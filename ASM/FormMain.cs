using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM
{
    public partial class FormMain : Form
    {
        private string[] images;
        private int index = 0;
        FormLogin formLogin;
        public FormMain()
        {
            InitializeComponent();
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string resourcePath = Path.Combine(basePath, "MainPicture");
            images = Directory.GetFiles(resourcePath, "*.*")
                              .Where(file => file.EndsWith(".png") || file.EndsWith(".jpg"))
                              .ToArray();
            if (images.Length > 0)
            {
                pictureBox1.Image = Image.FromFile(images[index]);
            }
            timer1.Interval = 2000; // Đặt thời gian mặc định là 3 giây
            timer1.Start();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            formLogin = new FormLogin();
            formLogin.FormClosed += (s, args) => this.Hide();
            formLogin.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Xác nhận thoát !", "Message", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
            {
                Close();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            index = (index + 1) % images.Length; // Lặp lại khi hết ảnh
            pictureBox1.Image = Image.FromFile(images[index]);
        }
    }
}
