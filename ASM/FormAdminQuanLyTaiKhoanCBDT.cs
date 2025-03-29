using BUS_QL;
using DTO_QL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ASM
{
    public partial class FormAdminQuanLyTaiKhoanCBDT : Form
    {
        BUS_IT QlTaiKhoan = new BUS_IT();
        private bool isAdding = false;
        public FormAdminQuanLyTaiKhoanCBDT()
        {
            InitializeComponent();
            LoadDsTk();
            LoadDanhSachrole();
            LoadDanhSachChuaCoTaiKhoan();
            LockControl();

            dgvDatatK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private bool CheckInput()
        {
            if (cbRole.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtMaTk.Text) ||
                string.IsNullOrWhiteSpace(txtTk.Text) ||
                string.IsNullOrWhiteSpace(txtMk.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        public void LockControl()
        {
            txtMaTk.Enabled = false;
            txtTk.Enabled = false;
            txtMk.Enabled = false;
            cbRole.Enabled = false;
            cbTk.Enabled = false;
            btnSave.Enabled = false;
            btnUpdate.Enabled = false;
            btnLoU.Enabled = false;
            btnHis.Enabled = false;
        }
        public void ClearForm()
        {
            txtMaTk.Clear();
            txtTk.Clear();
            txtMk.Clear();
        }
        public void LoadDanhSachITChuaCoTaiKhoan()
        {
            cbTk.DataSource = QlTaiKhoan.LoadDsITChuaCoTaiKhoan();
            cbTk.DisplayMember = "TenIT";
            cbTk.ValueMember = "IDIT";
        }
        public void LoadDanhSachCBDTChuaCoTaiKhoan()
        {
            cbTk.DataSource = QlTaiKhoan.LoadDsCBDTChuaCoTaiKhoan();
            cbTk.DisplayMember = "TenCBDT";
            cbTk.ValueMember = "IDCBDT";
        }
        public void LoadDanhSachCBQLChuaCoTaiKhoan()
        {
            cbTk.DataSource = QlTaiKhoan.LoadDsCBQLChuaCoTaiKhoan();
            cbTk.DisplayMember = "TenCBQL";
            cbTk.ValueMember = "IDCBQL";
        }
        public void LoadDanhSachGiaoVienChuaCoTaiKhoan()
        {
            cbTk.DataSource = QlTaiKhoan.LoadDsGiaoVienChuaCoTaiKhoan();
            cbTk.DisplayMember = "TenGV";
            cbTk.ValueMember = "IDGV";
        }
        public void LoadDanhSachSinhVienChuaCoTaiKhoan()
        {
            cbTk.DataSource = QlTaiKhoan.LoadDsSinhVienChuaCoTaiKhoan();
            cbTk.DisplayMember = "TenSV";
            cbTk.ValueMember = "IDSV";
        }
        public void LoadDanhSachChuaCoTaiKhoan()
        {
            LoadDanhSachITChuaCoTaiKhoan();
            LoadDanhSachCBDTChuaCoTaiKhoan();
            LoadDanhSachCBQLChuaCoTaiKhoan();
            LoadDanhSachGiaoVienChuaCoTaiKhoan();
            LoadDanhSachSinhVienChuaCoTaiKhoan();
        }
        public void LoadDanhSachrole()
        {
            cbRole.DataSource = QlTaiKhoan.LoadDsRole();
            cbRole.DisplayMember = "Role";
            cbRole.ValueMember = "IDRole";
        }
        public void LoadDsTk()
        {
            dgvDatatK.DataSource = QlTaiKhoan.LoadDsTkCBDT();
            dgvDatatK.Columns[0].Visible = false;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            isAdding = false;
            txtMk.Enabled = true;
            cbRole.Enabled = true;
            cbTk.Enabled = true;
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnAdd.Enabled = false;
            btnLoU.Enabled = false;
            btnHis.Enabled = false;
            dgvDatatK.Enabled = false;
        }

        private void btnLoU_Click(object sender, EventArgs e)
        {
            string idacc = txtMaTk.Text;

            if (QlTaiKhoan.KtSoLuongTkIT(idacc))
            {
                MessageBox.Show("Không thể khóa tài khoản admin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (QlTaiKhoan.LockOrUnlockAccount(idacc))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDsTk();
                    LoadDanhSachChuaCoTaiKhoan();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tài khoản để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDatatK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDatatK.CurrentRow != null)
            {
                try
                {
                    btnUpdate.Enabled = true;

                    txtMaTk.Text = dgvDatatK.CurrentRow.Cells["IdAcc"]?.Value?.ToString() ?? string.Empty;
                    txtTk.Text = dgvDatatK.CurrentRow.Cells["Username"]?.Value?.ToString() ?? string.Empty;
                    cbRole.SelectedValue = dgvDatatK.CurrentRow.Cells["IDRole"]?.Value?.ToString() ?? string.Empty;
                    txtTrangthai.Text = dgvDatatK.CurrentRow.Cells["TrangThai"]?.Value?.ToString() ?? string.Empty;

                    btnLoU.Enabled = true;
                    btnHis.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xử lý dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHis_Click(object sender, EventArgs e)
        {
            if (dgvDatatK.CurrentRow != null && dgvDatatK.CurrentRow.Cells["IdAcc"] != null)
            {
                using (FormLichSuDangNhap frmhienthi = new FormLichSuDangNhap(txtMaTk.Text))
                {
                    frmhienthi.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một tài khoản trong danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRole.Text == "IT")
            {
                lbCapTaiKhoan.Visible = true;
                cbTk.Visible = true;
                LoadDanhSachITChuaCoTaiKhoan();
            }
            else if (cbRole.Text == "CBDT")
            {
                lbCapTaiKhoan.Visible = true;
                cbTk.Visible = true;
                LoadDanhSachCBDTChuaCoTaiKhoan();
            }
            else if (cbRole.Text == "CBQL")
            {
                lbCapTaiKhoan.Visible = true;
                cbTk.Visible = true;
                LoadDanhSachCBQLChuaCoTaiKhoan();
            }
            else if (cbRole.Text == "GV")
            {
                lbCapTaiKhoan.Visible = true;
                cbTk.Visible = true;
                LoadDanhSachGiaoVienChuaCoTaiKhoan();
            }
            else if (cbRole.Text == "SV")
            {
                lbCapTaiKhoan.Visible = true;
                cbTk.Visible = true;
                LoadDanhSachSinhVienChuaCoTaiKhoan();
            }
            else
            {
                lbCapTaiKhoan.Visible = false;
                cbTk.Visible = false;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            isAdding = true;
            txtTk.Enabled = true;
            txtMk.Enabled = true;
            cbRole.Enabled = true;
            cbTk.Enabled = true;
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnAdd.Enabled = false;
            btnLoU.Enabled = false;
            btnHis.Enabled = false;
            dgvDatatK.Enabled = false;

            ClearForm();

            string tiento = "A"; //tiền tố
            txtMaTk.Text = QlTaiKhoan.CreateID(tiento);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string ID = cbTk.SelectedValue?.ToString();
            string message;
            if (isAdding)
            {
                if (!CheckInput())
                {
                    MessageBox.Show("Dữ liệu nhập không hợp lệ!");
                    return;
                }

                if (QlTaiKhoan.KtTkDaTonTai(txtMaTk.Text))
                {
                    MessageBox.Show("Mã tài khoản đã tồn tại. Vui lòng nhập mã khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(ID))
                {
                    MessageBox.Show("Không còn ai chưa có tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DTO_IT taikhoan = new DTO_IT(txtMaTk.Text, txtTk.Text, txtMk.Text, cbRole.SelectedValue.ToString(), false, ID);
                if (QlTaiKhoan.AddNewAccount(taikhoan, out message))
                {
                    MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (ID == null)
                {
                    MessageBox.Show("Không còn ai chưa có tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DTO_IT taikhoan = new DTO_IT(txtMaTk.Text, txtMk.Text, ID);
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật tài khoản này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (QlTaiKhoan.UpdateAccount(taikhoan, out message))
                    {
                        MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            ClearForm();
            LockControl();

            LoadDsTk();
            LoadDanhSachChuaCoTaiKhoan();

            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            dgvDatatK.Enabled = true;
        }
    }
}
