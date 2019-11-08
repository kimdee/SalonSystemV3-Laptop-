Imports MySql.Data.MySqlClient

Public Class Appointment
    Private _AppointmentID As Integer = 0
    Public Property AppointmentID As Integer
        Set(value As Integer)
            _AppointmentID = value
        End Set
        Get
            Return _AppointmentID
        End Get
    End Property

    Private _CustomerID As Integer
    Public Property CustomerID As Integer
        Set(value As Integer)
            _CustomerID = value
        End Set
        Get
            Return _CustomerID
        End Get
    End Property

    Private _serviceID As String
    Public Property ServiceID As String
        Set(value As String)
            _serviceID = value
        End Set
        Get
            Return _serviceID
        End Get
    End Property

    Private _appointmentTime As String
    Public Property AppointmentTime As String
        Set(value As String)
            _appointmentTime = value
        End Set
        Get
            Return _appointmentTime
        End Get
    End Property

    Private _appointmentDate As String
    Public Property AppointmentDate As String
        Set(value As String)
            _appointmentDate = value
        End Set
        Get
            Return _appointmentDate
        End Get
    End Property

    Private _appointmentType As String
    Public Property AppointmentType As String
        Set(value As String)
            _appointmentType = value
        End Set
        Get
            Return _appointmentType
        End Get
    End Property

    Private _appointmentStatus As String
    Public Property AppointmentStatus As String
        Set(value As String)
            _appointmentStatus = value
        End Set
        Get
            Return _appointmentStatus
        End Get
    End Property

    Private _appointmenttotalAmount As String
    Public Property AppointmentTotalAmount As String
        Set(value As String)
            _appointmenttotalAmount = value
        End Set
        Get
            Return _appointmenttotalAmount
        End Get
    End Property

    Public Sub SetAppointmentID()
        Try
            Dim sql As String
            sql = "SELECT LAST_INSERT_ID();"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                AppointmentID = Integer.Parse(cmd.ExecuteScalar)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub SetAppointmentDetails(id As Integer)
        Try
            Dim sql As String
            sql = "SELECT * FROM Appointment WHERE appointmentID =" & id & ";"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    AppointmentID = reader(0)
                    CustomerID = reader(1)
                    ServiceID = reader(2)
                    AppointmentTime = reader(3)
                    AppointmentDate = reader(4)
                    AppointmentType = reader(5)
                    AppointmentStatus = reader(6)
                    AppointmentTotalAmount = reader(7)
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Function AddAppointment() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "INSERT INTO Appointment (customerID,serviceID,appointmentTime,AppointmentDate,appointmentType,appointmentStatus,appointmentTotalAmount) VALUES (@0,@1,@2,@3,@4,@5,@6);"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, CustomerID, ServiceID, AppointmentTime, AppointmentDate, AppointmentType, AppointmentStatus, AppointmentTotalAmount)
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
    Public Function EditAppointment() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "UPDATE Appointment SET customerID=@0,serviceID=@1,appointmentTime=@2,appointmentDate=@3,appointmentType=@4,appointmentTypeStatus=@5,appointmentTotalAmount=@6 WHERE appointmentID=@7;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, CustomerID, ServiceID, AppointmentTime, AppointmentDate, AppointmentType, AppointmentStatus, AppointmentTotalAmount, AppointmentID)
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
    Public Function DeleteAppointment() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "DELETE FROM Appointment WHERE appointmentID=@0;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, AppointmentID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function

    Public Sub ViewAppointment(gv As DataGridView)
        Try
            Dim sql As String
            Dim i As Integer = 0

            sql = "SELECT * FROM appointment INNER JOIN customer ON appointment.customerID=customer.customerID INNER JOIN service ON appointment.serviceID=service.serviceID" _
                & " ORDER BY appointmentDate DESC;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                While reader.Read()
                    i = i + 1
                    With gv
                        .Rows.Add(reader(0), i, reader("customerName"), reader("serviceName"), reader(7), reader(3), reader(4), reader(5), reader(6), "Delete")
                    End With
                End While
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub UpdateStatus()
        Dim bool As Boolean = False
        Try
            IsConnected()
            Dim sql As String = "UPDATE appointment SET appointmentStatus=@0 WHERE appointmentID=@1;"
            ServerExecuteSQL(sql, AppointmentStatus, AppointmentID)
            Commit()
        Catch ex As Exception
            MsgBox(ex.Message + " Here MorningOut")
        End Try
    End Sub

    Public Function IsServiceExist(kw As DataGridView) As Boolean
        Try
            Dim bool As Boolean = True
            Dim sql As String
            sql = "SELECT serviceID FROM appointment WHERE serviceID=serviceID ORDER BY serviceID ASC;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.HasRows() Then
                    bool = True
                Else
                    bool = False
                End If
            End If
            Return bool
        Catch ex As Exception
            Return True
        End Try
    End Function
End Class