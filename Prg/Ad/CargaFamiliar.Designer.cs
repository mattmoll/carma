namespace Carm.Ad
{
    partial class CargaFamiliar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CargaFamiliar));
            this.xPanel1 = new TNGS.NetControls.XPanel();
            this.gbCancel = new TNGS.NetControls.GlassButton();
            this.gbAccept = new TNGS.NetControls.GlassButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.fullLabel13 = new TNGS.NetControls.FullLabel();
            this.deFechaNacimiento = new TNGS.NetControls.DateEdit();
            this.neDocumento = new TNGS.NetControls.NumberEdit();
            this.cdcParentesco = new TNGS.NetControls.CDCombo();
            this.teObraSocial = new TNGS.NetControls.TextEdit();
            this.fullLabel5 = new TNGS.NetControls.FullLabel();
            this.teNombre = new TNGS.NetControls.TextEdit();
            this.fullLabel10 = new TNGS.NetControls.FullLabel();
            this.fullLabel8 = new TNGS.NetControls.FullLabel();
            this.teApellido = new TNGS.NetControls.TextEdit();
            this.fullLabel9 = new TNGS.NetControls.FullLabel();
            this.fullLabel1 = new TNGS.NetControls.FullLabel();
            this.fullLabel2 = new TNGS.NetControls.FullLabel();
            this.xPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xPanel1
            // 
            this.xPanel1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanel1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanel1.BorderColor = System.Drawing.Color.Black;
            this.xPanel1.Controls.Add(this.gbCancel);
            this.xPanel1.Controls.Add(this.gbAccept);
            this.xPanel1.Controls.Add(this.btnExit);
            this.xPanel1.Controls.Add(this.fullLabel13);
            this.xPanel1.Controls.Add(this.deFechaNacimiento);
            this.xPanel1.Controls.Add(this.neDocumento);
            this.xPanel1.Controls.Add(this.cdcParentesco);
            this.xPanel1.Controls.Add(this.teObraSocial);
            this.xPanel1.Controls.Add(this.fullLabel5);
            this.xPanel1.Controls.Add(this.teNombre);
            this.xPanel1.Controls.Add(this.fullLabel10);
            this.xPanel1.Controls.Add(this.fullLabel8);
            this.xPanel1.Controls.Add(this.teApellido);
            this.xPanel1.Controls.Add(this.fullLabel9);
            this.xPanel1.Controls.Add(this.fullLabel1);
            this.xPanel1.Controls.Add(this.fullLabel2);
            this.xPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xPanel1.Location = new System.Drawing.Point(0, 0);
            this.xPanel1.Name = "xPanel1";
            this.xPanel1.Size = new System.Drawing.Size(407, 361);
            this.xPanel1.SkinFixed = true;
            this.xPanel1.TabIndex = 0;
            // 
            // gbCancel
            // 
            this.gbCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbCancel.BackgroundImage")));
            this.gbCancel.BlackBorder = true;
            this.gbCancel.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbCancel.CircleButton = false;
            this.gbCancel.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Cancel;
            this.gbCancel.FlatColor = System.Drawing.Color.Red;
            this.gbCancel.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Cancelar;
            this.gbCancel.FlatFontSize = 9;
            this.gbCancel.FlatTextColor = System.Drawing.Color.Black;
            this.gbCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbCancel.Location = new System.Drawing.Point(27, 315);
            this.gbCancel.Name = "gbCancel";
            this.gbCancel.RoundCorners = 2;
            this.gbCancel.Size = new System.Drawing.Size(86, 25);
            this.gbCancel.TabIndex = 7;
            this.gbCancel.Text = "Cancelar";
            this.gbCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbCancel.W8Color = System.Drawing.Color.Red;
            this.gbCancel.Click += new System.EventHandler(this.gbCancel_Click);
            // 
            // gbAccept
            // 
            this.gbAccept.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbAccept.BackgroundImage")));
            this.gbAccept.BlackBorder = true;
            this.gbAccept.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbAccept.CircleButton = false;
            this.gbAccept.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Accept;
            this.gbAccept.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gbAccept.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Aceptar;
            this.gbAccept.FlatFontSize = 9;
            this.gbAccept.FlatTextColor = System.Drawing.Color.Black;
            this.gbAccept.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbAccept.Location = new System.Drawing.Point(295, 315);
            this.gbAccept.Name = "gbAccept";
            this.gbAccept.RoundCorners = 2;
            this.gbAccept.Size = new System.Drawing.Size(83, 25);
            this.gbAccept.TabIndex = 6;
            this.gbAccept.Text = "Grabar";
            this.gbAccept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbAccept.W8Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gbAccept.Click += new System.EventHandler(this.gbAccept_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(337, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(58, 40);
            this.btnExit.TabIndex = 101;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // fullLabel13
            // 
            this.fullLabel13.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel13.ForeColor = System.Drawing.Color.Black;
            this.fullLabel13.Location = new System.Drawing.Point(13, 209);
            this.fullLabel13.Name = "fullLabel13";
            this.fullLabel13.Size = new System.Drawing.Size(122, 19);
            this.fullLabel13.TabIndex = 96;
            this.fullLabel13.Text = "Fecha Nacimiento:";
            // 
            // deFechaNacimiento
            // 
            this.deFechaNacimiento.BackColor = System.Drawing.SystemColors.Window;
            this.deFechaNacimiento.EmptyValid = false;
            this.deFechaNacimiento.Location = new System.Drawing.Point(142, 209);
            this.deFechaNacimiento.Name = "deFechaNacimiento";
            this.deFechaNacimiento.Size = new System.Drawing.Size(100, 20);
            this.deFechaNacimiento.TabIndex = 4;
            this.deFechaNacimiento.Text = "01/01/1900";
            // 
            // neDocumento
            // 
            this.neDocumento.BackColor = System.Drawing.SystemColors.Window;
            this.neDocumento.Location = new System.Drawing.Point(142, 178);
            this.neDocumento.Name = "neDocumento";
            this.neDocumento.NegativeValid = false;
            this.neDocumento.Size = new System.Drawing.Size(100, 20);
            this.neDocumento.TabIndex = 3;
            this.neDocumento.Text = "0";
            this.neDocumento.ZeroValid = false;
            // 
            // cdcParentesco
            // 
            this.cdcParentesco.BackColor = System.Drawing.SystemColors.Window;
            this.cdcParentesco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdcParentesco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cdcParentesco.FormattingEnabled = true;
            this.cdcParentesco.Location = new System.Drawing.Point(142, 142);
            this.cdcParentesco.Name = "cdcParentesco";
            this.cdcParentesco.Size = new System.Drawing.Size(226, 21);
            this.cdcParentesco.Sorted = true;
            this.cdcParentesco.TabIndex = 2;
            // 
            // teObraSocial
            // 
            this.teObraSocial.BackColor = System.Drawing.SystemColors.Window;
            this.teObraSocial.Location = new System.Drawing.Point(142, 240);
            this.teObraSocial.Name = "teObraSocial";
            this.teObraSocial.Size = new System.Drawing.Size(216, 20);
            this.teObraSocial.TabIndex = 5;
            // 
            // fullLabel5
            // 
            this.fullLabel5.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.fullLabel5.Location = new System.Drawing.Point(50, 243);
            this.fullLabel5.Name = "fullLabel5";
            this.fullLabel5.Size = new System.Drawing.Size(100, 16);
            this.fullLabel5.TabIndex = 90;
            this.fullLabel5.Text = "Obra Social:";
            // 
            // teNombre
            // 
            this.teNombre.BackColor = System.Drawing.SystemColors.Window;
            this.teNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.teNombre.EmptyValid = false;
            this.teNombre.Location = new System.Drawing.Point(142, 79);
            this.teNombre.Name = "teNombre";
            this.teNombre.Size = new System.Drawing.Size(226, 20);
            this.teNombre.TabIndex = 0;
            // 
            // fullLabel10
            // 
            this.fullLabel10.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.fullLabel10.Location = new System.Drawing.Point(73, 79);
            this.fullLabel10.Name = "fullLabel10";
            this.fullLabel10.Size = new System.Drawing.Size(100, 16);
            this.fullLabel10.TabIndex = 82;
            this.fullLabel10.Text = "Nombre:";
            // 
            // fullLabel8
            // 
            this.fullLabel8.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.fullLabel8.Location = new System.Drawing.Point(54, 178);
            this.fullLabel8.Name = "fullLabel8";
            this.fullLabel8.Size = new System.Drawing.Size(115, 16);
            this.fullLabel8.TabIndex = 79;
            this.fullLabel8.Text = "Documento:";
            // 
            // teApellido
            // 
            this.teApellido.BackColor = System.Drawing.SystemColors.Window;
            this.teApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.teApellido.EmptyValid = false;
            this.teApellido.Location = new System.Drawing.Point(142, 110);
            this.teApellido.Name = "teApellido";
            this.teApellido.Size = new System.Drawing.Size(226, 20);
            this.teApellido.TabIndex = 1;
            // 
            // fullLabel9
            // 
            this.fullLabel9.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.fullLabel9.Location = new System.Drawing.Point(72, 111);
            this.fullLabel9.Name = "fullLabel9";
            this.fullLabel9.Size = new System.Drawing.Size(100, 16);
            this.fullLabel9.TabIndex = 78;
            this.fullLabel9.Text = "Apellido:";
            // 
            // fullLabel1
            // 
            this.fullLabel1.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel1.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel1.Location = new System.Drawing.Point(7, 9);
            this.fullLabel1.Name = "fullLabel1";
            this.fullLabel1.Size = new System.Drawing.Size(203, 32);
            this.fullLabel1.TabIndex = 71;
            this.fullLabel1.Text = "Carga de Familiar";
            this.fullLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fullLabel2
            // 
            this.fullLabel2.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.fullLabel2.Location = new System.Drawing.Point(54, 143);
            this.fullLabel2.Name = "fullLabel2";
            this.fullLabel2.Size = new System.Drawing.Size(115, 16);
            this.fullLabel2.TabIndex = 104;
            this.fullLabel2.Text = "Parentesco:";
            // 
            // CargaFamiliar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(407, 361);
            this.Controls.Add(this.xPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CargaFamiliar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Contacto";
            this.Load += new System.EventHandler(this.CargaFamiliar_Load);
            this.xPanel1.ResumeLayout(false);
            this.xPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TNGS.NetControls.XPanel xPanel1;
        private TNGS.NetControls.FullLabel fullLabel1;
        private TNGS.NetControls.TextEdit teNombre;
        private TNGS.NetControls.FullLabel fullLabel10;
        private TNGS.NetControls.FullLabel fullLabel8;
        private TNGS.NetControls.TextEdit teApellido;
        private TNGS.NetControls.FullLabel fullLabel9;
        private TNGS.NetControls.TextEdit teObraSocial;
        private TNGS.NetControls.FullLabel fullLabel5;
        private TNGS.NetControls.CDCombo cdcParentesco;
        private TNGS.NetControls.NumberEdit neDocumento;
        private TNGS.NetControls.FullLabel fullLabel13;
        private TNGS.NetControls.DateEdit deFechaNacimiento;
        private System.Windows.Forms.Button btnExit;
        private TNGS.NetControls.GlassButton gbCancel;
        private TNGS.NetControls.GlassButton gbAccept;
        private TNGS.NetControls.FullLabel fullLabel2;
    }
}