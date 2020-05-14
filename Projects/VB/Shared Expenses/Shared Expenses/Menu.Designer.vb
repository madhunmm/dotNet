<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.cmdAddEntry = New System.Windows.Forms.Button
        Me.cmdViewSummary = New System.Windows.Forms.Button
        Me.cmdConfigure = New System.Windows.Forms.Button
        Me.cmdMerge = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cmdAddEntry
        '
        Me.cmdAddEntry.Location = New System.Drawing.Point(12, 12)
        Me.cmdAddEntry.Name = "cmdAddEntry"
        Me.cmdAddEntry.Size = New System.Drawing.Size(253, 32)
        Me.cmdAddEntry.TabIndex = 0
        Me.cmdAddEntry.Text = "Add Entry"
        Me.cmdAddEntry.UseVisualStyleBackColor = True
        '
        'cmdViewSummary
        '
        Me.cmdViewSummary.Location = New System.Drawing.Point(12, 50)
        Me.cmdViewSummary.Name = "cmdViewSummary"
        Me.cmdViewSummary.Size = New System.Drawing.Size(253, 32)
        Me.cmdViewSummary.TabIndex = 1
        Me.cmdViewSummary.Text = "View Summary"
        Me.cmdViewSummary.UseVisualStyleBackColor = True
        '
        'cmdConfigure
        '
        Me.cmdConfigure.Location = New System.Drawing.Point(11, 88)
        Me.cmdConfigure.Name = "cmdConfigure"
        Me.cmdConfigure.Size = New System.Drawing.Size(253, 32)
        Me.cmdConfigure.TabIndex = 2
        Me.cmdConfigure.Text = "Configure"
        Me.cmdConfigure.UseVisualStyleBackColor = True
        '
        'cmdMerge
        '
        Me.cmdMerge.Location = New System.Drawing.Point(11, 128)
        Me.cmdMerge.Name = "cmdMerge"
        Me.cmdMerge.Size = New System.Drawing.Size(253, 32)
        Me.cmdMerge.TabIndex = 3
        Me.cmdMerge.Text = "Merge Database"
        Me.cmdMerge.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 169)
        Me.Controls.Add(Me.cmdMerge)
        Me.Controls.Add(Me.cmdConfigure)
        Me.Controls.Add(Me.cmdViewSummary)
        Me.Controls.Add(Me.cmdAddEntry)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(282, 167)
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdAddEntry As System.Windows.Forms.Button
    Friend WithEvents cmdViewSummary As System.Windows.Forms.Button
    Friend WithEvents cmdConfigure As System.Windows.Forms.Button
    Friend WithEvents cmdMerge As System.Windows.Forms.Button
End Class
