<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSummary
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
        Me.dgvSummary = New System.Windows.Forms.DataGridView
        Me.Person = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.To_pay = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.in_lieu_of = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EntryDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Paid = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.cboPerson = New System.Windows.Forms.ComboBox
        Me.cboToPay = New System.Windows.Forms.ComboBox
        Me.lblPerson = New System.Windows.Forms.Label
        Me.lblToPay = New System.Windows.Forms.Label
        Me.lblSummary = New System.Windows.Forms.Label
        Me.chkAllentries = New System.Windows.Forms.CheckBox
        Me.lblAmount = New System.Windows.Forms.Label
        Me.cmdSettle = New System.Windows.Forms.Button
        Me.cboArchive = New System.Windows.Forms.ComboBox
        CType(Me.dgvSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvSummary
        '
        Me.dgvSummary.AllowUserToAddRows = False
        Me.dgvSummary.AllowUserToDeleteRows = False
        Me.dgvSummary.AllowUserToResizeColumns = False
        Me.dgvSummary.AllowUserToResizeRows = False
        Me.dgvSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSummary.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Person, Me.To_pay, Me.Amount, Me.in_lieu_of, Me.EntryDate, Me.Paid})
        Me.dgvSummary.Location = New System.Drawing.Point(16, 70)
        Me.dgvSummary.Name = "dgvSummary"
        Me.dgvSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvSummary.Size = New System.Drawing.Size(547, 150)
        Me.dgvSummary.TabIndex = 0
        '
        'Person
        '
        Me.Person.HeaderText = "Person"
        Me.Person.Name = "Person"
        Me.Person.ReadOnly = True
        '
        'To_pay
        '
        Me.To_pay.HeaderText = "To Pay"
        Me.To_pay.Name = "To_pay"
        Me.To_pay.ReadOnly = True
        '
        'Amount
        '
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.ReadOnly = True
        '
        'in_lieu_of
        '
        Me.in_lieu_of.HeaderText = "In Lieu of"
        Me.in_lieu_of.Name = "in_lieu_of"
        Me.in_lieu_of.ReadOnly = True
        '
        'EntryDate
        '
        Me.EntryDate.HeaderText = "Date"
        Me.EntryDate.Name = "EntryDate"
        Me.EntryDate.ReadOnly = True
        '
        'Paid
        '
        Me.Paid.HeaderText = "Paid"
        Me.Paid.Name = "Paid"
        Me.Paid.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Paid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'cboPerson
        '
        Me.cboPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPerson.FormattingEnabled = True
        Me.cboPerson.Location = New System.Drawing.Point(118, 25)
        Me.cboPerson.Name = "cboPerson"
        Me.cboPerson.Size = New System.Drawing.Size(121, 21)
        Me.cboPerson.TabIndex = 1
        '
        'cboToPay
        '
        Me.cboToPay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboToPay.FormattingEnabled = True
        Me.cboToPay.Location = New System.Drawing.Point(368, 25)
        Me.cboToPay.Name = "cboToPay"
        Me.cboToPay.Size = New System.Drawing.Size(121, 21)
        Me.cboToPay.TabIndex = 2
        '
        'lblPerson
        '
        Me.lblPerson.AutoSize = True
        Me.lblPerson.Location = New System.Drawing.Point(72, 29)
        Me.lblPerson.Name = "lblPerson"
        Me.lblPerson.Size = New System.Drawing.Size(40, 13)
        Me.lblPerson.TabIndex = 3
        Me.lblPerson.Text = "Person"
        '
        'lblToPay
        '
        Me.lblToPay.AutoSize = True
        Me.lblToPay.Location = New System.Drawing.Point(321, 29)
        Me.lblToPay.Name = "lblToPay"
        Me.lblToPay.Size = New System.Drawing.Size(41, 13)
        Me.lblToPay.TabIndex = 4
        Me.lblToPay.Text = "To Pay"
        '
        'lblSummary
        '
        Me.lblSummary.AutoSize = True
        Me.lblSummary.Location = New System.Drawing.Point(13, 236)
        Me.lblSummary.Name = "lblSummary"
        Me.lblSummary.Size = New System.Drawing.Size(122, 13)
        Me.lblSummary.TabIndex = 5
        Me.lblSummary.Text = "Total amount to be paid "
        '
        'chkAllentries
        '
        Me.chkAllentries.AutoSize = True
        Me.chkAllentries.Location = New System.Drawing.Point(498, 234)
        Me.chkAllentries.Name = "chkAllentries"
        Me.chkAllentries.Size = New System.Drawing.Size(72, 17)
        Me.chkAllentries.TabIndex = 6
        Me.chkAllentries.Text = "All Entries"
        Me.chkAllentries.UseVisualStyleBackColor = True
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.ForeColor = System.Drawing.Color.Green
        Me.lblAmount.Location = New System.Drawing.Point(141, 230)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(0, 22)
        Me.lblAmount.TabIndex = 7
        '
        'cmdSettle
        '
        Me.cmdSettle.Location = New System.Drawing.Point(261, 231)
        Me.cmdSettle.Name = "cmdSettle"
        Me.cmdSettle.Size = New System.Drawing.Size(94, 23)
        Me.cmdSettle.TabIndex = 8
        Me.cmdSettle.Text = "Settle Accounts"
        Me.cmdSettle.UseVisualStyleBackColor = True
        '
        'cboArchive
        '
        Me.cboArchive.FormattingEnabled = True
        Me.cboArchive.Location = New System.Drawing.Point(376, 231)
        Me.cboArchive.Name = "cboArchive"
        Me.cboArchive.Size = New System.Drawing.Size(96, 21)
        Me.cboArchive.TabIndex = 9
        Me.cboArchive.Text = "Select Archive"
        '
        'ViewSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 266)
        Me.Controls.Add(Me.cboArchive)
        Me.Controls.Add(Me.cmdSettle)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.chkAllentries)
        Me.Controls.Add(Me.lblSummary)
        Me.Controls.Add(Me.lblToPay)
        Me.Controls.Add(Me.lblPerson)
        Me.Controls.Add(Me.cboToPay)
        Me.Controls.Add(Me.cboPerson)
        Me.Controls.Add(Me.dgvSummary)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(587, 300)
        Me.MinimumSize = New System.Drawing.Size(587, 300)
        Me.Name = "ViewSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Summary"
        CType(Me.dgvSummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvSummary As System.Windows.Forms.DataGridView
    Friend WithEvents cboPerson As System.Windows.Forms.ComboBox
    Friend WithEvents cboToPay As System.Windows.Forms.ComboBox
    Friend WithEvents lblPerson As System.Windows.Forms.Label
    Friend WithEvents lblToPay As System.Windows.Forms.Label
    Friend WithEvents lblSummary As System.Windows.Forms.Label
    Friend WithEvents chkAllentries As System.Windows.Forms.CheckBox
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents cmdSettle As System.Windows.Forms.Button
    Friend WithEvents cboArchive As System.Windows.Forms.ComboBox
    Friend WithEvents Person As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents To_pay As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents in_lieu_of As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EntryDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Paid As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
