using BUS_QL;
using DTO_QL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM
{
    public partial class FormQuanLySVDaCoDiem : Form
    {
        BUS_GV QlGiangVien = new BUS_GV();

        DataTable dt;
        bool IsAdding = false;
        int currentindex = -1;
        int max;
        string Malop;
        string IdGv;
        int IdMonhoc;
        int idkyhoc;
        public FormQuanLySVDaCoDiem(string Tk, string Idacc, int IDKYHOC)
        {
            InitializeComponent();
            idkyhoc = IDKYHOC;
            Malop = QlGiangVien.GetMaLop(Tk);
            max = QlGiangVien.GetTotalStudent(Malop);
            IdGv = QlGiangVien.GetIdGvFromIdAcc(Idacc);
            IdMonhoc = QlGiangVien.GetIdMonhocFromIdGv(IdGv);
            LoadDsSv();
            LockControl();
            
            dgvDanhSachSV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void LoadDsSv()
        {
            dt = QlGiangVien.LoadDsSinhVien(Malop, IdGv);
            dgvDanhSachSV.DataSource = QlGiangVien.LoadDsSinhVien(Malop,IdGv);
        }

        public void LoadTrangThaiDulieu()
        {
            if (txtDiem.Text.Trim().Equals("Chưa nhập", StringComparison.OrdinalIgnoreCase))
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
        private void LoadTrangThaiNutChuyenTrang()
        {
            btnChangeLeft.Enabled = currentindex > 0;
            btnChangeAllLeft.Enabled = currentindex > 0;
            BtnRight.Enabled = currentindex < max - 1;
            btnChangeAllRight.Enabled = currentindex < max - 1;
        }
        public bool Ktdv()
        {
            double Diem = 0;
            if (double.TryParse(txtDiem.Text, out double DiemToan))
            {
                Diem += DiemToan;
            }

            if (Diem > 10 || Diem < 0)
            {
                MessageBox.Show("Điểm phải nằm trong khoảng 0 đến 10!", "Thông báo");
                return false;
            }
            return true;
        }
        private void SelectStudent(int index)
        {
            if (index >= 0 && index < dt.Rows.Count)
            {
                DataRow row = dt.Rows[index];
                txtMasvDiemtb.Text = row["IDSV"].ToString();
                lbTenSV.Text = row["TenSV"].ToString();
                txtTenMon.Text = row["TenMon"].ToString();
                txtDiem.Text = row["Diem"].ToString();

                dgvDanhSachSV.ClearSelection();
                dgvDanhSachSV.Rows[index].Selected = true;
                dgvDanhSachSV.CurrentCell = dgvDanhSachSV.Rows[index].Cells[0];
            }
        }
        public void LockControl()
        {
            txtDiem.Enabled = false;
            txtTenMon.Enabled = false;

            btnNew.Enabled = true;
            btnUpdate.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
        }
        public void ClearForm()
        {
            txtMasv.Clear();
            lbTenSV.Text = "";
            txtMasvDiemtb.Clear();
            txtDiem.Clear();
        }
        public void ClearDiem()
        {
            txtDiem.Clear();
        }
        private void txtMasv_Click(object sender, EventArgs e)
        {
            txtMasv.Text = null;
            txtMasv.ForeColor = Color.Black;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMasv.Text))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên cần tìm!", "Thông báo");
                return;
            }

            try
            {
                DataTable result = QlGiangVien.TimKiemSinhVien(Malop, IdGv, txtMasv.Text);
                if (result.Rows.Count > 0)
                {
                    dgvDanhSachSV.DataSource = result;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDsSv();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtMasv.Clear();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            IsAdding = true;
            txtDiem.Enabled = true;

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            IsAdding = false;
            txtDiem.Enabled = true;

            btnSave.Enabled = true;
            btnNew.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            btnChangeAllLeft.Enabled = false;
            btnChangeAllRight.Enabled = false;
            btnChangeLeft.Enabled = false;
            BtnRight.Enabled = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string message;
            if (IsAdding)
            {
                if (!Ktdv())
                {
                    return;
                }

                DTO_GV Diemsv = new DTO_GV(idkyhoc, txtMasvDiemtb.Text, IdMonhoc, txtDiem.Text);
                if (QlGiangVien.ThemDiem(Diemsv, out message))
                {
                    MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LockControl();
                    LoadDsSv();
                }
                else
                {
                    MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (!Ktdv())
                {
                    return;
                }

                DTO_GV Diemsv = new DTO_GV(idkyhoc, txtMasvDiemtb.Text, IdMonhoc, txtDiem.Text);
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật điểm không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (QlGiangVien.CapNhattDiem(Diemsv, out message))
                    {
                        MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                        LockControl();
                    }
                    else
                    {
                        MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

            LoadDsSv();
            LoadTrangThaiDulieu();
            LoadTrangThaiNutChuyenTrang();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string message;
            DTO_GV Diemsv = new DTO_GV(idkyhoc, txtMasvDiemtb.Text, IdMonhoc);
            DialogResult s = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (s == DialogResult.Yes)
            {
                if (QlGiangVien.XoaDiem(Diemsv, out message))
                {
                    MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LockControl();
                    LoadDsSv();
                }
                else
                {
                    MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
            LoadTrangThaiDulieu();
            LoadTrangThaiNutChuyenTrang();
        }
        private void btnChangeLeft_Click(object sender, EventArgs e)
        {
            currentindex--;
            SelectStudent(currentindex);
            LoadTrangThaiDulieu();
            LoadTrangThaiNutChuyenTrang();
        }
        private void BtnRight_Click(object sender, EventArgs e)
        {
            currentindex++;
            SelectStudent(currentindex);
            LoadTrangThaiDulieu();
            LoadTrangThaiNutChuyenTrang();
        }
        private void btnChangeAllLeft_Click(object sender, EventArgs e)
        {
            currentindex = 0;
            SelectStudent(currentindex);
            LoadTrangThaiDulieu();
            LoadTrangThaiNutChuyenTrang();
        }
        private void btnChangeAllRight_Click(object sender, EventArgs e)
        {
            currentindex = max - 1;
            SelectStudent(currentindex);
            LoadTrangThaiDulieu();
            LoadTrangThaiNutChuyenTrang();
        }
        private void dgvDanhSachSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDanhSachSV.CurrentRow != null)
            {
                currentindex = e.RowIndex;

                txtMasvDiemtb.Text = dgvDanhSachSV.CurrentRow.Cells["IDSV"]?.Value?.ToString();
                lbTenSV.Text = dgvDanhSachSV.CurrentRow.Cells["TenSV"]?.Value?.ToString();
                txtTenMon.Text = dgvDanhSachSV.CurrentRow.Cells["TenMon"]?.Value?.ToString();
                txtDiem.Text = dgvDanhSachSV.CurrentRow.Cells["Diem"]?.Value?.ToString();

                LoadTrangThaiDulieu();
                LoadTrangThaiNutChuyenTrang();
            }
        }
        private void FormQuanLyDiemSV_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
    }
}
