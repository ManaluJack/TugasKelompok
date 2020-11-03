Public Class Form_Practice2
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "Sepeda Motor" And RadioButton1.Checked = True Then
            Label9.Text = "2"
            Label10.Text = Val(TextBox2.Text) * Val(TextBox1.Text)
            Label11.Text = TextBox2.Text
        End If

        If ComboBox1.Text = "Mobil" And RadioButton1.Checked = True Then
            Label9.Text = "4"
            Label10.Text = Val(TextBox2.Text) * Val(TextBox1.Text)
            Label11.Text = TextBox2.Text
        End If

        If ComboBox1.Text = "Truk" And RadioButton1.Checked = True Then
            Label9.Text = "10"
            Label10.Text = Val(TextBox2.Text) * Val(TextBox1.Text)
            Label11.Text = TextBox2.Text
        End If

        If ComboBox1.Text = "Bus" And RadioButton1.Checked = True Then
            Label9.Text = "6"
            Label10.Text = Val(TextBox2.Text) * Val(TextBox1.Text)
            Label11.Text = TextBox2.Text
        End If

        If ComboBox1.Text = "Sepeda Motor" And RadioButton2.Checked = True Then
            Label9.Text = "2"
            Label11.Text = Val(TextBox2.Text) / Val(TextBox1.Text)
            Label10.Text = TextBox2.Text
        End If

        If ComboBox1.Text = "Mobil" And RadioButton2.Checked = True Then
            Label9.Text = "4"
            Label11.Text = Val(TextBox2.Text) / Val(TextBox1.Text)
            Label10.Text = TextBox2.Text
        End If

        If ComboBox1.Text = "Truk" And RadioButton2.Checked = True Then
            Label9.Text = "10"
            Label11.Text = Val(TextBox2.Text) / Val(TextBox1.Text)
            Label10.Text = TextBox2.Text
        End If

        If ComboBox1.Text = "Bus" And RadioButton2.Checked = True Then
            Label9.Text = "6"
            Label11.Text = Val(TextBox2.Text) / Val(TextBox1.Text)
            Label10.Text = TextBox2.Text
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class