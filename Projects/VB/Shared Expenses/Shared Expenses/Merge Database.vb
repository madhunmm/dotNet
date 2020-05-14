Public Class MergeDatabase

    Private m_EntryList As ArrayList

    Private Sub MergeDatabase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        m_EntryList = New ArrayList()
        Dim settings As New Settings
        Dim strFiles() As String
        strFiles = System.IO.Directory.GetFiles(settings.RemoteDir)

        For Each strFile As String In strFiles
            Dim fileReader As New System.IO.StreamReader(strFile)

            Dim line As String
            Dim params() As String

            While (fileReader.EndOfStream = False)

                line = fileReader.ReadLine()
                params = Split(line, ",")
                Dim entry As New DBObject
                entry.Person = params(0)                    ' Person
                entry.ExpenseType = params(1)               ' Expense type
                entry.Amount = params(2)                    ' Amount
                entry.EntryDate = params(3)                 ' Date
                entry.Archived = False                      ' Archived?
                entry.SharedMembers = New ArrayList()

                Dim personCount As Integer
                personCount = (UBound(params) - 3) / 2
                For index = 4 To UBound(params) Step 2

                    ' Person status
                    Dim ps As New PersonStatus
                    ps.Person = params(index)               ' debtee
                    ps.Amount = Math.Round(entry.Amount / personCount, 2)  ' Amount(individual)
                    If (params(index + 1) = "Yes") Then     ' Paid?
                        ps.Paid = True
                    Else
                        ps.Paid = False
                    End If
                    entry.SharedMembers.Add(ps)
                Next
                m_EntryList.Add(entry)
            End While
            fileReader.Close()
        Next

        FillGrid()
    End Sub

    Private Sub FillGrid()
        dgvNewEntries.Rows.Clear()
        With dgvNewEntries.ColumnHeadersDefaultCellStyle
            .Alignment = DataGridViewContentAlignment.MiddleCenter
            .Font = New Font(DefaultFont, FontStyle.Bold)
        End With
        dgvNewEntries.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dim dbo As Shared_Expenses.DBObject
        Dim ps As Shared_Expenses.PersonStatus
        Dim strShareMembers As String
        For Each dbo In m_EntryList
            strShareMembers = ""
            For Each ps In dbo.SharedMembers
                If (strShareMembers = "") Then
                    strShareMembers = ps.Person
                Else
                    strShareMembers = strShareMembers + "," + ps.Person
                End If
            Next

            dgvNewEntries.Rows.Add(dbo.Person, _
                                    strShareMembers, _
                                    dbo.Amount, _
                                    dbo.ExpenseType, _
                                    dbo.EntryDate, _
                                    False)
        Next
        dgvNewEntries.Sort(dgvNewEntries.Columns(5), System.ComponentModel.ListSortDirection.Ascending)

        ' Make the first row selected.
        If (dgvNewEntries.RowCount > 0) Then
            dgvNewEntries.Rows(0).Selected = True
        End If
    End Sub

    Private Sub MergeDatabase_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Shared_Expenses.Menu.Show()
    End Sub

    Private Sub cmdRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemove.Click
        ' Get all the information from the grid
        Dim strPerson As String
        Dim strSharers As String
        Dim iAmount As Double
        Dim strDate As String
        Dim strLiew As String
        Dim iRow As Integer

        If (dgvNewEntries.SelectedRows.Count = 1) Then
            iRow = dgvNewEntries.SelectedRows(0).Index
            strPerson = dgvNewEntries.Rows(iRow).Cells(0).Value.ToString()
            strSharers = dgvNewEntries.Rows(iRow).Cells(1).Value.ToString()
            iAmount = Double.Parse(dgvNewEntries.Rows(iRow).Cells(2).Value.ToString())
            strLiew = dgvNewEntries.Rows(iRow).Cells(3).Value.ToString()
            strDate = dgvNewEntries.Rows(iRow).Cells(4).Value.ToString()

            Dim dbo As Shared_Expenses.DBObject

            For Each dbo In m_EntryList
                If (dbo.Person = strPerson) Then
                    If (dbo.EntryDate = strDate) Then
                        If (dbo.ExpenseType = strLiew) Then
                            If (dbo.Amount = iAmount) Then
                                m_EntryList.Remove(dbo)
                                dgvNewEntries.Rows.Remove(dgvNewEntries.Rows(iRow))
                                Exit For
                            End If
                        End If
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub dgvNewEntries_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvNewEntries.CellClick
        If (e.RowIndex >= 0) Then
            dgvNewEntries.Rows(e.RowIndex).Selected = True
        End If
    End Sub

    Private Sub cmdMerge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMerge.Click
        Dim dbo As Shared_Expenses.DBObject
        If (m_EntryList.Count > 0) Then
            For Each dbo In m_EntryList
                Shared_Expenses.Menu.Database.Add(dbo)
                Common.Modified = True
            Next
        End If

        ' Delete all the files in the cache.
        Dim settings As New Settings
        Dim strFiles() As String
        strFiles = System.IO.Directory.GetFiles(settings.RemoteDir)

        For Each strFile As String In strFiles
            System.IO.File.Delete(strFile)
        Next

        ' Remove all entries from grid
        dgvNewEntries.Rows.Clear()

        ' Message to user
        MessageBox.Show("All entries merged successfully! Do not forget to commit changes before exiting application.", _
                        "Merge successful", _
                        MessageBoxButtons.OK, _
                        MessageBoxIcon.Information)

        ' Close this window
        Close()
    End Sub
End Class