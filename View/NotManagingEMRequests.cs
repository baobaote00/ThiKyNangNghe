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
using ThiKyNangNghe.Models;

namespace ThiKyNangNghe.View
{
    public partial class NotManagingEMRequests : Form
    {
        public Employee User { get; set; }
        SqlConnection connection;
        public Form PrevForm { get; set; }
        private int selectedRow;

        public NotManagingEMRequests(Form PrevForm,Employee user)
        {
            InitializeComponent();
            User = user;
            this.PrevForm = PrevForm;
        }

        private void NotManagingEMRequests_Load(object sender, EventArgs e)
        {
            GetDatabase();
        }

        public void GetDatabase()
        {
            this.data.Clear();
            string sql = @"select 
                            em.ID,
                            em.AssetID,
                            a.AssetSN,
                            a.AssetName,
                            em.EMReportDate,
                            em.EMEndDate,
                            (select e.FirstName + ' ' + e.LastName  from Employees as e where a.EmployeeID = e.ID) as EmployeeFullName,
                            (select d.Name from Departments as d where d.ID = (select dl.DepartmentID from DepartmentLocations as dl where dl.ID = a.DepartmentLocationID)) as Department
                            from EmergencyMaintenances as em
                            join assets as a
                            on em.AssetID = a.ID
                            order by em.PriorityID desc, em.EMReportDate desc";

            try
            {
                connection = Connection.Connection.GetConnection();
                connection.Open();
                //xu ly 
                SqlCommand command = new SqlCommand(sql, connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ListToNotManagerForm list = new ListToNotManagerForm();
                    list.ID = reader.GetInt64(reader.GetOrdinal("ID"));
                    list.AssetID = reader.GetInt64(reader.GetOrdinal("AssetID"));
                    list.AssetSN = reader.GetString(reader.GetOrdinal("AssetSN"));
                    list.AssetName = reader.GetString(reader.GetOrdinal("AssetName"));
                    if (!reader.IsDBNull(reader.GetOrdinal("EMReportDate")))
                    {
                        list.RequestDate = reader.GetDateTime(reader.GetOrdinal("EMReportDate"));
                    }
                    if (!reader.IsDBNull(reader.GetOrdinal("EMEndDate")))
                    {
                        list.EMEndDate = reader.GetDateTime(reader.GetOrdinal("EMEndDate"));
                    }
                    list.EmployeeFullName = reader.GetString(reader.GetOrdinal("EmployeeFullName"));
                    list.Department = reader.GetString(reader.GetOrdinal("Department"));
                    this.data.Add(list);
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
            this.selectedRow = e.RowIndex;
            this.dataGridView1.Rows[e.RowIndex].Selected = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (this.data[selectedRow].EMEndDate.HasValue)
            {
                MessageBox.Show("khong duoc chinh");
                return;
            }
            EmergencyMaintenanceRequestDetails emergencyMaintenanceRequestDetails = new EmergencyMaintenanceRequestDetails(this, this.data[selectedRow]);

            this.Hide();
            emergencyMaintenanceRequestDetails.Show();
        }
    }
}
