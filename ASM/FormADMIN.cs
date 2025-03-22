using BUS_QL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM
{
    public partial class FormADMIN : Form
    {
        BUS_GUI Qlgiaodien = new BUS_GUI();
        private int xPosition;
        private string[] images;
        private int index = 0;

        public FormADMIN(string Username, string IDrole)
        {
            InitializeComponent();
            ThongTinTaiKhoan.Text = "Chào " + Username;
            UserNameThongTinTaiKhoan.Text = "Username: " + Username;
            RoleThongTinTaiKhoan.Text = "Role: " + Qlgiaodien.GetRole(IDrole);

            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string resourcePath = Path.Combine(basePath, "AdminPic");
            images = Directory.GetFiles(resourcePath, "*.*")
                              .Where(file => file.EndsWith(".png") || file.EndsWith(".jpg"))
                              .ToArray();

            if (images.Length > 0)
            {
                pictureBox1.Image = Image.FromFile(images[index]);
            }

            timer1.Interval = 2000; // Đặt thời gian mặc định là 2 giây
            timer1.Start();
            xPosition = this.Width; // Đặt vị trí ban đầu ngoài màn hình
            lblMarquee.Text = "Hệ thống Giáo dục FPT ra đời với sứ mệnh đào tạo thế hệ trẻ Việt Nam trở thành những công dân toàn cầu, giàu tri thức và kỹ năng, sẵn sàng thích ứng với sự thay đổi của thế giới. Với triết lý giáo dục \"Thực học – Thực nghiệp\", FPT tập trung xây dựng môi trường học tập sáng tạo, kết hợp hài hòa giữa lý thuyết và thực tiễn, giúp học sinh – sinh viên phát triển toàn diện."; // Nội dung hiển thị
            lblMarquee.AutoSize = true; // Để chữ không bị cắt mất
            timer2.Interval = 100; // Điều chỉnh tốc độ chạy
            timer2.Tick += timer2_Tick; // Gán sự kiện Timer
            timer2.Start(); // Bắt đầu Timer
        }
        
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMenuQlyTaiKhoan_Click(object sender, EventArgs e)
        {
            tabMain.Controls.Clear();
            FormAdminQuanLyTaiKhoanADMIN f2 = new FormAdminQuanLyTaiKhoanADMIN();
            f2.TopLevel = false;
            f2.FormBorderStyle = FormBorderStyle.None;
            f2.Dock = DockStyle.Fill;
            tabMain.Controls.Add(f2);
            f2.Show();
        }

        private void btnMenuQlyCBDT_Click(object sender, EventArgs e)
        {
            tabMain.Controls.Clear();
            FormAdminQuanLyTaiKhoanCBDT f2 = new FormAdminQuanLyTaiKhoanCBDT();
            f2.TopLevel = false;
            f2.FormBorderStyle = FormBorderStyle.None;
            f2.Dock = DockStyle.Fill;
            tabMain.Controls.Add(f2);
            f2.Show();
        }

        private void btnMenuQlyGV_Click(object sender, EventArgs e)
        {
            tabMain.Controls.Clear();
            FormAdminQuanLyTaiKhoanGV f2 = new FormAdminQuanLyTaiKhoanGV();
            f2.TopLevel = false;
            f2.FormBorderStyle = FormBorderStyle.None;
            f2.Dock = DockStyle.Fill;
            tabMain.Controls.Add(f2);
            f2.Show();
        }

        private void btnMenuQlyGlobalBan_Click(object sender, EventArgs e)
        {
            tabMain.Controls.Clear();
            FormAdminQuanLyTaiKhoanZeros f2 = new FormAdminQuanLyTaiKhoanZeros();
            f2.TopLevel = false;
            f2.FormBorderStyle = FormBorderStyle.None;
            f2.Dock = DockStyle.Fill;
            tabMain.Controls.Add(f2);
            f2.Show();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            index = (index + 1) % images.Length; // Lặp lại khi hết ảnh
            pictureBox1.Image = Image.FromFile(images[index]);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            xPosition -= 5; // Giảm vị trí X để chữ chạy từ phải sang trái

            if (xPosition < -lblMarquee.Width) // Khi chữ ra khỏi màn hình, đặt lại vị trí
            {
                xPosition = this.Width;
            }

            lblMarquee.Left = xPosition; // Cập nhật vị trí Label
        }
    }
}
