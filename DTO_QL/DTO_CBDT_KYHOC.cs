using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QL
{
    public class DTO_CBDT_KYHOC
    {
        public int IDKyHoc { get; set; }
        public string TenKy { get; set; }
        public DateTime NamBatDau { get; set; }
        public DateTime NamKetThuc { get; set; }
        public bool Trangthai { get; set; }

        public DTO_CBDT_KYHOC(int iDKyHoc)
        {
            IDKyHoc = iDKyHoc;
        }
        public DTO_CBDT_KYHOC(string tenKy, DateTime namBatDau, DateTime namKetThuc, bool trangthai)
        {
            TenKy = tenKy;
            NamBatDau = namBatDau;
            NamKetThuc = namKetThuc;
            Trangthai = trangthai;
        }
        public DTO_CBDT_KYHOC(int iDKyHoc, string tenKy, DateTime namBatDau, DateTime namKetThuc)
        {
            IDKyHoc = iDKyHoc;
            TenKy = tenKy;
            NamBatDau = namBatDau;
            NamKetThuc = namKetThuc;
        }
    }
}
