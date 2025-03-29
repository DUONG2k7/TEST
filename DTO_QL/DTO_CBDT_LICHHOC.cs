using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QL
{
    public class DTO_CBDT_LICHHOC
    {
        public int IDLICHHOC { get; set; }
        public string IDLop { get; set; }
        public int IDMonHoc { get; set; }
        public string IDGV { get; set; }
        public int IDKyHoc { get; set; }
        public bool LoaiNgay { get; set; }
        public DateTime Ngay { get; set; }
        public TimeSpan GioBatDau { get; set; }
        public TimeSpan GioKetThuc { get; set; }

        public DTO_CBDT_LICHHOC(int idlichhoc, string idlop, int idmonhoc, string idgv, int idkyhoc, bool loaingay, DateTime ngay, TimeSpan giobatdau, TimeSpan gioketthuc)
        {
            IDLICHHOC = idlichhoc;
            IDLop = idlop;
            IDMonHoc = idmonhoc;
            IDGV = idgv;
            IDKyHoc = idkyhoc;
            LoaiNgay = loaingay;
            Ngay = ngay;
            GioBatDau = giobatdau;
            GioKetThuc = gioketthuc;
        }
        public DTO_CBDT_LICHHOC(string idlop, int idmonhoc, string idgv, int idkyhoc, bool loaingay, DateTime ngay, TimeSpan giobatdau, TimeSpan gioketthuc)
        {
            IDLop = idlop;
            IDMonHoc = idmonhoc;
            IDGV = idgv;
            IDKyHoc = idkyhoc;
            LoaiNgay = loaingay;
            Ngay = ngay;
            GioBatDau = giobatdau;
            GioKetThuc = gioketthuc;
        }
    }
}
