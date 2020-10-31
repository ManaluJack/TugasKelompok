Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        stslabel2.Text = DateTime.Now.ToString("hh:mm:ss tt")
        stslabel1.Text = Format(Now, "ddd/dd/MM/yyyy")
    End Sub

    Private Sub HelloWorldToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelloWorldToolStripMenuItem.Click
        MsgBox("Hello World", MessageBoxIcon.Information, "Pesan")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub ShowShowDialogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowShowDialogToolStripMenuItem.Click
        Form__Show_Showdialog.ShowDialog()
    End Sub

    Private Sub MembuatPesanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MembuatPesanToolStripMenuItem.Click
        Form_Pesan.ShowDialog()
    End Sub

    Private Sub OperatorRelasiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OperatorRelasiToolStripMenuItem.Click
        Form_Relasi.ShowDialog()
    End Sub

    Private Sub KonversiMataUangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KonversiMataUangToolStripMenuItem.Click
        Form_Konversi.ShowDialog()
    End Sub

    Private Sub LatihanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LatihanToolStripMenuItem.Click
        Form_Latihan.ShowDialog()
    End Sub

    Private Sub PercabanganIfThenElseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PercabanganIfThenElseToolStripMenuItem.Click
        Form_Percabangan.ShowDialog()
    End Sub

    Private Sub NestedIfToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NestedIfToolStripMenuItem.Click
        Form_Nested_If.ShowDialog()
    End Sub

    Private Sub EntryDataMahasiswaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntryDataMahasiswaToolStripMenuItem.Click
        Form_Entry_Data.ShowDialog()
    End Sub

    Private Sub NilaiMahasiswaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NilaiMahasiswaToolStripMenuItem.Click
        Form_Practice.ShowDialog()
    End Sub
End Class
