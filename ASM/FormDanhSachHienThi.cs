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
        string ConnectionString = @"Data Source=DAUMINHDUONG\SQLEXPRESS;Initial Catalog=PRO231;Integrated Security=True";
        string taikhoan;
        string Malop;
        public FormDanhSachHienThi(string TK)
        {
            InitializeComponent();
            taikhoan = TK;
            cbDanhSach.SelectedIndex = 0;

            GetMaLop();
            dgvDanhSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public string GetMaLop()
        {
            string query = @"SELECT C.MaLop FROM CLASSES C INNER JOIN TEACHERS T ON C.MaGV = T.MaGV INNER JOIN ACCOUNTS A ON T.IdAcc = A.IdAcc WHERE A.Username = @Username";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", taikhoan);

                    Malop = cmd.ExecuteScalar()?.ToString();
                }
            }
            return Malop;
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            string query = "";
            switch (cbDanhSach.SelectedItem.ToString())
            {
                case "Mặc định":
                    query = "SELECT SV.MaSV, SV.TenSV, GD.Toan, GD.Van, GD.TiengAnh, ROUND(CAST((GD.Toan + GD.Van + GD.TiengAnh) AS FLOAT) / 3, 2) AS DiemTB FROM STUDENTS SV JOIN GRADE GD ON SV.MaSV = GD.MaSV WHERE SV.MaLop = @MaLop";
                    break;
                case "Top 3 sinh viên cao nhất":
                    query = "SELECT TOP 3 SV.MaSV, SV.TenSV, GD.Toan, GD.Van, GD.TiengAnh, ROUND(CAST((GD.Toan + GD.Van + GD.TiengAnh) AS FLOAT) / 3, 2) AS DiemTB FROM STUDENTS SV JOIN GRADE GD ON SV.MaSV = GD.MaSV WHERE SV.MaLop = @MaLop ORDER BY ((GD.Toan + GD.Van + GD.TiengAnh) / 3) DESC";
                    break;
                case "Tăng dần theo mã sinh viên":
                    query = "SELECT SV.MaSV, SV.TenSV, GD.Toan, GD.Van, GD.TiengAnh, ROUND(CAST((GD.Toan + GD.Van + GD.TiengAnh) AS FLOAT) / 3, 2) AS DiemTB FROM STUDENTS SV JOIN GRADE GD ON SV.MaSV = GD.MaSV WHERE SV.MaLop = @MaLop ORDER BY SV.MaSV ASC";
                    break;
                case "Tăng dần theo giới tính":
                    query = "SELECT SV.MaSV, SV.TenSV, CASE WHEN SV.GioiTinh = 1 THEN 'Nam' ELSE N'Nữ' END AS GioiTinh, ROUND(CAST((GD.Toan + GD.Van + GD.TiengAnh) AS FLOAT) / 3, 2) AS DiemTB FROM STUDENTS SV JOIN GRADE GD ON SV.MaSV = GD.MaSV WHERE SV.MaLop = @MaLop ORDER BY SV.GioiTinh DESC";
                    break;
                case "Giảm dần theo mã sinh viên":
                    query = "SELECT SV.MaSV, SV.TenSV, GD.Toan, GD.Van, GD.TiengAnh, ROUND(CAST((GD.Toan + GD.Van + GD.TiengAnh) AS FLOAT) / 3, 2) AS DiemTB FROM STUDENTS SV JOIN GRADE GD ON SV.MaSV = GD.MaSV WHERE SV.MaLop = @MaLop ORDER BY SV.MaSV DESC";
                    break;
                case "Giảm dần theo giới tính":
                    query = "SELECT SV.MaSV, SV.TenSV, CASE WHEN SV.GioiTinh = 1 THEN 'Nam' ELSE N'Nữ' END AS GioiTinh, ROUND(CAST((GD.Toan + GD.Van + GD.TiengAnh) AS FLOAT) / 3, 2) AS DiemTB FROM STUDENTS SV JOIN GRADE GD ON SV.MaSV = GD.MaSV WHERE SV.MaLop = @MaLop ORDER BY SV.GioiTinh";
                    break;
                default:
                    MessageBox.Show("Vui lòng chọn 1 lựa chọn hiện thị");
                    break;
            }
            if (!string.IsNullOrEmpty(query))
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConnectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaLop", Malop);

                            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            dataAdapter.Fill(dt);

                            dgvDanhSach.DataSource = dt;
                        }
                    }
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
