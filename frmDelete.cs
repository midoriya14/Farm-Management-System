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
    public partial class frmDelete : Form
    {
        OracleConnection con;
        public frmDelete()
        {
            InitializeComponent();

        }

        private void frmDelete_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/XE; USER ID=KUGI;PASSWORD=lolipop";
            con = new OracleConnection(conStr);
            LoadData();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtEmployeeID.Text, out int employeeID))
            {
                if (MessageBox.Show("Are you sure you want to delete this employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();

                        using (OracleCommand cmd = new OracleCommand("DeleteEmployeeInfo", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("p_EmployeeID", OracleDbType.Int32).Value = employeeID;

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Employee information deleted successfully!");
                        LoadData();
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
            }
            else
            {
                MessageBox.Show("Please enter a valid EmployeeID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
