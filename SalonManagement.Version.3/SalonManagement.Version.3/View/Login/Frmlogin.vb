Public Class Frmlogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim obj As New FrmMain
        If txtuserName.Text = "Admin" And txtpass.Text = "admin" Then
            obj.ShowDialog()
            Me.Hide()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim obj As New FrmAttendanceTimein
        obj.ShowDialog()
    End Sub
End Class