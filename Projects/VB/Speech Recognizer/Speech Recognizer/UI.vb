Public Class frmUI
    Private cm As New CommandMap
    Private sg As New SpeechGrammar

    Dim WithEvents rc As SpeechLib.SpSharedRecoContext
    Dim WithEvents tts As SpeechLib.SpVoice
    Dim grammar As SpeechLib.ISpeechRecoGrammar

    Private Sub frmUI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cm.Load()
        sg.Xml = ".\Commands.xml"
        sg.Initialize()
        LoadDefaultCommands()

        ' Populate the commands list
        FillCommandList()

        ' Load the Speech Engine
        rc = New SpeechLib.SpSharedRecoContext

        grammar = rc.CreateGrammar
        grammar.CmdLoadFromFile(sg.Xml, SpeechLib.SpeechLoadOption.SLOStatic)
        grammar.CmdSetRuleIdState(0, SpeechLib.SpeechRuleState.SGDSActive)

    End Sub

    Private Sub lstCommands_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCommands.SelectedIndexChanged
        Dim mn As MapNode
        mn = cm.SearchCommand(lstCommands.SelectedItem)
        If (Not IsNothing(mn)) Then
            txtPhrase.Text = mn.Command
            txtResponse.Text = mn.Response
            cboActionType.Text = CodeToUI(mn.Action)
            txtAction.Text = ""
            For index = 0 To mn.Parameters.Length - 1
                If (index <> 0) Then
                    txtAction.Text = txtAction.Text + ","
                End If
                txtAction.Text = txtAction.Text + mn.Parameters(index)
            Next
        End If
    End Sub

    Private Function CodeToUI(ByVal at As String) As String
        If (at = "mouseleftclick") Then
            CodeToUI = "Click"
        ElseIf (at = "mousedoubleclick") Then
            CodeToUI = "Double Click"
        ElseIf (at = "mouserightclick") Then
            CodeToUI = "Right Click"
        ElseIf (at = "keypress") Then
            CodeToUI = "Key Press"
        ElseIf (at = "execute") Then
            CodeToUI = "Execute"
        Else
            CodeToUI = ""
        End If
    End Function

    Private Function UIToCode(ByVal at As String) As String
        If (at = "Click") Then
            UIToCode = "mouseleftclick"
        ElseIf (at = "Double Click") Then
            UIToCode = "mousedoubleclick"
        ElseIf (at = "Right Click") Then
            UIToCode = "mouserightclick"
        ElseIf (at = "Key Press") Then
            UIToCode = "keypress"
        ElseIf (at = "Execute") Then
            UIToCode = "execute"
        Else
            UIToCode = ""
        End If
    End Function

    Private Sub FillCommandList()
        lstCommands.Items.Clear()
        Dim commands() As String
        commands = sg.GetRulesList()
        For index = 0 To commands.Length - 1
            lstCommands.Items.Add(commands(index))
        Next
    End Sub

    Private Sub txtPhrase_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPhrase.TextChanged
        cmdUpdate.Enabled = True
    End Sub

    Private Sub cmdRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemove.Click
        ' Remove rule from Grammar
        sg.RemoveRule(lstCommands.SelectedItem)

        ' Reload Speech engine grammar
        grammar.CmdLoadFromFile(sg.Xml, SpeechLib.SpeechLoadOption.SLOStatic)
        grammar.CmdSetRuleIdState(0, SpeechLib.SpeechRuleState.SGDSActive)

        cm.RemoveCommand(lstCommands.SelectedItem)
        FillCommandList()
        txtAction.Text = ""
        txtPhrase.Text = ""
        txtResponse.Text = ""
        cboActionType.Text = ""
    End Sub

    Private Sub rc_Recognition(ByVal StreamNumber As Integer, ByVal StreamPosition As Object, ByVal RecognitionType As SpeechLib.SpeechRecognitionType, ByVal Result As SpeechLib.ISpeechRecoResult) Handles rc.Recognition
        Dim command As String
        Dim mn As MapNode

        command = Result.PhraseInfo.GetText()

        mn = cm.SearchCommand(command)
        If (Not IsNothing(mn)) Then
            If (Not mn.UICommand) Then
                SpeechOperations.HandleCommand(mn)
            Else
                Me.HandleCommand(mn)
            End If
            ' Speak out the response
            If (mn.Response <> "") Then
                tts = New SpeechLib.SpVoice
                tts.Speak(mn.Response)
            End If

        End If
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        ' Add rule to grammar
        sg.AddRule(txtPhrase.Text)

        ' Reload Speech Engine Grammar
        grammar.CmdLoadFromFile(sg.Xml, SpeechLib.SpeechLoadOption.SLODynamic)
        grammar.CmdSetRuleIdState(0, SpeechLib.SpeechRuleState.SGDSActive)

        ' Add rule to Command Map
        Dim params() As String
        params = Split(txtAction.Text, ",")
        cm.AddCommand(txtPhrase.Text, UIToCode(cboActionType.Text), txtResponse.Text, False, params)

        FillCommandList()
        txtAction.Text = ""
        txtPhrase.Text = ""
        txtResponse.Text = ""
        cboActionType.Text = "Select Action Type"
    End Sub

    Private Sub HandleCommand(ByRef mn As MapNode)
        If (mn.Command = "Add mouse click") Then
            Dim loc As Mouse.MouseLocation
            loc = Mouse.CaptureMousePosition()
            txtAction.Text = loc.x.ToString() + "," + loc.y.ToString()
            'ElseIf (mn.Command = "Stand By") Then
            '    rc.Pause()
            'ElseIf (mn.Command = "Computer") Then
            '    rc.Resume()
        End If
    End Sub

    Private Sub LoadDefaultCommands()
        sg.AddRule("Add mouse click")
        cm.AddCommand("Add mouse click", "", "", True)

        sg.AddRule("Stand By")
        cm.AddCommand("Stand By", "", "", True)

        sg.AddRule("Computer")
        cm.AddCommand("Computer", "", "", True)
    End Sub

    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        Dim strPhrase As String
        strPhrase = txtPhrase.Text
        cm.RemoveCommand(strPhrase)

        Dim params() As String
        params = Split(txtAction.Text, ",")
        cm.AddCommand(strPhrase, UIToCode(cboActionType.Text), txtResponse.Text, False, txtAction.Text)
    End Sub
End Class

