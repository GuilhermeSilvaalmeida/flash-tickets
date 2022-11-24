<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ingressos
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ingressos))
        Me.BunifuGradientPanel2 = New Bunifu.UI.WinForms.BunifuGradientPanel()
        Me.lbl_valor = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.drop_id_compra = New Bunifu.UI.WinForms.BunifuDropdown()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuLabel2 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuGradientPanel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuGradientPanel2
        '
        Me.BunifuGradientPanel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuGradientPanel2.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel2.BorderRadius = 1
        Me.BunifuGradientPanel2.Controls.Add(Me.lbl_valor)
        Me.BunifuGradientPanel2.Controls.Add(Me.BunifuLabel1)
        Me.BunifuGradientPanel2.Controls.Add(Me.drop_id_compra)
        Me.BunifuGradientPanel2.Controls.Add(Me.PictureBox2)
        Me.BunifuGradientPanel2.Controls.Add(Me.PictureBox1)
        Me.BunifuGradientPanel2.Controls.Add(Me.BunifuLabel2)
        Me.BunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuGradientPanel2.Location = New System.Drawing.Point(-4, -5)
        Me.BunifuGradientPanel2.Name = "BunifuGradientPanel2"
        Me.BunifuGradientPanel2.Quality = 10
        Me.BunifuGradientPanel2.Size = New System.Drawing.Size(544, 462)
        Me.BunifuGradientPanel2.TabIndex = 73
        '
        'lbl_valor
        '
        Me.lbl_valor.AllowParentOverrides = False
        Me.lbl_valor.AutoEllipsis = False
        Me.lbl_valor.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl_valor.CursorType = System.Windows.Forms.Cursors.Default
        Me.lbl_valor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_valor.Location = New System.Drawing.Point(57, 213)
        Me.lbl_valor.Name = "lbl_valor"
        Me.lbl_valor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_valor.Size = New System.Drawing.Size(73, 15)
        Me.lbl_valor.TabIndex = 89
        Me.lbl_valor.Text = "valor ingresso"
        Me.lbl_valor.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.lbl_valor.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AllowParentOverrides = False
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuLabel1.Location = New System.Drawing.Point(28, 95)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(134, 15)
        Me.BunifuLabel1.TabIndex = 88
        Me.BunifuLabel1.Text = "Selecione o ID da compra"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'drop_id_compra
        '
        Me.drop_id_compra.BackColor = System.Drawing.Color.Transparent
        Me.drop_id_compra.BackgroundColor = System.Drawing.Color.White
        Me.drop_id_compra.BorderColor = System.Drawing.Color.Silver
        Me.drop_id_compra.BorderRadius = 1
        Me.drop_id_compra.Color = System.Drawing.Color.Silver
        Me.drop_id_compra.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down
        Me.drop_id_compra.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.drop_id_compra.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.drop_id_compra.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.drop_id_compra.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.drop_id_compra.DisabledIndicatorColor = System.Drawing.Color.DarkGray
        Me.drop_id_compra.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.drop_id_compra.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin
        Me.drop_id_compra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.drop_id_compra.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.drop_id_compra.FillDropDown = True
        Me.drop_id_compra.FillIndicator = False
        Me.drop_id_compra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.drop_id_compra.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.drop_id_compra.ForeColor = System.Drawing.Color.Black
        Me.drop_id_compra.FormattingEnabled = True
        Me.drop_id_compra.Icon = Nothing
        Me.drop_id_compra.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.drop_id_compra.IndicatorColor = System.Drawing.Color.Gray
        Me.drop_id_compra.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.drop_id_compra.ItemBackColor = System.Drawing.Color.White
        Me.drop_id_compra.ItemBorderColor = System.Drawing.Color.White
        Me.drop_id_compra.ItemForeColor = System.Drawing.Color.Black
        Me.drop_id_compra.ItemHeight = 26
        Me.drop_id_compra.ItemHighLightColor = System.Drawing.Color.DodgerBlue
        Me.drop_id_compra.ItemHighLightForeColor = System.Drawing.Color.White
        Me.drop_id_compra.ItemTopMargin = 3
        Me.drop_id_compra.Location = New System.Drawing.Point(28, 116)
        Me.drop_id_compra.Name = "drop_id_compra"
        Me.drop_id_compra.Size = New System.Drawing.Size(260, 32)
        Me.drop_id_compra.TabIndex = 87
        Me.drop_id_compra.Text = Nothing
        Me.drop_id_compra.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.drop_id_compra.TextLeftMargin = 5
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.prj_si_2022_2S.My.Resources.Resources.icons8_xbox_x_35
        Me.PictureBox2.Location = New System.Drawing.Point(494, 17)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(34, 45)
        Me.PictureBox2.TabIndex = 86
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.prj_si_2022_2S.My.Resources.Resources.icons8_esquerda_25
        Me.PictureBox1.Location = New System.Drawing.Point(28, 379)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(27, 29)
        Me.PictureBox1.TabIndex = 84
        Me.PictureBox1.TabStop = False
        '
        'BunifuLabel2
        '
        Me.BunifuLabel2.AllowParentOverrides = False
        Me.BunifuLabel2.AutoEllipsis = False
        Me.BunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel2.ForeColor = System.Drawing.Color.Black
        Me.BunifuLabel2.Location = New System.Drawing.Point(167, 17)
        Me.BunifuLabel2.Name = "BunifuLabel2"
        Me.BunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel2.Size = New System.Drawing.Size(317, 38)
        Me.BunifuLabel2.TabIndex = 74
        Me.BunifuLabel2.Text = "MINHAS COMPRAS"
        Me.BunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'frm_ingressos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 450)
        Me.Controls.Add(Me.BunifuGradientPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_ingressos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.BunifuGradientPanel2.ResumeLayout(False)
        Me.BunifuGradientPanel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuGradientPanel2 As Bunifu.UI.WinForms.BunifuGradientPanel
    Friend WithEvents BunifuLabel2 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents drop_id_compra As Bunifu.UI.WinForms.BunifuDropdown
    Friend WithEvents lbl_valor As Bunifu.UI.WinForms.BunifuLabel
End Class
