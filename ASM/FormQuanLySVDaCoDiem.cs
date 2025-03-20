using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM
{
    public partial class FormQuanLySVDaCoDiem : Form
    {
        string ConnectionString = @"Data Source=DAUMINHDUONG\SQLEXPRESS;Initial Catalog=PRO231;Integrated Security=True";
        static int pageIndex = 1;
        static int pageSize = 1;
        int max;

        string Malop;
        bool IsAdding = false;
        public FormQuanLySVDaCoDiem(string Tk)
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
            lbTenSV.Text = "";
            lbDiemTB.Text = "";
            txtMasvDiemtb.Clear();
            txtTienganh.Clear();
            txtVan.Clear();
            txtToan.Clear();
        }
        public void ClearDiem()
        {
            lbDiemTB.Text = "";
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
        public void LoadTrangThaiDulieu()
        {
            if (lbDiemTB.Text.Trim().Equals("Chưa xét", StringComparison.OrdinalIgnoreCase))
            {
                btnNew.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                btnNew.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }
        private void LoadCurrentData()
        {
            int offset = (pageIndex - 1) * pageSize;

            if (max == 0)
            {
                MessageBox.Show("Không có sinh viên trong lớp này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    string queryFindSinhVien = "SELECT SV.MaSV, SV.TenSV, COALESCE(CAST(GD.Toan AS NVARCHAR), N'Chưa nhập') AS Toan, COALESCE(CAST(GD.Van AS NVARCHAR), N'Chưa nhập') AS Van, COALESCE(CAST(GD.TiengAnh AS NVARCHAR), N'Chưa nhập') AS TiengAnh, CASE WHEN GD.Toan IS NULL AND GD.Van IS NULL AND GD.TiengAnh IS NULL THEN N'Chưa xét' ELSE CAST(ROUND(CAST((COALESCE(GD.Toan, 0) + COALESCE(GD.Van, 0) + COALESCE(GD.TiengAnh, 0)) AS FLOAT) / 3, 2) AS NVARCHAR) END AS DiemTB FROM STUDENTS SV LEFT JOIN GRADE GD ON SV.MaSV = GD.MaSV WHERE SV.MaLop = @MaLop ORDER BY SV.MaSV ASC OFFSET @Offset ROWS FETCH NEXT @size ROWS ONLY";
                    using (SqlCommand cmd = new SqlCommand(queryFindSinhVien, conn))
                    {
                        cmd.Parameters.AddWithValue("@Offset", offset);
                        cmd.Parameters.AddWithValue("@size", pageSize);
                        cmd.Parameters.AddWithValue("@MaLop", Malop);

                        DataTable dtSinhVien = new DataTable();
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dtSinhVien);
                        }

                        if (dtSinhVien.Rows.Count == 0)
                        {
                            MessageBox.Show("Không có dữ liệu sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        DataRow currentRow = dtSinhVien.Rows[0];

                        txtMasvDiemtb.Text = currentRow["MaSV"].ToString();
                        lbTenSV.Text = currentRow["TenSV"].ToString();
                        txtTienganh.Text = currentRow["TiengAnh"].ToString();
                        txtVan.Text = currentRow["Van"].ToString();
                        txtToan.Text = currentRow["Toan"].ToString();
                        lbDiemTB.Text = currentRow["DiemTB"].ToString();

                        string selectedMaSV = currentRow["MaSV"].ToString();
                        HighlightRowByMaSV(selectedMaSV);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void HighlightRowByMaSV(string maSV)
        {
            if (dgvDanhSachSV.Rows.Count == 0) return;

            foreach (DataGridViewRow row in dgvDanhSachSV.Rows)
            {
                if (row.Cells["MaSV"].Value != null && row.Cells["MaSV"].Value.ToString() == maSV)
                {
                    row.Selected = true;
                    dgvDanhSachSV.CurrentCell = row.Cells[0];
                    break;
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
            double Toan = 0;
            double Van = 0;
            double Anh = 0;

            if (double.TryParse(txtToan.Text, out double DiemToan))
            {
                Toan += DiemToan;
            }

            if (double.TryParse(txtToan.Text, out double DiemVan))
            {
                Van += DiemVan;
            }

            if (double.TryParse(txtToan.Text, out double DiemAnh))
            {
                Anh += DiemAnh;
            }

            if (Anh > 10 || Anh < 0 || Van > 10 || Van < 0 || Toan > 10 || Toan < 0)
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
                double tongDiem = 0;
                int soMon = 0;

                if (double.TryParse(txtToan.Text, out double toan))
                {
                    tongDiem += toan;
                    soMon++;
                }

                if (double.TryParse(txtTienganh.Text, out double tienganh))
                {
                    tongDiem += tienganh;
                    soMon++;
                }

                if (double.TryParse(txtVan.Text, out double van))
                {
                    tongDiem += van;
                    soMon++;
                }

                if (soMon > 0)
                {
                    double diemTB = Math.Round(tongDiem / soMon, 2);
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

            string MaSV = txtMasv.Text;
            string query = "SELECT SV.MaSV, SV.TenSV, COALESCE(CAST(GD.Toan AS NVARCHAR), N'Chưa nhập') AS Toan, COALESCE(CAST(GD.Van AS NVARCHAR), N'Chưa nhập') AS Van, COALESCE(CAST(GD.TiengAnh AS NVARCHAR), N'Chưa nhập') AS TiengAnh, CASE WHEN GD.Toan IS NULL AND GD.Van IS NULL AND GD.TiengAnh IS NULL THEN N'Chưa xét' ELSE CAST(ROUND(CAST((COALESCE(GD.Toan, 0) + COALESCE(GD.Van, 0) + COALESCE(GD.TiengAnh, 0)) AS FLOAT) / 3, 2) AS NVARCHAR) END AS DiemTB FROM STUDENTS SV LEFT JOIN GRADE GD ON SV.MaSV = GD.MaSV WHERE SV.MaLop = @MaLop AND SV.MaSV LIKE @MaSV";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using(SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaLop", Malop);
                    cmd.Parameters.AddWithValue("@MaSV", "%" + MaSV + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dtHang = new DataTable();
                    da.Fill(dtHang);

                    dgvDanhSachSV.DataSource = dtHang;
                    
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

            ClearDiem();
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
            if (max == 0)
            {
                MessageBox.Show("Không có dữ liệu sinh viên!", "Thông báo");
                return;
            }

            if (pageIndex > 1)
            {
                pageIndex--;
                LoadCurrentData();
                LoadTrangThaiDulieu();
            }
            else
            {
                MessageBox.Show("Đã đến sinh viên đầu tiên!", "Thông báo");
            }
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            if (max == 0)
            {
                MessageBox.Show("Không có dữ liệu sinh viên!", "Thông báo");
                return;
            }

            if (pageIndex < max)
            {
                pageIndex++;
                LoadCurrentData();
                LoadTrangThaiDulieu();
            }
            else
            {
                MessageBox.Show("Đã đến sinh viên cuối!", "Thông báo");
            }
        }

        private void btnChangeAllLeft_Click(object sender, EventArgs e)
        {
            pageIndex = 1;
            LoadCurrentData();
            LoadTrangThaiDulieu();
        }

        private void btnChangeAllRight_Click(object sender, EventArgs e)
        {
            if (max == 0)
            {
                MessageBox.Show("Không có dữ liệu sinh viên!", "Thông báo");
                return;
            }
            pageIndex = max;
            LoadCurrentData();
            LoadTrangThaiDulieu();
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
                    cmd.Parameters.AddWithValue("@Tienganh", string.IsNullOrWhiteSpace(txtTienganh.Text) ? (object)DBNull.Value : txtTienganh.Text);
                    cmd.Parameters.AddWithValue("@van", string.IsNullOrWhiteSpace(txtVan.Text) ? (object)DBNull.Value : txtVan.Text);
                    cmd.Parameters.AddWithValue("@toan", string.IsNullOrWhiteSpace(txtToan.Text) ? (object)DBNull.Value : txtToan.Text);

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
                    cmd.Parameters.AddWithValue("@Tienganh", string.IsNullOrWhiteSpace(txtTienganh.Text) ? (object)DBNull.Value : txtTienganh.Text);
                    cmd.Parameters.AddWithValue("@van", string.IsNullOrWhiteSpace(txtVan.Text) ? (object)DBNull.Value : txtVan.Text);
                    cmd.Parameters.AddWithValue("@toan", string.IsNullOrWhiteSpace(txtToan.Text) ? (object)DBNull.Value : txtToan.Text);

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
                txtMasvDiemtb.Text = dgvDanhSachSV.CurrentRow.Cells["MaSV"]?.Value?.ToString();
                lbTenSV.Text = dgvDanhSachSV.CurrentRow.Cells["TenSV"]?.Value?.ToString();
                txtTienganh.Text = dgvDanhSachSV.CurrentRow.Cells["TiengAnh"]?.Value?.ToString();
                txtToan.Text = dgvDanhSachSV.CurrentRow.Cells["Toan"]?.Value?.ToString();
                txtVan.Text = dgvDanhSachSV.CurrentRow.Cells["Van"]?.Value?.ToString();
                lbDiemTB.Text = dgvDanhSachSV.CurrentRow.Cells["DiemTB"]?.Value?.ToString();

                LoadTrangThaiDulieu();
            }
        }

        private void txtMasv_Click(object sender, EventArgs e)
        {
            txtMasv.Text = null;
            txtMasv.ForeColor = Color.Black;
        }
    }
}
