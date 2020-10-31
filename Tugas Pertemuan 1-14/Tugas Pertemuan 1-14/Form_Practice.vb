Public Class Form_Practice
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim var1, var2, var3, var4 As Integer
        Dim tot As Double

        var1 = absen.Text
        var2 = tugas.Text
        var3 = uts.Text
        var4 = uas.Text

        habsen.Text = Val(absen.Text) * 0.1
        htugas.Text = Val(tugas.Text) * 0.2
        huts.Text = Val(uts.Text) * 0.3
        huas.Text = Val(uas.Text) * 0.4

        tot = Val(habsen.Text) + Val(htugas.Text) + Val(huts.Text) + Val(huas.Text)
        total.Text = Val(habsen.Text) + Val(htugas.Text) + Val(huts.Text) + Val(huas.Text)

        If tot >= 80 Then
            grade.Text = "A"
            keterangan.Text = "Lulus"
        End If
        If tot <= 79 Then
                grade.Text = "B"
            keterangan.Text = "Lulus"
        End If
        If tot <= 65 Then
            grade.Text = "C"
            keterangan.Text = "Gagal"
        End If
        If tot <= 45 Then
            grade.Text = "D"
            keterangan.Text = "Gagal"
        End If



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        absen.Text = ""
        habsen.Text = ""
        tugas.Text = ""
        htugas.Text = ""
        uts.Text = ""
        huts.Text = ""
        uas.Text = ""
        huas.Text = ""
        total.Text = ""
        grade.Text = ""
        keterangan.Text = ""
        absen.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MsgBox("Yakin Ingin Keluar?", MessageBoxButtons.YesNo, "Pesan") Then
            Close()
        End If
    End Sub
End Class