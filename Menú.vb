Public Class Form3
    'Boton Registrar Empleado
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim oform As New Empleados
        oform.Show()
        Me.Visible = False
    End Sub
    'Boton de Vacaciones
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
    End Sub
    'Boton de Permisos
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
    End Sub
    'Boton Control de horas
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    End Sub
    'Boton Datos del empleado
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    End Sub
    'Boton de salida
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim oform As New Form1
        oform.Show()
        Me.Visible = False
    End Sub
End Class