Public Class Form_Latihan

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim jum As Integer
        Dim tot, dsc, pjk, hrg As Double

        harga.Text = hrg
        diskon.Text = dsc
        pajak.Text = pjk


        If ComboBox1.Text = "Shampo" Then
            harga.Text = "3000"
            diskon.Text = "5%"
            pajak.Text = "2%"
            hrg = 3000
            dsc = 0.05
            pjk = 0.02
            jumlah.Focus()
        End If
        If ComboBox1.Text = "Sabun" Then
            harga.Text = "5000"
            diskon.Text = "5%"
            pajak.Text = "2%"
            hrg = 5000
            dsc = 0.05
            pjk = 0.02
            jumlah.Focus()
        End If
        If ComboBox1.Text = "Rinso" Then
            harga.Text = "10000"
            diskon.Text = "5%"
            pajak.Text = "2%"
            hrg = 10000
            dsc = 0.05
            pjk = 0.02
            jumlah.Focus()
        End If
        If ComboBox1.Text = "Gula" Then
            harga.Text = "20000"
            diskon.Text = "5%"
            pajak.Text = "2%"
            hrg = 20000
            dsc = 0.05
            pjk = 0.02
            jumlah.Focus()
        End If
        If ComboBox1.Text = "Susu Kaleng" Then
            harga.Text = "30000"
            diskon.Text = "5%"
            pajak.Text = "2%"
            hrg = 30000
            dsc = 0.05
            pjk = 0.02
            jumlah.Focus()
        End If

        jumlah.Text = jum
        tot = Val(harga.Text) * Val(diskon.Text) * Val(pajak.Text) * Val(jumlah.Text)
        total.Text = tot
    End Sub
End Class