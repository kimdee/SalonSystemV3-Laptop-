Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class Deduction
    Private _deductionID As Integer = 0
    Public Property DeductionID As Integer
        Set(value As Integer)
            _deductionID = value
        End Set
        Get
            Return _deductionID
        End Get
    End Property

    Private _deductionType As String
    Public Property DeductionType As String
        Set(value As String)
            _deductionType = value
        End Set
        Get
            Return _deductionType
        End Get
    End Property


    Private _deductionAmount As String
    Public Property DeductionAmount As String
        Set(value As String)
            _deductionAmount = value
        End Set
        Get
            Return _deductionAmount
        End Get
    End Property

    Public Sub SetDeductionDetails(id As Integer)
        Try
            Dim sql As String
            sql = "SELECT * FROM Deduction WHERE deductionID =" & id & ";"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    DeductionID = reader(0)
                    DeductionType = reader(1)
                    DeductionAmount = reader(2)
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Function AddDeduction() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "INSERT INTO deduction (deductionType,deductionAmount) VALUES (@0,@1);"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, DeductionType, DeductionAmount)
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
    Public Function EditDeduction() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "UPDATE Deduction SET deductionType=@0,deductionAmount=@1 WHERE deductionID=@2;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, DeductionType, DeductionAmount, DeductionID)
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
    Public Function DeleteDeduction() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "DELETE FROM Deduction WHERE deductionID=@0;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, DeductionID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function

    Public Sub ViewDeduction(gv As DataGridView, lbl As Label)
        Try
            Dim sql As String
            Dim i As Integer = 0

            sql = "SELECT * FROM Deduction ORDER BY deductionType ASC;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                While reader.Read()
                    i = i + 1
                    With gv
                        .Rows.Add(reader(0), i, reader(1), reader(2), "Edit", "Delete")
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


    Public Sub SelectDeduction(gv As DataGridView)
        Try
            Dim sql As String
            Dim i As Integer = 0
            Dim cb As Boolean
            sql = "SELECT * FROM Deduction ORDER BY deductionType ASC;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                While reader.Read()
                    i = i + 1
                    With gv
                        .Rows.Add(reader(0), cb, i, reader(1), reader(2), "Select")
                    End With
                End While
                reader.Close()

                'If gv.RowCount > 0 Then
                '    lbl.Hide()
                'Else
                '    lbl.Text = "NO RESULT FOUND"
                '    lbl.Show()
                'End If

                gv.ClearSelection()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Function IsDeductionTypeExist(kw As String) As Boolean
        Try
            Dim bool As Boolean = True
            Dim sql As String
            sql = "SELECT * FROM Deduction WHERE (BINARY deductionType='" & kw & "') ORDER BY deductionType ASC;"
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
