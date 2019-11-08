Public Class frmAddAppointment
    Public Shared dtServer As Date = DateTime.Now

    Private customer As New Customer
    Private appointment As New Appointment
    Private service As New Service

    Private add As Boolean = False
    Private edit As Boolean = False

    Dim status As String = "Not Paid"

    Private Sub EnableInput(root As Control)
        For Each ctrl As Control In root.Controls
            EnableInput(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Enabled = True
            End If
            If TypeOf ctrl Is RadioButton Then
                CType(ctrl, RadioButton).Enabled = True
            End If
            If TypeOf ctrl Is ComboBox Then
                CType(ctrl, ComboBox).Enabled = True
            End If
            If TypeOf ctrl Is DateTimePicker Then
                CType(ctrl, DateTimePicker).Enabled = True
            End If
            If TypeOf ctrl Is DataGridView Then
                CType(ctrl, DataGridView).Enabled = True
            End If
        Next ctrl
    End Sub
    Private Sub DisableInput(root As Control)
        For Each ctrl As Control In root.Controls
            DisableInput(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Enabled = False
            End If
            If TypeOf ctrl Is RadioButton Then
                CType(ctrl, RadioButton).Enabled = False
            End If
            If TypeOf ctrl Is DateTimePicker Then
                CType(ctrl, DateTimePicker).Enabled = False
            End If
            If TypeOf ctrl Is ComboBox Then
                CType(ctrl, ComboBox).Enabled = False
            End If
            If TypeOf ctrl Is DataGridView Then
                CType(ctrl, DataGridView).Enabled = False
            End If
        Next ctrl
    End Sub

    Sub SetAppointment()
        appointment.CustomerID = customer.CustomerID
        appointment.ServiceID = service.ServiceID
        appointment.AppointmentTime = dtpTime.Value.ToShortTimeString
        appointment.AppointmentDate = dtpDate.Value.ToString
        appointment.AppointmentType =
        appointment.AddAppointment()
        appointment.SetAppointmentID()

        For Each r As DataGridViewRow In gvView.Rows
            With service
                .AppointmentID = appointment.AppointmentID
                .ServiceName = r.Cells(2).Value
                .ServiceDescription = r.Cells(3).Value
                .ServicePrice = r.Cells(4).Value
                '.AddService()
            End With
        Next
    End Sub
    Public Sub ClearInput(root As Control)
        For Each ctrl As Control In root.Controls
            ClearInput(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = String.Empty
            ElseIf TypeOf ctrl Is DataGridView Then
                CType(ctrl, DataGridView).Text = String.Empty
            ElseIf TypeOf ctrl Is ComboBox Then
                CType(ctrl, ComboBox).Text = String.Empty
            End If
        Next ctrl
    End Sub

    ''---------Buttons Enable/Color---------
    Private Sub ResetButton()
        btnSearch.Enabled = True
        btnSearch.BackColor = Color.WhiteSmoke
        btnNewCustomer.Enabled = True
        btnNewCustomer.BackColor = Color.WhiteSmoke
        btnBrowseCustomer.Enabled = True
        btnBrowseCustomer.BackColor = Color.WhiteSmoke
        btnAddservice.Enabled = False
        btnAddservice.BackColor = Color.WhiteSmoke
        btnPayments.Enabled = False
        btnPayments.BackColor = Color.WhiteSmoke
        btnSave.Enabled = False
        btnSave.BackColor = Color.DarkSlateGray
        btnEdit.Enabled = False
        btnEdit.BackColor = Color.DarkSlateGray
        btnClose.Enabled = True
        btnClose.BackColor = Color.WhiteSmoke
    End Sub
    Private Sub OnActionButton()
        btnSearch.Enabled = False
        btnSearch.BackColor = Color.WhiteSmoke
        btnNewCustomer.Enabled = True
        btnNewCustomer.BackColor = Color.WhiteSmoke
        btnBrowseCustomer.Enabled = False
        btnBrowseCustomer.BackColor = Color.WhiteSmoke
        btnAddservice.Enabled = True
        btnAddservice.BackColor = Color.WhiteSmoke
        btnPayments.Enabled = False
        btnPayments.BackColor = Color.WhiteSmoke
        btnSave.Enabled = True
        btnSave.BackColor = Color.DarkSlateGray
        btnEdit.Enabled = False
        btnEdit.BackColor = Color.DarkSlateGray
        btnClose.Enabled = True
        btnClose.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub timerWalkin_Tick(sender As Object, e As EventArgs) Handles timerWalkin.Tick
        lblTimeNow.Text = dtServer.ToString("h:mm tt")
        lblDateNow.Text = dtServer.ToShortDateString
    End Sub

    Private Sub frmAddWalkin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisableInput(Me)
        ResetButton()
        timerWalkin.Start()

        add = True
        edit = True

        dtpDate.Value = dtServer.ToShortDateString
        dtpTime.Value = dtServer.ToString("h:mm tt")
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

    End Sub

    Private Sub btnNewCustomer_Click(sender As Object, e As EventArgs) Handles btnNewCustomer.Click
        Dim obj As New frmAddCustomer
        obj.customer = Me.customer

        If btnNewCustomer.Text = "Edit Customer" Then
            obj.edit = True
        End If

        If obj.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            ''Insert CustomerTable
            With customer
                txtName.Text = .CustomerName
                txtCN.Text = .CustomerCN
                If .CustomerSex = "Male" Then
                    rdbMale.Checked = True
                ElseIf .CustomerSex = "Female" Then
                    rdbFemale.Checked = True
                End If
            End With
            btnNewCustomer.Text = "Edit Customer"

            OnActionButton()
            btnClose.Text = "Cancel"
        End If

        gvView.Rows.Clear()

        EnableInput(Me)
        txtName.Enabled = False
        rdbMale.Enabled = False
        rdbFemale.Enabled = False
        txtCN.Enabled = False


    End Sub

    Private Sub btnBrowseCustomer_Click(sender As Object, e As EventArgs) Handles btnBrowseCustomer.Click
        gvView.Rows.Clear()
        ClearInput(Me)

        EnableInput(Me)
        txtName.Enabled = False
        rdbMale.Enabled = False
        rdbFemale.Enabled = False
        txtCN.Enabled = False

        Dim obj As New frmSearchCustomer
        obj.customer = Me.customer

        Dim obj2 As New frmAddCustomer
        obj.customer = Me.customer
        If btnNewCustomer.Text = "Edit Customer" Then
            obj2.edit = True
        End If

        If obj.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Try
                With customer
                    txtName.Text = .CustomerName
                    If .CustomerSex = "Male" Then
                        rdbMale.Checked = True
                    ElseIf .CustomerSex = "Female" Then
                        rdbFemale.Checked = True
                    End If
                    txtCN.Text = .CustomerCN
                End With
                btnNewCustomer.Text = "Edit Customer"

                OnActionButton()
                btnClose.Text = "Cancel"
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    ''Total Amount Count
    Sub recount()
        Dim i As Integer = 1
        Dim c As Decimal = 0
        For Each r As DataGridViewRow In gvView.Rows
            r.Cells(1).Value = i
            i = i + 1
            c = c + r.Cells(4).Value
        Next
        nudTotalAmount.Value = c
        'recolor()
        gvView.ClearSelection()
    End Sub

    Private Sub btnAddservice_Click(sender As Object, e As EventArgs) Handles btnAddservice.Click
        Dim obj As New frmAddServices
        If obj.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Dim index As Integer = 1
            For Each row As DataGridViewRow In obj.gvView.Rows
                If row.Cells(1).Value = True Then
                    With gvView
                        .Rows.Add(row.Cells(0).Value.ToString,
                                       index.ToString,
                                       row.Cells(3).Value.ToString,
                                       row.Cells(4).Value.ToString,
                                       row.Cells(5).Value.ToString,
                                       "Remove")
                    End With
                    index += 1
                    recount()
                End If
            Next
        End If
    End Sub

    Private Sub btnPayments_Click(sender As Object, e As EventArgs) Handles btnPayments.Click
        Dim obj As New frmAddPayments
        appointment.SetAppointmentDetails(appointment.AppointmentID)
        customer.SetCustomerDetails(customer.CustomerID)
        obj.appointment = Me.appointment
        obj.customer = Me.customer
        If obj.ShowDialog = DialogResult.OK Then
            appointment.AppointmentStatus = "Paid"
            appointment.EditAppointment()
        End If
    End Sub


    Private Sub OnDone()
        ResetButton()
        DisableInput(Me)
    End Sub
    Public Sub doAdd()
        Try
            customer.AddCustomer()
            customer.SetCustomerID()

            ''Instert AppointmentTable
            For Each r As DataGridViewRow In gvView.Rows
                With appointment
                    .AppointmentID = appointment.AppointmentID
                    .CustomerID = customer.CustomerID
                    .ServiceID = r.Cells(0).Value.ToString

                    .AppointmentDate = lblDateNow.Text
                    If rdbWalkin.Checked = True Then
                        .AppointmentType = "Walk-In"
                        .AppointmentTime = lblTimeNow.Text
                        .AppointmentDate = lblDateNow.Text
                    ElseIf rdbReservation.Checked = True Then
                        .AppointmentType = "Reservation"
                        .AppointmentTime = dtpTime.Value.ToString("t")
                        .AppointmentDate = dtpDate.Value.ToString("d")
                    End If
                    .AppointmentStatus = "Not Paid"
                    .AppointmentTotalAmount = nudTotalAmount.Value.ToString

                    If .AddAppointment() = True Then
                        If MessageBox.Show("Do you want to proceed to payment?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            Dim obj As New frmAddPayments
                            Me.Hide()
                            appointment.SetAppointmentDetails(appointment.AppointmentID)
                            customer.SetCustomerDetails(customer.CustomerID)
                            obj.appointment = Me.appointment
                            obj.customer = Me.customer
                            If obj.ShowDialog = DialogResult.OK Then

                            End If
                        ElseIf MessageBox.Show("Appointment Save", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question) = DialogResult.OK Then
                            OnDone()
                            ResetButton()
                            ClearInput(Me)
                            DisableInput(Me)

                            gvView.Rows.Clear()
                            rdbMale.Checked = True
                            rdbWalkin.Checked = True

                            btnClose.Text = "Close"
                            btnNewCustomer.Text = "New Customer"
                        End If
                    Else
                        Dim err As ErrorMessage
                        err = New ErrorMessage
                        err.lblMsg.Text = "Failed Saving New Appointment."
                        err.ShowDialog()
                    End If
                End With
            Next
        Catch ex As Exception

        End Try
    End Sub
    Public Sub doEdit()
        Try
            ''Edit CustomerTable
            With customer
                .CustomerName = txtName.Text
                .CustomerCN = txtCN.Text
                If rdbMale.Checked = True Then
                    .CustomerSex = "Male"
                ElseIf rdbFemale.Checked = True Then
                    .CustomerSex = "Female"
                End If
                .EditCustomer()
                .SetCustomerID()
            End With

            ''Edit AppointmentTable
            For Each r As DataGridViewRow In gvView.Rows
                With appointment
                    .CustomerID = customer.CustomerID
                    .ServiceID = service.ServiceID

                    If rdbWalkin.Checked = True Then
                        .AppointmentType = "Walk-In"
                        .AppointmentTime = lblTimeNow.Text
                        .AppointmentDate = lblDateNow.Text
                    ElseIf rdbReservation.Checked = True Then
                        .AppointmentType = "Reservation"
                        .AppointmentTime = dtpTime.Value.TimeOfDay.ToString
                        .AppointmentDate = dtpDate.Value.ToString
                    End If
                    .AppointmentStatus = "Off"
                    .AppointmentTotalAmount = nudTotalAmount.Value.ToString

                    If .EditAppointment() = True Then
                        Dim ok As New OKMessage
                        ok = New OKMessage
                        ok.lblMsg.Text = "Appointment has been updated."
                        ok.ShowDialog()

                        OnDone()

                        btnPayments.Enabled = True
                        btnEdit.Enabled = True
                    Else
                        Dim err As ErrorMessage
                        err = New ErrorMessage
                        err.lblMsg.Text = "Failed to update Appointment."
                        err.ShowDialog()
                    End If
                End With
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If gvView.Rows.Count = 0 And dtpDate.Value.ToString < dtpDate.Value.ToString Then
            MessageBox.Show("Please check your date and services", "Message",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf gvView.Rows.Count = 0 Then
            MessageBox.Show("Please add service.", "Message",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf dtpDate.Value.ToString < dtpDate.Value.ToString Then
            MessageBox.Show("Please check your date", "Message",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            If add = True Then
                doAdd()
            ElseIf edit = True Then
                doEdit()
            End If
        End If

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        EnableInput(Me)
        OnActionButton()
        add = False
        edit = True
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If btnClose.Text = "Cancel" Then
            ResetButton()
            ClearInput(Me)
            DisableInput(Me)

            gvView.Rows.Clear()
            rdbMale.Checked = True
            rdbWalkin.Checked = True

            btnClose.Text = "Close"
            btnNewCustomer.Text = "New Customer"
        ElseIf btnClose.Text = "Close" Then
            Me.Close()
        End If
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        AllowedOnly(LetterOnly, txtName)
        txtName.MaxLength = 15
    End Sub

    Private Sub txtCN_TextChanged_1(sender As Object, e As EventArgs) Handles txtCN.TextChanged
        PhoneFormat(txtCN)
        ContactNo(txtCN)
        AllowedOnly(NumberWDash, txtCN)
        txtCN.MaxLength = 13
    End Sub

    Private Sub gvView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvView.CellContentClick
        If e.ColumnIndex = 5 Then
            gvView.Rows.RemoveAt(appointment.ServiceID)
            recount()
        End If
    End Sub

    Private Sub rdbWalkin_CheckedChanged(sender As Object, e As EventArgs) Handles rdbWalkin.CheckedChanged
        lblTimeNow.Show()
        lblDateNow.Show()

        dtpTime.Hide()
        dtpDate.Hide()
    End Sub

    Private Sub rdbReservation_CheckedChanged(sender As Object, e As EventArgs) Handles rdbReservation.CheckedChanged
        dtpTime.Show()
        dtpDate.Show()

        lblTimeNow.Hide()
        lblDateNow.Hide()
    End Sub
End Class