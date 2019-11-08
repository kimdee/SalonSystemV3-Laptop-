Imports MySql.Data.MySqlClient
Imports MySql.Data

Public Class Position
    Private _PostionID As Integer = 0
    Public Property PositionID As Integer
        Set(value As Integer)
            _PostionID = value
        End Set
        Get
            Return _PostionID
        End Get
    End Property

    Private _PositionName As String
    Public Property PositionName As String
        Set(value As String)
            _PositionName = value
        End Set
        Get
            Return _PositionName
        End Get
    End Property

    Private _PositionStandardPay As String
    Public Property PositionStandardPay As String
        Set(value As String)
            _PositionStandardPay = value
        End Set
        Get
            Return _PositionStandardPay
        End Get
    End Property

    Private _PositionOvertime As String
    Public Property PositionOvertime As String
        Set(value As String)
            _PositionOvertime = value
        End Set
        Get
            Return _PositionOvertime
        End Get
    End Property


    Private _PositionBasicPay As String
    Public Property PositionBasicPay As String
        Set(value As String)
            _PositionBasicPay = value
        End Set
        Get
            Return _PositionBasicPay
        End Get
    End Property

    Public Sub SetPositionDetails(id As Integer)
        Try
            Dim sql As String
            sql = "SELECT * FROM Position WHERE positionID = " & id & ";"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    PositionID = reader(0)
                    PositionName = reader(1)
                    PositionStandardPay = reader(2)
                    PositionOvertime = reader(3)
                    PositionBasicPay = reader(4)
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Function AddPosition() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "INSERT INTO position (positionName,positionStandardPay,positionOvertime,positionBasicPay) VALUES (@0,@1,@2,@3);"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, PositionName, PositionStandardPay, PositionOvertime, _PositionBasicPay)
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

    Public Function EditPosition() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "UPDATE Update SET positionName=@0,positionStandardPay=@1,positionOvertime=@2,positionBasicPay=@3 WHERE positionID=@4;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, _PositionName, PositionStandardPay, PositionOvertime, PositionBasicPay, PositionID)
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
            Dim sql As String = "DELETE FROM Position WHERE positionID=@0;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, PositionID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function

    Public Sub ViewPosition(gv As DataGridView, lbl As Label)
        Try
            Dim sql As String
            Dim i As Integer = 0
            sql = "SELECT * FROM position ORDER BY positionName ASC;"
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
                    lbl.Text = "NO RESULT FOUND"
                    lbl.Show()
                End If

                gv.ClearSelection()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub LoadPositionToCBO(cbo As ComboBox)
        Try
            Dim sql As String
            sql = "SELECT * FROM Position ORDER BY positionID ASC;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                cbo.Items.Clear()
                While reader.Read()
                    cbo.Items.Add(reader(1))
                End While
                reader.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Sub LoadPositionCboTextBox(cbo As ComboBox, txtStandardPay As TextBox, txtOT As TextBox, txtBasicPay As TextBox)
        Try
            Dim sql As String
            sql = "SELECT * FROM Position WHERE positionName='" & cbo.Text & "'"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    cbo.Items.Add(reader(1))
                    txtStandardPay.Text = reader(2)
                    txtOT.Text = reader(3)
                    txtBasicPay.Text = reader(4)
                End While
                reader.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub LoadPositionTextBox(txtPosition As TextBox, txtStandardPay As TextBox, txtOT As TextBox, txtBasicPay As TextBox)
        Try
            Dim sql As String
            sql = "SELECT * FROM Position WHERE positionName='" & txtPosition.Text & "'"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    txtStandardPay.Text = reader(2)
                    txtOT.Text = reader(3)
                    txtBasicPay.Text = reader(4)
                End While
                reader.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
