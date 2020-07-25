namespace Carm.Shr
{
    partial class Reportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportes));
            this.rpReporte = new TNGS.NetControls.Report();
            this.SuspendLayout();
            // 
            // rpReporte
            // 
            this.rpReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rpReporte.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpReporte.ISortEnable = true;
            this.rpReporte.Location = new System.Drawing.Point(0, 0);
            this.rpReporte.MSortEnable = TNGS.NetControls.Report.MSortModes.Libre;
            this.rpReporte.Name = "rpReporte";
            this.rpReporte.PrintRowEnable = false;
            this.rpReporte.Size = new System.Drawing.Size(689, 580);
            this.rpReporte.SkinFixed = true;
            this.rpReporte.TabIndex = 0;
            this.rpReporte.Advance += new TNGS.NetRoutines.AdvanceEventHandler(this.rpReporte_Advance);
            this.rpReporte.PrintGridIniting += new System.ComponentModel.CancelEventHandler(this.rpReporte_PrintGridIniting);
            this.rpReporte.PrintGridEnded += new System.EventHandler(this.rpReporte_PrintGridEnded);
            this.rpReporte.ExportGridIniting += new System.ComponentModel.CancelEventHandler(this.rpReporte_ExportGridIniting);
            this.rpReporte.ExportGridEnded += new System.EventHandler(this.rpReporte_ExportGridEnded);
            this.rpReporte.ReportLastState += new TNGS.NetRoutines.ReportLastStateEventHandler(this.rpReporte_ReportLastState);
            // 
            // Reportes
            // 
            this.AllowEndUserDocking = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 580);
            this.Controls.Add(this.rpReporte);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.Document;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.ResumeLayout(false);

        }

        #endregion

        private TNGS.NetControls.Report rpReporte;
    }
}