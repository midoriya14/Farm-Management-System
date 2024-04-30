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
    public partial class frmViewFarmPro : Form
    {
        OracleConnection con;
        public frmViewFarmPro()
        {
            InitializeComponent();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            frmView db = new frmView();
            db.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            frmView db = new frmView();
            db.Show();
            this.Close();
        }

        private void frmViewFarmPro_Load(object sender, EventArgs e)
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

                string sqlQuery = "SELECT * FROM FarmProductSummaryView";

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
    }
}
