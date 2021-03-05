Public Class Formulario
    Private Const M1 As String = "-----.-..... -.-.----..."
    Private Const entrar As String = "@gmail.comhello"
    Private Const existente As String = "@gmail.com"

    Private Sub BINGRESAR_Click(sender As Object, e As EventArgs) Handles BINGRESAR.Click

        If TBCORREO.Text & TBCONTRASENA.Text = entrar Then
            Timer1.Stop()
            MsgBox("Bienvenido", vbInformation, "PSN")
            Close()
        End If
        If TBCORREO.Text = M1 Then
            Timer1.Stop()
            MsgBox("Welcome", vbInformation, "PSN")
            Close()
        Else
            Timer1.Stop()
            MsgBox("Contraseña y/o correo incorrectos", vbExclamation, "Error")
            TBCONTRASENA.Text = ""
            Timer1.Start()
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
        'If TBCORREO.Text = existente Then
        '    MsgBox("Correo ya existente", vbCritical, "Log In")
        'Else
        If TBCORREO.Text & TBCONTRASENA.Text = "" Then
            Timer1.Stop()
            MsgBox("Debes completar los datos requeridos primero", vbCritical, "Registrarse")
            Timer1.Start()
        End If
        'End If
        If TBCORREO.Text IsNot "" Then
            If TBCONTRASENA.Text IsNot "" Then
                'If TBCORREO.Text IsNot existente Then
                Timer1.Stop()
                MsgBox("Bienvenido", vbInformation, "Registrado")
            Else
                Timer1.Stop()
                MsgBox("Debes completar los datos requeridos primero", vbCritical, "Registrarse")
                Timer1.Start()
            End If
        End If
        'End If
        'If TBCORREO.Text IsNot existente Then
        If TBCONTRASENA.Text IsNot "" Then
            If TBCORREO.Text IsNot "" Then
                Close()
            Else
                Timer1.Stop()
                MsgBox("Debes completar los datos requeridos primero", vbCritical, "Registrarse")
                Timer1.Start()
            End If
        End If
        'End If
    End Sub
End Class