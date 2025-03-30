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
    public partial class FormSvXemLichHoc : Form
    {
        BUS_SV QlLichHocSv = new BUS_SV();
        public FormSvXemLichHoc(string IDacc)
        {
            InitializeComponent();
            LoadDsLichHocGV(IDacc);

            dgvLichHoc.Columns["Ngay"].DefaultCellStyle.Format = "dd/MM/yyyy";
            if (dgvLichHoc.Columns.Contains("IDKyHoc"))
            {
                dgvLichHoc.Columns["IDKyHoc"].Visible = false;
            }
            if (dgvLichHoc.Columns.Contains("LoaiNgay"))
            {
                dgvLichHoc.Columns["LoaiNgay"].Visible = false;
            }
            if (dgvLichHoc.Columns.Contains("IDLop"))
            {
                dgvLichHoc.Columns["IDLop"].Visible = false;
            }
            if (dgvLichHoc.Columns.Contains("IDGV"))
            {
                dgvLichHoc.Columns["IDGV"].Visible = false;
            }
        }
        public void LoadDsLichHocGV(string IDacc)
        {
            dgvLichHoc.DataSource = QlLichHocSv.LoadDsLichHocSv(IDacc);
        }
    }
}
