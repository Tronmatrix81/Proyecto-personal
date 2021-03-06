Imports System.Data.OleDb
Imports System.Data
Public Class Registro
    Dim connection As New OleDbConnection(My.Settings.DataBase2ConnectionString)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BCREAR.Click
        If TBUSUARIO.Text = Nothing Or TBCORREO.Text = Nothing Or TBCONTRASENA.Text = Nothing Or TB1.Text = Nothing Then
            MsgBox("Debe completar los datos solicitados primero", vbCritical, "Registrarse")
        ElseIf TBCONTRASENA.Text <> TB1.Text Then
            MsgBox("La contraseña no es igual", vbExclamation, "Registrarse")
        Else

            Try
                If connection.State = ConnectionState.Closed Then
                    connection.Open()
                End If

                Dim cmd As New OleDbCommand("select count (*) from tabla1 where Correo=? and CONTRASENA=?", connection)
                cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = TBCORREO.Text
                cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = TBCONTRASENA.Text
                Dim count = Convert.ToInt32(cmd.ExecuteScalar())

                If (count > 0) Then
                    MsgBox("Correo ya existente", vbCritical, "Error")
                    Close()
                End If

                Using Create As New OleDbCommand("insert into Tabla1([Correo],[CONTRASENA],[Usuario]) values(TBCORREO.Text,TBCONTRASENA.Text,TBUSUARIO.Text)", connection)
                    Create.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = TBCORREO.Text
                    Create.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = TBCONTRASENA.Text
                    Create.Parameters.AddWithValue("@3", OleDbType.VarChar).Value = TBUSUARIO.Text

                    Create.ExecuteNonQuery()
                    connection.Close()
                End Using

                MsgBox("Cuenta creada correctamente" & vbNewLine & "Bienvenid@ " & TBUSUARIO.Text, vbInformation, "Registrarse")
                Close()

            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub BCANCELAR_Click(sender As Object, e As EventArgs) Handles BCANCELAR.Click
        Close()
    End Sub

    Private Sub Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TBCONTRASENA.Clear()
        TBCORREO.Clear()
        TBUSUARIO.Clear()
        TB1.Clear()
    End Sub
End Class