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
    public partial class DeleteVehicleForm : Form
    {
        string connectionString =
            "Server=.\\SQLEXPRESS;" +
            "Database=TransportDB;" +
            "Trusted_Connection=True;" +
            "TrustServerCertificate=True;";
        public DeleteVehicleForm()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);

                int id = int.Parse(txtVehicleID.Text);

                con.Open();

                SqlCommand cmd1 = new SqlCommand(
                    "DELETE FROM Log_Part WHERE log_id IN " +
                    "(SELECT log_id FROM Maintenance_Log WHERE vehicle_id=@id)", con);

                cmd1.Parameters.AddWithValue("@id", id);
                cmd1.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand(
                    "DELETE FROM Maintenance_Log WHERE vehicle_id=@id", con);

                cmd2.Parameters.AddWithValue("@id", id);
                cmd2.ExecuteNonQuery();

                SqlCommand cmd3 = new SqlCommand(
                    "DELETE FROM Inspection WHERE vehicle_id=@id", con);

                cmd3.Parameters.AddWithValue("@id", id);
                cmd3.ExecuteNonQuery();

                SqlCommand cmd4 = new SqlCommand(
                    "DELETE FROM Vehicle WHERE vehicle_id=@id", con);

                cmd4.Parameters.AddWithValue("@id", id);
                cmd4.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Vehicle Deleted Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
