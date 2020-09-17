namespace Carm.Ad
{
    partial class ResultadoEntrevista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultadoEntrevista));
            this.xPanel1 = new TNGS.NetControls.XPanel();
            this.gbModificar = new TNGS.NetControls.GlassButton();
            this.mrCliEntrevistas = new TNGS.NetControls.MiniReport();
            this.imgGResultado = new TNGS.NetControls.ImgGroup();
            this.teHora = new TNGS.NetControls.TimeEdit();
            this.fullLabel6 = new TNGS.NetControls.FullLabel();
            this.gbCancelar = new TNGS.NetControls.GlassButton();
            this.gbContrato = new TNGS.NetControls.GlassButton();
            this.fullLabel5 = new TNGS.NetControls.FullLabel();
            this.gbGuardar = new TNGS.NetControls.GlassButton();
            this.fullLabel4 = new TNGS.NetControls.FullLabel();
            this.teInforme = new TNGS.NetControls.TextEdit();
            this.cdcResultados = new TNGS.NetControls.CDCombo();
            this.teMotivo = new TNGS.NetControls.TextEdit();
            this.fullLabel3 = new TNGS.NetControls.FullLabel();
            this.fullLabel2 = new TNGS.NetControls.FullLabel();
            this.mcFechaEntrev = new System.Windows.Forms.MonthCalendar();
            this.fullLabel1 = new TNGS.NetControls.FullLabel();
            this.xPanel1.SuspendLayout();
            this.imgGResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // xPanel1
            // 
            this.xPanel1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanel1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanel1.BorderColor = System.Drawing.Color.Black;
            this.xPanel1.Controls.Add(this.gbModificar);
            this.xPanel1.Controls.Add(this.mrCliEntrevistas);
            this.xPanel1.Controls.Add(this.imgGResultado);
            this.xPanel1.Controls.Add(this.fullLabel1);
            this.xPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xPanel1.Location = new System.Drawing.Point(0, 0);
            this.xPanel1.Name = "xPanel1";
            this.xPanel1.Size = new System.Drawing.Size(857, 497);
            this.xPanel1.SkinFixed = true;
            this.xPanel1.TabIndex = 1;
            // 
            // gbModificar
            // 
            this.gbModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbModificar.BackgroundImage")));
            this.gbModificar.BlackBorder = true;
            this.gbModificar.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbModificar.CircleButton = false;
            this.gbModificar.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Edit;
            this.gbModificar.FlatColor = System.Drawing.Color.DodgerBlue;
            this.gbModificar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.LightBlue;
            this.gbModificar.FlatFontSize = 9;
            this.gbModificar.FlatTextColor = System.Drawing.Color.Black;
            this.gbModificar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbModificar.Location = new System.Drawing.Point(745, 114);
            this.gbModificar.Name = "gbModificar";
            this.gbModificar.RoundCorners = 2;
            this.gbModificar.Size = new System.Drawing.Size(100, 55);
            this.gbModificar.TabIndex = 1;
            this.gbModificar.Text = "Modificar Primer Entrevista";
            this.gbModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbModificar.W8Color = System.Drawing.Color.DodgerBlue;
            this.gbModificar.Click += new System.EventHandler(this.gbModificar_Click);
            // 
            // mrCliEntrevistas
            // 
            this.mrCliEntrevistas.Enabled = false;
            this.mrCliEntrevistas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrCliEntrevistas.Location = new System.Drawing.Point(11, 26);
            this.mrCliEntrevistas.Name = "mrCliEntrevistas";
            this.mrCliEntrevistas.ShowExcel = false;
            this.mrCliEntrevistas.ShowPrtAll = false;
            this.mrCliEntrevistas.ShowPrtOne = false;
            this.mrCliEntrevistas.Size = new System.Drawing.Size(720, 188);
            this.mrCliEntrevistas.SkinFixed = true;
            this.mrCliEntrevistas.TabIndex = 0;
            this.mrCliEntrevistas.GetColor += new TNGS.NetRoutines.GetColorEventHandler(this.mrCliEntrevistas_GetColor);
            // 
            // imgGResultado
            // 
            this.imgGResultado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgGResultado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.imgGResultado.BackgroundGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.imgGResultado.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.ForwardDiagonal;
            this.imgGResultado.BlackBorder = true;
            this.imgGResultado.BorderColor = System.Drawing.Color.DodgerBlue;
            this.imgGResultado.BorderThickness = 1F;
            this.imgGResultado.Controls.Add(this.teHora);
            this.imgGResultado.Controls.Add(this.fullLabel6);
            this.imgGResultado.Controls.Add(this.gbCancelar);
            this.imgGResultado.Controls.Add(this.gbContrato);
            this.imgGResultado.Controls.Add(this.fullLabel5);
            this.imgGResultado.Controls.Add(this.gbGuardar);
            this.imgGResultado.Controls.Add(this.fullLabel4);
            this.imgGResultado.Controls.Add(this.teInforme);
            this.imgGResultado.Controls.Add(this.cdcResultados);
            this.imgGResultado.Controls.Add(this.teMotivo);
            this.imgGResultado.Controls.Add(this.fullLabel3);
            this.imgGResultado.Controls.Add(this.fullLabel2);
            this.imgGResultado.Controls.Add(this.mcFechaEntrev);
            this.imgGResultado.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.imgGResultado.Enabled = false;
            this.imgGResultado.FlatMode = true;
            this.imgGResultado.FontTitle = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgGResultado.ForeColor = System.Drawing.Color.Black;
            this.imgGResultado.GroupImage = null;
            this.imgGResultado.GroupTitle = "Resultado";
            this.imgGResultado.Location = new System.Drawing.Point(11, 220);
            this.imgGResultado.Name = "imgGResultado";
            this.imgGResultado.Padding = new System.Windows.Forms.Padding(20);
            this.imgGResultado.PaintGroupBox = false;
            this.imgGResultado.RoundCorners = 4;
            this.imgGResultado.ShadowColor = System.Drawing.Color.DarkGray;
            this.imgGResultado.ShadowControl = false;
            this.imgGResultado.ShadowThickness = 3;
            this.imgGResultado.Size = new System.Drawing.Size(838, 265);
            this.imgGResultado.SkinFixed = true;
            this.imgGResultado.TabIndex = 3;
            this.imgGResultado.TitleBackground = System.Drawing.Color.DodgerBlue;
            this.imgGResultado.TitleBackgroundDefault = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.imgGResultado.TitleFontColor = System.Drawing.Color.White;
            // 
            // teHora
            // 
            this.teHora.BackColor = System.Drawing.SystemColors.Window;
            this.teHora.Location = new System.Drawing.Point(489, 63);
            this.teHora.MaxLength = 5;
            this.teHora.Name = "teHora";
            this.teHora.Size = new System.Drawing.Size(43, 20);
            this.teHora.TabIndex = 11;
            this.teHora.Text = "  :  ";
            // 
            // fullLabel6
            // 
            this.fullLabel6.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel6.Location = new System.Drawing.Point(287, 33);
            this.fullLabel6.Name = "fullLabel6";
            this.fullLabel6.Size = new System.Drawing.Size(102, 21);
            this.fullLabel6.TabIndex = 10;
            this.fullLabel6.Text = "Hora realizada:";
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
            this.gbCancelar.Location = new System.Drawing.Point(732, 232);
            this.gbCancelar.Name = "gbCancelar";
            this.gbCancelar.RoundCorners = 2;
            this.gbCancelar.Size = new System.Drawing.Size(85, 25);
            this.gbCancelar.TabIndex = 6;
            this.gbCancelar.Text = "Cerrar";
            this.gbCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbCancelar.W8Color = System.Drawing.Color.Red;
            this.gbCancelar.Click += new System.EventHandler(this.gbCancelar_Click);
            // 
            // gbContrato
            // 
            this.gbContrato.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbContrato.BackgroundImage")));
            this.gbContrato.BlackBorder = true;
            this.gbContrato.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbContrato.CircleButton = false;
            this.gbContrato.Enabled = false;
            this.gbContrato.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Money;
            this.gbContrato.FlatColor = System.Drawing.Color.DodgerBlue;
            this.gbContrato.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.LightBlue;
            this.gbContrato.FlatFontSize = 9;
            this.gbContrato.FlatTextColor = System.Drawing.Color.Black;
            this.gbContrato.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbContrato.Location = new System.Drawing.Point(395, 232);
            this.gbContrato.Name = "gbContrato";
            this.gbContrato.RoundCorners = 2;
            this.gbContrato.Size = new System.Drawing.Size(137, 25);
            this.gbContrato.TabIndex = 4;
            this.gbContrato.Text = "Generar Contrato";
            this.gbContrato.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbContrato.W8Color = System.Drawing.Color.DodgerBlue;
            this.gbContrato.Click += new System.EventHandler(this.gbContrato_Click);
            // 
            // fullLabel5
            // 
            this.fullLabel5.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel5.Location = new System.Drawing.Point(571, 99);
            this.fullLabel5.Name = "fullLabel5";
            this.fullLabel5.Size = new System.Drawing.Size(152, 21);
            this.fullLabel5.TabIndex = 8;
            this.fullLabel5.Text = "Informe:";
            // 
            // gbGuardar
            // 
            this.gbGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbGuardar.BackgroundImage")));
            this.gbGuardar.BlackBorder = true;
            this.gbGuardar.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbGuardar.CircleButton = false;
            this.gbGuardar.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Save;
            this.gbGuardar.FlatColor = System.Drawing.Color.DodgerBlue;
            this.gbGuardar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.LightBlue;
            this.gbGuardar.FlatFontSize = 9;
            this.gbGuardar.FlatTextColor = System.Drawing.Color.Black;
            this.gbGuardar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbGuardar.Location = new System.Drawing.Point(592, 232);
            this.gbGuardar.Name = "gbGuardar";
            this.gbGuardar.RoundCorners = 2;
            this.gbGuardar.Size = new System.Drawing.Size(80, 25);
            this.gbGuardar.TabIndex = 5;
            this.gbGuardar.Text = "Grabar";
            this.gbGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbGuardar.W8Color = System.Drawing.Color.DodgerBlue;
            this.gbGuardar.Click += new System.EventHandler(this.gbGuardar_Click);
            // 
            // fullLabel4
            // 
            this.fullLabel4.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel4.Location = new System.Drawing.Point(571, 33);
            this.fullLabel4.Name = "fullLabel4";
            this.fullLabel4.Size = new System.Drawing.Size(152, 21);
            this.fullLabel4.TabIndex = 7;
            this.fullLabel4.Text = "Resultado:";
            // 
            // teInforme
            // 
            this.teInforme.BackColor = System.Drawing.SystemColors.Window;
            this.teInforme.Location = new System.Drawing.Point(592, 125);
            this.teInforme.MaxLength = 60;
            this.teInforme.Multiline = true;
            this.teInforme.Name = "teInforme";
            this.teInforme.Size = new System.Drawing.Size(225, 100);
            this.teInforme.TabIndex = 3;
            // 
            // cdcResultados
            // 
            this.cdcResultados.BackColor = System.Drawing.SystemColors.Window;
            this.cdcResultados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdcResultados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cdcResultados.FormattingEnabled = true;
            this.cdcResultados.Location = new System.Drawing.Point(592, 63);
            this.cdcResultados.Name = "cdcResultados";
            this.cdcResultados.Size = new System.Drawing.Size(225, 21);
            this.cdcResultados.Sorted = true;
            this.cdcResultados.TabIndex = 2;
            this.cdcResultados.SelectedIndexChanged += new System.EventHandler(this.cdcResultados_SelectedIndexChanged);
            // 
            // teMotivo
            // 
            this.teMotivo.BackColor = System.Drawing.SystemColors.Window;
            this.teMotivo.EmptyValid = false;
            this.teMotivo.Enabled = false;
            this.teMotivo.Location = new System.Drawing.Point(307, 125);
            this.teMotivo.MaxLength = 60;
            this.teMotivo.Multiline = true;
            this.teMotivo.Name = "teMotivo";
            this.teMotivo.Size = new System.Drawing.Size(225, 100);
            this.teMotivo.TabIndex = 1;
            // 
            // fullLabel3
            // 
            this.fullLabel3.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel3.Location = new System.Drawing.Point(287, 99);
            this.fullLabel3.Name = "fullLabel3";
            this.fullLabel3.Size = new System.Drawing.Size(178, 21);
            this.fullLabel3.TabIndex = 3;
            this.fullLabel3.Text = "Motivo de cambio de fecha:";
            // 
            // fullLabel2
            // 
            this.fullLabel2.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel2.Location = new System.Drawing.Point(26, 33);
            this.fullLabel2.Name = "fullLabel2";
            this.fullLabel2.Size = new System.Drawing.Size(131, 21);
            this.fullLabel2.TabIndex = 2;
            this.fullLabel2.Text = "Fecha realizada:";
            // 
            // mcFechaEntrev
            // 
            this.mcFechaEntrev.Location = new System.Drawing.Point(39, 63);
            this.mcFechaEntrev.Name = "mcFechaEntrev";
            this.mcFechaEntrev.TabIndex = 0;
            // 
            // fullLabel1
            // 
            this.fullLabel1.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel1.Location = new System.Drawing.Point(16, 8);
            this.fullLabel1.Name = "fullLabel1";
            this.fullLabel1.Size = new System.Drawing.Size(266, 21);
            this.fullLabel1.TabIndex = 1;
            this.fullLabel1.Text = "Clientes con Entrevistas incompletas:";
            // 
            // ResultadoEntrevista
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(857, 497);
            this.Controls.Add(this.xPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResultadoEntrevista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ResultadoEntrevista";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ResultadoEntrevista_FormClosing);
            this.Load += new System.EventHandler(this.ResultadoEntrevista_Load);
            this.xPanel1.ResumeLayout(false);
            this.imgGResultado.ResumeLayout(false);
            this.imgGResultado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TNGS.NetControls.XPanel xPanel1;
        private TNGS.NetControls.GlassButton gbModificar;
        private TNGS.NetControls.MiniReport mrCliEntrevistas;
        private TNGS.NetControls.ImgGroup imgGResultado;
        private TNGS.NetControls.TimeEdit teHora;
        private TNGS.NetControls.FullLabel fullLabel6;
        private TNGS.NetControls.GlassButton gbCancelar;
        private TNGS.NetControls.GlassButton gbContrato;
        private TNGS.NetControls.FullLabel fullLabel5;
        private TNGS.NetControls.GlassButton gbGuardar;
        private TNGS.NetControls.FullLabel fullLabel4;
        private TNGS.NetControls.TextEdit teInforme;
        private TNGS.NetControls.CDCombo cdcResultados;
        private TNGS.NetControls.TextEdit teMotivo;
        private TNGS.NetControls.FullLabel fullLabel3;
        private TNGS.NetControls.FullLabel fullLabel2;
        private System.Windows.Forms.MonthCalendar mcFechaEntrev;
        private TNGS.NetControls.FullLabel fullLabel1;
    }
}