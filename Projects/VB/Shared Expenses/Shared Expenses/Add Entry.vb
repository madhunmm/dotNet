Public Class AddEntry

    Private Sub AddEntry_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Shared_Expenses.Menu.Show()
    End Sub

    Private Sub AddEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim entryList As ArrayList
        Dim dbo As Shared_Expenses.DBObject
        Dim ps As Shared_Expenses.PersonStatus

        entryList = Shared_Expenses.Menu.Database
        For Each dbo In entryList
            ' Populate the person list and debtee list (both are the same)
            If Not cboPerson.Items.Contains(dbo.Person) Then
                cboPerson.Items.Add(dbo.Person)
                clstSharedBy.Items.Add(dbo.Person)
            End If

            For Each ps In dbo.SharedMembers
                If Not cboPerson.Items.Contains(ps.Person) Then
                    cboPerson.Items.Add(ps.Person)
                    clstSharedBy.Items.Add(ps.Person)
                End If
            Next

            ' Populate the Expense type list
            If Not cboExpenseType.Items.Contains(dbo.ExpenseType) Then
                cboExpenseType.Items.Add(dbo.ExpenseType)
            End If
        Next
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        ' Create the package first
        Dim entry As New Shared_Expenses.DBObject

        entry.Person = cboPerson.Text                    ' Person
        entry.ExpenseType = cboExpenseType.Text          ' Expense type
        entry.Amount = txtAmount.Text                    ' Amount
        entry.EntryDate = dtpDate.Text                   ' Date
        entry.SharedMembers = New ArrayList()

        Dim debtees As System.Windows.Forms.CheckedListBox.CheckedItemCollection
        debtees = clstSharedBy.CheckedItems
        For index = 0 To debtees.Count - 1               ' debtee list
            Dim ps As New Shared_Expenses.PersonStatus
            ps.Person = debtees.Item(index)
            ps.Amount = Math.Round((Val(txtAmount.Text) / debtees.Count), 2)
            ps.Paid = False
            entry.SharedMembers.Add(ps)
        Next

        ' If agent, then store to separate DB
        Dim settings As New Settings
        If Not (settings.Agent) Then
            ' Add package to database
            Shared_Expenses.Menu.Database.Add(entry)
        Else
            ' Add to Cache
            Shared_Expenses.Menu.CacheDatabase.Add(entry)
        End If

        MessageBox.Show("Entry added successfully")

        ' Set status as modified
        Common.Modified = True

        Me.Close()
    End Sub

    Private Sub cmdAddName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddName.Click
        If (txtNewName.Text <> "") Then
            clstSharedBy.Items.Add(txtNewName.Text)
        End If
        txtNewName.Text = ""
        cmdNameNotFound.Visible = True
        lblAddName.Visible = False
        txtNewName.Visible = False
        cmdAddName.Visible = False
    End Sub

    Private Sub cmdNameNotFound_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNameNotFound.Click
        cmdNameNotFound.Visible = False
        lblAddName.Visible = True
        txtNewName.Visible = True
        cmdAddName.Visible = True
    End Sub
End Class