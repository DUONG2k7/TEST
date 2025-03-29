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
    public partial class FormQuanLyCongViec : Form
    {
        BUS_CBDT QlViec = new BUS_CBDT();
        bool IsAdding = false;
        DateTime? Nambatdau;
        public FormQuanLyCongViec(int IDKYHOC)
        {
            InitializeComponent();
            LoadDsMonHocGV();
            LoadDsMonHocFormChiDinhGV();
            LoadGiangVienList();
            LockControl();

            cbChonMonHoc.SelectedIndexChanged += cbChonMonHoc_SelectedIndexChanged;
            txtKyhoc.Text = IDKYHOC.ToString();
            Nambatdau = QlViec.LayNamBatDauKyHoc() ?? DateTime.Now;
            dtpNgayChotViec.Value = Nambatdau.Value.AddDays(-28);

            if (dgvDsMonHocGV.Columns.Contains("IDKyHoc"))
            {
                dgvDsMonHocGV.Columns["IDKyHoc"].Visible = false;
            }
            if (dgvDsMonHocGV.Columns.Contains("IDMonHoc"))
            {
                dgvDsMonHocGV.Columns["IDMonHoc"].Visible = false;
            }

            dgvDsMonHocGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiDinhGVtoMH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void LoadDsMonHocGV()
        {
            dgvDsMonHocGV.DataSource = QlViec.LoadDsMonHocGV();
        }
        public void LoadDsMonHocFormChiDinhGV()
        {
            cbChonMonHoc.DataSource = QlViec.LoadDsMonHocFormChiDinhGV();
            cbChonMonHoc.DisplayMember = "TenMon";
            cbChonMonHoc.ValueMember = "IDMonHoc";
        }
        private void LoadGiangVienList()
        {
            int idMonHoc = Convert.ToInt32(cbChonMonHoc.SelectedValue);
            dgvChiDinhGVtoMH.DataSource = QlViec.LoadDsGVFormChiDinhGV(idMonHoc);
        }
        private void cbChonMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGiangVienList();
        }
        public void LockControl()
        {
            cbChonMonHoc.Enabled = false;

            btnNew.Enabled = true;
            btnUpdateSetGVtoMH.Enabled = false;
            btnSaveChiDinhGVtoMH.Enabled = false;
            dtpNgayChotViec.Enabled = false;
            dgvDsMonHocGV.Enabled = true;
            dgvChiDinhGVtoMH.Enabled = true;
        }
        public void ClearForm()
        {
            cbChonMonHoc.SelectedIndex = -1;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            IsAdding = true;
            cbChonMonHoc.Enabled = true;
            dgvDsMonHocGV.Enabled = false;
            dtpNgayChotViec.Enabled = true;
            dgvChiDinhGVtoMH.Enabled = true;

            btnNew.Enabled = false;
            btnUpdateSetGVtoMH.Enabled = false;
            btnSaveChiDinhGVtoMH.Enabled = true;

            ClearForm();
        }

        private void btnUpdateSetGVtoMH_Click(object sender, EventArgs e)
        {

            IsAdding = false;
            cbChonMonHoc.Enabled = true;
            dgvDsMonHocGV.Enabled = false;
            dtpNgayChotViec.Enabled = true;
            dgvChiDinhGVtoMH.Enabled = true;

            btnNew.Enabled = false;
            btnUpdateSetGVtoMH.Enabled = false;
            btnSaveChiDinhGVtoMH.Enabled = true;

            if (QlViec.SuaChiDinhGVtoMonHoc(Convert.ToInt32(cbChonMonHoc.SelectedValue), out string message))
            {
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDsMonHocGV();
                LoadGiangVienList();
            }
            else
            {
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSaveChiDinhGVtoMH_Click(object sender, EventArgs e)
        {
            if (cbChonMonHoc.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn một môn học trước khi chỉ định giáo viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idKyhoc = Convert.ToInt32(txtKyhoc.Text);
            int idMonHoc = Convert.ToInt32(cbChonMonHoc.SelectedValue);
            bool hasChecked = false;
            int successCount = 0;
            List<string> errorMessages = new List<string>();

            foreach (DataGridViewRow row in dgvChiDinhGVtoMH.Rows)
            {
                if (row.Cells["CheckColumn"] is DataGridViewCheckBoxCell cell && Convert.ToBoolean(cell.Value))
                {
                    hasChecked = true;
                    string idGV = row.Cells["IDGV"].Value.ToString();

                    if (QlViec.ThemChiDinhGVtoMonHoc(idKyhoc, idMonHoc, idGV, dtpNgayChotViec.Value, out string message))
                    {
                        successCount++;
                    }
                    else
                    {
                        errorMessages.Add($"GV ID {idGV}: {message}"); // Lưu lỗi
                    }
                }
            }

            if (!hasChecked)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một giáo viên để chỉ định!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (successCount > 0)
                {
                    MessageBox.Show($"Đã chỉ định thành công {successCount} giáo viên vào môn học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LockControl();
                    LoadGiangVienList();
                    LoadDsMonHocGV();
                }

                if (errorMessages.Count > 0)
                {
                    MessageBox.Show("Có lỗi xảy ra với các giáo viên sau:\n" + string.Join("\n", errorMessages), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvDsMonHocGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdateSetGVtoMH.Enabled = true;
            if (e.RowIndex >= 0 && dgvDsMonHocGV.CurrentRow != null)
            {
                try
                {
                    cbChonMonHoc.SelectedValue = dgvDsMonHocGV.CurrentRow.Cells["IDMonHoc"]?.Value?.ToString() ?? string.Empty;
                    dtpNgayChotViec.Value = Convert.ToDateTime(dgvDsMonHocGV.CurrentRow.Cells["NgayChotViec"].Value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xử lý dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
