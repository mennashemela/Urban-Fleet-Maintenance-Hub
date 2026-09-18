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
    public partial class ViewLogsForm : Form
    {
        string connectionString =
            "Server=.\\SQLEXPRESS;" +
            "Database=TransportDB;" +
            "Trusted_Connection=True;" +
            "TrustServerCertificate=True;";
        public ViewLogsForm()
        {
            InitializeComponent();
        }

        private void ViewLogsForm_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);

                string query =
                "SELECT ml.log_id, " +
                "v.model, " +
                "m.full_name, " +
                "ml.issue_description, " +
                "ml.open_date, " +
                "ml.close_date " +
                "FROM Maintenance_Log ml " +
                "JOIN Vehicle v " +
                "ON ml.vehicle_id = v.vehicle_id " +
                "JOIN Mechanic m " +
                "ON ml.mechanic_id = m.mechanic_id";

                SqlDataAdapter da =
                new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvLogs.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
