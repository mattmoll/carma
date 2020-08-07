#region Usings
using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
#endregion

namespace Carm.
{
    public partial class Vendedores : DockContent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        private TNGS.NetControls.XPanel xpnlBase;
        private TNGS.NetControls.GlassButton cmdSalir;
        private System.Windows.Forms.Label lblTitle;
        private TNGS.NetControls.GlassButton cmdExcel;
        private TNGS.NetControls.GlassButton cmdPrint;
        private TNGS.NetControls.GlassButton cmdNuevo;
        private TNGS.NetControls.GlassButton cmdModificar;
        private TNGS.NetControls.GlassButton cmdPurgar;
        private TNGS.NetControls.ImgGroup frmEdicion;
        private System.Windows.Forms.Label lblCod;
        private TNGS.NetControls.TextEdit txtCod;
        private System.Windows.Forms.Label lblApellido;
        private TNGS.NetControls.TextEdit txtApellido;
        private System.Windows.Forms.Label lblNombre;
        private TNGS.NetControls.TextEdit txtNombre;
        private System.Windows.Forms.Label lblUsuario;
        private TNGS.NetControls.TextEdit txtUsuario;
        private System.Windows.Forms.Label lblTel1;
        private TNGS.NetControls.TextEdit txtTel1;
        private System.Windows.Forms.Label lblCelular;
        private TNGS.NetControls.TextEdit txtCelular;
        private System.Windows.Forms.Label lblTel2;
        private TNGS.NetControls.TextEdit txtTel2;
        private System.Windows.Forms.Label lblFecnacim;
        private TNGS.NetControls.DateEdit txtFecnacim;
        private System.Windows.Forms.Label lblDireccion;
        private TNGS.NetControls.TextEdit txtDireccion;
        private System.Windows.Forms.Label lblEmail;
        private TNGS.NetControls.TextEdit txtEmail;
        private System.Windows.Forms.Label lblContrasenia;
        private TNGS.NetControls.TextEdit txtContrasenia;
        private System.Windows.Forms.Label lblCodsuperv;
        private TNGS.NetControls.CDCombo cmbCodsuperv;
        private System.Windows.Forms.Label lblCodtvend;
        private TNGS.NetControls.CDCombo cmbCodtvend;
        private System.Windows.Forms.Label lblHorarios;
        private TNGS.NetControls.TextEdit txtHorarios;
        private System.Windows.Forms.Label lblMailremitente;
        private TNGS.NetControls.TextEdit txtMailremitente;
        private System.Windows.Forms.Label lblNombreamostrar;
        private TNGS.NetControls.TextEdit txtNombreamostrar;
        private System.Windows.Forms.Label lblCoddominio;
        private TNGS.NetControls.CDCombo cmbCoddominio;
        private System.Windows.Forms.Label lblHistorico;
        private TNGS.NetControls.TextEdit txtHistorico;
        private TNGS.NetControls.GlassButton cmdDesHab;
        private TNGS.NetControls.GlassButton cmdHab;
        private TNGS.NetControls.GlassButton cmdGrabar;
        private TNGS.NetControls.GlassButton cmdCancelar;
        private TNGS.NetControls.FullGrid grdDatos;
        private TNGS.NetControls.TSContainer tsContainer1;
        private RibbonStyle.TabPageSwitcher tabPageSwitcher1;
        private RibbonStyle.TabStripPage tabStripPage1;
        private TNGS.NetControls.TSPanel tsPanel2;
        private TNGS.NetControls.TSPanel tsPanel1;
        private TNGS.NetControls.TSBase tsBase1;
        private RibbonStyle.Tab tab1;

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
            this.xpnlBase = new TNGS.NetControls.XPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grdDatos = new TNGS.NetControls.FullGrid();
            this.cmdExcel = new TNGS.NetControls.GlassButton();
            this.cmdPrint = new TNGS.NetControls.GlassButton();
            this.cmdNuevo = new TNGS.NetControls.GlassButton();
            this.cmdModificar = new TNGS.NetControls.GlassButton();
            this.cmdPurgar = new TNGS.NetControls.GlassButton();
            this.cmdSalir = new TNGS.NetControls.GlassButton();
            this.frmEdicion = new TNGS.NetControls.ImgGroup();
            this.cmdGrabar = new TNGS.NetControls.GlassButton();
            this.cmdDesHab = new TNGS.NetControls.GlassButton();
            this.cmdHab = new TNGS.NetControls.GlassButton();
            this.cmdCancelar = new TNGS.NetControls.GlassButton();
            this.tsContainer1 = new TNGS.NetControls.TSContainer();
            this.tabPageSwitcher1 = new RibbonStyle.TabPageSwitcher();
            this.tabStripPage1 = new RibbonStyle.TabStripPage();
            this.tsPanel2 = new TNGS.NetControls.TSPanel();
            this.tsPanel1 = new TNGS.NetControls.TSPanel();
            this.tsBase1 = new TNGS.NetControls.TSBase();
            this.tab1 = new RibbonStyle.Tab();
            this.lblCod = new System.Windows.Forms.Label();
            this.txtCod = new TNGS.NetControls.TextEdit();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new TNGS.NetControls.TextEdit();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new TNGS.NetControls.TextEdit();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new TNGS.NetControls.TextEdit();
            this.lblTel1 = new System.Windows.Forms.Label();
            this.txtTel1 = new TNGS.NetControls.TextEdit();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtCelular = new TNGS.NetControls.TextEdit();
            this.lblTel2 = new System.Windows.Forms.Label();
            this.txtTel2 = new TNGS.NetControls.TextEdit();
            this.lblFecnacim = new System.Windows.Forms.Label();
            this.txtFecnacim = new TNGS.NetControls.DateEdit();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new TNGS.NetControls.TextEdit();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new TNGS.NetControls.TextEdit();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.txtContrasenia = new TNGS.NetControls.TextEdit();
            this.lblCodsuperv = new System.Windows.Forms.Label();
            this.cmbCodsuperv = new TNGS.NetControls.CDCombo();
            this.lblCodtvend = new System.Windows.Forms.Label();
            this.cmbCodtvend = new TNGS.NetControls.CDCombo();
            this.lblHorarios = new System.Windows.Forms.Label();
            this.txtHorarios = new TNGS.NetControls.TextEdit();
            this.lblMailremitente = new System.Windows.Forms.Label();
            this.txtMailremitente = new TNGS.NetControls.TextEdit();
            this.lblNombreamostrar = new System.Windows.Forms.Label();
            this.txtNombreamostrar = new TNGS.NetControls.TextEdit();
            this.lblCoddominio = new System.Windows.Forms.Label();
            this.cmbCoddominio = new TNGS.NetControls.CDCombo();
            this.lblHistorico = new System.Windows.Forms.Label();
            this.txtHistorico = new TNGS.NetControls.TextEdit();
            this.xpnlBase.SuspendLayout();
            this.tsContainer1.SuspendLayout();
            this.tabPageSwitcher1.SuspendLayout();
            this.tabStripPage1.SuspendLayout();
            this.tsPanel2.SuspendLayout();
            this.tsPanel1.SuspendLayout();
            this.tsBase1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.frmEdicion.SuspendLayout();
            this.SuspendLayout();
            // 
            // xpnlBase
            // 
            this.xpnlBase.BackColor1 = SystemColors.Control;
            this.xpnlBase.BackColor2 = SystemColors.Control;
            this.xpnlBase.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                                 this.tsContainer1,
                                                                                 this.lblTitle,
                                                                                 this.grdDatos,
                                                                                 this.cmdPrint,
                                                                                 this.cmdExcel,
                                                                                 this.frmEdicion});
            this.xpnlBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xpnlBase.Location = new System.Drawing.Point(0, 0);
            this.xpnlBase.Name = "xpnlBase";
            this.xpnlBase.Size = new System.Drawing.Size(600, 414);
            this.xpnlBase.TabIndex = 0;
            // 
            // tsContainer1
            // 
            this.tsContainer1.Controls.Add(this.tabPageSwitcher1);
            this.tsContainer1.Controls.Add(this.tsBase1);
            this.tsContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tsContainer1.Location = new System.Drawing.Point(0, 0);
            this.tsContainer1.Name = "tsContainer1";
            this.tsContainer1.Size = new System.Drawing.Size(750, 115);
            this.tsContainer1.TabIndex = 22;
            // 
            // tabPageSwitcher1
            // 
            this.tabPageSwitcher1.Controls.Add(this.tabStripPage1);
            this.tabPageSwitcher1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPageSwitcher1.Location = new System.Drawing.Point(0, 26);
            this.tabPageSwitcher1.Name = "tabPageSwitcher1";
            this.tabPageSwitcher1.SelectedTabStripPage = this.tabStripPage1;
            this.tabPageSwitcher1.Size = new System.Drawing.Size(750, 89);
            this.tabPageSwitcher1.TabIndex = 1;
            this.tabPageSwitcher1.TabStrip = this.tsBase1;
            this.tabPageSwitcher1.Text = "tabPageSwitcher1";
            // 
            // tabStripPage1
            // 
            this.tabStripPage1.Caption = "";
            this.tabStripPage1.Controls.Add(this.tsPanel2);
            this.tabStripPage1.Controls.Add(this.tsPanel1);
            this.tabStripPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabStripPage1.Location = new System.Drawing.Point(4, 0);
            this.tabStripPage1.Name = "tabStripPage1";
            this.tabStripPage1.Opacity = 255;
            this.tabStripPage1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.tabStripPage1.Size = new System.Drawing.Size(742, 87);
            this.tabStripPage1.Speed = 8;
            this.tabStripPage1.TabIndex = 0;
            // 
            // tsPanel2
            // 
            this.tsPanel2.Caption = "Edición";
            this.tsPanel2.Controls.Add(this.cmdHab);
            this.tsPanel2.Controls.Add(this.cmdCancelar);
            this.tsPanel2.Controls.Add(this.cmdGrabar);
            this.tsPanel2.Controls.Add(this.cmdDesHab);
            this.tsPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsPanel2.Location = new System.Drawing.Point(282, 3);
            this.tsPanel2.Name = "tsPanel2";
            this.tsPanel2.Opacity = 255;
            this.tsPanel2.Size = new System.Drawing.Size(284, 85);
            this.tsPanel2.Speed = 1;
            this.tsPanel2.TabIndex = 1;
            // 
            // tsPanel1
            // 
            this.tsPanel1.Caption = "Operaciones";
            this.tsPanel1.Controls.Add(this.cmdSalir);
            this.tsPanel1.Controls.Add(this.cmdPurgar);
            this.tsPanel1.Controls.Add(this.cmdModificar);
            this.tsPanel1.Controls.Add(this.cmdNuevo);
            this.tsPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsPanel1.Location = new System.Drawing.Point(0, 3);
            this.tsPanel1.Name = "tsPanel1";
            this.tsPanel1.Opacity = 255;
            this.tsPanel1.Size = new System.Drawing.Size(282, 85);
            this.tsPanel1.Speed = 1;
            this.tsPanel1.TabIndex = 0;
            // 
            // tsBase1
            // 
            this.tsBase1.AutoSize = false;
            this.tsBase1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsBase1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tab1});
            this.tsBase1.Location = new System.Drawing.Point(0, 0);
            this.tsBase1.Name = "tsBase1";
            this.tsBase1.Padding = new System.Windows.Forms.Padding(60, 3, 30, 0);
            this.tsBase1.SelectedTab = this.tab1;
            this.tsBase1.ShowItemToolTips = false;
            this.tsBase1.Size = new System.Drawing.Size(750, 26);
            this.tsBase1.TabIndex = 0;
            this.tsBase1.TabOverlap = 0;
            this.tsBase1.Text = "tsBase1";
            // 
            // tab1
            // 
            this.tab1.AutoSize = false;
            this.tab1.Checked = true;
            this.tab1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tab1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tab1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(90)))), ((int)(((byte)(154)))));
            this.tab1.Margin = new System.Windows.Forms.Padding(6, 1, 0, 2);
            this.tab1.Name = "tab1";
            this.tab1.Size = new System.Drawing.Size(114, 23);
            this.tab1.TabStripPage = this.tabStripPage1;
            this.tab1.Text = "Mantenimiento";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(9, 126);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(180, 16);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "Vendedores:";
            // 
            // grdDatos
            // 
            this.grdDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grdDatos.CaptionFilterColor = System.Drawing.Color.FromArgb(((System.Byte)(73)), ((System.Byte)(206)), ((System.Byte)(72)));
            this.grdDatos.CaptionVisible = false;
            this.grdDatos.DataInString = false;
            this.grdDatos.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.grdDatos.Hide1900 = true;
            this.grdDatos.Location = new System.Drawing.Point(4, 142);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.ShowTotals = false;
            this.grdDatos.Size = new System.Drawing.Size(592, 112);
            this.grdDatos.TabIndex = 0;
            this.grdDatos.WithCheckBoxes = false;
            this.grdDatos.DataDClick += new TNGS.NetRoutines.DataDClickEventHandler(this.grdDatos_DataDClick);
            this.grdDatos.Advance += new TNGS.NetRoutines.AdvanceEventHandler(this.grdDatos_Advance);
            this.grdDatos.HeaderClick += new TNGS.NetRoutines.HeaderClickEventHandler(this.grdDatos_HeaderClick);
            // 
            // cmdExcel
            // 
            this.cmdExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdExcel.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.cmdExcel.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.fExcel;
            this.cmdExcel.FlatColor = System.Drawing.Color.LimeGreen;
            this.cmdExcel.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Excel;
            this.cmdExcel.FlatFontSize = 9;
            this.cmdExcel.FlatTextColor = System.Drawing.Color.Black;
            this.cmdExcel.Location = new System.Drawing.Point(542, 118);
            this.cmdExcel.Name = "cmdExcel";
            this.cmdExcel.PCode = "TNGS.EXCEL";
            this.cmdExcel.RoundCorners = 2;
            this.cmdExcel.Size = new System.Drawing.Size(26, 24);
            this.cmdExcel.TabIndex = 1;
            this.cmdExcel.Click += new System.EventHandler(this.cmdExcel_Click);
            // 
            // cmdPrint
            // 
            this.cmdPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdPrint.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.cmdPrint.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.fPrint;
            this.cmdPrint.FlatColor = System.Drawing.Color.Gray;
            this.cmdPrint.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Imprimir;
            this.cmdPrint.FlatFontSize = 9;
            this.cmdPrint.FlatTextColor = System.Drawing.Color.Black;
            this.cmdPrint.Location = new System.Drawing.Point(569, 118);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.PCode = "TNGS.PRINT";
            this.cmdPrint.RoundCorners = 2;
            this.cmdPrint.Size = new System.Drawing.Size(26, 24);
            this.cmdPrint.TabIndex = 2;
            this.cmdPrint.Click += new System.EventHandler(this.cmdPrint_Click);
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.cmdNuevo.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.New;
            this.cmdNuevo.FlatColor = System.Drawing.Color.DodgerBlue;
            this.cmdNuevo.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.LightBlue;
            this.cmdNuevo.FlatFontSize = 9;
            this.cmdNuevo.FlatTextColor = System.Drawing.Color.Black;
            this.cmdNuevo.ImageOnTop = true;
            this.cmdNuevo.Location = new System.Drawing.Point(8, 4);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.RoundCorners = 2;
            this.cmdNuevo.Size = new System.Drawing.Size(74, 60);
            this.cmdNuevo.TabIndex = 3;
            this.cmdNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdNuevo.Text = "Nuevo";
            this.cmdNuevo.Click += new System.EventHandler(this.cmdNuevo_Click);
            // 
            // cmdModificar
            // 
            this.cmdModificar.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.cmdModificar.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Edit;
            this.cmdModificar.FlatColor = System.Drawing.Color.DodgerBlue;
            this.cmdModificar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.LightBlue;
            this.cmdModificar.FlatFontSize = 9;
            this.cmdModificar.FlatTextColor = System.Drawing.Color.Black;
            this.cmdModificar.ImageOnTop = true;
            this.cmdModificar.Location = new System.Drawing.Point(85, 4);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.RoundCorners = 2;
            this.cmdModificar.Size = new System.Drawing.Size(74, 60);
            this.cmdModificar.TabIndex = 4;
            this.cmdModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // cmdPurgar
            // 
            this.cmdPurgar.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.cmdPurgar.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Folder;
            this.cmdPurgar.FlatColor = System.Drawing.Color.Gray;
            this.cmdPurgar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Imprimir;
            this.cmdPurgar.FlatFontSize = 9;
            this.cmdPurgar.FlatTextColor = System.Drawing.Color.Black;
            this.cmdPurgar.Location = new System.Drawing.Point(164, 35);
            this.cmdPurgar.Name = "cmdPurgar";
            this.cmdPurgar.RoundCorners = 2;
            this.cmdPurgar.Size = new System.Drawing.Size(104, 25);
            this.cmdPurgar.TabIndex = 5;
            this.cmdPurgar.Text = "Compactar";
            this.cmdPurgar.Click += new System.EventHandler(this.cmdPurgar_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.cmdSalir.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Undo;
            this.cmdSalir.FlatColor = System.Drawing.Color.Red;
            this.cmdSalir.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Cancelar;
            this.cmdSalir.FlatFontSize = 9;
            this.cmdSalir.FlatTextColor = System.Drawing.Color.Black;
            this.cmdSalir.Location = new System.Drawing.Point(164, 7);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.RoundCorners = 2;
            this.cmdSalir.Size = new System.Drawing.Size(104, 25);
            this.cmdSalir.TabIndex = 6;
            this.cmdSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // frmEdicion
            // 
            this.frmEdicion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.frmEdicion.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                               this.lblCod,
                                                                               this.txtCod,
                                                                               this.lblApellido,
                                                                               this.txtApellido,
                                                                               this.lblNombre,
                                                                               this.txtNombre,
                                                                               this.lblUsuario,
                                                                               this.txtUsuario,
                                                                               this.lblTel1,
                                                                               this.txtTel1,
                                                                               this.lblCelular,
                                                                               this.txtCelular,
                                                                               this.lblTel2,
                                                                               this.txtTel2,
                                                                               this.lblFecnacim,
                                                                               this.txtFecnacim,
                                                                               this.lblDireccion,
                                                                               this.txtDireccion,
                                                                               this.lblEmail,
                                                                               this.txtEmail,
                                                                               this.lblContrasenia,
                                                                               this.txtContrasenia,
                                                                               this.lblCodsuperv,
                                                                               this.cmbCodsuperv,
                                                                               this.lblCodtvend,
                                                                               this.cmbCodtvend,
                                                                               this.lblHorarios,
                                                                               this.txtHorarios,
                                                                               this.lblMailremitente,
                                                                               this.txtMailremitente,
                                                                               this.lblNombreamostrar,
                                                                               this.txtNombreamostrar,
                                                                               this.lblCoddominio,
                                                                               this.cmbCoddominio,
                                                                               this.lblHistorico,
                                                                               this.txtHistorico});
            this.frmEdicion.BackgroundColor = SystemColors.Control;
            this.frmEdicion.BackgroundGradientColor = SystemColors.Control;
            this.frmEdicion.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.ForwardDiagonal;
            this.frmEdicion.BlackBorder = true;
            this.frmEdicion.BorderColor = System.Drawing.Color.Black;
            this.frmEdicion.BorderThickness = 1F;
            this.frmEdicion.CustomGroupBoxColor = System.Drawing.Color.White;
            this.frmEdicion.FlatMode = true;
            this.frmEdicion.FontTitle = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmEdicion.GroupImage = null;
            this.frmEdicion.GroupTitle = " Vendedor ";
            this.frmEdicion.Location = new System.Drawing.Point(4, 260);
            this.frmEdicion.Name = "frmEdicion";
            this.frmEdicion.Padding = new System.Windows.Forms.Padding(20);
            this.frmEdicion.PaintGroupBox = false;
            this.frmEdicion.RoundCorners = 4;
            this.frmEdicion.ShadowColor = System.Drawing.Color.DarkGray;
            this.frmEdicion.ShadowControl = false;
            this.frmEdicion.ShadowThickness = 3;
            this.frmEdicion.Size = new System.Drawing.Size(592, 150);
            this.frmEdicion.TabIndex = 21;
            this.frmEdicion.TitleBackground = System.Drawing.Color.DodgerBlue;
            this.frmEdicion.TitleBackgroundDefault = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.frmEdicion.TitleFontColor = System.Drawing.Color.White;
            // 
            // cmdGrabar
            // 
            this.cmdGrabar.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.cmdGrabar.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Save;
            this.cmdGrabar.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cmdGrabar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Aceptar;
            this.cmdGrabar.FlatFontSize = 9;
            this.cmdGrabar.FlatTextColor = System.Drawing.Color.Black;
            this.cmdGrabar.ImageOnTop = true;
            this.cmdGrabar.Location = new System.Drawing.Point(8, 4);
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.Size = new System.Drawing.Size(70, 60);
            this.cmdGrabar.RoundCorners = 2;
            this.cmdGrabar.TabIndex = 10;
            this.cmdGrabar.Text = "Grabar";
            this.cmdGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdGrabar.Text = "Grabar";
            this.cmdGrabar.Click += new System.EventHandler(this.cmdGrabar_Click);
            // 
            // cmdDesHab
            // 
            this.cmdDesHab.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.cmdDesHab.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Block;
            this.cmdDesHab.FlatColor = System.Drawing.Color.Gold;
            this.cmdDesHab.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Yellow;
            this.cmdDesHab.FlatFontSize = 9;
            this.cmdDesHab.FlatTextColor = System.Drawing.Color.Black;
            this.cmdDesHab.Location = new System.Drawing.Point(157, 35);
            this.cmdDesHab.Name = "cmdDesHab";
            this.cmdDesHab.Size = new System.Drawing.Size(113, 25);
            this.cmdDesHab.RoundCorners = 2;
            this.cmdDesHab.TabIndex = 11;
            this.cmdDesHab.Text = "Deshabilitar";
            this.cmdDesHab.Click += new System.EventHandler(this.cmdDesHab_Click);
            // 
            // cmdHab
            // 
            this.cmdHab.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.cmdHab.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Check;
            this.cmdHab.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cmdHab.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Aceptar;
            this.cmdHab.FlatFontSize = 9;
            this.cmdHab.FlatTextColor = System.Drawing.Color.Black;
            this.cmdHab.Location = new System.Drawing.Point(157, 7);
            this.cmdHab.Name = "cmdHab";
            this.cmdHab.Size = new System.Drawing.Size(113, 25);
            this.cmdHab.RoundCorners = 2;
            this.cmdHab.TabIndex = 11;
            this.cmdHab.Text = "Habilitar";
            this.cmdHab.Text = "Habilitar";
            this.cmdHab.Click += new System.EventHandler(this.cmdDesHab_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.cmdCancelar.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Cancel;
            this.cmdCancelar.FlatColor = System.Drawing.Color.Red;
            this.cmdCancelar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Cancelar;
            this.cmdCancelar.FlatFontSize = 9;
            this.cmdCancelar.FlatTextColor = System.Drawing.Color.Black;
            this.cmdCancelar.ImageOnTop = true;
            this.cmdCancelar.Location = new System.Drawing.Point(81, 4);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(70, 60);
            this.cmdCancelar.RoundCorners = 2;
            this.cmdCancelar.TabIndex = 12;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // lblCod
            // 
            this.lblCod.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblCod.Location = new System.Drawing.Point(15, 30);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(104, 22);
            this.lblCod.TabIndex = 106;
            this.lblCod.Text = "Código:";
            this.lblCod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCod
            // 
            this.txtCod.Enabled = false;
            this.txtCod.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(125, 38);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(44, 22);
            this.txtCod.TabIndex = 6;
            this.txtCod.MaxLength = 6;
            this.txtCod.Text = "";
            this.txtCod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCod.EmptyValid = false;
            this.txtCod.Multiline = false;
            this.txtCod.OnlyDigits = false;
            // 
            // lblApellido
            // 
            this.lblApellido.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(15, 46);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(104, 22);
            this.lblApellido.TabIndex = 107;
            this.lblApellido.Text = "Apellido:";
            this.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(125, 54);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(44, 22);
            this.txtApellido.TabIndex = 7;
            this.txtApellido.MaxLength = 30;
            this.txtApellido.Text = "";
            this.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellido.EmptyValid = false;
            this.txtApellido.Multiline = false;
            this.txtApellido.OnlyDigits = false;
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(15, 62);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(104, 22);
            this.lblNombre.TabIndex = 108;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(125, 70);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(44, 22);
            this.txtNombre.TabIndex = 8;
            this.txtNombre.MaxLength = 30;
            this.txtNombre.Text = "";
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.EmptyValid = false;
            this.txtNombre.Multiline = false;
            this.txtNombre.OnlyDigits = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(15, 78);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(104, 22);
            this.lblUsuario.TabIndex = 109;
            this.lblUsuario.Text = "Usuario Sistema:";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(125, 86);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(44, 22);
            this.txtUsuario.TabIndex = 9;
            this.txtUsuario.MaxLength = 20;
            this.txtUsuario.Text = "";
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuario.EmptyValid = false;
            this.txtUsuario.Multiline = false;
            this.txtUsuario.OnlyDigits = false;
            // 
            // lblTel1
            // 
            this.lblTel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblTel1.Location = new System.Drawing.Point(15, 94);
            this.lblTel1.Name = "lblTel1";
            this.lblTel1.Size = new System.Drawing.Size(104, 22);
            this.lblTel1.TabIndex = 110;
            this.lblTel1.Text = "Telefono1:";
            this.lblTel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTel1
            // 
            this.txtTel1.Enabled = false;
            this.txtTel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtTel1.Location = new System.Drawing.Point(125, 102);
            this.txtTel1.Name = "txtTel1";
            this.txtTel1.Size = new System.Drawing.Size(44, 22);
            this.txtTel1.TabIndex = 10;
            this.txtTel1.MaxLength = 30;
            this.txtTel1.Text = "";
            this.txtTel1.EmptyValid = true;
            this.txtTel1.Multiline = false;
            this.txtTel1.OnlyDigits = false;
            // 
            // lblCelular
            // 
            this.lblCelular.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(15, 110);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(104, 22);
            this.lblCelular.TabIndex = 111;
            this.lblCelular.Text = "Celular:";
            this.lblCelular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCelular
            // 
            this.txtCelular.Enabled = false;
            this.txtCelular.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(125, 118);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(44, 22);
            this.txtCelular.TabIndex = 11;
            this.txtCelular.MaxLength = 30;
            this.txtCelular.Text = "";
            this.txtCelular.EmptyValid = true;
            this.txtCelular.Multiline = false;
            this.txtCelular.OnlyDigits = false;
            // 
            // lblTel2
            // 
            this.lblTel2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblTel2.Location = new System.Drawing.Point(15, 126);
            this.lblTel2.Name = "lblTel2";
            this.lblTel2.Size = new System.Drawing.Size(104, 22);
            this.lblTel2.TabIndex = 112;
            this.lblTel2.Text = "Telefono2:";
            this.lblTel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTel2
            // 
            this.txtTel2.Enabled = false;
            this.txtTel2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtTel2.Location = new System.Drawing.Point(125, 134);
            this.txtTel2.Name = "txtTel2";
            this.txtTel2.Size = new System.Drawing.Size(44, 22);
            this.txtTel2.TabIndex = 12;
            this.txtTel2.MaxLength = 30;
            this.txtTel2.Text = "";
            this.txtTel2.EmptyValid = true;
            this.txtTel2.Multiline = false;
            this.txtTel2.OnlyDigits = false;
            // 
            // lblFecnacim
            // 
            this.lblFecnacim.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblFecnacim.Location = new System.Drawing.Point(15, 142);
            this.lblFecnacim.Name = "lblFecnacim";
            this.lblFecnacim.Size = new System.Drawing.Size(104, 22);
            this.lblFecnacim.TabIndex = 113;
            this.lblFecnacim.Text = "Fecha Nacimiento:";
            this.lblFecnacim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFecnacim
            // 
            this.txtFecnacim.Enabled = false;
            this.txtFecnacim.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtFecnacim.Location = new System.Drawing.Point(125, 150);
            this.txtFecnacim.Name = "txtFecnacim";
            this.txtFecnacim.Size = new System.Drawing.Size(44, 22);
            this.txtFecnacim.TabIndex = 13;
            this.txtFecnacim.Fecha = new DateTime(1900,1,1,0,0,0);
            this.txtFecnacim.EmptyValid = false;
            // 
            // lblDireccion
            // 
            this.lblDireccion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(15, 158);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(104, 22);
            this.lblDireccion.TabIndex = 114;
            this.lblDireccion.Text = "Dirección:";
            this.lblDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(125, 166);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(44, 22);
            this.txtDireccion.TabIndex = 14;
            this.txtDireccion.MaxLength = 60;
            this.txtDireccion.Text = "";
            this.txtDireccion.EmptyValid = true;
            this.txtDireccion.Multiline = false;
            this.txtDireccion.OnlyDigits = false;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(15, 174);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(104, 22);
            this.lblEmail.TabIndex = 115;
            this.lblEmail.Text = "Usuario Credencial Mail:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(125, 182);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(44, 22);
            this.txtEmail.TabIndex = 15;
            this.txtEmail.MaxLength = 60;
            this.txtEmail.Text = "";
            this.txtEmail.EmptyValid = false;
            this.txtEmail.Multiline = false;
            this.txtEmail.OnlyDigits = false;
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblContrasenia.Location = new System.Drawing.Point(15, 190);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(104, 22);
            this.lblContrasenia.TabIndex = 116;
            this.lblContrasenia.Text = "Contraseña:";
            this.lblContrasenia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Enabled = false;
            this.txtContrasenia.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtContrasenia.Location = new System.Drawing.Point(125, 198);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(44, 22);
            this.txtContrasenia.TabIndex = 16;
            this.txtContrasenia.MaxLength = 60;
            this.txtContrasenia.Text = "";
            this.txtContrasenia.EmptyValid = false;
            this.txtContrasenia.Multiline = false;
            this.txtContrasenia.OnlyDigits = false;
            // 
            // lblCodsuperv
            // 
            this.lblCodsuperv.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblCodsuperv.Location = new System.Drawing.Point(15, 206);
            this.lblCodsuperv.Name = "lblCodsuperv";
            this.lblCodsuperv.Size = new System.Drawing.Size(104, 22);
            this.lblCodsuperv.TabIndex = 117;
            this.lblCodsuperv.Text = "Supervisor:";
            this.lblCodsuperv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbCodsuperv
            // 
            this.cmbCodsuperv.Enabled = false;
            this.cmbCodsuperv.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.cmbCodsuperv.Location = new System.Drawing.Point(125, 214);
            this.cmbCodsuperv.Name = "cmbCodsuperv";
            this.cmbCodsuperv.Size = new System.Drawing.Size(44, 22);
            this.cmbCodsuperv.TabIndex = 17;
            this.cmbCodsuperv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodsuperv.EmptyValid = false;
            // 
            // lblCodtvend
            // 
            this.lblCodtvend.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblCodtvend.Location = new System.Drawing.Point(15, 222);
            this.lblCodtvend.Name = "lblCodtvend";
            this.lblCodtvend.Size = new System.Drawing.Size(104, 22);
            this.lblCodtvend.TabIndex = 118;
            this.lblCodtvend.Text = "Tipo Vendedor:";
            this.lblCodtvend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbCodtvend
            // 
            this.cmbCodtvend.Enabled = false;
            this.cmbCodtvend.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.cmbCodtvend.Location = new System.Drawing.Point(125, 230);
            this.cmbCodtvend.Name = "cmbCodtvend";
            this.cmbCodtvend.Size = new System.Drawing.Size(44, 22);
            this.cmbCodtvend.TabIndex = 18;
            this.cmbCodtvend.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodtvend.EmptyValid = false;
            // 
            // lblHorarios
            // 
            this.lblHorarios.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblHorarios.Location = new System.Drawing.Point(15, 238);
            this.lblHorarios.Name = "lblHorarios";
            this.lblHorarios.Size = new System.Drawing.Size(104, 22);
            this.lblHorarios.TabIndex = 119;
            this.lblHorarios.Text = "Horarios:";
            this.lblHorarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHorarios
            // 
            this.txtHorarios.Enabled = false;
            this.txtHorarios.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtHorarios.Location = new System.Drawing.Point(125, 246);
            this.txtHorarios.Name = "txtHorarios";
            this.txtHorarios.Size = new System.Drawing.Size(44, 22);
            this.txtHorarios.TabIndex = 19;
            this.txtHorarios.MaxLength = 0;
            this.txtHorarios.Text = "";
            this.txtHorarios.EmptyValid = true;
            this.txtHorarios.Multiline = true;
            this.txtHorarios.OnlyDigits = false;
            // 
            // lblMailremitente
            // 
            this.lblMailremitente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblMailremitente.Location = new System.Drawing.Point(15, 254);
            this.lblMailremitente.Name = "lblMailremitente";
            this.lblMailremitente.Size = new System.Drawing.Size(104, 22);
            this.lblMailremitente.TabIndex = 120;
            this.lblMailremitente.Text = "Mail Remitente:";
            this.lblMailremitente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMailremitente
            // 
            this.txtMailremitente.Enabled = false;
            this.txtMailremitente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtMailremitente.Location = new System.Drawing.Point(125, 262);
            this.txtMailremitente.Name = "txtMailremitente";
            this.txtMailremitente.Size = new System.Drawing.Size(44, 22);
            this.txtMailremitente.TabIndex = 20;
            this.txtMailremitente.MaxLength = 60;
            this.txtMailremitente.Text = "";
            this.txtMailremitente.EmptyValid = true;
            this.txtMailremitente.Multiline = false;
            this.txtMailremitente.OnlyDigits = false;
            // 
            // lblNombreamostrar
            // 
            this.lblNombreamostrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblNombreamostrar.Location = new System.Drawing.Point(15, 270);
            this.lblNombreamostrar.Name = "lblNombreamostrar";
            this.lblNombreamostrar.Size = new System.Drawing.Size(104, 22);
            this.lblNombreamostrar.TabIndex = 121;
            this.lblNombreamostrar.Text = "Nombre a Mostrar:";
            this.lblNombreamostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNombreamostrar
            // 
            this.txtNombreamostrar.Enabled = false;
            this.txtNombreamostrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtNombreamostrar.Location = new System.Drawing.Point(125, 278);
            this.txtNombreamostrar.Name = "txtNombreamostrar";
            this.txtNombreamostrar.Size = new System.Drawing.Size(44, 22);
            this.txtNombreamostrar.TabIndex = 21;
            this.txtNombreamostrar.MaxLength = 60;
            this.txtNombreamostrar.Text = "";
            this.txtNombreamostrar.EmptyValid = true;
            this.txtNombreamostrar.Multiline = false;
            this.txtNombreamostrar.OnlyDigits = false;
            // 
            // lblCoddominio
            // 
            this.lblCoddominio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblCoddominio.Location = new System.Drawing.Point(15, 286);
            this.lblCoddominio.Name = "lblCoddominio";
            this.lblCoddominio.Size = new System.Drawing.Size(104, 22);
            this.lblCoddominio.TabIndex = 122;
            this.lblCoddominio.Text = "Dominio:";
            this.lblCoddominio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbCoddominio
            // 
            this.cmbCoddominio.Enabled = false;
            this.cmbCoddominio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.cmbCoddominio.Location = new System.Drawing.Point(125, 294);
            this.cmbCoddominio.Name = "cmbCoddominio";
            this.cmbCoddominio.Size = new System.Drawing.Size(44, 22);
            this.cmbCoddominio.TabIndex = 22;
            this.cmbCoddominio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCoddominio.EmptyValid = true;
            // 
            // lblHistorico
            // 
            this.lblHistorico.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblHistorico.Location = new System.Drawing.Point(15, 302);
            this.lblHistorico.Name = "lblHistorico";
            this.lblHistorico.Size = new System.Drawing.Size(104, 22);
            this.lblHistorico.TabIndex = 123;
            this.lblHistorico.Text = "Es Historico:";
            this.lblHistorico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHistorico
            // 
            this.txtHistorico.Enabled = false;
            this.txtHistorico.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtHistorico.Location = new System.Drawing.Point(125, 310);
            this.txtHistorico.Name = "txtHistorico";
            this.txtHistorico.Size = new System.Drawing.Size(44, 22);
            this.txtHistorico.TabIndex = 23;
            this.txtHistorico.MaxLength = 1;
            this.txtHistorico.Text = "";
            this.txtHistorico.EmptyValid = true;
            this.txtHistorico.Multiline = false;
            this.txtHistorico.OnlyDigits = false;
            // 
            // Vendedores
            // 
            this.AllowEndUserDocking = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.xpnlBase);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.Document;
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Vendedores";
            this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.Document;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TabText = "Mantenimiento de Vendedores";
            this.Load += new System.EventHandler(this.Vendedores_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Vendedores_FormClosed);
            this.xpnlBase.ResumeLayout(false);
            this.tsContainer1.ResumeLayout(false);
            this.tabPageSwitcher1.ResumeLayout(false);
            this.tabStripPage1.ResumeLayout(false);
            this.tsPanel2.ResumeLayout(false);
            this.tsPanel1.ResumeLayout(false);
            this.tsBase1.ResumeLayout(false);
            this.tsBase1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.frmEdicion.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
    }
}
