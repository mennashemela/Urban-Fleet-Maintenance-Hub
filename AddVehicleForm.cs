using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportDB_GUI
{
    public partial class AddVehicleForm : Form
    {
        public AddVehicleForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string connectionString =
        "Server=.\\SQLEXPRESS;" +
        "Database=TransportDB;" +
        "Trusted_Connection=True;" +
        "TrustServerCertificate=True;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query =
                "INSERT INTO Vehicle(model, fuel_type, capacity, status) " +
                "VALUES (@model, @fuel, @capacity, @status)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@model", txtModel.Text);
                cmd.Parameters.AddWithValue("@fuel", txtFuel.Text);
                cmd.Parameters.AddWithValue("@capacity", int.Parse(txtCapacity.Text));
                cmd.Parameters.AddWithValue("@status", txtStatus.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Vehicle Added Successfully");
            }
        }
    }
}
