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
    public partial class FormSvXemLichThi : Form
    {
        BUS_SV QlLichThiSv = new BUS_SV();
        public FormSvXemLichThi(string IDacc)
        {
            InitializeComponent();
            LoadDsLichThiGV(IDacc);

            dgvLichThi.Columns["Ngay"].DefaultCellStyle.Format = "dd/MM/yyyy";
            if (dgvLichThi.Columns.Contains("IDKyHoc"))
            {
                dgvLichThi.Columns["IDKyHoc"].Visible = false;
            }
            if (dgvLichThi.Columns.Contains("LoaiNgay"))
            {
                dgvLichThi.Columns["LoaiNgay"].Visible = false;
            }
            if (dgvLichThi.Columns.Contains("IDLop"))
            {
                dgvLichThi.Columns["IDLop"].Visible = false;
            }
            if (dgvLichThi.Columns.Contains("IDGV"))
            {
                dgvLichThi.Columns["IDGV"].Visible = false;
            }
        }
        public void LoadDsLichThiGV(string IDacc)
        {
            dgvLichThi.DataSource = QlLichThiSv.LoadDsLichThiSv(IDacc);
        }
    }
}
