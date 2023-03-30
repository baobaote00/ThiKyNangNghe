using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using ThiKyNangNghe.Models;

namespace ThiKyNangNghe.View
{
    public partial class FormLogin : Form
    {
        SqlConnection connection;
        public FormLogin()
        {
            InitializeComponent();
        }

        private bool Login(string username, string password)
        {
            bool result = false;
            try
            {
                connection = Connection.Connection.GetConnection();
                connection.Open();
                string cmd = "select * from Employees as e where e.Username = @username and e.Password = @password";
                //xu ly 
                SqlCommand command = new SqlCommand(cmd, connection);
                command.Parameters.AddWithValue("username", username);
                command.Parameters.AddWithValue("password", password);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    employee = new Employee();
                    employee.ID = reader.GetInt64(0);
                    employee.FirstName = reader.GetString(1);
                    employee.LastName = reader.GetString(2);
                    employee.Phone = reader.GetString(3);
                    if (!reader.IsDBNull(reader.GetOrdinal("isAdmin")))
                    {
                        employee.isAdmin = reader.GetBoolean(reader.GetOrdinal("isAdmin"));
                    }
                    employee.Username = reader.GetString(5);
                    employee.Password = reader.GetString(6);
                    result = true;
                }

                return result;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return false;
        }

        private void LoginForm_Paint(object sender, PaintEventArgs e)
        {
            // Tạo một đối tượng Graphics để vẽ
            Graphics g = e.Graphics;

            // Tạo một đối tượng Rectangle với tọa độ và kích thước
            Rectangle rect = new Rectangle(94, 69, 412, 207);

            // Vẽ hình chữ nhật bằng phương thức DrawRectangle của đối tượng Graphics
            g.DrawRectangle(Pens.Black, rect);
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void _OK_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("chua nhap username");
                return;
            }
            if (txtPassword.Text == "")
            {   
                MessageBox.Show("chua nhap password");
                return;
            }
            if (!Login(txtUsername.Text, txtPassword.Text))
            {
                MessageBox.Show("sai username hoac password");
                return;
            }

            Form form = null;

            if (employee.isAdmin.HasValue)
            {
                form = new ManagingEMRequests(employee);
            }
            else
            {
                form = new NotManagingEMRequests(employee);
            }

            form.Show();
            Hide();
        }

    }
}
