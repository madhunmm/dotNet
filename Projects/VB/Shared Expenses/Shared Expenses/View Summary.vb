Public Class ViewSummary
    Private dbList As ArrayList

    Private Sub ViewSummary_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ' Commit all changes
        Dim retVal = MsgBox("Do you want to save your changes?", MsgBoxStyle.YesNo)
        If retVal = MsgBoxResult.Yes Then
            ' Search for the appropriate entry in the database and update
            Dim dbo As Shared_Expenses.DBObject
            Dim ps As Shared_Expenses.PersonStatus
            For i = 0 To dgvSummary.Rows.Count - 1
                For Each dbo In dbList
                    If (dbo.ExpenseType = dgvSummary.Item(3, i).Value) Then
                        For Each ps In dbo.SharedMembers
                            If (dgvSummary.Item(0, i).Value = ps.Person And _
                                dgvSummary.Item(1, i).Value = dbo.Person And _
                                dgvSummary.Item(4, i).Value = dbo.EntryDate) Then

                                ps.Paid = dgvSummary.Item(5, i).Value ' Update the status

                            End If
                        Next
                    End If
                Next
                ' End If
            Next
            Shared_Expenses.Menu.Database = dbList

            ' Set status as modified
            Common.Modified = True
        End If
        Shared_Expenses.Menu.Show()
    End Sub

    Private Sub ViewSummary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim settings As New Settings
        ' Agents can only add new entries.
        ' Only the server apps have the right to settle.
        If (settings.Agent) Then
            cmdSettle.Enabled = False
            cboArchive.Enabled = False
        End If
        dbList = Shared_Expenses.Menu.Database
        Populate(cboPerson)
        Populate(cboToPay)
        FillGrid()

        ' Fill Archive list
        If Not (settings.Agent) Then
            cboArchive.Items.Clear()
            If FileIO.FileSystem.DirectoryExists(".\Archives") Then
                Dim archiveList As String()
                archiveList = System.IO.Directory.GetFiles(".\Archives")

                Dim strFileName As String
                For Each archiveFile In archiveList
                    strFileName = Microsoft.VisualBasic.Strings.Left(FileIO.FileSystem.GetName(archiveFile), FileIO.FileSystem.GetName(archiveFile).Length - 4)
                    cboArchive.Items.Add(strFileName)
                Next
            End If
        End If
    End Sub

    Private Sub chkAllentries_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAllentries.CheckedChanged
        FillGrid()
    End Sub

    Private Sub cboPerson_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPerson.SelectedIndexChanged
        Populate(cboToPay)
        FillGrid()
    End Sub

    Private Sub cboToPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboToPay.SelectedIndexChanged
        Populate(cboPerson)
        FillGrid()
    End Sub

    Private Sub Populate(ByVal cboBox As ComboBox)
        Dim dbo As Shared_Expenses.DBObject
        Dim ps As Shared_Expenses.PersonStatus

        For Each dbo In dbList
            ' Populate all persons
            If cboBox.Equals(cboPerson) Then
                If Not cboPerson.Items.Contains(dbo.Person) Then
                    cboPerson.Items.Add(dbo.Person)
                End If
            Else
                If Not cboToPay.Items.Contains(dbo.Person) Then
                    cboToPay.Items.Add(dbo.Person)
                End If
            End If
            For Each ps In dbo.SharedMembers
                ' Populate from here also
                If cboBox.Equals(cboPerson) Then
                    If Not cboPerson.Items.Contains(ps.Person) Then
                        cboPerson.Items.Add(ps.Person)
                    End If
                Else
                    If Not cboToPay.Items.Contains(ps.Person) Then
                        cboToPay.Items.Add(ps.Person)
                    End If
                End If
            Next
        Next
    End Sub

    Private Sub FillGrid()
        dgvSummary.Rows.Clear()
        With dgvSummary.ColumnHeadersDefaultCellStyle
            .Alignment = DataGridViewContentAlignment.MiddleCenter
            .Font = New Font(DefaultFont, FontStyle.Bold)
        End With
        dgvSummary.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dim dbo As Shared_Expenses.DBObject
        Dim ps As Shared_Expenses.PersonStatus
        For Each dbo In dbList
            If dbo.Person = cboToPay.Text Or cboToPay.Text = "" Then
                For Each ps In dbo.SharedMembers
                    If ps.Person = cboPerson.Text Or cboPerson.Text = "" Then
                        If (ps.Person <> dbo.Person And (chkAllentries.Checked Or Not ps.Paid)) Then
                            dgvSummary.Rows.Add(ps.Person, _
                                                dbo.Person, _
                                                ps.Amount, _
                                                dbo.ExpenseType, _
                                                dbo.EntryDate, _
                                                ps.Paid)

                            ' Colour code paid entries
                            If ps.Paid Then
                                With dgvSummary.Rows(dgvSummary.RowCount - 1).DefaultCellStyle
                                    .BackColor = Color.PaleGreen
                                End With
                            End If

                        End If
                    End If
                Next
            End If
        Next
        dgvSummary.Sort(dgvSummary.Columns(5), System.ComponentModel.ListSortDirection.Ascending)
        lblAmount.Text = "Rs. " + Math.Round(CalculateAmount(cboPerson.Text, cboToPay.Text), 2).ToString()
    End Sub

    Public Function CalculateAmount(ByVal strFrom As String, ByVal strTo As String) As Double
        If IsNothing(dbList) Then
            dbList = Shared_Expenses.Menu.Database
        End If
        Dim netAmount, fromAmount, toAmount As Double
        Dim dbo As Shared_Expenses.DBObject
        Dim ps As Shared_Expenses.PersonStatus

        netAmount = fromAmount = toAmount = 0

        For Each dbo In dbList
            If dbo.Person = strTo Then
                For Each ps In dbo.SharedMembers
                    If ps.Person = strFrom And ps.Paid = False Then
                        fromAmount = fromAmount + ps.Amount
                    End If
                Next
            End If
        Next

        For Each dbo In dbList
            If dbo.Person = strFrom Then
                For Each ps In dbo.SharedMembers
                    If ps.Person = strTo And ps.Paid = False Then
                        toAmount = toAmount + ps.Amount
                    End If
                Next
            End If
        Next

        If fromAmount > toAmount Then
            CalculateAmount = fromAmount - toAmount
        Else
            CalculateAmount = 0
        End If
    End Function

    Private Sub cmdSettle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSettle.Click
        Dim retVal = MsgBox("Are you sure you want to settle all accounts?", MsgBoxStyle.YesNo)
        If retVal = MsgBoxResult.Yes Then
            ' Check all paid? status's
            Dim dbo As Shared_Expenses.DBObject
            Dim ps As Shared_Expenses.PersonStatus
            For Each dbo In dbList
                If dbo.Person = cboToPay.Text Then
                    For Each ps In dbo.SharedMembers
                        If ps.Person = cboPerson.Text And ps.Paid = False Then
                            ps.Paid = True
                        End If
                    Next
                End If
            Next

            For Each dbo In dbList
                If dbo.Person = cboPerson.Text Then
                    For Each ps In dbo.SharedMembers
                        If ps.Person = cboToPay.Text And ps.Paid = False Then
                            ps.Paid = True
                        End If
                    Next
                End If
            Next
            FillGrid()
            MsgBox("All debts settled and saved")
        End If

    End Sub
End Class