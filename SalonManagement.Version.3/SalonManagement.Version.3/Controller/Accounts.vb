Imports MySql.Data.MySqlClient

Public Class Accounts
    Private _AccountID As Integer = 0
    Public Property AccountID As Integer
        Set(value As Integer)
            _AccountID = value
        End Set
        Get
            Return _AccountID
        End Get
    End Property

    Private _firstname As String = ""
    Public Property FirstName As String
        Set(value As String)
            _firstname = value
        End Set
        Get
            Return _firstname
        End Get
    End Property

    Private _lastname As String = ""
    Public Property LastName As String
        Set(value As String)
            _lastname = value
        End Set
        Get
            Return _lastname
        End Get
    End Property

    Private _Accountrole As String = "administrator"
    Public Property AccountRole As String
        Set(value As String)
            _Accountrole = value
        End Set
        Get
            Return _Accountrole
        End Get
    End Property

    Private _UserName As String = "admin"
    Public Property UserName As String
        Set(value As String)
            _UserName = value
        End Set
        Get
            Return _UserName
        End Get
    End Property

    Private _Password As String = "admin"
    Public Property Password As String
        Set(value As String)
            _Password = value
        End Set
        Get
            Return _Password
        End Get
    End Property

    Private _LoginStatus As Integer = 0
    Public Property LoginStatus As Integer
        Set(value As Integer)
            _LoginStatus = value
        End Set
        Get
            Return _LoginStatus
        End Get
    End Property

    Private _Count As Integer
    Public Property Count As Integer
        Set(value As Integer)
            _Count = value
        End Set
        Get
            Return _Count
        End Get
    End Property

    Private _loginid As Integer
    Public Property loginid As Integer
        Set(value As Integer)
            _loginid = value
        End Set
        Get
            Return _loginid
        End Get
    End Property

    Public Sub SetAccountDetails(id As Integer)
        Try
            Dim sql As String
            sql = "SELECT * FROM Account WHERE accountID = " & id & ";"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    AccountID = reader(0)
                    FirstName = reader(1)
                    LastName = reader(2)
                    AccountRole = reader(3)
                    UserName = reader(4)
                    Password = reader(5)
                    LoginStatus = reader(6)
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Function AddAccount() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "INSERT INTO Account (firstname,lastname,usertype,UserName,Password,Status) VALUES (@0,@1,@2,@3,@4,@5);"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, FirstName, LastName, AccountRole, UserName, Password, 0)
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
    Public Function EditAccount() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "UPDATE Account SET firstname=@0,lastname=@1, usertype=@2,UserName=@3,Password=@4,status=@5 Where accountID = @6;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, FirstName, LastName, AccountRole, UserName, Password, LoginStatus, AccountID)
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
    Public Function DeleteAccount() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "DELETE FROM Account WHERE accountID= @0;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, AccountID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function
    Public Sub SearchAccount(kw As String, gv As DataGridView)
        Try
            Dim sql As String
            Dim i As Integer = 0
            sql = "SELECT * FROM Account WHERE (firstname LIKE '" & kw & "%' or lastname LIKE '" & kw & "%') and accountID <> " & frmMain.UserID & " ORDER BY firstname,lastname DESC;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                While reader.Read()
                    i = i + 1
                    With gv
                        .Rows.Add(reader(0), i, reader(1) + " " + reader(2), reader(3),
                                  reader(5), "Edit", "Delete")
                    End With
                End While
                reader.Close()
                gv.ClearSelection()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub ViewAccounts(gv As DataGridView, lbl As Label)
        Try
            Dim sql As String
            Dim i As Integer = 0
            sql = "SELECT * FROM Account ORDER BY firstname,lastname,username ASC;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                While reader.Read()
                    i = i + 1
                    With gv
                        .Rows.Add(reader(0), i, reader(1) + " " + reader(2), reader(4), reader(3), "Edit", "Delete")
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

    Public Function IsAccountExist(kw As String) As Boolean
        Try
            Dim bool As Boolean = True
            Dim sql As String
            sql = "SELECT * FROM Account WHERE (BINARY username = '" & kw & "') ORDER BY username ASC;"
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

    ''----VALIDATION-----
    Public Function IsCountAccount() As Integer
        Try
            Dim sql As String
            sql = "SELECT COUNT(accountID) FROM account;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
            End If
        Catch ex As Exception
            Return True
        End Try
    End Function

    Public Function ValidateUserName(cnt As String) As Boolean
        Try
            Dim sql As String
            Dim bool As Boolean
            Dim i As Integer = 0
            sql = "SELECT Username From Account Where username = '" & cnt & "';"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    bool = False
                Else
                    bool = True
                End If
                reader.Close()
            End If
            Return bool
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function ValidatePassword(cnt As String) As Boolean
        Try
            Dim sql As String
            Dim bool As Boolean
            Dim i As Integer = 0
            sql = "SELECT Password From Account Where '" & cnt & "' = Password and accountID = '" & frmMain.UserID & "';"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    bool = True
                Else
                    bool = False
                End If
                reader.Close()
            End If
            Return bool
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function IsAdminExist() As Boolean
        Try
            Dim bool As Boolean = True
            Dim sql As String
            sql = "SELECT * FROM Account WHERE role = 'Administrator' ORDER BY username ASC;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.HasRows() Then
                    bool = True
                Else
                    bool = False
                End If
                reader.Close()
            End If
            Return bool
        Catch ex As Exception
            Return True
        End Try
    End Function


    ''---LOGIN-------
    Public Function IsLogin(n As String, pw As String) As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String
            sql = "SELECT * FROM Account WHERE (BINARY username = '" & n & "' and BINARY password = '" & pw & "') LIMIT 1;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.HasRows() Then
                    bool = True
                    While reader.Read
                        AccountID = reader(0)
                    End While
                Else
                    bool = False
                    AccountID = 0
                End If
            End If
            Return bool
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Sub SetAcctID(cnt As String, tmp As String)
        Try

            Dim sql As String
            sql = "SELECT acctid FROM account Where '" & cnt & "' = username and '" & tmp & "' = password and Status = 0"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    loginid = (reader("accountID"))

                    frmMain.UserID = loginid
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub ViewLoginAccount(gv As DataGridView, lbl As Label)
        Try
            Dim sql As String
            Dim i As Integer = 0
            sql = "SELECT * FROM Account WHERE loginstatus = 1 ORDER BY firstname,lastname,username ASC;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                While reader.Read()
                    i = i + 1
                    With gv
                        .Rows.Add(reader(0), i, reader(1) + " " + reader(2), reader(3), reader(5), "Logout")
                    End With
                End While
                reader.Close()
                If gv.RowCount > 0 Then
                    lbl.Hide()
                Else
                    lbl.Text = "NO LOGIN ACCOUNTS YET"
                    lbl.Show()
                End If
                gv.ClearSelection()
            End If
        Catch ex As Exception
        End Try
    End Sub

    ''----Status---
    Public Function Editstatus(i As Integer) As Boolean
        Try
            If AccountRole = "Administrator" Then
                i = 0
            End If
            Dim bool As Boolean = False
            Dim sql As String = "UPDATE Account SET Status=@0 WHERE accountID=@1;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, i, loginid)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function

    Public Function Editpassword(str As String, ctr As String) As Boolean
        Try

            Dim bool As Boolean = False
            Dim sql As String = "UPDATE Account SET Password=@0 WHERE Acctid =@1 and Password=@2;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, str, frmMain.UserID, ctr)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function

End Class
