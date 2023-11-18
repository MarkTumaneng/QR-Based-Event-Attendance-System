Public Class frmSelect
    Private Sub cboSelect_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboSelect.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSelect.SelectedIndexChanged

    End Sub

    Private Sub frmSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With frmLogin
            .Hide()
        End With
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        With frmAttendance
            .lblLType.Text = cboSelect.Text

            .Show()
            .UnLoadForm()
        End With
    End Sub
End Class