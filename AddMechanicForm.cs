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
    public partial class AddMechanicForm : Form
    {
        string connectionString =
            "Server=.\\SQLEXPRESS;" +
            "Database=TransportDB;" +
            "Trusted_Connection=True;" +
            "TrustServerCertificate=True;";
        public AddMechanicForm()
        {
            InitializeComponent();
        }

        private void btnAddMechanic_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);

            string query =
            "INSERT INTO Mechanic(full_name, specialization, depot_id) " +
            "VALUES(@name, @spec, @depot)";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@spec", txtSpec.Text);
            cmd.Parameters.AddWithValue("@depot", int.Parse(txtDepot.Text));

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Mechanic Added Successfully!");

        }
    }
}
