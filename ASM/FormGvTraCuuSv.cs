using BUS_QL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM
{
    public partial class FormGvTraCuuSv : Form
    {
        BUS_GV QlGvtracuugv = new BUS_GV();
        int IDKyhoc;
        public FormGvTraCuuSv(int idkyhoc)
        {
            InitializeComponent();
            IDKyhoc = idkyhoc;
        }
        public bool LoadInfoSv(string IDSV)
        {
            DataTable dt = QlGvtracuugv.LoadDsThongTinSinhVien(IDSV);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                lbHoTen.Text = $"Họ tên: {row["TenSV"]}";
                lbIDLop.Text = $"Lớp: {row["IDLop"]}";
                lbEmail.Text = $"Email: {row["Email"]}";
                lbSDT.Text = $"Số ĐT: {row["SoDT"]}";
                lbDiaChi.Text = $"Địa chỉ: {row["Diachi"]}";
                lbGioiTinh.Text = $"Giới tính: {(row["GioiTinh"].ToString() == "1" ? "Nam" : "Nữ")}";
                return true;
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maSinhVien = txtTimkiem.Text.Trim();
            if (LoadInfoSv(maSinhVien))
            {
                dgvDiem.DataSource = QlGvtracuugv.GetListDiem(maSinhVien);
            }
            else
            {
                dgvDiem.DataSource = null;
                lbHoTen.Text = "";
                lbIDLop.Text = "";
                lbEmail.Text = "";
                lbSDT.Text = "";
                lbDiaChi.Text = "";
                lbGioiTinh.Text = "";
            }
        }
    }
}
