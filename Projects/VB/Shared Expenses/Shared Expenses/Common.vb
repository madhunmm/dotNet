Module Common
    Private srVoiceRecognizer As SpeechRecognition
    Private bModified, _
            bArchivingRequired, _
            bSpeechEnabled As Boolean

    Public Property SpeechEnabled() As Boolean
        Get
            Return bSpeechEnabled
        End Get
        Set(ByVal value As Boolean)
            bSpeechEnabled = value
        End Set
    End Property

    Public Property Modified() As Boolean
        Get
            Return bModified
        End Get
        Set(ByVal value As Boolean)
            bModified = value
        End Set
    End Property

    Public Property ArchivingRequired() As Boolean
        Get
            Return bArchivingRequired
        End Get
        Set(ByVal value As Boolean)
            bArchivingRequired = value
        End Set
    End Property

    Public Sub EnableVoiceRecognition()
        Dim personList As New ArrayList
        srVoiceRecognizer = New SpeechRecognition

        For Each dbo As DBObject In Menu.Database
            ' Populate the person list and debtee list (both are the same)
            If Not personList.Contains(dbo.Person) Then
                personList.Add(dbo.Person)
            End If

            For Each ps As PersonStatus In dbo.SharedMembers
                If Not personList.Contains(ps.Person) Then
                    personList.Add(ps.Person)
                End If
            Next
        Next

        For Each fromPerson As String In personList
            For Each toPerson As String In personList
                If fromPerson <> toPerson Then
                    srVoiceRecognizer.Grammar.AddRule(fromPerson, toPerson)
                End If
            Next
        Next

        ' Reload Speech Engine Grammar
        srVoiceRecognizer.ReloadGrammar()
        bSpeechEnabled = True
    End Sub

    Public Sub DisableVoiceRecognition()
        If Not IsNothing(srVoiceRecognizer) Then
            srVoiceRecognizer.Disable()
            bSpeechEnabled = False
        End If
    End Sub

    Public Sub Archive()
        ' Only non agents
        Dim settings As New Settings
        If Not (settings.Agent) Then
            ' Archive all old entries
            ' Check if Archive folder exists
            If Not FileIO.FileSystem.DirectoryExists(".\Archives") Then
                FileIO.FileSystem.CreateDirectory(".\Archives")
            End If
            ' Create a new Archive file with date
            Dim strNewArchiveFile As String
            strNewArchiveFile = ".\Archives\" + Date.Today.ToShortDateString() + ".csv"

            Dim fileWriter As New System.IO.StreamWriter(strNewArchiveFile, True)
            For Each dbo As DBObject In Shared_Expenses.Menu.Database
                ' Check if this entry is OK for archiving
                If dbo.Archived Then
                    Dim line As String
                    line = dbo.Person + "," + _
                           dbo.ExpenseType + "," + _
                           dbo.Amount.ToString() + "," + _
                           dbo.EntryDate
                    For Each ps As PersonStatus In dbo.SharedMembers
                        line = line + "," + ps.Person
                        If ps.Paid = True Then
                            line = line + ",Yes"
                        Else
                            line = line + ",No"
                        End If
                    Next

                    fileWriter.WriteLine(line)
                End If
            Next
            fileWriter.Flush()
            fileWriter.Close()
            bModified = True
        End If
    End Sub

    Public Sub WriteToDatabase(ByRef strDBFile As String, ByRef dbo As DBObject, ByVal bAppend As Boolean)
        ' Implement this in the future for performing all file writes to one location.
    End Sub
End Module

' Helper classes
Public Class PersonStatus
    Private m_person As String
    Private m_amount As Double
    Private m_bPaid As Boolean

    Public Property Person() As String
        Get
            Return m_person
        End Get
        Set(ByVal value As String)
            m_person = value
        End Set
    End Property

    Public Property Amount() As Double
        Get
            Return m_amount
        End Get
        Set(ByVal value As Double)
            m_amount = value
        End Set
    End Property

    Public Property Paid() As Boolean
        Get
            Return m_bPaid
        End Get
        Set(ByVal value As Boolean)
            m_bPaid = value
        End Set
    End Property
End Class

