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
    public partial class frmRegister : Form
    {
        OracleConnection con;
        public frmRegister()
        {
            InitializeComponent();
            this.Load += frmRegister_Load;
        }
        private void frmRegister_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtUser;
            string conStr = @"DATA SOURCE = localhost:1521/XE; USER ID=KUGI;PASSWORD=lolipop";
            con = new OracleConnection(conStr);
            
        }
        private void regLabel_Click(object sender, EventArgs e)
        {
            frmLogin fr = new frmLogin();
            fr.Show();
            this.Hide();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (txtPass.Text!= cnfPass.Text)
            {
                MessageBox.Show("Passwords do not match. Please re-enter.");
                txtPass.Text = "";
                cnfPass.Text = "";
                txtPass.Focus();
                return;
            }
            try
            {
                con.Open();
                OracleCommand insertEmp = con.CreateCommand();
                insertEmp.CommandText = "INSERT INTO UserAuthentication (username, password) VALUES (:1, :2)";
                insertEmp.CommandType = CommandType.Text;

                insertEmp.Parameters.Add(":1", OracleDbType.Varchar2).Value = txtUser.Text;
                insertEmp.Parameters.Add(":2", OracleDbType.Varchar2).Value = txtPass.Text;

                int rows = insertEmp.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Registration Successful!");
                    txtUser.Text = "";
                    txtUser.Focus();
                    txtPass.Text = "";                    
                    cnfPass.Text = "";

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
                // Show the password characters
                txtPass.UseSystemPasswordChar = false;
                cnfPass.UseSystemPasswordChar = false;
            }
            else
            {
                // Hide the password characters
                txtPass.UseSystemPasswordChar = true;
                cnfPass.UseSystemPasswordChar = true;
            }
        }

        private void passHide_Click(object sender, EventArgs e)
        {
            if(txtPass.PasswordChar == '●')
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

        private void cnfHide_Click(object sender, EventArgs e)
        {
            if (cnfPass.PasswordChar == '●')
            {
                cnfShow.BringToFront();
                cnfPass.PasswordChar = '\0';
            }
        }

        private void cnfShow_Click(object sender, EventArgs e)
        {
            if (cnfPass.PasswordChar == '\0')
            {
                cnfHide.BringToFront();
                cnfPass.PasswordChar = '●';
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

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
                cnfPass.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void cnfPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                registerBtn.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
