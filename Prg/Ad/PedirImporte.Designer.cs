namespace Carm.Ad
{
    partial class PedirImporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedirImporte));
            this.xPanel1 = new TNGS.NetControls.XPanel();
            this.gbCancelar = new TNGS.NetControls.GlassButton();
            this.gbAceptar = new TNGS.NetControls.GlassButton();
            this.dceAbono = new TNGS.NetControls.DecimalEdit();
            this.fullLabel1 = new TNGS.NetControls.FullLabel();
            this.xPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xPanel1
            // 
            this.xPanel1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanel1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.xPanel1.BorderColor = System.Drawing.Color.Black;
            this.xPanel1.Controls.Add(this.gbCancelar);
            this.xPanel1.Controls.Add(this.gbAceptar);
            this.xPanel1.Controls.Add(this.dceAbono);
            this.xPanel1.Controls.Add(this.fullLabel1);
            this.xPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xPanel1.Location = new System.Drawing.Point(0, 0);
            this.xPanel1.Name = "xPanel1";
            this.xPanel1.Size = new System.Drawing.Size(258, 132);
            this.xPanel1.SkinFixed = true;
            this.xPanel1.TabIndex = 0;
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
            this.gbCancelar.Location = new System.Drawing.Point(58, 84);
            this.gbCancelar.Name = "gbCancelar";
            this.gbCancelar.RoundCorners = 2;
            this.gbCancelar.Size = new System.Drawing.Size(26, 24);
            this.gbCancelar.TabIndex = 8;
            this.gbCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbCancelar.W8Color = System.Drawing.Color.Red;
            this.gbCancelar.Click += new System.EventHandler(this.gbCancelar_Click);
            // 
            // gbAceptar
            // 
            this.gbAceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbAceptar.BackgroundImage")));
            this.gbAceptar.BlackBorder = true;
            this.gbAceptar.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbAceptar.CircleButton = false;
            this.gbAceptar.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.fAccept;
            this.gbAceptar.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gbAceptar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Aceptar;
            this.gbAceptar.FlatFontSize = 9;
            this.gbAceptar.FlatTextColor = System.Drawing.Color.Black;
            this.gbAceptar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbAceptar.Location = new System.Drawing.Point(185, 84);
            this.gbAceptar.Name = "gbAceptar";
            this.gbAceptar.RoundCorners = 2;
            this.gbAceptar.Size = new System.Drawing.Size(26, 24);
            this.gbAceptar.TabIndex = 7;
            this.gbAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbAceptar.W8Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gbAceptar.Click += new System.EventHandler(this.gbAceptar_Click);
            // 
            // dceAbono
            // 
            this.dceAbono.BackColor = System.Drawing.SystemColors.Window;
            this.dceAbono.Location = new System.Drawing.Point(96, 29);
            this.dceAbono.MaxLength = 13;
            this.dceAbono.Name = "dceAbono";
            this.dceAbono.Size = new System.Drawing.Size(100, 20);
            this.dceAbono.TabIndex = 0;
            this.dceAbono.Text = "0.00";
            // 
            // fullLabel1
            // 
            this.fullLabel1.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel1.Location = new System.Drawing.Point(44, 27);
            this.fullLabel1.Name = "fullLabel1";
            this.fullLabel1.Size = new System.Drawing.Size(58, 23);
            this.fullLabel1.TabIndex = 1;
            this.fullLabel1.Text = "Abono:";
            this.fullLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PedirImporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(258, 132);
            this.Controls.Add(this.xPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PedirImporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nuevo Abono";
            this.xPanel1.ResumeLayout(false);
            this.xPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TNGS.NetControls.XPanel xPanel1;
        private TNGS.NetControls.DecimalEdit dceAbono;
        private TNGS.NetControls.FullLabel fullLabel1;
        private TNGS.NetControls.GlassButton gbCancelar;
        private TNGS.NetControls.GlassButton gbAceptar;
    }
}