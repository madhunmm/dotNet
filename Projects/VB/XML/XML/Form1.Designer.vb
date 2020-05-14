<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddRule
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
        Me.lblOpt = New System.Windows.Forms.Label
        Me.lblPhrase = New System.Windows.Forms.Label
        Me.txtOptional = New System.Windows.Forms.TextBox
        Me.btnAddOpt = New System.Windows.Forms.Button
        Me.lstOptional = New System.Windows.Forms.ListBox
        Me.lstPhrase = New System.Windows.Forms.ListBox
        Me.btnAddPhr = New System.Windows.Forms.Button
        Me.txtPhrase = New System.Windows.Forms.TextBox
        Me.chkTopLevel = New System.Windows.Forms.CheckBox
        Me.btnInsert = New System.Windows.Forms.Button
        Me.btnRemOpt = New System.Windows.Forms.Button
        Me.btnRemPhr = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblOpt
        '
        Me.lblOpt.AutoSize = True
        Me.lblOpt.Location = New System.Drawing.Point(33, 29)
        Me.lblOpt.Name = "lblOpt"
        Me.lblOpt.Size = New System.Drawing.Size(46, 13)
        Me.lblOpt.TabIndex = 3
        Me.lblOpt.Text = "Optional"
        '
        'lblPhrase
        '
        Me.lblPhrase.AutoSize = True
        Me.lblPhrase.Location = New System.Drawing.Point(33, 137)
        Me.lblPhrase.Name = "lblPhrase"
        Me.lblPhrase.Size = New System.Drawing.Size(40, 13)
        Me.lblPhrase.TabIndex = 4
        Me.lblPhrase.Text = "Phrase"
        '
        'txtOptional
        '
        Me.txtOptional.Location = New System.Drawing.Point(98, 26)
        Me.txtOptional.Name = "txtOptional"
        Me.txtOptional.Size = New System.Drawing.Size(100, 20)
        Me.txtOptional.TabIndex = 5
        '
        'btnAddOpt
        '
        Me.btnAddOpt.Location = New System.Drawing.Point(204, 23)
        Me.btnAddOpt.Name = "btnAddOpt"
        Me.btnAddOpt.Size = New System.Drawing.Size(57, 23)
        Me.btnAddOpt.TabIndex = 6
        Me.btnAddOpt.Text = "Add"
        Me.btnAddOpt.UseVisualStyleBackColor = True
        '
        'lstOptional
        '
        Me.lstOptional.FormattingEnabled = True
        Me.lstOptional.Location = New System.Drawing.Point(98, 52)
        Me.lstOptional.Name = "lstOptional"
        Me.lstOptional.Size = New System.Drawing.Size(100, 69)
        Me.lstOptional.TabIndex = 7
        '
        'lstPhrase
        '
        Me.lstPhrase.FormattingEnabled = True
        Me.lstPhrase.Location = New System.Drawing.Point(98, 157)
        Me.lstPhrase.Name = "lstPhrase"
        Me.lstPhrase.Size = New System.Drawing.Size(100, 69)
        Me.lstPhrase.TabIndex = 10
        '
        'btnAddPhr
        '
        Me.btnAddPhr.Location = New System.Drawing.Point(204, 129)
        Me.btnAddPhr.Name = "btnAddPhr"
        Me.btnAddPhr.Size = New System.Drawing.Size(57, 23)
        Me.btnAddPhr.TabIndex = 9
        Me.btnAddPhr.Text = "Add"
        Me.btnAddPhr.UseVisualStyleBackColor = True
        '
        'txtPhrase
        '
        Me.txtPhrase.Location = New System.Drawing.Point(98, 131)
        Me.txtPhrase.Name = "txtPhrase"
        Me.txtPhrase.Size = New System.Drawing.Size(100, 20)
        Me.txtPhrase.TabIndex = 8
        '
        'chkTopLevel
        '
        Me.chkTopLevel.AutoSize = True
        Me.chkTopLevel.Location = New System.Drawing.Point(36, 241)
        Me.chkTopLevel.Name = "chkTopLevel"
        Me.chkTopLevel.Size = New System.Drawing.Size(71, 17)
        Me.chkTopLevel.TabIndex = 11
        Me.chkTopLevel.Text = "TopLevel"
        Me.chkTopLevel.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(110, 265)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 23)
        Me.btnInsert.TabIndex = 12
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnRemOpt
        '
        Me.btnRemOpt.Location = New System.Drawing.Point(204, 73)
        Me.btnRemOpt.Name = "btnRemOpt"
        Me.btnRemOpt.Size = New System.Drawing.Size(57, 23)
        Me.btnRemOpt.TabIndex = 13
        Me.btnRemOpt.Text = "Remove"
        Me.btnRemOpt.UseVisualStyleBackColor = True
        '
        'btnRemPhr
        '
        Me.btnRemPhr.Location = New System.Drawing.Point(204, 177)
        Me.btnRemPhr.Name = "btnRemPhr"
        Me.btnRemPhr.Size = New System.Drawing.Size(57, 23)
        Me.btnRemPhr.TabIndex = 14
        Me.btnRemPhr.Text = "Remove"
        Me.btnRemPhr.UseVisualStyleBackColor = True
        '
        'frmAddRule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 313)
        Me.Controls.Add(Me.btnRemPhr)
        Me.Controls.Add(Me.btnRemOpt)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.chkTopLevel)
        Me.Controls.Add(Me.lstPhrase)
        Me.Controls.Add(Me.btnAddPhr)
        Me.Controls.Add(Me.txtPhrase)
        Me.Controls.Add(Me.lstOptional)
        Me.Controls.Add(Me.btnAddOpt)
        Me.Controls.Add(Me.txtOptional)
        Me.Controls.Add(Me.lblPhrase)
        Me.Controls.Add(Me.lblOpt)
        Me.Name = "frmAddRule"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Rule"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblOpt As System.Windows.Forms.Label
    Friend WithEvents lblPhrase As System.Windows.Forms.Label
    Friend WithEvents txtOptional As System.Windows.Forms.TextBox
    Friend WithEvents btnAddOpt As System.Windows.Forms.Button
    Friend WithEvents lstOptional As System.Windows.Forms.ListBox
    Friend WithEvents lstPhrase As System.Windows.Forms.ListBox
    Friend WithEvents btnAddPhr As System.Windows.Forms.Button
    Friend WithEvents txtPhrase As System.Windows.Forms.TextBox
    Friend WithEvents chkTopLevel As System.Windows.Forms.CheckBox
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents btnRemOpt As System.Windows.Forms.Button
    Friend WithEvents btnRemPhr As System.Windows.Forms.Button

End Class
