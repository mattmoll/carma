namespace Carm.Rp
{
    partial class LlamadasProgramadas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LlamadasProgramadas));
            this.xPanel1 = new TNGS.NetControls.XPanel();
            this.gbBuscarLlamadas = new TNGS.NetControls.GlassButton();
            this.xpPanelBase.SuspendLayout();
            this.xPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xpPanelBase
            // 
            this.xpPanelBase.Size = new System.Drawing.Size(256, 496);
            this.xpPanelBase.Controls.SetChildIndex(this.gbBuscar, 0);
            this.xpPanelBase.Controls.SetChildIndex(this.cbAbrirDockeableNuevo, 0);
            // 
            // gbBuscar
            // 
            this.gbBuscar.Location = new System.Drawing.Point(87, 442);
            // 
            // cbAbrirDockeableNuevo
            // 
            this.cbAbrirDockeableNuevo.Location = new System.Drawing.Point(61, 419);
            // 
            // xPanel1
            // 
            this.xPanel1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanel1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.xPanel1.Controls.Add(this.gbBuscarLlamadas);
            this.xPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xPanel1.Location = new System.Drawing.Point(0, 0);
            this.xPanel1.Name = "xPanel1";
            this.xPanel1.Size = new System.Drawing.Size(256, 496);
            this.xPanel1.SkinFixed = true;
            this.xPanel1.TabIndex = 6;
            // 
            // gbBuscarLlamadas
            // 
            this.gbBuscarLlamadas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbBuscarLlamadas.BlackBorder = true;
            this.gbBuscarLlamadas.CircleButton = false;
            this.gbBuscarLlamadas.FixedImage = TNGS.NetControls.FixedGlassButtons.Find;
            this.gbBuscarLlamadas.FlatColor = System.Drawing.Color.RoyalBlue;
            this.gbBuscarLlamadas.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.gbBuscarLlamadas.FlatTextColor = System.Drawing.Color.Black;
            this.gbBuscarLlamadas.Location = new System.Drawing.Point(65, 450);
            this.gbBuscarLlamadas.Name = "gbBuscarLlamadas";
            this.gbBuscarLlamadas.RoundCorners = 2;
            this.gbBuscarLlamadas.Size = new System.Drawing.Size(104, 26);
            this.gbBuscarLlamadas.TabIndex = 4;
            this.gbBuscarLlamadas.Text = "Buscar";
            this.gbBuscarLlamadas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbBuscarLlamadas.W8Color = System.Drawing.Color.RoyalBlue;
            // 
            // LlamadasProgramadas
            // 
            this.AllowEndUserDocking = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 496);
            this.Controls.Add(this.xPanel1);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LlamadasProgramadas";
            this.TabText = "Llamadas Programadas";
            this.Text = "Llamadas Programadas";
            this.Controls.SetChildIndex(this.xPanel1, 0);
            this.Controls.SetChildIndex(this.xpPanelBase, 0);
            this.xpPanelBase.ResumeLayout(false);
            this.xpPanelBase.PerformLayout();
            this.xPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TNGS.NetControls.XPanel xPanel1;
        private TNGS.NetControls.GlassButton gbBuscarLlamadas;
    }
}