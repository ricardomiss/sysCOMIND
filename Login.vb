Public Class Form2
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs)

    End Sub



    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim oform As New Form3
        oform.Show()
        Me.Visible = False
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub ID_TextChanged(sender As Object, e As EventArgs) Handles ID.TextChanged

    End Sub
End Class