Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Data.SqlClient
Public Class Permisos
    'String donde se guarda la informacion de la BD
    '"Data Source=nombre_servidor;Initial Catalog=nombre_base_datos;User ID=usuario;Password=contraseña"
    Private conexionstr As String = "Data Source=11ITACHIKUN;Initial Catalog=sys_COMINDDB;User ID=sa;Password=admin123"
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Permisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim oform As New Form3
        oform.Show()
        Me.Visible = False
    End Sub
    'Tipo
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
    End Sub
    'ID_Permiso 
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
    'Fecha del permiso
    Private Sub DateTimePicker3_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker3.ValueChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
    'CURP
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub
    'Id Trabajador
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub
    'Fecha de inicio
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub
    'Fecha de Finalizacion
    Private Sub DateTimePicker2_ValueChanged_1(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged

    End Sub
    'Estado
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub
    'Motivo
    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub
    'Guardar datos
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If String.IsNullOrEmpty(TextBox1.Text) OrElse String.IsNullOrEmpty(TextBox3.Text) OrElse String.IsNullOrEmpty(TextBox4.Text) OrElse
            String.IsNullOrEmpty(TextBox5.Text) OrElse String.IsNullOrEmpty(TextBox6.Text) OrElse String.IsNullOrEmpty(TextBox7.Text) OrElse
            ComboBox1.SelectedIndex = -1 OrElse ComboBox2.SelectedIndex = -1 Then
            MessageBox.Show("Debe completar todos los campos.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim idPermiso As String = TextBox1.Text
            Dim fechaPermiso As DateTime = DateTimePicker3.Value
            Dim curp As String = TextBox4.Text
            Dim idTrabajador As String = TextBox5.Text
            Dim fechaInicio As DateTime = DateTimePicker1.Value
            Dim fechaFin As DateTime = DateTimePicker2.Value
            Dim tipo As String = ComboBox1.SelectedItem.ToString()
            Dim estado As String = ComboBox2.SelectedItem.ToString()
            Dim motivo As String = TextBox7.Text

            Using connection As New SqlConnection(conexionstr)
                Try
                    connection.Open()
                    Dim query As String = "INSERT INTO PERMISOS (ID_PERMISO, FECHA_PERMISO, ID_TRABAJADOR, FECHA_INICIO, FECHA_FINAL, TIPO, ESTADO, MOTIVO, CURP) VALUES (@IdPermiso, @FechaPermiso, @IdTrabajador, @FechaInicio, @FechaFin, @Tipo, @Estado, @Motivo, @Curp)"
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@IdPermiso", idPermiso)
                        command.Parameters.AddWithValue("@FechaPermiso", fechaPermiso)
                        command.Parameters.AddWithValue("@Curp", curp)
                        command.Parameters.AddWithValue("@IdTrabajador", idTrabajador)
                        command.Parameters.AddWithValue("@FechaInicio", fechaInicio)
                        command.Parameters.AddWithValue("@FechaFin", fechaFin)
                        command.Parameters.AddWithValue("@Tipo", tipo)
                        command.Parameters.AddWithValue("@Estado", estado)
                        command.Parameters.AddWithValue("@Motivo", motivo)
                        command.ExecuteNonQuery()
                        MessageBox.Show("Permiso registrado con éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        TextBox1.Text = ""
                        TextBox3.Text = ""
                        TextBox4.Text = ""
                        TextBox5.Text = ""
                        TextBox6.Text = ""
                        TextBox7.Text = ""
                        ComboBox1.SelectedIndex = -1
                        ComboBox2.SelectedIndex = -1
                    End Using
                Catch ex As SqlException
                    If ex.Number = 547 Then
                        MessageBox.Show("Error: El trabajador con el ID especificado no existe.", "Error de inserción", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ElseIf ex.Number = 2627 AndAlso ex.Message.Contains("Violation of PRIMARY KEY constraint") Then
                        MessageBox.Show("Ese numero de permiso ya existe. Intente con otro.", "Error de inserción", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        MessageBox.Show("Error al registrar el permiso: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Try
            End Using
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim oform As New mostrar_Permisos
        oform.Show()
        Me.Visible = False
    End Sub
End Class