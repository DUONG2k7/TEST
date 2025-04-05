using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QL
{
    public class DTO_CBQL_CBQL
    {
        public string IDCBQL { get; set; }
        public int IDPhong { get; set; }
        public string TenCBQL { get; set; }
        public string IdAcc { get; set; }
        public string Email { get; set; }
        public string SoDT { get; set; }
        public bool Gioitinh { get; set; }
        public string Diachi { get; set; }
        public byte[] Hinh { get; set; }

        public DTO_CBQL_CBQL(string maCBQL, int IDPHONG, string tenCBQL, string email, string soDT, bool gioitinh, string diachi, byte[] hinh)
        {
            IDCBQL = maCBQL;
            IDPhong = IDPHONG;
            TenCBQL = tenCBQL;
            Email = email;
            SoDT = soDT;
            Gioitinh = gioitinh;
            Diachi = diachi;
            Hinh = hinh;
        }
    }
}
