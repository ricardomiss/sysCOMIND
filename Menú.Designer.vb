<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form3))
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button6 = New Button()
        btnsalir = New Button()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        Label9 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(75, 75)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(154, 135)
        Button2.TabIndex = 1
        Button2.Text = "Registrar Empleado"
        Button2.UseVisualStyleBackColor = True
        Button2.Visible = False
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(434, 75)
        Button3.Margin = New Padding(3, 4, 3, 4)
        Button3.Name = "Button3"
        Button3.Size = New Size(153, 135)
        Button3.TabIndex = 2
        Button3.Text = "Control de horas"
        Button3.UseVisualStyleBackColor = True
        Button3.Visible = False
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(250, 237)
        Button4.Margin = New Padding(3, 4, 3, 4)
        Button4.Name = "Button4"
        Button4.Size = New Size(154, 135)
        Button4.TabIndex = 3
        Button4.Text = "Permisos"
        Button4.UseVisualStyleBackColor = True
        Button4.Visible = False
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(475, 395)
        Button6.Margin = New Padding(3, 4, 3, 4)
        Button6.Name = "Button6"
        Button6.Size = New Size(154, 43)
        Button6.TabIndex = 5
        Button6.Text = "Salir"
        Button6.UseVisualStyleBackColor = True
        Button6.Visible = False
        ' 
        ' btnsalir
        ' 
        btnsalir.BackColor = Color.Red
        btnsalir.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        btnsalir.ForeColor = Color.Black
        btnsalir.Location = New Point(515, 390)
        btnsalir.Margin = New Padding(3, 4, 3, 4)
        btnsalir.Name = "btnsalir"
        btnsalir.Size = New Size(72, 53)
        btnsalir.TabIndex = 8
        btnsalir.Text = "Salir"
        btnsalir.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.empleados
        PictureBox1.Location = New Point(75, 75)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(154, 135)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.calendar
        PictureBox2.Location = New Point(433, 76)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(154, 135)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 10
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.permission
        PictureBox3.Location = New Point(250, 238)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(154, 135)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 11
        PictureBox3.TabStop = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(62, 213)
        Label9.Name = "Label9"
        Label9.Size = New Size(182, 25)
        Label9.TabIndex = 12
        Label9.Text = "Registrar Empleado"
        Label9.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(280, 376)
        Label1.Name = "Label1"
        Label1.Size = New Size(93, 25)
        Label1.TabIndex = 13
        Label1.Text = "Permisos"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(434, 214)
        Label2.Name = "Label2"
        Label2.Size = New Size(159, 25)
        Label2.TabIndex = 14
        Label2.Text = "Control de Horas"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(678, 500)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Label9)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(btnsalir)
        Controls.Add(Button6)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form3"
        Text = "Menu"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
