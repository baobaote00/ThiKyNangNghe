using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThiKyNangNghe.Services;
using ThiKyNangNghe.Repository;
using System.Data.SqlClient;

namespace ThiKyNangNghe
{
    public partial class LoginForm : Form
    {
        SqlConnection connection;
        private readonly EmployeeService employeeService = new EmployeeService(new EmployeeRepository(Connection.Connection.getConnectionString()));
        public LoginForm()
        {
            InitializeComponent();
        }

        private bool Login()
        {
            try
            {
                connection = Connection.Connection.GetConnection();
                connection.Open();
                //xu ly 
                //thuc hien truy van
                //xu ly tren form
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return true;
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

        }
    }
}
