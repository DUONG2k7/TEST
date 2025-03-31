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
    public partial class FormBaoCaoDiemDanh : Form
    {
        BUS_GV qlBaocaoDiemDanh = new BUS_GV();
        public FormBaoCaoDiemDanh(int idLichHoc, DateTime Ngay)
        {
            InitializeComponent();
            LoadDSDIEM(idLichHoc, Ngay);

            if (dgvBaoCao.Columns.Contains("ThoiGianDiemDanh"))
            {
                dgvBaoCao.Columns["ThoiGianDiemDanh"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            dgvBaoCao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void LoadDSDIEM(int idLichHoc, DateTime Ngay)
        {
            dgvBaoCao.DataSource = qlBaocaoDiemDanh.LoadDsBaoCaoDiemDanh(idLichHoc, Ngay);
        }
    }
}
