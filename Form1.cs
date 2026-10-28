using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace AutoCareSystem
{
    public partial class Form1 : Form
    {
        private readonly string connectionString =
              @"Server=A;Database=AutoCareDB;Integrated Security=True;TrustServerCertificate=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadServices();
        }

        private void LoadServices()
        {
            try
            {
                string query = "SELECT * FROM VehicleService ORDER BY ServiceID DESC";
                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable table = new DataTable();
                        table.Load(reader);
                        dgvServices.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load service records: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            txtServiceNumber.Clear();
            txtCustomerName.Clear();
            txtIDNumber.Clear();
            txtContactNumber.Clear();
            txtVehicleRegistration.Clear();
            txtVehicleMake.Clear();
            txtVehicleModel.Clear();
            txtVehicleYear.Clear();
            txtServiceType.Clear();
            txtTechnician.Clear();
            txtServiceCost.Clear();
            cmbPaymentStatus.SelectedIndex = -1;
            dtpServiceDate.Value = DateTime.Today;
            dtpNextServiceDate.Value = DateTime.Today.AddMonths(3);
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtServiceNumber.Text) ||
                string.IsNullOrWhiteSpace(txtCustomerName.Text) ||
                string.IsNullOrWhiteSpace(txtVehicleRegistration.Text))
            {
                MessageBox.Show("Fill Service Number, Customer Name and Registration!");
                return false;
            }
            if (!decimal.TryParse(txtServiceCost.Text, out _))
            {
                MessageBox.Show("Service Cost must be a number!");
                return false;
            }
            if (!int.TryParse(txtVehicleYear.Text, out _))
            {
                MessageBox.Show("Vehicle Year must be a number!");
                return false;
            }
            return true;
        }

        // REQUIRED BY DESIGNER - ALL THE MISSING METHODS
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInputs()) return;
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string q = "INSERT INTO VehicleService VALUES (@num,@cname,@id,@contact,@reg,@make,@model,@year,@stype,@tech,@cost,@sdate,@nsdate,@pay)";
                    using (SqlCommand cmd = new SqlCommand(q, con))
                    {
                        cmd.Parameters.AddWithValue("@num", txtServiceNumber.Text);
                        cmd.Parameters.AddWithValue("@cname", txtCustomerName.Text);
                        cmd.Parameters.AddWithValue("@id", txtIDNumber.Text);
                        cmd.Parameters.AddWithValue("@contact", txtContactNumber.Text);
                        cmd.Parameters.AddWithValue("@reg", txtVehicleRegistration.Text);
                        cmd.Parameters.AddWithValue("@make", txtVehicleMake.Text);
                        cmd.Parameters.AddWithValue("@model", txtVehicleModel.Text);
                        cmd.Parameters.AddWithValue("@year", int.Parse(txtVehicleYear.Text));
                        cmd.Parameters.AddWithValue("@stype", txtServiceType.Text);
                        cmd.Parameters.AddWithValue("@tech", txtTechnician.Text);
                        cmd.Parameters.AddWithValue("@cost", decimal.Parse(txtServiceCost.Text));
                        cmd.Parameters.AddWithValue("@sdate", dtpServiceDate.Value);
                        cmd.Parameters.AddWithValue("@nsdate", dtpNextServiceDate.Value);
                        cmd.Parameters.AddWithValue("@pay", cmbPaymentStatus.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Registered!"); LoadServices(); ClearFields();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnView_Click(object sender, EventArgs e) { LoadServices(); }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string search = txtServiceNumber.Text.Trim();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string q = "SELECT * FROM VehicleService WHERE ServiceNumber LIKE @s OR VehicleRegistration LIKE @s";
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.Parameters.AddWithValue("@s", "%" + search + "%");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable(); da.Fill(dt);
                    dgvServices.DataSource = dt;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInputs()) return;
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string q = "UPDATE VehicleService SET CustomerName=@cn, IDNumber=@id, ContactNumber=@co, VehicleRegistration=@rg, VehicleMake=@mk, VehicleModel=@mo, VehicleYear=@yr, ServiceType=@st, Technician=@te, ServiceCost=@cs, ServiceDate=@sd, NextServiceDate=@ns, PaymentStatus=@ps WHERE ServiceNumber=@num";
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.Parameters.AddWithValue("@num", txtServiceNumber.Text);
                    cmd.Parameters.AddWithValue("@cn", txtCustomerName.Text);
                    cmd.Parameters.AddWithValue("@id", txtIDNumber.Text);
                    cmd.Parameters.AddWithValue("@co", txtContactNumber.Text);
                    cmd.Parameters.AddWithValue("@rg", txtVehicleRegistration.Text);
                    cmd.Parameters.AddWithValue("@mk", txtVehicleMake.Text);
                    cmd.Parameters.AddWithValue("@mo", txtVehicleModel.Text);
                    cmd.Parameters.AddWithValue("@yr", int.Parse(txtVehicleYear.Text));
                    cmd.Parameters.AddWithValue("@st", txtServiceType.Text);
                    cmd.Parameters.AddWithValue("@te", txtTechnician.Text);
                    cmd.Parameters.AddWithValue("@cs", decimal.Parse(txtServiceCost.Text));
                    cmd.Parameters.AddWithValue("@sd", dtpServiceDate.Value);
                    cmd.Parameters.AddWithValue("@ns", dtpNextServiceDate.Value);
                    cmd.Parameters.AddWithValue("@ps", cmbPaymentStatus.Text);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Updated!"); LoadServices();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM VehicleService WHERE ServiceNumber=@num", con);
                    cmd.Parameters.AddWithValue("@num", txtServiceNumber.Text);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Deleted!"); LoadServices(); ClearFields();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    int total = (int)new SqlCommand("SELECT COUNT(*) FROM VehicleService", con).ExecuteScalar();
                    object incObj = new SqlCommand("SELECT SUM(ServiceCost) FROM VehicleService WHERE PaymentStatus='Paid'", con).ExecuteScalar();
                    decimal income = incObj == DBNull.Value ? 0 : Convert.ToDecimal(incObj);
                    int unpaid = (int)new SqlCommand("SELECT COUNT(*) FROM VehicleService WHERE PaymentStatus='Unpaid'", con).ExecuteScalar();

                    string report = $"Total Services: {total}\nTotal Income: R{income}\nOutstanding: {unpaid}\n\n";
                    SqlCommand cmd = new SqlCommand("SELECT Technician, COUNT(*) as Cnt FROM VehicleService GROUP BY Technician", con);
                    SqlDataReader r = cmd.ExecuteReader();
                    report += "By Technician:\n";
                    while (r.Read()) { report += $"{r["Technician"]}: {r["Cnt"]}\n"; }
                    r.Close();
                    MessageBox.Show(report);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnClear_Click(object sender, EventArgs e) { ClearFields(); }

        private void dgvServices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvServices.Rows[e.RowIndex];
                txtServiceNumber.Text = row.Cells["ServiceNumber"].Value?.ToString();
                txtCustomerName.Text = row.Cells["CustomerName"].Value?.ToString();
                txtIDNumber.Text = row.Cells["IDNumber"].Value?.ToString();
                txtContactNumber.Text = row.Cells["ContactNumber"].Value?.ToString();
                txtVehicleRegistration.Text = row.Cells["VehicleRegistration"].Value?.ToString();
                txtVehicleMake.Text = row.Cells["VehicleMake"].Value?.ToString();
                txtVehicleModel.Text = row.Cells["VehicleModel"].Value?.ToString();
                txtVehicleYear.Text = row.Cells["VehicleYear"].Value?.ToString();
                txtServiceType.Text = row.Cells["ServiceType"].Value?.ToString();
                txtTechnician.Text = row.Cells["Technician"].Value?.ToString();
                txtServiceCost.Text = row.Cells["ServiceCost"].Value?.ToString();
                cmbPaymentStatus.Text = row.Cells["PaymentStatus"].Value?.ToString();
            }
        }
    }
}