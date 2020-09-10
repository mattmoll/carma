using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TNGS.NetApp;

namespace Carm.Ad
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
			
			App.SetMainWindow(this, null, (ToolStrip)null, null, null, null, null, null);

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Home_Activated(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

    }
}
