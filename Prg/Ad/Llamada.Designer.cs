namespace Carm.Ad
{
    partial class Llamada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Llamada));
            this.xPanel1 = new TNGS.NetControls.XPanel();
            this.dtRellamada = new System.Windows.Forms.DateTimePicker();
            this.cbRellamar = new System.Windows.Forms.CheckBox();
            this.pnlSeleccionTipo = new System.Windows.Forms.Panel();
            this.pnlLlamado = new System.Windows.Forms.Panel();
            this.teResultado = new TNGS.NetControls.TextEdit();
            this.fullLabel2 = new TNGS.NetControls.FullLabel();
            this.cdcCategorias = new TNGS.NetControls.CDCombo();
            this.fullLabel3 = new TNGS.NetControls.FullLabel();
            this.fullLabel4 = new TNGS.NetControls.FullLabel();
            this.cdcMotivos = new TNGS.NetControls.CDCombo();
            this.rbSalientes = new System.Windows.Forms.RadioButton();
            this.rbEntrantes = new System.Windows.Forms.RadioButton();
            this.teNTelefono = new TNGS.NetControls.TextEdit();
            this.btnExit = new System.Windows.Forms.Button();
            this.fullLabel6 = new TNGS.NetControls.FullLabel();
            this.fullLabel5 = new TNGS.NetControls.FullLabel();
            this.gbRecupero = new TNGS.NetControls.GlassButton();
            this.teHora = new TNGS.NetControls.TimeEdit();
            this.mcCalendar = new System.Windows.Forms.MonthCalendar();
            this.fullLabel1 = new TNGS.NetControls.FullLabel();
            this.gbBaja = new TNGS.NetControls.GlassButton();
            this.bAceptar = new TNGS.NetControls.GlassButton();
            this.bCancelar = new TNGS.NetControls.GlassButton();
            this.cbReintentarLlamado = new System.Windows.Forms.CheckBox();
            this.xPanel1.SuspendLayout();
            this.pnlSeleccionTipo.SuspendLayout();
            this.pnlLlamado.SuspendLayout();
            this.SuspendLayout();
            // 
            // xPanel1
            // 
            this.xPanel1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanel1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanel1.BorderColor = System.Drawing.Color.Black;
            this.xPanel1.Controls.Add(this.cbReintentarLlamado);
            this.xPanel1.Controls.Add(this.dtRellamada);
            this.xPanel1.Controls.Add(this.cbRellamar);
            this.xPanel1.Controls.Add(this.pnlSeleccionTipo);
            this.xPanel1.Controls.Add(this.teNTelefono);
            this.xPanel1.Controls.Add(this.btnExit);
            this.xPanel1.Controls.Add(this.fullLabel6);
            this.xPanel1.Controls.Add(this.fullLabel5);
            this.xPanel1.Controls.Add(this.gbRecupero);
            this.xPanel1.Controls.Add(this.teHora);
            this.xPanel1.Controls.Add(this.mcCalendar);
            this.xPanel1.Controls.Add(this.fullLabel1);
            this.xPanel1.Controls.Add(this.gbBaja);
            this.xPanel1.Controls.Add(this.bAceptar);
            this.xPanel1.Controls.Add(this.bCancelar);
            this.xPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xPanel1.Location = new System.Drawing.Point(0, 0);
            this.xPanel1.Name = "xPanel1";
            this.xPanel1.Size = new System.Drawing.Size(778, 547);
            this.xPanel1.SkinFixed = true;
            this.xPanel1.TabIndex = 0;
            // 
            // dtRellamada
            // 
            this.dtRellamada.Location = new System.Drawing.Point(497, 390);
            this.dtRellamada.Name = "dtRellamada";
            this.dtRellamada.Size = new System.Drawing.Size(200, 22);
            this.dtRellamada.TabIndex = 107;
            this.dtRellamada.Visible = false;
            // 
            // cbRellamar
            // 
            this.cbRellamar.AutoSize = true;
            this.cbRellamar.BackColor = System.Drawing.Color.Transparent;
            this.cbRellamar.Location = new System.Drawing.Point(499, 367);
            this.cbRellamar.Name = "cbRellamar";
            this.cbRellamar.Size = new System.Drawing.Size(119, 20);
            this.cbRellamar.TabIndex = 106;
            this.cbRellamar.Text = "Volver a llamar";
            this.cbRellamar.UseVisualStyleBackColor = false;
            this.cbRellamar.CheckedChanged += new System.EventHandler(this.cbRellamar_CheckedChanged);
            // 
            // pnlSeleccionTipo
            // 
            this.pnlSeleccionTipo.BackColor = System.Drawing.Color.Transparent;
            this.pnlSeleccionTipo.Controls.Add(this.pnlLlamado);
            this.pnlSeleccionTipo.Controls.Add(this.rbSalientes);
            this.pnlSeleccionTipo.Controls.Add(this.rbEntrantes);
            this.pnlSeleccionTipo.Location = new System.Drawing.Point(17, 80);
            this.pnlSeleccionTipo.Name = "pnlSeleccionTipo";
            this.pnlSeleccionTipo.Size = new System.Drawing.Size(441, 295);
            this.pnlSeleccionTipo.TabIndex = 15;
            // 
            // pnlLlamado
            // 
            this.pnlLlamado.Controls.Add(this.teResultado);
            this.pnlLlamado.Controls.Add(this.fullLabel2);
            this.pnlLlamado.Controls.Add(this.cdcCategorias);
            this.pnlLlamado.Controls.Add(this.fullLabel3);
            this.pnlLlamado.Controls.Add(this.fullLabel4);
            this.pnlLlamado.Controls.Add(this.cdcMotivos);
            this.pnlLlamado.Location = new System.Drawing.Point(6, 25);
            this.pnlLlamado.Name = "pnlLlamado";
            this.pnlLlamado.Size = new System.Drawing.Size(419, 255);
            this.pnlLlamado.TabIndex = 23;
            this.pnlLlamado.Visible = false;
            // 
            // teResultado
            // 
            this.teResultado.BackColor = System.Drawing.SystemColors.Window;
            this.teResultado.EmptyValid = false;
            this.teResultado.Location = new System.Drawing.Point(94, 113);
            this.teResultado.Multiline = true;
            this.teResultado.Name = "teResultado";
            this.teResultado.Size = new System.Drawing.Size(297, 139);
            this.teResultado.TabIndex = 4;
            // 
            // fullLabel2
            // 
            this.fullLabel2.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel2.Location = new System.Drawing.Point(29, 62);
            this.fullLabel2.Name = "fullLabel2";
            this.fullLabel2.Size = new System.Drawing.Size(59, 16);
            this.fullLabel2.TabIndex = 5;
            this.fullLabel2.Text = "Motivo:";
            this.fullLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cdcCategorias
            // 
            this.cdcCategorias.BackColor = System.Drawing.SystemColors.Window;
            this.cdcCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdcCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cdcCategorias.FormattingEnabled = true;
            this.cdcCategorias.Location = new System.Drawing.Point(94, 16);
            this.cdcCategorias.Name = "cdcCategorias";
            this.cdcCategorias.Size = new System.Drawing.Size(297, 24);
            this.cdcCategorias.Sorted = true;
            this.cdcCategorias.TabIndex = 9;
            this.cdcCategorias.SelectedIndexChanged += new System.EventHandler(this.cdcCategorias_SelectedIndexChanged);
            // 
            // fullLabel3
            // 
            this.fullLabel3.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel3.Location = new System.Drawing.Point(9, 113);
            this.fullLabel3.Name = "fullLabel3";
            this.fullLabel3.Size = new System.Drawing.Size(79, 16);
            this.fullLabel3.TabIndex = 6;
            this.fullLabel3.Text = "Resultado:";
            this.fullLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fullLabel4
            // 
            this.fullLabel4.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel4.Location = new System.Drawing.Point(29, 17);
            this.fullLabel4.Name = "fullLabel4";
            this.fullLabel4.Size = new System.Drawing.Size(59, 16);
            this.fullLabel4.TabIndex = 10;
            this.fullLabel4.Text = "Categoria:";
            this.fullLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cdcMotivos
            // 
            this.cdcMotivos.BackColor = System.Drawing.SystemColors.Window;
            this.cdcMotivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdcMotivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cdcMotivos.FormattingEnabled = true;
            this.cdcMotivos.Location = new System.Drawing.Point(94, 61);
            this.cdcMotivos.Name = "cdcMotivos";
            this.cdcMotivos.Size = new System.Drawing.Size(297, 24);
            this.cdcMotivos.Sorted = true;
            this.cdcMotivos.TabIndex = 3;
            // 
            // rbSalientes
            // 
            this.rbSalientes.AutoSize = true;
            this.rbSalientes.Location = new System.Drawing.Point(139, 3);
            this.rbSalientes.Name = "rbSalientes";
            this.rbSalientes.Size = new System.Drawing.Size(77, 20);
            this.rbSalientes.TabIndex = 0;
            this.rbSalientes.TabStop = true;
            this.rbSalientes.Text = "Saliente";
            this.rbSalientes.UseVisualStyleBackColor = true;
            this.rbSalientes.CheckedChanged += new System.EventHandler(this.rbSalientes_CheckedChanged);
            // 
            // rbEntrantes
            // 
            this.rbEntrantes.AutoSize = true;
            this.rbEntrantes.Location = new System.Drawing.Point(234, 3);
            this.rbEntrantes.Name = "rbEntrantes";
            this.rbEntrantes.Size = new System.Drawing.Size(77, 20);
            this.rbEntrantes.TabIndex = 1;
            this.rbEntrantes.TabStop = true;
            this.rbEntrantes.Text = "Entrante";
            this.rbEntrantes.UseVisualStyleBackColor = true;
            this.rbEntrantes.CheckedChanged += new System.EventHandler(this.rbEntrantes_CheckedChanged);
            // 
            // teNTelefono
            // 
            this.teNTelefono.BackColor = System.Drawing.SystemColors.Window;
            this.teNTelefono.Enabled = false;
            this.teNTelefono.Location = new System.Drawing.Point(558, 83);
            this.teNTelefono.Name = "teNTelefono";
            this.teNTelefono.Size = new System.Drawing.Size(173, 22);
            this.teNTelefono.TabIndex = 82;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(709, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(58, 40);
            this.btnExit.TabIndex = 105;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // fullLabel6
            // 
            this.fullLabel6.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel6.Location = new System.Drawing.Point(501, 87);
            this.fullLabel6.Name = "fullLabel6";
            this.fullLabel6.Size = new System.Drawing.Size(100, 16);
            this.fullLabel6.TabIndex = 83;
            this.fullLabel6.Text = "Teléfono:";
            // 
            // fullLabel5
            // 
            this.fullLabel5.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel5.Location = new System.Drawing.Point(12, 9);
            this.fullLabel5.Name = "fullLabel5";
            this.fullLabel5.Size = new System.Drawing.Size(289, 32);
            this.fullLabel5.TabIndex = 104;
            this.fullLabel5.Text = "Carga de Llamada";
            this.fullLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbRecupero
            // 
            this.gbRecupero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbRecupero.BackgroundImage")));
            this.gbRecupero.BlackBorder = true;
            this.gbRecupero.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbRecupero.CircleButton = false;
            this.gbRecupero.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Money;
            this.gbRecupero.FlatColor = System.Drawing.Color.DodgerBlue;
            this.gbRecupero.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.LightBlue;
            this.gbRecupero.FlatFontSize = 9;
            this.gbRecupero.FlatTextColor = System.Drawing.Color.Black;
            this.gbRecupero.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbRecupero.Location = new System.Drawing.Point(251, 485);
            this.gbRecupero.Name = "gbRecupero";
            this.gbRecupero.PCode = "CLIRECUPERO";
            this.gbRecupero.RoundCorners = 2;
            this.gbRecupero.Size = new System.Drawing.Size(96, 25);
            this.gbRecupero.TabIndex = 23;
            this.gbRecupero.Text = "Recupero";
            this.gbRecupero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbRecupero.Visible = false;
            this.gbRecupero.W8Color = System.Drawing.Color.DodgerBlue;
            this.gbRecupero.Click += new System.EventHandler(this.gbRecupero_Click);
            // 
            // teHora
            // 
            this.teHora.BackColor = System.Drawing.SystemColors.Window;
            this.teHora.Location = new System.Drawing.Point(558, 116);
            this.teHora.MaxLength = 5;
            this.teHora.Name = "teHora";
            this.teHora.Size = new System.Drawing.Size(52, 22);
            this.teHora.TabIndex = 2;
            this.teHora.Text = "  :  ";
            // 
            // mcCalendar
            // 
            this.mcCalendar.Location = new System.Drawing.Point(504, 148);
            this.mcCalendar.MaxSelectionCount = 1;
            this.mcCalendar.Name = "mcCalendar";
            this.mcCalendar.TabIndex = 0;
            // 
            // fullLabel1
            // 
            this.fullLabel1.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel1.Location = new System.Drawing.Point(494, 116);
            this.fullLabel1.Name = "fullLabel1";
            this.fullLabel1.Size = new System.Drawing.Size(55, 16);
            this.fullLabel1.TabIndex = 4;
            this.fullLabel1.Text = "Hora:";
            this.fullLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbBaja
            // 
            this.gbBaja.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbBaja.BackgroundImage")));
            this.gbBaja.BlackBorder = true;
            this.gbBaja.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbBaja.CircleButton = false;
            this.gbBaja.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Cancel;
            this.gbBaja.FlatColor = System.Drawing.Color.Red;
            this.gbBaja.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Cancelar;
            this.gbBaja.FlatFontSize = 9;
            this.gbBaja.FlatTextColor = System.Drawing.Color.Black;
            this.gbBaja.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbBaja.Location = new System.Drawing.Point(114, 485);
            this.gbBaja.Name = "gbBaja";
            this.gbBaja.PCode = "CLIBAJA";
            this.gbBaja.RoundCorners = 2;
            this.gbBaja.Size = new System.Drawing.Size(112, 25);
            this.gbBaja.TabIndex = 11;
            this.gbBaja.Text = "Baja Servicio";
            this.gbBaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbBaja.Visible = false;
            this.gbBaja.W8Color = System.Drawing.Color.Red;
            this.gbBaja.Click += new System.EventHandler(this.gbBaja_Click);
            // 
            // bAceptar
            // 
            this.bAceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bAceptar.BackgroundImage")));
            this.bAceptar.BlackBorder = true;
            this.bAceptar.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.bAceptar.CircleButton = false;
            this.bAceptar.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Accept;
            this.bAceptar.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bAceptar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Aceptar;
            this.bAceptar.FlatFontSize = 9;
            this.bAceptar.FlatTextColor = System.Drawing.Color.Black;
            this.bAceptar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bAceptar.Location = new System.Drawing.Point(649, 485);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.RoundCorners = 2;
            this.bAceptar.Size = new System.Drawing.Size(82, 25);
            this.bAceptar.TabIndex = 5;
            this.bAceptar.Text = "Grabar";
            this.bAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAceptar.W8Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bCancelar.BackgroundImage")));
            this.bCancelar.BlackBorder = true;
            this.bCancelar.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.bCancelar.CircleButton = false;
            this.bCancelar.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Cancel;
            this.bCancelar.FlatColor = System.Drawing.Color.Red;
            this.bCancelar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Cancelar;
            this.bCancelar.FlatFontSize = 9;
            this.bCancelar.FlatTextColor = System.Drawing.Color.Black;
            this.bCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bCancelar.Location = new System.Drawing.Point(504, 485);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.RoundCorners = 2;
            this.bCancelar.Size = new System.Drawing.Size(87, 25);
            this.bCancelar.TabIndex = 8;
            this.bCancelar.Text = "Cerrar";
            this.bCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bCancelar.W8Color = System.Drawing.Color.Red;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // cbReintentarLlamado
            // 
            this.cbReintentarLlamado.AutoSize = true;
            this.cbReintentarLlamado.BackColor = System.Drawing.Color.Transparent;
            this.cbReintentarLlamado.Location = new System.Drawing.Point(497, 430);
            this.cbReintentarLlamado.Name = "cbReintentarLlamado";
            this.cbReintentarLlamado.Size = new System.Drawing.Size(146, 20);
            this.cbReintentarLlamado.TabIndex = 108;
            this.cbReintentarLlamado.Text = "Reintentar Llamado";
            this.cbReintentarLlamado.UseVisualStyleBackColor = false;
            // 
            // Llamada
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(778, 547);
            this.Controls.Add(this.xPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Llamada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Resultado de Llamada";
            this.Load += new System.EventHandler(this.ResultadoLlamada_Load);
            this.xPanel1.ResumeLayout(false);
            this.xPanel1.PerformLayout();
            this.pnlSeleccionTipo.ResumeLayout(false);
            this.pnlSeleccionTipo.PerformLayout();
            this.pnlLlamado.ResumeLayout(false);
            this.pnlLlamado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TNGS.NetControls.XPanel xPanel1;
        private TNGS.NetControls.FullLabel fullLabel3;
        private TNGS.NetControls.FullLabel fullLabel2;
        private TNGS.NetControls.FullLabel fullLabel1;
        private TNGS.NetControls.TimeEdit teHora;
        private System.Windows.Forms.MonthCalendar mcCalendar;
        private TNGS.NetControls.CDCombo cdcMotivos;
        private TNGS.NetControls.TextEdit teResultado;
        private TNGS.NetControls.GlassButton bCancelar;
        private TNGS.NetControls.GlassButton bAceptar;
        private System.Windows.Forms.RadioButton rbSalientes;
        private System.Windows.Forms.RadioButton rbEntrantes;
        private TNGS.NetControls.CDCombo cdcCategorias;
        private TNGS.NetControls.FullLabel fullLabel4;
        private TNGS.NetControls.GlassButton gbBaja;
        private System.Windows.Forms.Panel pnlSeleccionTipo;
        private System.Windows.Forms.Panel pnlLlamado;
        private TNGS.NetControls.GlassButton gbRecupero;
        private TNGS.NetControls.TextEdit teNTelefono;
        private TNGS.NetControls.FullLabel fullLabel6;
        private System.Windows.Forms.Button btnExit;
        private TNGS.NetControls.FullLabel fullLabel5;
        private System.Windows.Forms.DateTimePicker dtRellamada;
        private System.Windows.Forms.CheckBox cbRellamar;
        private System.Windows.Forms.CheckBox cbReintentarLlamado;
    }
}