namespace Carm.Shr
{
    partial class ListaServicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaServicios));
            this.xPanel1 = new TNGS.NetControls.XPanel();
            this.gbConfirm = new TNGS.NetControls.GlassButton();
            this.fullLabel1 = new TNGS.NetControls.FullLabel();
            this.cdlLista = new TNGS.NetControls.CDCheckedList();
            this.xPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xPanel1
            // 
            this.xPanel1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanel1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.xPanel1.Controls.Add(this.cdlLista);
            this.xPanel1.Controls.Add(this.gbConfirm);
            this.xPanel1.Controls.Add(this.fullLabel1);
            this.xPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xPanel1.Location = new System.Drawing.Point(0, 0);
            this.xPanel1.Name = "xPanel1";
            this.xPanel1.Size = new System.Drawing.Size(254, 372);
            this.xPanel1.SkinFixed = true;
            this.xPanel1.TabIndex = 9;
            // 
            // gbConfirm
            // 
            this.gbConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbConfirm.FixedImage = TNGS.NetControls.FixedGlassButtons.Accept;
            this.gbConfirm.Location = new System.Drawing.Point(77, 334);
            this.gbConfirm.Name = "gbConfirm";
            this.gbConfirm.Size = new System.Drawing.Size(91, 26);
            this.gbConfirm.TabIndex = 8;
            this.gbConfirm.Text = "Confirmar";
            this.gbConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbConfirm.Click += new System.EventHandler(this.gbConfirm_Click);
            // 
            // fullLabel1
            // 
            this.fullLabel1.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel1.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel1.Location = new System.Drawing.Point(16, 11);
            this.fullLabel1.Name = "fullLabel1";
            this.fullLabel1.Size = new System.Drawing.Size(217, 23);
            this.fullLabel1.TabIndex = 5;
            this.fullLabel1.Text = "Servicios Disponibles:";
            this.fullLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cdlLista
            // 
            this.cdlLista.FormattingEnabled = true;
            this.cdlLista.Location = new System.Drawing.Point(12, 58);
            this.cdlLista.Name = "cdlLista";
            this.cdlLista.Size = new System.Drawing.Size(227, 259);
            this.cdlLista.Sorted = true;
            this.cdlLista.TabIndex = 9;
            // 
            // ListaServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 372);
            this.Controls.Add(this.xPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListaServicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Elegir Servicios";
            this.Load += new System.EventHandler(this.ListaServicios_Load);
            this.xPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TNGS.NetControls.XPanel xPanel1;
        private TNGS.NetControls.FullLabel fullLabel1;
        private TNGS.NetControls.GlassButton gbConfirm;
        private TNGS.NetControls.CDCheckedList cdlLista;
    }
}