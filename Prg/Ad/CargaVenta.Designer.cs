namespace Carm.Ad
{
    partial class CargaVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CargaVenta));
            this.xPanel1 = new TNGS.NetControls.XPanel();
            this.dcePrecioFinal = new TNGS.NetControls.DecimalEdit();
            this.fullLabel1 = new TNGS.NetControls.FullLabel();
            this.neCantPersonas = new TNGS.NetControls.NumberEdit();
            this.fullLabel8 = new TNGS.NetControls.FullLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.cdcListaDePrecios = new TNGS.NetControls.CDCombo();
            this.mrServicios = new TNGS.NetControls.MiniReport();
            this.GBCancel = new TNGS.NetControls.GlassButton();
            this.GBAccept = new TNGS.NetControls.GlassButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cdcPlan = new TNGS.NetControls.CDCombo();
            this.fullLabel5 = new TNGS.NetControls.FullLabel();
            this.pnlFieldsSocios = new System.Windows.Forms.Panel();
            this.xPanel1.SuspendLayout();
            this.pnlFieldsSocios.SuspendLayout();
            this.SuspendLayout();
            // 
            // xPanel1
            // 
            this.xPanel1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanel1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanel1.BorderColor = System.Drawing.Color.Black;
            this.xPanel1.Controls.Add(this.pnlFieldsSocios);
            this.xPanel1.Controls.Add(this.fullLabel5);
            this.xPanel1.Controls.Add(this.dcePrecioFinal);
            this.xPanel1.Controls.Add(this.fullLabel1);
            this.xPanel1.Controls.Add(this.mrServicios);
            this.xPanel1.Controls.Add(this.GBCancel);
            this.xPanel1.Controls.Add(this.GBAccept);
            this.xPanel1.Controls.Add(this.label2);
            this.xPanel1.Controls.Add(this.cdcPlan);
            this.xPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xPanel1.Location = new System.Drawing.Point(0, 0);
            this.xPanel1.Name = "xPanel1";
            this.xPanel1.Size = new System.Drawing.Size(546, 568);
            this.xPanel1.SkinFixed = true;
            this.xPanel1.TabIndex = 0;
            // 
            // dcePrecioFinal
            // 
            this.dcePrecioFinal.BackColor = System.Drawing.SystemColors.Window;
            this.dcePrecioFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dcePrecioFinal.Location = new System.Drawing.Point(256, 460);
            this.dcePrecioFinal.MaxLength = 13;
            this.dcePrecioFinal.Name = "dcePrecioFinal";
            this.dcePrecioFinal.Size = new System.Drawing.Size(111, 27);
            this.dcePrecioFinal.TabIndex = 155;
            this.dcePrecioFinal.Text = "0.00";
            // 
            // fullLabel1
            // 
            this.fullLabel1.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel1.Location = new System.Drawing.Point(134, 461);
            this.fullLabel1.Name = "fullLabel1";
            this.fullLabel1.Size = new System.Drawing.Size(135, 22);
            this.fullLabel1.TabIndex = 154;
            this.fullLabel1.Text = "Precio Final:";
            // 
            // neCantPersonas
            // 
            this.neCantPersonas.BackColor = System.Drawing.SystemColors.Window;
            this.neCantPersonas.Location = new System.Drawing.Point(333, 44);
            this.neCantPersonas.Name = "neCantPersonas";
            this.neCantPersonas.NegativeValid = false;
            this.neCantPersonas.Size = new System.Drawing.Size(116, 22);
            this.neCantPersonas.TabIndex = 151;
            this.neCantPersonas.Text = "0";
            this.neCantPersonas.ZeroValid = false;
            this.neCantPersonas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.neCantPersonas_KeyUp);
            // 
            // fullLabel8
            // 
            this.fullLabel8.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.fullLabel8.Location = new System.Drawing.Point(329, 15);
            this.fullLabel8.Name = "fullLabel8";
            this.fullLabel8.Size = new System.Drawing.Size(181, 22);
            this.fullLabel8.TabIndex = 152;
            this.fullLabel8.Text = "Cantidad de Personas:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 22);
            this.label1.TabIndex = 150;
            this.label1.Text = "Lista de Precios:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cdcListaDePrecios
            // 
            this.cdcListaDePrecios.BackColor = System.Drawing.SystemColors.Window;
            this.cdcListaDePrecios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdcListaDePrecios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cdcListaDePrecios.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdcListaDePrecios.Location = new System.Drawing.Point(13, 40);
            this.cdcListaDePrecios.Name = "cdcListaDePrecios";
            this.cdcListaDePrecios.Size = new System.Drawing.Size(226, 26);
            this.cdcListaDePrecios.Sorted = true;
            this.cdcListaDePrecios.TabIndex = 149;
            this.cdcListaDePrecios.Leave += new System.EventHandler(this.cdcListaDePrecios_Leave);
            // 
            // mrServicios
            // 
            this.mrServicios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mrServicios.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrServicios.Location = new System.Drawing.Point(9, 105);
            this.mrServicios.Name = "mrServicios";
            this.mrServicios.ShowExcel = false;
            this.mrServicios.ShowFilter = false;
            this.mrServicios.ShowPrtAll = false;
            this.mrServicios.ShowPrtOne = false;
            this.mrServicios.ShowZoom = false;
            this.mrServicios.Size = new System.Drawing.Size(522, 235);
            this.mrServicios.SkinFixed = true;
            this.mrServicios.TabIndex = 148;
            // 
            // GBCancel
            // 
            this.GBCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GBCancel.BackgroundImage")));
            this.GBCancel.BlackBorder = true;
            this.GBCancel.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.GBCancel.CircleButton = false;
            this.GBCancel.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Cancel;
            this.GBCancel.FlatColor = System.Drawing.Color.Red;
            this.GBCancel.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Cancelar;
            this.GBCancel.FlatFontSize = 9;
            this.GBCancel.FlatTextColor = System.Drawing.Color.Black;
            this.GBCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.GBCancel.Location = new System.Drawing.Point(24, 529);
            this.GBCancel.Name = "GBCancel";
            this.GBCancel.RoundCorners = 2;
            this.GBCancel.Size = new System.Drawing.Size(101, 25);
            this.GBCancel.TabIndex = 7;
            this.GBCancel.Text = "Cancelar";
            this.GBCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GBCancel.W8Color = System.Drawing.Color.Red;
            this.GBCancel.Click += new System.EventHandler(this.GBCancel_Click);
            // 
            // GBAccept
            // 
            this.GBAccept.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GBAccept.BackgroundImage")));
            this.GBAccept.BlackBorder = true;
            this.GBAccept.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.GBAccept.CircleButton = false;
            this.GBAccept.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Accept;
            this.GBAccept.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.GBAccept.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Aceptar;
            this.GBAccept.FlatFontSize = 9;
            this.GBAccept.FlatTextColor = System.Drawing.Color.Black;
            this.GBAccept.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.GBAccept.Location = new System.Drawing.Point(419, 529);
            this.GBAccept.Name = "GBAccept";
            this.GBAccept.RoundCorners = 2;
            this.GBAccept.Size = new System.Drawing.Size(100, 25);
            this.GBAccept.TabIndex = 6;
            this.GBAccept.Text = "Aceptar";
            this.GBAccept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GBAccept.W8Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.GBAccept.Click += new System.EventHandler(this.GBAccept_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 147;
            this.label2.Text = "Plan:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cdcPlan
            // 
            this.cdcPlan.BackColor = System.Drawing.SystemColors.Window;
            this.cdcPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdcPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cdcPlan.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdcPlan.Location = new System.Drawing.Point(169, 73);
            this.cdcPlan.Name = "cdcPlan";
            this.cdcPlan.Size = new System.Drawing.Size(226, 26);
            this.cdcPlan.Sorted = true;
            this.cdcPlan.TabIndex = 1;
            this.cdcPlan.SelectedIndexChanged += new System.EventHandler(this.cdcPlan_SelectedIndexChanged);
            // 
            // fullLabel5
            // 
            this.fullLabel5.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel5.Location = new System.Drawing.Point(12, 9);
            this.fullLabel5.Name = "fullLabel5";
            this.fullLabel5.Size = new System.Drawing.Size(320, 32);
            this.fullLabel5.TabIndex = 156;
            this.fullLabel5.Text = "Carga de Venta";
            this.fullLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlFieldsSocios
            // 
            this.pnlFieldsSocios.BackColor = System.Drawing.Color.Transparent;
            this.pnlFieldsSocios.Controls.Add(this.cdcListaDePrecios);
            this.pnlFieldsSocios.Controls.Add(this.label1);
            this.pnlFieldsSocios.Controls.Add(this.fullLabel8);
            this.pnlFieldsSocios.Controls.Add(this.neCantPersonas);
            this.pnlFieldsSocios.Location = new System.Drawing.Point(9, 349);
            this.pnlFieldsSocios.Name = "pnlFieldsSocios";
            this.pnlFieldsSocios.Size = new System.Drawing.Size(516, 87);
            this.pnlFieldsSocios.TabIndex = 157;
            // 
            // CargaVenta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(546, 568);
            this.Controls.Add(this.xPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CargaVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Carga Venta";
            this.Load += new System.EventHandler(this.CargaVenta_Load);
            this.xPanel1.ResumeLayout(false);
            this.xPanel1.PerformLayout();
            this.pnlFieldsSocios.ResumeLayout(false);
            this.pnlFieldsSocios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TNGS.NetControls.XPanel xPanel1;
        private System.Windows.Forms.Label label2;
        private TNGS.NetControls.CDCombo cdcPlan;
        private TNGS.NetControls.GlassButton GBCancel;
        private TNGS.NetControls.GlassButton GBAccept;
        private TNGS.NetControls.MiniReport mrServicios;
        private System.Windows.Forms.Label label1;
        private TNGS.NetControls.CDCombo cdcListaDePrecios;
        private TNGS.NetControls.FullLabel fullLabel1;
        private TNGS.NetControls.NumberEdit neCantPersonas;
        private TNGS.NetControls.FullLabel fullLabel8;
        private TNGS.NetControls.DecimalEdit dcePrecioFinal;
        private TNGS.NetControls.FullLabel fullLabel5;
        private System.Windows.Forms.Panel pnlFieldsSocios;
    }
}