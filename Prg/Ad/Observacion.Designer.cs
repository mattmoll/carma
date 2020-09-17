namespace Carm.Ad
{
    partial class Observacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Observacion));
            this.xPanel1 = new TNGS.NetControls.XPanel();
            this.gbCancel = new TNGS.NetControls.GlassButton();
            this.gbAccept = new TNGS.NetControls.GlassButton();
            this.fullLabel2 = new TNGS.NetControls.FullLabel();
            this.fullLabel1 = new TNGS.NetControls.FullLabel();
            this.teObservacion = new TNGS.NetControls.TextEdit();
            this.xPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xPanel1
            // 
            this.xPanel1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanel1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.xPanel1.BorderColor = System.Drawing.Color.Black;
            this.xPanel1.Controls.Add(this.gbCancel);
            this.xPanel1.Controls.Add(this.gbAccept);
            this.xPanel1.Controls.Add(this.fullLabel2);
            this.xPanel1.Controls.Add(this.fullLabel1);
            this.xPanel1.Controls.Add(this.teObservacion);
            this.xPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xPanel1.Location = new System.Drawing.Point(0, 0);
            this.xPanel1.Name = "xPanel1";
            this.xPanel1.Size = new System.Drawing.Size(359, 174);
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
            this.gbCancel.Location = new System.Drawing.Point(49, 136);
            this.gbCancel.Name = "gbCancel";
            this.gbCancel.RoundCorners = 2;
            this.gbCancel.Size = new System.Drawing.Size(89, 25);
            this.gbCancel.TabIndex = 4;
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
            this.gbAccept.Location = new System.Drawing.Point(232, 136);
            this.gbAccept.Name = "gbAccept";
            this.gbAccept.RoundCorners = 2;
            this.gbAccept.Size = new System.Drawing.Size(82, 25);
            this.gbAccept.TabIndex = 3;
            this.gbAccept.Text = "Aceptar";
            this.gbAccept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbAccept.W8Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gbAccept.Click += new System.EventHandler(this.gbAccept_Click);
            // 
            // fullLabel2
            // 
            this.fullLabel2.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel2.Location = new System.Drawing.Point(86, 32);
            this.fullLabel2.Name = "fullLabel2";
            this.fullLabel2.Size = new System.Drawing.Size(192, 23);
            this.fullLabel2.TabIndex = 2;
            this.fullLabel2.Text = "caracteres como máximo:";
            // 
            // fullLabel1
            // 
            this.fullLabel1.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel1.Location = new System.Drawing.Point(63, 9);
            this.fullLabel1.Name = "fullLabel1";
            this.fullLabel1.Size = new System.Drawing.Size(240, 23);
            this.fullLabel1.TabIndex = 1;
            this.fullLabel1.Text = "La observación debe ser de 120 ";
            // 
            // teObservacion
            // 
            this.teObservacion.BackColor = System.Drawing.SystemColors.Window;
            this.teObservacion.Location = new System.Drawing.Point(49, 63);
            this.teObservacion.Multiline = true;
            this.teObservacion.Name = "teObservacion";
            this.teObservacion.Size = new System.Drawing.Size(265, 53);
            this.teObservacion.TabIndex = 0;
            // 
            // Observacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(359, 174);
            this.Controls.Add(this.xPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Observacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Observación";
            this.xPanel1.ResumeLayout(false);
            this.xPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TNGS.NetControls.XPanel xPanel1;
        private TNGS.NetControls.GlassButton gbCancel;
        private TNGS.NetControls.GlassButton gbAccept;
        private TNGS.NetControls.FullLabel fullLabel2;
        private TNGS.NetControls.FullLabel fullLabel1;
        private TNGS.NetControls.TextEdit teObservacion;
    }
}