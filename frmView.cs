using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farm
{
    public partial class frmView : Form
    {
        public frmView()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            frmDashboard db = new frmDashboard();
            db.Show();
            this.Close();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            frmDashboard db = new frmDashboard();
            db.Show();
            this.Close();
        }

        private void empInfo_Click(object sender, EventArgs e)
        {
            frmViewEmpInfo ins = new frmViewEmpInfo();
            ins.Show();
            this.Close();
        }

        private void farmProduct_Click(object sender, EventArgs e)
        {
            frmViewFarmPro ins = new frmViewFarmPro();
            ins.Show();
            this.Close();
        }

        private void production_Click(object sender, EventArgs e)
        {
            frmViewProduction ins = new frmViewProduction();
            ins.Show();
            this.Close();
        }

        private void empLocation_Click(object sender, EventArgs e)
        {
            frmViewEmpLoc ins = new frmViewEmpLoc();
            ins.Show();
            this.Close();
        }
    }
}
