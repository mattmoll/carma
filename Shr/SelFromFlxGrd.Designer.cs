namespace Carm.Shr
{
    partial class SelFromFlxGrd
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
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelFromFlxGrd));
            this.xpnlBase = new TNGS.NetControls.XPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flxgSelect = new TNGS.NetControls.FlexGrid();
            this.xpnlBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // xpnlBase
            // 
            this.xpnlBase.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xpnlBase.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.xpnlBase.BorderColor = System.Drawing.Color.Black;
            this.xpnlBase.Controls.Add(this.label3);
            this.xpnlBase.Controls.Add(this.label2);
            this.xpnlBase.Controls.Add(this.flxgSelect);
            this.xpnlBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xpnlBase.Location = new System.Drawing.Point(0, 0);
            this.xpnlBase.Name = "xpnlBase";
            this.xpnlBase.Size = new System.Drawing.Size(703, 378);
            this.xpnlBase.SkinFixed = true;
            this.xpnlBase.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(477, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "[Esc]- Cancela";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(70, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "[Enter]- Confirma selección";
            // 
            // flxgSelect
            // 
            this.flxgSelect.ExcelTitle = "";
            this.flxgSelect.Location = new System.Drawing.Point(12, 12);
            this.flxgSelect.Name = "flxgSelect";
            this.flxgSelect.OwnerDraw = true;
            this.flxgSelect.Size = new System.Drawing.Size(679, 324);
            this.flxgSelect.TabIndex = 1;
            this.flxgSelect.UseCompatibleStateImageBehavior = false;
            this.flxgSelect.DoubleClick += new System.EventHandler(this.flxgSelect_DoubleClick);
            // 
            // SelFromFlxGrd
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(703, 378);
            this.Controls.Add(this.xpnlBase);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelFromFlxGrd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Seleccionar";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SelFromFlxGrd_KeyPress);
            this.xpnlBase.ResumeLayout(false);
            this.xpnlBase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TNGS.NetControls.XPanel xpnlBase;
        private TNGS.NetControls.FlexGrid flxgSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}