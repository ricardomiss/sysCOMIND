<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        MonthCalendar1 = New MonthCalendar()
        Label4 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        TextBox3 = New TextBox()
        Label8 = New Label()
        Panel1 = New Panel()
        btnsalir = New Button()
        Label10 = New Label()
        Label9 = New Label()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        Button1 = New Button()
        Button2 = New Button()
        Label11 = New Label()
        Timer2 = New Timer(components)
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(411, 27)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(275, 329)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(35, -24)
        Label1.Name = "Label1"
        Label1.Size = New Size(379, 106)
        Label1.TabIndex = 1
        Label1.Text = "COMIND"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(47, 71)
        Label2.Name = "Label2"
        Label2.Size = New Size(367, 37)
        Label2.TabIndex = 2
        Label2.Text = "CONEXIONES Y MANGUERAS"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(122, 111)
        Label3.Name = "Label3"
        Label3.Size = New Size(191, 37)
        Label3.TabIndex = 3
        Label3.Text = "INDUSTRIALES"
        ' 
        ' MonthCalendar1
        ' 
        MonthCalendar1.Location = New Point(72, 157)
        MonthCalendar1.Name = "MonthCalendar1"
        MonthCalendar1.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(342, 417)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 46)
        Label4.TabIndex = 5
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(211, 428)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(109, 27)
        TextBox1.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(376, 428)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 27)
        TextBox2.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(207, 401)
        Label5.Name = "Label5"
        Label5.Size = New Size(118, 20)
        Label5.TabIndex = 8
        Label5.Text = "Hora de Entrada"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(373, 401)
        Label6.Name = "Label6"
        Label6.Size = New Size(108, 20)
        Label6.TabIndex = 9
        Label6.Text = "Hora de Salida"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(98, 401)
        Label7.Name = "Label7"
        Label7.Size = New Size(24, 20)
        Label7.TabIndex = 10
        Label7.Text = "ID"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(58, 424)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 27)
        TextBox3.TabIndex = 11
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(501, 383)
        Label8.Name = "Label8"
        Label8.Size = New Size(0, 20)
        Label8.TabIndex = 12
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(btnsalir)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Location = New Point(741, 0)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(173, 500)
        Panel1.TabIndex = 13
        ' 
        ' btnsalir
        ' 
        btnsalir.BackColor = Color.Red
        btnsalir.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        btnsalir.ForeColor = Color.Black
        btnsalir.Location = New Point(23, 13)
        btnsalir.Margin = New Padding(3, 4, 3, 4)
        btnsalir.Name = "btnsalir"
        btnsalir.Size = New Size(72, 53)
        btnsalir.TabIndex = 17
        btnsalir.Text = "Salir"
        btnsalir.UseVisualStyleBackColor = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(3, 412)
        Label10.Name = "Label10"
        Label10.Size = New Size(110, 25)
        Label10.TabIndex = 3
        Label10.Text = "Empleados"
        Label10.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(27, 205)
        Label9.Name = "Label9"
        Label9.Size = New Size(68, 25)
        Label9.TabIndex = 2
        Label9.Text = "Admin"
        Label9.TextAlign = ContentAlignment.TopCenter
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.admin
        PictureBox3.Location = New Point(19, 95)
        PictureBox3.Margin = New Padding(3, 4, 3, 4)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(80, 93)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 1
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.empleado1
        PictureBox2.Location = New Point(19, 309)
        PictureBox2.Margin = New Padding(3, 4, 3, 4)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(80, 93)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(528, 409)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(70, 49)
        Button1.TabIndex = 14
        Button1.Text = "Limpiar "
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(617, 409)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(78, 49)
        Button2.TabIndex = 15
        Button2.Text = "Registrar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(125, 340)
        Label11.Name = "Label11"
        Label11.Size = New Size(68, 23)
        Label11.TabIndex = 16
        Label11.Text = "Label11"
        ' 
        ' Timer2
        ' 
        Timer2.Enabled = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(853, 479)
        Controls.Add(Label11)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Panel1)
        Controls.Add(Label8)
        Controls.Add(TextBox3)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(MonthCalendar1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Sys_COMIND"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button2 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents btnsalir As Button
End Class
