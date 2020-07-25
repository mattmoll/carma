namespace Sima.Ct
{
    partial class Cartas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cartas));
            this.xPanel1 = new TNGS.NetControls.XPanel();
            this.cdcTipoCartas = new TNGS.NetControls.CDCombo();
            this.gbNuevoMasivo = new TNGS.NetControls.GlassButton();
            this.lstCartas = new TNGS.NetControls.CDList();
            this.gbBorrar = new TNGS.NetControls.GlassButton();
            this.gbModificar = new TNGS.NetControls.GlassButton();
            this.fullLabel1 = new TNGS.NetControls.FullLabel();
            this.gbNuevo = new TNGS.NetControls.GlassButton();
            this.lblDescription = new System.Windows.Forms.Label();
            this.xPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xPanel1
            // 
            this.xPanel1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanel1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanel1.Controls.Add(this.lblDescription);
            this.xPanel1.Controls.Add(this.cdcTipoCartas);
            this.xPanel1.Controls.Add(this.gbNuevoMasivo);
            this.xPanel1.Controls.Add(this.lstCartas);
            this.xPanel1.Controls.Add(this.gbBorrar);
            this.xPanel1.Controls.Add(this.gbModificar);
            this.xPanel1.Controls.Add(this.fullLabel1);
            this.xPanel1.Controls.Add(this.gbNuevo);
            this.xPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xPanel1.Location = new System.Drawing.Point(0, 0);
            this.xPanel1.Name = "xPanel1";
            this.xPanel1.Size = new System.Drawing.Size(229, 641);
            this.xPanel1.SkinFixed = true;
            this.xPanel1.TabIndex = 6;
            // 
            // cdcTipoCartas
            // 
            this.cdcTipoCartas.BackColor = System.Drawing.SystemColors.Window;
            this.cdcTipoCartas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdcTipoCartas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cdcTipoCartas.FormattingEnabled = true;
            this.cdcTipoCartas.Location = new System.Drawing.Point(12, 12);
            this.cdcTipoCartas.Name = "cdcTipoCartas";
            this.cdcTipoCartas.Size = new System.Drawing.Size(209, 21);
            this.cdcTipoCartas.Sorted = true;
            this.cdcTipoCartas.TabIndex = 6;
            this.cdcTipoCartas.SelectedIndexChanged += new System.EventHandler(this.cdcTipoCartas_SelectedIndexChanged);
            // 
            // gbNuevoMasivo
            // 
            this.gbNuevoMasivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbNuevoMasivo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbNuevoMasivo.BackgroundImage")));
            this.gbNuevoMasivo.BlackBorder = true;
            this.gbNuevoMasivo.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbNuevoMasivo.CircleButton = false;
            this.gbNuevoMasivo.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.New;
            this.gbNuevoMasivo.FlatColor = System.Drawing.Color.DodgerBlue;
            this.gbNuevoMasivo.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.LightBlue;
            this.gbNuevoMasivo.FlatFontSize = 9;
            this.gbNuevoMasivo.FlatTextColor = System.Drawing.Color.Black;
            this.gbNuevoMasivo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbNuevoMasivo.ImageOnTop = true;
            this.gbNuevoMasivo.Location = new System.Drawing.Point(118, 553);
            this.gbNuevoMasivo.Name = "gbNuevoMasivo";
            this.gbNuevoMasivo.RoundCorners = 2;
            this.gbNuevoMasivo.Size = new System.Drawing.Size(92, 75);
            this.gbNuevoMasivo.TabIndex = 2;
            this.gbNuevoMasivo.Text = "Nuevo Masivo";
            this.gbNuevoMasivo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gbNuevoMasivo.W8Color = System.Drawing.Color.DodgerBlue;
            this.gbNuevoMasivo.Click += new System.EventHandler(this.gbNuevoMasivo_Click);
            // 
            // lstCartas
            // 
            this.lstCartas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstCartas.FormattingEnabled = true;
            this.lstCartas.Location = new System.Drawing.Point(12, 84);
            this.lstCartas.Name = "lstCartas";
            this.lstCartas.Size = new System.Drawing.Size(209, 342);
            this.lstCartas.Sorted = true;
            this.lstCartas.TabIndex = 0;
            this.lstCartas.SelectedIndexChanged += new System.EventHandler(this.lstCartas_SelectedIndexChanged);
            // 
            // gbBorrar
            // 
            this.gbBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbBorrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbBorrar.BackgroundImage")));
            this.gbBorrar.BlackBorder = true;
            this.gbBorrar.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbBorrar.CircleButton = false;
            this.gbBorrar.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Delete;
            this.gbBorrar.FlatColor = System.Drawing.Color.Red;
            this.gbBorrar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Cancelar;
            this.gbBorrar.FlatFontSize = 9;
            this.gbBorrar.FlatTextColor = System.Drawing.Color.Black;
            this.gbBorrar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbBorrar.Location = new System.Drawing.Point(22, 483);
            this.gbBorrar.Name = "gbBorrar";
            this.gbBorrar.RoundCorners = 2;
            this.gbBorrar.Size = new System.Drawing.Size(90, 25);
            this.gbBorrar.TabIndex = 4;
            this.gbBorrar.Text = "Borrar";
            this.gbBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbBorrar.W8Color = System.Drawing.Color.Red;
            this.gbBorrar.Click += new System.EventHandler(this.gbBorrar_Click);
            // 
            // gbModificar
            // 
            this.gbModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbModificar.BackgroundImage")));
            this.gbModificar.BlackBorder = true;
            this.gbModificar.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbModificar.CircleButton = false;
            this.gbModificar.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Edit;
            this.gbModificar.FlatColor = System.Drawing.Color.DodgerBlue;
            this.gbModificar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.LightBlue;
            this.gbModificar.FlatFontSize = 9;
            this.gbModificar.FlatTextColor = System.Drawing.Color.Black;
            this.gbModificar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbModificar.Location = new System.Drawing.Point(118, 483);
            this.gbModificar.Name = "gbModificar";
            this.gbModificar.RoundCorners = 2;
            this.gbModificar.Size = new System.Drawing.Size(92, 25);
            this.gbModificar.TabIndex = 3;
            this.gbModificar.Text = "Modificar";
            this.gbModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbModificar.W8Color = System.Drawing.Color.DodgerBlue;
            this.gbModificar.Click += new System.EventHandler(this.gbModificar_Click);
            // 
            // fullLabel1
            // 
            this.fullLabel1.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel1.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel1.Location = new System.Drawing.Point(51, 58);
            this.fullLabel1.Name = "fullLabel1";
            this.fullLabel1.Size = new System.Drawing.Size(134, 23);
            this.fullLabel1.TabIndex = 5;
            this.fullLabel1.Text = "Disponibles";
            this.fullLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbNuevo
            // 
            this.gbNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbNuevo.BackgroundImage")));
            this.gbNuevo.BlackBorder = true;
            this.gbNuevo.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbNuevo.CircleButton = false;
            this.gbNuevo.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.New;
            this.gbNuevo.FlatColor = System.Drawing.Color.DodgerBlue;
            this.gbNuevo.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.LightBlue;
            this.gbNuevo.FlatFontSize = 9;
            this.gbNuevo.FlatTextColor = System.Drawing.Color.Black;
            this.gbNuevo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbNuevo.ImageOnTop = true;
            this.gbNuevo.Location = new System.Drawing.Point(22, 553);
            this.gbNuevo.Name = "gbNuevo";
            this.gbNuevo.RoundCorners = 2;
            this.gbNuevo.Size = new System.Drawing.Size(90, 75);
            this.gbNuevo.TabIndex = 1;
            this.gbNuevo.Text = "Nuevo Unitario";
            this.gbNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gbNuevo.W8Color = System.Drawing.Color.DodgerBlue;
            this.gbNuevo.Click += new System.EventHandler(this.gbNuevoUnitario_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDescription.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(12, 429);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(209, 51);
            this.lblDescription.TabIndex = 7;
            // 
            // Cartas
            // 
            this.AllowEndUserDocking = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 641);
            this.Controls.Add(this.xPanel1);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cartas";
            this.TabText = "Cartas";
            this.Text = "Cartas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cartas_FormClosed);
            this.Load += new System.EventHandler(this.Cartas_Load);
            this.xPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TNGS.NetControls.XPanel xPanel1;
        private TNGS.NetControls.FullLabel fullLabel1;
        private TNGS.NetControls.GlassButton gbNuevo;
        private TNGS.NetControls.CDList lstCartas;
        private TNGS.NetControls.GlassButton gbBorrar;
        private TNGS.NetControls.GlassButton gbModificar;
        private TNGS.NetControls.GlassButton gbNuevoMasivo;
        private TNGS.NetControls.CDCombo cdcTipoCartas;
        private System.Windows.Forms.Label lblDescription;
    }
}