Public Class frmConfirmReset
    Public Property IsAuthorized As Boolean = False

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If txtPassword.Text.Trim() = "admin123" Then ' TEMPORARY hardcoded password
            IsAuthorized = True
            Me.Close()
        Else
            MessageBox.Show("Incorrect password!", "Reset Blocked", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Clear()
            txtPassword.Focus()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
