Public Class frm_suporte
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Try
            frm_menu.Show()
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Application.Exit()
    End Sub
End Class