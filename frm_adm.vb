Public Class frm_adm

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click
        Call frm_clientes.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub

    Private Sub frm_adm(sender As Object, e As EventArgs) Handles MyBase.Load

        If sessao_usuario <> "admin" Then
            lbl_boas_vindas.Text = $"Bem vindo(a) de volta"
            lbl_nome.Text = sessao_usuario
        Else
            lbl_boas_vindas.Text = $"Logado como administrador"

            lbl_nome.Visible = False
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Try
            resp = MsgBox("Deseja realmente sair da conta?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
            If resp = MsgBoxResult.Yes Then
                frm_login.Show()
                Me.Close()
            End If
        Catch ex As Exception

        End Try

    End Sub
End Class