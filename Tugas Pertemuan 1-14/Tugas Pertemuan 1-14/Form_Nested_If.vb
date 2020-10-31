Public Class Form_Nested_If
    Private Sub Form_Nested_If_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Menikah")
        ComboBox1.Items.Add("Bujang")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            If ComboBox1.Text = "Menikah" Then
                TextBox1.Text = "Ayah"
            Else
                TextBox1.Text = "Jejaka"
            End If
        Else
            If ComboBox1.Text = "Menikah" Then
                TextBox1.Text = "Ibu"
            Else
                TextBox1.Text = "Gadis"
            End If
        End If
    End Sub
End Class