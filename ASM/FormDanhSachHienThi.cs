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
    public partial class FormDanhSachHienThi : Form
    {
        BUS_GV QlDAnhSach = new BUS_GV();
        string Malop;
        public FormDanhSachHienThi(string TK)
        {
            InitializeComponent();

            Malop = QlDAnhSach.GetMaLop(TK);
            cbDanhSach.SelectedIndex = 0;

            dgvDanhSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            string query = "";
            switch (cbDanhSach.SelectedItem.ToString())
            {
                case "Mặc định":
                    query = "SELECT SV.IDGV, SV.TenSV, GD.Toan, GD.Van, GD.TiengAnh, ROUND(CAST((GD.Toan + GD.Van + GD.TiengAnh) AS FLOAT) / 3, 2) AS DiemTB FROM STUDENTS SV JOIN GRADE GD ON SV.IDGV = GD.IDGV WHERE SV.IDLop = @IDLop";
                    break;
                case "Top 3 sinh viên cao nhất":
                    query = "SELECT TOP 3 SV.IDGV, SV.TenSV, GD.Toan, GD.Van, GD.TiengAnh, ROUND(CAST((GD.Toan + GD.Van + GD.TiengAnh) AS FLOAT) / 3, 2) AS DiemTB FROM STUDENTS SV JOIN GRADE GD ON SV.IDGV = GD.IDGV WHERE SV.IDLop = @IDLop ORDER BY ((GD.Toan + GD.Van + GD.TiengAnh) / 3) DESC";
                    break;
                case "Tăng dần theo mã sinh viên":
                    query = "SELECT SV.IDGV, SV.TenSV, GD.Toan, GD.Van, GD.TiengAnh, ROUND(CAST((GD.Toan + GD.Van + GD.TiengAnh) AS FLOAT) / 3, 2) AS DiemTB FROM STUDENTS SV JOIN GRADE GD ON SV.IDGV = GD.IDGV WHERE SV.IDLop = @IDLop ORDER BY SV.IDGV ASC";
                    break;
                case "Tăng dần theo giới tính":
                    query = "SELECT SV.IDGV, SV.TenSV, CASE WHEN SV.GioiTinh = 1 THEN 'Nam' ELSE N'Nữ' END AS GioiTinh, ROUND(CAST((GD.Toan + GD.Van + GD.TiengAnh) AS FLOAT) / 3, 2) AS DiemTB FROM STUDENTS SV JOIN GRADE GD ON SV.IDGV = GD.IDGV WHERE SV.IDLop = @IDLop ORDER BY SV.GioiTinh DESC";
                    break;
                case "Giảm dần theo mã sinh viên":
                    query = "SELECT SV.IDGV, SV.TenSV, GD.Toan, GD.Van, GD.TiengAnh, ROUND(CAST((GD.Toan + GD.Van + GD.TiengAnh) AS FLOAT) / 3, 2) AS DiemTB FROM STUDENTS SV JOIN GRADE GD ON SV.IDGV = GD.IDGV WHERE SV.IDLop = @IDLop ORDER BY SV.IDGV DESC";
                    break;
                case "Giảm dần theo giới tính":
                    query = "SELECT SV.IDGV, SV.TenSV, CASE WHEN SV.GioiTinh = 1 THEN 'Nam' ELSE N'Nữ' END AS GioiTinh, ROUND(CAST((GD.Toan + GD.Van + GD.TiengAnh) AS FLOAT) / 3, 2) AS DiemTB FROM STUDENTS SV JOIN GRADE GD ON SV.IDGV = GD.IDGV WHERE SV.IDLop = @IDLop ORDER BY SV.GioiTinh";
                    break;
                default:
                    MessageBox.Show("Vui lòng chọn 1 lựa chọn hiện thị");
                    break;
            }
            if (!string.IsNullOrEmpty(query))
            {
                try
                {
                    DataTable dt = QlDAnhSach.GetData(query, Malop);
                    dgvDanhSach.DataSource = dt;
                }
                catch (Exception)
                {
                    MessageBox.Show("Giáo viên này chưa được phân lớp!");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
