namespace Carm.Shr
{
    partial class BusqLocalidades
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
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusqLocalidades));
            this.xpnlBase = new TNGS.NetControls.XPanel();
            this.lblTitulo = new TNGS.NetControls.FullLabel();
            this.lblCancela = new System.Windows.Forms.Label();
            this.lblConfirma = new System.Windows.Forms.Label();
            this.imgGroup1 = new TNGS.NetControls.ImgGroup();
            this.GBBuscar = new TNGS.NetControls.GlassButton();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.cmbProvincias = new TNGS.NetControls.CDCombo();
            this.txtLocalidad = new TNGS.NetControls.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flxgLocalidades = new TNGS.NetControls.FlexGrid();
            this.xpnlBase.SuspendLayout();
            this.imgGroup1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xpnlBase
            // 
            this.xpnlBase.BackColor = System.Drawing.Color.Transparent;
            this.xpnlBase.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xpnlBase.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.xpnlBase.BorderColor = System.Drawing.Color.Black;
            this.xpnlBase.Controls.Add(this.lblTitulo);
            this.xpnlBase.Controls.Add(this.lblCancela);
            this.xpnlBase.Controls.Add(this.lblConfirma);
            this.xpnlBase.Controls.Add(this.imgGroup1);
            this.xpnlBase.Controls.Add(this.flxgLocalidades);
            this.xpnlBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xpnlBase.Location = new System.Drawing.Point(0, 0);
            this.xpnlBase.Name = "xpnlBase";
            this.xpnlBase.Size = new System.Drawing.Size(693, 396);
            this.xpnlBase.SkinFixed = true;
            this.xpnlBase.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(92, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(498, 23);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "Busqueda de Localidades";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCancela
            // 
            this.lblCancela.AutoSize = true;
            this.lblCancela.BackColor = System.Drawing.Color.Transparent;
            this.lblCancela.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancela.ForeColor = System.Drawing.Color.SkyBlue;
            this.lblCancela.Location = new System.Drawing.Point(12, 276);
            this.lblCancela.Name = "lblCancela";
            this.lblCancela.Size = new System.Drawing.Size(117, 12);
            this.lblCancela.TabIndex = 2;
            this.lblCancela.Text = "[Esc]- Cancela";
            // 
            // lblConfirma
            // 
            this.lblConfirma.AutoSize = true;
            this.lblConfirma.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirma.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirma.ForeColor = System.Drawing.Color.SkyBlue;
            this.lblConfirma.Location = new System.Drawing.Point(462, 276);
            this.lblConfirma.Name = "lblConfirma";
            this.lblConfirma.Size = new System.Drawing.Size(221, 12);
            this.lblConfirma.TabIndex = 3;
            this.lblConfirma.Text = "[Enter]- Confirma selección";
            this.lblConfirma.Visible = false;
            // 
            // imgGroup1
            // 
            this.imgGroup1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.imgGroup1.BackgroundGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.imgGroup1.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.ForwardDiagonal;
            this.imgGroup1.BlackBorder = false;
            this.imgGroup1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.imgGroup1.BorderThickness = 2F;
            this.imgGroup1.Controls.Add(this.GBBuscar);
            this.imgGroup1.Controls.Add(this.lblMensaje);
            this.imgGroup1.Controls.Add(this.cmbProvincias);
            this.imgGroup1.Controls.Add(this.txtLocalidad);
            this.imgGroup1.Controls.Add(this.label2);
            this.imgGroup1.Controls.Add(this.label1);
            this.imgGroup1.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.imgGroup1.FlatMode = true;
            this.imgGroup1.FontTitle = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgGroup1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.imgGroup1.GroupImage = null;
            this.imgGroup1.GroupTitle = "";
            this.imgGroup1.Location = new System.Drawing.Point(14, 291);
            this.imgGroup1.Name = "imgGroup1";
            this.imgGroup1.Padding = new System.Windows.Forms.Padding(20);
            this.imgGroup1.PaintGroupBox = false;
            this.imgGroup1.RoundCorners = 4;
            this.imgGroup1.ShadowColor = System.Drawing.Color.DarkGray;
            this.imgGroup1.ShadowControl = false;
            this.imgGroup1.ShadowThickness = 3;
            this.imgGroup1.Size = new System.Drawing.Size(669, 94);
            this.imgGroup1.SkinFixed = true;
            this.imgGroup1.TabIndex = 0;
            this.imgGroup1.TitleBackground = System.Drawing.Color.DodgerBlue;
            this.imgGroup1.TitleBackgroundDefault = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.imgGroup1.TitleFontColor = System.Drawing.Color.White;
            // 
            // GBBuscar
            // 
            this.GBBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GBBuscar.BackgroundImage")));
            this.GBBuscar.BlackBorder = true;
            this.GBBuscar.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.GBBuscar.CircleButton = false;
            this.GBBuscar.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Search;
            this.GBBuscar.FlatColor = System.Drawing.Color.DodgerBlue;
            this.GBBuscar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.LightBlue;
            this.GBBuscar.FlatFontSize = 9;
            this.GBBuscar.FlatTextColor = System.Drawing.Color.Black;
            this.GBBuscar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.GBBuscar.Location = new System.Drawing.Point(518, 54);
            this.GBBuscar.Name = "GBBuscar";
            this.GBBuscar.RoundCorners = 2;
            this.GBBuscar.Size = new System.Drawing.Size(80, 25);
            this.GBBuscar.TabIndex = 5;
            this.GBBuscar.Text = "Buscar";
            this.GBBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GBBuscar.W8Color = System.Drawing.Color.DodgerBlue;
            this.GBBuscar.Click += new System.EventHandler(this.GBBuscar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.BackColor = System.Drawing.Color.Transparent;
            this.lblMensaje.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.SkyBlue;
            this.lblMensaje.Location = new System.Drawing.Point(375, 26);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(282, 31);
            this.lblMensaje.TabIndex = 4;
            this.lblMensaje.Text = "[F3]- Borra los resultados";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbProvincias
            // 
            this.cmbProvincias.BackColor = System.Drawing.SystemColors.Window;
            this.cmbProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvincias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProvincias.FormattingEnabled = true;
            this.cmbProvincias.Location = new System.Drawing.Point(111, 28);
            this.cmbProvincias.Name = "cmbProvincias";
            this.cmbProvincias.Size = new System.Drawing.Size(239, 23);
            this.cmbProvincias.Sorted = true;
            this.cmbProvincias.TabIndex = 0;
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.BackColor = System.Drawing.SystemColors.Window;
            this.txtLocalidad.Location = new System.Drawing.Point(112, 57);
            this.txtLocalidad.MaxLength = 60;
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(257, 21);
            this.txtLocalidad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Localidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Provincia:";
            // 
            // flxgLocalidades
            // 
            this.flxgLocalidades.ExcelTitle = "";
            this.flxgLocalidades.Location = new System.Drawing.Point(12, 43);
            this.flxgLocalidades.Name = "flxgLocalidades";
            this.flxgLocalidades.OwnerDraw = true;
            this.flxgLocalidades.Size = new System.Drawing.Size(671, 226);
            this.flxgLocalidades.TabIndex = 1;
            this.flxgLocalidades.UseCompatibleStateImageBehavior = false;
            this.flxgLocalidades.DoubleClick += new System.EventHandler(this.flxgLocalidades_DoubleClick);
            // 
            // BusqLocalidades
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(693, 396);
            this.Controls.Add(this.xpnlBase);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BusqLocalidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda de Localidades";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BusqLocalidades_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BusqLocalidades_KeyPress);
            this.xpnlBase.ResumeLayout(false);
            this.xpnlBase.PerformLayout();
            this.imgGroup1.ResumeLayout(false);
            this.imgGroup1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TNGS.NetControls.XPanel xpnlBase;
        private TNGS.NetControls.CDCombo cmbProvincias;
        private TNGS.NetControls.ImgGroup imgGroup1;
        private TNGS.NetControls.FlexGrid flxgLocalidades;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private TNGS.NetControls.TextEdit txtLocalidad;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblCancela;
        private System.Windows.Forms.Label lblConfirma;
        private TNGS.NetControls.GlassButton GBBuscar;
        private TNGS.NetControls.FullLabel lblTitulo;
    }
}