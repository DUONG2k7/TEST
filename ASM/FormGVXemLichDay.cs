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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ASM
{
    public partial class FormGVXemLichDay : Form
    {
        BUS_GV QLLICHDAY = new BUS_GV();
        string IdGv;
        int idkyhoc;
        public FormGVXemLichDay(string idacc, int idky)
        {
            InitializeComponent();

            idkyhoc = idky;
            IdGv = QLLICHDAY.GetIdGvFromIdAcc(idacc);
            cboLopHoc.Enabled = false;
            cboMonHoc.Enabled = false;
            dtpNgayDiemDanh.Enabled = false;
            rdbNgayhoc.Enabled = false;
            rdbNgaythi.Enabled = false;

            LoadDsLopGvDangDay();
            LoadDsMonHocGvDangDay();
            LayDsLichDay();

            dgvDanhSachSinhVien.Columns["Ngay"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvDanhSachSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void LayDsLichDay()
        {
            dgvDanhSachSinhVien.DataSource = QLLICHDAY.LayDsLichDay(IdGv);
        }
        public void LoadDsLopGvDangDay()
        {
            cboLopHoc.DataSource = QLLICHDAY.LoadDsLopGvDangDay(IdGv);
            cboLopHoc.DisplayMember = "ClassName";
            cboLopHoc.ValueMember = "IDLop";
        }
        public void LoadDsMonHocGvDangDay()
        {
            cboMonHoc.DataSource = QLLICHDAY.LoadDsMonHocGvDangDay(IdGv, cboLopHoc.SelectedValue.ToString());
            cboMonHoc.DisplayMember = "TenMon";
            cboMonHoc.ValueMember = "IDMonHoc";
        }
        private void btnDiemDanh_Click(object sender, EventArgs e)
        {
            int idlichhoc = Convert.ToInt32(dgvDanhSachSinhVien.CurrentRow.Cells["IDLichHoc"].Value);
            FormDiemDanhSV GV = new FormDiemDanhSV(cboLopHoc.SelectedValue.ToString(), Convert.ToInt32(cboMonHoc.SelectedValue), dtpNgayDiemDanh.Value, IdGv, idkyhoc, idlichhoc);
            GV.ShowDialog();
        }
        private void dgvDanhSachSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDanhSachSinhVien.CurrentRow != null)
            {
                try
                {
                    cboLopHoc.SelectedValue = dgvDanhSachSinhVien.CurrentRow.Cells["IDLop"].Value;
                    cboMonHoc.SelectedValue = dgvDanhSachSinhVien.CurrentRow.Cells["IDMonHoc"].Value;

                    dtpNgayDiemDanh.Value = Convert.ToDateTime(dgvDanhSachSinhVien.CurrentRow.Cells["Ngay"].Value);

                    string LoaiNgay = dgvDanhSachSinhVien.CurrentRow.Cells["LoaiNgay"]?.Value?.ToString();
                    if (!string.IsNullOrEmpty(LoaiNgay))
                    {
                        rdbNgayhoc.Checked = LoaiNgay == "Ngày học";
                        rdbNgaythi.Checked = LoaiNgay == "Ngày thi";
                    }
                    else
                    {
                        rdbNgayhoc.Checked = false;
                        rdbNgaythi.Checked = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xử lý dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
