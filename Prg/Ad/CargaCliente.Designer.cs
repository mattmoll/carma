using System;

namespace Carm.Ad
{
    partial class CargaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CargaCliente));
            this.xPanel1 = new TNGS.NetControls.XPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbLimpiarTodo = new TNGS.NetControls.GlassButton();
            this.tgrpDatosBasicos = new TNGS.NetControls.ImgGroup();
            this.gbCargarLocalidad = new TNGS.NetControls.GlassButton();
            this.cdcFranquicia = new TNGS.NetControls.CDCombo();
            this.fullLabel10 = new TNGS.NetControls.FullLabel();
            this.teZona = new TNGS.NetControls.TextEdit();
            this.fullLabel9 = new TNGS.NetControls.FullLabel();
            this.teProvincia = new TNGS.NetControls.TextEdit();
            this.fullLabel8 = new TNGS.NetControls.FullLabel();
            this.tePartido = new TNGS.NetControls.TextEdit();
            this.fullLabel7 = new TNGS.NetControls.FullLabel();
            this.teLocalidad = new TNGS.NetControls.TextEdit();
            this.fullLabel3 = new TNGS.NetControls.FullLabel();
            this.teEmail = new TNGS.NetControls.TextEdit();
            this.fullLabel1 = new TNGS.NetControls.FullLabel();
            this.teTelefono = new TNGS.NetControls.TextEdit();
            this.fullLabel6 = new TNGS.NetControls.FullLabel();
            this.teCelular = new TNGS.NetControls.TextEdit();
            this.fullLabel5 = new TNGS.NetControls.FullLabel();
            this.tePaginaWeb = new TNGS.NetControls.TextEdit();
            this.fullLabel4 = new TNGS.NetControls.FullLabel();
            this.teRazonSocial = new TNGS.NetControls.TextEdit();
            this.teDireccion = new TNGS.NetControls.TextEdit();
            this.tePisoDepto = new TNGS.NetControls.TextEdit();
            this.neAltura = new TNGS.NetControls.NumberEdit();
            this.fullLabel2 = new TNGS.NetControls.FullLabel();
            this.cdcTipoCliente = new TNGS.NetControls.CDCombo();
            this.teNombreFantasia = new TNGS.NetControls.TextEdit();
            this.lblRazonSocial = new TNGS.NetControls.FullLabel();
            this.teAnotaciones = new TNGS.NetControls.TextEdit();
            this.lblNroChasis = new TNGS.NetControls.FullLabel();
            this.lblDescripcionMovil = new TNGS.NetControls.FullLabel();
            this.lblAnioFabricacion = new TNGS.NetControls.FullLabel();
            this.lblNroMotor = new TNGS.NetControls.FullLabel();
            this.lblAnotaciones = new TNGS.NetControls.FullLabel();
            this.gbGrabar = new TNGS.NetControls.GlassButton();
            this.xPanel1.SuspendLayout();
            this.tgrpDatosBasicos.SuspendLayout();
            this.SuspendLayout();
            // 
            // xPanel1
            // 
            this.xPanel1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanel1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanel1.BorderColor = System.Drawing.Color.Black;
            this.xPanel1.Controls.Add(this.btnExit);
            this.xPanel1.Controls.Add(this.gbLimpiarTodo);
            this.xPanel1.Controls.Add(this.tgrpDatosBasicos);
            this.xPanel1.Controls.Add(this.gbGrabar);
            this.xPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xPanel1.Location = new System.Drawing.Point(0, 0);
            this.xPanel1.Name = "xPanel1";
            this.xPanel1.Size = new System.Drawing.Size(1008, 550);
            this.xPanel1.SkinFixed = true;
            this.xPanel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(942, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(58, 40);
            this.btnExit.TabIndex = 4;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbLimpiarTodo
            // 
            this.gbLimpiarTodo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbLimpiarTodo.BackgroundImage")));
            this.gbLimpiarTodo.BlackBorder = true;
            this.gbLimpiarTodo.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbLimpiarTodo.CircleButton = false;
            this.gbLimpiarTodo.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Delete;
            this.gbLimpiarTodo.FlatColor = System.Drawing.Color.DodgerBlue;
            this.gbLimpiarTodo.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.LightBlue;
            this.gbLimpiarTodo.FlatFontSize = 9;
            this.gbLimpiarTodo.FlatTextColor = System.Drawing.Color.Black;
            this.gbLimpiarTodo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbLimpiarTodo.Location = new System.Drawing.Point(15, 12);
            this.gbLimpiarTodo.Name = "gbLimpiarTodo";
            this.gbLimpiarTodo.RoundCorners = 2;
            this.gbLimpiarTodo.Size = new System.Drawing.Size(99, 55);
            this.gbLimpiarTodo.TabIndex = 3;
            this.gbLimpiarTodo.Text = "Limpiar Campos";
            this.gbLimpiarTodo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbLimpiarTodo.W8Color = System.Drawing.Color.DodgerBlue;
            this.gbLimpiarTodo.Click += new System.EventHandler(this.btnLimpiarTodo_Click);
            // 
            // tgrpDatosBasicos
            // 
            this.tgrpDatosBasicos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tgrpDatosBasicos.BackgroundGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tgrpDatosBasicos.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.ForwardDiagonal;
            this.tgrpDatosBasicos.BlackBorder = true;
            this.tgrpDatosBasicos.BorderColor = System.Drawing.Color.DodgerBlue;
            this.tgrpDatosBasicos.BorderThickness = 1F;
            this.tgrpDatosBasicos.Controls.Add(this.gbCargarLocalidad);
            this.tgrpDatosBasicos.Controls.Add(this.cdcFranquicia);
            this.tgrpDatosBasicos.Controls.Add(this.fullLabel10);
            this.tgrpDatosBasicos.Controls.Add(this.teZona);
            this.tgrpDatosBasicos.Controls.Add(this.fullLabel9);
            this.tgrpDatosBasicos.Controls.Add(this.teProvincia);
            this.tgrpDatosBasicos.Controls.Add(this.fullLabel8);
            this.tgrpDatosBasicos.Controls.Add(this.tePartido);
            this.tgrpDatosBasicos.Controls.Add(this.fullLabel7);
            this.tgrpDatosBasicos.Controls.Add(this.teLocalidad);
            this.tgrpDatosBasicos.Controls.Add(this.fullLabel3);
            this.tgrpDatosBasicos.Controls.Add(this.teEmail);
            this.tgrpDatosBasicos.Controls.Add(this.fullLabel1);
            this.tgrpDatosBasicos.Controls.Add(this.teTelefono);
            this.tgrpDatosBasicos.Controls.Add(this.fullLabel6);
            this.tgrpDatosBasicos.Controls.Add(this.teCelular);
            this.tgrpDatosBasicos.Controls.Add(this.fullLabel5);
            this.tgrpDatosBasicos.Controls.Add(this.tePaginaWeb);
            this.tgrpDatosBasicos.Controls.Add(this.fullLabel4);
            this.tgrpDatosBasicos.Controls.Add(this.teRazonSocial);
            this.tgrpDatosBasicos.Controls.Add(this.teDireccion);
            this.tgrpDatosBasicos.Controls.Add(this.tePisoDepto);
            this.tgrpDatosBasicos.Controls.Add(this.neAltura);
            this.tgrpDatosBasicos.Controls.Add(this.fullLabel2);
            this.tgrpDatosBasicos.Controls.Add(this.cdcTipoCliente);
            this.tgrpDatosBasicos.Controls.Add(this.teNombreFantasia);
            this.tgrpDatosBasicos.Controls.Add(this.lblRazonSocial);
            this.tgrpDatosBasicos.Controls.Add(this.teAnotaciones);
            this.tgrpDatosBasicos.Controls.Add(this.lblNroChasis);
            this.tgrpDatosBasicos.Controls.Add(this.lblDescripcionMovil);
            this.tgrpDatosBasicos.Controls.Add(this.lblAnioFabricacion);
            this.tgrpDatosBasicos.Controls.Add(this.lblNroMotor);
            this.tgrpDatosBasicos.Controls.Add(this.lblAnotaciones);
            this.tgrpDatosBasicos.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tgrpDatosBasicos.FlatMode = true;
            this.tgrpDatosBasicos.Font = new System.Drawing.Font("Arial", 9F);
            this.tgrpDatosBasicos.FontTitle = new System.Drawing.Font("Arial", 9F);
            this.tgrpDatosBasicos.ForeColor = System.Drawing.Color.Black;
            this.tgrpDatosBasicos.GroupImage = null;
            this.tgrpDatosBasicos.GroupTitle = "Datos Cliente";
            this.tgrpDatosBasicos.Location = new System.Drawing.Point(15, 84);
            this.tgrpDatosBasicos.Name = "tgrpDatosBasicos";
            this.tgrpDatosBasicos.Padding = new System.Windows.Forms.Padding(20);
            this.tgrpDatosBasicos.PaintGroupBox = false;
            this.tgrpDatosBasicos.RoundCorners = 4;
            this.tgrpDatosBasicos.ShadowColor = System.Drawing.Color.DarkGray;
            this.tgrpDatosBasicos.ShadowControl = false;
            this.tgrpDatosBasicos.ShadowThickness = 3;
            this.tgrpDatosBasicos.Size = new System.Drawing.Size(981, 457);
            this.tgrpDatosBasicos.SkinFixed = true;
            this.tgrpDatosBasicos.TabIndex = 0;
            this.tgrpDatosBasicos.TitleBackground = System.Drawing.Color.DarkGreen;
            this.tgrpDatosBasicos.TitleBackgroundDefault = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.tgrpDatosBasicos.TitleFontColor = System.Drawing.Color.White;
            // 
            // gbCargarLocalidad
            // 
            this.gbCargarLocalidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCargarLocalidad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbCargarLocalidad.BackgroundImage")));
            this.gbCargarLocalidad.BlackBorder = true;
            this.gbCargarLocalidad.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbCargarLocalidad.CircleButton = false;
            this.gbCargarLocalidad.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.fSearch;
            this.gbCargarLocalidad.FlatColor = System.Drawing.Color.DodgerBlue;
            this.gbCargarLocalidad.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.LightBlue;
            this.gbCargarLocalidad.FlatFontSize = 9;
            this.gbCargarLocalidad.FlatTextColor = System.Drawing.Color.Black;
            this.gbCargarLocalidad.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbCargarLocalidad.Location = new System.Drawing.Point(504, 156);
            this.gbCargarLocalidad.Name = "gbCargarLocalidad";
            this.gbCargarLocalidad.PCode = "TNGS.EXCEL";
            this.gbCargarLocalidad.RoundCorners = 2;
            this.gbCargarLocalidad.Size = new System.Drawing.Size(26, 24);
            this.gbCargarLocalidad.TabIndex = 43;
            this.gbCargarLocalidad.W8Color = System.Drawing.Color.DodgerBlue;
            // 
            // cdcFranquicia
            // 
            this.cdcFranquicia.BackColor = System.Drawing.SystemColors.Window;
            this.cdcFranquicia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdcFranquicia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cdcFranquicia.FormattingEnabled = true;
            this.cdcFranquicia.Location = new System.Drawing.Point(176, 274);
            this.cdcFranquicia.Name = "cdcFranquicia";
            this.cdcFranquicia.Size = new System.Drawing.Size(276, 23);
            this.cdcFranquicia.Sorted = true;
            this.cdcFranquicia.TabIndex = 41;
            // 
            // fullLabel10
            // 
            this.fullLabel10.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel10.ForeColor = System.Drawing.Color.Black;
            this.fullLabel10.Location = new System.Drawing.Point(70, 278);
            this.fullLabel10.Name = "fullLabel10";
            this.fullLabel10.Size = new System.Drawing.Size(96, 18);
            this.fullLabel10.TabIndex = 42;
            this.fullLabel10.Text = "Franquicia:";
            // 
            // teZona
            // 
            this.teZona.BackColor = System.Drawing.SystemColors.Window;
            this.teZona.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.teZona.Location = new System.Drawing.Point(618, 277);
            this.teZona.Name = "teZona";
            this.teZona.ReadOnly = true;
            this.teZona.Size = new System.Drawing.Size(276, 21);
            this.teZona.TabIndex = 39;
            this.teZona.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // fullLabel9
            // 
            this.fullLabel9.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel9.ForeColor = System.Drawing.Color.Black;
            this.fullLabel9.Location = new System.Drawing.Point(551, 279);
            this.fullLabel9.Name = "fullLabel9";
            this.fullLabel9.Size = new System.Drawing.Size(61, 18);
            this.fullLabel9.TabIndex = 40;
            this.fullLabel9.Text = "Zona:";
            // 
            // teProvincia
            // 
            this.teProvincia.BackColor = System.Drawing.SystemColors.Window;
            this.teProvincia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.teProvincia.Location = new System.Drawing.Point(618, 236);
            this.teProvincia.Name = "teProvincia";
            this.teProvincia.ReadOnly = true;
            this.teProvincia.Size = new System.Drawing.Size(276, 21);
            this.teProvincia.TabIndex = 37;
            this.teProvincia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // fullLabel8
            // 
            this.fullLabel8.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel8.ForeColor = System.Drawing.Color.Black;
            this.fullLabel8.Location = new System.Drawing.Point(536, 238);
            this.fullLabel8.Name = "fullLabel8";
            this.fullLabel8.Size = new System.Drawing.Size(76, 18);
            this.fullLabel8.TabIndex = 38;
            this.fullLabel8.Text = "Provincia:";
            // 
            // tePartido
            // 
            this.tePartido.BackColor = System.Drawing.SystemColors.Window;
            this.tePartido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tePartido.Location = new System.Drawing.Point(618, 200);
            this.tePartido.Name = "tePartido";
            this.tePartido.ReadOnly = true;
            this.tePartido.Size = new System.Drawing.Size(276, 21);
            this.tePartido.TabIndex = 35;
            this.tePartido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // fullLabel7
            // 
            this.fullLabel7.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel7.ForeColor = System.Drawing.Color.Black;
            this.fullLabel7.Location = new System.Drawing.Point(536, 202);
            this.fullLabel7.Name = "fullLabel7";
            this.fullLabel7.Size = new System.Drawing.Size(76, 18);
            this.fullLabel7.TabIndex = 36;
            this.fullLabel7.Text = "Partido:";
            // 
            // teLocalidad
            // 
            this.teLocalidad.BackColor = System.Drawing.SystemColors.Window;
            this.teLocalidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.teLocalidad.Location = new System.Drawing.Point(618, 160);
            this.teLocalidad.Name = "teLocalidad";
            this.teLocalidad.ReadOnly = true;
            this.teLocalidad.Size = new System.Drawing.Size(276, 21);
            this.teLocalidad.TabIndex = 33;
            this.teLocalidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // fullLabel3
            // 
            this.fullLabel3.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel3.ForeColor = System.Drawing.Color.Black;
            this.fullLabel3.Location = new System.Drawing.Point(536, 162);
            this.fullLabel3.Name = "fullLabel3";
            this.fullLabel3.Size = new System.Drawing.Size(76, 18);
            this.fullLabel3.TabIndex = 34;
            this.fullLabel3.Text = "Localidad:";
            // 
            // teEmail
            // 
            this.teEmail.BackColor = System.Drawing.SystemColors.Window;
            this.teEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.teEmail.Location = new System.Drawing.Point(618, 122);
            this.teEmail.Name = "teEmail";
            this.teEmail.Size = new System.Drawing.Size(276, 21);
            this.teEmail.TabIndex = 31;
            this.teEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // fullLabel1
            // 
            this.fullLabel1.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel1.ForeColor = System.Drawing.Color.Black;
            this.fullLabel1.Location = new System.Drawing.Point(558, 124);
            this.fullLabel1.Name = "fullLabel1";
            this.fullLabel1.Size = new System.Drawing.Size(54, 18);
            this.fullLabel1.TabIndex = 32;
            this.fullLabel1.Text = "Email:";
            // 
            // teTelefono
            // 
            this.teTelefono.BackColor = System.Drawing.SystemColors.Window;
            this.teTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.teTelefono.Location = new System.Drawing.Point(618, 86);
            this.teTelefono.Name = "teTelefono";
            this.teTelefono.Size = new System.Drawing.Size(276, 21);
            this.teTelefono.TabIndex = 29;
            this.teTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // fullLabel6
            // 
            this.fullLabel6.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel6.ForeColor = System.Drawing.Color.Black;
            this.fullLabel6.Location = new System.Drawing.Point(521, 88);
            this.fullLabel6.Name = "fullLabel6";
            this.fullLabel6.Size = new System.Drawing.Size(91, 18);
            this.fullLabel6.TabIndex = 30;
            this.fullLabel6.Text = "1er Teléfono:";
            // 
            // teCelular
            // 
            this.teCelular.BackColor = System.Drawing.SystemColors.Window;
            this.teCelular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.teCelular.Location = new System.Drawing.Point(618, 49);
            this.teCelular.Name = "teCelular";
            this.teCelular.Size = new System.Drawing.Size(276, 21);
            this.teCelular.TabIndex = 27;
            this.teCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // fullLabel5
            // 
            this.fullLabel5.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel5.ForeColor = System.Drawing.Color.Black;
            this.fullLabel5.Location = new System.Drawing.Point(548, 49);
            this.fullLabel5.Name = "fullLabel5";
            this.fullLabel5.Size = new System.Drawing.Size(64, 18);
            this.fullLabel5.TabIndex = 28;
            this.fullLabel5.Text = "Celular:";
            // 
            // tePaginaWeb
            // 
            this.tePaginaWeb.BackColor = System.Drawing.SystemColors.Window;
            this.tePaginaWeb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tePaginaWeb.Location = new System.Drawing.Point(176, 237);
            this.tePaginaWeb.Name = "tePaginaWeb";
            this.tePaginaWeb.Size = new System.Drawing.Size(276, 21);
            this.tePaginaWeb.TabIndex = 25;
            this.tePaginaWeb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // fullLabel4
            // 
            this.fullLabel4.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel4.ForeColor = System.Drawing.Color.Black;
            this.fullLabel4.Location = new System.Drawing.Point(63, 239);
            this.fullLabel4.Name = "fullLabel4";
            this.fullLabel4.Size = new System.Drawing.Size(97, 18);
            this.fullLabel4.TabIndex = 26;
            this.fullLabel4.Text = "Página Web:";
            // 
            // teRazonSocial
            // 
            this.teRazonSocial.BackColor = System.Drawing.SystemColors.Window;
            this.teRazonSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.teRazonSocial.Location = new System.Drawing.Point(177, 49);
            this.teRazonSocial.MaxLength = 8;
            this.teRazonSocial.Name = "teRazonSocial";
            this.teRazonSocial.Size = new System.Drawing.Size(275, 21);
            this.teRazonSocial.TabIndex = 0;
            this.teRazonSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // teDireccion
            // 
            this.teDireccion.BackColor = System.Drawing.SystemColors.Window;
            this.teDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.teDireccion.Location = new System.Drawing.Point(176, 161);
            this.teDireccion.Name = "teDireccion";
            this.teDireccion.Size = new System.Drawing.Size(276, 21);
            this.teDireccion.TabIndex = 4;
            this.teDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tePisoDepto
            // 
            this.tePisoDepto.BackColor = System.Drawing.SystemColors.Window;
            this.tePisoDepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tePisoDepto.Location = new System.Drawing.Point(339, 200);
            this.tePisoDepto.MaxLength = 8;
            this.tePisoDepto.Name = "tePisoDepto";
            this.tePisoDepto.Size = new System.Drawing.Size(113, 21);
            this.tePisoDepto.TabIndex = 8;
            this.tePisoDepto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // neAltura
            // 
            this.neAltura.BackColor = System.Drawing.SystemColors.Window;
            this.neAltura.Location = new System.Drawing.Point(177, 201);
            this.neAltura.Name = "neAltura";
            this.neAltura.Size = new System.Drawing.Size(75, 21);
            this.neAltura.TabIndex = 5;
            this.neAltura.Text = "0";
            // 
            // fullLabel2
            // 
            this.fullLabel2.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel2.ForeColor = System.Drawing.Color.Black;
            this.fullLabel2.Location = new System.Drawing.Point(268, 203);
            this.fullLabel2.Name = "fullLabel2";
            this.fullLabel2.Size = new System.Drawing.Size(79, 18);
            this.fullLabel2.TabIndex = 22;
            this.fullLabel2.Text = "Piso/Dpto: ";
            // 
            // cdcTipoCliente
            // 
            this.cdcTipoCliente.BackColor = System.Drawing.SystemColors.Window;
            this.cdcTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdcTipoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cdcTipoCliente.FormattingEnabled = true;
            this.cdcTipoCliente.Location = new System.Drawing.Point(176, 122);
            this.cdcTipoCliente.Name = "cdcTipoCliente";
            this.cdcTipoCliente.Size = new System.Drawing.Size(276, 23);
            this.cdcTipoCliente.Sorted = true;
            this.cdcTipoCliente.TabIndex = 3;
            // 
            // teNombreFantasia
            // 
            this.teNombreFantasia.BackColor = System.Drawing.SystemColors.Window;
            this.teNombreFantasia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.teNombreFantasia.Location = new System.Drawing.Point(176, 86);
            this.teNombreFantasia.Name = "teNombreFantasia";
            this.teNombreFantasia.Size = new System.Drawing.Size(276, 21);
            this.teNombreFantasia.TabIndex = 1;
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.BackColor = System.Drawing.Color.Transparent;
            this.lblRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocial.ForeColor = System.Drawing.Color.Black;
            this.lblRazonSocial.Location = new System.Drawing.Point(60, 51);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(104, 18);
            this.lblRazonSocial.TabIndex = 6;
            this.lblRazonSocial.Text = "Razón Social:";
            // 
            // teAnotaciones
            // 
            this.teAnotaciones.BackColor = System.Drawing.SystemColors.Window;
            this.teAnotaciones.Location = new System.Drawing.Point(34, 359);
            this.teAnotaciones.Multiline = true;
            this.teAnotaciones.Name = "teAnotaciones";
            this.teAnotaciones.Size = new System.Drawing.Size(916, 81);
            this.teAnotaciones.TabIndex = 10;
            // 
            // lblNroChasis
            // 
            this.lblNroChasis.BackColor = System.Drawing.Color.Transparent;
            this.lblNroChasis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroChasis.ForeColor = System.Drawing.Color.Black;
            this.lblNroChasis.Location = new System.Drawing.Point(70, 126);
            this.lblNroChasis.Name = "lblNroChasis";
            this.lblNroChasis.Size = new System.Drawing.Size(96, 18);
            this.lblNroChasis.TabIndex = 14;
            this.lblNroChasis.Text = "Tipo Cliente:";
            // 
            // lblDescripcionMovil
            // 
            this.lblDescripcionMovil.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcionMovil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionMovil.ForeColor = System.Drawing.Color.Black;
            this.lblDescripcionMovil.Location = new System.Drawing.Point(38, 86);
            this.lblDescripcionMovil.Name = "lblDescripcionMovil";
            this.lblDescripcionMovil.Size = new System.Drawing.Size(122, 19);
            this.lblDescripcionMovil.TabIndex = 10;
            this.lblDescripcionMovil.Text = "Nombre Fantasía:";
            // 
            // lblAnioFabricacion
            // 
            this.lblAnioFabricacion.BackColor = System.Drawing.Color.Transparent;
            this.lblAnioFabricacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnioFabricacion.ForeColor = System.Drawing.Color.Black;
            this.lblAnioFabricacion.Location = new System.Drawing.Point(106, 203);
            this.lblAnioFabricacion.Name = "lblAnioFabricacion";
            this.lblAnioFabricacion.Size = new System.Drawing.Size(67, 18);
            this.lblAnioFabricacion.TabIndex = 17;
            this.lblAnioFabricacion.Text = "Altura:";
            // 
            // lblNroMotor
            // 
            this.lblNroMotor.BackColor = System.Drawing.Color.Transparent;
            this.lblNroMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroMotor.ForeColor = System.Drawing.Color.Black;
            this.lblNroMotor.Location = new System.Drawing.Point(85, 163);
            this.lblNroMotor.Name = "lblNroMotor";
            this.lblNroMotor.Size = new System.Drawing.Size(75, 18);
            this.lblNroMotor.TabIndex = 15;
            this.lblNroMotor.Text = "Dirección:";
            // 
            // lblAnotaciones
            // 
            this.lblAnotaciones.BackColor = System.Drawing.Color.Transparent;
            this.lblAnotaciones.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnotaciones.ForeColor = System.Drawing.Color.Black;
            this.lblAnotaciones.Location = new System.Drawing.Point(43, 338);
            this.lblAnotaciones.Name = "lblAnotaciones";
            this.lblAnotaciones.Size = new System.Drawing.Size(117, 18);
            this.lblAnotaciones.TabIndex = 13;
            this.lblAnotaciones.Text = "Anotaciones:";
            // 
            // gbGrabar
            // 
            this.gbGrabar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbGrabar.BackgroundImage")));
            this.gbGrabar.BlackBorder = true;
            this.gbGrabar.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbGrabar.CircleButton = false;
            this.gbGrabar.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Save;
            this.gbGrabar.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gbGrabar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Aceptar;
            this.gbGrabar.FlatFontSize = 9;
            this.gbGrabar.FlatTextColor = System.Drawing.Color.Black;
            this.gbGrabar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbGrabar.Location = new System.Drawing.Point(148, 12);
            this.gbGrabar.Name = "gbGrabar";
            this.gbGrabar.RoundCorners = 2;
            this.gbGrabar.Size = new System.Drawing.Size(100, 55);
            this.gbGrabar.TabIndex = 0;
            this.gbGrabar.Text = "Guardar";
            this.gbGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbGrabar.W8Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gbGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // CargaCliente
            // 
            this.AcceptButton = this.gbGrabar;
            this.ClientSize = new System.Drawing.Size(1008, 550);
            this.Controls.Add(this.xPanel1);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CargaCliente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nuevo Movil";
            this.xPanel1.ResumeLayout(false);
            this.tgrpDatosBasicos.ResumeLayout(false);
            this.tgrpDatosBasicos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TNGS.NetControls.XPanel xPanel1;
        private TNGS.NetControls.TextEdit teRazonSocial;
        private TNGS.NetControls.FullLabel lblAnotaciones;
        private TNGS.NetControls.FullLabel lblAnioFabricacion;
        private TNGS.NetControls.TextEdit teAnotaciones;
        private TNGS.NetControls.NumberEdit neAltura;
        private TNGS.NetControls.TextEdit teDireccion;
        private TNGS.NetControls.CDCombo cdcTipoCliente;
        private TNGS.NetControls.FullLabel lblRazonSocial;
        private TNGS.NetControls.FullLabel lblDescripcionMovil;
        private TNGS.NetControls.TextEdit teNombreFantasia;
        private TNGS.NetControls.FullLabel lblNroMotor;
        private TNGS.NetControls.FullLabel lblNroChasis;
        private TNGS.NetControls.GlassButton gbGrabar;
        private TNGS.NetControls.GlassButton gbLimpiarTodo;
        private TNGS.NetControls.TextEdit tePisoDepto;
        private TNGS.NetControls.FullLabel fullLabel2;
        private TNGS.NetControls.ImgGroup tgrpDatosBasicos;
        private System.Windows.Forms.Button btnExit;
        private TNGS.NetControls.GlassButton gbCargarLocalidad;
        private TNGS.NetControls.CDCombo cdcFranquicia;
        private TNGS.NetControls.FullLabel fullLabel10;
        private TNGS.NetControls.TextEdit teZona;
        private TNGS.NetControls.FullLabel fullLabel9;
        private TNGS.NetControls.TextEdit teProvincia;
        private TNGS.NetControls.FullLabel fullLabel8;
        private TNGS.NetControls.TextEdit tePartido;
        private TNGS.NetControls.FullLabel fullLabel7;
        private TNGS.NetControls.TextEdit teLocalidad;
        private TNGS.NetControls.FullLabel fullLabel3;
        private TNGS.NetControls.TextEdit teEmail;
        private TNGS.NetControls.FullLabel fullLabel1;
        private TNGS.NetControls.TextEdit teTelefono;
        private TNGS.NetControls.FullLabel fullLabel6;
        private TNGS.NetControls.TextEdit teCelular;
        private TNGS.NetControls.FullLabel fullLabel5;
        private TNGS.NetControls.TextEdit tePaginaWeb;
        private TNGS.NetControls.FullLabel fullLabel4;
    }
}