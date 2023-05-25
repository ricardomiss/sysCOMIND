Imports System.Data.SqlClient

Public Class mostrar_Permisos
    'String donde se guarda la informacion de la BD
    '"Data Source=nombre_servidor;Initial Catalog=nombre_base_datos;User ID=usuario;Password=contraseña"
    Private conexionstr As String = "Data Source=11ITACHIKUN;Initial Catalog=sys_COMINDDB;User ID=sa;Password=admin123"
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim oform As New Form3
        oform.Show()
        Me.Visible = False
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub mostrar_Permisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Consulta SQL para obtener los datos de la tabla HORARIOS
        Dim query As String = "SELECT * FROM PERMISOS"

        ' Crear una conexión a la base de datos y un adaptador de datos
        Using connection As New SqlConnection(conexionstr)
            Using command As New SqlCommand(query, connection)
                Try
                    ' Abrir la conexión
                    connection.Open()

                    ' Crear un objeto DataTable para almacenar los datos
                    Dim dataTable As New DataTable()

                    ' Llenar el DataTable con los datos del adaptador de datos
                    Dim dataAdapter As New SqlDataAdapter(command)
                    dataAdapter.Fill(dataTable)

                    ' Asignar el DataTable como origen de datos del DataGridView
                    DataGridView1.DataSource = dataTable
                Catch ex As Exception
                    MessageBox.Show("Error al obtener los datos de la tabla HORARIOS: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub
End Class