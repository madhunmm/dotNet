Public Class Form1
    Dim cm As New CommandMap
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        TestMouseClick()

        'TestCommandMap()
        'TestSpeechGrammar()
    End Sub

    Private Sub TestCommandMap()
        Dim cm As New CommandMap
        cm.Load()
        cm.AddCommand("test", "mouseleftclick", "ok", 123, 456)
        cm.AddCommand("madhu", "KeyPress", "sure", "ctrl + alt + delete")
        cm.AddCommand("voice", "Execute", "no problemo", "Just testing")
        cm.AddCommand("ca", "mouseleftclick", "okay", 56, 78)


        'cm.RemoveCommand("voice")
        'cm.RemoveCommand("madhu")
        cm.Save()
    End Sub

    Private Sub TestSpeechGrammar()
        Dim sg As New SpeechGrammar
        sg.Xml = ".\Commands.xml"
        sg.Initialize()
        sg.AddRule("madhu")
        sg.AddRule("test")
        sg.AddRule("ca")
        sg.AddRule("voice")

        Dim rList As Array
        rList = sg.GetRulesList()
        For Each srule In rList
            System.Console.WriteLine(srule)
        Next

        'sg.RemoveRule("test")
        'sg.RemoveRule("ca")

        'rList = sg.GetRulesList()
        'For Each srule In rList
        '    System.Console.WriteLine(srule)
        'Next
    End Sub

    Private Sub TestMouseClick()
        Dim loc As Mouse.MouseLocation
        loc = Mouse.CaptureMousePosition()
        txtLocation.Text = loc.x.ToString() + "," + loc.y.ToString()

        Dim location() As String
        location = Split(txtLocation.Text, ",")


        cm.AddCommand(txtCommand.Text, "mousedoubleclick", "", False, location)

        Dim sg As New SpeechGrammar
        sg.Xml = ".\Commands.xml"
        sg.Initialize()
        sg.AddRule(txtCommand.Text)
    End Sub

    Private Sub cmdRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRun.Click
        Dim cmd As String
        cmd = txtCommand.Text

        'Dim x As New CommandMap
        Dim y As MapNode
        y = cm.SearchCommand(cmd)

        SpeechOperations.HandleCommand(y)
    End Sub
End Class
