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
    public partial class FormQuanLyNhanSu : Form
    {
        public FormQuanLyNhanSu()
        {
            InitializeComponent();
        }
        private void FormQuanLyNhanSu_Load(object sender, EventArgs e)
        {
            tabPageCBDT.Controls.Clear();
            FormQuanLyCBDT QlGV1 = new FormQuanLyCBDT();
            QlGV1.TopLevel = false;
            QlGV1.FormBorderStyle = FormBorderStyle.None;
            QlGV1.Dock = DockStyle.Fill;
            tabPageCBDT.Controls.Add(QlGV1);
            QlGV1.Show();

            tabPageCBQL.Controls.Clear();
            FormQuanLyCBQL QlGV2 = new FormQuanLyCBQL();
            QlGV2.TopLevel = false;
            QlGV2.FormBorderStyle = FormBorderStyle.None;
            QlGV2.Dock = DockStyle.Fill;
            tabPageCBQL.Controls.Add(QlGV2);
            QlGV2.Show();

            tabPageIT.Controls.Clear();
            FormQuanLyIT QlGV3 = new FormQuanLyIT();
            QlGV3.TopLevel = false;
            QlGV3.FormBorderStyle = FormBorderStyle.None;
            QlGV3.Dock = DockStyle.Fill;
            tabPageIT.Controls.Add(QlGV3);
            QlGV3.Show();
        }
    }
}
