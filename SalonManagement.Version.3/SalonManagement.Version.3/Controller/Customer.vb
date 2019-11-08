Imports MySql.Data.MySqlClient

Public Class Customer
    Private _customerID As Integer
    Public Property CustomerID As Integer
        Set(value As Integer)
            _customerID = value
        End Set
        Get
            Return _customerID
        End Get
    End Property

    Private _customerName As String
    Public Property CustomerName As String
        Set(value As String)
            _customerName = value
        End Set
        Get
            Return _customerName
        End Get
    End Property

    Private _customerSex As String
    Public Property CustomerSex As String
        Set(value As String)
            _customerSex = value
        End Set
        Get
            Return _customerSex
        End Get
    End Property

    Private _customerCN As String
    Public Property CustomerCN As String
        Set(value As String)
            _customerCN = value
        End Set
        Get
            Return _customerCN
        End Get
    End Property

    Private _tag As Integer
    Public Property Tag As Integer
        Set(value As Integer)
            _tag = value
        End Set
        Get
            Return _tag
        End Get
    End Property

    Public Sub SetCustomerID()
        Try
            Dim sql As String
            sql = "SELECT LAST_INSERT_ID();"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                CustomerID = Integer.Parse(cmd.ExecuteScalar)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub SetCustomerDetails(id As Integer)
        Try
            Dim sql As String
            sql = "SELECT * FROM Customer WHERE CustomerID = " & id & ";"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    CustomerID = reader(0)
                    CustomerName = reader(1)
                    CustomerSex = reader(2)
                    CustomerCN = reader(3)
                    Tag = reader(4)
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Function AddCustomer() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "INSERT INTO Customer (customerName,customerSex,customerCN,tag) VALUES (@0,@1,@2,@3);"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, CustomerName, CustomerSex, CustomerCN, Tag)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function

    Public Function EditCustomer() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "UPDATE Customer SET customerName=@0,customerSex=@1,customerCN=@2,tag=@3 WHERE customerID=@4;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, CustomerName, CustomerSex, CustomerCN, Tag, CustomerID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function
    Public Function DeleteCustomer() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "DELETE FROM customer WHERE customerID = @0;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, CustomerID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function
    Public Sub ViewCustomer(gv As DataGridView, lbl As Label)
        Try
            Dim sql As String
            Dim i As Integer = 0
            sql = "SELECT * FROM customer ORDER BY customerName ASC;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                While reader.Read()
                    i = i + 1
                    With gv
                        .Rows.Add(reader(0), i, reader(1), reader(2), reader(3), reader(4), "Edit", "Delete")
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

    Public Sub SearchCustomer(lbl As Label, gv As DataGridView, tb As TextBox)
        Try
            Dim sql As String
            Dim i As Integer = 0
            sql = "SELECT * FROM customer ORDER BY customerName ASC;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                While reader.Read()
                    i = i + 1
                    With gv
                        .Rows.Add(reader(0), i, reader(1), reader(2), reader(3), reader(4), "Select")
                    End With
                End While
                reader.Close()
                If gv.RowCount > 0 Then
                    lbl.Hide()
                Else
                    lbl.Text = "Customer NOT FOUND"
                    lbl.Show()
                End If
                gv.ClearSelection()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub FilterCustomer(str As String, gv As DataGridView, lbl As Label)
        Try
            Dim sql As String
            Dim i As Integer = 0
            '            WHERE (customerName LIKE '%" & str & "%') and appointmentStatus <> 'Not Paid' and tag=1
            sql = "SELECT * FROM customer INNER JOIN appointment ON customer.customerID=appointment.customerID ORDER BY customerName ASC;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                While reader.Read()
                    i = i + 1
                    With gv
                        .Rows.Add(reader(0), i, reader(1), reader(2), reader(3), reader(4), "Select")
                    End With
                End While
                reader.Close()
                If gv.RowCount > 0 Then
                    lbl.Hide()
                Else
                    lbl.Text = "CUSTOMER NOT FOUND"
                    lbl.Show()
                End If
                gv.ClearSelection()
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class
