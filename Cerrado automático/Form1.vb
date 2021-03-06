Imports System.Data.OleDb
Imports System.Data
Public Class Formulario
    Dim connection As New OleDbConnection(My.Settings.DataBase2ConnectionString)
    Private Sub BINGRESAR_Click(sender As Object, e As EventArgs) Handles BINGRESAR.Click
        If TBCORREO.Text = Nothing Or TBCONTRASENA.Text = Nothing Then
            Timer1.Stop()
            MsgBox("Debe completar los datos solicitados primero", vbCritical, "Iniciar sesión")
            TBCONTRASENA.Text = ""
            Timer1.Start()
        Else
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            Dim cmd As New OleDbCommand("SELECT COUNT (*) from tabla1 where Correo=? and Contrasena=?", connection)
            cmd.Parameters.AddWithValue("Correo", TBCORREO.Text)
            cmd.Parameters.AddWithValue("Contrasena", TBCONTRASENA.Text)
            If Convert.ToInt32(cmd.ExecuteScalar()) > 0 Then
                Timer1.Stop()
                MsgBox("Bienvenid@ " & TBCORREO.Text, vbInformation, "PSN")
                connection.Close()
                Close()
            Else
                Timer1.Stop()
                    MsgBox("Contraseña y/o correo incorrectos", vbExclamation, "Error")
                    TBCONTRASENA.Text = ""
                    Timer1.Start()
                End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LMS.Text -= 1
        If LMS.Text <= 0 Then
            LMS.Text = 9
            LS.Text -= 1
        End If
        If LS.Text <= 0 Then
            LS.Text = 59
            LM.Text -= 1
        End If
        If LM.Text <= -1 Then
            LMS.Text = "00"
            LS.Text = "00"
            LM.Text = "0"
            Timer1.Stop()
            MsgBox("Tiempo de espera agotado", vbCritical, "Error")
            End
        End If
    End Sub

    Private Sub Formulario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        LMS.Text = 9
        LS.Text = 59
        LM.Text = 1
    End Sub

    Private Sub BCREAR_Click(sender As Object, e As EventArgs) Handles BCREAR.Click
        Timer1.Stop()
        TBCORREO.Text = ""
        TBCONTRASENA.Text = ""
        Registro.ShowDialog()
    End Sub

    Private Sub TBCORREO_TextChanged(sender As Object, e As EventArgs) Handles TBCORREO.TextChanged
        If TBCORREO.Text <> Nothing Then
            LCORREO.Text = ""
        Else
            LCORREO.Text = "Correo electrónico"
        End If
    End Sub

    Private Sub TBCONTRASENA_TextChanged(sender As Object, e As EventArgs) Handles TBCONTRASENA.TextChanged
        If TBCONTRASENA.Text <> Nothing Then
            LCONTRASENA.Text = ""
        Else
            LCONTRASENA.Text = "Contraseña"
        End If
    End Sub

    Private Sub Formulario_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        connection.Close()
    End Sub
End Class