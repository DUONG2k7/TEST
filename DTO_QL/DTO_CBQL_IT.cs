using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QL
{
    public class DTO_CBQL_IT
    {
        public string IDIT { get; set; }
        public int IDPhong { get; set; }
        public string TenIT { get; set; }
        public string IdAcc { get; set; }
        public string Email { get; set; }
        public string SoDT { get; set; }
        public bool Gioitinh { get; set; }
        public string Diachi { get; set; }
        public byte[] Hinh { get; set; }

        public DTO_CBQL_IT(string maIT, int IDPHONG, string tenIT, string email, string soDT, bool gioitinh, string diachi, byte[] hinh)
        {
            IDIT = maIT;
            IDPhong = IDPHONG;
            TenIT = tenIT;
            Email = email;
            SoDT = soDT;
            Gioitinh = gioitinh;
            Diachi = diachi;
            Hinh = hinh;
        }
    }
}
