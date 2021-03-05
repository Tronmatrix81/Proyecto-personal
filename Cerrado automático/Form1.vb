Imports System.Data.OleDb
Imports System.Data

Public Class Formulario
    Dim connection As New OleDbConnection(My.Settings.DataBase2ConnectionString)
    Private Sub BINGRESAR_Click(sender As Object, e As EventArgs) Handles BINGRESAR.Click
        If TBCORREO.Text = Nothing Or TBCONTRASENA.Text = Nothing Then
            Timer1.Stop()
            MsgBox("Debe completar los datos solicitados primero", vbCritical, "Registrarse")
            TBCONTRASENA.Text = ""
            Timer1.Start()
        Else
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            Dim cmd As New OleDbCommand("select count (*) from tabla1 where Correo=? and CONTRASENA=?", connection)
            cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = TBCORREO.Text
            cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = TBCONTRASENA.Text
            Dim count = Convert.ToInt32(cmd.ExecuteScalar())

            If (count > 0) Then
                Timer1.Stop()
                MsgBox("Bienvenid@ " & TBCORREO.Text, vbInformation, "PSN")
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
        If TBCORREO.Text = Nothing Or TBCONTRASENA.Text = Nothing Then
            Timer1.Stop()
            MsgBox("Debe completar los datos solicitados primero", vbCritical, "Registrarse")
            Timer1.Start()
        Else
            Timer1.Stop()
            MsgBox("Bienvenid@ " & TBCORREO.Text, vbInformation, "PSN")
            Close()
        End If
    End Sub
End Class