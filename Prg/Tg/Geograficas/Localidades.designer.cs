using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Carm.Tg
{
    public partial class Localidades : DockContent
    {
        private TNGS.NetControls.XPanel xpnlBase;
        private TNGS.NetControls.GlassButton gbSalir;
        private System.Windows.Forms.Label lblTitle;
        private TNGS.NetControls.GlassButton cmdExcel;
        private TNGS.NetControls.GlassButton cmdPrint;
        private TNGS.NetControls.ImgGroup frmOper;
        private TNGS.NetControls.GlassButton gbNuevo;
        private TNGS.NetControls.GlassButton gbModificar;
        private TNGS.NetControls.ImgGroup frmEdicion;
        private TNGS.NetControls.ImgGroup frmData;
        private System.Windows.Forms.Label lblDescripcion;
        private TNGS.NetControls.TextEdit txtDescripcion;
        private System.Windows.Forms.Label lblZona;
        private TNGS.NetControls.CDCombo cmbZona;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Localidades));
            this.xpnlBase = new TNGS.NetControls.XPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdCanNPart = new TNGS.NetControls.GlassButton();
            this.cmdSvNPart = new TNGS.NetControls.GlassButton();
            this.txtNewPartido = new TNGS.NetControls.TextEdit();
            this.cmdNewPart = new TNGS.NetControls.GlassButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grdDatos = new TNGS.NetControls.FullGrid();
            this.cmdPrint = new TNGS.NetControls.GlassButton();
            this.cmdExcel = new TNGS.NetControls.GlassButton();
            this.cmbPartido = new TNGS.NetControls.CDCombo();
            this.frmOper = new TNGS.NetControls.ImgGroup();
            this.gbNuevo = new TNGS.NetControls.GlassButton();
            this.gbModificar = new TNGS.NetControls.GlassButton();
            this.gbSalir = new TNGS.NetControls.GlassButton();
            this.cmbProvincia = new TNGS.NetControls.CDCombo();
            this.frmEdicion = new TNGS.NetControls.ImgGroup();
            this.gbGrabar = new TNGS.NetControls.GlassButton();
            this.gbDeshabilitar = new TNGS.NetControls.GlassButton();
            this.gbCancelar = new TNGS.NetControls.GlassButton();
            this.frmData = new TNGS.NetControls.ImgGroup();
            this.txtCodPostal = new TNGS.NetControls.FrmEdit();
            this.cmbDirecta = new TNGS.NetControls.CDCombo();
            this.txtDescripcion = new TNGS.NetControls.TextEdit();
            this.cmbZona = new TNGS.NetControls.CDCombo();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblZona = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.xpnlBase.Controls.Add(this.label6);
            this.xpnlBase.Controls.Add(this.label4);
            this.xpnlBase.Controls.Add(this.cmdCanNPart);
            this.xpnlBase.Controls.Add(this.cmdSvNPart);
            this.xpnlBase.Controls.Add(this.txtNewPartido);
            this.xpnlBase.Controls.Add(this.cmdNewPart);
            this.xpnlBase.Controls.Add(this.lblTitle);
            this.xpnlBase.Controls.Add(this.grdDatos);
            this.xpnlBase.Controls.Add(this.cmdPrint);
            this.xpnlBase.Controls.Add(this.cmdExcel);
            this.xpnlBase.Controls.Add(this.cmbPartido);
            this.xpnlBase.Controls.Add(this.frmOper);
            this.xpnlBase.Controls.Add(this.cmbProvincia);
            this.xpnlBase.Controls.Add(this.frmEdicion);
            this.xpnlBase.Controls.Add(this.label1);
            this.xpnlBase.Controls.Add(this.label2);
            this.xpnlBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xpnlBase.Location = new System.Drawing.Point(0, 0);
            this.xpnlBase.Name = "xpnlBase";
            this.xpnlBase.Size = new System.Drawing.Size(750, 450);
            this.xpnlBase.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(140, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(486, 22);
            this.label6.TabIndex = 115;
            this.label6.Text = "pero cuando se agranda al debuggear queda centrado!!!";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(673, 22);
            this.label4.TabIndex = 114;
            this.label4.Text = "NO TOCAR el formato de esta ventana, se ve horrible en la ventana de diseño ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Visible = false;
            // 
            // cmdCanNPart
            // 
            this.cmdCanNPart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCanNPart.BlackBorder = true;
            this.cmdCanNPart.CircleButton = false;
            this.cmdCanNPart.FixedImage = TNGS.NetControls.FixedGlassButtons.bCancel;
            this.cmdCanNPart.FlatColor = System.Drawing.SystemColors.HotTrack;
            this.cmdCanNPart.FlatFontSize = 9;
            this.cmdCanNPart.FlatTextColor = System.Drawing.Color.Black;
            this.cmdCanNPart.Location = new System.Drawing.Point(487, 6);
            this.cmdCanNPart.Name = "cmdCanNPart";
            this.cmdCanNPart.RoundCorners = 2;
            this.cmdCanNPart.Size = new System.Drawing.Size(26, 24);
            this.cmdCanNPart.TabIndex = 4;
            this.cmdCanNPart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCanNPart.W8Color = System.Drawing.SystemColors.HotTrack;
            this.cmdCanNPart.Click += new System.EventHandler(this.cmdCanNPart_Click);
            // 
            // cmdSvNPart
            // 
            this.cmdSvNPart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSvNPart.BlackBorder = true;
            this.cmdSvNPart.CircleButton = false;
            this.cmdSvNPart.FixedImage = TNGS.NetControls.FixedGlassButtons.bSave;
            this.cmdSvNPart.FlatColor = System.Drawing.SystemColors.HotTrack;
            this.cmdSvNPart.FlatFontSize = 9;
            this.cmdSvNPart.FlatTextColor = System.Drawing.Color.Black;
            this.cmdSvNPart.Location = new System.Drawing.Point(514, 6);
            this.cmdSvNPart.Name = "cmdSvNPart";
            this.cmdSvNPart.RoundCorners = 2;
            this.cmdSvNPart.Size = new System.Drawing.Size(26, 24);
            this.cmdSvNPart.TabIndex = 5;
            this.cmdSvNPart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSvNPart.W8Color = System.Drawing.SystemColors.HotTrack;
            this.cmdSvNPart.Click += new System.EventHandler(this.cmdSvNPart_Click);
            // 
            // txtNewPartido
            // 
            this.txtNewPartido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewPartido.BackColor = System.Drawing.SystemColors.Window;
            this.txtNewPartido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNewPartido.EmptyValid = false;
            this.txtNewPartido.Enabled = false;
            this.txtNewPartido.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPartido.Location = new System.Drawing.Point(317, 30);
            this.txtNewPartido.MaxLength = 60;
            this.txtNewPartido.Name = "txtNewPartido";
            this.txtNewPartido.Size = new System.Drawing.Size(223, 22);
            this.txtNewPartido.TabIndex = 3;
            // 
            // cmdNewPart
            // 
            this.cmdNewPart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdNewPart.BlackBorder = true;
            this.cmdNewPart.CircleButton = false;
            this.cmdNewPart.FixedImage = TNGS.NetControls.FixedGlassButtons.bNew;
            this.cmdNewPart.FlatColor = System.Drawing.SystemColors.HotTrack;
            this.cmdNewPart.FlatFontSize = 9;
            this.cmdNewPart.FlatTextColor = System.Drawing.Color.Black;
            this.cmdNewPart.Location = new System.Drawing.Point(283, 29);
            this.cmdNewPart.Name = "cmdNewPart";
            this.cmdNewPart.RoundCorners = 2;
            this.cmdNewPart.Size = new System.Drawing.Size(26, 24);
            this.cmdNewPart.TabIndex = 2;
            this.cmdNewPart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdNewPart.W8Color = System.Drawing.SystemColors.HotTrack;
            this.cmdNewPart.Click += new System.EventHandler(this.cmdNewPart_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(8, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(86, 16);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "Localidades:";
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
            this.grdDatos.Location = new System.Drawing.Point(4, 57);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.Size = new System.Drawing.Size(742, 188);
            this.grdDatos.TabIndex = 6;
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
            this.cmdPrint.Location = new System.Drawing.Point(719, 33);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.PCode = "TNGS.PRINT";
            this.cmdPrint.RoundCorners = 2;
            this.cmdPrint.Size = new System.Drawing.Size(26, 24);
            this.cmdPrint.TabIndex = 7;
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
            this.cmdExcel.Location = new System.Drawing.Point(694, 33);
            this.cmdExcel.Name = "cmdExcel";
            this.cmdExcel.PCode = "TNGS.EXCEL";
            this.cmdExcel.RoundCorners = 2;
            this.cmdExcel.Size = new System.Drawing.Size(26, 24);
            this.cmdExcel.TabIndex = 6;
            this.cmdExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdExcel.W8Color = System.Drawing.SystemColors.HotTrack;
            this.cmdExcel.Click += new System.EventHandler(this.cmdExcel_Click);
            // 
            // cmbPartido
            // 
            this.cmbPartido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPartido.BackColor = System.Drawing.SystemColors.Window;
            this.cmbPartido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPartido.Enabled = false;
            this.cmbPartido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPartido.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPartido.Location = new System.Drawing.Point(35, 29);
            this.cmbPartido.Name = "cmbPartido";
            this.cmbPartido.Size = new System.Drawing.Size(245, 24);
            this.cmbPartido.Sorted = true;
            this.cmbPartido.TabIndex = 1;
            this.cmbPartido.SelectedIndexChanged += new System.EventHandler(this.cmbPartido_SelectedIndexChanged);
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
            this.frmOper.Controls.Add(this.gbSalir);
            this.frmOper.CustomGroupBoxColor = System.Drawing.Color.White;
            this.frmOper.FontTitle = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmOper.GroupImage = null;
            this.frmOper.GroupTitle = " Operaciones ";
            this.frmOper.Location = new System.Drawing.Point(613, 251);
            this.frmOper.Name = "frmOper";
            this.frmOper.Padding = new System.Windows.Forms.Padding(20);
            this.frmOper.PaintGroupBox = false;
            this.frmOper.RoundCorners = 10;
            this.frmOper.ShadowColor = System.Drawing.Color.DarkGray;
            this.frmOper.ShadowControl = false;
            this.frmOper.ShadowThickness = 3;
            this.frmOper.Size = new System.Drawing.Size(133, 193);
            this.frmOper.TabIndex = 7;
            // 
            // gbNuevo
            // 
            this.gbNuevo.BlackBorder = true;
            this.gbNuevo.CircleButton = false;
            this.gbNuevo.FixedImage = TNGS.NetControls.FixedGlassButtons.New;
            this.gbNuevo.FlatColor = System.Drawing.SystemColors.HotTrack;
            this.gbNuevo.FlatFontSize = 9;
            this.gbNuevo.FlatTextColor = System.Drawing.Color.Black;
            this.gbNuevo.Location = new System.Drawing.Point(17, 30);
            this.gbNuevo.Name = "gbNuevo";
            this.gbNuevo.RoundCorners = 2;
            this.gbNuevo.Size = new System.Drawing.Size(104, 26);
            this.gbNuevo.TabIndex = 0;
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
            this.gbModificar.Location = new System.Drawing.Point(17, 57);
            this.gbModificar.Name = "gbModificar";
            this.gbModificar.RoundCorners = 2;
            this.gbModificar.Size = new System.Drawing.Size(104, 26);
            this.gbModificar.TabIndex = 1;
            this.gbModificar.Text = "Modificar";
            this.gbModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbModificar.W8Color = System.Drawing.SystemColors.HotTrack;
            this.gbModificar.Click += new System.EventHandler(this.gbModificar_Click);
            // 
            // gbSalir
            // 
            this.gbSalir.BlackBorder = true;
            this.gbSalir.CircleButton = false;
            this.gbSalir.FixedImage = TNGS.NetControls.FixedGlassButtons.Quit;
            this.gbSalir.FlatColor = System.Drawing.SystemColors.HotTrack;
            this.gbSalir.FlatFontSize = 9;
            this.gbSalir.FlatTextColor = System.Drawing.Color.Black;
            this.gbSalir.Location = new System.Drawing.Point(17, 159);
            this.gbSalir.Name = "gbSalir";
            this.gbSalir.RoundCorners = 2;
            this.gbSalir.Size = new System.Drawing.Size(104, 26);
            this.gbSalir.TabIndex = 2;
            this.gbSalir.Text = "Salir";
            this.gbSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbSalir.W8Color = System.Drawing.SystemColors.HotTrack;
            this.gbSalir.Click += new System.EventHandler(this.gbSalir_Click);
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProvincia.BackColor = System.Drawing.SystemColors.Window;
            this.cmbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvincia.Enabled = false;
            this.cmbProvincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProvincia.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProvincia.Location = new System.Drawing.Point(35, 3);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(245, 24);
            this.cmbProvincia.Sorted = true;
            this.cmbProvincia.TabIndex = 0;
            this.cmbProvincia.SelectedIndexChanged += new System.EventHandler(this.cmbProvincia_SelectedIndexChanged);
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
            this.frmEdicion.GroupTitle = " Localidad ";
            this.frmEdicion.Location = new System.Drawing.Point(4, 251);
            this.frmEdicion.Name = "frmEdicion";
            this.frmEdicion.Padding = new System.Windows.Forms.Padding(20);
            this.frmEdicion.PaintGroupBox = false;
            this.frmEdicion.RoundCorners = 10;
            this.frmEdicion.ShadowColor = System.Drawing.Color.DarkGray;
            this.frmEdicion.ShadowControl = false;
            this.frmEdicion.ShadowThickness = 3;
            this.frmEdicion.Size = new System.Drawing.Size(603, 193);
            this.frmEdicion.TabIndex = 8;
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
            this.gbGrabar.Location = new System.Drawing.Point(489, 159);
            this.gbGrabar.Name = "gbGrabar";
            this.gbGrabar.RoundCorners = 2;
            this.gbGrabar.Size = new System.Drawing.Size(104, 26);
            this.gbGrabar.TabIndex = 0;
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
            this.gbDeshabilitar.Location = new System.Drawing.Point(382, 159);
            this.gbDeshabilitar.Name = "gbDeshabilitar";
            this.gbDeshabilitar.RoundCorners = 2;
            this.gbDeshabilitar.Size = new System.Drawing.Size(104, 26);
            this.gbDeshabilitar.TabIndex = 2;
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
            this.gbCancelar.Location = new System.Drawing.Point(7, 159);
            this.gbCancelar.Name = "gbCancelar";
            this.gbCancelar.RoundCorners = 2;
            this.gbCancelar.Size = new System.Drawing.Size(104, 26);
            this.gbCancelar.TabIndex = 1;
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
            this.frmData.Controls.Add(this.txtCodPostal);
            this.frmData.Controls.Add(this.cmbDirecta);
            this.frmData.Controls.Add(this.txtDescripcion);
            this.frmData.Controls.Add(this.cmbZona);
            this.frmData.Controls.Add(this.lblDescripcion);
            this.frmData.Controls.Add(this.lblZona);
            this.frmData.Controls.Add(this.label3);
            this.frmData.Controls.Add(this.label5);
            this.frmData.CustomGroupBoxColor = System.Drawing.Color.White;
            this.frmData.FontTitle = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmData.GroupImage = null;
            this.frmData.GroupTitle = "";
            this.frmData.Location = new System.Drawing.Point(7, 21);
            this.frmData.Name = "frmData";
            this.frmData.Padding = new System.Windows.Forms.Padding(20);
            this.frmData.PaintGroupBox = false;
            this.frmData.RoundCorners = 10;
            this.frmData.ShadowColor = System.Drawing.Color.DarkGray;
            this.frmData.ShadowControl = false;
            this.frmData.ShadowThickness = 3;
            this.frmData.Size = new System.Drawing.Size(586, 132);
            this.frmData.TabIndex = 0;
            // 
            // txtCodPostal
            // 
            this.txtCodPostal.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodPostal.InvBackColor = System.Drawing.Color.LightCoral;
            this.txtCodPostal.Location = new System.Drawing.Point(93, 21);
            this.txtCodPostal.Mask = "A####AAA";
            this.txtCodPostal.MaxLength = 8;
            this.txtCodPostal.Name = "txtCodPostal";
            this.txtCodPostal.Size = new System.Drawing.Size(100, 21);
            this.txtCodPostal.TabIndex = 0;
            this.txtCodPostal.Text = "        ";
            // 
            // cmbDirecta
            // 
            this.cmbDirecta.BackColor = System.Drawing.SystemColors.Window;
            this.cmbDirecta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDirecta.Enabled = false;
            this.cmbDirecta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDirecta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDirecta.Location = new System.Drawing.Point(93, 103);
            this.cmbDirecta.Name = "cmbDirecta";
            this.cmbDirecta.Size = new System.Drawing.Size(45, 24);
            this.cmbDirecta.Sorted = true;
            this.cmbDirecta.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.EmptyValid = false;
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(93, 48);
            this.txtDescripcion.MaxLength = 60;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(463, 22);
            this.txtDescripcion.TabIndex = 1;
            // 
            // cmbZona
            // 
            this.cmbZona.BackColor = System.Drawing.SystemColors.Window;
            this.cmbZona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZona.Enabled = false;
            this.cmbZona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbZona.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbZona.Location = new System.Drawing.Point(93, 73);
            this.cmbZona.Name = "cmbZona";
            this.cmbZona.Size = new System.Drawing.Size(245, 24);
            this.cmbZona.Sorted = true;
            this.cmbZona.TabIndex = 2;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(16, 51);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(80, 16);
            this.lblDescripcion.TabIndex = 107;
            this.lblDescripcion.Text = "Descripción:";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblZona
            // 
            this.lblZona.AutoSize = true;
            this.lblZona.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZona.Location = new System.Drawing.Point(54, 76);
            this.lblZona.Name = "lblZona";
            this.lblZona.Size = new System.Drawing.Size(40, 16);
            this.lblZona.TabIndex = 108;
            this.lblZona.Text = "Zona:";
            this.lblZona.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 115;
            this.label3.Text = "Directa:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Código Postal:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-27, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 111;
            this.label1.Text = "Provincia:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-16, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 113;
            this.label2.Text = "Partido:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Localidades
            // 
            this.AllowEndUserDocking = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.xpnlBase);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.Document;
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Localidades";
            this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.Document;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TabText = "Mantenimiento de Localidades";
            this.Text = "Mantenimiento de Localidades";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Localidades_FormClosed);
            this.Load += new System.EventHandler(this.Localidades_Load);
            this.xpnlBase.ResumeLayout(false);
            this.xpnlBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.frmOper.ResumeLayout(false);
            this.frmEdicion.ResumeLayout(false);
            this.frmData.ResumeLayout(false);
            this.frmData.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private IContainer components=null;
        private TNGS.NetControls.CDCombo cmbPartido;
        private Label label2;
        private TNGS.NetControls.CDCombo cmbProvincia;
        private Label label1;
        private TNGS.NetControls.CDCombo cmbDirecta;
        private Label label3;
        private TNGS.NetControls.GlassButton cmdNewPart;
        private TNGS.NetControls.TextEdit txtNewPartido;
        private TNGS.NetControls.FrmEdit txtCodPostal;
        private Label label5;
        private TNGS.NetControls.GlassButton cmdSvNPart;
        private TNGS.NetControls.GlassButton cmdCanNPart;
        private Label label4;
        private Label label6;
    }
}
