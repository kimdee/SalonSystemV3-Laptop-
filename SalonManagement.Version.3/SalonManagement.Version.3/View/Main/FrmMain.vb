Public Class FrmMain
    Sub loadForm(ByVal form As Form)
        panelContainer.Controls.Clear()
        form.TopLevel = False
        panelContainer.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadForm(frmDashboard)
    End Sub

    Private Sub tmrMenu_Tick(sender As Object, e As EventArgs) Handles tmrMenu.Tick
        If panelMenu.Width <= 60 Then
            Me.tmrMenu.Enabled = False
            lblmanage.Text = "..."
            lblreport.Text = "..."
            lblsetting.Text = "..."
        Else
            panelMenu.Width = panelMenu.Width - 25
            pnlviewTask.Width = pnlviewTask.Width + 25

            'btnVwEmploy.Width = btnVwEmploy.Width + 25
            'btnVwPresnt.Width = btnVwPresnt.Width + 25
            'btnVwLeave.Width = btnVwLeave.Width + 25
            'btnVwAbsnt.Width = btnVwAbsnt.Width + 25
            'btnVwCustmr.Width = btnVwCustmr.Width + 25
            'btnVwCollect.Width = btnVwCollect.Width + 25

            'pnlVwEmploy.Width = pnlVwEmploy.Width + 25
            'pnlVwPresnt.Width = pnlVwPresnt.Width + 25
            'pnlVwLeave.Width = pnlVwLeave.Width + 25
            'pnlVwAbsnt.Width = pnlVwAbsnt.Width + 25
            'pnlVwCustmr.Width = pnlVwCustmr.Width + 25
            'pnlVwCollct.Width = pnlVwCollct.Width + 25

        End If
    End Sub

    Private Sub tmrMenu2_Tick(sender As Object, e As EventArgs) Handles tmrMenu2.Tick
        If panelMenu.Width >= 273 Then
            Me.tmrMenu2.Enabled = False
            lblmanage.Text = "Manage"
            lblreport.Text = "Reports"
            lblsetting.Text = "Settings"
        Else
            panelMenu.Width = panelMenu.Width + 25
            pnlviewTask.Width = pnlviewTask.Width - 25
            panelContainer.Width = panelContainer.Width - 25

            'btnVwEmploy.Width = btnVwEmploy.Width - 25
            'btnVwPresnt.Width = btnVwPresnt.Width - 25
            'btnVwLeave.Width = btnVwLeave.Width - 25
            'btnVwAbsnt.Width = btnVwAbsnt.Width - 25
            'btnVwCustmr.Width = btnVwCustmr.Width - 25
            'btnVwCollect.Width = btnVwCollect.Width - 25

            'pnlVwEmploy.Width = pnlVwEmploy.Width - 25
            'pnlVwPresnt.Width = pnlVwPresnt.Width - 25
            'pnlVwLeave.Width = pnlVwLeave.Width - 25
            'pnlVwAbsnt.Width = pnlVwAbsnt.Width - 25
            'pnlVwCustmr.Width = pnlVwCustmr.Width - 25
            'pnlVwCollct.Width = pnlVwCollct.Width - 25

        End If
    End Sub

    Private Sub picBoxMenu_Click(sender As Object, e As EventArgs) Handles picBoxMenu.Click
        If panelMenu.Width >= 273 Then
            Me.tmrMenu.Enabled = True
        ElseIf panelMenu.Width <= 60 Then
            Me.tmrMenu2.Enabled = True
        End If
    End Sub


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        FrmHelp.Show()
    End Sub
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        pnlIndicator.Height = btnHome.Height
        pnlIndicator.Top = btnHome.Top

        loadForm(frmDashboard)

    End Sub

    Private Sub btnappoint_click(sender As Object, e As EventArgs) Handles btnappoint.Click
        pnlIndicator.Height = btnappoint.Height
        pnlIndicator.Top = btnappoint.Top

        loadForm(FrmAppointment)
    End Sub

    Private Sub btnservice_click(sender As Object, e As EventArgs) Handles btnservice.Click
        pnlIndicator.Height = btnservice.Height
        pnlIndicator.Top = btnservice.Top

        loadForm(FrmService)
    End Sub

    Private Sub btnemployee_Click(sender As Object, e As EventArgs) Handles btnemployee.Click
        pnlIndicator.Height = btnemployee.Height
        pnlIndicator.Top = btnemployee.Top

        loadForm(FrmEmployee)
    End Sub

    Private Sub btnposition_Click(sender As Object, e As EventArgs) Handles btnposition.Click
        pnlIndicator.Height = btnposition.Height
        pnlIndicator.Top = btnposition.Top

        loadForm(FrmPosition)
    End Sub

    Private Sub btndeduct_Click(sender As Object, e As EventArgs) Handles btndeduct.Click
        pnlIndicator.Height = btndeduct.Height
        pnlIndicator.Top = btndeduct.Top

        loadForm(FrmDeduction)
    End Sub

    Private Sub btnAttend_Click(sender As Object, e As EventArgs) Handles btnAttend.Click
        pnlIndicator.Height = btnAttend.Height
        pnlIndicator.Top = btnAttend.Top

        loadForm(FrmAttendance)
    End Sub

    Private Sub btnPayrol_Click(sender As Object, e As EventArgs) Handles btnPayrol.Click
        pnlIndicator.Height = btnPayrol.Height
        pnlIndicator.Top = btnPayrol.Top

        loadForm(FrmPayroll)
    End Sub

    Private Sub btnCollect_Click(sender As Object, e As EventArgs) Handles btnCollect.Click
        pnlIndicator.Height = btnCollect.Height
        pnlIndicator.Top = btnCollect.Top

        loadForm(FrmCollection)
    End Sub

    Private Sub btnCustRecord_Click(sender As Object, e As EventArgs) Handles btnCustRecord.Click
        pnlIndicator.Height = btnCustRecord.Height
        pnlIndicator.Top = btnCustRecord.Top

        loadForm(FrmCustmerRec)
    End Sub

    Private Sub btnAccnt_Click(sender As Object, e As EventArgs) Handles btnAccnt.Click
        pnlIndicator.Height = btnAccnt.Height
        pnlIndicator.Top = btnAccnt.Top

        loadForm(FrmAccount)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        Frmlogin.Show()
        Frmlogin.txtuserName.Text = ""
        Frmlogin.txtpass.Text = ""
    End Sub
End Class
