#region Usings
using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
#endregion

namespace Carm.Tg
{
    public partial class Rubros : DockContent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        private TNGS.NetControls.XPanel xpnlBase;
        private System.Windows.Forms.Label lblTitle;
        private TNGS.NetControls.GlassButton cmdExcel;
        private TNGS.NetControls.GlassButton cmdPrint;
        private TNGS.NetControls.GlassButton gbNuevo;
        private TNGS.NetControls.GlassButton gbModificar;
        private TNGS.NetControls.ImgGroup frmEdicion;
        private System.Windows.Forms.Label lblCod;
        private TNGS.NetControls.TextEdit txtCod;
        private System.Windows.Forms.Label lblDes;
        private TNGS.NetControls.TextEdit txtDes;
        private TNGS.NetControls.GlassButton gbGrabar;
        private TNGS.NetControls.GlassButton gbCancelar;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rubros));
            this.xpnlBase = new TNGS.NetControls.XPanel();
            this.tsContainer1 = new TNGS.NetControls.TSContainer();
            this.tabPageSwitcher1 = new RibbonStyle.TabPageSwitcher();
            this.tabStripPage1 = new RibbonStyle.TabStripPage();
            this.tsPanel2 = new TNGS.NetControls.TSPanel();
            this.gbHabilitar = new TNGS.NetControls.GlassButton();
            this.gbDeshabilitar = new TNGS.NetControls.GlassButton();
            this.gbCancelar = new TNGS.NetControls.GlassButton();
            this.gbGrabar = new TNGS.NetControls.GlassButton();
            this.tsPanel1 = new TNGS.NetControls.TSPanel();
            this.gbCompactar = new TNGS.NetControls.GlassButton();
            this.gbModificar = new TNGS.NetControls.GlassButton();
            this.gbSalir = new TNGS.NetControls.GlassButton();
            this.gbNuevo = new TNGS.NetControls.GlassButton();
            this.tsBase1 = new TNGS.NetControls.TSBase();
            this.tab1 = new RibbonStyle.Tab();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grdDatos = new TNGS.NetControls.FullGrid();
            this.cmdPrint = new TNGS.NetControls.GlassButton();
            this.cmdExcel = new TNGS.NetControls.GlassButton();
            this.frmEdicion = new TNGS.NetControls.ImgGroup();
            this.lblCod = new System.Windows.Forms.Label();
            this.txtCod = new TNGS.NetControls.TextEdit();
            this.lblDes = new System.Windows.Forms.Label();
            this.txtDes = new TNGS.NetControls.TextEdit();
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
            this.xpnlBase.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xpnlBase.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xpnlBase.Controls.Add(this.tsContainer1);
            this.xpnlBase.Controls.Add(this.lblTitle);
            this.xpnlBase.Controls.Add(this.grdDatos);
            this.xpnlBase.Controls.Add(this.cmdPrint);
            this.xpnlBase.Controls.Add(this.cmdExcel);
            this.xpnlBase.Controls.Add(this.frmEdicion);
            this.xpnlBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xpnlBase.Location = new System.Drawing.Point(0, 0);
            this.xpnlBase.Name = "xpnlBase";
            this.xpnlBase.Size = new System.Drawing.Size(750, 450);
            this.xpnlBase.SkinFixed = true;
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
            this.tabStripPage1.ForeColor = System.Drawing.SystemColors.ControlText;
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
            this.tsPanel2.Controls.Add(this.gbHabilitar);
            this.tsPanel2.Controls.Add(this.gbDeshabilitar);
            this.tsPanel2.Controls.Add(this.gbCancelar);
            this.tsPanel2.Controls.Add(this.gbGrabar);
            this.tsPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsPanel2.FlatColor = System.Drawing.Color.RoyalBlue;
            this.tsPanel2.Location = new System.Drawing.Point(282, 3);
            this.tsPanel2.Name = "tsPanel2";
            this.tsPanel2.Opacity = 255;
            this.tsPanel2.Size = new System.Drawing.Size(284, 85);
            this.tsPanel2.Speed = 1;
            this.tsPanel2.TabIndex = 1;
            // 
            // gbHabilitar
            // 
            this.gbHabilitar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbHabilitar.BackgroundImage")));
            this.gbHabilitar.BlackBorder = true;
            this.gbHabilitar.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbHabilitar.CircleButton = false;
            this.gbHabilitar.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Check;
            this.gbHabilitar.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gbHabilitar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Aceptar;
            this.gbHabilitar.FlatFontSize = 9;
            this.gbHabilitar.FlatTextColor = System.Drawing.Color.Black;
            this.gbHabilitar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbHabilitar.Location = new System.Drawing.Point(162, 6);
            this.gbHabilitar.Name = "gbHabilitar";
            this.gbHabilitar.RoundCorners = 2;
            this.gbHabilitar.Size = new System.Drawing.Size(113, 25);
            this.gbHabilitar.TabIndex = 23;
            this.gbHabilitar.Text = "Habilitar";
            this.gbHabilitar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbHabilitar.W8Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gbHabilitar.Click += new System.EventHandler(this.gbChangeHabilitado_Click);
            // 
            // gbDeshabilitar
            // 
            this.gbDeshabilitar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbDeshabilitar.BackgroundImage")));
            this.gbDeshabilitar.BlackBorder = true;
            this.gbDeshabilitar.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbDeshabilitar.CircleButton = false;
            this.gbDeshabilitar.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Block;
            this.gbDeshabilitar.FlatColor = System.Drawing.Color.Gold;
            this.gbDeshabilitar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Yellow;
            this.gbDeshabilitar.FlatFontSize = 9;
            this.gbDeshabilitar.FlatTextColor = System.Drawing.Color.Black;
            this.gbDeshabilitar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbDeshabilitar.Location = new System.Drawing.Point(162, 35);
            this.gbDeshabilitar.Name = "gbDeshabilitar";
            this.gbDeshabilitar.RoundCorners = 2;
            this.gbDeshabilitar.Size = new System.Drawing.Size(113, 25);
            this.gbDeshabilitar.TabIndex = 24;
            this.gbDeshabilitar.Text = "Deshabilitar";
            this.gbDeshabilitar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbDeshabilitar.W8Color = System.Drawing.Color.Gold;
            this.gbDeshabilitar.Click += new System.EventHandler(this.gbChangeHabilitado_Click);
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
            this.gbCancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbCancelar.ImageOnTop = true;
            this.gbCancelar.Location = new System.Drawing.Point(81, 4);
            this.gbCancelar.Name = "gbCancelar";
            this.gbCancelar.RoundCorners = 2;
            this.gbCancelar.Size = new System.Drawing.Size(70, 60);
            this.gbCancelar.TabIndex = 12;
            this.gbCancelar.Text = "Cancelar";
            this.gbCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gbCancelar.W8Color = System.Drawing.Color.Red;
            this.gbCancelar.Click += new System.EventHandler(this.gbCancelar_Click);
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
            this.gbGrabar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbGrabar.ImageOnTop = true;
            this.gbGrabar.Location = new System.Drawing.Point(8, 4);
            this.gbGrabar.Name = "gbGrabar";
            this.gbGrabar.RoundCorners = 2;
            this.gbGrabar.Size = new System.Drawing.Size(70, 60);
            this.gbGrabar.TabIndex = 10;
            this.gbGrabar.Text = "Grabar";
            this.gbGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gbGrabar.W8Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gbGrabar.Click += new System.EventHandler(this.gbGrabar_Click);
            // 
            // tsPanel1
            // 
            this.tsPanel1.Caption = "Operaciones";
            this.tsPanel1.Controls.Add(this.gbCompactar);
            this.tsPanel1.Controls.Add(this.gbModificar);
            this.tsPanel1.Controls.Add(this.gbSalir);
            this.tsPanel1.Controls.Add(this.gbNuevo);
            this.tsPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsPanel1.FlatColor = System.Drawing.Color.RoyalBlue;
            this.tsPanel1.Location = new System.Drawing.Point(0, 3);
            this.tsPanel1.Name = "tsPanel1";
            this.tsPanel1.Opacity = 255;
            this.tsPanel1.Size = new System.Drawing.Size(282, 85);
            this.tsPanel1.Speed = 1;
            this.tsPanel1.TabIndex = 0;
            // 
            // gbCompactar
            // 
            this.gbCompactar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbCompactar.BackgroundImage")));
            this.gbCompactar.BlackBorder = true;
            this.gbCompactar.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbCompactar.CircleButton = false;
            this.gbCompactar.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Folder;
            this.gbCompactar.FlatColor = System.Drawing.Color.Gray;
            this.gbCompactar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Imprimir;
            this.gbCompactar.FlatFontSize = 9;
            this.gbCompactar.FlatTextColor = System.Drawing.Color.Black;
            this.gbCompactar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbCompactar.Location = new System.Drawing.Point(172, 35);
            this.gbCompactar.Name = "gbCompactar";
            this.gbCompactar.RoundCorners = 2;
            this.gbCompactar.Size = new System.Drawing.Size(104, 25);
            this.gbCompactar.TabIndex = 18;
            this.gbCompactar.Text = "Compactar";
            this.gbCompactar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbCompactar.W8Color = System.Drawing.Color.Gray;
            this.gbCompactar.Click += new System.EventHandler(this.gbCompactar_Click);
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
            this.gbModificar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbModificar.ImageOnTop = true;
            this.gbModificar.Location = new System.Drawing.Point(85, 4);
            this.gbModificar.Name = "gbModificar";
            this.gbModificar.RoundCorners = 2;
            this.gbModificar.Size = new System.Drawing.Size(74, 60);
            this.gbModificar.TabIndex = 4;
            this.gbModificar.Text = "Modificar";
            this.gbModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gbModificar.W8Color = System.Drawing.Color.DodgerBlue;
            this.gbModificar.Click += new System.EventHandler(this.gbModificar_Click);
            // 
            // gbSalir
            // 
            this.gbSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbSalir.BackgroundImage")));
            this.gbSalir.BlackBorder = true;
            this.gbSalir.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbSalir.CircleButton = false;
            this.gbSalir.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Undo;
            this.gbSalir.FlatColor = System.Drawing.Color.Red;
            this.gbSalir.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Cancelar;
            this.gbSalir.FlatFontSize = 9;
            this.gbSalir.FlatTextColor = System.Drawing.Color.Black;
            this.gbSalir.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbSalir.Location = new System.Drawing.Point(172, 6);
            this.gbSalir.Name = "gbSalir";
            this.gbSalir.RoundCorners = 2;
            this.gbSalir.Size = new System.Drawing.Size(104, 25);
            this.gbSalir.TabIndex = 17;
            this.gbSalir.Text = "Salir";
            this.gbSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbSalir.W8Color = System.Drawing.Color.Red;
            this.gbSalir.Click += new System.EventHandler(this.gbSalir_Click);
            // 
            // gbNuevo
            // 
            this.gbNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbNuevo.BackgroundImage")));
            this.gbNuevo.BlackBorder = true;
            this.gbNuevo.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbNuevo.CircleButton = false;
            this.gbNuevo.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.New;
            this.gbNuevo.FlatColor = System.Drawing.Color.DodgerBlue;
            this.gbNuevo.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.LightBlue;
            this.gbNuevo.FlatFontSize = 9;
            this.gbNuevo.FlatTextColor = System.Drawing.Color.Black;
            this.gbNuevo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbNuevo.ImageOnTop = true;
            this.gbNuevo.Location = new System.Drawing.Point(8, 4);
            this.gbNuevo.Name = "gbNuevo";
            this.gbNuevo.RoundCorners = 2;
            this.gbNuevo.Size = new System.Drawing.Size(74, 60);
            this.gbNuevo.TabIndex = 3;
            this.gbNuevo.Text = "Nuevo";
            this.gbNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gbNuevo.W8Color = System.Drawing.Color.DodgerBlue;
            this.gbNuevo.Click += new System.EventHandler(this.gbNuevo_Click);
            // 
            // tsBase1
            // 
            this.tsBase1.AutoSize = false;
            this.tsBase1.FlatLigth = true;
            this.tsBase1.ForeColor = System.Drawing.Color.Black;
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
            this.lblTitle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(9, 126);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(180, 16);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "Rubros:";
            // 
            // grdDatos
            // 
            this.grdDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grdDatos.CaptionBackColor = System.Drawing.Color.DodgerBlue;
            this.grdDatos.CaptionFilterColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdDatos.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdDatos.CaptionVisible = false;
            this.grdDatos.DataMember = "";
            this.grdDatos.ExcelName = "Datos Exportados";
            this.grdDatos.ExcelTitle = "";
            this.grdDatos.GridOrder = "";
            this.grdDatos.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.grdDatos.Location = new System.Drawing.Point(4, 142);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.Size = new System.Drawing.Size(742, 209);
            this.grdDatos.SkinFixed = true;
            this.grdDatos.TabIndex = 0;
            this.grdDatos.Advance += new TNGS.NetRoutines.AdvanceEventHandler(this.grdDatos_Advance);
            this.grdDatos.DataDClick += new TNGS.NetRoutines.DataDClickEventHandler(this.grdDatos_DataDClick);
            this.grdDatos.HeaderClick += new TNGS.NetRoutines.HeaderClickEventHandler(this.grdDatos_HeaderClick);
            // 
            // cmdPrint
            // 
            this.cmdPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdPrint.BackgroundImage")));
            this.cmdPrint.BlackBorder = true;
            this.cmdPrint.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.cmdPrint.CircleButton = false;
            this.cmdPrint.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.fPrint;
            this.cmdPrint.FlatColor = System.Drawing.Color.Gray;
            this.cmdPrint.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Imprimir;
            this.cmdPrint.FlatFontSize = 9;
            this.cmdPrint.FlatTextColor = System.Drawing.Color.Black;
            this.cmdPrint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmdPrint.Location = new System.Drawing.Point(719, 118);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.PCode = "TNGS.PRINT";
            this.cmdPrint.RoundCorners = 2;
            this.cmdPrint.Size = new System.Drawing.Size(26, 24);
            this.cmdPrint.TabIndex = 2;
            this.cmdPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdPrint.W8Color = System.Drawing.Color.Gray;
            this.cmdPrint.Click += new System.EventHandler(this.cmdPrint_Click);
            // 
            // cmdExcel
            // 
            this.cmdExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdExcel.BackgroundImage")));
            this.cmdExcel.BlackBorder = true;
            this.cmdExcel.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.cmdExcel.CircleButton = false;
            this.cmdExcel.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.fExcel;
            this.cmdExcel.FlatColor = System.Drawing.Color.LimeGreen;
            this.cmdExcel.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Excel;
            this.cmdExcel.FlatFontSize = 9;
            this.cmdExcel.FlatTextColor = System.Drawing.Color.Black;
            this.cmdExcel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmdExcel.Location = new System.Drawing.Point(692, 118);
            this.cmdExcel.Name = "cmdExcel";
            this.cmdExcel.PCode = "TNGS.EXCEL";
            this.cmdExcel.RoundCorners = 2;
            this.cmdExcel.Size = new System.Drawing.Size(26, 24);
            this.cmdExcel.TabIndex = 1;
            this.cmdExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdExcel.W8Color = System.Drawing.Color.LimeGreen;
            this.cmdExcel.Click += new System.EventHandler(this.cmdExcel_Click);
            // 
            // frmEdicion
            // 
            this.frmEdicion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frmEdicion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.frmEdicion.BackgroundGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.frmEdicion.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.ForwardDiagonal;
            this.frmEdicion.BlackBorder = true;
            this.frmEdicion.BorderColor = System.Drawing.Color.DodgerBlue;
            this.frmEdicion.BorderThickness = 1F;
            this.frmEdicion.Controls.Add(this.lblCod);
            this.frmEdicion.Controls.Add(this.txtCod);
            this.frmEdicion.Controls.Add(this.lblDes);
            this.frmEdicion.Controls.Add(this.txtDes);
            this.frmEdicion.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.frmEdicion.FlatMode = true;
            this.frmEdicion.FontTitle = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmEdicion.ForeColor = System.Drawing.Color.Black;
            this.frmEdicion.GroupImage = null;
            this.frmEdicion.GroupTitle = " Rubro ";
            this.frmEdicion.Location = new System.Drawing.Point(4, 357);
            this.frmEdicion.Name = "frmEdicion";
            this.frmEdicion.Padding = new System.Windows.Forms.Padding(20);
            this.frmEdicion.PaintGroupBox = false;
            this.frmEdicion.RoundCorners = 4;
            this.frmEdicion.ShadowColor = System.Drawing.Color.DarkGray;
            this.frmEdicion.ShadowControl = false;
            this.frmEdicion.ShadowThickness = 3;
            this.frmEdicion.Size = new System.Drawing.Size(742, 89);
            this.frmEdicion.SkinFixed = true;
            this.frmEdicion.TabIndex = 21;
            this.frmEdicion.TitleBackground = System.Drawing.Color.DodgerBlue;
            this.frmEdicion.TitleBackgroundDefault = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.frmEdicion.TitleFontColor = System.Drawing.Color.White;
            // 
            // lblCod
            // 
            this.lblCod.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.Location = new System.Drawing.Point(36, 44);
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
            this.txtCod.Location = new System.Drawing.Point(146, 44);
            this.txtCod.MaxLength = 2;
            this.txtCod.Name = "txtCod";
            this.txtCod.OnlyDigits = true;
            this.txtCod.Size = new System.Drawing.Size(44, 22);
            this.txtCod.TabIndex = 6;
            // 
            // lblDes
            // 
            this.lblDes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDes.Location = new System.Drawing.Point(223, 44);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(104, 22);
            this.lblDes.TabIndex = 107;
            this.lblDes.Text = "Descripción:";
            this.lblDes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDes
            // 
            this.txtDes.BackColor = System.Drawing.SystemColors.Window;
            this.txtDes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDes.EmptyValid = false;
            this.txtDes.Enabled = false;
            this.txtDes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDes.Location = new System.Drawing.Point(333, 44);
            this.txtDes.MaxLength = 30;
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(367, 22);
            this.txtDes.TabIndex = 7;
            // 
            // Rubros
            // 
            this.AllowEndUserDocking = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.xpnlBase);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.Document;
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Rubros";
            this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.Document;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TabText = "Mantenimiento de Rubros";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Rubros_FormClosed);
            this.Load += new System.EventHandler(this.Rubros_Load);
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
            this.frmEdicion.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private TNGS.NetControls.GlassButton gbHabilitar;
        private TNGS.NetControls.GlassButton gbDeshabilitar;
        private TNGS.NetControls.GlassButton gbCompactar;
        private TNGS.NetControls.GlassButton gbSalir;
    }
}
