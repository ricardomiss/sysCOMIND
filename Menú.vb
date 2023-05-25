Public Class Form3
    'Boton Registrar Empleado
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim oform As New Empleados
        oform.Show()
        Me.Visible = False
    End Sub

    'Boton de Permisos
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim oform As New Permisos
        oform.Show()
        Me.Visible = False
    End Sub
    'Boton Control de horas
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim oform As New Horas
        oform.Show()
        Me.Visible = False
    End Sub
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Application.Exit()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub
    'Boton Registrar Empleado
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim oform As New Empleados
        oform.Show()
        Me.Visible = False
    End Sub
    'Boton Control de horas
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim oform As New Horas
        oform.Show()
        Me.Visible = False
    End Sub
    'Boton de Permisos
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

        Dim oform As New Permisos
        oform.Show()
        Me.Visible = False
    End Sub

    'Boton de salida
    'Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
    '    Dim oform As New Form1
    '    oform.Show()
    '    Me.Visible = False
    'End Sub
End Class