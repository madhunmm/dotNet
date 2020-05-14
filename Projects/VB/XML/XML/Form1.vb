Public Class frmAddRule

    Private Sub btnAddOpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddOpt.Click
        If (txtOptional.Text <> "") Then
            lstOptional.Items.Add(txtOptional.Text)
            txtOptional.Text = ""
        End If
    End Sub

    Private Sub btnAddPhr_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddPhr.Click
        If (txtPhrase.Text <> "") Then
            lstPhrase.Items.Add(txtPhrase.Text)
            txtPhrase.Text = ""
        End If
    End Sub

    Private Sub btnRemOpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemOpt.Click
        If (lstOptional.SelectedIndex >= 0) Then
            lstOptional.Items.RemoveAt(lstOptional.SelectedIndex)
        End If
    End Sub

    Private Sub btnRemPhr_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRemPhr.Click
        If (lstPhrase.SelectedIndex >= 0) Then
            lstPhrase.Items.RemoveAt(lstPhrase.SelectedIndex)
        End If
    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click

    End Sub
End Class
