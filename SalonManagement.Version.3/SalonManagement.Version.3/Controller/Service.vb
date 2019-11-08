Imports MySql.Data.MySqlClient

Public Class Service
    Private _ServiceID As Integer = 0
    Public Property ServiceID As Integer
        Set(value As Integer)
            _ServiceID = value
        End Set
        Get
            Return _ServiceID
        End Get
    End Property

    Private _AppointmentID As Integer = 0
    Public Property AppointmentID As Integer
        Set(value As Integer)
            _AppointmentID = value
        End Set
        Get
            Return _AppointmentID
        End Get
    End Property

    Private _ServiceName As String
    Public Property ServiceName As String
        Set(value As String)
            _ServiceName = value
        End Set
        Get
            Return _ServiceName
        End Get
    End Property

    Private _serviceDescription As String = ""
    Public Property ServiceDescription As String
        Set(value As String)
            _serviceDescription = value
        End Set
        Get
            Return _serviceDescription
        End Get
    End Property

    Private _servicePrice As Integer = "0"
    Public Property ServicePrice As Integer
        Set(value As Integer)
            _servicePrice = value
        End Set
        Get
            Return _servicePrice
        End Get
    End Property

    Public Sub SetServiceDetails(id As Integer)
        Try
            Dim sql As String
            sql = "SELECT * FROM Service WHERE serviceID = " & id & ";"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    ServiceID = reader(0)
                    ServiceName = reader(1)
                    ServiceDescription = reader(2)
                    ServicePrice = reader(3)
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Function AddService() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "INSERT INTO Service (serviceName,serviceDescription,servicePrice) VALUES (@0,@1,@2);"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, ServiceName, ServiceDescription, ServicePrice)
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
    Public Function EditService() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "UPDATE Service SET serviceName=@0,serviceDescription=@1,servicePrice=@2 WHERE serviceID=@3;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, ServiceName, ServiceDescription, ServicePrice, ServiceID)
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
    Public Function DeletePosition() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "DELETE FROM Service WHERE serviceID= @0;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, ServiceID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function
    Public Sub ViewService(gv As DataGridView, lbl As Label)
        Try
            Dim sql As String
            Dim i As Integer = 0
            sql = "SELECT * FROM service ORDER BY serviceName ASC;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                While reader.Read()
                    i = i + 1
                    With gv
                        .Rows.Add(reader(0), i, reader(1), reader(2), reader(3), "Edit", "Delete")
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
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub SelectService(gv As DataGridView)
        Try
            Dim sql As String
            Dim i As Integer = 0
            Dim cb As Boolean
            sql = "SELECT * FROM service ORDER BY serviceName ASC;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                While reader.Read()
                    i = i + 1
                    With gv
                        .Rows.Add(reader(0), cb, i, reader(1), reader(2), reader(3), "Remove")
                    End With
                End While
                reader.Close()
                gv.ClearSelection()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function IsServiceExist(kw As String) As Boolean
        Try
            Dim bool As Boolean = True
            Dim sql As String
            sql = "SELECT * FROM Service WHERE (BINARY serviceName = '" & kw & "') ORDER BY serviceName ASC;"
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
    Public Sub LoanServicetoCBO(cbo As ComboBox)
        Try
            Dim sql As String
            sql = "SELECT DISTINCT name FROM Service ORDER BY name;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                cbo.Items.Clear()
                While reader.Read()
                    cbo.Items.Add(reader("name"))
                End While
                reader.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
