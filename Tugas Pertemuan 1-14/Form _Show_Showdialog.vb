Public Class Form__Show_Showdialog
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form_Show.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form_Show_Dialog.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub
End Class