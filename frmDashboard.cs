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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            frmView ins = new frmView();
            ins.Show();
            this.Close();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                frmLogin lf = new frmLogin();
                lf.Show();
                this.Close();
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            frmLogin lf = new frmLogin();
            lf.Show();
            this.Close();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            frmInsert ins = new frmInsert();
            ins.Show();
            this.Close();            
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            frmUpdate db = new frmUpdate();
            db.Show();
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            frmDelete db = new frmDelete();
            db.Show();
            this.Close();
        }
    }
}
