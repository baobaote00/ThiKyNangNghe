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

        public NotManagingEMRequests(Employee user)
        {
            InitializeComponent();
            User = user;
        }

        private void NotManagingEMRequests_Load(object sender, EventArgs e)
        {
            string sql = @"select 
                            a.AssetSN,
                            a.AssetName,
                            em.EMReportDate,
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
                    list.AssetSN = reader.GetString(0);
                    list.AssetName = reader.GetString(1);
                    if (!reader.IsDBNull(reader.GetOrdinal("EMReportDate")))
                    {
                        list.RequestDate = reader.GetDateTime(reader.GetOrdinal("EMReportDate"));
                    }
                    list.EmployeeFullName = reader.GetString(3);
                    list.Department = reader.GetString(4);
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
            this.dataGridView1.Rows[e.RowIndex].Selected = true;
        }
    }
}
