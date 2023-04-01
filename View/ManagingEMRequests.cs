using System;
using System.Collections.Generic;
using ThiKyNangNghe.Models;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SqlClient;

namespace ThiKyNangNghe.View
{
    public partial class ManagingEMRequests : Form
    {
        public Employee User { get; set; }
        SqlConnection connection;
        private int RowSelected { get; set; }
        public Form PrevForm { get; set; }

        public ManagingEMRequests(Form prevForm, Employee user)
        {
            InitializeComponent();
            User = user;
            this.PrevForm = prevForm;
        }

        private void ManagingEMRequests_Load(object sender, EventArgs e)
        {
            getDataTable();
        }

        public void getDataTable()
        {
            this.data.Clear();
            string sql = "select a.ID,a.AssetSN,a.AssetName,(select MAX(em.EMEndDate) from EmergencyMaintenances as em where em.AssetID = a.ID) as LastClosedEM,(select count(*) from EmergencyMaintenances as em where em.AssetID = a.ID) as NumberOfEMs from Assets as a";

            try
            {
                connection = Connection.Connection.GetConnection();
                connection.Open();
                //xu ly 
                SqlCommand command = new SqlCommand(sql, connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ListToManagerForm listToManagerForm = new ListToManagerForm();
                    listToManagerForm.ID = reader.GetInt64(0);
                    listToManagerForm.AssetSN = reader.GetString(1);
                    listToManagerForm.AssetName = reader.GetString(2);
                    if (!reader.IsDBNull(reader.GetOrdinal("LastClosedEM")))
                    {
                        listToManagerForm.LastClosedEM = reader.GetDateTime(reader.GetOrdinal("LastClosedEM"));
                    }
                    listToManagerForm.NumberOfEMs = reader.GetInt32(4);
                    this.data.Add(listToManagerForm);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                BindingSource binding = new BindingSource();
                binding.DataSource = this.data;
                dataGridView1.DataSource = binding;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            RowSelected = e.RowIndex;
            this.dataGridView1.Rows[e.RowIndex].Selected = true;
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            // Lấy dòng hiện tại
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            // Thiết lập màu nền cho dòng
            if (data[e.RowIndex].LastClosedEM != null)
            {
                row.DefaultCellStyle.BackColor = Color.White;
            }
            else
            {
                row.DefaultCellStyle.BackColor = Color.Gray;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (data[RowSelected].LastClosedEM == null) return;
            EmergencyMaintenanceRequest emergencyMaintenanceRequest = new EmergencyMaintenanceRequest(this,data[RowSelected].ID);

            this.Hide();
            emergencyMaintenanceRequest.Show();
        }
    }
}
