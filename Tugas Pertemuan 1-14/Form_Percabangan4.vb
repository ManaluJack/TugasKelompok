Public Class Form_Percabangan4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pilih As String
        pilih = "Pilihan Anda "

        If RadioButton1.Checked = True Then
            pilih = pilih & "Sate. "
        ElseIf RadioButton2.Checked = True Then
            pilih = pilih & "Soto. "
        ElseIf RadioButton3.Checked = True Then
            pilih = pilih & "Kari. "
        End If
        MsgBox(pilih & "Segera Diantar")
    End Sub
End Class