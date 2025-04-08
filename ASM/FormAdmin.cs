using BUS_QL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace ASM
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }
        private void btnMenuQlyIT_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormIT QlSV = new FormIT("I", "R01");
            QlSV.ShowDialog();
            this.Show();
        }

        private void btnMenuQlyCBDT_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCBDT QlSV = new FormCBDT("DT", "R02");
            QlSV.ShowDialog();
            this.Show();
        }

        private void btnMenuQlyCBQL_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCBQL QlSV = new FormCBQL("QL", "R03");
            QlSV.ShowDialog();
            this.Show();
        }

        private void btnMenuQlyPhongBan_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormGV QlSV = new FormGV("GV", "R04", "A08");
            QlSV.ShowDialog();
            this.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSV QlSV = new FormSV("SV", "R05", "A11");
            QlSV.ShowDialog();
            this.Show();
        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
