using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QL
{
    public class DTO_GV
    {
        private string MaSV;
        private string TenSV;
        private string TenMon;
        private double Diem;

        public string _MaSV
        {
            get
            {
                return MaSV;
            }
            set
            {
                MaSV = value;
            }
        }
        public string _TenSV
        {
            get
            {
                return TenSV;
            }
            set
            {
                TenSV = value;
            }
        }
        public string _TenMon
        {
            get
            {
                return TenMon;
            }
            set
            {
                TenMon = value;
            }
        }
        public double _Diem
        {
            get
            {
                return Diem;
            }
            set
            {
                Diem = value;
            }
        }
    }
}
