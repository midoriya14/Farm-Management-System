using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Farm
{
    public partial class frmLogin : Form
    {
        OracleConnection con;
        public frmLogin()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtUser;
            string conStr = @"DATA SOURCE = localhost:1521/XE; USER ID=KUGI; PASSWORD=lolipop";
            con = new OracleConnection(conStr);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OracleCommand loginCommand = con.CreateCommand();
                loginCommand.CommandText = "SELECT COUNT(*) FROM userAuthentication WHERE username = :username AND password = :password";
                loginCommand.CommandType = CommandType.Text;
                loginCommand.Parameters.Add(":username", OracleDbType.Varchar2).Value = txtUser.Text;
                loginCommand.Parameters.Add(":password", OracleDbType.Varchar2).Value = txtPass.Text;

                int count = Convert.ToInt32(loginCommand.ExecuteScalar());

                if (count > 0)
                {
                    frmDashboard fd = new frmDashboard();
                    fd.Show();
                    this.Hide();
                    MessageBox.Show("Login Successful!");
                }

                else
                {
                    MessageBox.Show("Invalid Username or Password! Please Try Again.");
                    txtUser.Text = "";
                    txtPass.Text = "";
                    txtUser.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked == true)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void regLabel_Click(object sender, EventArgs e)
        {
            frmRegister fr = new frmRegister();
            fr.Show();
            this.Hide();
        }

        private void passHide_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '●')
            {
                passShow.BringToFront();
                txtPass.PasswordChar = '\0';
            }
        }

        private void passShow_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '\0')
            {
                passHide.BringToFront();
                txtPass.PasswordChar = '●';
            }
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPass.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guna2Button1.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
