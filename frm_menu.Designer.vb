<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_menu
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_menu))
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges3 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges4 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.elipseBackground = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.GERENCIARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContasDeUsuáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MEUSINGRESSOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SAIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SUPORTEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BunifuGradientPanel1 = New Bunifu.UI.WinForms.BunifuGradientPanel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BunifuButton3 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton2 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton1 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.btn_entrar = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.lbl_nome = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuPanel1 = New Bunifu.UI.WinForms.BunifuPanel()
        Me.img_foto = New System.Windows.Forms.PictureBox()
        Me.BunifuSeparator1 = New Bunifu.UI.WinForms.BunifuSeparator()
        Me.lbl_boas_vindas = New Bunifu.UI.WinForms.BunifuLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuPanel1.SuspendLayout()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Chocolate
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GERENCIARToolStripMenuItem, Me.MEUSINGRESSOSToolStripMenuItem, Me.SAIRToolStripMenuItem, Me.SUPORTEToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1022, 32)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'elipseBackground
        '
        Me.elipseBackground.ElipseRadius = 20
        Me.elipseBackground.TargetControl = Me
        '
        'GERENCIARToolStripMenuItem
        '
        Me.GERENCIARToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastarToolStripMenuItem, Me.ContasDeUsuáriosToolStripMenuItem})
        Me.GERENCIARToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GERENCIARToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GERENCIARToolStripMenuItem.Image = CType(resources.GetObject("GERENCIARToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GERENCIARToolStripMenuItem.Name = "GERENCIARToolStripMenuItem"
        Me.GERENCIARToolStripMenuItem.Size = New System.Drawing.Size(157, 28)
        Me.GERENCIARToolStripMenuItem.Text = "&GERENCIAR CONTAS"
        '
        'CadastarToolStripMenuItem
        '
        Me.CadastarToolStripMenuItem.Name = "CadastarToolStripMenuItem"
        Me.CadastarToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.CadastarToolStripMenuItem.Text = "Cadastrar Contas"
        '
        'ContasDeUsuáriosToolStripMenuItem
        '
        Me.ContasDeUsuáriosToolStripMenuItem.Image = CType(resources.GetObject("ContasDeUsuáriosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ContasDeUsuáriosToolStripMenuItem.Name = "ContasDeUsuáriosToolStripMenuItem"
        Me.ContasDeUsuáriosToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ContasDeUsuáriosToolStripMenuItem.Text = "Gerenciar Acesso"
        '
        'MEUSINGRESSOSToolStripMenuItem
        '
        Me.MEUSINGRESSOSToolStripMenuItem.Image = Global.prj_si_2022_2S.My.Resources.Resources.icons8_carrinho_de_compras_30
        Me.MEUSINGRESSOSToolStripMenuItem.Name = "MEUSINGRESSOSToolStripMenuItem"
        Me.MEUSINGRESSOSToolStripMenuItem.Size = New System.Drawing.Size(137, 28)
        Me.MEUSINGRESSOSToolStripMenuItem.Text = "MEUS INGRESSOS"
        '
        'SAIRToolStripMenuItem
        '
        Me.SAIRToolStripMenuItem.Image = Global.prj_si_2022_2S.My.Resources.Resources.icons8_saída_de_emergência_24
        Me.SAIRToolStripMenuItem.Name = "SAIRToolStripMenuItem"
        Me.SAIRToolStripMenuItem.Size = New System.Drawing.Size(89, 28)
        Me.SAIRToolStripMenuItem.Text = "LOGOUT"
        '
        'SUPORTEToolStripMenuItem
        '
        Me.SUPORTEToolStripMenuItem.Image = Global.prj_si_2022_2S.My.Resources.Resources.icons8_suporte_ao_cliente_24
        Me.SUPORTEToolStripMenuItem.Name = "SUPORTEToolStripMenuItem"
        Me.SUPORTEToolStripMenuItem.Size = New System.Drawing.Size(150, 28)
        Me.SUPORTEToolStripMenuItem.Text = "PRECISA DE AJUDA?"
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.BorderRadius = 1
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureBox2)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuButton3)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuButton2)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuButton1)
        Me.BunifuGradientPanel1.Controls.Add(Me.btn_entrar)
        Me.BunifuGradientPanel1.Controls.Add(Me.lbl_nome)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuPanel1)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuSeparator1)
        Me.BunifuGradientPanel1.Controls.Add(Me.lbl_boas_vindas)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(-11, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(1041, 538)
        Me.BunifuGradientPanel1.TabIndex = 4
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.prj_si_2022_2S.My.Resources.Resources.icons8_xbox_x_35
        Me.PictureBox2.Location = New System.Drawing.Point(987, 35)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(34, 45)
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'BunifuButton3
        '
        Me.BunifuButton3.AllowAnimations = True
        Me.BunifuButton3.AllowMouseEffects = True
        Me.BunifuButton3.AllowToggling = False
        Me.BunifuButton3.AnimationSpeed = 200
        Me.BunifuButton3.AutoGenerateColors = False
        Me.BunifuButton3.AutoRoundBorders = False
        Me.BunifuButton3.AutoSizeLeftIcon = True
        Me.BunifuButton3.AutoSizeRightIcon = True
        Me.BunifuButton3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton3.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BunifuButton3.BackgroundImage = CType(resources.GetObject("BunifuButton3.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton3.ButtonText = "GERENCIAR CONTAS"
        Me.BunifuButton3.ButtonTextMarginLeft = 0
        Me.BunifuButton3.ColorContrastOnClick = 45
        Me.BunifuButton3.ColorContrastOnHover = 45
        Me.BunifuButton3.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.BunifuButton3.CustomizableEdges = BorderEdges1
        Me.BunifuButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton3.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton3.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton3.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton3.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuButton3.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton3.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton3.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton3.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton3.IconMarginLeft = 11
        Me.BunifuButton3.IconPadding = 10
        Me.BunifuButton3.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton3.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton3.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton3.IconSize = 25
        Me.BunifuButton3.IdleBorderColor = System.Drawing.Color.Transparent
        Me.BunifuButton3.IdleBorderRadius = 20
        Me.BunifuButton3.IdleBorderThickness = 2
        Me.BunifuButton3.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BunifuButton3.IdleIconLeftImage = Nothing
        Me.BunifuButton3.IdleIconRightImage = Nothing
        Me.BunifuButton3.IndicateFocus = False
        Me.BunifuButton3.Location = New System.Drawing.Point(61, 339)
        Me.BunifuButton3.Name = "BunifuButton3"
        Me.BunifuButton3.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton3.OnDisabledState.BorderRadius = 20
        Me.BunifuButton3.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton3.OnDisabledState.BorderThickness = 2
        Me.BunifuButton3.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton3.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton3.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton3.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton3.onHoverState.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuButton3.onHoverState.BorderRadius = 20
        Me.BunifuButton3.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton3.onHoverState.BorderThickness = 2
        Me.BunifuButton3.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuButton3.onHoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuButton3.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton3.onHoverState.IconRightImage = Nothing
        Me.BunifuButton3.OnIdleState.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuButton3.OnIdleState.BorderRadius = 20
        Me.BunifuButton3.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton3.OnIdleState.BorderThickness = 2
        Me.BunifuButton3.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BunifuButton3.OnIdleState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton3.OnIdleState.IconLeftImage = Nothing
        Me.BunifuButton3.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton3.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BunifuButton3.OnPressedState.BorderRadius = 20
        Me.BunifuButton3.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton3.OnPressedState.BorderThickness = 2
        Me.BunifuButton3.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuButton3.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuButton3.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton3.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton3.Size = New System.Drawing.Size(194, 90)
        Me.BunifuButton3.TabIndex = 12
        Me.BunifuButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton3.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton3.TextMarginLeft = 0
        Me.BunifuButton3.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton3.UseDefaultRadiusAndThickness = True
        '
        'BunifuButton2
        '
        Me.BunifuButton2.AllowAnimations = True
        Me.BunifuButton2.AllowMouseEffects = True
        Me.BunifuButton2.AllowToggling = False
        Me.BunifuButton2.AnimationSpeed = 200
        Me.BunifuButton2.AutoGenerateColors = False
        Me.BunifuButton2.AutoRoundBorders = False
        Me.BunifuButton2.AutoSizeLeftIcon = True
        Me.BunifuButton2.AutoSizeRightIcon = True
        Me.BunifuButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton2.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BunifuButton2.BackgroundImage = CType(resources.GetObject("BunifuButton2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton2.ButtonText = "GERENCIAR ACESSOS"
        Me.BunifuButton2.ButtonTextMarginLeft = 0
        Me.BunifuButton2.ColorContrastOnClick = 45
        Me.BunifuButton2.ColorContrastOnHover = 45
        Me.BunifuButton2.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges2.BottomLeft = True
        BorderEdges2.BottomRight = True
        BorderEdges2.TopLeft = True
        BorderEdges2.TopRight = True
        Me.BunifuButton2.CustomizableEdges = BorderEdges2
        Me.BunifuButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton2.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton2.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton2.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuButton2.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton2.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton2.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton2.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton2.IconMarginLeft = 11
        Me.BunifuButton2.IconPadding = 10
        Me.BunifuButton2.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton2.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton2.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton2.IconSize = 25
        Me.BunifuButton2.IdleBorderColor = System.Drawing.Color.Transparent
        Me.BunifuButton2.IdleBorderRadius = 20
        Me.BunifuButton2.IdleBorderThickness = 2
        Me.BunifuButton2.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BunifuButton2.IdleIconLeftImage = Nothing
        Me.BunifuButton2.IdleIconRightImage = Nothing
        Me.BunifuButton2.IndicateFocus = False
        Me.BunifuButton2.Location = New System.Drawing.Point(261, 339)
        Me.BunifuButton2.Name = "BunifuButton2"
        Me.BunifuButton2.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton2.OnDisabledState.BorderRadius = 20
        Me.BunifuButton2.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton2.OnDisabledState.BorderThickness = 2
        Me.BunifuButton2.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton2.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton2.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton2.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton2.onHoverState.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuButton2.onHoverState.BorderRadius = 20
        Me.BunifuButton2.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton2.onHoverState.BorderThickness = 2
        Me.BunifuButton2.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuButton2.onHoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuButton2.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton2.onHoverState.IconRightImage = Nothing
        Me.BunifuButton2.OnIdleState.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuButton2.OnIdleState.BorderRadius = 20
        Me.BunifuButton2.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton2.OnIdleState.BorderThickness = 2
        Me.BunifuButton2.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BunifuButton2.OnIdleState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton2.OnIdleState.IconLeftImage = Nothing
        Me.BunifuButton2.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton2.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BunifuButton2.OnPressedState.BorderRadius = 20
        Me.BunifuButton2.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton2.OnPressedState.BorderThickness = 2
        Me.BunifuButton2.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuButton2.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuButton2.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton2.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton2.Size = New System.Drawing.Size(194, 90)
        Me.BunifuButton2.TabIndex = 11
        Me.BunifuButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton2.TextMarginLeft = 0
        Me.BunifuButton2.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton2.UseDefaultRadiusAndThickness = True
        '
        'BunifuButton1
        '
        Me.BunifuButton1.AllowAnimations = True
        Me.BunifuButton1.AllowMouseEffects = True
        Me.BunifuButton1.AllowToggling = False
        Me.BunifuButton1.AnimationSpeed = 200
        Me.BunifuButton1.AutoGenerateColors = False
        Me.BunifuButton1.AutoRoundBorders = False
        Me.BunifuButton1.AutoSizeLeftIcon = True
        Me.BunifuButton1.AutoSizeRightIcon = True
        Me.BunifuButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton1.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BunifuButton1.BackgroundImage = CType(resources.GetObject("BunifuButton1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.ButtonText = "MEU PERFIL"
        Me.BunifuButton1.ButtonTextMarginLeft = 0
        Me.BunifuButton1.ColorContrastOnClick = 45
        Me.BunifuButton1.ColorContrastOnHover = 45
        Me.BunifuButton1.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges3.BottomLeft = True
        BorderEdges3.BottomRight = True
        BorderEdges3.TopLeft = True
        BorderEdges3.TopRight = True
        Me.BunifuButton1.CustomizableEdges = BorderEdges3
        Me.BunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuButton1.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton1.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton1.IconMarginLeft = 11
        Me.BunifuButton1.IconPadding = 10
        Me.BunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton1.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton1.IconSize = 25
        Me.BunifuButton1.IdleBorderColor = System.Drawing.Color.Transparent
        Me.BunifuButton1.IdleBorderRadius = 20
        Me.BunifuButton1.IdleBorderThickness = 2
        Me.BunifuButton1.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BunifuButton1.IdleIconLeftImage = Nothing
        Me.BunifuButton1.IdleIconRightImage = Nothing
        Me.BunifuButton1.IndicateFocus = False
        Me.BunifuButton1.Location = New System.Drawing.Point(61, 223)
        Me.BunifuButton1.Name = "BunifuButton1"
        Me.BunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton1.OnDisabledState.BorderRadius = 20
        Me.BunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.OnDisabledState.BorderThickness = 2
        Me.BunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton1.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton1.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton1.onHoverState.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuButton1.onHoverState.BorderRadius = 20
        Me.BunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.onHoverState.BorderThickness = 2
        Me.BunifuButton1.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuButton1.onHoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuButton1.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton1.onHoverState.IconRightImage = Nothing
        Me.BunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuButton1.OnIdleState.BorderRadius = 20
        Me.BunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.OnIdleState.BorderThickness = 2
        Me.BunifuButton1.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton1.OnIdleState.IconLeftImage = Nothing
        Me.BunifuButton1.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BunifuButton1.OnPressedState.BorderRadius = 20
        Me.BunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.OnPressedState.BorderThickness = 2
        Me.BunifuButton1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuButton1.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton1.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton1.Size = New System.Drawing.Size(194, 90)
        Me.BunifuButton1.TabIndex = 10
        Me.BunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton1.TextMarginLeft = 0
        Me.BunifuButton1.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton1.UseDefaultRadiusAndThickness = True
        '
        'btn_entrar
        '
        Me.btn_entrar.AllowAnimations = True
        Me.btn_entrar.AllowMouseEffects = True
        Me.btn_entrar.AllowToggling = False
        Me.btn_entrar.AnimationSpeed = 200
        Me.btn_entrar.AutoGenerateColors = False
        Me.btn_entrar.AutoRoundBorders = False
        Me.btn_entrar.AutoSizeLeftIcon = True
        Me.btn_entrar.AutoSizeRightIcon = True
        Me.btn_entrar.BackColor = System.Drawing.Color.Transparent
        Me.btn_entrar.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btn_entrar.BackgroundImage = CType(resources.GetObject("btn_entrar.BackgroundImage"), System.Drawing.Image)
        Me.btn_entrar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_entrar.ButtonText = "EXPLORAR"
        Me.btn_entrar.ButtonTextMarginLeft = 0
        Me.btn_entrar.ColorContrastOnClick = 45
        Me.btn_entrar.ColorContrastOnHover = 45
        Me.btn_entrar.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges4.BottomLeft = True
        BorderEdges4.BottomRight = True
        BorderEdges4.TopLeft = True
        BorderEdges4.TopRight = True
        Me.btn_entrar.CustomizableEdges = BorderEdges4
        Me.btn_entrar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_entrar.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btn_entrar.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_entrar.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_entrar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btn_entrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_entrar.ForeColor = System.Drawing.Color.Black
        Me.btn_entrar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_entrar.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.btn_entrar.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.btn_entrar.IconMarginLeft = 11
        Me.btn_entrar.IconPadding = 10
        Me.btn_entrar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_entrar.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.btn_entrar.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.btn_entrar.IconSize = 25
        Me.btn_entrar.IdleBorderColor = System.Drawing.Color.Transparent
        Me.btn_entrar.IdleBorderRadius = 20
        Me.btn_entrar.IdleBorderThickness = 2
        Me.btn_entrar.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btn_entrar.IdleIconLeftImage = Nothing
        Me.btn_entrar.IdleIconRightImage = Nothing
        Me.btn_entrar.IndicateFocus = False
        Me.btn_entrar.Location = New System.Drawing.Point(261, 223)
        Me.btn_entrar.Name = "btn_entrar"
        Me.btn_entrar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btn_entrar.OnDisabledState.BorderRadius = 20
        Me.btn_entrar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_entrar.OnDisabledState.BorderThickness = 2
        Me.btn_entrar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_entrar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_entrar.OnDisabledState.IconLeftImage = Nothing
        Me.btn_entrar.OnDisabledState.IconRightImage = Nothing
        Me.btn_entrar.onHoverState.BorderColor = System.Drawing.Color.Transparent
        Me.btn_entrar.onHoverState.BorderRadius = 20
        Me.btn_entrar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_entrar.onHoverState.BorderThickness = 2
        Me.btn_entrar.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_entrar.onHoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_entrar.onHoverState.IconLeftImage = Nothing
        Me.btn_entrar.onHoverState.IconRightImage = Nothing
        Me.btn_entrar.OnIdleState.BorderColor = System.Drawing.Color.Transparent
        Me.btn_entrar.OnIdleState.BorderRadius = 20
        Me.btn_entrar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_entrar.OnIdleState.BorderThickness = 2
        Me.btn_entrar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btn_entrar.OnIdleState.ForeColor = System.Drawing.Color.Black
        Me.btn_entrar.OnIdleState.IconLeftImage = Nothing
        Me.btn_entrar.OnIdleState.IconRightImage = Nothing
        Me.btn_entrar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btn_entrar.OnPressedState.BorderRadius = 20
        Me.btn_entrar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_entrar.OnPressedState.BorderThickness = 2
        Me.btn_entrar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_entrar.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_entrar.OnPressedState.IconLeftImage = Nothing
        Me.btn_entrar.OnPressedState.IconRightImage = Nothing
        Me.btn_entrar.Size = New System.Drawing.Size(194, 90)
        Me.btn_entrar.TabIndex = 9
        Me.btn_entrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_entrar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.btn_entrar.TextMarginLeft = 0
        Me.btn_entrar.TextPadding = New System.Windows.Forms.Padding(0)
        Me.btn_entrar.UseDefaultRadiusAndThickness = True
        '
        'lbl_nome
        '
        Me.lbl_nome.AllowParentOverrides = False
        Me.lbl_nome.AutoEllipsis = False
        Me.lbl_nome.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl_nome.CursorType = System.Windows.Forms.Cursors.Default
        Me.lbl_nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_nome.Location = New System.Drawing.Point(61, 144)
        Me.lbl_nome.Name = "lbl_nome"
        Me.lbl_nome.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_nome.Size = New System.Drawing.Size(338, 38)
        Me.lbl_nome.TabIndex = 8
        Me.lbl_nome.Text = "Bem vindo(a) de volta"
        Me.lbl_nome.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.lbl_nome.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuPanel1
        '
        Me.BunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BunifuPanel1.BackgroundImage = CType(resources.GetObject("BunifuPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuPanel1.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuPanel1.BorderRadius = 20
        Me.BunifuPanel1.BorderThickness = 1
        Me.BunifuPanel1.Controls.Add(Me.img_foto)
        Me.BunifuPanel1.Location = New System.Drawing.Point(595, 80)
        Me.BunifuPanel1.Name = "BunifuPanel1"
        Me.BunifuPanel1.ShowBorders = True
        Me.BunifuPanel1.Size = New System.Drawing.Size(370, 380)
        Me.BunifuPanel1.TabIndex = 7
        '
        'img_foto
        '
        Me.img_foto.BackgroundImage = Global.prj_si_2022_2S.My.Resources.Resources.nova_foto
        Me.img_foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.img_foto.Location = New System.Drawing.Point(41, 50)
        Me.img_foto.Name = "img_foto"
        Me.img_foto.Size = New System.Drawing.Size(291, 284)
        Me.img_foto.TabIndex = 5
        Me.img_foto.TabStop = False
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.BackgroundImage = CType(resources.GetObject("BunifuSeparator1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.Firebrick
        Me.BunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(79, 319)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal
        Me.BunifuSeparator1.Size = New System.Drawing.Size(354, 14)
        Me.BunifuSeparator1.TabIndex = 6
        '
        'lbl_boas_vindas
        '
        Me.lbl_boas_vindas.AllowParentOverrides = False
        Me.lbl_boas_vindas.AutoEllipsis = False
        Me.lbl_boas_vindas.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl_boas_vindas.CursorType = System.Windows.Forms.Cursors.Default
        Me.lbl_boas_vindas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_boas_vindas.Location = New System.Drawing.Point(61, 104)
        Me.lbl_boas_vindas.Name = "lbl_boas_vindas"
        Me.lbl_boas_vindas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_boas_vindas.Size = New System.Drawing.Size(338, 38)
        Me.lbl_boas_vindas.TabIndex = 0
        Me.lbl_boas_vindas.Text = "Bem vindo(a) de volta"
        Me.lbl_boas_vindas.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.lbl_boas_vindas.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'frm_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1022, 533)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PROJETO SI"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuPanel1.ResumeLayout(False)
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GERENCIARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContasDeUsuáriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SAIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BunifuGradientPanel1 As Bunifu.UI.WinForms.BunifuGradientPanel
    Friend WithEvents elipseBackground As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents lbl_boas_vindas As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents img_foto As PictureBox
    Friend WithEvents BunifuSeparator1 As Bunifu.UI.WinForms.BunifuSeparator
    Friend WithEvents BunifuPanel1 As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents lbl_nome As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuButton3 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents btn_entrar As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents MEUSINGRESSOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SUPORTEToolStripMenuItem As ToolStripMenuItem
End Class
