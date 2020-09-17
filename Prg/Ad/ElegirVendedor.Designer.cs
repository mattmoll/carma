namespace Carm.Ad.Forms
{
    partial class ElegirVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElegirVendedor));
            this.cmbVendedores = new TNGS.NetControls.CDCombo();
            this.bDetalle = new TNGS.NetControls.GlassButton();
            this.bAceptar = new TNGS.NetControls.GlassButton();
            this.fullLabel1 = new TNGS.NetControls.FullLabel();
            this.xPanel1 = new TNGS.NetControls.XPanel();
            this.gbCancelar = new TNGS.NetControls.GlassButton();
            this.xPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbVendedores
            // 
            this.cmbVendedores.BackColor = System.Drawing.SystemColors.Window;
            this.cmbVendedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVendedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbVendedores.FormattingEnabled = true;
            this.cmbVendedores.Location = new System.Drawing.Point(12, 38);
            this.cmbVendedores.Name = "cmbVendedores";
            this.cmbVendedores.Size = new System.Drawing.Size(186, 21);
            this.cmbVendedores.Sorted = true;
            this.cmbVendedores.TabIndex = 0;
            // 
            // bDetalle
            // 
            this.bDetalle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bDetalle.BackgroundImage")));
            this.bDetalle.BlackBorder = true;
            this.bDetalle.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.bDetalle.CircleButton = false;
            this.bDetalle.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Search;
            this.bDetalle.FlatColor = System.Drawing.Color.DodgerBlue;
            this.bDetalle.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.LightBlue;
            this.bDetalle.FlatFontSize = 9;
            this.bDetalle.FlatTextColor = System.Drawing.Color.Black;
            this.bDetalle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bDetalle.Location = new System.Drawing.Point(231, 34);
            this.bDetalle.Name = "bDetalle";
            this.bDetalle.RoundCorners = 2;
            this.bDetalle.Size = new System.Drawing.Size(104, 25);
            this.bDetalle.TabIndex = 1;
            this.bDetalle.Text = "Ver Detalle";
            this.bDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bDetalle.W8Color = System.Drawing.Color.DodgerBlue;
            this.bDetalle.Click += new System.EventHandler(this.bDetalle_Click);
            // 
            // bAceptar
            // 
            this.bAceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bAceptar.BackgroundImage")));
            this.bAceptar.BlackBorder = true;
            this.bAceptar.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.bAceptar.CircleButton = false;
            this.bAceptar.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Accept;
            this.bAceptar.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bAceptar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Aceptar;
            this.bAceptar.FlatFontSize = 9;
            this.bAceptar.FlatTextColor = System.Drawing.Color.Black;
            this.bAceptar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bAceptar.Location = new System.Drawing.Point(360, 34);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.RoundCorners = 2;
            this.bAceptar.Size = new System.Drawing.Size(88, 25);
            this.bAceptar.TabIndex = 2;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAceptar.W8Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // fullLabel1
            // 
            this.fullLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel1.Location = new System.Drawing.Point(12, 9);
            this.fullLabel1.Name = "fullLabel1";
            this.fullLabel1.Size = new System.Drawing.Size(186, 18);
            this.fullLabel1.TabIndex = 3;
            this.fullLabel1.Text = "Seleccione el vendedor";
            // 
            // xPanel1
            // 
            this.xPanel1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanel1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanel1.BorderColor = System.Drawing.Color.Black;
            this.xPanel1.Controls.Add(this.gbCancelar);
            this.xPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xPanel1.Location = new System.Drawing.Point(0, 0);
            this.xPanel1.Name = "xPanel1";
            this.xPanel1.Size = new System.Drawing.Size(476, 71);
            this.xPanel1.SkinFixed = true;
            this.xPanel1.TabIndex = 4;
            // 
            // gbCancelar
            // 
            this.gbCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbCancelar.BackgroundImage")));
            this.gbCancelar.BlackBorder = true;
            this.gbCancelar.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbCancelar.CircleButton = false;
            this.gbCancelar.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.fCancel;
            this.gbCancelar.FlatColor = System.Drawing.Color.Red;
            this.gbCancelar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Cancelar;
            this.gbCancelar.FlatFontSize = 9;
            this.gbCancelar.FlatTextColor = System.Drawing.Color.Black;
            this.gbCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbCancelar.Location = new System.Drawing.Point(447, 3);
            this.gbCancelar.Name = "gbCancelar";
            this.gbCancelar.RoundCorners = 2;
            this.gbCancelar.Size = new System.Drawing.Size(26, 24);
            this.gbCancelar.TabIndex = 9;
            this.gbCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbCancelar.W8Color = System.Drawing.Color.Red;
            this.gbCancelar.Click += new System.EventHandler(this.gbCancelar_Click);
            // 
            // ElegirVendedor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(476, 71);
            this.Controls.Add(this.fullLabel1);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.bDetalle);
            this.Controls.Add(this.cmbVendedores);
            this.Controls.Add(this.xPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ElegirVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Elegir vendedor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ElegirVendedor_FormClosing);
            this.Load += new System.EventHandler(this.ElegirVendedor_Load);
            this.xPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TNGS.NetControls.CDCombo cmbVendedores;
        private TNGS.NetControls.GlassButton bDetalle;
        private TNGS.NetControls.GlassButton bAceptar;
        private TNGS.NetControls.FullLabel fullLabel1;
        private TNGS.NetControls.XPanel xPanel1;
        private TNGS.NetControls.GlassButton gbCancelar;
    }
}