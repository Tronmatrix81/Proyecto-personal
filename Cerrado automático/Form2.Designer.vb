<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBUSUARIO = New System.Windows.Forms.TextBox()
        Me.TBCORREO = New System.Windows.Forms.TextBox()
        Me.TBCONTRASENA = New System.Windows.Forms.TextBox()
        Me.TB1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BCREAR = New System.Windows.Forms.Button()
        Me.BCANCELAR = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(183, 168)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(227, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 20)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Es fácil y rápido"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(226, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(201, 29)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Abre una cuenta"
        '
        'TBUSUARIO
        '
        Me.TBUSUARIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBUSUARIO.ForeColor = System.Drawing.Color.Gray
        Me.TBUSUARIO.Location = New System.Drawing.Point(231, 84)
        Me.TBUSUARIO.Multiline = True
        Me.TBUSUARIO.Name = "TBUSUARIO"
        Me.TBUSUARIO.Size = New System.Drawing.Size(135, 27)
        Me.TBUSUARIO.TabIndex = 35
        '
        'TBCORREO
        '
        Me.TBCORREO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBCORREO.ForeColor = System.Drawing.Color.Gray
        Me.TBCORREO.Location = New System.Drawing.Point(231, 133)
        Me.TBCORREO.Multiline = True
        Me.TBCORREO.Name = "TBCORREO"
        Me.TBCORREO.Size = New System.Drawing.Size(276, 27)
        Me.TBCORREO.TabIndex = 36
        '
        'TBCONTRASENA
        '
        Me.TBCONTRASENA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBCONTRASENA.ForeColor = System.Drawing.Color.Gray
        Me.TBCONTRASENA.Location = New System.Drawing.Point(231, 186)
        Me.TBCONTRASENA.Multiline = True
        Me.TBCONTRASENA.Name = "TBCONTRASENA"
        Me.TBCONTRASENA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBCONTRASENA.Size = New System.Drawing.Size(276, 27)
        Me.TBCONTRASENA.TabIndex = 37
        '
        'TB1
        '
        Me.TB1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB1.ForeColor = System.Drawing.Color.Gray
        Me.TB1.Location = New System.Drawing.Point(231, 239)
        Me.TB1.Multiline = True
        Me.TB1.Name = "TB1"
        Me.TB1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TB1.Size = New System.Drawing.Size(276, 27)
        Me.TB1.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(228, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 15)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(228, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 15)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Correo electrónico"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(228, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 15)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Contraseña"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(228, 269)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 15)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Confirmar contraseña"
        '
        'BCREAR
        '
        Me.BCREAR.Location = New System.Drawing.Point(251, 296)
        Me.BCREAR.Name = "BCREAR"
        Me.BCREAR.Size = New System.Drawing.Size(95, 26)
        Me.BCREAR.TabIndex = 43
        Me.BCREAR.Text = "Registrarse"
        Me.BCREAR.UseVisualStyleBackColor = True
        '
        'BCANCELAR
        '
        Me.BCANCELAR.Location = New System.Drawing.Point(381, 296)
        Me.BCANCELAR.Name = "BCANCELAR"
        Me.BCANCELAR.Size = New System.Drawing.Size(95, 26)
        Me.BCANCELAR.TabIndex = 44
        Me.BCANCELAR.Text = "Cancelar"
        Me.BCANCELAR.UseVisualStyleBackColor = True
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 343)
        Me.Controls.Add(Me.BCANCELAR)
        Me.Controls.Add(Me.BCREAR)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TB1)
        Me.Controls.Add(Me.TBCONTRASENA)
        Me.Controls.Add(Me.TBCORREO)
        Me.Controls.Add(Me.TBUSUARIO)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Registro"
        Me.Text = "Registrarse"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TBUSUARIO As TextBox
    Friend WithEvents TBCORREO As TextBox
    Friend WithEvents TBCONTRASENA As TextBox
    Friend WithEvents TB1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BCREAR As Button
    Friend WithEvents BCANCELAR As Button
End Class
