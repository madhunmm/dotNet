Module SpeechOperations
    Public Sub HandleCommand(ByRef mn As MapNode)
        If (mn.Action.ToLower = "mouseleftclick") Then
            Dim xPos, yPos As Integer
            xPos = Integer.Parse(mn.Parameters(0))
            yPos = Integer.Parse(mn.Parameters(1))
            Mouse.LeftClick(xPos, yPos)

        ElseIf (mn.Action.ToLower = "mouserightclick") Then
            Dim xPos, yPos As Integer
            xPos = Integer.Parse(mn.Parameters(0))
            yPos = Integer.Parse(mn.Parameters(1))
            Mouse.RightClick(xPos, yPos)

        ElseIf (mn.Action.ToLower = "mousedoubleclick") Then
            Dim xPos, yPos As Integer
            xPos = Integer.Parse(mn.Parameters(0))
            yPos = Integer.Parse(mn.Parameters(1))
            Mouse.DoubleClick(xPos, yPos)

        ElseIf (mn.Action.ToLower = "keypress") Then
            ' Will require some parsing..Only in Version 2
            Keyboard.PressKeyVK(enumKeys.keyControl, True)
            Keyboard.PressKeyVK(enumKeys.keyAlt, True)
            Keyboard.PressKey("A")
            Keyboard.PressKeyVK(enumKeys.keyControl, , True)
            Keyboard.PressKeyVK(enumKeys.keyAlt, , True)
        ElseIf (mn.Action.ToLower = "execute") Then
            ' Open up the Shell and go go go..
            Dim strExecPath As String
            strExecPath = """" + mn.Parameters(0) + """"

            'If (My.Computer.FileSystem.FileExists(strExecPath)) Then
            Try
                Microsoft.VisualBasic.Interaction.Shell(strExecPath, AppWinStyle.MaximizedFocus, False)
            Catch ex As Exception
                ' Do logging here..
            End Try
            'End If

        End If
    End Sub
End Module
