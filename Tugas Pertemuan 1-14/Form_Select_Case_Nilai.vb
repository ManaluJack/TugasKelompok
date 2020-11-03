Public Class Form_Select_Case_Nilai
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case "001"
                TextBox1.Text = "Uli"
            Case "002"
                TextBox1.Text = "Arya"
            Case "003"
                TextBox1.Text = "Rama"
            Case Else
                TextBox1.Text = ""
        End Select
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Select Case ComboBox2.Text
            Case "IIIA"
                TextBox2.Text = 2500000
            Case "IIIB"
                TextBox2.Text = 2750000
            Case "IIIC"
                TextBox2.Text = 3500000
            Case "IVA"
                TextBox2.Text = 4500000
            Case Else
                TextBox2.Text = 0

        End Select
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Select Case ComboBox3.Text
            Case "KaBag"
                TextBox3.Text = 1500000
            Case " KaSub"
                TextBox3.Text = 1000000
            Case Else
                TextBox3.Text = 0
        End Select
    End Sub

    Private Sub Form_Select_Case_Nilai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("001")
        ComboBox1.Items.Add("002")
        ComboBox1.Items.Add("003")

        ComboBox2.Items.Add("IIIA")
        ComboBox2.Items.Add("IIIB")
        ComboBox2.Items.Add("IIIC")
        ComboBox2.Items.Add("IIID")
        ComboBox2.Items.Add("IVA")

        ComboBox3.Items.Add("KaBag")
        ComboBox3.Items.Add("KaSub")

        Button1_click(sender, e)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ComboBox1.Text = ""
        TextBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox4.Text = Val(TextBox2.Text) + Val(TextBox3.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox8.Text = 0.25 * Val(TextBox5.Text) + 0.3 * Val(TextBox9.Text) + 0.45 * Val(TextBox7.Text)
        Select Case TextBox8.Text
            Case Is >= 81
                TextBox9.Text = "A"
            Case Is >= 71
                TextBox9.Text = "AB"
            Case Is >= 66
                TextBox9.Text = "B"
            Case Is >= 61
                TextBox9.Text = "BC"
            Case Is >= 56
                TextBox9.Text = "C"
            Case Is >= 41
                TextBox9.Text = "D"
            Case Else
                TextBox9.Text = "E"
        End Select
    End Sub
End Class