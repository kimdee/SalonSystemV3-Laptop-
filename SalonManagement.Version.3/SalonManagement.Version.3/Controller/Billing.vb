Imports MySql.Data.MySqlClient

Public Class Billing

    Private _billID As Integer = 0
    Public Property BillID As Integer
        Set(value As Integer)
            _billID = value
        End Set
        Get
            Return _billID
        End Get
    End Property

    Private _appointmentID As Integer = 0
    Public Property AppointmentID As Integer
        Set(value As Integer)
            _appointmentID = value
        End Set
        Get
            Return _appointmentID
        End Get
    End Property

    Private _customerID As Integer = 0
    Public Property CustomerID As Integer
        Set(value As Integer)
            _customerID = value
        End Set
        Get
            Return _customerID
        End Get
    End Property

    Private _employeeID As Integer = 0
    Public Property EmployeeID As Integer
        Set(value As Integer)
            _employeeID = value
        End Set
        Get
            Return _employeeID
        End Get
    End Property

    Private _billingDate As Date
    Public Property BillingDate As Date
        Set(value As Date)
            _billingDate = value
        End Set
        Get
            Return _billingDate
        End Get
    End Property

    Private _billingAmount As Decimal = 0
    Public Property BillingAmount As Decimal
        Set(value As Decimal)
            _billingAmount = value
        End Set
        Get
            Return _billingAmount
        End Get
    End Property

    Private _billingStatus As String
    Public Property BillingStatus As String
        Set(value As String)
            _billingStatus = value
        End Set
        Get
            Return _billingStatus
        End Get
    End Property

    Private _appointmentType As String = "Walk In"
    Public Property AppointmentType As String
        Set(value As String)
            _appointmentType = value
        End Set
        Get
            Return _appointmentType
        End Get
    End Property

    Public Sub SetbillDetails(id As Integer)
        Try
            Dim sql As String
            sql = "SELECT * FROM billing WHERE billingid = " & id & ";"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    BillID = reader(0)
                    AppointmentID = reader(1)
                    CustomerID = reader(2)
                    EmployeeID = reader(3)
                    BillingDate = reader(4)
                    BillingAmount = reader(5)
                    BillingStatus = reader(6)
                    AppointmentType = reader(7)
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Function Addbill() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "INSERT INTO billing (appointmentID,customerID,employeeID,billingdate,billingAmount,billingStatus,appointmentType) VALUES (@0,@1,@2,@3,@4,@5,@6);"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, AppointmentID, CustomerID, EmployeeID, BillingDate, BillingAmount, BillingStatus, AppointmentType)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            MsgBox(ex.Message)
            Rollback()
            Return False
        End Try
    End Function

    Public Function Editbill() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "UPDATE billing SET appointmentID=@0,employeeID=@1,billingDate=@2,billingAmount=@3,billingStatus=@4,billingType=5 WHERE billingID=@6;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, AppointmentID, EmployeeID, BillingDate, BillingAmount, BillingStatus, AppointmentType, BillID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function

    Public Function DeleteBilling() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "DELETE FROM billing WHERE billingID=@0;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, BillID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function


    Public Sub ViewCollection(gv As DataGridView)
        Try
            Dim sql As String
            Dim i As Integer = 0
            sql = "SELECT billingID,billingDate,billingAmount,billingStatus,billingType FROM billing " _
                & "INNER JOIN appointment on billing.appointmentID=appointment.appointmentID WHERE appointment.appointmentID" _
                & "=" & AppointmentID & "and billingStatus = 0 ORDER BY billingDate DESC;"
            If IsConnected() Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                While reader.Read()
                    With gv
                        Dim paid As Decimal = 0
                        Dim due As Integer = 0
                        If Date.Compare(Date.Parse(reader(1)).Date, frmMain.dtServer.Date) <= 0 Then
                            i = i + 1
                            If Date.Compare(Date.Parse(reader(3)).Date, Date.Parse(reader(5)).Date) < 0 Then
                                due = 1
                                paid = reader(4)
                            Else
                                due = 0
                                paid = reader(2)
                            End If
                            .Rows.Add(reader(0), i, Date.Parse(reader(1)).ToString("yyyy-MMM-dd"), "₱ " & Format(reader(2), "n2"),
                                    Date.Parse(reader(3)).ToString("yyyy-MMM-dd"), "₱ " & Format(reader(4), "n2"), due, paid, False)
                        End If
                    End With
                End While
                reader.Close()
                gv.ClearSelection()
            End If

        Catch ex As Exception

        End Try
    End Sub

End Class
