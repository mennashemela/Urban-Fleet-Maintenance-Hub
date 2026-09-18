using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TransportDB_GUI
{
    public partial class ViewVehiclesForm : Form
    {
        public ViewVehiclesForm()
        {
            InitializeComponent();
        }

        private void ViewVehiclesForm_Load(object sender, EventArgs e)
        {
            string connectionString =
            "Server=.\\SQLEXPRESS;" +
            "Database=TransportDB;" +
            "Trusted_Connection=True;" +
            "TrustServerCertificate=True;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Vehicle";

                SqlDataAdapter da = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }
    }
}
