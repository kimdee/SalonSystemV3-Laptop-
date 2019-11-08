Imports MySql.Data.MySqlClient
Imports MySql.Data
Public Class Payroll

    Private _payrollID As Integer = 0
    Public Property PayrollID As Integer
        Set(value As Integer)
            _payrollID = value
        End Set
        Get
            Return _payrollID
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

    Private _deductionID As Integer = 0
    Public Property DeductionID As Integer
        Set(value As Integer)
            _deductionID = value
        End Set
        Get
            Return _deductionID
        End Get
    End Property

    Private _payrollCommission As String = ""
    Public Property PayrollCommission As String
        Set(value As String)
            _payrollCommission = value
        End Set
        Get
            Return _payrollCommission
        End Get
    End Property

    Private _payrollOvertime As String = ""
    Public Property PayrollOvertime As String
        Set(value As String)
            _payrollOvertime = value
        End Set
        Get
            Return _payrollOvertime
        End Get
    End Property

    Private _payrollGrossPay As String = ""
    Public Property PayrollGrossPay As String
        Set(value As String)
            _payrollGrossPay = value
        End Set
        Get
            Return _payrollGrossPay
        End Get
    End Property

    Private _payrollNetPay As String = ""
    Public Property PayrollNetPay As String
        Set(value As String)
            _payrollNetPay = value
        End Set
        Get
            Return _payrollNetPay
        End Get
    End Property

    Private _payrollDate As String = ""
    Public Property PayrollDate As String
        Set(value As String)
            _payrollDate = value
        End Set
        Get
            Return _payrollDate
        End Get
    End Property

    Private _payrollTime As String = ""
    Public Property PayrollTime As String
        Set(value As String)
            _payrollTime = value
        End Set
        Get
            Return _payrollTime
        End Get
    End Property

    Public Sub SetPayrollDetails(id As Integer)
        Try
            Dim sql As String
            sql = "SELECT * FROM Payroll WHERE acctID = " & id & ";"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    PayrollID = reader(0)
                    EmployeeID = reader(1)
                    DeductionID = reader(2)
                    PayrollCommission = reader(3)
                    PayrollOvertime = reader(4)
                    PayrollGrossPay = reader(5)
                    PayrollNetPay = reader(6)
                    PayrollDate = reader(7)
                    PayrollTime = reader(8)
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Function AddPayroll() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "INSERT INTO Payroll (employeeID,deductionID,payrollCommission,payrollOvertime,payrollGrossPay,payrollNetPay,payrollDate,payrollTime) VALUES (@0,@1,@2,@3,@4,@5,@6,@7);"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, EmployeeID, DeductionID, PayrollCommission, PayrollOvertime, PayrollGrossPay, PayrollNetPay, PayrollDate, PayrollTime)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            MsgBox(ex.ToString, vbCritical, "Error")
            Return False
        End Try
    End Function

    Public Function EditPayroll() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "UPDATE Payroll SET employeeID=@0, deductionID=@1, payrollCommission=@2, payrollOvertime=@3, payrollGrossPay=@4, payrollNetPay=@5, payrollDate=@6, payrollTime=@7 WHERE payrollID=@8;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, EmployeeID, DeductionID, PayrollCommission, PayrollOvertime, PayrollGrossPay, PayrollNetPay, PayrollDate, PayrollTime, PayrollID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            MsgBox(ex.ToString, vbCritical, "Error")
            Return False
        End Try
    End Function

    Public Function DeletePayroll() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "DELETE FROM Payroll WHERE payrollID=@0;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, PayrollID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function
    Public Sub ViewPayroll(gv As DataGridView, lbl As Label)
        Try
            Dim sql As String
            Dim i As Integer = 0
            sql = "SELECT * FROM Payroll INNER JOIN Employee ON payroll.employeeID=employee.employeeID ORDER BY employee.employeeLN,employee.employeeFN ASC;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                While reader.Read()
                    i = i + 1
                    With gv
                        .Rows.Add(reader(0), i, reader("employeeLName") + ", " + reader("employeeFName") + " " + reader("employeeMName"), reader(2), reader(3), reader(4), reader(5), reader(6), reader(7), reader(8), "Delete")
                    End With
                End While
                reader.Close()
                If gv.RowCount > 0 Then
                    lbl.Hide()
                Else
                    lbl.Text = "NO RESULT FOUND"
                    lbl.Show()
                End If
                gv.ClearSelection()
            End If
        Catch ex As Exception
        End Try
    End Sub

End Class
