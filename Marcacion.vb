Imports System.Data.SqlClient
Public Class Form1
    'String donde se guarda la informacion de la BD
    '"Data Source=nombre_servidor;Initial Catalog=nombre_base_datos;User ID=usuario;Password=contraseña"
    Private conexionstr As String = "Data Source=11ITACHIKUN;Initial Catalog=sys_COMINDDB;User ID=sa;Password=admin123"
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs)
        Label4.Text = TimeOfDay
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer2.Enabled = True
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged

    End Sub
    'Hora de Salida
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox3.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
    'Boton de registro
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If String.IsNullOrEmpty(TextBox1.Text) OrElse String.IsNullOrEmpty(TextBox2.Text) OrElse String.IsNullOrEmpty(TextBox3.Text) Then
            MessageBox.Show("Debe completar todos los campos.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim idtrabajador As String = TextBox3.Text
            Dim horaentrada As String = TextBox1.Text
            Dim horasalida As String = TextBox2.Text
            Dim fechaActual As DateTime = DateTime.Now.Date
            Using connection As New SqlConnection(conexionstr)
                Try
                    connection.Open()
                    Dim query As String = "INSERT INTO HORARIOS (ID_EMPLEADO, HORA_ENTRADA, HORA_SALIDA, FECHA) VALUES (@IdTrabajador, @HoraEntrada, @HoraSalida, @Fecha)"
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@IdTrabajador", idtrabajador)
                        command.Parameters.AddWithValue("@HoraEntrada", horaentrada)
                        command.Parameters.AddWithValue("@HoraSalida", horasalida)
                        command.Parameters.AddWithValue("@Fecha", fechaActual)
                        command.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("La hora ha sido registrada con éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TextBox3.Text = ""
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                Catch ex As SqlException
                    If ex.Number = 547 Then
                        MessageBox.Show("Error: El trabajador con el ID especificado no existe.", "Error de inserción", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        MessageBox.Show("Error al registrar el horario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Try
            End Using
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim oform As New Form2
        oform.Show()
        Me.Visible = False
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
    'id del trabajador
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
    'hora de entrada
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label11.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Application.Exit()
    End Sub
End Class
