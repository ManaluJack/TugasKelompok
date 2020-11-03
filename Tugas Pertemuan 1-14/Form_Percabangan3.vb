Public Class Form_Percabangan3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pilih As String
        pilih = "Pesanan Anda "

        If CheckBox1.Checked = True Then
            pilih = pilih & "Sate. "
        ElseIf CheckBox2.Checked = True Then
            pilih = pilih & "Soto. "
        ElseIf CheckBox3.Checked = True Then
            pilih = pilih & "Kari. "
        End If
        MsgBox(pilih & "Segera Diantar")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form_Percabangan4.ShowDialog()
    End Sub
End Class