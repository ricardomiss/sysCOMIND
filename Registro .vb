Imports System.Data.SqlClient
Public Class Empleados
    'String donde se guarda la informacion de la BD
    '"Data Source=nombre_servidor;Initial Catalog=nombre_base_datos;User ID=usuario;Password=contraseña"
    Private conexionstr As String = "Data Source=11ITACHIKUN;Initial Catalog=sys_COMINDDB;User ID=sa;Password=admin123"
    Private Sub Button1_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim oform As New mostrar_Empleados
        oform.Show()
        Me.Visible = False
    End Sub

    Private Sub Label8_Click_1(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub
    'Boton de Registro
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(TextBox1.Text) OrElse String.IsNullOrEmpty(TextBox2.Text) OrElse String.IsNullOrEmpty(TextBox3.Text) OrElse String.IsNullOrEmpty(TextBox4.Text) OrElse String.IsNullOrEmpty(TextBox5.Text) OrElse String.IsNullOrEmpty(TextBox6.Text) OrElse String.IsNullOrEmpty(TextBox7.Text) OrElse String.IsNullOrEmpty(TextBox8.Text) OrElse String.IsNullOrEmpty(TextBox9.Text) OrElse String.IsNullOrEmpty(TextBox10.Text) Then
            MessageBox.Show("Debe completar todos los campos.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If RegistrarEmpleado() Then
                MessageBox.Show("Empleado registrado con éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox6.Text = ""
                TextBox7.Text = ""
                TextBox8.Text = ""
                TextBox9.Text = ""
                TextBox10.Text = ""
            Else
                MessageBox.Show("Error al registrar el empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
    Private Function RegistrarEmpleado() As Boolean
        Using connection As New SqlConnection(conexionstr)
            Try
                connection.Open()
                Dim query As String = "INSERT INTO EMPLEADO (ID_EMPLEADO, NOMBRE, APELLIDO, TELEFONO, CORREO, CARGO, ESTADO, ESTATUS, FECHA, DIRECCION) VALUES (@IdEmpleado, @Nombre, @Apellido, @Telefono, @Correo, @Cargo, @Estado, @Estatus, @Fecha, @Direccion)"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@IdEmpleado", TextBox1.Text)
                    command.Parameters.AddWithValue("@Nombre", TextBox3.Text)
                    command.Parameters.AddWithValue("@Apellido", TextBox4.Text)
                    command.Parameters.AddWithValue("@Cargo", TextBox5.Text)
                    command.Parameters.AddWithValue("@Estado", TextBox2.Text)
                    command.Parameters.AddWithValue("@Direccion", TextBox6.Text)
                    command.Parameters.AddWithValue("@Telefono", TextBox7.Text)
                    command.Parameters.AddWithValue("@Correo", TextBox8.Text)
                    command.Parameters.AddWithValue("@Estatus", TextBox9.Text)
                    command.Parameters.AddWithValue("@Fecha", TextBox10.Text)
                    command.ExecuteNonQuery()
                    Return True
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al registrar el empleado: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Using
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim oform As New Form3
        oform.Show()
        Me.Visible = False
    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
    End Sub
    'IdEmpleado
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
    'Nombre
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
    'Apellido
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub
    'Puesto
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub
    'Estado Civil
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
    'Direccion
    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub
    'Telefono
    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub
    'Correo
    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub
    'Estatus
    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    End Sub
    'Fecha de Ingreso
    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged

    End Sub

    Private Sub Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class