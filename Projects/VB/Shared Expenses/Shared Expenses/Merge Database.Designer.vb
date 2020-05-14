<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MergeDatabase
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
        Me.dgvNewEntries = New System.Windows.Forms.DataGridView
        Me.Person = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SharedBy = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.in_lieu_of = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EntryDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Paid = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.cmdRemove = New System.Windows.Forms.Button
        Me.cmdMerge = New System.Windows.Forms.Button
        CType(Me.dgvNewEntries, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvNewEntries
        '
        Me.dgvNewEntries.AllowUserToAddRows = False
        Me.dgvNewEntries.AllowUserToDeleteRows = False
        Me.dgvNewEntries.AllowUserToResizeColumns = False
        Me.dgvNewEntries.AllowUserToResizeRows = False
        Me.dgvNewEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNewEntries.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Person, Me.SharedBy, Me.Amount, Me.in_lieu_of, Me.EntryDate, Me.Paid})
        Me.dgvNewEntries.Location = New System.Drawing.Point(16, 12)
        Me.dgvNewEntries.Name = "dgvNewEntries"
        Me.dgvNewEntries.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvNewEntries.Size = New System.Drawing.Size(667, 208)
        Me.dgvNewEntries.TabIndex = 10
        '
        'Person
        '
        Me.Person.HeaderText = "Person"
        Me.Person.Name = "Person"
        Me.Person.ReadOnly = True
        '
        'SharedBy
        '
        Me.SharedBy.HeaderText = "Shared By"
        Me.SharedBy.Name = "SharedBy"
        Me.SharedBy.Width = 220
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
        'cmdRemove
        '
        Me.cmdRemove.Location = New System.Drawing.Point(197, 231)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(75, 23)
        Me.cmdRemove.TabIndex = 11
        Me.cmdRemove.Text = "Remove"
        Me.cmdRemove.UseVisualStyleBackColor = True
        '
        'cmdMerge
        '
        Me.cmdMerge.Location = New System.Drawing.Point(420, 231)
        Me.cmdMerge.Name = "cmdMerge"
        Me.cmdMerge.Size = New System.Drawing.Size(75, 23)
        Me.cmdMerge.TabIndex = 12
        Me.cmdMerge.Text = "Merge"
        Me.cmdMerge.UseVisualStyleBackColor = True
        '
        'MergeDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 266)
        Me.Controls.Add(Me.cmdMerge)
        Me.Controls.Add(Me.cmdRemove)
        Me.Controls.Add(Me.dgvNewEntries)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(703, 300)
        Me.MinimumSize = New System.Drawing.Size(703, 300)
        Me.Name = "MergeDatabase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Merge Database"
        CType(Me.dgvNewEntries, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvNewEntries As System.Windows.Forms.DataGridView
    Friend WithEvents Person As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SharedBy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents in_lieu_of As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EntryDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Paid As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cmdRemove As System.Windows.Forms.Button
    Friend WithEvents cmdMerge As System.Windows.Forms.Button
End Class
