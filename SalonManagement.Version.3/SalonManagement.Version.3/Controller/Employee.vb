Imports MySql.Data.MySqlClient
Imports System.Drawing.Imaging
Public Class Employee
    Private _employeeID As Integer = 0
    Public Property EmployeeID As Integer
        Set(value As Integer)
            _employeeID = value
        End Set
        Get
            Return _employeeID
        End Get
    End Property

    Private Shared _lastName As String = ""
    Public Property EmployeeLN As String
        Set(value As String)
            _lastName = value
        End Set
        Get
            Return _lastName
        End Get
    End Property

    Private Shared _firstName As String = ""
    Public Property EmployeeFN As String
        Set(value As String)
            _firstName = value
        End Set
        Get
            Return _firstName
        End Get
    End Property

    Private Shared _middleInitial As String = ""
    Public Property EmployeeMN As String
        Set(value As String)
            _middleInitial = value
        End Set
        Get
            Return _middleInitial
        End Get
    End Property

    Private Shared _birthDate As Date
    Public Property EmployeeBirthDate As Date
        Set(value As Date)
            _birthDate = value
        End Set
        Get
            Return _birthDate
        End Get
    End Property

    Private Shared _gender As String = "Male"
    Public Property EmployeeGender As String
        Set(value As String)
            _gender = value
        End Set
        Get
            Return _gender
        End Get
    End Property

    Private Shared _contactNo As String = ""
    Public Property EmployeeCN As String
        Set(value As String)
            _contactNo = value
        End Set
        Get
            Return _contactNo
        End Get
    End Property

    Private Shared _position As String = ""
    Public Property EmployeePosition As String
        Set(value As String)
            _position = value
        End Set
        Get
            Return _position
        End Get
    End Property

    Private Shared _passcode As String = ""
    Public Property EmployeePasscode As String
        Set(value As String)
            _passcode = value
        End Set
        Get
            Return _passcode
        End Get
    End Property

    Private _picture As String = ""
    Public Property EmployeePicture As String
        Set(value As String)
            _picture = value
        End Set
        Get
            Return _picture
        End Get
    End Property

    Private _photo As Byte()
    Public Property Photo As Byte()
        Set(value As Byte())
            _photo = value
        End Set
        Get
            Return _photo
        End Get
    End Property

    Private Shared _status As Integer = 0
    Public Property EmployeeStatus As Integer
        Set(value As Integer)
            _status = value
        End Set
        Get
            Return _status
        End Get
    End Property

    '------PICTURE----
    Public Function ConvertImageTo64(img As Image) As String
        Try
            Dim ms As New System.IO.MemoryStream()
            img.Save(ms, ImageFormat.Bmp)
            Photo = ms.ToArray
            ms.Dispose()
            Dim base64 As String = Convert.ToBase64String(Photo)
            Return base64
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function Base64ToImage(str As String) As Image
        Try
            Dim mybyte() As Byte = Convert.FromBase64String(str)
            Dim ms As New System.IO.MemoryStream(mybyte)
            Dim img As Image
            img = Image.FromStream(ms)
            Return img
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Sub SetEmployeeID()
        Try
            Dim sql As String
            sql = "SELECT LAST_INSERT_ID();"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                EmployeeID = Integer.Parse(cmd.ExecuteScalar)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub SetEmployeeDetails(id As Integer)
        Try
            Dim sql As String
            sql = "SELECT * FROM employee WHERE employeeID = " & id & ";"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    EmployeeID = reader(0)
                    EmployeeLN = reader(1)
                    EmployeeFN = reader(2)
                    EmployeeMN = reader(3)
                    EmployeeBirthDate = reader(4)
                    EmployeeGender = reader(5)
                    EmployeeCN = reader(6)
                    EmployeePosition = reader(7)
                    EmployeePasscode = reader(8)
                    EmployeePicture = reader(9)
                    EmployeeStatus = reader(10)
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Function AddEmployee() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "INSERT INTO employee (employeeLN,employeeFN,employeeMN,employeeBirthDate,employeeGender,employeeCN,employeePosition,employeePasscode,employeePicture) VALUES (@0,@1,@2,@3,@4,@5,@6,@7,@8);"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, EmployeeLN, EmployeeFN, EmployeeMN, EmployeeBirthDate, EmployeeGender, EmployeeCN, EmployeePosition, EmployeePasscode, EmployeePicture)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function

    Public Function EditEmployee() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "UPDATE employee SET employeeLN=@0,employeeFN=@1,employeeMN=@2,employeeBirthDate=@3," _
                               & "employeeGender=@4,employeeCN=@5,employeePosition=@6,employeePasscode=@7," _
                               & "employeePicture=@8,employeeStatus=@9 WHERE employeeID=@10;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, EmployeeLN, EmployeeFN, EmployeeMN, EmployeeBirthDate, EmployeeGender,
                                  EmployeeCN, EmployeePosition, EmployeePasscode, EmployeePicture,
                                 0, EmployeeID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function
    Public Function DeleteEmployee() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "DELETE FROM employee WHERE employeeID = @0;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, EmployeeID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function
    Public Sub ViewEmployee(gv As DataGridView, lbl As Label)
        Try
            Dim sql As String
            Dim i As Integer = 0
            sql = "SELECT * FROM employee ORDER BY employeeLN,employeeFN ASC;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                While reader.Read()
                    i = i + 1
                    With gv
                        .Rows.Add(reader(0), i, reader(1) + ", " + reader(2) + " " + reader(3), reader(4),
                                  reader(5), reader(6), reader(7), reader(8), reader(9),
                                  reader(10), "Edit", "Delete")
                    End With
                End While
                reader.Close()
                If gv.RowCount > 0 Then
                    lbl.Hide()
                Else
                    lbl.Text = "EMPLOYEE NOT FOUND"
                    lbl.Show()
                End If
                gv.ClearSelection()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub SelectEmployee(gv As DataGridView)
        Try
            Dim sql As String
            Dim i As Integer = 0
            Dim cb As Boolean
            sql = "SELECT * FROM employee ORDER BY employeeLN,employeeFN ASC;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                While reader.Read()
                    i = i + 1
                    With gv
                        .Rows.Add(reader(0), cb, i, reader(1) + ", " + reader(2) + " " + reader(3), reader(5), reader(7), reader(10), "Select")
                    End With
                End While
                reader.Close()
                gv.ClearSelection()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub FilterEmployee(str As String, gv As DataGridView, lbl As Label)
        Try
            Dim sql As String
            Dim i As Integer = 0
            Dim cb As Boolean
            sql = "SELECT * FROM employee ORDER BY employeeLN,employeeFN ASC;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                While reader.Read()
                    i = i + 1
                    With gv
                        .Rows.Add(reader(0), cb, i, reader(1) + ", " + reader(2) + " " + reader(3), reader(5), reader(8), reader(10), "Select")
                    End With
                End While
                reader.Close()
                If gv.RowCount > 0 Then
                    lbl.Hide()
                Else
                    lbl.Text = "EMPLOYEE NOT FOUND"
                    lbl.Show()
                End If
                gv.ClearSelection()
            End If
        Catch ex As Exception
        End Try
    End Sub

    'AgeLimit
    Public Function GetCurrentAge(ByVal DOB As Date, serverDT As Date) As Integer
        Try
            Dim CalculateAge As Integer
            CalculateAge = serverDT.Year - DOB.Year
            If (DOB > serverDT.AddYears(-CalculateAge)) Then CalculateAge -= 1
            If CalculateAge < 0 Then
                CalculateAge = 0
            End If
            Return CalculateAge
        Catch ex As Exception
            Return 0
        End Try
    End Function
    'ReadPasscode
    Public Function IsPasscodeRead(pw As String) As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String
            sql = "SELECT * FROM Employee WHERE (BINARY employeePasscode = '" & pw & "') LIMIT 1;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.HasRows() Then
                    bool = True
                    While reader.Read
                        EmployeeID = reader(0)
                    End While
                Else
                    bool = False
                    EmployeeID = 0
                End If
            End If
            Return bool
        Catch ex As Exception
            Return False
        End Try
    End Function
    'Passcode
    Public Function IsPasscodeExist(kw As String) As Boolean
        Try
            Dim bool As Boolean = True
            Dim sql As String
            sql = "SELECT * FROM employee WHERE (BINARY passcode = '" & kw & "') ORDER BY lastName ASC;"
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
