Imports System.Data.SqlClient
Public Class Form2
    'String donde se guarda la informacion de la BD
    '"Data Source=nombre_servidor;Initial Catalog=nombre_base_datos;User ID=usuario;Password=contraseña"
    Private conexionstr As String = "Data Source=11ITACHIKUN;Initial Catalog=sys_COMINDDB;User ID=sa;Password=admin123"
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs)

    End Sub
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim usuario As String = ID.Text
        Dim contrasena As String = TextBox2.Text
        If verify(usuario, contrasena) Then
            Dim oform As New Form3
            oform.Show()
            Me.Visible = False
        Else
            MessageBox.Show("Credenciales incorrectas. Por favor, verifique su usuario y contraseña.", "Inicio de sesión fallido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Function verify(usuario As String, contrasena As String) As Boolean
        'conexion BD
        Using connection As New SqlConnection(conexionstr)
            Try
                connection.Open()
                ' Crear la consulta SQL para verificar las credenciales del usuario
                Dim query As String = "SELECT COUNT(*) FROM ADMIN WHERE USUARIO = @Usuario AND PASS = @Contraseña"
                Using command As New SqlCommand(query, connection)
                    ' Agregar los parámetros a la consulta
                    command.Parameters.AddWithValue("@Usuario", usuario)
                    command.Parameters.AddWithValue("@Contraseña", contrasena)

                    ' Ejecutar la consulta y obtener el resultado
                    Dim result As Integer = CInt(command.ExecuteScalar())

                    ' Si el resultado es mayor que 0, las credenciales son válidas
                    Return result > 0
                End Using
            Catch ex As Exception
                ' Manejar cualquier error en la conexión o consulta
                MessageBox.Show("Error al verificar las credenciales: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Using
    End Function
    'Contrasena
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.UseSystemPasswordChar = True
    End Sub
    'Usuario
    Private Sub ID_TextChanged(sender As Object, e As EventArgs) Handles ID.TextChanged

    End Sub
End Class