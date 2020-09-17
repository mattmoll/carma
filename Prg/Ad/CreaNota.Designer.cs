namespace Carm.Ad.Forms
{
    partial class CreaNota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreaNota));
            this.xPanel1 = new TNGS.NetControls.XPanel();
            this.gbCancelar = new TNGS.NetControls.GlassButton();
            this.gbAceptar = new TNGS.NetControls.GlassButton();
            this.teTexto = new TNGS.NetControls.TextEdit();
            this.fullLabel2 = new TNGS.NetControls.FullLabel();
            this.teTitulo = new TNGS.NetControls.TextEdit();
            this.fullLabel1 = new TNGS.NetControls.FullLabel();
            this.gbHelp = new TNGS.NetControls.GlassButton();
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
            this.xPanel1.Controls.Add(this.teTexto);
            this.xPanel1.Controls.Add(this.fullLabel2);
            this.xPanel1.Controls.Add(this.teTitulo);
            this.xPanel1.Controls.Add(this.fullLabel1);
            this.xPanel1.Controls.Add(this.gbHelp);
            this.xPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xPanel1.Location = new System.Drawing.Point(0, 0);
            this.xPanel1.Name = "xPanel1";
            this.xPanel1.Size = new System.Drawing.Size(267, 268);
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
            this.gbCancelar.Location = new System.Drawing.Point(34, 238);
            this.gbCancelar.Name = "gbCancelar";
            this.gbCancelar.RoundCorners = 2;
            this.gbCancelar.Size = new System.Drawing.Size(26, 24);
            this.gbCancelar.TabIndex = 3;
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
            this.gbAceptar.Location = new System.Drawing.Point(213, 238);
            this.gbAceptar.Name = "gbAceptar";
            this.gbAceptar.RoundCorners = 2;
            this.gbAceptar.Size = new System.Drawing.Size(26, 25);
            this.gbAceptar.TabIndex = 2;
            this.gbAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbAceptar.W8Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gbAceptar.Click += new System.EventHandler(this.gbAceptar_Click);
            // 
            // teTexto
            // 
            this.teTexto.BackColor = System.Drawing.SystemColors.Window;
            this.teTexto.Location = new System.Drawing.Point(34, 111);
            this.teTexto.Multiline = true;
            this.teTexto.Name = "teTexto";
            this.teTexto.Size = new System.Drawing.Size(205, 115);
            this.teTexto.TabIndex = 1;
            // 
            // fullLabel2
            // 
            this.fullLabel2.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel2.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel2.Location = new System.Drawing.Point(50, 82);
            this.fullLabel2.Name = "fullLabel2";
            this.fullLabel2.Size = new System.Drawing.Size(174, 23);
            this.fullLabel2.TabIndex = 3;
            this.fullLabel2.Text = "Texto";
            this.fullLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // teTitulo
            // 
            this.teTitulo.BackColor = System.Drawing.SystemColors.Window;
            this.teTitulo.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teTitulo.Location = new System.Drawing.Point(34, 46);
            this.teTitulo.Name = "teTitulo";
            this.teTitulo.Size = new System.Drawing.Size(205, 27);
            this.teTitulo.TabIndex = 0;
            this.teTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fullLabel1
            // 
            this.fullLabel1.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel1.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel1.Location = new System.Drawing.Point(49, 19);
            this.fullLabel1.Name = "fullLabel1";
            this.fullLabel1.Size = new System.Drawing.Size(179, 23);
            this.fullLabel1.TabIndex = 1;
            this.fullLabel1.Text = "Título";
            this.fullLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbHelp
            // 
            this.gbHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbHelp.BackgroundImage")));
            this.gbHelp.BlackBorder = true;
            this.gbHelp.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbHelp.CircleButton = false;
            this.gbHelp.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.fInfo;
            this.gbHelp.FlatColor = System.Drawing.Color.RoyalBlue;
            this.gbHelp.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Default;
            this.gbHelp.FlatFontSize = 9;
            this.gbHelp.FlatTextColor = System.Drawing.Color.Black;
            this.gbHelp.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbHelp.Location = new System.Drawing.Point(3, 3);
            this.gbHelp.Name = "gbHelp";
            this.gbHelp.RoundCorners = 2;
            this.gbHelp.Size = new System.Drawing.Size(26, 24);
            this.gbHelp.TabIndex = 0;
            this.gbHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbHelp.W8Color = System.Drawing.Color.RoyalBlue;
            this.gbHelp.Click += new System.EventHandler(this.gbHelp_Click);
            // 
            // CreaNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(267, 268);
            this.Controls.Add(this.xPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreaNota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nota";
            this.xPanel1.ResumeLayout(false);
            this.xPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TNGS.NetControls.XPanel xPanel1;
        private TNGS.NetControls.GlassButton gbHelp;
        private TNGS.NetControls.GlassButton gbCancelar;
        private TNGS.NetControls.GlassButton gbAceptar;
        private TNGS.NetControls.TextEdit teTexto;
        private TNGS.NetControls.FullLabel fullLabel2;
        private TNGS.NetControls.TextEdit teTitulo;
        private TNGS.NetControls.FullLabel fullLabel1;
    }
}