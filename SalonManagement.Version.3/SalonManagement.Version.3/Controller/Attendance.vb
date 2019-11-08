Imports MySql.Data.MySqlClient

Public Class Attendance
    Private _attendanceID As Integer
    Public Property AttendanceID As Integer
        Set(value As Integer)
            _attendanceID = value
        End Set
        Get
            Return _attendanceID
        End Get
    End Property

    Private _employeeID As Integer
    Public Property EmployeeID As Integer
        Set(value As Integer)
            _employeeID = value
        End Set
        Get
            Return _employeeID
        End Get
    End Property

    Private _attendanceDate As Date
    Public Property AttendanceDate As Date
        Set(value As Date)
            _attendanceDate = value
        End Set
        Get
            Return _attendanceDate
        End Get
    End Property

    Private _attendanceMornIn As String = ""
    Public Property AttendanceMornIn As String
        Set(value As String)
            _attendanceMornIn = value
        End Set
        Get
            Return _attendanceMornIn
        End Get
    End Property

    Private _attendanceMornOut As String = ""
    Public Property AttendanceMornOut As String
        Set(value As String)
            _attendanceMornOut = value
        End Set
        Get
            Return _attendanceMornOut
        End Get
    End Property

    Private _attendanceAftIn As String = ""
    Public Property AttendanceAftIn As String
        Set(value As String)
            _attendanceAftIn = value
        End Set
        Get
            Return _attendanceAftIn
        End Get
    End Property

    Private _attendanceAftOut As String = ""
    Public Property AttendanceAftOut As String
        Set(value As String)
            _attendanceAftOut = value
        End Set
        Get
            Return _attendanceAftOut
        End Get
    End Property

    Private _Tag As Integer = 0
    Public Property Tag As Integer
        Set(value As Integer)
            _Tag = value
        End Set
        Get
            Return _Tag
        End Get
    End Property

    Public Sub SetAttendanceID()
        Try
            Dim sql As String
            sql = "SELECT LAST_INSERT_ID();"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                AttendanceID = Integer.Parse(cmd.ExecuteScalar)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub SetAttendanceDetails(id As Integer)
        Try
            Dim sql As String
            sql = "SELECT * FROM Appointment WHERE  appointmentID =" & id & ";"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    AttendanceID = reader(0)
                    EmployeeID = reader(1)
                    AttendanceDate = reader(2)
                    AttendanceMornIn = reader(3)
                    AttendanceMornOut = reader(4)
                    AttendanceAftIn = reader(5)
                    AttendanceAftOut = reader(6)
                    Tag = reader(7)
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub
    ''-------CRUD-------
    Public Function IsAttendanceAdded() As String
        Dim reader As MySql.Data.MySqlClient.MySqlDataReader
        Dim yes As Integer = 2

        Try
            Dim sql As String = "SELECT * FROM attendance WHERE employeeID='" & EmployeeID & "' and attendanceDate = '" & Format(Today.Date, "yyyy-MM-dd") & "'"
            IsConnected()
            Dim cmd = New MySqlCommand(sql, getServerConnection)
            reader = cmd.ExecuteReader()
            If reader.HasRows Then
                yes = 1
            Else
                yes = 0
            End If
        Catch ex As Exception

        End Try

        If yes = 0 Then
            Try
                Dim bool As Boolean = False
                Dim sql As String = "INSERT INTO attendance (employeeID,attendanceDate,attendanceMornIn,attendanceMornOut,attendanceAftIn,attendanceAftOut,Tag) VALUES " _
                                    & "(@0,@1,@2,@3,@4,@5,@6);"
                IsConnected()
                ServerExecuteSQL(sql, EmployeeID, AttendanceDate, AttendanceMornIn, AttendanceMornOut, AttendanceAftIn, AttendanceAftOut, Tag)
                Commit()

            Catch ex As Exception
                MsgBox(ex.Message + "Insert")
            End Try
            Return "YES"
        Else
            Return "NO"
        End If
    End Function

    Public Sub IsAttendanceUpdated()
        Dim bool As Boolean = False
        Try
            IsConnected()
            Dim sql As String = "UPDATE attendance SET attendanceDate=@0, attendanceMornIn=@1, attendanceMornOut=@2, attendanceAftIn=@3, attendanceAftOut=@4, Tag=@5 WHERE employeeID=@6;"
            ServerExecuteSQL(sql, AttendanceDate, AttendanceMornIn, AttendanceMornOut, AttendanceAftIn, AttendanceAftOut, Tag, EmployeeID)
            Commit()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub IsAttendanceDeleted()
        Dim bool As Boolean = False
        Try
            IsConnected()
            Dim sql As String = "DELETE FROM attendance WHERE employeeID=@0;"
            ServerExecuteSQL(sql, AttendanceID)
            Commit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub ViewAttendanceDashboard(gv As DataGridView)
        Try
            Dim i As Integer = 1
            Dim sql As String = "SELECT * FROM attendance INNER JOIN employee ON attendance.employeeID = employee.employeeID ORDER BY attendanceDate ASC LIMIT 100;"
            gv.Rows.Clear()
            IsConnected()
            Dim cmd = New MySqlCommand(sql, getServerConnection())
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                With gv
                    If reader(3) = reader(3) And reader(4) = "" And reader(5) = "" And reader(6) = "" Then
                        Dim offHrsWork As Integer = 8
                        Dim underTime As Integer = 0
                        Dim HrsWork As Integer = 0
                        Dim OT As Integer = 0
                        .Rows.Add(reader(0), i.ToString(), reader("employeeLN") + ", " + reader("employeeFN") + " " + reader("employeeMN"),
                            Date.Parse(reader(2)).ToShortDateString, reader(3), reader(4), reader(5), reader(6), offHrsWork, HrsWork, OT, underTime,
                            reader(7), "Manual Update")

                    ElseIf reader(3) = reader(3) And reader(4) = reader(4) And reader(5) = "" And reader(6) = "" Then
                        Dim offHrsWork As Integer = 8
                        Dim HrsWork As Integer = DateDiff(DateInterval.Hour, reader(3), reader(4))
                        Dim OT As Integer = 0

                        Dim underTime As Integer
                        If HrsWork < offHrsWork Then
                            underTime = offHrsWork - HrsWork
                        End If


                        .Rows.Add(reader(0), i.ToString(), reader("employeeLN") + ", " + reader("employeeFN") + " " + reader("employeeMN"),
                              Date.Parse(reader(2)).ToShortDateString, reader(3), reader(4), reader(5), reader(6), offHrsWork, HrsWork, OT, underTime,
                               reader(7), "Manual Update")

                    ElseIf reader(3) = reader(3) And reader(4) = reader(4) And reader(5) = reader(5) And reader(6) = "" Then
                        Dim offHrsWork As Integer = 8
                        Dim HrsWork As Integer = DateDiff(DateInterval.Hour, reader(3), reader(4))
                        Dim OT As Integer = 0

                        Dim underTime As Integer
                        If HrsWork < offHrsWork Then
                            underTime = offHrsWork - HrsWork
                        End If

                        .Rows.Add(reader(0), i.ToString(), reader("employeeLN") + ", " + reader("employeeFN") + " " + reader("employeeMN"),
                              Date.Parse(reader(2)).ToShortDateString, reader(3), reader(4), reader(5), reader(6), offHrsWork, HrsWork, OT, underTime,
                              reader(7), "Manual Update")

                    ElseIf reader(3) = reader(3) And reader(4) = reader(4) And reader(5) = reader(5) And reader(6) = reader(6) Then
                        Dim offHrsWork As Integer = 8
                        Dim HrsWork As Integer = DateDiff(DateInterval.Hour, reader(3), reader(6))

                        Dim OT As Integer
                        If HrsWork > offHrsWork Then
                            OT = HrsWork - offHrsWork
                        End If

                        Dim underTime As Integer
                        If HrsWork < offHrsWork Then
                            underTime = offHrsWork - HrsWork
                        End If

                        .Rows.Add(reader(0), i.ToString(), reader("employeeLN") + ", " + reader("employeeFN") + " " + reader("employeeMN"),
                             Date.Parse(reader(2)).ToShortDateString, reader(3), reader(4), reader(5), reader(6), offHrsWork, HrsWork, OT, underTime,
                              reader(7), "Manual Update")
                    End If
                    i = i + 1
                End With
            End While
            reader.Close()
            gv.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub ViewAttendance(gv As DataGridView)
        Try
            Dim i As Integer = 1
            Dim sql As String = "SELECT * FROM attendance INNER JOIN employee ON attendance.employeeID = employee.employeeID ORDER BY attendanceDate ASC LIMIT 100;"
            gv.Rows.Clear()
            IsConnected()
            Dim cmd = New MySqlCommand(sql, getServerConnection())
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                With gv
                    If reader(3) = reader(3) And reader(4) = "" And reader(5) = "" And reader(6) = "" Then
                        Dim offHrsWork As Integer = 8
                        Dim underTime As Integer = 0
                        Dim HrsWork As Integer = 0
                        Dim OT As Integer = 0
                        .Rows.Add(reader(0), i.ToString(), reader("employeeLN") + ", " + reader("employeeFN") + " " + reader("employeeMN"),
                            Date.Parse(reader(2)).ToShortDateString, reader(3), reader(4), reader(5), reader(6), offHrsWork, HrsWork, OT, underTime,
                            reader(7), "Manual Update")

                    ElseIf reader(3) = reader(3) And reader(4) = reader(4) And reader(5) = "" And reader(6) = "" Then
                        Dim offHrsWork As Integer = 8
                        Dim HrsWork As Integer = DateDiff(DateInterval.Hour, reader(3), reader(4))
                        Dim OT As Integer = 0

                        Dim underTime As Integer
                        If HrsWork < offHrsWork Then
                            underTime = offHrsWork - HrsWork
                        End If


                        .Rows.Add(reader(0), i.ToString(), reader("employeeLN") + ", " + reader("employeeFN") + " " + reader("employeeMN"),
                              Date.Parse(reader(2)).ToShortDateString, reader(3), reader(4), reader(5), reader(6), offHrsWork, HrsWork, OT, underTime,
                               reader(7), "Manual Update")

                    ElseIf reader(3) = reader(3) And reader(4) = reader(4) And reader(5) = reader(5) And reader(6) = "" Then
                        Dim offHrsWork As Integer = 8
                        Dim HrsWork As Integer = DateDiff(DateInterval.Hour, reader(3), reader(4))
                        Dim OT As Integer = 0

                        Dim underTime As Integer
                        If HrsWork < offHrsWork Then
                            underTime = offHrsWork - HrsWork
                        End If

                        .Rows.Add(reader(0), i.ToString(), reader("employeeLN") + ", " + reader("employeeFN") + " " + reader("employeeMN"),
                              Date.Parse(reader(2)).ToShortDateString, reader(3), reader(4), reader(5), reader(6), offHrsWork, HrsWork, OT, underTime,
                              reader(7), "Manual Update")

                    ElseIf reader(3) = reader(3) And reader(4) = reader(4) And reader(5) = reader(5) And reader(6) = reader(6) Then
                        Dim offHrsWork As Integer = 8
                        Dim HrsWork As Integer = DateDiff(DateInterval.Hour, reader(3), reader(6))

                        Dim OT As Integer
                        If HrsWork > offHrsWork Then
                            OT = HrsWork - offHrsWork
                        End If

                        Dim underTime As Integer
                        If HrsWork < offHrsWork Then
                            underTime = offHrsWork - HrsWork
                        End If

                        .Rows.Add(reader(0), i.ToString(), reader("employeeLN") + ", " + reader("employeeFN") + " " + reader("employeeMN"),
                             Date.Parse(reader(2)).ToShortDateString, reader(3), reader(4), reader(5), reader(6), offHrsWork, HrsWork, OT, underTime,
                              reader(7), "Manual Update")
                    End If
                    i = i + 1
                End With
            End While
            reader.Close()
            gv.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    '-------'Update MorningOut/AfternoonIn/AfternoonOut-------
    Public Sub UpdateMorningOut()
        Dim bool As Boolean = False
        Try
            IsConnected()
            Dim sql As String = "UPDATE attendance SET attendanceMornOut=@0 WHERE employeeID=@1 and attendanceDate=DATE(NOW());"
            ServerExecuteSQL(sql, AttendanceMornOut, EmployeeID)
            Commit()
        Catch ex As Exception
            MsgBox(ex.Message + " Here MorningOut")
        End Try
    End Sub
    Public Sub UpdateAfternoonIn()
        Dim bool As Boolean = False
        Try
            IsConnected()
            Dim sql As String = "UPDATE attendance SET attendanceAftIn=@0 WHERE employeeID=@1 and attendanceDate=DATE(NOW());"
            ServerExecuteSQL(sql, AttendanceAftIn, EmployeeID)
            Commit()
        Catch ex As Exception
            MsgBox(ex.Message + " Here AfternoonIn")
        End Try
    End Sub
    Public Sub UpdateAfternoonOut()
        Dim bool As Boolean = False
        Try
            IsConnected()
            Dim sql As String = "UPDATE attendance SET attendanceAftOut=@0 WHERE employeeID=@1 and attendanceDate=DATE(NOW());"
            ServerExecuteSQL(sql, AttendanceAftOut, EmployeeID)
            Commit()
        Catch ex As Exception
            MsgBox(ex.Message + " Here AfternoonOut")
        End Try
    End Sub

    ''-------TimeIn Already-------

    ''MorningIn - MorningOut
    Public Function IsInMorningIn(id As String) As Boolean
        Dim reader As MySql.Data.MySqlClient.MySqlDataReader
        Dim bool As Boolean = False
        Try
            Dim sql As String = "SELECT * FROM attendance WHERE employeeID = '" & id & "' and attendanceDate = DATE(NOW()) and attendanceMornIn <> '' and attendanceMornOut = '';"
            IsConnected()
            Dim cmd = New MySqlCommand(sql, getServerConnection())
            reader = cmd.ExecuteReader()
            While reader.Read()
                AttendanceID = reader(0)
                EmployeeID = reader(1)
                AttendanceDate = reader(2)
                AttendanceMornIn = reader(3)
                AttendanceMornOut = reader(4)
                AttendanceAftIn = reader(5)
                AttendanceAftOut = reader(6)
                Tag = reader(7)
                bool = True
            End While
            reader.Close()
            Return bool
        Catch ex As Exception
            MsgBox(ex.Message + "Is In MorningIn")
            Return False
        End Try
    End Function

    ''MorningOut - AfternoonIn
    Public Function IsInMorningOut(id As String) As Boolean
        Dim reader As MySql.Data.MySqlClient.MySqlDataReader
        Dim bool As Boolean = False
        Try
            Dim sql As String = "SELECT * FROM attendance WHERE employeeID = '" & id & "' and attendanceDate=DATE(NOW()) and attendanceMornOut <> '' and attendanceAftIn = '';"
            IsConnected()
            Dim cmd = New MySqlCommand(sql, getServerConnection())
            reader = cmd.ExecuteReader()
            While reader.Read()
                AttendanceID = reader(0)
                EmployeeID = reader(1)
                AttendanceDate = reader(2)
                AttendanceMornIn = reader(3)
                AttendanceMornOut = reader(4)
                AttendanceAftIn = reader(5)
                AttendanceAftOut = reader(6)
                Tag = reader(7)
                bool = True
            End While
            reader.Close()
            Return bool
        Catch ex As Exception
            MsgBox(ex.Message + "Is In MorningOut")
            Return False
        End Try
    End Function

    ''AfternoonIn - AfternoonOut
    Public Function IsInAfternoonIn(id As String) As Boolean
        Dim reader As MySql.Data.MySqlClient.MySqlDataReader
        Dim bool As Boolean = False
        Try
            Dim sql As String = "SELECT * FROM attendance WHERE employeeID = '" & id & "' and attendanceDate=DATE(NOW()) and attendanceAftIn <> '' and attendanceAftOut = '';"
            IsConnected()
            Dim cmd = New MySqlCommand(sql, getServerConnection())
            reader = cmd.ExecuteReader()
            While reader.Read()
                AttendanceID = reader(0)
                EmployeeID = reader(1)
                AttendanceDate = reader(2)
                AttendanceMornIn = reader(3)
                AttendanceMornOut = reader(4)
                AttendanceAftIn = reader(5)
                AttendanceAftOut = reader(6)
                Tag = reader(7)
                bool = True
            End While
            reader.Close()
            Return bool
        Catch ex As Exception
            MsgBox(ex.Message + "Is In AfternoonIn")
            Return False
        End Try
    End Function
End Class
