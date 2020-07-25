namespace Sima.Ar
{
    /*Datos para la grilla:
     * Fecha de generación, tipo, cantidad de solicitudes para el mismo cliente, codVend, codCli
     * */
    partial class AprobacionReservas
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AprobacionReservas));
            this.imgTree = new System.Windows.Forms.ImageList(this.components);
            this.sbMain = new System.Windows.Forms.StatusStrip();
            this.sbpMensaje = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbpConexion = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbpUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbpPercent = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbpAvance = new System.Windows.Forms.ToolStripProgressBar();
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.niSysTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.xpnlBase = new TNGS.NetControls.XPanel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.fullLabel1 = new TNGS.NetControls.FullLabel();
            this.TEObsSol = new TNGS.NetControls.TextEdit();
            this.GBRechazar = new TNGS.NetControls.GlassButton();
            this.GBAceptar = new TNGS.NetControls.GlassButton();
            this.grpInfoCli = new TNGS.NetControls.ImgGroup();
            this.TELoc = new TNGS.NetControls.TextEdit();
            this.TEMayo = new TNGS.NetControls.TextEdit();
            this.fullLabel5 = new TNGS.NetControls.FullLabel();
            this.fullLabel6 = new TNGS.NetControls.FullLabel();
            this.grpInfoVend = new TNGS.NetControls.ImgGroup();
            this.TEMarca = new TNGS.NetControls.TextEdit();
            this.TEGrupo = new TNGS.NetControls.TextEdit();
            this.fullLabel4 = new TNGS.NetControls.FullLabel();
            this.fullLabel3 = new TNGS.NetControls.FullLabel();
            this.udAviso = new System.Windows.Forms.NumericUpDown();
            this.cmdFiltrar = new TNGS.NetControls.GlassButton();
            this.cmdRefresh = new TNGS.NetControls.GlassButton();
            this.cmdVer = new TNGS.NetControls.GlassButton();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.grdPendientes = new TNGS.NetControls.FullGrid();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.sbMain.SuspendLayout();
            this.xpnlBase.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.grpInfoCli.SuspendLayout();
            this.grpInfoVend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udAviso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPendientes)).BeginInit();
            this.SuspendLayout();
            // 
            // imgTree
            // 
            this.imgTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgTree.ImageStream")));
            this.imgTree.TransparentColor = System.Drawing.Color.Magenta;
            this.imgTree.Images.SetKeyName(0, "tbOficinas.bmp");
            this.imgTree.Images.SetKeyName(1, "tbCobradores.bmp");
            this.imgTree.Images.SetKeyName(2, "tbPromotores.bmp");
            this.imgTree.Images.SetKeyName(3, "tbUsuarios.bmp");
            this.imgTree.Images.SetKeyName(4, "tbOfiTree.bmp");
            this.imgTree.Images.SetKeyName(5, "tbOfiFolder.bmp");
            // 
            // sbMain
            // 
            this.sbMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbpMensaje,
            this.sbpConexion,
            this.sbpUsuario,
            this.sbpPercent,
            this.sbpAvance});
            this.sbMain.Location = new System.Drawing.Point(0, 697);
            this.sbMain.Name = "sbMain";
            this.sbMain.Size = new System.Drawing.Size(890, 23);
            this.sbMain.SizingGrip = false;
            this.sbMain.TabIndex = 13;
            this.sbMain.Text = "statusStrip1";
            // 
            // sbpMensaje
            // 
            this.sbpMensaje.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbpMensaje.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sbpMensaje.Name = "sbpMensaje";
            this.sbpMensaje.Size = new System.Drawing.Size(665, 18);
            this.sbpMensaje.Spring = true;
            this.sbpMensaje.Text = "XXX";
            this.sbpMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sbpConexion
            // 
            this.sbpConexion.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.sbpConexion.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbpConexion.Name = "sbpConexion";
            this.sbpConexion.Size = new System.Drawing.Size(27, 18);
            this.sbpConexion.Text = "YY";
            // 
            // sbpUsuario
            // 
            this.sbpUsuario.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.sbpUsuario.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbpUsuario.Name = "sbpUsuario";
            this.sbpUsuario.Size = new System.Drawing.Size(21, 18);
            this.sbpUsuario.Text = "zz";
            // 
            // sbpPercent
            // 
            this.sbpPercent.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbpPercent.Name = "sbpPercent";
            this.sbpPercent.Size = new System.Drawing.Size(43, 18);
            this.sbpPercent.Text = "(15%)";
            // 
            // sbpAvance
            // 
            this.sbpAvance.AutoSize = false;
            this.sbpAvance.Margin = new System.Windows.Forms.Padding(1, 5, 1, 4);
            this.sbpAvance.Name = "sbpAvance";
            this.sbpAvance.Size = new System.Drawing.Size(100, 14);
            // 
            // tmrRefresh
            // 
            this.tmrRefresh.Interval = 60000;
            this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
            // 
            // niSysTray
            // 
            this.niSysTray.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.niSysTray.BalloonTipTitle = "SIMA";
            this.niSysTray.Icon = ((System.Drawing.Icon)(resources.GetObject("niSysTray.Icon")));
            this.niSysTray.Text = "Solicitudes SIMA";
            this.niSysTray.Visible = true;
            this.niSysTray.DoubleClick += new System.EventHandler(this.niSysTray_DoubleClick);
            // 
            // xpnlBase
            // 
            this.xpnlBase.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xpnlBase.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xpnlBase.Controls.Add(this.topPanel);
            this.xpnlBase.Controls.Add(this.fullLabel1);
            this.xpnlBase.Controls.Add(this.TEObsSol);
            this.xpnlBase.Controls.Add(this.GBRechazar);
            this.xpnlBase.Controls.Add(this.GBAceptar);
            this.xpnlBase.Controls.Add(this.grpInfoCli);
            this.xpnlBase.Controls.Add(this.grpInfoVend);
            this.xpnlBase.Controls.Add(this.udAviso);
            this.xpnlBase.Controls.Add(this.cmdFiltrar);
            this.xpnlBase.Controls.Add(this.cmdRefresh);
            this.xpnlBase.Controls.Add(this.cmdVer);
            this.xpnlBase.Controls.Add(this.lblCantidad);
            this.xpnlBase.Controls.Add(this.grdPendientes);
            this.xpnlBase.Controls.Add(this.label2);
            this.xpnlBase.Controls.Add(this.label1);
            this.xpnlBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xpnlBase.Location = new System.Drawing.Point(0, 0);
            this.xpnlBase.Name = "xpnlBase";
            this.xpnlBase.Size = new System.Drawing.Size(890, 697);
            this.xpnlBase.SkinFixed = true;
            this.xpnlBase.TabIndex = 10;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.topPanel.Controls.Add(this.btnMinimize);
            this.topPanel.Controls.Add(this.label3);
            this.topPanel.Controls.Add(this.btnExit);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(890, 40);
            this.topPanel.TabIndex = 33;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(790, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(47, 40);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Solución SIMA";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(832, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(58, 40);
            this.btnExit.TabIndex = 1;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // fullLabel1
            // 
            this.fullLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fullLabel1.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel1.Location = new System.Drawing.Point(12, 463);
            this.fullLabel1.Name = "fullLabel1";
            this.fullLabel1.Size = new System.Drawing.Size(98, 39);
            this.fullLabel1.TabIndex = 32;
            this.fullLabel1.Text = "Observacion del Solicitante:";
            this.fullLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TEObsSol
            // 
            this.TEObsSol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TEObsSol.BackColor = System.Drawing.SystemColors.Window;
            this.TEObsSol.Location = new System.Drawing.Point(133, 460);
            this.TEObsSol.Multiline = true;
            this.TEObsSol.Name = "TEObsSol";
            this.TEObsSol.Size = new System.Drawing.Size(605, 42);
            this.TEObsSol.TabIndex = 1;
            // 
            // GBRechazar
            // 
            this.GBRechazar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GBRechazar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GBRechazar.BackgroundImage")));
            this.GBRechazar.BlackBorder = true;
            this.GBRechazar.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.GBRechazar.CircleButton = false;
            this.GBRechazar.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Cancel;
            this.GBRechazar.FlatColor = System.Drawing.Color.Red;
            this.GBRechazar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Cancelar;
            this.GBRechazar.FlatFontSize = 9;
            this.GBRechazar.FlatTextColor = System.Drawing.Color.Black;
            this.GBRechazar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.GBRechazar.ImageOnTop = true;
            this.GBRechazar.Location = new System.Drawing.Point(785, 604);
            this.GBRechazar.Name = "GBRechazar";
            this.GBRechazar.RoundCorners = 2;
            this.GBRechazar.Size = new System.Drawing.Size(70, 60);
            this.GBRechazar.TabIndex = 5;
            this.GBRechazar.Text = "Rechazar";
            this.GBRechazar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GBRechazar.W8Color = System.Drawing.Color.Red;
            this.GBRechazar.Click += new System.EventHandler(this.GBRechazar_Click);
            // 
            // GBAceptar
            // 
            this.GBAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GBAceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GBAceptar.BackgroundImage")));
            this.GBAceptar.BlackBorder = true;
            this.GBAceptar.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.GBAceptar.CircleButton = false;
            this.GBAceptar.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Accept;
            this.GBAceptar.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.GBAceptar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Aceptar;
            this.GBAceptar.FlatFontSize = 9;
            this.GBAceptar.FlatTextColor = System.Drawing.Color.Black;
            this.GBAceptar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.GBAceptar.ImageOnTop = true;
            this.GBAceptar.Location = new System.Drawing.Point(785, 460);
            this.GBAceptar.Name = "GBAceptar";
            this.GBAceptar.RoundCorners = 2;
            this.GBAceptar.Size = new System.Drawing.Size(70, 60);
            this.GBAceptar.TabIndex = 3;
            this.GBAceptar.Text = "Aceptar";
            this.GBAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GBAceptar.W8Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.GBAceptar.Click += new System.EventHandler(this.GBAceptar_Click);
            // 
            // grpInfoCli
            // 
            this.grpInfoCli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpInfoCli.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grpInfoCli.BackgroundGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grpInfoCli.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.ForwardDiagonal;
            this.grpInfoCli.BlackBorder = true;
            this.grpInfoCli.BorderColor = System.Drawing.Color.DodgerBlue;
            this.grpInfoCli.BorderThickness = 1F;
            this.grpInfoCli.Controls.Add(this.TELoc);
            this.grpInfoCli.Controls.Add(this.TEMayo);
            this.grpInfoCli.Controls.Add(this.fullLabel5);
            this.grpInfoCli.Controls.Add(this.fullLabel6);
            this.grpInfoCli.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grpInfoCli.FlatMode = true;
            this.grpInfoCli.FontTitle = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfoCli.ForeColor = System.Drawing.Color.Black;
            this.grpInfoCli.GroupImage = null;
            this.grpInfoCli.GroupTitle = "Cliente";
            this.grpInfoCli.Location = new System.Drawing.Point(383, 516);
            this.grpInfoCli.Name = "grpInfoCli";
            this.grpInfoCli.Padding = new System.Windows.Forms.Padding(20);
            this.grpInfoCli.PaintGroupBox = false;
            this.grpInfoCli.RoundCorners = 4;
            this.grpInfoCli.ShadowColor = System.Drawing.Color.DarkGray;
            this.grpInfoCli.ShadowControl = false;
            this.grpInfoCli.ShadowThickness = 3;
            this.grpInfoCli.Size = new System.Drawing.Size(355, 140);
            this.grpInfoCli.SkinFixed = true;
            this.grpInfoCli.TabIndex = 2;
            this.grpInfoCli.TitleBackground = System.Drawing.Color.DodgerBlue;
            this.grpInfoCli.TitleBackgroundDefault = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.grpInfoCli.TitleFontColor = System.Drawing.Color.White;
            // 
            // TELoc
            // 
            this.TELoc.BackColor = System.Drawing.SystemColors.Window;
            this.TELoc.Location = new System.Drawing.Point(117, 89);
            this.TELoc.Name = "TELoc";
            this.TELoc.Size = new System.Drawing.Size(215, 21);
            this.TELoc.TabIndex = 0;
            // 
            // TEMayo
            // 
            this.TEMayo.BackColor = System.Drawing.SystemColors.Window;
            this.TEMayo.Location = new System.Drawing.Point(117, 49);
            this.TEMayo.Name = "TEMayo";
            this.TEMayo.Size = new System.Drawing.Size(44, 21);
            this.TEMayo.TabIndex = 14;
            // 
            // fullLabel5
            // 
            this.fullLabel5.Location = new System.Drawing.Point(32, 92);
            this.fullLabel5.Name = "fullLabel5";
            this.fullLabel5.Size = new System.Drawing.Size(79, 23);
            this.fullLabel5.TabIndex = 12;
            this.fullLabel5.Text = "Localidad:";
            // 
            // fullLabel6
            // 
            this.fullLabel6.Location = new System.Drawing.Point(32, 52);
            this.fullLabel6.Name = "fullLabel6";
            this.fullLabel6.Size = new System.Drawing.Size(79, 23);
            this.fullLabel6.TabIndex = 11;
            this.fullLabel6.Text = "Mayorista:";
            // 
            // grpInfoVend
            // 
            this.grpInfoVend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpInfoVend.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grpInfoVend.BackgroundGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grpInfoVend.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.ForwardDiagonal;
            this.grpInfoVend.BlackBorder = true;
            this.grpInfoVend.BorderColor = System.Drawing.Color.DodgerBlue;
            this.grpInfoVend.BorderThickness = 1F;
            this.grpInfoVend.Controls.Add(this.TEMarca);
            this.grpInfoVend.Controls.Add(this.TEGrupo);
            this.grpInfoVend.Controls.Add(this.fullLabel4);
            this.grpInfoVend.Controls.Add(this.fullLabel3);
            this.grpInfoVend.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grpInfoVend.FlatMode = true;
            this.grpInfoVend.FontTitle = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfoVend.ForeColor = System.Drawing.Color.Black;
            this.grpInfoVend.GroupImage = null;
            this.grpInfoVend.GroupTitle = "Vendedor";
            this.grpInfoVend.Location = new System.Drawing.Point(16, 517);
            this.grpInfoVend.Name = "grpInfoVend";
            this.grpInfoVend.Padding = new System.Windows.Forms.Padding(20);
            this.grpInfoVend.PaintGroupBox = false;
            this.grpInfoVend.RoundCorners = 4;
            this.grpInfoVend.ShadowColor = System.Drawing.Color.DarkGray;
            this.grpInfoVend.ShadowControl = false;
            this.grpInfoVend.ShadowThickness = 3;
            this.grpInfoVend.Size = new System.Drawing.Size(355, 140);
            this.grpInfoVend.SkinFixed = true;
            this.grpInfoVend.TabIndex = 26;
            this.grpInfoVend.TitleBackground = System.Drawing.Color.DodgerBlue;
            this.grpInfoVend.TitleBackgroundDefault = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.grpInfoVend.TitleFontColor = System.Drawing.Color.White;
            // 
            // TEMarca
            // 
            this.TEMarca.BackColor = System.Drawing.SystemColors.Window;
            this.TEMarca.Location = new System.Drawing.Point(125, 89);
            this.TEMarca.Name = "TEMarca";
            this.TEMarca.Size = new System.Drawing.Size(199, 21);
            this.TEMarca.TabIndex = 1;
            // 
            // TEGrupo
            // 
            this.TEGrupo.BackColor = System.Drawing.SystemColors.Window;
            this.TEGrupo.Location = new System.Drawing.Point(125, 49);
            this.TEGrupo.Name = "TEGrupo";
            this.TEGrupo.Size = new System.Drawing.Size(199, 21);
            this.TEGrupo.TabIndex = 0;
            // 
            // fullLabel4
            // 
            this.fullLabel4.Location = new System.Drawing.Point(40, 92);
            this.fullLabel4.Name = "fullLabel4";
            this.fullLabel4.Size = new System.Drawing.Size(79, 23);
            this.fullLabel4.TabIndex = 4;
            this.fullLabel4.Text = "Marca:";
            // 
            // fullLabel3
            // 
            this.fullLabel3.Location = new System.Drawing.Point(40, 52);
            this.fullLabel3.Name = "fullLabel3";
            this.fullLabel3.Size = new System.Drawing.Size(79, 23);
            this.fullLabel3.TabIndex = 3;
            this.fullLabel3.Text = "Grupo:";
            // 
            // udAviso
            // 
            this.udAviso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.udAviso.Location = new System.Drawing.Point(235, 663);
            this.udAviso.Name = "udAviso";
            this.udAviso.Size = new System.Drawing.Size(41, 21);
            this.udAviso.TabIndex = 24;
            this.udAviso.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.udAviso.ValueChanged += new System.EventHandler(this.udAviso_ValueChanged);
            // 
            // cmdFiltrar
            // 
            this.cmdFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdFiltrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdFiltrar.BackgroundImage")));
            this.cmdFiltrar.BlackBorder = true;
            this.cmdFiltrar.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.cmdFiltrar.CircleButton = false;
            this.cmdFiltrar.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.fFilter;
            this.cmdFiltrar.FlatColor = System.Drawing.Color.DodgerBlue;
            this.cmdFiltrar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.LightBlue;
            this.cmdFiltrar.FlatFontSize = 9;
            this.cmdFiltrar.FlatTextColor = System.Drawing.Color.Black;
            this.cmdFiltrar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmdFiltrar.Location = new System.Drawing.Point(824, 61);
            this.cmdFiltrar.Name = "cmdFiltrar";
            this.cmdFiltrar.RoundCorners = 2;
            this.cmdFiltrar.Size = new System.Drawing.Size(26, 24);
            this.cmdFiltrar.TabIndex = 22;
            this.cmdFiltrar.Tag = "14";
            this.cmdFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdFiltrar.ToolTipText = "Filtra la grilla por la columna solicitada";
            this.cmdFiltrar.W8Color = System.Drawing.Color.DodgerBlue;
            this.cmdFiltrar.Click += new System.EventHandler(this.cmdFiltrar_Click);
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdRefresh.BackgroundImage")));
            this.cmdRefresh.BlackBorder = true;
            this.cmdRefresh.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.cmdRefresh.CircleButton = false;
            this.cmdRefresh.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.fRefresh;
            this.cmdRefresh.FlatColor = System.Drawing.Color.DodgerBlue;
            this.cmdRefresh.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.LightBlue;
            this.cmdRefresh.FlatFontSize = 9;
            this.cmdRefresh.FlatTextColor = System.Drawing.Color.Black;
            this.cmdRefresh.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmdRefresh.Location = new System.Drawing.Point(856, 61);
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.RoundCorners = 2;
            this.cmdRefresh.Size = new System.Drawing.Size(26, 24);
            this.cmdRefresh.TabIndex = 18;
            this.cmdRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdRefresh.ToolTipText = "Actualiza la lista de pendientes";
            this.cmdRefresh.W8Color = System.Drawing.Color.DodgerBlue;
            this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
            // 
            // cmdVer
            // 
            this.cmdVer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdVer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdVer.BackgroundImage")));
            this.cmdVer.BlackBorder = true;
            this.cmdVer.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.cmdVer.CircleButton = false;
            this.cmdVer.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Search;
            this.cmdVer.FlatColor = System.Drawing.Color.DodgerBlue;
            this.cmdVer.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.LightBlue;
            this.cmdVer.FlatFontSize = 9;
            this.cmdVer.FlatTextColor = System.Drawing.Color.Black;
            this.cmdVer.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmdVer.ImageOnTop = true;
            this.cmdVer.Location = new System.Drawing.Point(785, 532);
            this.cmdVer.Name = "cmdVer";
            this.cmdVer.RoundCorners = 2;
            this.cmdVer.Size = new System.Drawing.Size(70, 60);
            this.cmdVer.TabIndex = 4;
            this.cmdVer.Text = "Detalle";
            this.cmdVer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdVer.ToolTipText = "Muestra los datos de la solicitud";
            this.cmdVer.W8Color = System.Drawing.Color.DodgerBlue;
            this.cmdVer.Click += new System.EventHandler(this.cmdVer_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(8, 63);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(324, 24);
            this.lblCantidad.TabIndex = 15;
            this.lblCantidad.Text = "No hay solicitudes pendientes";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grdPendientes
            // 
            this.grdPendientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdPendientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdPendientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grdPendientes.CaptionBackColor = System.Drawing.Color.DodgerBlue;
            this.grdPendientes.CaptionFilterColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdPendientes.CaptionForeColor = System.Drawing.Color.Black;
            this.grdPendientes.CaptionText = "Solicitudes";
            this.grdPendientes.DataMember = "";
            this.grdPendientes.ExcelName = "Datos Exportados";
            this.grdPendientes.ExcelTitle = "";
            this.grdPendientes.GridOrder = "";
            this.grdPendientes.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.grdPendientes.Location = new System.Drawing.Point(8, 87);
            this.grdPendientes.Name = "grdPendientes";
            this.grdPendientes.Size = new System.Drawing.Size(874, 363);
            this.grdPendientes.SkinFixed = true;
            this.grdPendientes.TabIndex = 0;
            this.grdPendientes.GetColor += new TNGS.NetRoutines.GetColorEventHandler(this.grdPendientes_GetColor);
            this.grdPendientes.CurrentCellChanged += new System.EventHandler(this.grdPendientes_CurrentCellChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(277, 665);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "minutos.";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(23, 665);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Avisarme de nuevas solicitudes cada";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.topPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // AprobacionReservas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(890, 720);
            this.Controls.Add(this.xpnlBase);
            this.Controls.Add(this.sbMain);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AprobacionReservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aprobacion de Reservas";
            this.Activated += new System.EventHandler(this.AprobacionReservas_Activated);
            this.Load += new System.EventHandler(this.Mainframe_Load);
            this.Resize += new System.EventHandler(this.Mainframe_Resize);
            this.sbMain.ResumeLayout(false);
            this.sbMain.PerformLayout();
            this.xpnlBase.ResumeLayout(false);
            this.xpnlBase.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.grpInfoCli.ResumeLayout(false);
            this.grpInfoCli.PerformLayout();
            this.grpInfoVend.ResumeLayout(false);
            this.grpInfoVend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udAviso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPendientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imgTree;
        private System.Windows.Forms.StatusStrip sbMain;
        private System.Windows.Forms.ToolStripStatusLabel sbpMensaje;
        private System.Windows.Forms.ToolStripStatusLabel sbpConexion;
        private System.Windows.Forms.ToolStripStatusLabel sbpUsuario;
        private System.Windows.Forms.ToolStripStatusLabel sbpPercent;
        private System.Windows.Forms.ToolStripProgressBar sbpAvance;
        private TNGS.NetControls.FullGrid grdPendientes;
        private System.Windows.Forms.Label lblCantidad;
        private TNGS.NetControls.GlassButton cmdVer;
        private TNGS.NetControls.GlassButton cmdRefresh;
        private System.Windows.Forms.Timer tmrRefresh;
        private TNGS.NetControls.GlassButton cmdFiltrar;
        private System.Windows.Forms.NotifyIcon niSysTray;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown udAviso;
        private System.Windows.Forms.Label label2;
        private TNGS.NetControls.XPanel xpnlBase;
        private TNGS.NetControls.ImgGroup grpInfoVend;
        private TNGS.NetControls.GlassButton GBRechazar;
        private TNGS.NetControls.GlassButton GBAceptar;
        private TNGS.NetControls.ImgGroup grpInfoCli;
        private TNGS.NetControls.TextEdit TEMarca;
        private TNGS.NetControls.TextEdit TEGrupo;
        private TNGS.NetControls.FullLabel fullLabel4;
        private TNGS.NetControls.FullLabel fullLabel3;
        private TNGS.NetControls.TextEdit TELoc;
        private TNGS.NetControls.TextEdit TEMayo;
        private TNGS.NetControls.FullLabel fullLabel5;
        private TNGS.NetControls.FullLabel fullLabel6;
        private TNGS.NetControls.FullLabel fullLabel1;
        private TNGS.NetControls.TextEdit TEObsSol;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExit;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}