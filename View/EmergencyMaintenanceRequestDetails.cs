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
    public partial class EmergencyMaintenanceRequestDetails : Form
    {
        ListToNotManagerForm list;
        SqlConnection connection;
        public Form PrevForm { get; set; }
        public EmergencyMaintenanceRequestDetails(Form PrevForm, ListToNotManagerForm list)
        {
            InitializeComponent();

            this.PrevForm = PrevForm;
            this.list = list;
        }

        private void LoginForm_Paint(object sender, PaintEventArgs e)
        {
            // Tạo một đối tượng Graphics để vẽ
            Graphics g = e.Graphics;

            // Tạo một đối tượng Rectangle với tọa độ và kích thước
            Rectangle rect1 = new Rectangle(20, 30, 980, 100);
            Rectangle rect2 = new Rectangle(20, 144, 980, 156);
            Rectangle rect3 = new Rectangle(20, 320, 980, 215);

            // Vẽ hình chữ nhật bằng phương thức DrawRectangle của đối tượng Graphics
            g.DrawRectangle(Pens.Black, rect1);
            g.DrawRectangle(Pens.Black, rect2);
            g.DrawRectangle(Pens.Black, rect3);
        }

        private void EmergencyMaintenanceRequestDetails_Load(object sender, EventArgs e)
        {
            string sql1 = @"select 
                        a.AssetSN,
                        a.AssetName, 
                        (select d.Name from Departments as d where d.ID = 
                            (select dl.DepartmentID from DepartmentLocations as dl where dl.ID = a.DepartmentLocationID)) as Department
                        from Assets as a where a.ID = @id";

            try
            {
                connection = Connection.Connection.GetConnection();
                connection.Open();
                //xu ly 
                SqlCommand command = new SqlCommand(sql1, connection);
                command.Parameters.AddWithValue("@id", this.list.AssetID);

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

            string sql = @"select * from Parts";

            try
            {
                connection = Connection.Connection.GetConnection();
                connection.Open();
                //xu ly 
                SqlCommand command = new SqlCommand(sql, connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Part part = new Part();
                    part.ID = reader.GetInt64(0);
                    part.Name = reader.GetString(1);
                    if (!reader.IsDBNull(reader.GetOrdinal("EffectiveLife")))
                    {
                        part.EffectiveLife = reader.GetInt64(reader.GetOrdinal("EffectiveLife"));
                    }
                    dataPartCMB.Add(part);
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
                binding.DataSource = this.dataPartCMB;
                cmbPartName.DataSource = binding;
            }
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            Part part = ((Part)this.cmbPartName.SelectedItem);

            string sql = @"select 
                            p.ID,
                            p.EffectiveLife,
                            p.Name 
                            from ChangedParts as cp 
                            join Parts as p 
                            on cp.PartID = p.ID 
                            where p.ID = @id and p.EffectiveLife is not null";

            try
            {
                connection = Connection.Connection.GetConnection();
                connection.Open();
                //xu ly 
                SqlCommand command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@id", part.ID);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("part " + reader.GetString(reader.GetOrdinal("Name")) + " is used");
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

            int amount = 0;
            int.TryParse(this.txtAmount.Text, out amount);
            if (amount < 0) return;

            if (this.dataPartDGV.Contains(part))
            {
                this.dataPartDGV.Find(p => p.ID == part.ID).Amount += amount;
            }
            else
            {
                part.Amount = amount;
                this.dataPartDGV.Add(part);
            }

            BindingSource binding = new BindingSource();
            binding.DataSource = this.dataPartDGV;
            dgvPart.DataSource = binding;
            if (dgvPart.ColumnCount < 3)
            {
                dgvPart.Columns.Insert(dgvPart.ColumnCount, btnRemove);
            }
        }

        private void dgvPart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != btnRemove.Index) return;

            dataPartDGV.RemoveAt(e.RowIndex);
            BindingSource binding = new BindingSource();
            binding.DataSource = this.dataPartDGV;
            dgvPart.DataSource = binding;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (dtpStartDate.Value <= list.RequestDate)
            {
                MessageBox.Show("Ngay bat dau khong hop le");
                return;
            }

            bool check = dtpCompletedDate.Value != dtpCompletedDate.MinDate;

            if (dtpCompletedDate.Value != dtpCompletedDate.MinDate &&
                (dtpCompletedDate.Value <= list.RequestDate ||
                dtpCompletedDate.Value < dtpStartDate.Value))
            {
                MessageBox.Show("Ngay ket thuc khong hop le");
                return;
            }

            if (check && string.IsNullOrEmpty(txtTechnicianNote.Text))
            {
                MessageBox.Show("chua nhap technician note");
                return;
            }

            string sql1 = @"UPDATE [dbo].[EmergencyMaintenances]
                               SET [EMStartDate] = @startDate
                                  ,[EMEndDate] = @endDate
                                  ,[EMTechnicianNote] = @technicianNote
                             WHERE ID = @id";

            string sql2 = @"UPDATE [dbo].[EmergencyMaintenances]
                               SET [EMStartDate] = @startDate
                             WHERE ID = @id";

            try
            {
                connection = Connection.Connection.GetConnection();
                connection.Open();
                SqlCommand command;

                //xu ly 
                if (!check)
                {
                    command = new SqlCommand(sql2, connection);
                }
                else
                {
                    command = new SqlCommand(sql1, connection);
                    command.Parameters.AddWithValue("@endDate", dtpCompletedDate.Value);
                    command.Parameters.AddWithValue("@technicianNote", txtTechnicianNote.Text);
                }

                command.Parameters.AddWithValue("@startDate", dtpStartDate.Value);
                command.Parameters.AddWithValue("@id", list.ID);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }


            if (dataPartDGV.Count > 0)
            {
                string sql = @"INSERT INTO [dbo].[ChangedParts]
                                    ([EmergencyMaintenanceID]
                                    ,[PartID]
                                    ,[Amount])
                             VALUES
                                   (@EmergencyMaintenanceID
                                   ,@PartID
                                   ,@Amount)";

                for (int i = 0; i < dataPartDGV.Count; i++)
                {
                    try
                    {
                        connection = Connection.Connection.GetConnection();
                        connection.Open();
                        //xu ly 
                        SqlCommand command = new SqlCommand(sql, connection);


                        command.Parameters.AddWithValue("@EmergencyMaintenanceID", list.ID);
                        command.Parameters.AddWithValue("@PartID", dataPartDGV[i].ID);
                        command.Parameters.AddWithValue("@Amount", dataPartDGV[i].Amount);
                        command.ExecuteNonQuery();
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
            }

            this.Close();
            PrevForm.Show();
            ((NotManagingEMRequests)PrevForm).GetDatabase();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            PrevForm.Show();
        }
    }
}
