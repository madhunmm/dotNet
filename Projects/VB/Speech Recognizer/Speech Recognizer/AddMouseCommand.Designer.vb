<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtLocation = New System.Windows.Forms.TextBox
        Me.cmdSave = New System.Windows.Forms.Button
        Me.lblLocation = New System.Windows.Forms.Label
        Me.lblCommand = New System.Windows.Forms.Label
        Me.txtCommand = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboClickType = New System.Windows.Forms.ComboBox
        Me.cmdRun = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(73, 45)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(114, 20)
        Me.txtLocation.TabIndex = 0
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(37, 114)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(52, 23)
        Me.cmdSave.TabIndex = 3
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Location = New System.Drawing.Point(12, 49)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(48, 13)
        Me.lblLocation.TabIndex = 4
        Me.lblLocation.Text = "Location"
        '
        'lblCommand
        '
        Me.lblCommand.AutoSize = True
        Me.lblCommand.Location = New System.Drawing.Point(12, 19)
        Me.lblCommand.Name = "lblCommand"
        Me.lblCommand.Size = New System.Drawing.Size(46, 13)
        Me.lblCommand.TabIndex = 5
        Me.lblCommand.Text = "Comand"
        '
        'txtCommand
        '
        Me.txtCommand.Location = New System.Drawing.Point(73, 15)
        Me.txtCommand.Name = "txtCommand"
        Me.txtCommand.Size = New System.Drawing.Size(114, 20)
        Me.txtCommand.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Click Type"
        '
        'cboClickType
        '
        Me.cboClickType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboClickType.FormattingEnabled = True
        Me.cboClickType.Items.AddRange(New Object() {"Click", "Double Click", "Right Click"})
        Me.cboClickType.Location = New System.Drawing.Point(73, 76)
        Me.cboClickType.Name = "cboClickType"
        Me.cboClickType.Size = New System.Drawing.Size(114, 21)
        Me.cboClickType.TabIndex = 8
        '
        'cmdRun
        '
        Me.cmdRun.Location = New System.Drawing.Point(95, 114)
        Me.cmdRun.Name = "cmdRun"
        Me.cmdRun.Size = New System.Drawing.Size(50, 23)
        Me.cmdRun.TabIndex = 9
        Me.cmdRun.Text = "Run"
        Me.cmdRun.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(199, 149)
        Me.Controls.Add(Me.cmdRun)
        Me.Controls.Add(Me.cboClickType)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCommand)
        Me.Controls.Add(Me.lblCommand)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.txtLocation)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Mouse Click"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents lblLocation As System.Windows.Forms.Label
    Friend WithEvents lblCommand As System.Windows.Forms.Label
    Friend WithEvents txtCommand As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboClickType As System.Windows.Forms.ComboBox
    Friend WithEvents cmdRun As System.Windows.Forms.Button

End Class
