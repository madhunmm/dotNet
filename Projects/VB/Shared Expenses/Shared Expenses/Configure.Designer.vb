<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Configure
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpOptions = New System.Windows.Forms.GroupBox
        Me.cmdBrowse = New System.Windows.Forms.Button
        Me.txtCache = New System.Windows.Forms.TextBox
        Me.lblCache = New System.Windows.Forms.Label
        Me.chkAgent = New System.Windows.Forms.CheckBox
        Me.chkVoice = New System.Windows.Forms.CheckBox
        Me.cmdOK = New System.Windows.Forms.Button
        Me.fbdBrowse = New System.Windows.Forms.FolderBrowserDialog
        Me.txtRemote = New System.Windows.Forms.TextBox
        Me.lblRemote = New System.Windows.Forms.Label
        Me.grpOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.txtRemote)
        Me.grpOptions.Controls.Add(Me.lblRemote)
        Me.grpOptions.Controls.Add(Me.cmdBrowse)
        Me.grpOptions.Controls.Add(Me.txtCache)
        Me.grpOptions.Controls.Add(Me.lblCache)
        Me.grpOptions.Controls.Add(Me.chkAgent)
        Me.grpOptions.Controls.Add(Me.chkVoice)
        Me.grpOptions.Location = New System.Drawing.Point(12, 12)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(251, 193)
        Me.grpOptions.TabIndex = 1
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(215, 110)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(30, 20)
        Me.cmdBrowse.TabIndex = 5
        Me.cmdBrowse.Text = "..."
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'txtCache
        '
        Me.txtCache.Location = New System.Drawing.Point(21, 110)
        Me.txtCache.Name = "txtCache"
        Me.txtCache.Size = New System.Drawing.Size(188, 20)
        Me.txtCache.TabIndex = 4
        '
        'lblCache
        '
        Me.lblCache.AutoSize = True
        Me.lblCache.Location = New System.Drawing.Point(18, 94)
        Me.lblCache.Name = "lblCache"
        Me.lblCache.Size = New System.Drawing.Size(67, 13)
        Me.lblCache.TabIndex = 3
        Me.lblCache.Text = "Cache folder"
        '
        'chkAgent
        '
        Me.chkAgent.AutoSize = True
        Me.chkAgent.Location = New System.Drawing.Point(21, 61)
        Me.chkAgent.Name = "chkAgent"
        Me.chkAgent.Size = New System.Drawing.Size(90, 17)
        Me.chkAgent.TabIndex = 2
        Me.chkAgent.Text = "Run as agent"
        Me.chkAgent.UseVisualStyleBackColor = True
        '
        'chkVoice
        '
        Me.chkVoice.AutoSize = True
        Me.chkVoice.Location = New System.Drawing.Point(21, 28)
        Me.chkVoice.Name = "chkVoice"
        Me.chkVoice.Size = New System.Drawing.Size(144, 17)
        Me.chkVoice.TabIndex = 1
        Me.chkVoice.Text = "Enable Voice recognition"
        Me.chkVoice.UseVisualStyleBackColor = True
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(104, 211)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(55, 23)
        Me.cmdOK.TabIndex = 2
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'fbdBrowse
        '
        Me.fbdBrowse.Description = "Select the cache folder to store the entries"
        '
        'txtRemote
        '
        Me.txtRemote.Location = New System.Drawing.Point(21, 158)
        Me.txtRemote.Name = "txtRemote"
        Me.txtRemote.Size = New System.Drawing.Size(188, 20)
        Me.txtRemote.TabIndex = 7
        '
        'lblRemote
        '
        Me.lblRemote.AutoSize = True
        Me.lblRemote.Location = New System.Drawing.Point(18, 142)
        Me.lblRemote.Name = "lblRemote"
        Me.lblRemote.Size = New System.Drawing.Size(73, 13)
        Me.lblRemote.TabIndex = 6
        Me.lblRemote.Text = "Remote folder"
        '
        'Configure
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 246)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.grpOptions)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(283, 280)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(283, 280)
        Me.Name = "Configure"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configure"
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpOptions As System.Windows.Forms.GroupBox
    Friend WithEvents chkVoice As System.Windows.Forms.CheckBox
    Friend WithEvents cmdOK As System.Windows.Forms.Button
    Friend WithEvents cmdBrowse As System.Windows.Forms.Button
    Friend WithEvents txtCache As System.Windows.Forms.TextBox
    Friend WithEvents lblCache As System.Windows.Forms.Label
    Friend WithEvents chkAgent As System.Windows.Forms.CheckBox
    Friend WithEvents fbdBrowse As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents txtRemote As System.Windows.Forms.TextBox
    Friend WithEvents lblRemote As System.Windows.Forms.Label
End Class
