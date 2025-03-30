using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QL
{
    public class DTO_SV
    {
        public string IDSV { get; set; }
        public string IDLop { get; set; }
        public string TenSV { get; set; }
        public string IdAcc { get; set; }
        public string Email { get; set; }
        public string SoDT { get; set; }
        public bool GioiTinh { get; set; }
        public string Diachi { get; set; }
        public byte[] Hinh { get; set; }

        public DTO_SV(string idsv, string idLop, string tenSV, string idAcc, string email, string soDT, bool gioiTinh, string diachi, byte[] hinh = null)
        {
            IDSV = idsv;
            IDLop = idLop;
            TenSV = tenSV;
            IdAcc = idAcc;
            Email = email;
            SoDT = soDT;
            GioiTinh = gioiTinh;
            Diachi = diachi;
            Hinh = hinh;
        }
    }
}
