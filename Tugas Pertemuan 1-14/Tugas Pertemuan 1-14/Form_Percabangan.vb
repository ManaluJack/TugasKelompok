Public Class Form_Percabangan
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Val(TextBox1.Text) <= 50 Then
            TextBox2.Text = "Gagal"
        ElseIf Val(TextBox1.Text) > 51 Then
            TextBox2.Text = "Lulus"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form_Percabangan2.ShowDialog()
    End Sub
End Class