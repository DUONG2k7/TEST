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
    public partial class UcTinTuc : UserControl
    {
        public UcTinTuc()
        {
            InitializeComponent();
        }
        public string TieuDe
        {
            get => txtTieuDe.Text;
            set => txtTieuDe.Text = value;
        }

        public string NoiDung
        {
            get => txtNoiDung.Text;
            set => txtNoiDung.Text = value;
        }

        public Image HinhAnh
        {
            get => pbAnh.Image;
            set => pbAnh.Image = value;
        }
    }
}
