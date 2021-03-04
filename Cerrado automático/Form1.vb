Public Class Formulario

    Private Sub BINGRESAR_Click(sender As System.Object, e As System.EventArgs) Handles BINGRESAR.Click
        Dim entrar As String
        Dim morse As String
        entrar = "arrobajustie@gmail.comhello"
        morse = "-----.-.....-.-.----..."
        If TBCORREO.Text & TBCONTRASENA.Text = entrar Then
            Timer1.Stop()
            MsgBox(("Bienvenido"(TBCORREO.Text)), vbInformation, "PSN")
            Close()
        End If
        If TBCORREO.Text = morse Then
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

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
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

    Private Sub Formulario_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        LMS.Text = 9
        LS.Text = 59
        LM.Text = 1
    End Sub

    Private Sub BCREAR_Click(sender As System.Object, e As System.EventArgs) Handles BCREAR.Click
        If TBCORREO.Text & TBCONTRASENA.Text = "" Then
            Timer1.Stop()
            MsgBox("Debes completar los datos requeridos primero", vbCritical, "Registrarse")
            Timer1.Start()
        End If
        If TBCORREO.Text <> "" Then
            If TBCONTRASENA.Text <> "" Then
                Timer1.Stop()
                MsgBox("Bienvenido", vbInformation, "Registrado")
            Else
                Timer1.Stop()
                MsgBox("Debes completar los datos requeridos primero", vbCritical, "Registrarse")
                Timer1.Start()
            End If
        End If
        If TBCONTRASENA.Text <> "" Then
            If TBCORREO.Text <> "" Then
                Close()
            Else
                Timer1.Stop()
                MsgBox("Debes completar los datos requeridos primero", vbCritical, "Registrarse")
                Timer1.Start()
            End If
        End If
    End Sub
End Class