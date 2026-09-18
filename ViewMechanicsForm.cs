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
    public partial class ViewMechanicsForm : Form
    {
        string connectionString =
            "Server=.\\SQLEXPRESS;" +
            "Database=TransportDB;" +
            "Trusted_Connection=True;" +
            "TrustServerCertificate=True;";
        public ViewMechanicsForm()
        {
            InitializeComponent();
        }

        private void ViewMechanicsForm_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);

                string query =
                "SELECT m.mechanic_id, " +
                "m.full_name, " +
                "m.specialization, " +
                "d.name AS depot_name " +
                "FROM Mechanic m " +
                "JOIN Depot d " +
                "ON m.depot_id = d.depot_id";

                SqlDataAdapter da =
                new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvMechanics.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}