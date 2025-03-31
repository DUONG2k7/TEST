using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QL
{
    public class DTO_GV_DIEMDANH
    {
    //    IDDiemDanh INT IDENTITY(1,1) PRIMARY KEY,
    //IDLichHoc INT NOT NULL,
    //IDGV NVARCHAR(50) NOT NULL,
    //IDSV NVARCHAR(50) NOT NULL,
    //ThoiGianDiemDanh DATETIME NOT NULL,
    //TrangThai BIT NOT NULL,
    //GhiChu NVARCHAR(255),
        public int IDDiemDanh { get; set; }
        public int IDLichHoc { get; set; }
        public string IDGV { get; set; }
        public string IDSV { get; set; }
        public DateTime ThoiGianDiemDanh { get; set; }
        public bool TrangThai { get; set; }
        public string GhiChu { get; set; }

        public DTO_GV_DIEMDANH(int IDLICHHOC, string idgv, string idsv, DateTime thoigian, bool trangthai, string ghichu)
        {
            IDLichHoc = IDLICHHOC;
            IDGV = idgv;
            IDSV = idsv;
            ThoiGianDiemDanh = thoigian;
            TrangThai = trangthai;
            GhiChu = ghichu;
        }
        public DTO_GV_DIEMDANH(int IDLICHHOC, DateTime thoigian)
        {
            IDLichHoc = IDLICHHOC;
            ThoiGianDiemDanh = thoigian;
        }
    }
}
