Public Class frm_perfil
    Private Sub frm_perfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco()
        carregar_dados()
        carregar_tipo()

        Try
            sql = "SELECT email,nome,cep,endereco,bairro,cidade,uf,fone,cpf,foto from tb_usuario WHERE usuario='" & sessao_usuario & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txt_email.Text = rs.Fields(0).Value
                txt_nome.Text = rs.Fields(1).Value
                txt_cep.Text = rs.Fields(2).Value
                txt_endereco.Text = rs.Fields(3).Value
                txt_bairro.Text = rs.Fields(4).Value
                txt_cidade.Text = rs.Fields(5).Value
                txt_uf.Text = rs.Fields(6).Value
                txt_fone.Text = rs.Fields(7).Value
                txt_cpf.Text = rs.Fields(8).Value
                img_foto.Load(diretorio_imagem & rs.Fields(9).Value)
                txt_boasvindas.Text = "Olá " & sessao_usuario & ", seja bem vindo(a)!"
                txt_nome.Focus()
            End If
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try

    End Sub

    Private Sub img_foto_Click(sender As Object, e As EventArgs) Handles img_foto.Click
        Try
            With OpenFileDialog1
                .Title = "Selecione uma foto"
                .InitialDirectory = Application.StartupPath & "\Fotos\"
                .ShowDialog()
                diretorio = .FileName
                img_foto.Load(diretorio)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
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
End Class