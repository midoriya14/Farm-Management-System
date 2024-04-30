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
    public partial class frmInsert : Form
    {
        OracleConnection con;
        public frmInsert()
        {
            InitializeComponent();
        }
        private void frmInsert_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/XE; USER ID=KUGI;PASSWORD=lolipop";
            con = new OracleConnection(conStr);
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                con.Close();
                con.Open();

                string sqlQuery = "SELECT e.EMPLOYEEID, e.NAME, ed.CONTACTNUMBER, ed.ADDRESS, ed.HIREDATE, ed.SALARY, ed.BANKACCOUNTNUMBER, e.ROLEID, e.FARMID FROM Employee e JOIN EmployeeDetails ed ON e.EMPLOYEEDETAILSID = ed.EMPLOYEEDETAILSID";

                using (OracleCommand cmd = new OracleCommand(sqlQuery, con))
                {
                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        guna2DataGridView1.DataSource = dataTable;
                    }
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
        private void logOut_Click(object sender, EventArgs e)
        {
            frmDashboard db = new frmDashboard();
            db.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            frmDashboard db = new frmDashboard();
            db.Show();
            this.Close();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();

                using (OracleCommand cmd = new OracleCommand("InsertEmployeeInfo", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("p_Name", OracleDbType.Varchar2).Value = txtName.Text;
                    cmd.Parameters.Add("p_RoleID", OracleDbType.Int32).Value = Convert.ToInt32(txtRoleID.Text);
                    cmd.Parameters.Add("p_FarmID", OracleDbType.Int32).Value = Convert.ToInt32(txtFarmID.Text);
                    cmd.Parameters.Add("p_ContactNumber", OracleDbType.Varchar2).Value = txtContactNumber.Text;
                    cmd.Parameters.Add("p_Address", OracleDbType.Varchar2).Value = txtAddress2.Text;
                    cmd.Parameters.Add("p_HireDate", OracleDbType.Date).Value = dtPickerHireDate.Value;
                    cmd.Parameters.Add("p_Salary", OracleDbType.Int32).Value = Convert.ToInt32(txtSalary2.Text);
                    cmd.Parameters.Add("p_BankAccountNumber", OracleDbType.Varchar2).Value = txtBankAccountNumber2.Text;

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Employee information inserted successfully!");
                    LoadData();

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

        private void dtPickerHireDate_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show("You cannot change the date and time. It will be generated automatically.");
        }

        private void dtPickerHireDate_DropDown(object sender, EventArgs e)
        {
            
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
