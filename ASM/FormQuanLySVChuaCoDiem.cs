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
    public partial class FormQuanLySVChuaCoDiem : Form
    {
        BUS_GV QlDiem = new BUS_GV();
        string ConnectionString = Properties.Settings.Default.ConnectionString;
        //string ConnectionString = @"Data Source=DAUMINHDUONG\SQLEXPRESS;Initial Catalog=SOF102_ASM;Integrated Security=True";
        int currentindex = 0;
        int selectFunction = 0;
        int selectType = 0;
        int max;
        float tiengAnh = 0f;
        float van = 0f;
        float toan = 0f;
        string taikhoan;
        string Malop;
        bool IsAdding = false;
        public FormQuanLySVChuaCoDiem(string Tk)
        {
            InitializeComponent();
            GetMaLop(Tk);
            LoadDsSv();

            txtTienganh.TextChanged += FormQuanLyDiemSV_TextChanged;
            txtVan.TextChanged += FormQuanLyDiemSV_TextChanged;
            txtToan.TextChanged += FormQuanLyDiemSV_TextChanged;
            max = TongSV();

            txtToan.Enabled = false;
            txtVan.Enabled = false;
            txtTienganh.Enabled = false;
            btnSave.Enabled = false;

            dgvDanhSachSV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void LoadDsSv()
        {
            try
            {
                string query = "SELECT SV.MaSV, SV.TenSV, COALESCE(CAST(GD.Toan AS NVARCHAR), N'Chưa nhập') AS Toan, COALESCE(CAST(GD.Van AS NVARCHAR), N'Chưa nhập') AS Van, COALESCE(CAST(GD.TiengAnh AS NVARCHAR), N'Chưa nhập') AS TiengAnh, CASE WHEN GD.Toan IS NULL AND GD.Van IS NULL AND GD.TiengAnh IS NULL THEN N'Chưa xét' ELSE CAST(ROUND(CAST((COALESCE(GD.Toan, 0) + COALESCE(GD.Van, 0) + COALESCE(GD.TiengAnh, 0)) AS FLOAT) / 3, 2) AS NVARCHAR) END AS DiemTB FROM STUDENTS SV LEFT JOIN GRADE GD ON SV.MaSV = GD.MaSV WHERE SV.MaLop = @MaLop";
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaLop", Malop);

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);

                        dgvDanhSachSV.DataSource = dt;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Giáo viên này chưa được phân lớp!");
            }
        }
        public void ClearForm()
        {
            txtMasv.Clear();
            lbHoctenSV.Text = "";
            lbDiemTB.Text = "";
            txtMasvDiemtb.Clear();
            txtTienganh.Clear();
            txtVan.Clear();
            txtToan.Clear();
        }
        public string GetMaLop(string taikhoan)
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
        private void LoadFunction()
        {
            if (selectFunction == 0 && selectType == 1)
            {
                txtTienganh.ReadOnly = false;
                txtVan.ReadOnly = false;
                txtToan.ReadOnly = false;

                lbDiemTB.Text = "Chưa xét";
                txtTienganh.Text = "Chưa nhập";
                txtVan.Text = "Chưa nhập";
                txtToan.Text = "Chưa nhập";

                btnNew.Enabled = true;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
            }
            else if (selectFunction == 0 && selectType == 2)
            {
                txtTienganh.ReadOnly = false;
                txtVan.ReadOnly = false;
                txtToan.ReadOnly = false;

                lbDiemTB.Text = ((tiengAnh + van + toan) / 3).ToString("F2");
                txtTienganh.Text = tiengAnh.ToString();
                txtVan.Text = van.ToString();
                txtToan.Text = toan.ToString();

                btnNew.Enabled = false;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
            }
        }
        private void LoadCurrentData()
        {
            if (currentindex >= 0 && currentindex < max)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConnectionString))
                    {
                        conn.Open();

                        string maSV = null;

                        string queryFindSinhVien = "SELECT CL.MaLop, SV.MaSV, SV.TenSV FROM CLASSES CL JOIN STUDENTS SV ON SV.MaLop = CL.MaLop WHERE CL.MaLop = @MaLop ORDER BY MaSV ASC OFFSET @Row ROWS FETCH NEXT 1 ROWS ONLY";
                        using (SqlCommand cmd = new SqlCommand(queryFindSinhVien, conn))
                        {
                            cmd.Parameters.AddWithValue("@Row", currentindex);
                            cmd.Parameters.AddWithValue("@MaLop", Malop);
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (!reader.HasRows)
                                {
                                    selectType = 0;
                                    return;
                                }

                                while (reader.Read())
                                {
                                    maSV = reader[1].ToString();
                                    lbHoctenSV.Text = reader[2].ToString();
                                    txtMasvDiemtb.Text = maSV;
                                    selectFunction = 0;
                                    break;
                                }
                            }
                        }

                        string queryFindGrade = "SELECT TiengAnh, van, toan, ((TiengAnh + van + toan) / 3) AS TongDiem FROM GRADE WHERE MaSV = @MaSV";
                        using (SqlCommand cmd = new SqlCommand(queryFindGrade, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaSV", maSV);

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (!reader.HasRows)
                                {
                                    txtTienganh.Text = "Chưa nhập";
                                    txtVan.Text = "Chưa nhập";
                                    txtToan.Text = "Chưa nhập";
                                    lbDiemTB.Text = "Chưa xét";
                                    selectType = 1;
                                    LoadFunction();
                                    return;
                                }

                                while (reader.Read())
                                {
                                    tiengAnh = float.Parse(reader[0].ToString());
                                    txtTienganh.Text = tiengAnh.ToString();
                                    van = float.Parse(reader[1].ToString());
                                    txtVan.Text = van.ToString();
                                    toan = float.Parse(reader[2].ToString());
                                    txtToan.Text = toan.ToString();
                                    lbDiemTB.Text = ((tiengAnh + van + toan) / 3).ToString("F2");
                                    selectType = 2;
                                    LoadFunction();
                                    break;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public int TongSV()
        {
            string query = "SELECT COUNT(*) FROM STUDENTS WHERE MaLop = @MaLop";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaLop", Malop ?? "");
                        int count = (int)cmd.ExecuteScalar();
                        return count;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }
        }
        public bool Ktdv()
        {
            if (string.IsNullOrWhiteSpace(txtMasvDiemtb.Text) || string.IsNullOrWhiteSpace(txtTienganh.Text) ||
            string.IsNullOrWhiteSpace(txtVan.Text) || string.IsNullOrWhiteSpace(txtToan.Text) ||
            !double.TryParse(txtTienganh.Text, out double diemTA) || diemTA > 10 || diemTA < 0 ||
            !double.TryParse(txtVan.Text, out double diemTin) || diemTin > 10 || diemTin < 0 ||
            !double.TryParse(txtToan.Text, out double diemGD) || diemGD > 10 || diemGD < 0)
            {
                MessageBox.Show("Vui lòng nhập thông tin hợp lệ !","Thông báo");
                return false;
            }
            return true;
        }
        public bool KtUserDaTonTai(string maHs)
        {
            string query = "SELECT COUNT(*) FROM GRADE WHERE MASV = @MASV";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MASV", maHs);
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        public void CalculateDiemTrungBinh()
        {
            try
            {
                if (double.TryParse(txtToan.Text, out double giaoducTC) &&
                    double.TryParse(txtTienganh.Text, out double tienganh) &&
                    double.TryParse(txtVan.Text, out double van))
                {
                    double diemTB = Math.Round((giaoducTC + tienganh + van) / 3, 2);
                    lbDiemTB.Text = diemTB.ToString();
                }
                else
                {
                    lbDiemTB.Text = "N/A";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tính điểm trung bình: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void FormQuanLyDiemSV_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMasv.Text))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên cần tìm!", "Thông báo");
                return;
            }
            string query = "SELECT s.MASV, s.TenSV, g.Tienganh, g.van, g.toan FROM STUDENTS s LEFT JOIN GRADE g ON s.MASV = g.MASV WHERE s.MASV = @MASV AND s.MaLop = @MaLop";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using(SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MASV",txtMasv.Text);
                    cmd.Parameters.AddWithValue("@MaLop", Malop);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("Mã sinh viên không tồn tại trong lớp này", "Message");
                            return;
                        }
                        while (reader.Read())
                        {
                            txtMasvDiemtb.Text = reader["MaSV"].ToString();
                            lbHoctenSV.Text = reader["TenSV"].ToString();

                            txtTienganh.Text = reader["Tienganh"].ToString();
                            txtVan.Text = reader["van"].ToString();
                            txtToan.Text = reader["toan"].ToString();
                            break;
                        }
                    }
                }
            }
            txtMasv.Clear();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            IsAdding = true;
            txtToan.Enabled = true;
            txtVan.Enabled = true;
            txtTienganh.Enabled = true;
            btnSave.Enabled = true;
            btnNew.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnChangeAllLeft.Enabled = false;
            btnChangeAllRight.Enabled = false;
            btnChangeLeft.Enabled = false;
            BtnRight.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string Deletequery = "DELETE FROM GRADE WHERE MASV = @MASV";
            using( SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(Deletequery,con))
                {
                    cmd.Parameters.AddWithValue("@MASV", txtMasvDiemtb.Text);
                    DialogResult s = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (s == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thông tin học sinh đã được xóa thành công!", "Thông báo");

                        ClearForm();
                        LoadDsSv();
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            IsAdding = false;
            txtToan.Enabled = true;
            txtVan.Enabled = true;
            txtTienganh.Enabled = true;
            btnSave.Enabled = true;
            btnNew.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnChangeAllLeft.Enabled = false;
            btnChangeAllRight.Enabled = false;
            btnChangeLeft.Enabled = false;
            BtnRight.Enabled = false;
        }

        private void FormQuanLyDiemSV_TextChanged(object sender, EventArgs e)
        {
            CalculateDiemTrungBinh();
        }

        private void btnChangeLeft_Click(object sender, EventArgs e)
        {
            if (currentindex > 0)
            {
                currentindex--;
                LoadCurrentData();
            }
            else
            {
                MessageBox.Show("Đã đến sinh viên đầu tiên!", "Thông báo");
            }
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            if (currentindex < 0 || currentindex >= max)
            {
                MessageBox.Show("Không có dữ liệu sinh viên!", "Thông báo");
                return;
            }

            if (currentindex < max - 1)
            {
                currentindex++;
                LoadCurrentData();
            }
            else
            {
                MessageBox.Show("Đã đến sinh viên cuối!", "Thông báo");
            }
        }

        private void btnChangeAllLeft_Click(object sender, EventArgs e)
        {
            currentindex = 0;
            LoadCurrentData();
        }

        private void btnChangeAllRight_Click(object sender, EventArgs e)
        {
            if (currentindex < 0 || currentindex >= max)
            {
                MessageBox.Show("Không có dữ liệu sinh viên!", "Thông báo");
                return;
            }
            currentindex = max - 1;
            LoadCurrentData();
        }
        private void txtTienganh_Click(object sender, EventArgs e)
        {
            txtTienganh.Clear();
        }

        private void txtvan_Click(object sender, EventArgs e)
        {
            txtVan.Clear();
        }

        private void txtGiaoducTC_Click(object sender, EventArgs e)
        {
            txtToan.Clear();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            using (FormDanhSachHienThi frmhienthi = new FormDanhSachHienThi(Malop))
            {
                frmhienthi.ShowDialog();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void NewDuLieu()
        {
            if (!Ktdv())
            {
                return;
            }

            if (KtUserDaTonTai(txtMasvDiemtb.Text))
            {
                MessageBox.Show("Mã học sinh đã tồn tại. Vui lòng nhập mã khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string insertquery = "INSERT INTO GRADE (MASV, Tienganh, van, toan) VALUES (@MASV, @Tienganh, @van, @toan)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(insertquery, con))
                {
                    cmd.Parameters.AddWithValue("@MASV", txtMasvDiemtb.Text);
                    cmd.Parameters.AddWithValue("@Tienganh", txtTienganh.Text);
                    cmd.Parameters.AddWithValue("@van", txtVan.Text);
                    cmd.Parameters.AddWithValue("@toan", txtToan.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thông tin học sinh đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadDsSv();
                }
            }
        }
        private void UpdateDuLieu()
        {
            if (!Ktdv())
            {
                return;
            }

            string updatequery = "UPDATE GRADE SET Tienganh = @Tienganh, van = @van, toan = @toan WHERE MASV = @MASV";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(updatequery, conn))
                {
                    cmd.Parameters.AddWithValue("@MASV", txtMasvDiemtb.Text);
                    cmd.Parameters.AddWithValue("@Tienganh", txtTienganh.Text);
                    cmd.Parameters.AddWithValue("@van", txtVan.Text);
                    cmd.Parameters.AddWithValue("@toan", txtToan.Text);

                    DialogResult s = MessageBox.Show("Bạn có chắc chắn muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (s == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thông tin học sinh đã được lưu thành công!", "Thông báo");

                        LoadDsSv();
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsAdding)
            {
                NewDuLieu();
            }
            else
            {
                UpdateDuLieu();
            }
            ClearForm();

            btnSave.Enabled = false;
            btnNew.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnChangeAllLeft.Enabled = true;
            btnChangeAllRight.Enabled = true;
            btnChangeLeft.Enabled = true;
            BtnRight.Enabled = true;
        }
        private void dgvDanhSachSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDanhSachSV.CurrentRow != null)
            {
                txtMasv.Text = dgvDanhSachSV.CurrentRow.Cells[0]?.Value?.ToString();
                txtMasvDiemtb.Text = dgvDanhSachSV.CurrentRow.Cells[0]?.Value?.ToString();
                lbHoctenSV.Text = dgvDanhSachSV.CurrentRow.Cells[1]?.Value?.ToString();
                txtTienganh.Text = dgvDanhSachSV.CurrentRow.Cells[2]?.Value?.ToString();
                txtToan.Text = dgvDanhSachSV.CurrentRow.Cells[3]?.Value?.ToString();
                txtVan.Text = dgvDanhSachSV.CurrentRow.Cells[4]?.Value?.ToString();
                lbDiemTB.Text = dgvDanhSachSV.CurrentRow.Cells[5]?.Value?.ToString();

                LoadCurrentData();
            }
        }
    }
}
