using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QL
{
    public class DTO_CBDT_SV
    {
        //MaSV NVARCHAR(50) NOT NULL PRIMARY KEY,
        //MaLop NVARCHAR(50) NOT NULL, -- Mỗi học sinh thuộc một lớp
        //TenSV NVARCHAR(50),
        //Email NVARCHAR(50),
        //SoDT NVARCHAR(15),
        //Gioitinh BIT,
        //Diachi NVARCHAR(50),
        //Hinh VARBINARY(MAX),
        private string MaSV;
        private string MaLop;
        private string TenSV;
        private string Email;
        private string SoDT;
        private bool Gioitinh;
        private string Diachi;
        private byte[] Hinh;

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
        public string _MaLop
        {
            get
            {
                return MaLop;
            }
            set
            {
                MaLop = value;
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
        public string _Email
        {
            get
            {
                return Email;
            }
            set
            {
                Email = value;
            }
        }
        public string _SoDT
        {
            get
            {
                return SoDT;
            }
            set
            {
                SoDT = value;
            }
        }
        public bool _Gioitinh
        {
            get
            {
                return Gioitinh;
            }
            set
            {
                Gioitinh = value;
            }
        }
        public string _Diachi
        {
            get
            {
                return Diachi;
            }
            set
            {
                Diachi = value;
            }
        }
        public byte[] _Hinh
        {
            get
            {
                return Hinh;
            }
            set
            {
                Hinh = value;
            }
        }
        public DTO_CBDT_SV(string maSV, string maLop, string tenSV, string email, string soDT, bool gioitinh, string diachi, byte[] hinh)
        {
            _MaSV = maSV;
            _MaLop = maLop;
            _TenSV = tenSV;
            _Email = email;
            _SoDT = soDT;
            _Gioitinh = gioitinh;
            _Diachi = diachi;
            _Hinh = hinh;
        }
    }
}
