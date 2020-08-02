namespace Carm.Rp
{
    partial class CliCargadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CliCargadores));
            this.xPanel1 = new TNGS.NetControls.XPanel();
            this.xpPanelBase.SuspendLayout();
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
            this.xPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xPanel1.Location = new System.Drawing.Point(0, 0);
            this.xPanel1.Name = "xPanel1";
            this.xPanel1.Size = new System.Drawing.Size(256, 496);
            this.xPanel1.SkinFixed = true;
            this.xPanel1.TabIndex = 5;
            // 
            // CliCargadores
            // 
            this.AllowEndUserDocking = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 496);
            this.Controls.Add(this.xPanel1);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CliCargadores";
            this.TabText = "Cargadores";
            this.Text = "Cargadores";
            this.Controls.SetChildIndex(this.xPanel1, 0);
            this.Controls.SetChildIndex(this.xpPanelBase, 0);
            this.xpPanelBase.ResumeLayout(false);
            this.xpPanelBase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TNGS.NetControls.XPanel xPanel1;
    }
}