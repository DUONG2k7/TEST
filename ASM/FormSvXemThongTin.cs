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
    public partial class FormSvXemThongTin : Form
    {
        string idacc;
        public FormSvXemThongTin(string IDACC)
        {
            InitializeComponent();
            idacc = IDACC;
        }

        private void FormSvXemThongTin_Load(object sender, EventArgs e)
        {
            tpXemDiem.Controls.Clear();
            FormSvXemDiem QlGV1 = new FormSvXemDiem(idacc);
            QlGV1.TopLevel = false;
            QlGV1.FormBorderStyle = FormBorderStyle.None;
            QlGV1.Dock = DockStyle.Fill;
            tpXemDiem.Controls.Add(QlGV1);
            QlGV1.Show();

            tpXemLichHoc.Controls.Clear();
            FormSvXemLichHoc QlGV2 = new FormSvXemLichHoc(idacc);
            QlGV2.TopLevel = false;
            QlGV2.FormBorderStyle = FormBorderStyle.None;
            QlGV2.Dock = DockStyle.Fill;
            tpXemLichHoc.Controls.Add(QlGV2);
            QlGV2.Show();

            tpXemLichThi.Controls.Clear();
            FormSvXemLichThi QlGV3 = new FormSvXemLichThi(idacc);
            QlGV3.TopLevel = false;
            QlGV3.FormBorderStyle = FormBorderStyle.None;
            QlGV3.Dock = DockStyle.Fill;
            tpXemLichThi.Controls.Add(QlGV3);
            QlGV3.Show();
        }
    }
}
