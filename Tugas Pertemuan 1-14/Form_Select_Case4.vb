Public Class Form_Select_Case4
    Private Sub Form_Select_Case4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("Jeruk")
        ListBox1.Items.Add("Alpukat")
        ListBox1.Items.Add("Strawberry")
        ListBox1.Items.Add("Mangga")
        ListBox1.Items.Add("Nanas")

        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("paket 1")
        ComboBox1.Items.Add("paket 2")
        ComboBox1.Items.Add("paket 3")
        ComboBox1.Items.Add("paket 4")
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Select Case ListBox1.SelectedIndex
            Case 0
                Label12.Text = "Banyak mengandung vitamin C"
            Case 1
                Label12.Text = "Banyak mengandung lemak baik"
            Case 2
                Label12.Text = "Buah yang tumbuh hanya didaratan"
            Case 3
                Label12.Text = "Buah kesukaan sejuta umat"
            Case 4
                Label12.Text = "Buah yang enak dibuat untuk rujak"
        End Select
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case (Me.ComboBox1.Text)
            Case ("paket 1")
                Me.TextBox1.Text = "Rendang"
                Me.TextBox2.Text = "Teh Manis"
                Me.TextBox3.Text = "20000"
            Case ("paket 2")
                Me.TextBox1.Text = "Ayam Goreng"
                Me.TextBox2.Text = "Jeruk Peras"
                Me.TextBox3.Text = "20000"
            Case ("paket 3")
                Me.TextBox1.Text = "Dendeng"
                Me.TextBox2.Text = "Kelapa Muda"
                Me.TextBox3.Text = "20000"
            Case ("paket 4")
                Me.TextBox1.Text = "Ayam Bakar"
                Me.TextBox2.Text = "Teh Manis"
                Me.TextBox3.Text = "20000"
        End Select
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Select Case TextBox4.Text
            Case "SI"
                Label7.Text = "Sistem Informasi"
                Label8.Text = "Stara-1"
            Case "TI"
                Label7.Text = "Teknik Informatika"
                Label8.Text = "Stara-1"
            Case Else
                Label7.Text = "Jurusan Belum Terdaftar"
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case Val(TextBox5.Text)
            Case 80 To 100
                Label10.Text = "A"
                Label9.Text = "Memuaskan"
            Case 70 To 79
                Label10.Text = "B"
                Label9.Text = "Baik"
            Case 60 To 69
                Label10.Text = "C"
                Label9.Text = "Cukup"
            Case 50 To 69
                Label10.Text = "D"
                Label9.Text = "Kurang"
            Case 0 To 49
                Label10.Text = "E"
                Label9.Text = "Gagal"
            Case Else
                MessageBox.Show("Nilai Angkanya Salah", "Nilai Salah", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub
End Class