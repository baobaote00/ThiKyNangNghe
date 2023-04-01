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
    public partial class EmergencyMaintenanceRequest : Form
    {
        SqlConnection connection;
        public long AssetID { get; set; }
        public Form PrevForm { get; set; }

        public EmergencyMaintenanceRequest(Form PrevForm, long assetID)
        {
            InitializeComponent();
            this.AssetID = assetID;
            this.PrevForm = PrevForm;
        }

        private void LoginForm_Paint(object sender, PaintEventArgs e)
        {
            // Tạo một đối tượng Graphics để vẽ
            Graphics g = e.Graphics;

            // Tạo một đối tượng Rectangle với tọa độ và kích thước
            Rectangle rect1 = new Rectangle(20, 30, 980, 100);
            Rectangle rect2 = new Rectangle(20, 157, 980, 270);

            // Vẽ hình chữ nhật bằng phương thức DrawRectangle của đối tượng Graphics
            g.DrawRectangle(Pens.Black, rect1);
            g.DrawRectangle(Pens.Black, rect2);
        }

        private void EmergencyMaintenanceRequest_Load(object sender, EventArgs e)
        {
            string sql = @"select * from Priorities";
            priorities = new List<Priority>();

            try
            {
                connection = Connection.Connection.GetConnection();
                connection.Open();
                //xu ly 
                SqlCommand command = new SqlCommand(sql, connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Priority priority = new Priority();
                    priority.ID = reader.GetInt64(0);
                    priority.Name = reader.GetString(1);
                    priorities.Add(priority);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                binding.DataSource = this.priorities;
                this.cmbPriority.DataSource = binding;
            }

            string sql1 = @"select 
                        a.AssetSN,
                        a.AssetName, 
                        (select d.Name from Departments as d where d.ID = (select dl.DepartmentID from DepartmentLocations as dl where dl.ID = a.DepartmentLocationID)) as Department
                        from Assets as a where a.ID = @id";

            try
            {
                connection = Connection.Connection.GetConnection();
                connection.Open();
                //xu ly 
                SqlCommand command = new SqlCommand(sql1, connection);
                command.Parameters.AddWithValue("@id", this.AssetID);

                SqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    lblAssetSNValue.Text = reader.GetString(0);
                    lblAssetNameValue.Text = reader.GetString(1);
                    lblDepartmentValue.Text = reader.GetString(2);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
            PrevForm.Show();
        }

        private void btnSendRequest_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtDescription.Text))
            {
                MessageBox.Show("Chua nhap descriotion");
                return;
            }
            if (string.IsNullOrEmpty(txtOtherConsiderations.Text))
            {
                MessageBox.Show("Chua nhap other considerations");
                return;
            }

            string sql = @"INSERT INTO [dbo].[EmergencyMaintenances]
                               ([AssetID]
                               ,[PriorityID]
                               ,[DescriptionEmergency]
                               ,[OtherConsiderations]
                               ,[EMReportDate])
                         VALUES
                               (@assetID
                               ,@priorityID
                               ,@descriptionEmergency
                               ,@otherConsiderations
                               ,CURRENT_TIMESTAMP)";

            try
            {
                connection = Connection.Connection.GetConnection();
                connection.Open();

                //xu ly 
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@assetID", this.AssetID);
                command.Parameters.AddWithValue("@priorityID", ((Priority)this.cmbPriority.SelectedItem).ID);
                command.Parameters.AddWithValue("@descriptionEmergency", this.txtDescription.Text);
                command.Parameters.AddWithValue("@otherConsiderations", this.txtOtherConsiderations.Text);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                ((ManagingEMRequests)PrevForm).getDataTable();
                PrevForm.Show();
                Close();
            }
        }
    }
}
