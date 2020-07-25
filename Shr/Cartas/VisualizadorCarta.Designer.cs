namespace Carm.Shr
{
    partial class VisualizadorCarta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualizadorCarta));
            this.xPanel1 = new TNGS.NetControls.XPanel();
            this.gbAdjuntar = new TNGS.NetControls.GlassButton();
            this.gbWord = new TNGS.NetControls.GlassButton();
            this.gbCompletar = new TNGS.NetControls.GlassButton();
            this.lblTitulo = new TNGS.NetControls.FullLabel();
            this.gbImprimir = new TNGS.NetControls.GlassButton();
            this.gbEnviar = new TNGS.NetControls.GlassButton();
            this.rtfVisualizador = new TNGS.NetControls.RTFEdit();
            this.ofdBuscarAdjuntable = new System.Windows.Forms.OpenFileDialog();
            this.gbCancelar = new TNGS.NetControls.GlassButton();
            this.xPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xPanel1
            // 
            this.xPanel1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanel1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanel1.BorderColor = System.Drawing.Color.Black;
            this.xPanel1.Controls.Add(this.gbCancelar);
            this.xPanel1.Controls.Add(this.gbAdjuntar);
            this.xPanel1.Controls.Add(this.gbWord);
            this.xPanel1.Controls.Add(this.gbCompletar);
            this.xPanel1.Controls.Add(this.lblTitulo);
            this.xPanel1.Controls.Add(this.gbImprimir);
            this.xPanel1.Controls.Add(this.gbEnviar);
            this.xPanel1.Controls.Add(this.rtfVisualizador);
            this.xPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xPanel1.Location = new System.Drawing.Point(0, 0);
            this.xPanel1.Name = "xPanel1";
            this.xPanel1.Size = new System.Drawing.Size(690, 745);
            this.xPanel1.SkinFixed = true;
            this.xPanel1.TabIndex = 0;
            // 
            // gbAdjuntar
            // 
            this.gbAdjuntar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAdjuntar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbAdjuntar.BackgroundImage")));
            this.gbAdjuntar.BlackBorder = true;
            this.gbAdjuntar.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbAdjuntar.CircleButton = false;
            this.gbAdjuntar.Enabled = false;
            this.gbAdjuntar.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Folder;
            this.gbAdjuntar.FlatColor = System.Drawing.Color.DodgerBlue;
            this.gbAdjuntar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.LightBlue;
            this.gbAdjuntar.FlatFontSize = 9;
            this.gbAdjuntar.FlatTextColor = System.Drawing.Color.Black;
            this.gbAdjuntar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbAdjuntar.ImageOnTop = true;
            this.gbAdjuntar.Location = new System.Drawing.Point(441, 669);
            this.gbAdjuntar.Name = "gbAdjuntar";
            this.gbAdjuntar.RoundCorners = 2;
            this.gbAdjuntar.Size = new System.Drawing.Size(80, 68);
            this.gbAdjuntar.TabIndex = 16;
            this.gbAdjuntar.Text = "Adjuntar";
            this.gbAdjuntar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gbAdjuntar.W8Color = System.Drawing.Color.DodgerBlue;
            this.gbAdjuntar.Click += new System.EventHandler(this.gbAdjuntar_Click);
            // 
            // gbWord
            // 
            this.gbWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbWord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbWord.BackgroundImage")));
            this.gbWord.BlackBorder = true;
            this.gbWord.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbWord.CircleButton = false;
            this.gbWord.Enabled = false;
            this.gbWord.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Copy;
            this.gbWord.FlatColor = System.Drawing.Color.DodgerBlue;
            this.gbWord.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.LightBlue;
            this.gbWord.FlatFontSize = 9;
            this.gbWord.FlatTextColor = System.Drawing.Color.Black;
            this.gbWord.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbWord.ImageOnTop = true;
            this.gbWord.Location = new System.Drawing.Point(310, 669);
            this.gbWord.Name = "gbWord";
            this.gbWord.RoundCorners = 2;
            this.gbWord.Size = new System.Drawing.Size(80, 68);
            this.gbWord.TabIndex = 15;
            this.gbWord.Text = "Copiar al Clipboard";
            this.gbWord.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gbWord.ToolTipText = "Copia el contenido al portapapeles. Abrá un word y pegue y tendrá su carta en un " +
    "archivo word.";
            this.gbWord.W8Color = System.Drawing.Color.DodgerBlue;
            this.gbWord.Click += new System.EventHandler(this.gbWord_Click);
            // 
            // gbCompletar
            // 
            this.gbCompletar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCompletar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbCompletar.BackgroundImage")));
            this.gbCompletar.BlackBorder = true;
            this.gbCompletar.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbCompletar.CircleButton = false;
            this.gbCompletar.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Note;
            this.gbCompletar.FlatColor = System.Drawing.Color.DodgerBlue;
            this.gbCompletar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.LightBlue;
            this.gbCompletar.FlatFontSize = 9;
            this.gbCompletar.FlatTextColor = System.Drawing.Color.Black;
            this.gbCompletar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbCompletar.ImageOnTop = true;
            this.gbCompletar.Location = new System.Drawing.Point(37, 669);
            this.gbCompletar.Name = "gbCompletar";
            this.gbCompletar.RoundCorners = 2;
            this.gbCompletar.Size = new System.Drawing.Size(80, 68);
            this.gbCompletar.TabIndex = 14;
            this.gbCompletar.Text = "Completar Códigos";
            this.gbCompletar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gbCompletar.W8Color = System.Drawing.Color.DodgerBlue;
            this.gbCompletar.Click += new System.EventHandler(this.gbCompletar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(69, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(498, 23);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Título";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbImprimir
            // 
            this.gbImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbImprimir.BackgroundImage")));
            this.gbImprimir.BlackBorder = true;
            this.gbImprimir.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbImprimir.CircleButton = false;
            this.gbImprimir.Enabled = false;
            this.gbImprimir.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Print;
            this.gbImprimir.FlatColor = System.Drawing.Color.Gray;
            this.gbImprimir.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Imprimir;
            this.gbImprimir.FlatFontSize = 9;
            this.gbImprimir.FlatTextColor = System.Drawing.Color.Black;
            this.gbImprimir.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbImprimir.ImageOnTop = true;
            this.gbImprimir.Location = new System.Drawing.Point(170, 669);
            this.gbImprimir.Name = "gbImprimir";
            this.gbImprimir.RoundCorners = 2;
            this.gbImprimir.Size = new System.Drawing.Size(80, 68);
            this.gbImprimir.TabIndex = 12;
            this.gbImprimir.Text = "Imprimir";
            this.gbImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gbImprimir.W8Color = System.Drawing.Color.Gray;
            this.gbImprimir.Click += new System.EventHandler(this.gbImprimir_Click);
            // 
            // gbEnviar
            // 
            this.gbEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbEnviar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbEnviar.BackgroundImage")));
            this.gbEnviar.BlackBorder = true;
            this.gbEnviar.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbEnviar.CircleButton = false;
            this.gbEnviar.Enabled = false;
            this.gbEnviar.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Accept;
            this.gbEnviar.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gbEnviar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Aceptar;
            this.gbEnviar.FlatFontSize = 9;
            this.gbEnviar.FlatTextColor = System.Drawing.Color.Black;
            this.gbEnviar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbEnviar.ImageOnTop = true;
            this.gbEnviar.Location = new System.Drawing.Point(569, 669);
            this.gbEnviar.Name = "gbEnviar";
            this.gbEnviar.RoundCorners = 2;
            this.gbEnviar.Size = new System.Drawing.Size(80, 68);
            this.gbEnviar.TabIndex = 11;
            this.gbEnviar.Text = "Enviar";
            this.gbEnviar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gbEnviar.W8Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gbEnviar.Click += new System.EventHandler(this.gbEnviar_Click);
            // 
            // rtfVisualizador
            // 
            this.rtfVisualizador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtfVisualizador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rtfVisualizador.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtfVisualizador.Location = new System.Drawing.Point(12, 48);
            this.rtfVisualizador.Name = "rtfVisualizador";
            this.rtfVisualizador.ReadOnly = true;
            this.rtfVisualizador.RulerEnable = false;
            this.rtfVisualizador.Size = new System.Drawing.Size(666, 615);
            this.rtfVisualizador.TabIndex = 1;
            this.rtfVisualizador.TBEnable = false;
            // 
            // ofdBuscarAdjuntable
            // 
            this.ofdBuscarAdjuntable.FileName = "openFileDialog1";
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
            this.gbCancelar.Location = new System.Drawing.Point(661, 3);
            this.gbCancelar.Name = "gbCancelar";
            this.gbCancelar.RoundCorners = 2;
            this.gbCancelar.Size = new System.Drawing.Size(26, 24);
            this.gbCancelar.TabIndex = 141;
            this.gbCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbCancelar.W8Color = System.Drawing.Color.Red;
            this.gbCancelar.Click += new System.EventHandler(this.gbCancelar_Click);
            // 
            // VisualizadorCarta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 745);
            this.Controls.Add(this.xPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VisualizadorCarta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizador Carta";
            this.Load += new System.EventHandler(this.VisualizadorCarta_Load);
            this.xPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TNGS.NetControls.XPanel xPanel1;
        private TNGS.NetControls.RTFEdit rtfVisualizador;
        private TNGS.NetControls.GlassButton gbEnviar;
        private TNGS.NetControls.GlassButton gbImprimir;
        private TNGS.NetControls.FullLabel lblTitulo;
        private TNGS.NetControls.GlassButton gbCompletar;
        private TNGS.NetControls.GlassButton gbWord;
        private TNGS.NetControls.GlassButton gbAdjuntar;
        private System.Windows.Forms.OpenFileDialog ofdBuscarAdjuntable;
        private TNGS.NetControls.GlassButton gbCancelar;
    }
}