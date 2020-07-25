using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Carm.Tg
{
    public partial class Zonas : DockContent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        private TNGS.NetControls.XPanel xpnlBase;
        private TNGS.NetControls.GlassButton gbSalir;
        private System.Windows.Forms.Label lblTitle;
        private TNGS.NetControls.GlassButton cmdExcel;
        private TNGS.NetControls.GlassButton cmdPrint;
        private TNGS.NetControls.ImgGroup frmOper;
        private TNGS.NetControls.GlassButton gbNuevo;
        private TNGS.NetControls.GlassButton gbModificar;
        private TNGS.NetControls.GlassButton gbCompactar;
        private TNGS.NetControls.ImgGroup frmEdicion;
        private TNGS.NetControls.ImgGroup frmData;
        private System.Windows.Forms.Label lblCod;
        private TNGS.NetControls.TextEdit txtCod;
        private System.Windows.Forms.Label lblNombre;
        private TNGS.NetControls.TextEdit txtNombre;
        private System.Windows.Forms.Label lblGeoloc;
        private TNGS.NetControls.TextEdit txtGeoloc;
        private TNGS.NetControls.GlassButton gbDeshabilitar;
        private TNGS.NetControls.GlassButton gbGrabar;
        private TNGS.NetControls.GlassButton gbCancelar;
        private TNGS.NetControls.FullGrid grdDatos;

        /// <summary>
        /// Liberamos los recursos utilizados
        /// </summary>
        protected override void Dispose( bool disposing )
        {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zonas));
            this.xpnlBase = new TNGS.NetControls.XPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grdDatos = new TNGS.NetControls.FullGrid();
            this.cmdPrint = new TNGS.NetControls.GlassButton();
            this.cmdExcel = new TNGS.NetControls.GlassButton();
            this.frmOper = new TNGS.NetControls.ImgGroup();
            this.gbNuevo = new TNGS.NetControls.GlassButton();
            this.gbModificar = new TNGS.NetControls.GlassButton();
            this.gbCompactar = new TNGS.NetControls.GlassButton();
            this.gbSalir = new TNGS.NetControls.GlassButton();
            this.frmEdicion = new TNGS.NetControls.ImgGroup();
            this.gbGrabar = new TNGS.NetControls.GlassButton();
            this.gbDeshabilitar = new TNGS.NetControls.GlassButton();
            this.gbCancelar = new TNGS.NetControls.GlassButton();
            this.frmData = new TNGS.NetControls.ImgGroup();
            this.lblCod = new System.Windows.Forms.Label();
            this.txtCod = new TNGS.NetControls.TextEdit();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new TNGS.NetControls.TextEdit();
            this.lblGeoloc = new System.Windows.Forms.Label();
            this.txtGeoloc = new TNGS.NetControls.TextEdit();
            this.xpnlBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.frmOper.SuspendLayout();
            this.frmEdicion.SuspendLayout();
            this.frmData.SuspendLayout();
            this.SuspendLayout();
            // 
            // xpnlBase
            // 
            this.xpnlBase.BackColor1 = System.Drawing.SystemColors.Control;
            this.xpnlBase.BackColor2 = System.Drawing.SystemColors.Control;
            this.xpnlBase.Controls.Add(this.lblTitle);
            this.xpnlBase.Controls.Add(this.grdDatos);
            this.xpnlBase.Controls.Add(this.cmdPrint);
            this.xpnlBase.Controls.Add(this.cmdExcel);
            this.xpnlBase.Controls.Add(this.frmOper);
            this.xpnlBase.Controls.Add(this.frmEdicion);
            this.xpnlBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xpnlBase.Location = new System.Drawing.Point(0, 0);
            this.xpnlBase.Name = "xpnlBase";
            this.xpnlBase.Size = new System.Drawing.Size(750, 450);
            this.xpnlBase.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(8, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(180, 16);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "Zonas:";
            // 
            // grdDatos
            // 
            this.grdDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grdDatos.CaptionFilterColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(206)))), ((int)(((byte)(72)))));
            this.grdDatos.CaptionVisible = false;
            this.grdDatos.DataMember = "";
            this.grdDatos.ExcelTitle = "";
            this.grdDatos.GridOrder = "";
            this.grdDatos.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.grdDatos.Location = new System.Drawing.Point(4, 28);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.Size = new System.Drawing.Size(742, 225);
            this.grdDatos.TabIndex = 0;
            this.grdDatos.Advance += new TNGS.NetRoutines.AdvanceEventHandler(this.grdDatos_Advance);
            this.grdDatos.DataDClick += new TNGS.NetRoutines.DataDClickEventHandler(this.grdDatos_DataDClick);
            this.grdDatos.HeaderClick += new TNGS.NetRoutines.HeaderClickEventHandler(this.grdDatos_HeaderClick);
            // 
            // cmdPrint
            // 
            this.cmdPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdPrint.BlackBorder = true;
            this.cmdPrint.CircleButton = false;
            this.cmdPrint.FixedImage = TNGS.NetControls.FixedGlassButtons.bPrint;
            this.cmdPrint.FlatColor = System.Drawing.SystemColors.HotTrack;
            this.cmdPrint.FlatFontSize = 9;
            this.cmdPrint.FlatTextColor = System.Drawing.Color.Black;
            this.cmdPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmdPrint.Location = new System.Drawing.Point(720, 4);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.PCode = "TNGS.PRINT";
            this.cmdPrint.RoundCorners = 2;
            this.cmdPrint.Size = new System.Drawing.Size(26, 24);
            this.cmdPrint.TabIndex = 2;
            this.cmdPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdPrint.W8Color = System.Drawing.SystemColors.HotTrack;
            this.cmdPrint.Click += new System.EventHandler(this.cmdPrint_Click);
            // 
            // cmdExcel
            // 
            this.cmdExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdExcel.BlackBorder = true;
            this.cmdExcel.CircleButton = false;
            this.cmdExcel.FixedImage = TNGS.NetControls.FixedGlassButtons.bExcel;
            this.cmdExcel.FlatColor = System.Drawing.SystemColors.HotTrack;
            this.cmdExcel.FlatFontSize = 9;
            this.cmdExcel.FlatTextColor = System.Drawing.Color.Black;
            this.cmdExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmdExcel.Location = new System.Drawing.Point(695, 4);
            this.cmdExcel.Name = "cmdExcel";
            this.cmdExcel.PCode = "TNGS.EXCEL";
            this.cmdExcel.RoundCorners = 2;
            this.cmdExcel.Size = new System.Drawing.Size(26, 24);
            this.cmdExcel.TabIndex = 1;
            this.cmdExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdExcel.W8Color = System.Drawing.SystemColors.HotTrack;
            this.cmdExcel.Click += new System.EventHandler(this.cmdExcel_Click);
            // 
            // frmOper
            // 
            this.frmOper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.frmOper.BackgroundColor = System.Drawing.SystemColors.Control;
            this.frmOper.BackgroundGradientColor = System.Drawing.SystemColors.Control;
            this.frmOper.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.ForwardDiagonal;
            this.frmOper.BorderColor = System.Drawing.Color.Black;
            this.frmOper.BorderThickness = 1F;
            this.frmOper.Controls.Add(this.gbNuevo);
            this.frmOper.Controls.Add(this.gbModificar);
            this.frmOper.Controls.Add(this.gbCompactar);
            this.frmOper.Controls.Add(this.gbSalir);
            this.frmOper.CustomGroupBoxColor = System.Drawing.Color.White;
            this.frmOper.FontTitle = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmOper.GroupImage = null;
            this.frmOper.GroupTitle = " Operaciones ";
            this.frmOper.Location = new System.Drawing.Point(613, 260);
            this.frmOper.Name = "frmOper";
            this.frmOper.Padding = new System.Windows.Forms.Padding(20);
            this.frmOper.PaintGroupBox = false;
            this.frmOper.RoundCorners = 10;
            this.frmOper.ShadowColor = System.Drawing.Color.DarkGray;
            this.frmOper.ShadowControl = false;
            this.frmOper.ShadowThickness = 3;
            this.frmOper.Size = new System.Drawing.Size(133, 184);
            this.frmOper.TabIndex = 21;
            // 
            // gbNuevo
            // 
            this.gbNuevo.BlackBorder = true;
            this.gbNuevo.CircleButton = false;
            this.gbNuevo.FixedImage = TNGS.NetControls.FixedGlassButtons.New;
            this.gbNuevo.FlatColor = System.Drawing.SystemColors.HotTrack;
            this.gbNuevo.FlatFontSize = 9;
            this.gbNuevo.FlatTextColor = System.Drawing.Color.Black;
            this.gbNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.gbNuevo.Location = new System.Drawing.Point(17, 30);
            this.gbNuevo.Name = "gbNuevo";
            this.gbNuevo.RoundCorners = 2;
            this.gbNuevo.Size = new System.Drawing.Size(104, 26);
            this.gbNuevo.TabIndex = 3;
            this.gbNuevo.Text = "Nuevo";
            this.gbNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbNuevo.W8Color = System.Drawing.SystemColors.HotTrack;
            this.gbNuevo.Click += new System.EventHandler(this.gbNuevo_Click);
            // 
            // gbModificar
            // 
            this.gbModificar.BlackBorder = true;
            this.gbModificar.CircleButton = false;
            this.gbModificar.FixedImage = TNGS.NetControls.FixedGlassButtons.Modify;
            this.gbModificar.FlatColor = System.Drawing.SystemColors.HotTrack;
            this.gbModificar.FlatFontSize = 9;
            this.gbModificar.FlatTextColor = System.Drawing.Color.Black;
            this.gbModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.gbModificar.Location = new System.Drawing.Point(17, 57);
            this.gbModificar.Name = "gbModificar";
            this.gbModificar.RoundCorners = 2;
            this.gbModificar.Size = new System.Drawing.Size(104, 26);
            this.gbModificar.TabIndex = 4;
            this.gbModificar.Text = "Modificar";
            this.gbModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbModificar.W8Color = System.Drawing.SystemColors.HotTrack;
            this.gbModificar.Click += new System.EventHandler(this.gbModificar_Click);
            // 
            // gbCompactar
            // 
            this.gbCompactar.BlackBorder = true;
            this.gbCompactar.CircleButton = false;
            this.gbCompactar.FixedImage = TNGS.NetControls.FixedGlassButtons.Agrupa;
            this.gbCompactar.FlatColor = System.Drawing.SystemColors.HotTrack;
            this.gbCompactar.FlatFontSize = 9;
            this.gbCompactar.FlatTextColor = System.Drawing.Color.Black;
            this.gbCompactar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.gbCompactar.Location = new System.Drawing.Point(17, 94);
            this.gbCompactar.Name = "gbCompactar";
            this.gbCompactar.RoundCorners = 2;
            this.gbCompactar.Size = new System.Drawing.Size(104, 26);
            this.gbCompactar.TabIndex = 5;
            this.gbCompactar.Text = "Compactar";
            this.gbCompactar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbCompactar.W8Color = System.Drawing.SystemColors.HotTrack;
            this.gbCompactar.Click += new System.EventHandler(this.gbCompactar_Click);
            // 
            // gbSalir
            // 
            this.gbSalir.BlackBorder = true;
            this.gbSalir.CircleButton = false;
            this.gbSalir.FixedImage = TNGS.NetControls.FixedGlassButtons.Quit;
            this.gbSalir.FlatColor = System.Drawing.SystemColors.HotTrack;
            this.gbSalir.FlatFontSize = 9;
            this.gbSalir.FlatTextColor = System.Drawing.Color.Black;
            this.gbSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.gbSalir.Location = new System.Drawing.Point(17, 150);
            this.gbSalir.Name = "gbSalir";
            this.gbSalir.RoundCorners = 2;
            this.gbSalir.Size = new System.Drawing.Size(104, 26);
            this.gbSalir.TabIndex = 6;
            this.gbSalir.Text = "Salir";
            this.gbSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbSalir.W8Color = System.Drawing.SystemColors.HotTrack;
            this.gbSalir.Click += new System.EventHandler(this.gbSalir_Click);
            // 
            // frmEdicion
            // 
            this.frmEdicion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frmEdicion.BackgroundColor = System.Drawing.SystemColors.Control;
            this.frmEdicion.BackgroundGradientColor = System.Drawing.SystemColors.Control;
            this.frmEdicion.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.ForwardDiagonal;
            this.frmEdicion.BorderColor = System.Drawing.Color.Black;
            this.frmEdicion.BorderThickness = 1F;
            this.frmEdicion.Controls.Add(this.gbGrabar);
            this.frmEdicion.Controls.Add(this.gbDeshabilitar);
            this.frmEdicion.Controls.Add(this.gbCancelar);
            this.frmEdicion.Controls.Add(this.frmData);
            this.frmEdicion.CustomGroupBoxColor = System.Drawing.Color.White;
            this.frmEdicion.FontTitle = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmEdicion.GroupImage = null;
            this.frmEdicion.GroupTitle = " Zona ";
            this.frmEdicion.Location = new System.Drawing.Point(4, 260);
            this.frmEdicion.Name = "frmEdicion";
            this.frmEdicion.Padding = new System.Windows.Forms.Padding(20);
            this.frmEdicion.PaintGroupBox = false;
            this.frmEdicion.RoundCorners = 10;
            this.frmEdicion.ShadowColor = System.Drawing.Color.DarkGray;
            this.frmEdicion.ShadowControl = false;
            this.frmEdicion.ShadowThickness = 3;
            this.frmEdicion.Size = new System.Drawing.Size(603, 184);
            this.frmEdicion.TabIndex = 21;
            // 
            // gbGrabar
            // 
            this.gbGrabar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGrabar.BlackBorder = true;
            this.gbGrabar.CircleButton = false;
            this.gbGrabar.FixedImage = TNGS.NetControls.FixedGlassButtons.Save;
            this.gbGrabar.FlatColor = System.Drawing.SystemColors.HotTrack;
            this.gbGrabar.FlatFontSize = 9;
            this.gbGrabar.FlatTextColor = System.Drawing.Color.Black;
            this.gbGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.gbGrabar.Location = new System.Drawing.Point(489, 150);
            this.gbGrabar.Name = "gbGrabar";
            this.gbGrabar.RoundCorners = 2;
            this.gbGrabar.Size = new System.Drawing.Size(104, 26);
            this.gbGrabar.TabIndex = 10;
            this.gbGrabar.Text = "Grabar";
            this.gbGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbGrabar.W8Color = System.Drawing.SystemColors.HotTrack;
            this.gbGrabar.Click += new System.EventHandler(this.gbGrabar_Click);
            // 
            // gbDeshabilitar
            // 
            this.gbDeshabilitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDeshabilitar.BlackBorder = true;
            this.gbDeshabilitar.CircleButton = false;
            this.gbDeshabilitar.FixedImage = TNGS.NetControls.FixedGlassButtons.Enable;
            this.gbDeshabilitar.FlatColor = System.Drawing.SystemColors.HotTrack;
            this.gbDeshabilitar.FlatFontSize = 9;
            this.gbDeshabilitar.FlatTextColor = System.Drawing.Color.Black;
            this.gbDeshabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.gbDeshabilitar.Location = new System.Drawing.Point(371, 150);
            this.gbDeshabilitar.Name = "gbDeshabilitar";
            this.gbDeshabilitar.RoundCorners = 2;
            this.gbDeshabilitar.Size = new System.Drawing.Size(104, 26);
            this.gbDeshabilitar.TabIndex = 11;
            this.gbDeshabilitar.Text = "Habilitar";
            this.gbDeshabilitar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbDeshabilitar.W8Color = System.Drawing.SystemColors.HotTrack;
            this.gbDeshabilitar.Click += new System.EventHandler(this.gbChangeHabilitado_Click);
            // 
            // gbCancelar
            // 
            this.gbCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbCancelar.BlackBorder = true;
            this.gbCancelar.CircleButton = false;
            this.gbCancelar.FixedImage = TNGS.NetControls.FixedGlassButtons.Cancel;
            this.gbCancelar.FlatColor = System.Drawing.SystemColors.HotTrack;
            this.gbCancelar.FlatFontSize = 9;
            this.gbCancelar.FlatTextColor = System.Drawing.Color.Black;
            this.gbCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.gbCancelar.Location = new System.Drawing.Point(10, 150);
            this.gbCancelar.Name = "gbCancelar";
            this.gbCancelar.RoundCorners = 2;
            this.gbCancelar.Size = new System.Drawing.Size(104, 26);
            this.gbCancelar.TabIndex = 12;
            this.gbCancelar.Text = "Cancelar";
            this.gbCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbCancelar.W8Color = System.Drawing.SystemColors.HotTrack;
            this.gbCancelar.Click += new System.EventHandler(this.gbCancelar_Click);
            // 
            // frmData
            // 
            this.frmData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frmData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.frmData.BackgroundGradientColor = System.Drawing.SystemColors.Control;
            this.frmData.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.ForwardDiagonal;
            this.frmData.BorderColor = System.Drawing.Color.Black;
            this.frmData.BorderThickness = 1F;
            this.frmData.Controls.Add(this.lblCod);
            this.frmData.Controls.Add(this.txtCod);
            this.frmData.Controls.Add(this.lblNombre);
            this.frmData.Controls.Add(this.txtNombre);
            this.frmData.Controls.Add(this.lblGeoloc);
            this.frmData.Controls.Add(this.txtGeoloc);
            this.frmData.CustomGroupBoxColor = System.Drawing.Color.White;
            this.frmData.FontTitle = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmData.GroupImage = null;
            this.frmData.GroupTitle = "";
            this.frmData.Location = new System.Drawing.Point(10, 17);
            this.frmData.Name = "frmData";
            this.frmData.Padding = new System.Windows.Forms.Padding(20);
            this.frmData.PaintGroupBox = false;
            this.frmData.RoundCorners = 10;
            this.frmData.ShadowColor = System.Drawing.Color.DarkGray;
            this.frmData.ShadowControl = false;
            this.frmData.ShadowThickness = 3;
            this.frmData.Size = new System.Drawing.Size(583, 128);
            this.frmData.TabIndex = 22;
            // 
            // lblCod
            // 
            this.lblCod.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.Location = new System.Drawing.Point(39, 26);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(104, 22);
            this.lblCod.TabIndex = 106;
            this.lblCod.Text = "Código:";
            this.lblCod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCod
            // 
            this.txtCod.BackColor = System.Drawing.SystemColors.Window;
            this.txtCod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCod.EmptyValid = false;
            this.txtCod.Enabled = false;
            this.txtCod.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(180, 26);
            this.txtCod.MaxLength = 2;
            this.txtCod.Name = "txtCod";
            this.txtCod.OnlyDigits = true;
            this.txtCod.Size = new System.Drawing.Size(58, 22);
            this.txtCod.TabIndex = 6;
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(20, 56);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(123, 22);
            this.lblNombre.TabIndex = 107;
            this.lblNombre.Text = "Nombre de la zona:";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.EmptyValid = false;
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(180, 56);
            this.txtNombre.MaxLength = 30;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(166, 22);
            this.txtNombre.TabIndex = 7;
            // 
            // lblGeoloc
            // 
            this.lblGeoloc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeoloc.Location = new System.Drawing.Point(39, 84);
            this.lblGeoloc.Name = "lblGeoloc";
            this.lblGeoloc.Size = new System.Drawing.Size(104, 22);
            this.lblGeoloc.TabIndex = 108;
            this.lblGeoloc.Text = "Geolocalización:";
            this.lblGeoloc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGeoloc
            // 
            this.txtGeoloc.BackColor = System.Drawing.SystemColors.Window;
            this.txtGeoloc.Enabled = false;
            this.txtGeoloc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGeoloc.Location = new System.Drawing.Point(180, 86);
            this.txtGeoloc.MaxLength = 0;
            this.txtGeoloc.Multiline = true;
            this.txtGeoloc.Name = "txtGeoloc";
            this.txtGeoloc.Size = new System.Drawing.Size(354, 20);
            this.txtGeoloc.TabIndex = 8;
            // 
            // Zonas
            // 
            this.AllowEndUserDocking = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.xpnlBase);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.Document;
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Zonas";
            this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.Document;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TabText = "Mantenimiento de Zonas";
            this.Text = "Mantenimiento de Zonas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Zonas_FormClosed);
            this.Load += new System.EventHandler(this.Zonas_Load);
            this.xpnlBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.frmOper.ResumeLayout(false);
            this.frmEdicion.ResumeLayout(false);
            this.frmData.ResumeLayout(false);
            this.frmData.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
    }
}
