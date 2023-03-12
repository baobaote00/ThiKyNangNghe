using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThiKyNangNghe
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
