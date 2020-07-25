namespace Carm.Shr
{
    partial class ElegirMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElegirMarca));
            this.xPanel1 = new TNGS.NetControls.XPanel();
            this.gbAceptar = new TNGS.NetControls.GlassButton();
            this.cdcMarcas = new TNGS.NetControls.CDCombo();
            this.fullLabel16 = new TNGS.NetControls.FullLabel();
            this.xPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xPanel1
            // 
            this.xPanel1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanel1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.xPanel1.BorderColor = System.Drawing.Color.Black;
            this.xPanel1.Controls.Add(this.fullLabel16);
            this.xPanel1.Controls.Add(this.gbAceptar);
            this.xPanel1.Controls.Add(this.cdcMarcas);
            this.xPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xPanel1.Location = new System.Drawing.Point(0, 0);
            this.xPanel1.Name = "xPanel1";
            this.xPanel1.Size = new System.Drawing.Size(335, 104);
            this.xPanel1.SkinFixed = true;
            this.xPanel1.TabIndex = 1;
            // 
            // gbAceptar
            // 
            this.gbAceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbAceptar.BackgroundImage")));
            this.gbAceptar.BlackBorder = true;
            this.gbAceptar.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbAceptar.CircleButton = false;
            this.gbAceptar.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Accept;
            this.gbAceptar.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gbAceptar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Aceptar;
            this.gbAceptar.FlatFontSize = 9;
            this.gbAceptar.FlatTextColor = System.Drawing.Color.Black;
            this.gbAceptar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbAceptar.Location = new System.Drawing.Point(223, 58);
            this.gbAceptar.Name = "gbAceptar";
            this.gbAceptar.RoundCorners = 2;
            this.gbAceptar.Size = new System.Drawing.Size(83, 25);
            this.gbAceptar.TabIndex = 1;
            this.gbAceptar.Text = "Aceptar";
            this.gbAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbAceptar.W8Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gbAceptar.Click += new System.EventHandler(this.gbAceptar_Click);
            // 
            // cdcMarcas
            // 
            this.cdcMarcas.BackColor = System.Drawing.SystemColors.Window;
            this.cdcMarcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdcMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cdcMarcas.FormattingEnabled = true;
            this.cdcMarcas.Location = new System.Drawing.Point(19, 62);
            this.cdcMarcas.Name = "cdcMarcas";
            this.cdcMarcas.Size = new System.Drawing.Size(181, 21);
            this.cdcMarcas.Sorted = true;
            this.cdcMarcas.TabIndex = 0;
            // 
            // fullLabel16
            // 
            this.fullLabel16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fullLabel16.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel16.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel16.Location = new System.Drawing.Point(40, 9);
            this.fullLabel16.Name = "fullLabel16";
            this.fullLabel16.Size = new System.Drawing.Size(254, 23);
            this.fullLabel16.TabIndex = 10;
            this.fullLabel16.Text = "Seleccionar Marca";
            this.fullLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ElegirMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 104);
            this.Controls.Add(this.xPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ElegirMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Selección de Marca";
            this.xPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TNGS.NetControls.XPanel xPanel1;
        private TNGS.NetControls.GlassButton gbAceptar;
        private TNGS.NetControls.CDCombo cdcMarcas;
        private TNGS.NetControls.FullLabel fullLabel16;
    }
}