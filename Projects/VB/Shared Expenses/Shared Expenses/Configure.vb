Public Class Configure
    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        ' Store configuration in registry
        Dim settings As New Settings
        ' Enable Voice recognition
        If (chkVoice.Checked) Then
            settings.Voice = 1
        Else
            settings.Voice = 0
        End If

        ' Agent information
        If (chkAgent.Checked) Then
            settings.Agent = 1
        Else
            settings.Agent = 0
        End If

        ' Cache path
        settings.CacheDir = txtCache.Text
        settings.Location = System.IO.Directory.GetCurrentDirectory() + "\Shared Expenses.exe"
        settings.RemoteDir = txtRemote.Text
        Me.Close()
    End Sub

    Private Sub Configure_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If chkVoice.Checked Then
            Common.EnableVoiceRecognition()
        Else
            Common.DisableVoiceRecognition()
        End If
        Shared_Expenses.Menu.Show()
    End Sub

    Private Sub Configure_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Common.SpeechEnabled Then
            chkVoice.Checked = True
        End If

        Dim settings As New Settings
        If (settings.Agent) Then
            chkAgent.Checked = True
            txtCache.Enabled = False
            cmdBrowse.Enabled = False
        End If
        txtCache.Text = settings.CacheDir
        txtRemote.Text = settings.RemoteDir
    End Sub

    Private Sub cmdBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBrowse.Click
        Dim dr As DialogResult
        If (txtCache.Text <> "") Then
            fbdBrowse.SelectedPath = txtCache.Text
        End If
        dr = fbdBrowse.ShowDialog()
        txtCache.Text = fbdBrowse.SelectedPath
    End Sub

    Private Sub chkAgent_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAgent.CheckedChanged
        If Not (chkAgent.Checked) Then
            txtCache.Enabled = False
            cmdBrowse.Enabled = False
        Else
            txtCache.Enabled = True
            cmdBrowse.Enabled = True
        End If
    End Sub
End Class