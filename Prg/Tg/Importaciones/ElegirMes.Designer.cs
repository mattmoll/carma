namespace Carm.Tg
{
    partial class ElegirMes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElegirMes));
            this.xPanel1 = new TNGS.NetControls.XPanel();
            this.neAño = new TNGS.NetControls.NumberEdit();
            this.fullLabel1 = new TNGS.NetControls.FullLabel();
            this.gbAceptar = new TNGS.NetControls.GlassButton();
            this.cdcMeses = new TNGS.NetControls.CDCombo();
            this.xPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xPanel1
            // 
            this.xPanel1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanel1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.xPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xPanel1.Controls.Add(this.neAño);
            this.xPanel1.Controls.Add(this.fullLabel1);
            this.xPanel1.Controls.Add(this.gbAceptar);
            this.xPanel1.Controls.Add(this.cdcMeses);
            this.xPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xPanel1.Location = new System.Drawing.Point(0, 0);
            this.xPanel1.Name = "xPanel1";
            this.xPanel1.Size = new System.Drawing.Size(371, 62);
            this.xPanel1.SkinFixed = true;
            this.xPanel1.TabIndex = 0;
            // 
            // neAño
            // 
            this.neAño.BackColor = System.Drawing.SystemColors.Window;
            this.neAño.Location = new System.Drawing.Point(215, 21);
            this.neAño.Name = "neAño";
            this.neAño.Size = new System.Drawing.Size(36, 20);
            this.neAño.TabIndex = 3;
            this.neAño.Text = "0";
            // 
            // fullLabel1
            // 
            this.fullLabel1.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel1.Location = new System.Drawing.Point(201, 23);
            this.fullLabel1.Name = "fullLabel1";
            this.fullLabel1.Size = new System.Drawing.Size(17, 23);
            this.fullLabel1.TabIndex = 2;
            this.fullLabel1.Text = "/";
            // 
            // gbAceptar
            // 
            this.gbAceptar.FixedImage = TNGS.NetControls.FixedGlassButtons.Accept;
            this.gbAceptar.Location = new System.Drawing.Point(279, 20);
            this.gbAceptar.Name = "gbAceptar";
            this.gbAceptar.Size = new System.Drawing.Size(83, 26);
            this.gbAceptar.TabIndex = 1;
            this.gbAceptar.Text = "Aceptar";
            this.gbAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbAceptar.Click += new System.EventHandler(this.gbAceptar_Click);
            // 
            // cdcMeses
            // 
            this.cdcMeses.BackColor = System.Drawing.SystemColors.Window;
            this.cdcMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdcMeses.FormattingEnabled = true;
            this.cdcMeses.Location = new System.Drawing.Point(16, 20);
            this.cdcMeses.Name = "cdcMeses";
            this.cdcMeses.Size = new System.Drawing.Size(181, 21);
            this.cdcMeses.Sorted = true;
            this.cdcMeses.TabIndex = 0;
            // 
            // ElegirMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 62);
            this.Controls.Add(this.xPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ElegirMes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mes a Importar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ElegirMes_FormClosing);
            this.xPanel1.ResumeLayout(false);
            this.xPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TNGS.NetControls.XPanel xPanel1;
        private TNGS.NetControls.NumberEdit neAño;
        private TNGS.NetControls.FullLabel fullLabel1;
        private TNGS.NetControls.GlassButton gbAceptar;
        private TNGS.NetControls.CDCombo cdcMeses;
    }
}