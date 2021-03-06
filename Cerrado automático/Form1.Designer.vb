<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formulario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formulario))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBCORREO = New System.Windows.Forms.TextBox()
        Me.TBCONTRASENA = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BINGRESAR = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LMS = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LS = New System.Windows.Forms.Label()
        Me.LM = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BCREAR = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Location = New System.Drawing.Point(12, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Correo electrónico"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.Location = New System.Drawing.Point(158, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña"
        '
        'TBCORREO
        '
        Me.TBCORREO.AccessibleDescription = ""
        Me.TBCORREO.Location = New System.Drawing.Point(15, 74)
        Me.TBCORREO.MaxLength = 4000
        Me.TBCORREO.Name = "TBCORREO"
        Me.TBCORREO.Size = New System.Drawing.Size(140, 20)
        Me.TBCORREO.TabIndex = 2
        Me.TBCORREO.Tag = ""
        '
        'TBCONTRASENA
        '
        Me.TBCONTRASENA.Location = New System.Drawing.Point(161, 74)
        Me.TBCONTRASENA.MaxLength = 4000
        Me.TBCONTRASENA.Name = "TBCONTRASENA"
        Me.TBCONTRASENA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBCONTRASENA.Size = New System.Drawing.Size(101, 20)
        Me.TBCONTRASENA.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(32, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(279, 31)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "PlayStation Network"
        '
        'BINGRESAR
        '
        Me.BINGRESAR.Location = New System.Drawing.Point(268, 72)
        Me.BINGRESAR.Name = "BINGRESAR"
        Me.BINGRESAR.Size = New System.Drawing.Size(75, 23)
        Me.BINGRESAR.TabIndex = 6
        Me.BINGRESAR.Text = "Ingresar"
        Me.BINGRESAR.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(12, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(185, 12)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Tiempo antes de cancelar operación"
        '
        'LMS
        '
        Me.LMS.AutoSize = True
        Me.LMS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMS.ForeColor = System.Drawing.Color.White
        Me.LMS.Location = New System.Drawing.Point(319, 166)
        Me.LMS.Name = "LMS"
        Me.LMS.Size = New System.Drawing.Size(22, 16)
        Me.LMS.TabIndex = 8
        Me.LMS.Text = "00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(302, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(11, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "."
        '
        'LS
        '
        Me.LS.AutoSize = True
        Me.LS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LS.ForeColor = System.Drawing.Color.White
        Me.LS.Location = New System.Drawing.Point(274, 166)
        Me.LS.Name = "LS"
        Me.LS.Size = New System.Drawing.Size(22, 16)
        Me.LS.TabIndex = 10
        Me.LS.Text = "00"
        '
        'LM
        '
        Me.LM.AutoSize = True
        Me.LM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LM.ForeColor = System.Drawing.Color.White
        Me.LM.Location = New System.Drawing.Point(236, 166)
        Me.LM.Name = "LM"
        Me.LM.Size = New System.Drawing.Size(15, 16)
        Me.LM.TabIndex = 11
        Me.LM.Text = "2"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(257, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(11, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = ":"
        '
        'BCREAR
        '
        Me.BCREAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCREAR.Location = New System.Drawing.Point(268, 101)
        Me.BCREAR.Name = "BCREAR"
        Me.BCREAR.Size = New System.Drawing.Size(75, 23)
        Me.BCREAR.TabIndex = 13
        Me.BCREAR.Text = "Crear cuenta"
        Me.BCREAR.UseVisualStyleBackColor = True
        '
        'Formulario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(353, 191)
        Me.Controls.Add(Me.BCREAR)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LM)
        Me.Controls.Add(Me.LS)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LMS)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BINGRESAR)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TBCONTRASENA)
        Me.Controls.Add(Me.TBCORREO)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Formulario"
        Me.Text = "Iniciar sesión"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TBCORREO As System.Windows.Forms.TextBox
    Friend WithEvents TBCONTRASENA As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BINGRESAR As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LMS As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LS As System.Windows.Forms.Label
    Friend WithEvents LM As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BCREAR As System.Windows.Forms.Button

End Class
