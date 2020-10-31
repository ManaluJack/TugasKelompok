Public Class Form_Percabangan2
    Private Sub Form_Percabangan2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Paket 1")
        ComboBox1.Items.Add("Paket 2")
        ComboBox1.Items.Add("Paket 3")
        ComboBox1.Items.Add("Paket 4")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Paket 1" Then
            GroupBox1.Text = ComboBox1.Text
            TextBox1.Text = "Rendang"
            TextBox2.Text = "Teh Manis"
            TextBox3.Text = "Rp. 110000"
        ElseIf ComboBox1.Text = "Paket 2" Then
            GroupBox1.Text = ComboBox1.Text
            TextBox1.Text = "Ayam goreng"
            TextBox2.Text = "Jus Jeruk"
            TextBox3.Text = "Rp. 150000"
        ElseIf ComboBox1.Text = "Paket 3" Then
            GroupBox1.Text = ComboBox1.Text
            TextBox1.Text = "Nasi Goreng"
            TextBox2.Text = "Es Manis"
            TextBox3.Text = "Rp. 80000"
        Else
            GroupBox1.Text = ComboBox1.Text
            TextBox1.Text = "Nasi Bakar"
            TextBox2.Text = "Kopi"
            TextBox3.Text = "Rp. 170000"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form_Percabangan3.ShowDialog()
    End Sub
End Class