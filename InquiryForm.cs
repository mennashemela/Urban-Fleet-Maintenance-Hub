using System;
using System.Collections;
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
    public partial class InquiryForm : Form
    {
        string connectionString =
            "Server=.\\SQLEXPRESS;" +
            "Database=TransportDB;" +
            "Trusted_Connection=True;" +
            "TrustServerCertificate=True;";
        public InquiryForm()
        {
            InitializeComponent();
        }

        private void LoadData(string query)
        {
            try
            {
                SqlConnection con =
                new SqlConnection(connectionString);

                SqlDataAdapter da =
                new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvInquiry.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnQ1_Click(object sender, EventArgs e)
        {
            string query =
        "SELECT TOP 1 v.model, COUNT(*) AS log_count " +
        "FROM Maintenance_Log ml " +
        "JOIN Vehicle v ON ml.vehicle_id = v.vehicle_id " +
        "WHERE MONTH(ml.open_date) = MONTH(DATEADD(MONTH,-1,GETDATE())) " +
        "AND YEAR(ml.open_date) = YEAR(DATEADD(MONTH,-1,GETDATE())) " +
        "GROUP BY v.model " +
        "ORDER BY log_count DESC";

            LoadData(query);
        }

        private void btnQ2_Click(object sender, EventArgs e)
        {
            string query =
        "SELECT v.vehicle_id, v.model " +
        "FROM Vehicle v " +
        "WHERE v.vehicle_id NOT IN (" +
        "SELECT vehicle_id FROM Maintenance_Log " +
        "WHERE MONTH(open_date)=MONTH(DATEADD(MONTH,-1,GETDATE())) " +
        "AND YEAR(open_date)=YEAR(DATEADD(MONTH,-1,GETDATE())))";

            LoadData(query);
        }

        private void btnQ3_Click(object sender, EventArgs e)
        {
            string query =
       "SELECT TOP 1 m.full_name, COUNT(*) AS tasks " +
       "FROM Maintenance_Log ml " +
       "JOIN Mechanic m ON ml.mechanic_id = m.mechanic_id " +
       "WHERE ml.close_date IS NOT NULL " +
       "AND MONTH(ml.open_date)=MONTH(DATEADD(MONTH,-1,GETDATE())) " +
       "AND YEAR(ml.open_date)=YEAR(DATEADD(MONTH,-1,GETDATE())) " +
       "GROUP BY m.full_name " +
       "ORDER BY tasks DESC";

            LoadData(query);
        }

        private void btnQ4_Click(object sender, EventArgs e)
        {
            string query =
        "SELECT d.depot_id, d.name " +
        "FROM Depot d " +
        "WHERE d.depot_id NOT IN (" +
        "SELECT DISTINCT depot_id FROM Maintenance_Log " +
        "WHERE MONTH(open_date)=MONTH(DATEADD(MONTH,-1,GETDATE())) " +
        "AND YEAR(open_date)=YEAR(DATEADD(MONTH,-1,GETDATE())))";

            LoadData(query);
        }

        private void btnQ5_Click(object sender, EventArgs e)
        {
            string query =
        "SELECT v.model, sp.name AS part_name, " +
        "lp.qty_part, lp.total_cost " +
        "FROM Maintenance_Log ml " +
        "JOIN Vehicle v ON ml.vehicle_id = v.vehicle_id " +
        "JOIN Log_Part lp ON ml.log_id = lp.log_id " +
        "JOIN Spare_Part sp ON lp.part_id = sp.part_id " +
        "WHERE MONTH(ml.open_date)=MONTH(DATEADD(MONTH,-1,GETDATE())) " +
        "AND YEAR(ml.open_date)=YEAR(DATEADD(MONTH,-1,GETDATE()))";

            LoadData(query);
        }

        private void btnQ6_Click(object sender, EventArgs e)
        {
            string query =
        "SELECT v.vehicle_id, v.model, " +
        "SUM(lp.total_cost) AS total_cost " +
        "FROM Maintenance_Log ml " +
        "JOIN Vehicle v ON ml.vehicle_id = v.vehicle_id " +
        "JOIN Log_Part lp ON ml.log_id = lp.log_id " +
        "WHERE MONTH(ml.open_date)=MONTH(DATEADD(MONTH,-1,GETDATE())) " +
        "AND YEAR(ml.open_date)=YEAR(DATEADD(MONTH,-1,GETDATE())) " +
        "GROUP BY v.vehicle_id, v.model";

            LoadData(query);
        }
    }
}
