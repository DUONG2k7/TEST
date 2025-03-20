using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QL
{
    public class DTO_CBDT_CLASS
    {
        //    MaLop NVARCHAR(50) NOT NULL PRIMARY KEY,
        //ClassName NVARCHAR(50),
        //SiSo INT, -- Số lượng học sinh trong lớp
        //MaGV NVARCHAR(50), -- Giáo viên phụ trách lớp
        //Trangthai BIT,

        private string MaLop;
        private string ClassName;
        private string MaGV;

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
        public string _ClassName
        {
            get
            {
                return ClassName;
            }
            set
            {
                ClassName = value;
            }
        }
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
        public DTO_CBDT_CLASS(string malop, string classname, string magv)
        {
            _MaLop = malop;
            _ClassName = classname;
            _MaGV = magv;
        }
    }
}
