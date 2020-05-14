<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEntry
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
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.cboPerson = New System.Windows.Forms.ComboBox
        Me.cboExpenseType = New System.Windows.Forms.ComboBox
        Me.lblPerson = New System.Windows.Forms.Label
        Me.lblExenseType = New System.Windows.Forms.Label
        Me.lblSharedBy = New System.Windows.Forms.Label
        Me.lblAmount = New System.Windows.Forms.Label
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.clstSharedBy = New System.Windows.Forms.CheckedListBox
        Me.lblAddName = New System.Windows.Forms.Label
        Me.txtNewName = New System.Windows.Forms.TextBox
        Me.cmdAddName = New System.Windows.Forms.Button
        Me.cmdNameNotFound = New System.Windows.Forms.Button
        Me.lblDate = New System.Windows.Forms.Label
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.SuspendLayout()
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(109, 239)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(121, 20)
        Me.txtAmount.TabIndex = 4
        '
        'cboPerson
        '
        Me.cboPerson.FormattingEnabled = True
        Me.cboPerson.Location = New System.Drawing.Point(109, 32)
        Me.cboPerson.Name = "cboPerson"
        Me.cboPerson.Size = New System.Drawing.Size(121, 21)
        Me.cboPerson.TabIndex = 1
        '
        'cboExpenseType
        '
        Me.cboExpenseType.FormattingEnabled = True
        Me.cboExpenseType.Location = New System.Drawing.Point(109, 69)
        Me.cboExpenseType.Name = "cboExpenseType"
        Me.cboExpenseType.Size = New System.Drawing.Size(121, 21)
        Me.cboExpenseType.TabIndex = 2
        '
        'lblPerson
        '
        Me.lblPerson.AutoSize = True
        Me.lblPerson.Location = New System.Drawing.Point(26, 36)
        Me.lblPerson.Name = "lblPerson"
        Me.lblPerson.Size = New System.Drawing.Size(40, 13)
        Me.lblPerson.TabIndex = 4
        Me.lblPerson.Text = "Person"
        '
        'lblExenseType
        '
        Me.lblExenseType.AutoSize = True
        Me.lblExenseType.Location = New System.Drawing.Point(26, 73)
        Me.lblExenseType.Name = "lblExenseType"
        Me.lblExenseType.Size = New System.Drawing.Size(75, 13)
        Me.lblExenseType.TabIndex = 5
        Me.lblExenseType.Text = "Expense Type"
        '
        'lblSharedBy
        '
        Me.lblSharedBy.AutoSize = True
        Me.lblSharedBy.Location = New System.Drawing.Point(26, 110)
        Me.lblSharedBy.Name = "lblSharedBy"
        Me.lblSharedBy.Size = New System.Drawing.Size(55, 13)
        Me.lblSharedBy.TabIndex = 6
        Me.lblSharedBy.Text = "Shared by"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(26, 243)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(43, 13)
        Me.lblAmount.TabIndex = 7
        Me.lblAmount.Text = "Amount"
        Me.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(89, 278)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(75, 23)
        Me.cmdAdd.TabIndex = 5
        Me.cmdAdd.Text = "Add Entry"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'clstSharedBy
        '
        Me.clstSharedBy.FormattingEnabled = True
        Me.clstSharedBy.Location = New System.Drawing.Point(109, 103)
        Me.clstSharedBy.Name = "clstSharedBy"
        Me.clstSharedBy.Size = New System.Drawing.Size(120, 64)
        Me.clstSharedBy.TabIndex = 3
        '
        'lblAddName
        '
        Me.lblAddName.AutoSize = True
        Me.lblAddName.Location = New System.Drawing.Point(26, 180)
        Me.lblAddName.Name = "lblAddName"
        Me.lblAddName.Size = New System.Drawing.Size(55, 13)
        Me.lblAddName.TabIndex = 9
        Me.lblAddName.Text = "Add name"
        Me.lblAddName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblAddName.Visible = False
        '
        'txtNewName
        '
        Me.txtNewName.Location = New System.Drawing.Point(109, 176)
        Me.txtNewName.Name = "txtNewName"
        Me.txtNewName.Size = New System.Drawing.Size(81, 20)
        Me.txtNewName.TabIndex = 8
        Me.txtNewName.Visible = False
        '
        'cmdAddName
        '
        Me.cmdAddName.Location = New System.Drawing.Point(188, 174)
        Me.cmdAddName.Name = "cmdAddName"
        Me.cmdAddName.Size = New System.Drawing.Size(42, 23)
        Me.cmdAddName.TabIndex = 10
        Me.cmdAddName.Text = "Add"
        Me.cmdAddName.UseVisualStyleBackColor = True
        Me.cmdAddName.Visible = False
        '
        'cmdNameNotFound
        '
        Me.cmdNameNotFound.Location = New System.Drawing.Point(26, 175)
        Me.cmdNameNotFound.Name = "cmdNameNotFound"
        Me.cmdNameNotFound.Size = New System.Drawing.Size(204, 23)
        Me.cmdNameNotFound.TabIndex = 11
        Me.cmdNameNotFound.Text = "Name not found? Add it"
        Me.cmdNameNotFound.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(26, 209)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(30, 13)
        Me.lblDate.TabIndex = 13
        Me.lblDate.Text = "Date"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpDate
        '
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(109, 205)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(120, 20)
        Me.dtpDate.TabIndex = 14
        '
        'AddEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(257, 315)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.cmdNameNotFound)
        Me.Controls.Add(Me.cmdAddName)
        Me.Controls.Add(Me.lblAddName)
        Me.Controls.Add(Me.txtNewName)
        Me.Controls.Add(Me.clstSharedBy)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.lblSharedBy)
        Me.Controls.Add(Me.lblExenseType)
        Me.Controls.Add(Me.lblPerson)
        Me.Controls.Add(Me.cboExpenseType)
        Me.Controls.Add(Me.cboPerson)
        Me.Controls.Add(Me.txtAmount)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(265, 349)
        Me.MinimumSize = New System.Drawing.Size(265, 349)
        Me.Name = "AddEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Entry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents cboPerson As System.Windows.Forms.ComboBox
    Friend WithEvents cboExpenseType As System.Windows.Forms.ComboBox
    Friend WithEvents lblPerson As System.Windows.Forms.Label
    Friend WithEvents lblExenseType As System.Windows.Forms.Label
    Friend WithEvents lblSharedBy As System.Windows.Forms.Label
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents clstSharedBy As System.Windows.Forms.CheckedListBox
    Friend WithEvents lblAddName As System.Windows.Forms.Label
    Friend WithEvents txtNewName As System.Windows.Forms.TextBox
    Friend WithEvents cmdAddName As System.Windows.Forms.Button
    Friend WithEvents cmdNameNotFound As System.Windows.Forms.Button
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
End Class
