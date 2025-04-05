using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QL
{
    public class DTO_CBQL_GV
    {
        //    MaGV NVARCHAR(50) NOT NULL PRIMARY KEY,
        //TenGV NVARCHAR(50),
        //IdAcc NVARCHAR(50),
        //Email NVARCHAR(50),
        //SoDT NVARCHAR(15),
        //Gioitinh BIT,
        //Diachi NVARCHAR(50),
        //Hinh VARBINARY(MAX),
        private string MaGV;
        private string TenGV;
        private string IdAcc;
        private string Email;
        private string SoDT;
        private bool Gioitinh;
        private string Diachi;
        private byte[] Hinh;

        public string _MaGV
        {
            get
            {
                return MaGV;
            }
            set
            {
                MaGV = value;
            }
        }
        public string _TenGV
        {
            get
            {
                return TenGV;
            }
            set
            {
                TenGV = value;
            }
        }
        public string _IdAcc
        {
            get
            {
                return IdAcc;
            }
            set
            {
                IdAcc = value;
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
        public DTO_CBQL_GV(string maGV, string tenGV, string email, string soDT, bool gioitinh, string diachi, byte[] hinh)
        {
            _MaGV = maGV;
            _TenGV = tenGV;
            _Email = email;
            _SoDT = soDT;
            _Gioitinh = gioitinh;
            _Diachi = diachi;
            _Hinh = hinh;
        }
    }
}
