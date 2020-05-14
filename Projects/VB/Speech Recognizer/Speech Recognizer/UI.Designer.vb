<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUI
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
        Me.grpCommands = New System.Windows.Forms.GroupBox
        Me.lstCommands = New System.Windows.Forms.ListBox
        Me.grpSettings = New System.Windows.Forms.GroupBox
        Me.txtResponse = New System.Windows.Forms.TextBox
        Me.lblResponse = New System.Windows.Forms.Label
        Me.txtAction = New System.Windows.Forms.TextBox
        Me.lblAction = New System.Windows.Forms.Label
        Me.cboActionType = New System.Windows.Forms.ComboBox
        Me.lblActionType = New System.Windows.Forms.Label
        Me.txtPhrase = New System.Windows.Forms.TextBox
        Me.lblPhrase = New System.Windows.Forms.Label
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.cmdRemove = New System.Windows.Forms.Button
        Me.cmdUpdate = New System.Windows.Forms.Button
        Me.grpCommands.SuspendLayout()
        Me.grpSettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCommands
        '
        Me.grpCommands.Controls.Add(Me.lstCommands)
        Me.grpCommands.Location = New System.Drawing.Point(11, 10)
        Me.grpCommands.Name = "grpCommands"
        Me.grpCommands.Size = New System.Drawing.Size(132, 223)
        Me.grpCommands.TabIndex = 0
        Me.grpCommands.TabStop = False
        Me.grpCommands.Text = "Commands"
        '
        'lstCommands
        '
        Me.lstCommands.FormattingEnabled = True
        Me.lstCommands.Location = New System.Drawing.Point(6, 15)
        Me.lstCommands.Name = "lstCommands"
        Me.lstCommands.Size = New System.Drawing.Size(120, 199)
        Me.lstCommands.TabIndex = 1
        '
        'grpSettings
        '
        Me.grpSettings.Controls.Add(Me.txtResponse)
        Me.grpSettings.Controls.Add(Me.lblResponse)
        Me.grpSettings.Controls.Add(Me.txtAction)
        Me.grpSettings.Controls.Add(Me.lblAction)
        Me.grpSettings.Controls.Add(Me.cboActionType)
        Me.grpSettings.Controls.Add(Me.lblActionType)
        Me.grpSettings.Controls.Add(Me.txtPhrase)
        Me.grpSettings.Controls.Add(Me.lblPhrase)
        Me.grpSettings.Location = New System.Drawing.Point(149, 10)
        Me.grpSettings.Name = "grpSettings"
        Me.grpSettings.Size = New System.Drawing.Size(204, 223)
        Me.grpSettings.TabIndex = 1
        Me.grpSettings.TabStop = False
        Me.grpSettings.Text = "Command Settings"
        '
        'txtResponse
        '
        Me.txtResponse.Location = New System.Drawing.Point(74, 191)
        Me.txtResponse.Name = "txtResponse"
        Me.txtResponse.Size = New System.Drawing.Size(117, 20)
        Me.txtResponse.TabIndex = 6
        '
        'lblResponse
        '
        Me.lblResponse.AutoSize = True
        Me.lblResponse.Location = New System.Drawing.Point(10, 195)
        Me.lblResponse.Name = "lblResponse"
        Me.lblResponse.Size = New System.Drawing.Size(55, 13)
        Me.lblResponse.TabIndex = 8
        Me.lblResponse.Text = "Response"
        '
        'txtAction
        '
        Me.txtAction.Location = New System.Drawing.Point(9, 109)
        Me.txtAction.Multiline = True
        Me.txtAction.Name = "txtAction"
        Me.txtAction.Size = New System.Drawing.Size(182, 69)
        Me.txtAction.TabIndex = 5
        '
        'lblAction
        '
        Me.lblAction.AutoSize = True
        Me.lblAction.Location = New System.Drawing.Point(6, 93)
        Me.lblAction.Name = "lblAction"
        Me.lblAction.Size = New System.Drawing.Size(37, 13)
        Me.lblAction.TabIndex = 6
        Me.lblAction.Text = "Action"
        '
        'cboActionType
        '
        Me.cboActionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboActionType.FormattingEnabled = True
        Me.cboActionType.Items.AddRange(New Object() {"Select Action Type", "Click", "Double Click", "Right Click", "Key Press", "Execute"})
        Me.cboActionType.Location = New System.Drawing.Point(74, 59)
        Me.cboActionType.Name = "cboActionType"
        Me.cboActionType.Size = New System.Drawing.Size(117, 21)
        Me.cboActionType.TabIndex = 4
        '
        'lblActionType
        '
        Me.lblActionType.AutoSize = True
        Me.lblActionType.Location = New System.Drawing.Point(6, 63)
        Me.lblActionType.Name = "lblActionType"
        Me.lblActionType.Size = New System.Drawing.Size(64, 13)
        Me.lblActionType.TabIndex = 4
        Me.lblActionType.Text = "Action Type"
        '
        'txtPhrase
        '
        Me.txtPhrase.Location = New System.Drawing.Point(74, 29)
        Me.txtPhrase.Name = "txtPhrase"
        Me.txtPhrase.Size = New System.Drawing.Size(117, 20)
        Me.txtPhrase.TabIndex = 3
        '
        'lblPhrase
        '
        Me.lblPhrase.AutoSize = True
        Me.lblPhrase.Location = New System.Drawing.Point(6, 33)
        Me.lblPhrase.Name = "lblPhrase"
        Me.lblPhrase.Size = New System.Drawing.Size(40, 13)
        Me.lblPhrase.TabIndex = 2
        Me.lblPhrase.Text = "Phrase"
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(29, 239)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(75, 23)
        Me.cmdAdd.TabIndex = 2
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdRemove
        '
        Me.cmdRemove.Location = New System.Drawing.Point(143, 239)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(75, 23)
        Me.cmdRemove.TabIndex = 3
        Me.cmdRemove.Text = "Remove"
        Me.cmdRemove.UseVisualStyleBackColor = True
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Enabled = False
        Me.cmdUpdate.Location = New System.Drawing.Point(257, 239)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(75, 23)
        Me.cmdUpdate.TabIndex = 4
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'frmUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 272)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.cmdRemove)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.grpSettings)
        Me.Controls.Add(Me.grpCommands)
        Me.MaximizeBox = False
        Me.Name = "frmUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control Dashboard"
        Me.grpCommands.ResumeLayout(False)
        Me.grpSettings.ResumeLayout(False)
        Me.grpSettings.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpCommands As System.Windows.Forms.GroupBox
    Friend WithEvents lstCommands As System.Windows.Forms.ListBox
    Friend WithEvents grpSettings As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdRemove As System.Windows.Forms.Button
    Friend WithEvents cmdUpdate As System.Windows.Forms.Button
    Friend WithEvents txtPhrase As System.Windows.Forms.TextBox
    Friend WithEvents lblPhrase As System.Windows.Forms.Label
    Friend WithEvents cboActionType As System.Windows.Forms.ComboBox
    Friend WithEvents lblActionType As System.Windows.Forms.Label
    Friend WithEvents lblAction As System.Windows.Forms.Label
    Friend WithEvents txtAction As System.Windows.Forms.TextBox
    Friend WithEvents txtResponse As System.Windows.Forms.TextBox
    Friend WithEvents lblResponse As System.Windows.Forms.Label
End Class
