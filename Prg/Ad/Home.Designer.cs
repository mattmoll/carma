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
            this.fgKm = new TNGS.NetControls.FullGrid();
            this.fullLabel1 = new TNGS.NetControls.FullLabel();
            this.gbBusqueda = new TNGS.NetControls.GlassButton();
            this.gbDetalle = new TNGS.NetControls.GlassButton();
            this.gbLlamada = new TNGS.NetControls.GlassButton();
            this.gbVenta = new TNGS.NetControls.GlassButton();
            this.gbCargarCliente = new TNGS.NetControls.GlassButton();
            this.gbBorrarCliente = new TNGS.NetControls.GlassButton();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgKm)).BeginInit();
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
            // fgKm
            // 
            this.fgKm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fgKm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fgKm.CaptionBackColor = System.Drawing.Color.DodgerBlue;
            this.fgKm.CaptionFilterColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fgKm.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fgKm.CaptionVisible = false;
            this.fgKm.DataMember = "";
            this.fgKm.ExcelName = "Datos Exportados";
            this.fgKm.ExcelTitle = "";
            this.fgKm.GridOrder = "";
            this.fgKm.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.fgKm.Location = new System.Drawing.Point(12, 156);
            this.fgKm.Name = "fgKm";
            this.fgKm.Size = new System.Drawing.Size(1000, 529);
            this.fgKm.SkinFixed = true;
            this.fgKm.TabIndex = 61;
            // 
            // fullLabel1
            // 
            this.fullLabel1.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel1.Location = new System.Drawing.Point(9, 136);
            this.fullLabel1.Name = "fullLabel1";
            this.fullLabel1.Size = new System.Drawing.Size(140, 15);
            this.fullLabel1.TabIndex = 62;
            this.fullLabel1.Text = "Resultados Busqueda";
            this.fullLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 693);
            this.Controls.Add(this.gbBorrarCliente);
            this.Controls.Add(this.gbCargarCliente);
            this.Controls.Add(this.gbVenta);
            this.Controls.Add(this.gbLlamada);
            this.Controls.Add(this.gbDetalle);
            this.Controls.Add(this.gbBusqueda);
            this.Controls.Add(this.fgKm);
            this.Controls.Add(this.fullLabel1);
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
            ((System.ComponentModel.ISupportInitialize)(this.fgKm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl dragControl;
        private System.Windows.Forms.Button btnMinimize;
        private TNGS.NetControls.FullGrid fgKm;
        private TNGS.NetControls.FullLabel fullLabel1;
        private TNGS.NetControls.GlassButton gbBusqueda;
        private TNGS.NetControls.GlassButton gbDetalle;
        private TNGS.NetControls.GlassButton gbLlamada;
        private TNGS.NetControls.GlassButton gbVenta;
        private TNGS.NetControls.GlassButton gbCargarCliente;
        private TNGS.NetControls.GlassButton gbBorrarCliente;
    }
}