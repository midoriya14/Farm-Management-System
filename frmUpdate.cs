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
    public partial class frmUpdate : Form
    {
        OracleConnection con;
        public frmUpdate()
        {
            InitializeComponent();
            guna2DataGridView1.CellClick += guna2DataGridView1_CellContentClick;

        }

        private void frmUpdate_Load(object sender, EventArgs e)
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

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = guna2DataGridView1.Rows[e.RowIndex];

                txtName.Text = selectedRow.Cells["NAME"].Value.ToString();
                txtRoleID.Text = selectedRow.Cells["ROLEID"].Value.ToString();
                empID.Text = selectedRow.Cells["EMPLOYEEID"].Value.ToString();
                txtFarmID.Text = selectedRow.Cells["FARMID"].Value.ToString();
                txtContactNumber.Text = selectedRow.Cells["CONTACTNUMBER"].Value.ToString();
                txtAddress2.Text = selectedRow.Cells["ADDRESS"].Value.ToString();
                dtPickerHireDate.Value = Convert.ToDateTime(selectedRow.Cells["HIREDATE"].Value);
                txtSalary2.Text = selectedRow.Cells["SALARY"].Value.ToString();
                txtBankAccountNumber2.Text = selectedRow.Cells["BANKACCOUNTNUMBER"].Value.ToString();
            }

        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                using (OracleCommand cmd = new OracleCommand("UpdateEmployeeInfo", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("p_EmployeeID", OracleDbType.Int32).Value = Convert.ToInt32(empID.Text); ;

                    cmd.Parameters.Add("p_Name", OracleDbType.Varchar2).Value = txtName.Text;
                    cmd.Parameters.Add("p_RoleID", OracleDbType.Int32).Value = Convert.ToInt32(txtRoleID.Text);
                    cmd.Parameters.Add("p_FarmID", OracleDbType.Int32).Value = Convert.ToInt32(txtFarmID.Text);
                    cmd.Parameters.Add("p_ContactNumber", OracleDbType.Varchar2).Value = txtContactNumber.Text;
                    cmd.Parameters.Add("p_Address", OracleDbType.Varchar2).Value = txtAddress2.Text;
                    cmd.Parameters.Add("p_HireDate", OracleDbType.Date).Value = dtPickerHireDate.Value;
                    cmd.Parameters.Add("p_Salary", OracleDbType.Int32).Value = Convert.ToInt32(txtSalary2.Text);
                    cmd.Parameters.Add("p_BankAccountNumber", OracleDbType.Varchar2).Value = txtBankAccountNumber2.Text;

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Employee information updated successfully!");
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
        private void SearchDataByEmployeeID(int employeeID)
        {
            try
            {
                con.Open();

                string query = "SELECT e.EMPLOYEEID, e.NAME, ed.CONTACTNUMBER, ed.ADDRESS, ed.HIREDATE, ed.SALARY, ed.BANKACCOUNTNUMBER, e.ROLEID, e.FARMID FROM Employee e JOIN EmployeeDetails ed ON e.EMPLOYEEDETAILSID = ed.EMPLOYEEDETAILSID and EMPLOYEEID = :EmployeeID";


                using (OracleCommand cmd = new OracleCommand(query, con))
                {
                    cmd.Parameters.Add(":EmployeeID", OracleDbType.Int32).Value = employeeID;

                    OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        DataRow row = dataTable.Rows[0];

                        txtName.Text = row["NAME"].ToString();
                        txtRoleID.Text = row["ROLEID"].ToString();
                        txtFarmID.Text = row["FARMID"].ToString();
                        txtContactNumber.Text = row["CONTACTNUMBER"].ToString();
                        txtAddress2.Text = row["ADDRESS"].ToString();
                        dtPickerHireDate.Value = Convert.ToDateTime(row["HIREDATE"]);
                        txtSalary2.Text = row["SALARY"].ToString();
                        txtBankAccountNumber2.Text = row["BANKACCOUNTNUMBER"].ToString();

                        int rowIndex = -1;
                        foreach (DataGridViewRow dgvRow in guna2DataGridView1.Rows)
                        {
                            if (Convert.ToInt32(dgvRow.Cells["EMPLOYEEID"].Value) == employeeID)
                            {
                                rowIndex = dgvRow.Index;
                                break;
                            }
                        }

                        
                        if (rowIndex != -1)
                        {
                            guna2DataGridView1.ClearSelection();
                            guna2DataGridView1.Rows[rowIndex].Selected = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No data found for the specified EMPLOYEEID.");
                        ClearTextBoxes();
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

        private void ClearTextBoxes()
        {
            txtName.Text = string.Empty;
            txtRoleID.Text = string.Empty;
            txtFarmID.Text = string.Empty;
            txtContactNumber.Text = string.Empty;
            txtAddress2.Text = string.Empty;
            dtPickerHireDate.Value = DateTime.Now;
            txtSalary2.Text = string.Empty;
            txtBankAccountNumber2.Text = string.Empty;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(empID.Text) && int.TryParse(empID.Text, out int employeeID))
            {
                SearchDataByEmployeeID(employeeID);
            }
            else
            {
                MessageBox.Show("Please enter a valid EMPLOYEEID for search.");
            }
        }
    }
}
