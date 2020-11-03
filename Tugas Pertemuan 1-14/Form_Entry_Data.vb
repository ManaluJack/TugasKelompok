Public Class Form_Entry_Data
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label5.Text = "Selamat Datang " & nama.Text
        If ComboBox1.Text = "Sistem Infomasi" Then
            Label6.Text = "Anda Jurusan " & ComboBox1.Text
        ElseIf ComboBox1.Text = "Teknik Informatika" Then
            Label6.Text = "Anda Jurusan " & ComboBox1.Text
        ElseIf ComboBox1.Text = "Teknik Industri" Then
            Label6.Text = "Anda Jurusan " & ComboBox1.Text
        ElseIf ComboBox1.Text = "Sastra Inggris" Then
            Label6.Text = "Anda Jurusan " & ComboBox1.Text
        ElseIf ComboBox1.Text = "Ilmu Komunikasi" Then
            Label6.Text = "Anda Jurusan " & ComboBox1.Text
        ElseIf ComboBox1.Text = "Bisnis Manajemen" Then
            Label6.Text = "Anda Jurusan " & ComboBox1.Text
        End If
        If RadioButton1.Checked = True Then
            Label7.Text = "Anda Pria"
        Else
            Label7.Text = "Anda Wanita"
        End If
    End Sub
End Class