<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empleados
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Empleados))
        TextBox1 = New TextBox()
        Label1 = New Label()
        TextBox2 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Label8 = New Label()
        TextBox7 = New TextBox()
        Label9 = New Label()
        TextBox8 = New TextBox()
        Label10 = New Label()
        TextBox9 = New TextBox()
        Label11 = New Label()
        TextBox10 = New TextBox()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(23, 35)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 27)
        TextBox1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(23, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 20)
        Label1.TabIndex = 1
        Label1.Text = "ID/Empleado"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(27, 261)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 27)
        TextBox2.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(32, 69)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 20)
        Label2.TabIndex = 3
        Label2.Text = "Nombre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(32, 120)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 20)
        Label3.TabIndex = 5
        Label3.Text = "Apellido "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(32, 176)
        Label4.Name = "Label4"
        Label4.Size = New Size(99, 20)
        Label4.TabIndex = 6
        Label4.Text = "Cargo/Puesto"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(33, 295)
        Label5.Name = "Label5"
        Label5.Size = New Size(76, 20)
        Label5.TabIndex = 7
        Label5.Text = "Dirección "
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(33, 239)
        Label6.Name = "Label6"
        Label6.Size = New Size(90, 20)
        Label6.TabIndex = 8
        Label6.Text = "Estado Civil "
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(23, 87)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(180, 27)
        TextBox3.TabIndex = 10
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(23, 143)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(180, 27)
        TextBox4.TabIndex = 11
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(27, 199)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(100, 27)
        TextBox5.TabIndex = 12
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(33, 317)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(188, 27)
        TextBox6.TabIndex = 13
        ' 
        ' Button1
        ' 
        Button1.ImageAlign = ContentAlignment.MiddleRight
        Button1.Location = New Point(217, 471)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(86, 31)
        Button1.TabIndex = 14
        Button1.Text = "Guardar "
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(336, 464)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(104, 43)
        Button2.TabIndex = 15
        Button2.Text = "limpiar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(472, 459)
        Button3.Margin = New Padding(3, 4, 3, 4)
        Button3.Name = "Button3"
        Button3.Size = New Size(104, 43)
        Button3.TabIndex = 16
        Button3.Text = "Button3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(614, 464)
        Button4.Margin = New Padding(3, 4, 3, 4)
        Button4.Name = "Button4"
        Button4.Size = New Size(104, 43)
        Button4.TabIndex = 17
        Button4.Text = "Button4"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(382, 64)
        Label8.Name = "Label8"
        Label8.Size = New Size(71, 20)
        Label8.TabIndex = 18
        Label8.Text = "Telefono "
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(320, 87)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(180, 27)
        TextBox7.TabIndex = 19
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(397, 120)
        Label9.Name = "Label9"
        Label9.Size = New Size(56, 20)
        Label9.TabIndex = 20
        Label9.Text = "correo "
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(320, 143)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(180, 27)
        TextBox8.TabIndex = 21
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(386, 176)
        Label10.Name = "Label10"
        Label10.Size = New Size(59, 20)
        Label10.TabIndex = 22
        Label10.Text = "Estatus "
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(354, 215)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(100, 27)
        TextBox9.TabIndex = 23
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(354, 261)
        Label11.Name = "Label11"
        Label11.Size = New Size(121, 20)
        Label11.TabIndex = 24
        Label11.Text = "Fecha de ingreso"
        ' 
        ' TextBox10
        ' 
        TextBox10.Location = New Point(354, 295)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(100, 27)
        TextBox10.TabIndex = 25
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(560, 35)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(278, 352)
        PictureBox1.TabIndex = 26
        PictureBox1.TabStop = False
        ' 
        ' Empleados
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(871, 541)
        Controls.Add(PictureBox1)
        Controls.Add(TextBox10)
        Controls.Add(Label11)
        Controls.Add(TextBox9)
        Controls.Add(Label10)
        Controls.Add(TextBox8)
        Controls.Add(Label9)
        Controls.Add(TextBox7)
        Controls.Add(Label8)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Empleados"
        Text = "Registro de  Empleados "
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
