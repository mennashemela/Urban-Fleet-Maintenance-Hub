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
    public partial class Form1 : Form
    {
        string connectionString =
            "Server=.\\SQLEXPRESS;" +
            "Database=TransportDB;" +
            "Trusted_Connection=True;" +
            "TrustServerCertificate=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            AddVehicleForm form = new AddVehicleForm();
            form.Show();
        }

        private void btnViewVehicles_Click(object sender, EventArgs e)
        {
            ViewVehiclesForm form = new ViewVehiclesForm();
            form.Show();
        }

        private void btnDeleteVehicle_Click(object sender, EventArgs e)
        {
            DeleteVehicleForm form = new DeleteVehicleForm();
            form.Show();
        }

        private void btnAddMechanic_Click(object sender, EventArgs e)
        {
            AddMechanicForm form = new AddMechanicForm();
            form.Show();
        }

        private void btnDeleteMechanic_Click(object sender, EventArgs e)
        {
            DeleteMechanicsForm form = new DeleteMechanicsForm();
            form.Show();
        }

        private void btnUpdateVehicle_Click(object sender, EventArgs e)
        {
            UpdateVehicleForm form = new UpdateVehicleForm();
            form.Show();
        }

        private void btnCloseLog_Click(object sender, EventArgs e)
        {
            CloseLogForm form = new CloseLogForm();
            form.Show();
        }

        private void btnViewMechanics_Click(object sender, EventArgs e)
        {
            ViewMechanicsForm form = new ViewMechanicsForm();
            form.Show();
        }

        private void btnViewLogs_Click(object sender, EventArgs e)
        {
            ViewLogsForm form = new ViewLogsForm();
            form.Show();
        }

        private void btnInquiry_Click(object sender, EventArgs e)
        {
            InquiryForm form = new InquiryForm();
            form.Show();
        }
    }
}
