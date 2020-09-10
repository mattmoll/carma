namespace Carm.Ad
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.topPanel = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.dragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.gbBusqueda = new TNGS.NetControls.GlassButton();
            this.gbDetalle = new TNGS.NetControls.GlassButton();
            this.gbLlamada = new TNGS.NetControls.GlassButton();
            this.gbVenta = new TNGS.NetControls.GlassButton();
            this.gbCargarCliente = new TNGS.NetControls.GlassButton();
            this.gbBorrarCliente = new TNGS.NetControls.GlassButton();
            this.mrClientes = new TNGS.NetControls.MiniReport();
            this.lblCantReg = new TNGS.NetControls.FullLabel();
            this.fullLabel4 = new TNGS.NetControls.FullLabel();
            this.cmdExcel = new TNGS.NetControls.GlassButton();
            this.gbRemoverFiltros = new TNGS.NetControls.GlassButton();
            this.gbAgregarFiltros = new TNGS.NetControls.GlassButton();
            this.gbActualizar = new TNGS.NetControls.GlassButton();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.DarkGreen;
            this.topPanel.Controls.Add(this.btnMinimize);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.btnExit);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1024, 40);
            this.topPanel.TabIndex = 0;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(924, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(47, 40);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Solución Carma";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(966, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(58, 40);
            this.btnExit.TabIndex = 1;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dragControl
            // 
            this.dragControl.Fixed = true;
            this.dragControl.Horizontal = true;
            this.dragControl.TargetControl = this.topPanel;
            this.dragControl.Vertical = true;
            // 
            // gbBusqueda
            // 
            this.gbBusqueda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbBusqueda.BackgroundImage")));
            this.gbBusqueda.BlackBorder = true;
            this.gbBusqueda.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbBusqueda.CircleButton = false;
            this.gbBusqueda.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Search;
            this.gbBusqueda.FlatColor = System.Drawing.Color.Gray;
            this.gbBusqueda.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Imprimir;
            this.gbBusqueda.FlatFontSize = 9;
            this.gbBusqueda.FlatTextColor = System.Drawing.Color.Black;
            this.gbBusqueda.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbBusqueda.ImageOnTop = true;
            this.gbBusqueda.Location = new System.Drawing.Point(76, 59);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.RoundCorners = 2;
            this.gbBusqueda.Size = new System.Drawing.Size(94, 60);
            this.gbBusqueda.TabIndex = 63;
            this.gbBusqueda.Text = "Busqueda";
            this.gbBusqueda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gbBusqueda.W8Color = System.Drawing.Color.Gray;
            this.gbBusqueda.Click += new System.EventHandler(this.gbBusqueda_Click);
            // 
            // gbDetalle
            // 
            this.gbDetalle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbDetalle.BackgroundImage")));
            this.gbDetalle.BlackBorder = true;
            this.gbDetalle.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbDetalle.CircleButton = false;
            this.gbDetalle.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Info;
            this.gbDetalle.FlatColor = System.Drawing.Color.LimeGreen;
            this.gbDetalle.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Excel;
            this.gbDetalle.FlatFontSize = 9;
            this.gbDetalle.FlatTextColor = System.Drawing.Color.Black;
            this.gbDetalle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbDetalle.ImageOnTop = true;
            this.gbDetalle.Location = new System.Drawing.Point(300, 59);
            this.gbDetalle.Name = "gbDetalle";
            this.gbDetalle.RoundCorners = 2;
            this.gbDetalle.Size = new System.Drawing.Size(94, 60);
            this.gbDetalle.TabIndex = 64;
            this.gbDetalle.Text = "Detalle";
            this.gbDetalle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gbDetalle.W8Color = System.Drawing.Color.LimeGreen;
            this.gbDetalle.Click += new System.EventHandler(this.gbDetalle_Click);
            // 
            // gbLlamada
            // 
            this.gbLlamada.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbLlamada.BackgroundImage")));
            this.gbLlamada.BlackBorder = true;
            this.gbLlamada.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbLlamada.CircleButton = false;
            this.gbLlamada.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Phone;
            this.gbLlamada.FlatColor = System.Drawing.Color.LimeGreen;
            this.gbLlamada.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Excel;
            this.gbLlamada.FlatFontSize = 9;
            this.gbLlamada.FlatTextColor = System.Drawing.Color.Black;
            this.gbLlamada.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbLlamada.ImageOnTop = true;
            this.gbLlamada.Location = new System.Drawing.Point(421, 59);
            this.gbLlamada.Name = "gbLlamada";
            this.gbLlamada.RoundCorners = 2;
            this.gbLlamada.Size = new System.Drawing.Size(94, 60);
            this.gbLlamada.TabIndex = 65;
            this.gbLlamada.Text = "Llamada";
            this.gbLlamada.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gbLlamada.W8Color = System.Drawing.Color.LimeGreen;
            this.gbLlamada.Click += new System.EventHandler(this.gbLlamada_Click);
            // 
            // gbVenta
            // 
            this.gbVenta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbVenta.BackgroundImage")));
            this.gbVenta.BlackBorder = true;
            this.gbVenta.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbVenta.CircleButton = false;
            this.gbVenta.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Money;
            this.gbVenta.FlatColor = System.Drawing.Color.LimeGreen;
            this.gbVenta.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Excel;
            this.gbVenta.FlatFontSize = 9;
            this.gbVenta.FlatTextColor = System.Drawing.Color.Black;
            this.gbVenta.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbVenta.ImageOnTop = true;
            this.gbVenta.Location = new System.Drawing.Point(536, 59);
            this.gbVenta.Name = "gbVenta";
            this.gbVenta.RoundCorners = 2;
            this.gbVenta.Size = new System.Drawing.Size(94, 60);
            this.gbVenta.TabIndex = 66;
            this.gbVenta.Text = "Venta";
            this.gbVenta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gbVenta.W8Color = System.Drawing.Color.LimeGreen;
            this.gbVenta.Click += new System.EventHandler(this.gbVenta_Click);
            // 
            // gbCargarCliente
            // 
            this.gbCargarCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbCargarCliente.BackgroundImage")));
            this.gbCargarCliente.BlackBorder = true;
            this.gbCargarCliente.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbCargarCliente.CircleButton = false;
            this.gbCargarCliente.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Men;
            this.gbCargarCliente.FlatColor = System.Drawing.Color.DodgerBlue;
            this.gbCargarCliente.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.LightBlue;
            this.gbCargarCliente.FlatFontSize = 9;
            this.gbCargarCliente.FlatTextColor = System.Drawing.Color.Black;
            this.gbCargarCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbCargarCliente.ImageOnTop = true;
            this.gbCargarCliente.Location = new System.Drawing.Point(871, 59);
            this.gbCargarCliente.Name = "gbCargarCliente";
            this.gbCargarCliente.RoundCorners = 2;
            this.gbCargarCliente.Size = new System.Drawing.Size(100, 60);
            this.gbCargarCliente.TabIndex = 67;
            this.gbCargarCliente.Text = "Nuevo Cliente";
            this.gbCargarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gbCargarCliente.W8Color = System.Drawing.Color.DodgerBlue;
            this.gbCargarCliente.Click += new System.EventHandler(this.gbCargarCliente_Click);
            // 
            // gbBorrarCliente
            // 
            this.gbBorrarCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbBorrarCliente.BackgroundImage")));
            this.gbBorrarCliente.BlackBorder = true;
            this.gbBorrarCliente.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbBorrarCliente.CircleButton = false;
            this.gbBorrarCliente.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Delete;
            this.gbBorrarCliente.FlatColor = System.Drawing.Color.Red;
            this.gbBorrarCliente.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Cancelar;
            this.gbBorrarCliente.FlatFontSize = 9;
            this.gbBorrarCliente.FlatTextColor = System.Drawing.Color.Black;
            this.gbBorrarCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbBorrarCliente.ImageOnTop = true;
            this.gbBorrarCliente.Location = new System.Drawing.Point(651, 59);
            this.gbBorrarCliente.Name = "gbBorrarCliente";
            this.gbBorrarCliente.RoundCorners = 2;
            this.gbBorrarCliente.Size = new System.Drawing.Size(94, 60);
            this.gbBorrarCliente.TabIndex = 68;
            this.gbBorrarCliente.Text = "Borrar";
            this.gbBorrarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gbBorrarCliente.W8Color = System.Drawing.Color.Red;
            this.gbBorrarCliente.Click += new System.EventHandler(this.gbBorrarCliente_Click);
            // 
            // mrClientes
            // 
            this.mrClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mrClientes.BackColor = System.Drawing.Color.Transparent;
            this.mrClientes.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrClientes.Location = new System.Drawing.Point(12, 138);
            this.mrClientes.Name = "mrClientes";
            this.mrClientes.ShowExcel = false;
            this.mrClientes.ShowFilter = false;
            this.mrClientes.ShowPrtAll = false;
            this.mrClientes.ShowPrtOne = false;
            this.mrClientes.ShowZoom = false;
            this.mrClientes.Size = new System.Drawing.Size(1000, 547);
            this.mrClientes.SkinFixed = true;
            this.mrClientes.TabIndex = 69;
            this.mrClientes.TextPrtDetalle = " ";
            // 
            // lblCantReg
            // 
            this.lblCantReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantReg.BackColor = System.Drawing.Color.Transparent;
            this.lblCantReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantReg.Location = new System.Drawing.Point(175, 143);
            this.lblCantReg.Name = "lblCantReg";
            this.lblCantReg.Size = new System.Drawing.Size(102, 17);
            this.lblCantReg.TabIndex = 71;
            // 
            // fullLabel4
            // 
            this.fullLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fullLabel4.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel4.Location = new System.Drawing.Point(12, 143);
            this.fullLabel4.Name = "fullLabel4";
            this.fullLabel4.Size = new System.Drawing.Size(167, 17);
            this.fullLabel4.TabIndex = 70;
            this.fullLabel4.Text = "Cantidad de Registros:";
            // 
            // cmdExcel
            // 
            this.cmdExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdExcel.BackgroundImage")));
            this.cmdExcel.BlackBorder = true;
            this.cmdExcel.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.cmdExcel.CircleButton = false;
            this.cmdExcel.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.fExcel;
            this.cmdExcel.FlatColor = System.Drawing.Color.LimeGreen;
            this.cmdExcel.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Excel;
            this.cmdExcel.FlatFontSize = 9;
            this.cmdExcel.FlatTextColor = System.Drawing.Color.Black;
            this.cmdExcel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmdExcel.Location = new System.Drawing.Point(878, 140);
            this.cmdExcel.Name = "cmdExcel";
            this.cmdExcel.PCode = "EXCELADMIN";
            this.cmdExcel.RoundCorners = 2;
            this.cmdExcel.Size = new System.Drawing.Size(26, 24);
            this.cmdExcel.TabIndex = 72;
            this.cmdExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdExcel.W8Color = System.Drawing.Color.LimeGreen;
            this.cmdExcel.Click += new System.EventHandler(this.cmdExcel_Click);
            // 
            // gbRemoverFiltros
            // 
            this.gbRemoverFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRemoverFiltros.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbRemoverFiltros.BackgroundImage")));
            this.gbRemoverFiltros.BlackBorder = true;
            this.gbRemoverFiltros.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbRemoverFiltros.CircleButton = false;
            this.gbRemoverFiltros.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.fUnfilter;
            this.gbRemoverFiltros.FlatColor = System.Drawing.SystemColors.HotTrack;
            this.gbRemoverFiltros.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.gbRemoverFiltros.FlatFontSize = 9;
            this.gbRemoverFiltros.FlatTextColor = System.Drawing.Color.Black;
            this.gbRemoverFiltros.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbRemoverFiltros.Location = new System.Drawing.Point(981, 140);
            this.gbRemoverFiltros.Name = "gbRemoverFiltros";
            this.gbRemoverFiltros.RoundCorners = 2;
            this.gbRemoverFiltros.Size = new System.Drawing.Size(26, 24);
            this.gbRemoverFiltros.TabIndex = 75;
            this.gbRemoverFiltros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbRemoverFiltros.ToolTipText = "Remover Filtros";
            this.gbRemoverFiltros.W8Color = System.Drawing.SystemColors.HotTrack;
            this.gbRemoverFiltros.Click += new System.EventHandler(this.gbRemoverFiltros_Click);
            // 
            // gbAgregarFiltros
            // 
            this.gbAgregarFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAgregarFiltros.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbAgregarFiltros.BackgroundImage")));
            this.gbAgregarFiltros.BlackBorder = true;
            this.gbAgregarFiltros.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbAgregarFiltros.CircleButton = false;
            this.gbAgregarFiltros.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.fFilter;
            this.gbAgregarFiltros.FlatColor = System.Drawing.SystemColors.HotTrack;
            this.gbAgregarFiltros.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.gbAgregarFiltros.FlatFontSize = 9;
            this.gbAgregarFiltros.FlatTextColor = System.Drawing.Color.Black;
            this.gbAgregarFiltros.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbAgregarFiltros.Location = new System.Drawing.Point(949, 140);
            this.gbAgregarFiltros.Name = "gbAgregarFiltros";
            this.gbAgregarFiltros.RoundCorners = 2;
            this.gbAgregarFiltros.Size = new System.Drawing.Size(26, 24);
            this.gbAgregarFiltros.TabIndex = 74;
            this.gbAgregarFiltros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbAgregarFiltros.ToolTipText = "Agregar Filtros a la busqueda";
            this.gbAgregarFiltros.W8Color = System.Drawing.SystemColors.HotTrack;
            this.gbAgregarFiltros.Click += new System.EventHandler(this.gbAgregarFiltros_Click);
            // 
            // gbActualizar
            // 
            this.gbActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbActualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbActualizar.BackgroundImage")));
            this.gbActualizar.BlackBorder = true;
            this.gbActualizar.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbActualizar.CircleButton = false;
            this.gbActualizar.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.fRefresh;
            this.gbActualizar.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gbActualizar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Aceptar;
            this.gbActualizar.FlatFontSize = 9;
            this.gbActualizar.FlatTextColor = System.Drawing.Color.Black;
            this.gbActualizar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbActualizar.Location = new System.Drawing.Point(912, 140);
            this.gbActualizar.Name = "gbActualizar";
            this.gbActualizar.RoundCorners = 2;
            this.gbActualizar.Size = new System.Drawing.Size(26, 24);
            this.gbActualizar.TabIndex = 73;
            this.gbActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbActualizar.W8Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gbActualizar.Click += new System.EventHandler(this.gbActualizar_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 693);
            this.Controls.Add(this.cmdExcel);
            this.Controls.Add(this.gbRemoverFiltros);
            this.Controls.Add(this.gbAgregarFiltros);
            this.Controls.Add(this.gbActualizar);
            this.Controls.Add(this.lblCantReg);
            this.Controls.Add(this.fullLabel4);
            this.Controls.Add(this.mrClientes);
            this.Controls.Add(this.gbBorrarCliente);
            this.Controls.Add(this.gbCargarCliente);
            this.Controls.Add(this.gbVenta);
            this.Controls.Add(this.gbLlamada);
            this.Controls.Add(this.gbDetalle);
            this.Controls.Add(this.gbBusqueda);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Activated += new System.EventHandler(this.Home_Activated);
            this.Load += new System.EventHandler(this.Home_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl dragControl;
        private System.Windows.Forms.Button btnMinimize;
        private TNGS.NetControls.GlassButton gbBusqueda;
        private TNGS.NetControls.GlassButton gbDetalle;
        private TNGS.NetControls.GlassButton gbLlamada;
        private TNGS.NetControls.GlassButton gbVenta;
        private TNGS.NetControls.GlassButton gbCargarCliente;
        private TNGS.NetControls.GlassButton gbBorrarCliente;
        private TNGS.NetControls.MiniReport mrClientes;
        private TNGS.NetControls.FullLabel lblCantReg;
        private TNGS.NetControls.FullLabel fullLabel4;
        private TNGS.NetControls.GlassButton cmdExcel;
        private TNGS.NetControls.GlassButton gbRemoverFiltros;
        private TNGS.NetControls.GlassButton gbAgregarFiltros;
        private TNGS.NetControls.GlassButton gbActualizar;
    }
}