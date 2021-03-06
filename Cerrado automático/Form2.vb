Imports System.Data.OleDb
Imports System.Data
Public Class Registro
    Dim connection As New OleDbConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BCREAR.Click
        If TBUSUARIO.Text = Nothing Or TBCORREO.Text = Nothing Or TBCONTRASENA.Text = Nothing Or TB1.Text = Nothing Then
            MsgBox("Debe completar los datos solicitados primero", vbCritical, "Registrarse")
        ElseIf TBCONTRASENA.Text <> TB1.Text Then
            MsgBox("La contraseña no es igual", vbExclamation, "Registrarse")
        Else
            Try
                connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\arrob\Desktop\Proyect VS\Cerrado automático\Cerrado automático\Database2.accdb"
                If connection.State = ConnectionState.Closed Then
                    connection.Open()
                End If
            Catch ex As Exception
                MsgBox("Error al conectar con PSN", vbCritical, "Error")
                connection.Close()
                Close()
            End Try
            Dim cmd As New OleDbCommand("select count (*) from tabla1 where Correo=?", connection)
            cmd.Parameters.AddWithValue("Correo", TBCORREO.Text)
            If (Convert.ToInt32(cmd.ExecuteScalar()) > 0) Then
                MsgBox("Correo ya existente", vbCritical, "Error")
                connection.Close()
                Formulario.Timer1.Start()
                Close()
            End If
            Try
                Dim Create As New OleDbCommand("INSERT INTO Tabla1(Usuario,Correo,Contrasena) values(TBUSUARIO.Text,TBCORREO.Text,TBCONTRASENA.Text)", connection)
                Create.Parameters.AddWithValue("@1", TBUSUARIO.Text)
                Create.Parameters.AddWithValue("@2", TBCORREO.Text)
                Create.Parameters.AddWithValue("@3", TBCONTRASENA.Text)
                Create.ExecuteNonQuery()
                MsgBox("Cuenta creada correctamente" & vbNewLine & "Bienvenid@ " & TBUSUARIO.Text, vbInformation, "Registrarse")
                connection.Close()
                End
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub BCANCELAR_Click(sender As Object, e As EventArgs) Handles BCANCELAR.Click
        connection.Close()
        Close()
    End Sub
    Private Sub Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TBCONTRASENA.Clear()
        TBCORREO.Clear()
        TBUSUARIO.Clear()
        TB1.Clear()
    End Sub

    Private Sub TBCORREO_TextChanged(sender As Object, e As EventArgs) Handles TBCORREO.TextChanged
        If TBCORREO.Text <> Nothing Then
            LCORREO.Text = ""
        Else
            LCORREO.Text = "Correo electrónico"
        End If
    End Sub

    Private Sub TBUSUARIO_TextChanged(sender As Object, e As EventArgs) Handles TBUSUARIO.TextChanged
        If TBUSUARIO.Text <> Nothing Then
            LUSUARIO.Text = ""
        Else
            LUSUARIO.Text = "Usuario"
        End If
    End Sub

    Private Sub TBCONTRASENA_TextChanged(sender As Object, e As EventArgs) Handles TBCONTRASENA.TextChanged
        If TBCONTRASENA.Text <> Nothing Then
            LCONTRASENA.Text = ""
        Else
            LCONTRASENA.Text = "Contraseña"
        End If
    End Sub

    Private Sub TB1_TextChanged(sender As Object, e As EventArgs) Handles TB1.TextChanged
        If TB1.Text <> Nothing Then
            L1.Text = ""
        Else
            L1.Text = "Confirmar contraseña"
        End If
    End Sub

    Private Sub Registro_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        connection.Close()
    End Sub
End Class