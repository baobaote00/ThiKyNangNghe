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

        public ManagingEMRequests(Employee user)
        {
            InitializeComponent();
            User = user;
        }

        private void ManagingEMRequests_Load(object sender, EventArgs e)
        {
            string sql = "select a.AssetSN,a.AssetName,(select MAX(em.EMEndDate) from EmergencyMaintenances as em where em.AssetID = a.ID) as LastClosedEM,(select count(*) from EmergencyMaintenances as em where em.AssetID = a.ID) as NumberOfEMs from Assets as a";

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
                    listToManagerForm.AssetSN = reader.GetString(0);
                    listToManagerForm.AssetName = reader.GetString(1);
                    if (!reader.IsDBNull(reader.GetOrdinal("LastClosedEM")))
                    {
                        listToManagerForm.LastClosedEM = reader.GetDateTime(reader.GetOrdinal("LastClosedEM"));
                    }
                    listToManagerForm.NumberOfEMs = reader.GetInt32(3);
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
            this.dataGridView1.Rows[e.RowIndex].Selected = true;
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            // Lấy dòng hiện tại
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            // Thiết lập màu nền cho dòng
            if (data[e.RowIndex].LastClosedEM != null)
            {
                row.DefaultCellStyle.BackColor = Color.Gray; // đổi màu nền thành màu đỏ
            }
            else
            {
                row.DefaultCellStyle.BackColor = Color.White; // giữ màu nền mặc định là trắng
            }
        }

    }
}
