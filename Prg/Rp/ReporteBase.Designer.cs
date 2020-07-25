namespace Sima.Rp
{
    partial class ReporteBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteBase));
            this.xpPanelReporteBase = new TNGS.NetControls.XPanel();
            this.gbBuscar = new TNGS.NetControls.GlassButton();
            this.xpPanelReporteBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // xpPanelReporteBase
            // 
            this.xpPanelReporteBase.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xpPanelReporteBase.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.xpPanelReporteBase.Controls.Add(this.gbBuscar);
            this.xpPanelReporteBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xpPanelReporteBase.Location = new System.Drawing.Point(0, 0);
            this.xpPanelReporteBase.Name = "xpPanelReporteBase";
            this.xpPanelReporteBase.Size = new System.Drawing.Size(256, 496);
            this.xpPanelReporteBase.SkinFixed = true;
            this.xpPanelReporteBase.TabIndex = 0;
            // 
            // gbBuscar
            // 
            this.gbBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbBuscar.BlackBorder = true;
            this.gbBuscar.CircleButton = false;
            this.gbBuscar.FixedImage = TNGS.NetControls.FixedGlassButtons.Find;
            this.gbBuscar.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(151)))), ((int)(((byte)(23)))));
            this.gbBuscar.FlatTextColor = System.Drawing.Color.Black;
            this.gbBuscar.Location = new System.Drawing.Point(67, 450);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.Size = new System.Drawing.Size(104, 26);
            this.gbBuscar.TabIndex = 5;
            this.gbBuscar.Text = "Buscar";
            this.gbBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbBuscar.Click += new System.EventHandler(this.gbBuscar_Click);
            // 
            // ReporteBase
            // 
            this.AllowEndUserDocking = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 496);
            this.Controls.Add(this.xpPanelReporteBase);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReporteBase";
            this.Text = "Reporte";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReporteBase_FormClosed);
            this.Load += new System.EventHandler(this.ReporteBase_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Every_KeyPress);
            this.xpPanelReporteBase.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public TNGS.NetControls.XPanel xpPanelReporteBase;
        public TNGS.NetControls.GlassButton gbBuscar;
    }
}