Public Class DBObject
    Dim m_person As String
    Dim m_expenseType As String
    Dim m_amount As Double
    Dim m_sharedMembers As ArrayList
    Dim m_date As String
    Dim m_bArchived As Boolean

    Public Property Person() As String
        Get
            Return m_person
        End Get
        Set(ByVal value As String)
            m_person = value
        End Set
    End Property

    Public Property ExpenseType() As String
        Get
            Return m_expenseType
        End Get
        Set(ByVal value As String)
            m_expenseType = value
        End Set
    End Property

    Public Property Amount() As Double
        Get
            Return m_amount
        End Get
        Set(ByVal value As Double)
            m_amount = value
        End Set
    End Property

    Public Property SharedMembers() As ArrayList
        Get
            Return m_sharedMembers
        End Get
        Set(ByVal value As ArrayList)
            m_sharedMembers = value
        End Set
    End Property

    Public Property EntryDate() As String
        Get
            Return m_date
        End Get
        Set(ByVal value As String)
            m_date = value
        End Set
    End Property

    Public Property Archived() As Boolean
        Get
            Return m_bArchived
        End Get
        Set(ByVal value As Boolean)
            m_bArchived = value
        End Set
    End Property
End Class

' Registry accessors
Public Class Settings
    Private m_RegKey As String = "Software\Shared Expenses"
    Private CacheMoniker As String = "Cache"
    Private LocationMoniker As String = "Location"
    Private AgentMoniker As String = "Agent"
    Private VoiceMoniker As String = "Speech"
    Private RemoteMoniker As String = "ServerCache"
    Private rk As RegistryKey

    Public Property CacheDir() As String
        Get
            rk = GetRegistry()
            If Not rk Is Nothing Then
                Return rk.GetValue(CacheMoniker)
                rk.Close()
            End If
            Return ""
        End Get
        Set(ByVal value As String)
            rk = GetRegistry()
            If Not rk Is Nothing Then
                rk.SetValue(CacheMoniker, value, RegistryValueKind.String)
                rk.Close()
            End If
        End Set
    End Property

    Public Property Location() As String
        Get
            rk = GetRegistry()
            If Not rk Is Nothing Then
                Return rk.GetValue(LocationMoniker)
                rk.Close()
            End If
            Return ""
        End Get
        Set(ByVal value As String)
            rk = GetRegistry()
            If Not rk Is Nothing Then
                rk.SetValue(LocationMoniker, value, RegistryValueKind.String)
                rk.Close()
            End If
        End Set
    End Property

    Public Property RemoteDir() As String
        Get
            rk = GetRegistry()
            If Not rk Is Nothing Then
                Return rk.GetValue(RemoteMoniker)
                rk.Close()
            End If
            Return ""
        End Get
        Set(ByVal value As String)
            rk = GetRegistry()
            If Not rk Is Nothing Then
                rk.SetValue(RemoteMoniker, value, RegistryValueKind.String)
                rk.Close()
            End If
        End Set
    End Property

    Public Property Agent() As Boolean
        Get
            rk = GetRegistry()
            If Not rk Is Nothing Then
                Return rk.GetValue(AgentMoniker)
                rk.Close()
            End If
        End Get
        Set(ByVal value As Boolean)
            rk = GetRegistry()
            If Not rk Is Nothing Then
                rk.SetValue(AgentMoniker, value, RegistryValueKind.DWord)
                rk.Close()
            End If
        End Set
    End Property

    Public Property Voice() As Boolean
        Get
            rk = GetRegistry()
            If Not rk Is Nothing Then
                Return rk.GetValue(VoiceMoniker)
                rk.Close()
            End If
        End Get
        Set(ByVal value As Boolean)
            rk = GetRegistry()
            If Not rk Is Nothing Then
                rk.SetValue(VoiceMoniker, value, RegistryValueKind.DWord)
                rk.Close()
            End If
        End Set
    End Property

    Private Function GetRegistry() As RegistryKey
        GetRegistry = Registry.CurrentUser.OpenSubKey(m_RegKey, True)
        If (GetRegistry Is Nothing) Then
            Registry.CurrentUser.CreateSubKey(m_RegKey).Close()
            GetRegistry = Registry.CurrentUser.OpenSubKey(m_RegKey, True)
        End If
    End Function

End Class