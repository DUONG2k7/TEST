using BUS_QL;
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

namespace ASM
{
    public partial class FormLichSuDangNhap : Form
    {
        BUS_IT Qltaikhoan = new BUS_IT();
        public FormLichSuDangNhap(string Idacc)
        {
            InitializeComponent();
            LoadDsTk(Idacc);

            dgvLichSuDangNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void LoadDsTk(string idacc)
        {
            dgvLichSuDangNhap.DataSource = Qltaikhoan.LoadLichSu(idacc);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
