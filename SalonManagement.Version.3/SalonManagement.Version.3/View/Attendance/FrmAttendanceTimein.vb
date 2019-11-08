Public Class FrmAttendanceTimein
    Private Sub tmrTime_Tick(sender As Object, e As EventArgs) Handles tmrTime.Tick
        lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt")
        lblDate.Text = Today.ToLongDateString
    End Sub

    Private Sub FrmAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrTime.Start()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class