Public Class Form_Pesan
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Coba Belajar Vb.net")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Tanda Seru", MsgBoxStyle.Exclamation, "Baca Pesan")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("Tanda i", MsgBoxStyle.Information, "Baca Pesan")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("Error", MsgBoxStyle.Critical, "Baca Pesan")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim pesan As String
        pesan = MsgBox("Ingin Keluar Program ?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Exit")
        If pesan = vbOK Then
            Me.Close()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Label1.Text = "Percobaan VB,Net"
        Button5.Text = "OK !!"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Label1.Text = ""
        Button5.Text = "Keluar Pesan"
    End Sub
End Class