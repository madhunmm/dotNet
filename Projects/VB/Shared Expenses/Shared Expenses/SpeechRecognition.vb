Public Class SpeechRecognition
    Private sg As New SpeechGrammar

    Dim WithEvents rc As SpeechLib.SpSharedRecoContext
    Dim WithEvents tts As SpeechLib.SpVoice
    Dim m_grammar As SpeechLib.ISpeechRecoGrammar

    Dim optionalList() As String = {"How", "much", "does", "owe", "to", "should", "give"}

    Public ReadOnly Property Grammar() As SpeechGrammar
        Get
            Return sg
        End Get
    End Property

    Public Sub New()
        sg.Xml = ".\Commands.xml"
        sg.Initialize()

        ' Load the Speech Engine
        Try
            rc = New SpeechLib.SpSharedRecoContext

            m_grammar = rc.CreateGrammar
            m_grammar.CmdLoadFromFile(sg.Xml, SpeechLib.SpeechLoadOption.SLOStatic)
            m_grammar.CmdSetRuleIdState(0, SpeechLib.SpeechRuleState.SGDSActive)
            tts = New SpeechLib.SpVoice
        Catch
            ' Just ignore for the time.
        End Try

    End Sub
    Private Sub rc_Recognition(ByVal StreamNumber As Integer, ByVal StreamPosition As Object, ByVal RecognitionType As SpeechLib.SpeechRecognitionType, ByVal Result As SpeechLib.ISpeechRecoResult) Handles rc.Recognition
        Dim command As String
        Dim fromPerson, toPerson As String

        fromPerson = ""
        toPerson = ""
        command = Result.PhraseInfo.GetText()

        ' Here, parse the from and to persons
        Dim tokens() As String = Split(command, " ")
        For Each token As String In tokens
            Dim bOptional As Boolean = False
            For Each optionalString As String In optionalList
                If token = optionalString Then
                    bOptional = True
                    Exit For
                End If
            Next
            If Not bOptional Then
                If fromPerson = "" Then
                    fromPerson = token
                Else
                    toPerson = token
                End If
            End If
        Next

        ' Pass the from and to persons to the Summary form
        Dim amount As Double = ViewSummary.CalculateAmount(fromPerson, toPerson)

        ' Speak it out
        tts.Speak(Math.Round(amount, 2))
    End Sub
    Public Sub ReloadGrammar()
        Try
            ' Reload Speech Engine Grammar
            m_grammar.CmdLoadFromFile(sg.Xml, SpeechLib.SpeechLoadOption.SLODynamic)
            m_grammar.CmdSetRuleIdState(0, SpeechLib.SpeechRuleState.SGDSActive)
        Catch
            ' Don't do anything
        End Try
    End Sub
    Public Sub Disable()
        Try
            ' Disable Speech Engine Grammar
            m_grammar.CmdSetRuleIdState(0, SpeechLib.SpeechRuleState.SGDSInactive)
        Catch
            ' Don't do anything
        End Try
    End Sub
End Class
