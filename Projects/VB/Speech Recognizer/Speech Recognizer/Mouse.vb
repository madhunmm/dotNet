Module Mouse
    Private Declare Sub mouse_event Lib "user32" Alias _
        "mouse_event" (ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtraInfo As Integer)
    Private Declare Sub keybd_event Lib "user32" Alias _
        "keybd_event" (ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As Integer, ByVal dwExtraInfo As Integer)

    Public Structure MouseLocation
        Dim x As Long
        Dim y As Long
    End Structure

    Private Const MOUSE_MOVED = &H1
    Private Const MOUSEEVENTF_ABSOLUTE = &H8000 '  absolute move
    Private Const MOUSEEVENTF_LEFTDOWN = &H2 '  left button down
    Private Const MOUSEEVENTF_LEFTUP = &H4 '  left button up
    Private Const MOUSEEVENTF_MIDDLEDOWN = &H20 '  middle button down
    Private Const MOUSEEVENTF_MIDDLEUP = &H40 '  middle button up
    Private Const MOUSEEVENTF_MOVE = &H1 '  mouse move
    Private Const MOUSEEVENTF_RIGHTDOWN = &H8 '  right button down
    Private Const MOUSEEVENTF_RIGHTUP = &H10 '  right button up

    Public Function CaptureMousePosition() As MouseLocation
        Dim pt As MouseLocation
        pt.x = System.Windows.Forms.Cursor.Position.X
        pt.y = System.Windows.Forms.Cursor.Position.Y
        CaptureMousePosition = pt
    End Function
    Public Sub LeftClick(ByVal xPos As Integer, ByVal yPos As Integer)
        ' Save current mouse location so that we can put it back where it was
        Dim curLoc As MouseLocation
        curLoc = CaptureMousePosition()

        Dim x, y As Integer
        x = xPos * 65535 / Screen.PrimaryScreen.Bounds.Width
        y = yPos * 65535 / Screen.PrimaryScreen.Bounds.Height
        mouse_event(MOUSEEVENTF_ABSOLUTE + MOUSEEVENTF_MOVE + MOUSEEVENTF_LEFTDOWN + MOUSEEVENTF_LEFTUP, x, y, 0, 0)

        ' Replace mouse
        x = curLoc.x * 65535 / Screen.PrimaryScreen.Bounds.Width
        y = curLoc.y * 65535 / Screen.PrimaryScreen.Bounds.Height
        mouse_event(MOUSEEVENTF_ABSOLUTE + MOUSEEVENTF_MOVE, x, y, 0, 0)
    End Sub

    Public Sub DoubleClick(ByVal xPos As Integer, ByVal yPos As Integer)
        LeftClick(xPos, yPos)
        LeftClick(xPos, yPos)
    End Sub

    Public Sub RightClick(ByVal xPos As Integer, ByVal yPos As Integer)
        ' Save current mouse location so that we can put it back where it was
        Dim curLoc As MouseLocation
        curLoc = CaptureMousePosition()

        Dim x, y As Integer
        x = xPos * 65535 / Screen.PrimaryScreen.Bounds.Width
        y = yPos * 65535 / Screen.PrimaryScreen.Bounds.Height
        mouse_event(MOUSEEVENTF_ABSOLUTE + MOUSEEVENTF_MOVE + MOUSEEVENTF_RIGHTDOWN + MOUSEEVENTF_RIGHTUP, x, y, 0, 0)

        ' Replace mouse
        x = curLoc.x * 65535 / Screen.PrimaryScreen.Bounds.Width
        y = curLoc.y * 65535 / Screen.PrimaryScreen.Bounds.Height
        mouse_event(MOUSEEVENTF_ABSOLUTE + MOUSEEVENTF_MOVE, x, y, 0, 0)
    End Sub

End Module
