namespace Carm.Ad
{
    partial class CargaServicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CargaServicio));
            this.xPanel1 = new TNGS.NetControls.XPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cdcPlanes = new TNGS.NetControls.CDCombo();
            this.GBCancel = new TNGS.NetControls.GlassButton();
            this.GBAccept = new TNGS.NetControls.GlassButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cdCombo1 = new TNGS.NetControls.CDCombo();
            this.dceVCapita = new TNGS.NetControls.DecimalEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.xPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xPanel1
            // 
            this.xPanel1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanel1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanel1.BorderColor = System.Drawing.Color.Black;
            this.xPanel1.Controls.Add(this.dceVCapita);
            this.xPanel1.Controls.Add(this.label3);
            this.xPanel1.Controls.Add(this.label2);
            this.xPanel1.Controls.Add(this.cdCombo1);
            this.xPanel1.Controls.Add(this.label1);
            this.xPanel1.Controls.Add(this.cdcPlanes);
            this.xPanel1.Controls.Add(this.GBCancel);
            this.xPanel1.Controls.Add(this.GBAccept);
            this.xPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xPanel1.Location = new System.Drawing.Point(0, 0);
            this.xPanel1.Name = "xPanel1";
            this.xPanel1.Size = new System.Drawing.Size(661, 381);
            this.xPanel1.SkinFixed = true;
            this.xPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 22);
            this.label1.TabIndex = 135;
            this.label1.Text = "Plan:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cdcPlanes
            // 
            this.cdcPlanes.BackColor = System.Drawing.SystemColors.Window;
            this.cdcPlanes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdcPlanes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cdcPlanes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdcPlanes.Location = new System.Drawing.Point(105, 16);
            this.cdcPlanes.Name = "cdcPlanes";
            this.cdcPlanes.Size = new System.Drawing.Size(226, 24);
            this.cdcPlanes.Sorted = true;
            this.cdcPlanes.TabIndex = 3;
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
            this.GBCancel.Location = new System.Drawing.Point(354, 338);
            this.GBCancel.Name = "GBCancel";
            this.GBCancel.RoundCorners = 2;
            this.GBCancel.Size = new System.Drawing.Size(89, 25);
            this.GBCancel.TabIndex = 6;
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
            this.GBAccept.Location = new System.Drawing.Point(534, 338);
            this.GBAccept.Name = "GBAccept";
            this.GBAccept.RoundCorners = 2;
            this.GBAccept.Size = new System.Drawing.Size(85, 25);
            this.GBAccept.TabIndex = 5;
            this.GBAccept.Text = "Aceptar";
            this.GBAccept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GBAccept.W8Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.GBAccept.Click += new System.EventHandler(this.GBAccept_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 33);
            this.label2.TabIndex = 137;
            this.label2.Text = "Cantidad Personas:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cdCombo1
            // 
            this.cdCombo1.BackColor = System.Drawing.SystemColors.Window;
            this.cdCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdCombo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cdCombo1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdCombo1.Location = new System.Drawing.Point(105, 70);
            this.cdCombo1.Name = "cdCombo1";
            this.cdCombo1.Size = new System.Drawing.Size(226, 24);
            this.cdCombo1.Sorted = true;
            this.cdCombo1.TabIndex = 136;
            // 
            // dceVCapita
            // 
            this.dceVCapita.BackColor = System.Drawing.SystemColors.Window;
            this.dceVCapita.Location = new System.Drawing.Point(128, 144);
            this.dceVCapita.MaxLength = 13;
            this.dceVCapita.Name = "dceVCapita";
            this.dceVCapita.Size = new System.Drawing.Size(53, 20);
            this.dceVCapita.TabIndex = 138;
            this.dceVCapita.Text = "0.00";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 22);
            this.label3.TabIndex = 139;
            this.label3.Text = "Valor Contrato:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CargaServicio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(661, 381);
            this.Controls.Add(this.xPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CargaServicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Carga de Servicio";
            this.xPanel1.ResumeLayout(false);
            this.xPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TNGS.NetControls.XPanel xPanel1;
        private TNGS.NetControls.GlassButton GBCancel;
        private TNGS.NetControls.GlassButton GBAccept;
        private System.Windows.Forms.Label label1;
        private TNGS.NetControls.CDCombo cdcPlanes;
        private System.Windows.Forms.Label label2;
        private TNGS.NetControls.CDCombo cdCombo1;
        private TNGS.NetControls.DecimalEdit dceVCapita;
        private System.Windows.Forms.Label label3;
    }
}