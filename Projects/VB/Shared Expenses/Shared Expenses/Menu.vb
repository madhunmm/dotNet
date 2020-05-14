Public Class Menu
    Private m_db As System.IO.File
    Private m_debtList As ArrayList
    Private m_cacheDebtList As ArrayList

    Public ReadOnly Property DatabaseFile() As System.IO.File
        Get
            Return m_db
        End Get
    End Property

    Public Property Database() As ArrayList
        Get
            Return m_debtList
        End Get
        Set(ByVal value As ArrayList)
            m_debtList = value
        End Set
    End Property

    Public Property CacheDatabase() As ArrayList
        Get
            Return m_cacheDebtList
        End Get
        Set(ByVal value As ArrayList)
            m_cacheDebtList = value
        End Set
    End Property

    Private Sub cmdAddEntry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddEntry.Click
        AddEntry.Show()
        Me.Hide()
    End Sub

    Private Sub cmdViewSummary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdViewSummary.Click
        ViewSummary.Show()
        Me.Hide()
    End Sub

    Private Sub Menu_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If Common.Modified Then
            Dim retVal = MsgBox("Do you want to commit your changes?", MsgBoxStyle.YesNo)
            If retVal = MsgBoxResult.Yes Then

                Dim strCommitPath As String
                Dim alDB = Nothing
                Dim fileWriter As System.IO.StreamWriter

                Dim settings As New Settings
                If (settings.Agent) Then
                    strCommitPath = settings.CacheDir + "\" + Environment.MachineName + ".txt"
                    alDB = m_cacheDebtList
                    fileWriter = New System.IO.StreamWriter(strCommitPath, True)
                Else
                    strCommitPath = ".\Expenses.csv"
                    alDB = m_debtList
                    fileWriter = New System.IO.StreamWriter(strCommitPath)
                End If

                Dim dbo As DBObject
                Dim ps As PersonStatus
                ' Commit all changes
                Dim bCanBeWritten As Boolean = False

                For Each dbo In alDB
                    ' If the entry is flagged for archiving but the list 
                    ' is still young for archiving
                    If (dbo.Archived And Common.ArchivingRequired) Then
                        bCanBeWritten = False
                    ElseIf (dbo.Archived And Not Common.ArchivingRequired) Then
                        bCanBeWritten = True
                    ElseIf (Not dbo.Archived And Common.ArchivingRequired) Then
                        bCanBeWritten = True
                    ElseIf (Not dbo.Archived And Not Common.ArchivingRequired) Then
                        bCanBeWritten = True
                    End If

                    If bCanBeWritten Then
                        Dim line As String
                        line = dbo.Person + "," + _
                               dbo.ExpenseType + "," + _
                               dbo.Amount.ToString() + "," + _
                               dbo.EntryDate
                        For Each ps In dbo.SharedMembers
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
            End If

            If Common.ArchivingRequired Then
                Common.Archive()
            End If

        End If
    End Sub

    Private Sub Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Update registry information
        Dim settings As New Settings
        settings.Location = System.IO.Directory.GetCurrentDirectory() + "\Shared Expenses.exe"
        If (settings.Agent) Then
            cmdMerge.Enabled = False
        End If

        m_debtList = New ArrayList()
        m_cacheDebtList = New ArrayList()
        Common.ArchivingRequired = False

        If (FileIO.FileSystem.FileExists(".\Expenses.csv")) Then
            Dim fileReader As New System.IO.StreamReader(".\Expenses.csv")

            Dim line As String
            Dim params() As String

            Dim bCleared As Boolean
            Dim iClearedEntries As Integer = 0

            While (fileReader.EndOfStream = False)

                bCleared = True ' Flag to check whether an entry is fit for archiving

                line = fileReader.ReadLine()
                params = Split(line, ",")
                Dim entry As New DBObject
                entry.Person = params(0)                    ' Person
                entry.ExpenseType = params(1)               ' Expense type
                entry.Amount = params(2)                    ' Amount
                entry.EntryDate = params(3)                 ' Date
                entry.Archived = False                      ' Archived?
                entry.SharedMembers = New ArrayList()

                Dim personCount As Integer
                personCount = (UBound(params) - 3) / 2
                For index = 4 To UBound(params) Step 2

                    ' Person status
                    Dim ps As New PersonStatus
                    ps.Person = params(index)               ' debtee
                    ps.Amount = Math.Round(entry.Amount / personCount, 2)  ' Amount(individual)
                    If (params(index + 1) = "Yes") Then     ' Paid?
                        ps.Paid = True
                    Else
                        ps.Paid = False
                        ' Check for archiving
                        If ps.Person <> entry.Person Then
                            bCleared = False
                        End If
                    End If
                    entry.SharedMembers.Add(ps)
                Next

                If bCleared Then
                    iClearedEntries = iClearedEntries + 1
                    entry.Archived = True
                End If

                m_debtList.Add(entry)
            End While

            ' Check if OK for archiving
            If iClearedEntries >= 30 Then
                Common.ArchivingRequired = True
            End If

            fileReader.Close()
        End If
    End Sub

    Private Sub cmdConfigure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConfigure.Click
        Configure.Show()
        Me.Hide()
    End Sub

    Private Sub cmdMerge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMerge.Click
        MergeDatabase.Show()
        Me.Hide()
    End Sub
End Class

