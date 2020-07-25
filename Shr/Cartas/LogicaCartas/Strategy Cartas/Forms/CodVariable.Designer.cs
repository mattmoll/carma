namespace Carm.Shr
{
    partial class CodVariable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodVariable));
            this.xPanel1 = new TNGS.NetControls.XPanel();
            this.lblCodigoVar = new TNGS.NetControls.FullLabel();
            this.teReemplazo = new TNGS.NetControls.TextEdit();
            this.gbConfirm = new TNGS.NetControls.GlassButton();
            this.fullLabel1 = new TNGS.NetControls.FullLabel();
            this.xPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xPanel1
            // 
            this.xPanel1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanel1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.xPanel1.Controls.Add(this.lblCodigoVar);
            this.xPanel1.Controls.Add(this.teReemplazo);
            this.xPanel1.Controls.Add(this.gbConfirm);
            this.xPanel1.Controls.Add(this.fullLabel1);
            this.xPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xPanel1.Location = new System.Drawing.Point(0, 0);
            this.xPanel1.Name = "xPanel1";
            this.xPanel1.Size = new System.Drawing.Size(217, 144);
            this.xPanel1.SkinFixed = true;
            this.xPanel1.TabIndex = 8;
            // 
            // lblCodigoVar
            // 
            this.lblCodigoVar.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigoVar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoVar.Location = new System.Drawing.Point(12, 32);
            this.lblCodigoVar.Name = "lblCodigoVar";
            this.lblCodigoVar.Size = new System.Drawing.Size(193, 23);
            this.lblCodigoVar.TabIndex = 10;
            this.lblCodigoVar.Text = "(UnCodigo)";
            this.lblCodigoVar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // teReemplazo
            // 
            this.teReemplazo.BackColor = System.Drawing.SystemColors.Window;
            this.teReemplazo.Location = new System.Drawing.Point(12, 69);
            this.teReemplazo.Name = "teReemplazo";
            this.teReemplazo.Size = new System.Drawing.Size(193, 20);
            this.teReemplazo.TabIndex = 9;
            // 
            // gbConfirm
            // 
            this.gbConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbConfirm.BlackBorder = true;
            this.gbConfirm.CircleButton = false;
            this.gbConfirm.FixedImage = TNGS.NetControls.FixedGlassButtons.Accept;
            this.gbConfirm.FlatColor = System.Drawing.Color.RoyalBlue;
            this.gbConfirm.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.gbConfirm.FlatTextColor = System.Drawing.Color.Black;
            this.gbConfirm.Location = new System.Drawing.Point(64, 107);
            this.gbConfirm.Name = "gbConfirm";
            this.gbConfirm.RoundCorners = 2;
            this.gbConfirm.Size = new System.Drawing.Size(91, 26);
            this.gbConfirm.TabIndex = 8;
            this.gbConfirm.Text = "Confirmar";
            this.gbConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbConfirm.W8Color = System.Drawing.Color.RoyalBlue;
            this.gbConfirm.Click += new System.EventHandler(this.gbConfirm_Click);
            // 
            // fullLabel1
            // 
            this.fullLabel1.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel1.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel1.Location = new System.Drawing.Point(45, 9);
            this.fullLabel1.Name = "fullLabel1";
            this.fullLabel1.Size = new System.Drawing.Size(134, 23);
            this.fullLabel1.TabIndex = 5;
            this.fullLabel1.Text = "Reemplazar";
            this.fullLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CodVariable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 144);
            this.Controls.Add(this.xPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CodVariable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Código Variable";
            this.Load += new System.EventHandler(this.CodVariable_Load);
            this.xPanel1.ResumeLayout(false);
            this.xPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TNGS.NetControls.XPanel xPanel1;
        private TNGS.NetControls.GlassButton gbConfirm;
        private TNGS.NetControls.FullLabel fullLabel1;
        private TNGS.NetControls.TextEdit teReemplazo;
        private TNGS.NetControls.FullLabel lblCodigoVar;
    }
}