<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form2))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        ID = New TextBox()
        TextBox2 = New TextBox()
        PictureBox2 = New PictureBox()
        btnsalir = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(186, 41)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(126, 134)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(227, 178)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 37)
        Label1.TabIndex = 1
        Label1.Text = "ID"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(186, 253)
        Label2.Name = "Label2"
        Label2.Size = New Size(117, 37)
        Label2.TabIndex = 2
        Label2.Text = "Pasword"' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(182, 364)
        Button1.Name = "Button1"
        Button1.Size = New Size(121, 40)
        Button1.TabIndex = 3
        Button1.Text = "Aceptar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ID
        ' 
        ID.Location = New Point(156, 218)
        ID.Name = "ID"
        ID.Size = New Size(192, 23)
        ID.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(156, 307)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(192, 23)
        TextBox2.TabIndex = 5
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(186, 41)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(42, 34)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' btnsalir
        ' 
        btnsalir.BackColor = Color.Red
        btnsalir.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        btnsalir.ForeColor = Color.Black
        btnsalir.Location = New Point(409, 376)
        btnsalir.Name = "btnsalir"
        btnsalir.Size = New Size(63, 40)
        btnsalir.TabIndex = 7
        btnsalir.Text = "Salir"
        btnsalir.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonFace
        ClientSize = New Size(484, 418)
        Controls.Add(btnsalir)
        Controls.Add(PictureBox2)
        Controls.Add(TextBox2)
        Controls.Add(ID)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form2"
        Text = "Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ID As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnsalir As Button
End Class
