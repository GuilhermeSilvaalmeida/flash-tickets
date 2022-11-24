Public Class frm_ingressos
    Private Sub frm_ingressos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco()
        sql = $"SELECT * FROM tb_compra WHERE usuario_comprador = '{sessao_usuario}'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            While rs.EOF = False
                drop_id_compra.Items.Add(rs.Fields(0).Value)
                rs.MoveNext()
            End While
        Else
            drop_id_compra.Items.Add("Sem compras.")
        End If
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            frm_menu.Show()
            frm_menu.BunifuButton3.Visible = False
            frm_menu.BunifuButton2.Visible = False
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub drop_id_compra_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drop_id_compra.SelectedIndexChanged
        sql = $"SELECT * FROM tb_compra WHERE id = {drop_id_compra.SelectedItem}"
        rs = db.Execute(sql)
        lbl_valor.Text = $"R${rs.Fields(6).Value},00"
    End Sub
End Class