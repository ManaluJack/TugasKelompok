Public Class Form_Konversi
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim var1 As Double

        var1 = TextBox1.Text

        TextBox2.Text = (var1 / 14694)
        TextBox3.Text = (var1 / 19107)
        TextBox4.Text = (var1 / 17372)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("Ingin Keluar?", MsgBoxStyle.Question, "Pesan") Then
            Close()
        End If
    End Sub
End Class