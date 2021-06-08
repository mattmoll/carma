namespace Carm.Ad
{
    partial class AgendarEntrevista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgendarEntrevista));
            this.xPanel1 = new TNGS.NetControls.XPanel();
            this.fullLabel2 = new TNGS.NetControls.FullLabel();
            this.btnExit = new System.Windows.Forms.Button();
            this.fullLabel1 = new TNGS.NetControls.FullLabel();
            this.fullLabel16 = new TNGS.NetControls.FullLabel();
            this.cdcContactos = new TNGS.NetControls.CDCombo();
            this.teObservaciones = new TNGS.NetControls.TextEdit();
            this.fullLabel15 = new TNGS.NetControls.FullLabel();
            this.teDireccion = new TNGS.NetControls.TextEdit();
            this.gbCancelar = new TNGS.NetControls.GlassButton();
            this.gbAceptar = new TNGS.NetControls.GlassButton();
            this.teHora = new TNGS.NetControls.TimeEdit();
            this.fullLabel12 = new TNGS.NetControls.FullLabel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.xPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xPanel1
            // 
            this.xPanel1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanel1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanel1.BorderColor = System.Drawing.Color.Black;
            this.xPanel1.Controls.Add(this.fullLabel2);
            this.xPanel1.Controls.Add(this.btnExit);
            this.xPanel1.Controls.Add(this.fullLabel1);
            this.xPanel1.Controls.Add(this.fullLabel16);
            this.xPanel1.Controls.Add(this.cdcContactos);
            this.xPanel1.Controls.Add(this.teObservaciones);
            this.xPanel1.Controls.Add(this.fullLabel15);
            this.xPanel1.Controls.Add(this.teDireccion);
            this.xPanel1.Controls.Add(this.gbCancelar);
            this.xPanel1.Controls.Add(this.gbAceptar);
            this.xPanel1.Controls.Add(this.teHora);
            this.xPanel1.Controls.Add(this.fullLabel12);
            this.xPanel1.Controls.Add(this.monthCalendar1);
            this.xPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xPanel1.Location = new System.Drawing.Point(0, 0);
            this.xPanel1.Name = "xPanel1";
            this.xPanel1.Size = new System.Drawing.Size(605, 339);
            this.xPanel1.SkinFixed = true;
            this.xPanel1.TabIndex = 0;
            // 
            // fullLabel2
            // 
            this.fullLabel2.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel2.Location = new System.Drawing.Point(32, 80);
            this.fullLabel2.Name = "fullLabel2";
            this.fullLabel2.Size = new System.Drawing.Size(59, 17);
            this.fullLabel2.TabIndex = 104;
            this.fullLabel2.Text = "Contacto:";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(535, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(58, 40);
            this.btnExit.TabIndex = 103;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // fullLabel1
            // 
            this.fullLabel1.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel1.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel1.Location = new System.Drawing.Point(12, 9);
            this.fullLabel1.Name = "fullLabel1";
            this.fullLabel1.Size = new System.Drawing.Size(203, 32);
            this.fullLabel1.TabIndex = 102;
            this.fullLabel1.Text = "Carga de Entrevista";
            this.fullLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fullLabel16
            // 
            this.fullLabel16.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel16.Location = new System.Drawing.Point(32, 188);
            this.fullLabel16.Name = "fullLabel16";
            this.fullLabel16.Size = new System.Drawing.Size(102, 18);
            this.fullLabel16.TabIndex = 32;
            this.fullLabel16.Text = "Observaciones:";
            // 
            // cdcContactos
            // 
            this.cdcContactos.BackColor = System.Drawing.SystemColors.Window;
            this.cdcContactos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdcContactos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cdcContactos.FormattingEnabled = true;
            this.cdcContactos.Location = new System.Drawing.Point(97, 76);
            this.cdcContactos.Name = "cdcContactos";
            this.cdcContactos.Size = new System.Drawing.Size(208, 21);
            this.cdcContactos.Sorted = true;
            this.cdcContactos.TabIndex = 0;
            // 
            // teObservaciones
            // 
            this.teObservaciones.BackColor = System.Drawing.SystemColors.Window;
            this.teObservaciones.Location = new System.Drawing.Point(35, 209);
            this.teObservaciones.Multiline = true;
            this.teObservaciones.Name = "teObservaciones";
            this.teObservaciones.Size = new System.Drawing.Size(273, 64);
            this.teObservaciones.TabIndex = 3;
            // 
            // fullLabel15
            // 
            this.fullLabel15.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel15.Location = new System.Drawing.Point(29, 130);
            this.fullLabel15.Name = "fullLabel15";
            this.fullLabel15.Size = new System.Drawing.Size(59, 17);
            this.fullLabel15.TabIndex = 29;
            this.fullLabel15.Text = "Dirección:";
            // 
            // teDireccion
            // 
            this.teDireccion.BackColor = System.Drawing.SystemColors.Window;
            this.teDireccion.EmptyValid = false;
            this.teDireccion.Location = new System.Drawing.Point(97, 127);
            this.teDireccion.Name = "teDireccion";
            this.teDireccion.Size = new System.Drawing.Size(208, 20);
            this.teDireccion.TabIndex = 5;
            // 
            // gbCancelar
            // 
            this.gbCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbCancelar.BackgroundImage")));
            this.gbCancelar.BlackBorder = true;
            this.gbCancelar.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbCancelar.CircleButton = false;
            this.gbCancelar.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Cancel;
            this.gbCancelar.FlatColor = System.Drawing.Color.Red;
            this.gbCancelar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Cancelar;
            this.gbCancelar.FlatFontSize = 9;
            this.gbCancelar.FlatTextColor = System.Drawing.Color.Black;
            this.gbCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbCancelar.Location = new System.Drawing.Point(349, 299);
            this.gbCancelar.Name = "gbCancelar";
            this.gbCancelar.RoundCorners = 2;
            this.gbCancelar.Size = new System.Drawing.Size(99, 25);
            this.gbCancelar.TabIndex = 8;
            this.gbCancelar.Text = "Cancelar";
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
            this.gbAceptar.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Accept;
            this.gbAceptar.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gbAceptar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Aceptar;
            this.gbAceptar.FlatFontSize = 9;
            this.gbAceptar.FlatTextColor = System.Drawing.Color.Black;
            this.gbAceptar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbAceptar.Location = new System.Drawing.Point(488, 298);
            this.gbAceptar.Name = "gbAceptar";
            this.gbAceptar.RoundCorners = 2;
            this.gbAceptar.Size = new System.Drawing.Size(99, 25);
            this.gbAceptar.TabIndex = 6;
            this.gbAceptar.Text = "Aceptar";
            this.gbAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbAceptar.W8Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gbAceptar.Click += new System.EventHandler(this.gbAceptar_Click);
            // 
            // teHora
            // 
            this.teHora.BackColor = System.Drawing.SystemColors.Window;
            this.teHora.EmptyValid = false;
            this.teHora.Location = new System.Drawing.Point(398, 77);
            this.teHora.MaxLength = 5;
            this.teHora.Name = "teHora";
            this.teHora.Size = new System.Drawing.Size(50, 20);
            this.teHora.TabIndex = 4;
            this.teHora.Text = "  :  ";
            // 
            // fullLabel12
            // 
            this.fullLabel12.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel12.Location = new System.Drawing.Point(357, 80);
            this.fullLabel12.Name = "fullLabel12";
            this.fullLabel12.Size = new System.Drawing.Size(44, 16);
            this.fullLabel12.TabIndex = 25;
            this.fullLabel12.Text = "Hora:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(360, 113);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // AgendarEntrevista
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(605, 339);
            this.Controls.Add(this.xPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgendarEntrevista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agendar entrevista";
            this.xPanel1.ResumeLayout(false);
            this.xPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TNGS.NetControls.XPanel xPanel1;
        private TNGS.NetControls.CDCombo cdcContactos;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private TNGS.NetControls.GlassButton gbCancelar;
        private TNGS.NetControls.GlassButton gbAceptar;
        private TNGS.NetControls.FullLabel fullLabel12;
        private TNGS.NetControls.TimeEdit teHora;
        private TNGS.NetControls.FullLabel fullLabel15;
        private TNGS.NetControls.TextEdit teDireccion;
        private TNGS.NetControls.FullLabel fullLabel16;
        private TNGS.NetControls.TextEdit teObservaciones;
        private TNGS.NetControls.FullLabel fullLabel2;
        private System.Windows.Forms.Button btnExit;
        private TNGS.NetControls.FullLabel fullLabel1;
    }
}