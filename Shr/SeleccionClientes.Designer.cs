namespace Carm.Shr
{
    partial class SeleccionClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeleccionClientes));
            this.xPanel1 = new TNGS.NetControls.XPanel();
            this.mpPanelesOperativos = new TNGS.NetControls.MultiPanel();
            this.mppCambioVisibilidades = new TNGS.NetControls.MultiPanelPage();
            this.xPanel2 = new TNGS.NetControls.XPanel();
            this.cdcMarcas = new TNGS.NetControls.CDCombo();
            this.fllMarcas = new TNGS.NetControls.FullLabel();
            this.gbAgregarVisibilidad = new TNGS.NetControls.GlassButton();
            this.gbQuitarVisibilidad = new TNGS.NetControls.GlassButton();
            this.mppSeleccionarClientes = new TNGS.NetControls.MultiPanelPage();
            this.xPanel3 = new TNGS.NetControls.XPanel();
            this.gbConfirmarSeleccion = new TNGS.NetControls.GlassButton();
            this.gbCancelar = new TNGS.NetControls.GlassButton();
            this.mppCambioVendido = new TNGS.NetControls.MultiPanelPage();
            this.xPanel4 = new TNGS.NetControls.XPanel();
            this.gbMarcarVendido = new TNGS.NetControls.GlassButton();
            this.gbMarcarNoVendido = new TNGS.NetControls.GlassButton();
            this.flCantidad = new TNGS.NetControls.FullLabel();
            this.gbAgregarFiltros = new TNGS.NetControls.GlassButton();
            this.mrClientes = new TNGS.NetControls.MiniReport();
            this.fullLabel1 = new TNGS.NetControls.FullLabel();
            this.neNumeroConjunto = new TNGS.NetControls.NumberEdit();
            this.fullLabel2 = new TNGS.NetControls.FullLabel();
            this.gbTildar = new TNGS.NetControls.GlassButton();
            this.xPanel1.SuspendLayout();
            this.mpPanelesOperativos.SuspendLayout();
            this.mppCambioVisibilidades.SuspendLayout();
            this.xPanel2.SuspendLayout();
            this.mppSeleccionarClientes.SuspendLayout();
            this.xPanel3.SuspendLayout();
            this.mppCambioVendido.SuspendLayout();
            this.xPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // xPanel1
            // 
            this.xPanel1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanel1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanel1.BorderColor = System.Drawing.Color.Black;
            this.xPanel1.Controls.Add(this.mpPanelesOperativos);
            this.xPanel1.Controls.Add(this.flCantidad);
            this.xPanel1.Controls.Add(this.gbAgregarFiltros);
            this.xPanel1.Controls.Add(this.mrClientes);
            this.xPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xPanel1.Location = new System.Drawing.Point(0, 0);
            this.xPanel1.Name = "xPanel1";
            this.xPanel1.Size = new System.Drawing.Size(900, 575);
            this.xPanel1.SkinFixed = true;
            this.xPanel1.TabIndex = 0;
            // 
            // mpPanelesOperativos
            // 
            this.mpPanelesOperativos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mpPanelesOperativos.Controls.Add(this.mppCambioVisibilidades);
            this.mpPanelesOperativos.Controls.Add(this.mppSeleccionarClientes);
            this.mpPanelesOperativos.Controls.Add(this.mppCambioVendido);
            this.mpPanelesOperativos.Location = new System.Drawing.Point(3, 491);
            this.mpPanelesOperativos.Name = "mpPanelesOperativos";
            this.mpPanelesOperativos.SelectedPage = this.mppSeleccionarClientes;
            this.mpPanelesOperativos.Size = new System.Drawing.Size(894, 81);
            this.mpPanelesOperativos.TabIndex = 14;
            // 
            // mppCambioVisibilidades
            // 
            this.mppCambioVisibilidades.Controls.Add(this.xPanel2);
            this.mppCambioVisibilidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mppCambioVisibilidades.Location = new System.Drawing.Point(0, 0);
            this.mppCambioVisibilidades.Name = "mppCambioVisibilidades";
            this.mppCambioVisibilidades.Size = new System.Drawing.Size(823, 81);
            this.mppCambioVisibilidades.TabIndex = 0;
            this.mppCambioVisibilidades.Text = "multiPanelPage1";
            // 
            // xPanel2
            // 
            this.xPanel2.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanel2.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanel2.Controls.Add(this.cdcMarcas);
            this.xPanel2.Controls.Add(this.fllMarcas);
            this.xPanel2.Controls.Add(this.gbAgregarVisibilidad);
            this.xPanel2.Controls.Add(this.gbQuitarVisibilidad);
            this.xPanel2.Location = new System.Drawing.Point(0, 0);
            this.xPanel2.Name = "xPanel2";
            this.xPanel2.Size = new System.Drawing.Size(823, 81);
            this.xPanel2.SkinFixed = true;
            this.xPanel2.TabIndex = 0;
            // 
            // cdcMarcas
            // 
            this.cdcMarcas.BackColor = System.Drawing.SystemColors.Window;
            this.cdcMarcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdcMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cdcMarcas.FormattingEnabled = true;
            this.cdcMarcas.Location = new System.Drawing.Point(101, 13);
            this.cdcMarcas.Name = "cdcMarcas";
            this.cdcMarcas.Size = new System.Drawing.Size(254, 21);
            this.cdcMarcas.Sorted = true;
            this.cdcMarcas.TabIndex = 11;
            // 
            // fllMarcas
            // 
            this.fllMarcas.BackColor = System.Drawing.Color.Transparent;
            this.fllMarcas.Location = new System.Drawing.Point(27, 11);
            this.fllMarcas.Name = "fllMarcas";
            this.fllMarcas.Size = new System.Drawing.Size(100, 23);
            this.fllMarcas.TabIndex = 12;
            this.fllMarcas.Text = "Marca:";
            this.fllMarcas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbAgregarVisibilidad
            // 
            this.gbAgregarVisibilidad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbAgregarVisibilidad.BackgroundImage")));
            this.gbAgregarVisibilidad.BlackBorder = true;
            this.gbAgregarVisibilidad.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbAgregarVisibilidad.CircleButton = false;
            this.gbAgregarVisibilidad.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Accept;
            this.gbAgregarVisibilidad.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gbAgregarVisibilidad.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Aceptar;
            this.gbAgregarVisibilidad.FlatFontSize = 9;
            this.gbAgregarVisibilidad.FlatTextColor = System.Drawing.Color.Black;
            this.gbAgregarVisibilidad.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbAgregarVisibilidad.ImageOnTop = true;
            this.gbAgregarVisibilidad.Location = new System.Drawing.Point(700, 6);
            this.gbAgregarVisibilidad.Name = "gbAgregarVisibilidad";
            this.gbAgregarVisibilidad.PCode = "CAMBIOVISCLI";
            this.gbAgregarVisibilidad.RoundCorners = 2;
            this.gbAgregarVisibilidad.Size = new System.Drawing.Size(82, 69);
            this.gbAgregarVisibilidad.TabIndex = 9;
            this.gbAgregarVisibilidad.Text = "Habilitar Visibilidad";
            this.gbAgregarVisibilidad.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gbAgregarVisibilidad.W8Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gbAgregarVisibilidad.Click += new System.EventHandler(this.gbAgregarVisibilidad_Click);
            // 
            // gbQuitarVisibilidad
            // 
            this.gbQuitarVisibilidad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbQuitarVisibilidad.BackgroundImage")));
            this.gbQuitarVisibilidad.BlackBorder = true;
            this.gbQuitarVisibilidad.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbQuitarVisibilidad.CircleButton = false;
            this.gbQuitarVisibilidad.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Block;
            this.gbQuitarVisibilidad.FlatColor = System.Drawing.Color.Red;
            this.gbQuitarVisibilidad.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Cancelar;
            this.gbQuitarVisibilidad.FlatFontSize = 9;
            this.gbQuitarVisibilidad.FlatTextColor = System.Drawing.Color.Black;
            this.gbQuitarVisibilidad.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbQuitarVisibilidad.ImageOnTop = true;
            this.gbQuitarVisibilidad.Location = new System.Drawing.Point(513, 6);
            this.gbQuitarVisibilidad.Name = "gbQuitarVisibilidad";
            this.gbQuitarVisibilidad.PCode = "CAMBIOVISCLI";
            this.gbQuitarVisibilidad.RoundCorners = 2;
            this.gbQuitarVisibilidad.Size = new System.Drawing.Size(88, 69);
            this.gbQuitarVisibilidad.TabIndex = 10;
            this.gbQuitarVisibilidad.Text = "Deshabilitar Visibilidad";
            this.gbQuitarVisibilidad.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gbQuitarVisibilidad.W8Color = System.Drawing.Color.Red;
            // 
            // mppSeleccionarClientes
            // 
            this.mppSeleccionarClientes.Controls.Add(this.xPanel3);
            this.mppSeleccionarClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mppSeleccionarClientes.Location = new System.Drawing.Point(0, 0);
            this.mppSeleccionarClientes.Name = "mppSeleccionarClientes";
            this.mppSeleccionarClientes.Size = new System.Drawing.Size(894, 81);
            this.mppSeleccionarClientes.TabIndex = 1;
            this.mppSeleccionarClientes.Text = "Page_1";
            // 
            // xPanel3
            // 
            this.xPanel3.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanel3.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanel3.Controls.Add(this.gbTildar);
            this.xPanel3.Controls.Add(this.neNumeroConjunto);
            this.xPanel3.Controls.Add(this.fullLabel2);
            this.xPanel3.Controls.Add(this.fullLabel1);
            this.xPanel3.Controls.Add(this.gbConfirmarSeleccion);
            this.xPanel3.Controls.Add(this.gbCancelar);
            this.xPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xPanel3.Location = new System.Drawing.Point(0, 0);
            this.xPanel3.Name = "xPanel3";
            this.xPanel3.Size = new System.Drawing.Size(894, 81);
            this.xPanel3.SkinFixed = true;
            this.xPanel3.TabIndex = 0;
            // 
            // gbConfirmarSeleccion
            // 
            this.gbConfirmarSeleccion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbConfirmarSeleccion.BackgroundImage")));
            this.gbConfirmarSeleccion.BlackBorder = true;
            this.gbConfirmarSeleccion.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbConfirmarSeleccion.CircleButton = false;
            this.gbConfirmarSeleccion.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Accept;
            this.gbConfirmarSeleccion.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gbConfirmarSeleccion.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Aceptar;
            this.gbConfirmarSeleccion.FlatFontSize = 9;
            this.gbConfirmarSeleccion.FlatTextColor = System.Drawing.Color.Black;
            this.gbConfirmarSeleccion.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbConfirmarSeleccion.ImageOnTop = true;
            this.gbConfirmarSeleccion.Location = new System.Drawing.Point(605, 3);
            this.gbConfirmarSeleccion.Name = "gbConfirmarSeleccion";
            this.gbConfirmarSeleccion.PCode = "CAMBIOVISCLI";
            this.gbConfirmarSeleccion.RoundCorners = 2;
            this.gbConfirmarSeleccion.Size = new System.Drawing.Size(82, 69);
            this.gbConfirmarSeleccion.TabIndex = 11;
            this.gbConfirmarSeleccion.Text = "Confirmar Selección";
            this.gbConfirmarSeleccion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gbConfirmarSeleccion.W8Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gbConfirmarSeleccion.Click += new System.EventHandler(this.gbConfirmarSeleccion_Click);
            // 
            // gbCancelar
            // 
            this.gbCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbCancelar.BackgroundImage")));
            this.gbCancelar.BlackBorder = true;
            this.gbCancelar.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbCancelar.CircleButton = false;
            this.gbCancelar.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Cancel;
            this.gbCancelar.FlatColor = System.Drawing.Color.Red;
            this.gbCancelar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Cancelar;
            this.gbCancelar.FlatFontSize = 9;
            this.gbCancelar.FlatTextColor = System.Drawing.Color.Black;
            this.gbCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbCancelar.ImageOnTop = true;
            this.gbCancelar.Location = new System.Drawing.Point(368, 3);
            this.gbCancelar.Name = "gbCancelar";
            this.gbCancelar.PCode = "CAMBIOVISCLI";
            this.gbCancelar.RoundCorners = 2;
            this.gbCancelar.Size = new System.Drawing.Size(82, 69);
            this.gbCancelar.TabIndex = 12;
            this.gbCancelar.Text = "Cancelar";
            this.gbCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gbCancelar.W8Color = System.Drawing.Color.Red;
            this.gbCancelar.Click += new System.EventHandler(this.gbCancelar_Click);
            // 
            // mppCambioVendido
            // 
            this.mppCambioVendido.Controls.Add(this.xPanel4);
            this.mppCambioVendido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mppCambioVendido.Location = new System.Drawing.Point(0, 0);
            this.mppCambioVendido.Name = "mppCambioVendido";
            this.mppCambioVendido.Size = new System.Drawing.Size(823, 81);
            this.mppCambioVendido.TabIndex = 2;
            this.mppCambioVendido.Text = "Page_1";
            // 
            // xPanel4
            // 
            this.xPanel4.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanel4.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanel4.Controls.Add(this.gbMarcarVendido);
            this.xPanel4.Controls.Add(this.gbMarcarNoVendido);
            this.xPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xPanel4.Location = new System.Drawing.Point(0, 0);
            this.xPanel4.Name = "xPanel4";
            this.xPanel4.Size = new System.Drawing.Size(823, 81);
            this.xPanel4.SkinFixed = true;
            this.xPanel4.TabIndex = 1;
            // 
            // gbMarcarVendido
            // 
            this.gbMarcarVendido.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbMarcarVendido.BackgroundImage")));
            this.gbMarcarVendido.BlackBorder = true;
            this.gbMarcarVendido.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbMarcarVendido.CircleButton = false;
            this.gbMarcarVendido.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Accept;
            this.gbMarcarVendido.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gbMarcarVendido.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Aceptar;
            this.gbMarcarVendido.FlatFontSize = 9;
            this.gbMarcarVendido.FlatTextColor = System.Drawing.Color.Black;
            this.gbMarcarVendido.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbMarcarVendido.ImageOnTop = true;
            this.gbMarcarVendido.Location = new System.Drawing.Point(526, 4);
            this.gbMarcarVendido.Name = "gbMarcarVendido";
            this.gbMarcarVendido.PCode = "ALTBAJMASIVAS";
            this.gbMarcarVendido.RoundCorners = 2;
            this.gbMarcarVendido.Size = new System.Drawing.Size(85, 71);
            this.gbMarcarVendido.TabIndex = 9;
            this.gbMarcarVendido.Text = "Marcar Vendido";
            this.gbMarcarVendido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gbMarcarVendido.W8Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gbMarcarVendido.Click += new System.EventHandler(this.gbMarcarVendido_Click);
            // 
            // gbMarcarNoVendido
            // 
            this.gbMarcarNoVendido.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbMarcarNoVendido.BackgroundImage")));
            this.gbMarcarNoVendido.BlackBorder = true;
            this.gbMarcarNoVendido.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbMarcarNoVendido.CircleButton = false;
            this.gbMarcarNoVendido.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Cancel;
            this.gbMarcarNoVendido.FlatColor = System.Drawing.Color.Red;
            this.gbMarcarNoVendido.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Cancelar;
            this.gbMarcarNoVendido.FlatFontSize = 9;
            this.gbMarcarNoVendido.FlatTextColor = System.Drawing.Color.Black;
            this.gbMarcarNoVendido.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbMarcarNoVendido.ImageOnTop = true;
            this.gbMarcarNoVendido.Location = new System.Drawing.Point(269, 4);
            this.gbMarcarNoVendido.Name = "gbMarcarNoVendido";
            this.gbMarcarNoVendido.PCode = "ALTBAJMASIVAS";
            this.gbMarcarNoVendido.RoundCorners = 2;
            this.gbMarcarNoVendido.Size = new System.Drawing.Size(85, 71);
            this.gbMarcarNoVendido.TabIndex = 10;
            this.gbMarcarNoVendido.Text = "Marcar No Vendido";
            this.gbMarcarNoVendido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gbMarcarNoVendido.W8Color = System.Drawing.Color.Red;
            this.gbMarcarNoVendido.Click += new System.EventHandler(this.gbMarcarNoVendido_Click);
            // 
            // flCantidad
            // 
            this.flCantidad.BackColor = System.Drawing.Color.Transparent;
            this.flCantidad.Location = new System.Drawing.Point(113, 7);
            this.flCantidad.Name = "flCantidad";
            this.flCantidad.Size = new System.Drawing.Size(350, 18);
            this.flCantidad.TabIndex = 13;
            this.flCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbAgregarFiltros
            // 
            this.gbAgregarFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAgregarFiltros.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbAgregarFiltros.BackgroundImage")));
            this.gbAgregarFiltros.BlackBorder = true;
            this.gbAgregarFiltros.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbAgregarFiltros.CircleButton = false;
            this.gbAgregarFiltros.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.fSearch;
            this.gbAgregarFiltros.FlatColor = System.Drawing.Color.DodgerBlue;
            this.gbAgregarFiltros.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.LightBlue;
            this.gbAgregarFiltros.FlatFontSize = 9;
            this.gbAgregarFiltros.FlatTextColor = System.Drawing.Color.Black;
            this.gbAgregarFiltros.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbAgregarFiltros.Location = new System.Drawing.Point(716, 14);
            this.gbAgregarFiltros.Name = "gbAgregarFiltros";
            this.gbAgregarFiltros.RoundCorners = 2;
            this.gbAgregarFiltros.Size = new System.Drawing.Size(26, 24);
            this.gbAgregarFiltros.TabIndex = 8;
            this.gbAgregarFiltros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbAgregarFiltros.ToolTipText = "Agregar Filtros a la busqueda";
            this.gbAgregarFiltros.W8Color = System.Drawing.Color.DodgerBlue;
            this.gbAgregarFiltros.Click += new System.EventHandler(this.gbAgregarFiltros_Click);
            // 
            // mrClientes
            // 
            this.mrClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mrClientes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrClientes.Location = new System.Drawing.Point(3, 12);
            this.mrClientes.Name = "mrClientes";
            this.mrClientes.ShowExcel = false;
            this.mrClientes.ShowPrtAll = false;
            this.mrClientes.ShowPrtOne = false;
            this.mrClientes.ShowZoom = false;
            this.mrClientes.Size = new System.Drawing.Size(894, 473);
            this.mrClientes.SkinFixed = true;
            this.mrClientes.TabIndex = 0;
            this.mrClientes.WithCheckBoxes = true;
            this.mrClientes.FiltersChanged += new System.EventHandler(this.mrClientes_FiltersChanged);
            // 
            // fullLabel1
            // 
            this.fullLabel1.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel1.Location = new System.Drawing.Point(24, 27);
            this.fullLabel1.Name = "fullLabel1";
            this.fullLabel1.Size = new System.Drawing.Size(43, 23);
            this.fullLabel1.TabIndex = 13;
            this.fullLabel1.Text = "Tildar ";
            this.fullLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // neNumeroConjunto
            // 
            this.neNumeroConjunto.BackColor = System.Drawing.SystemColors.Window;
            this.neNumeroConjunto.Location = new System.Drawing.Point(61, 27);
            this.neNumeroConjunto.Name = "neNumeroConjunto";
            this.neNumeroConjunto.Size = new System.Drawing.Size(35, 20);
            this.neNumeroConjunto.TabIndex = 14;
            this.neNumeroConjunto.Text = "0";
            // 
            // fullLabel2
            // 
            this.fullLabel2.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel2.Location = new System.Drawing.Point(92, 26);
            this.fullLabel2.Name = "fullLabel2";
            this.fullLabel2.Size = new System.Drawing.Size(126, 23);
            this.fullLabel2.TabIndex = 15;
            this.fullLabel2.Text = "conjunto de 50 clientes";
            this.fullLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbTildar
            // 
            this.gbTildar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTildar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbTildar.BackgroundImage")));
            this.gbTildar.BlackBorder = true;
            this.gbTildar.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbTildar.CircleButton = false;
            this.gbTildar.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.fCheck;
            this.gbTildar.FlatColor = System.Drawing.Color.DodgerBlue;
            this.gbTildar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.LightBlue;
            this.gbTildar.FlatFontSize = 9;
            this.gbTildar.FlatTextColor = System.Drawing.Color.Black;
            this.gbTildar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbTildar.Location = new System.Drawing.Point(216, 25);
            this.gbTildar.Name = "gbTildar";
            this.gbTildar.RoundCorners = 2;
            this.gbTildar.Size = new System.Drawing.Size(26, 24);
            this.gbTildar.TabIndex = 16;
            this.gbTildar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbTildar.ToolTipText = "Agregar Filtros a la busqueda";
            this.gbTildar.W8Color = System.Drawing.Color.DodgerBlue;
            this.gbTildar.Click += new System.EventHandler(this.gbTildar_Click);
            // 
            // SeleccionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 575);
            this.Controls.Add(this.xPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SeleccionClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selección Clientes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SeleccionClientes_FormClosed);
            this.xPanel1.ResumeLayout(false);
            this.mpPanelesOperativos.ResumeLayout(false);
            this.mppCambioVisibilidades.ResumeLayout(false);
            this.xPanel2.ResumeLayout(false);
            this.mppSeleccionarClientes.ResumeLayout(false);
            this.xPanel3.ResumeLayout(false);
            this.xPanel3.PerformLayout();
            this.mppCambioVendido.ResumeLayout(false);
            this.xPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TNGS.NetControls.XPanel xPanel1;
        private TNGS.NetControls.MiniReport mrClientes;
        private TNGS.NetControls.CDCombo cdcMarcas;
        private TNGS.NetControls.GlassButton gbQuitarVisibilidad;
        private TNGS.NetControls.GlassButton gbAgregarVisibilidad;
        private TNGS.NetControls.GlassButton gbAgregarFiltros;
        private TNGS.NetControls.FullLabel fllMarcas;
        private TNGS.NetControls.FullLabel flCantidad;
        private TNGS.NetControls.MultiPanel mpPanelesOperativos;
        private TNGS.NetControls.MultiPanelPage mppCambioVisibilidades;
        private TNGS.NetControls.XPanel xPanel2;
        private TNGS.NetControls.MultiPanelPage mppSeleccionarClientes;
        private TNGS.NetControls.XPanel xPanel3;
        private TNGS.NetControls.GlassButton gbConfirmarSeleccion;
        private TNGS.NetControls.GlassButton gbCancelar;
        private TNGS.NetControls.MultiPanelPage mppCambioVendido;
        private TNGS.NetControls.XPanel xPanel4;
        private TNGS.NetControls.GlassButton gbMarcarVendido;
        private TNGS.NetControls.GlassButton gbMarcarNoVendido;
        private TNGS.NetControls.NumberEdit neNumeroConjunto;
        private TNGS.NetControls.FullLabel fullLabel2;
        private TNGS.NetControls.FullLabel fullLabel1;
        private TNGS.NetControls.GlassButton gbTildar;
    }
}