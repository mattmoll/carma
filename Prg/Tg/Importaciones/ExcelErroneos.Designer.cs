namespace Carm.Tg
{
    partial class ExcelErroneos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelErroneos));
            this.xPanel1 = new TNGS.NetControls.XPanel();
            this.fullLabel1 = new TNGS.NetControls.FullLabel();
            this.mrListaErroneos = new TNGS.NetControls.MiniReport();
            this.flblCantidad = new TNGS.NetControls.FullLabel();
            this.flblCantidadError = new TNGS.NetControls.FullLabel();
            this.xPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xPanel1
            // 
            this.xPanel1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanel1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.xPanel1.Controls.Add(this.flblCantidadError);
            this.xPanel1.Controls.Add(this.flblCantidad);
            this.xPanel1.Controls.Add(this.fullLabel1);
            this.xPanel1.Controls.Add(this.mrListaErroneos);
            this.xPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xPanel1.Location = new System.Drawing.Point(0, 0);
            this.xPanel1.Name = "xPanel1";
            this.xPanel1.Size = new System.Drawing.Size(713, 549);
            this.xPanel1.SkinFixed = true;
            this.xPanel1.TabIndex = 0;
            // 
            // fullLabel1
            // 
            this.fullLabel1.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel1.Location = new System.Drawing.Point(122, 9);
            this.fullLabel1.Name = "fullLabel1";
            this.fullLabel1.Size = new System.Drawing.Size(476, 51);
            this.fullLabel1.TabIndex = 2;
            this.fullLabel1.Text = "Haga click en el boton de Excel para exportar la planilla de rechazados. Corrijal" +
    "os y carguelos nuevamente.";
            this.fullLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mrListaErroneos
            // 
            this.mrListaErroneos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrListaErroneos.Location = new System.Drawing.Point(3, 63);
            this.mrListaErroneos.Name = "mrListaErroneos";
            this.mrListaErroneos.ShowFilter = false;
            this.mrListaErroneos.ShowPrtAll = false;
            this.mrListaErroneos.ShowPrtOne = false;
            this.mrListaErroneos.ShowZoom = false;
            this.mrListaErroneos.Size = new System.Drawing.Size(707, 483);
            this.mrListaErroneos.SkinFixed = true;
            this.mrListaErroneos.TabIndex = 0;
            // 
            // flblCantidad
            // 
            this.flblCantidad.BackColor = System.Drawing.Color.Transparent;
            this.flblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flblCantidad.Location = new System.Drawing.Point(3, 56);
            this.flblCantidad.Name = "flblCantidad";
            this.flblCantidad.Size = new System.Drawing.Size(152, 28);
            this.flblCantidad.TabIndex = 3;
            this.flblCantidad.Text = "Cantidad Erroneos: ";
            this.flblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flblCantidadError
            // 
            this.flblCantidadError.BackColor = System.Drawing.Color.Transparent;
            this.flblCantidadError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flblCantidadError.Location = new System.Drawing.Point(151, 56);
            this.flblCantidadError.Name = "flblCantidadError";
            this.flblCantidadError.Size = new System.Drawing.Size(152, 28);
            this.flblCantidadError.TabIndex = 4;
            this.flblCantidadError.Text = " ";
            this.flblCantidadError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExcelErroneos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 549);
            this.Controls.Add(this.xPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExcelErroneos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rechazados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExcelErroneos_FormClosing);
            this.Load += new System.EventHandler(this.ExcelErroneos_Load);
            this.xPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TNGS.NetControls.XPanel xPanel1;
        private TNGS.NetControls.MiniReport mrListaErroneos;
        private TNGS.NetControls.FullLabel fullLabel1;
        private TNGS.NetControls.FullLabel flblCantidadError;
        private TNGS.NetControls.FullLabel flblCantidad;
    }
}