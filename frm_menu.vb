Public Class frm_menu
    'Private Sub frm_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ' conecta_banco()
    'carregar_dados()
    'carregar_tipo()

    'Try
    ' sql = "SELECT foto from tb_usuario WHERE usuario='" & sessao_usuario & "'"
    ' rs = db.Execute(sql)
    'If rs.EOF = False Then
    ' img_foto.Load(diretorio_imagem & rs.Fields(9).Value)

    '   End If
    ' Catch ex As Exception
    'MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
    '  End Try

    ' End Sub
    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Try
            frm_clientes.ShowDialog() 'Chamada de formulário
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GERENCIARToolStripMenuItem.Visible = False
        GERENCIARToolStripMenuItem.Enabled = False

        If sessao_usuario <> "admin" Then
            lbl_boas_vindas.Text = $"Bem vindo(a) de volta"
            lbl_nome.Text = sessao_usuario
        Else
            lbl_boas_vindas.Text = $"Logado como administrador"
            GERENCIARToolStripMenuItem.Visible = True
            GERENCIARToolStripMenuItem.Enabled = True
            lbl_nome.Visible = False
        End If

    End Sub


    Private Sub SAIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SAIRToolStripMenuItem.Click
        resp = MsgBox("Deseja realmente sair da conta?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
        If resp = MsgBoxResult.Yes Then
            frm_login.Show()
            Me.Close()
        End If
    End Sub


    Private Sub CadastarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastarToolStripMenuItem.Click
        Call frm_clientes.Show()
        frm_login.Close()

    End Sub

    Private Sub PERFILToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Call frm_perfil.Show()
        Me.Close()
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Call frm_perfil.Show()
        Me.Close()
    End Sub

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click
        Call frm_clientes.Show()
        Me.Close()
    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Call frm_explorar.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub MEUSINGRESSOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MEUSINGRESSOSToolStripMenuItem.Click
        Try
            frm_ingressos.Show()
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SUPORTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SUPORTEToolStripMenuItem.Click

        Try
            frm_ajuda.Show()
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class
