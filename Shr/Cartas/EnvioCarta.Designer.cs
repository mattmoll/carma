namespace Carm.Shr
{
    partial class EnvioCarta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnvioCarta));
            this.xPanel1 = new TNGS.NetControls.XPanel();
            this.imgGroup1 = new TNGS.NetControls.ImgGroup();
            this.rbCartasInt = new System.Windows.Forms.RadioButton();
            this.rbPresupuestos = new System.Windows.Forms.RadioButton();
            this.rbCartasPres = new System.Windows.Forms.RadioButton();
            this.rbMailing = new System.Windows.Forms.RadioButton();
            this.lstCartas = new TNGS.NetControls.CDList();
            this.fullLabel1 = new TNGS.NetControls.FullLabel();
            this.gbConfirmar = new TNGS.NetControls.GlassButton();
            this.xPanel1.SuspendLayout();
            this.imgGroup1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xPanel1
            // 
            this.xPanel1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanel1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.xPanel1.BorderColor = System.Drawing.Color.Black;
            this.xPanel1.Controls.Add(this.imgGroup1);
            this.xPanel1.Controls.Add(this.lstCartas);
            this.xPanel1.Controls.Add(this.fullLabel1);
            this.xPanel1.Controls.Add(this.gbConfirmar);
            this.xPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xPanel1.Location = new System.Drawing.Point(0, 0);
            this.xPanel1.Name = "xPanel1";
            this.xPanel1.Size = new System.Drawing.Size(563, 449);
            this.xPanel1.SkinFixed = true;
            this.xPanel1.TabIndex = 7;
            // 
            // imgGroup1
            // 
            this.imgGroup1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.imgGroup1.BackgroundGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.imgGroup1.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.ForwardDiagonal;
            this.imgGroup1.BlackBorder = true;
            this.imgGroup1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.imgGroup1.BorderThickness = 1F;
            this.imgGroup1.Controls.Add(this.rbCartasInt);
            this.imgGroup1.Controls.Add(this.rbPresupuestos);
            this.imgGroup1.Controls.Add(this.rbCartasPres);
            this.imgGroup1.Controls.Add(this.rbMailing);
            this.imgGroup1.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.imgGroup1.FlatMode = true;
            this.imgGroup1.FontTitle = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgGroup1.ForeColor = System.Drawing.Color.Black;
            this.imgGroup1.GroupImage = null;
            this.imgGroup1.GroupTitle = "Formatos";
            this.imgGroup1.Location = new System.Drawing.Point(12, 15);
            this.imgGroup1.Name = "imgGroup1";
            this.imgGroup1.Padding = new System.Windows.Forms.Padding(20);
            this.imgGroup1.PaintGroupBox = false;
            this.imgGroup1.RoundCorners = 4;
            this.imgGroup1.ShadowColor = System.Drawing.Color.DarkGray;
            this.imgGroup1.ShadowControl = false;
            this.imgGroup1.ShadowThickness = 3;
            this.imgGroup1.Size = new System.Drawing.Size(267, 363);
            this.imgGroup1.SkinFixed = true;
            this.imgGroup1.TabIndex = 9;
            this.imgGroup1.TitleBackground = System.Drawing.Color.DodgerBlue;
            this.imgGroup1.TitleBackgroundDefault = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.imgGroup1.TitleFontColor = System.Drawing.Color.White;
            // 
            // rbCartasInt
            // 
            this.rbCartasInt.AutoSize = true;
            this.rbCartasInt.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCartasInt.Location = new System.Drawing.Point(56, 279);
            this.rbCartasInt.Name = "rbCartasInt";
            this.rbCartasInt.Size = new System.Drawing.Size(142, 24);
            this.rbCartasInt.TabIndex = 3;
            this.rbCartasInt.TabStop = true;
            this.rbCartasInt.Text = "Cartas Intención";
            this.rbCartasInt.UseVisualStyleBackColor = true;
            this.rbCartasInt.CheckedChanged += new System.EventHandler(this.rbCartasInt_CheckedChanged);
            // 
            // rbPresupuestos
            // 
            this.rbPresupuestos.AutoSize = true;
            this.rbPresupuestos.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPresupuestos.Location = new System.Drawing.Point(56, 206);
            this.rbPresupuestos.Name = "rbPresupuestos";
            this.rbPresupuestos.Size = new System.Drawing.Size(124, 24);
            this.rbPresupuestos.TabIndex = 2;
            this.rbPresupuestos.TabStop = true;
            this.rbPresupuestos.Text = "Presupuestos";
            this.rbPresupuestos.UseVisualStyleBackColor = true;
            this.rbPresupuestos.CheckedChanged += new System.EventHandler(this.rbPresupuestos_CheckedChanged);
            // 
            // rbCartasPres
            // 
            this.rbCartasPres.AutoSize = true;
            this.rbCartasPres.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCartasPres.Location = new System.Drawing.Point(56, 136);
            this.rbCartasPres.Name = "rbCartasPres";
            this.rbCartasPres.Size = new System.Drawing.Size(167, 24);
            this.rbCartasPres.TabIndex = 1;
            this.rbCartasPres.TabStop = true;
            this.rbCartasPres.Text = "Cartas Presentación";
            this.rbCartasPres.UseVisualStyleBackColor = true;
            this.rbCartasPres.CheckedChanged += new System.EventHandler(this.rbCartasPres_CheckedChanged);
            // 
            // rbMailing
            // 
            this.rbMailing.AutoSize = true;
            this.rbMailing.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMailing.Location = new System.Drawing.Point(56, 75);
            this.rbMailing.Name = "rbMailing";
            this.rbMailing.Size = new System.Drawing.Size(83, 24);
            this.rbMailing.TabIndex = 0;
            this.rbMailing.TabStop = true;
            this.rbMailing.Text = "Mailing";
            this.rbMailing.UseVisualStyleBackColor = true;
            this.rbMailing.CheckedChanged += new System.EventHandler(this.rbMailing_CheckedChanged);
            // 
            // lstCartas
            // 
            this.lstCartas.FormattingEnabled = true;
            this.lstCartas.Location = new System.Drawing.Point(296, 49);
            this.lstCartas.Name = "lstCartas";
            this.lstCartas.Size = new System.Drawing.Size(255, 329);
            this.lstCartas.Sorted = true;
            this.lstCartas.TabIndex = 8;
            // 
            // fullLabel1
            // 
            this.fullLabel1.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel1.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel1.Location = new System.Drawing.Point(362, 15);
            this.fullLabel1.Name = "fullLabel1";
            this.fullLabel1.Size = new System.Drawing.Size(134, 23);
            this.fullLabel1.TabIndex = 5;
            this.fullLabel1.Text = "Disponibles:";
            this.fullLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbConfirmar
            // 
            this.gbConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbConfirmar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbConfirmar.BackgroundImage")));
            this.gbConfirmar.BlackBorder = true;
            this.gbConfirmar.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbConfirmar.CircleButton = false;
            this.gbConfirmar.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Accept;
            this.gbConfirmar.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gbConfirmar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Aceptar;
            this.gbConfirmar.FlatFontSize = 9;
            this.gbConfirmar.FlatTextColor = System.Drawing.Color.Black;
            this.gbConfirmar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbConfirmar.Location = new System.Drawing.Point(247, 412);
            this.gbConfirmar.Name = "gbConfirmar";
            this.gbConfirmar.RoundCorners = 2;
            this.gbConfirmar.Size = new System.Drawing.Size(87, 25);
            this.gbConfirmar.TabIndex = 4;
            this.gbConfirmar.Text = "Aceptar";
            this.gbConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbConfirmar.W8Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gbConfirmar.Click += new System.EventHandler(this.gbConfirmar_Click);
            // 
            // EnvioCarta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 449);
            this.Controls.Add(this.xPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EnvioCarta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Selección";
            this.Load += new System.EventHandler(this.SeleccionCarta_Load);
            this.xPanel1.ResumeLayout(false);
            this.imgGroup1.ResumeLayout(false);
            this.imgGroup1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TNGS.NetControls.XPanel xPanel1;
        private TNGS.NetControls.ImgGroup imgGroup1;
        private System.Windows.Forms.RadioButton rbMailing;
        private TNGS.NetControls.CDList lstCartas;
        private TNGS.NetControls.FullLabel fullLabel1;
        private TNGS.NetControls.GlassButton gbConfirmar;
        private System.Windows.Forms.RadioButton rbCartasInt;
        private System.Windows.Forms.RadioButton rbPresupuestos;
        private System.Windows.Forms.RadioButton rbCartasPres;
    }
}