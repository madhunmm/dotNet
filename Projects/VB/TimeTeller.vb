Public Class Form1
    Dim WithEvents rc As SpeechLib.SpSharedRecoContext
    Dim WithEvents tts As SpeechLib.SpVoice
    Dim grammar As SpeechLib.ISpeechRecoGrammar

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rc = New SpeechLib.SpSharedRecoContext
        tts = New SpeechLib.SpVoice
        grammar = rc.CreateGrammar
        grammar.CmdLoadFromFile("..\..\getTime.xml", SpeechLib.SpeechLoadOption.SLOStatic)
        grammar.CmdSetRuleIdState(0, SpeechLib.SpeechRuleState.SGDSActive)
    End Sub

    Private Sub rc_Recognition(ByVal StreamNumber As Integer, ByVal StreamPosition As Object, ByVal RecognitionType As SpeechLib.SpeechRecognitionType, ByVal Result As SpeechLib.ISpeechRecoResult) Handles rc.Recognition
        Dim dt As System.DateTime = DateTime.Now
        MsgBox(dt.TimeOfDay.ToString)
    End Sub
End Class
