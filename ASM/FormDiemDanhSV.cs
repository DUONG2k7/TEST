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
    public partial class FormDiemDanhSV : Form
    {
        BUS_GV QLDiemDanh = new BUS_GV();
        int IDLICHHOC;
        string IdGv;
        int IDKyHoc;
        public FormDiemDanhSV(string idacc, int IDKYHOC)
        {
            InitializeComponent();
            IdGv = QLDiemDanh.GetIdGvFromIdAcc(idacc);
            IDKyHoc = IDKYHOC;

            LoadDsLopGvDangDay();
            LoadDsMonHocGvDangDay();

            IDLICHHOC = QLDiemDanh.LayIDLichHOC(cboLopHoc.SelectedValue.ToString(), Convert.ToInt32(cboMonHoc.SelectedValue), IdGv, IDKyHoc);
            dtpNgayDiemDanh.Value = QLDiemDanh.LayNgayDiemdanh(IDLICHHOC) ?? DateTime.Now;
            LoadDsSvDiemDanh();

            dgvDanhSachSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void LoadDsSvDiemDanh()
        {
            dgvDanhSachSinhVien.DataSource = QLDiemDanh.LoadDsSinhVienDiemDanh(cboLopHoc.SelectedValue.ToString(), IDLICHHOC, dtpNgayDiemDanh.Value);
        }
        public void LoadDsLopGvDangDay()
        {
            cboLopHoc.DataSource = QLDiemDanh.LoadDsLopGvDangDay(IdGv);
            cboLopHoc.DisplayMember = "ClassName";
            cboLopHoc.ValueMember = "IDLop";
        }
        public void LoadDsMonHocGvDangDay()
        {
            cboMonHoc.DataSource = QLDiemDanh.LoadDsMonHocGvDangDay(IdGv, cboLopHoc.SelectedValue.ToString());
            cboMonHoc.DisplayMember = "TenMon";
            cboMonHoc.ValueMember = "IDMonHoc";
        }

        private void cboLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDsMonHocGvDangDay();
            LoadDsSvDiemDanh();
            dtpNgayDiemDanh.Value = QLDiemDanh.LayNgayDiemdanh(IDLICHHOC) ?? DateTime.Now;
        }

        private void cboMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDsSvDiemDanh();
            dtpNgayDiemDanh.Value = QLDiemDanh.LayNgayDiemdanh(IDLICHHOC) ?? DateTime.Now;
        }

        private void dtpNgayDiemDanh_ValueChanged(object sender, EventArgs e)
        {
            LoadDsSvDiemDanh();
        }
    }
}
