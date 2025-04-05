using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DTO_QL
{
    public class DTO_CBQL_CBDT
    {
        public string IDCBDT { get; set; }
        public int IDPhong { get; set; }
        public string TenCBDT { get; set; }
        public string IdAcc { get; set; }
        public string Email { get; set; }
        public string SoDT { get; set; }
        public bool Gioitinh { get; set; }
        public string Diachi { get; set; }
        public byte[] Hinh { get; set; }

        public DTO_CBQL_CBDT(string maCBDT, int IDPHONG, string tenCBDT, string email, string soDT, bool gioitinh, string diachi, byte[] hinh)
        {
            IDCBDT = maCBDT;
            IDPhong = IDPHONG;
            TenCBDT = tenCBDT;
            Email = email;
            SoDT = soDT;
            Gioitinh = gioitinh;
            Diachi = diachi;
            Hinh = hinh;
        }
    }
}
