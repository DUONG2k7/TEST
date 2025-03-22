using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QL
{
    public class DTO_GV
    {
        private string MaSV;
        private string IDMonHoc;
        private string Diem;

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
        public string _IDMonHoc
        {
            get
            {
                return IDMonHoc;
            }
            set
            {
                IDMonHoc = value;
            }
        }
        public string _Diem
        {
            get
            {
                return Diem;
            }
            set
            {
                Diem = value;
            }
        }
        public DTO_GV(string MASV, string IDMONHOC, string DIEM)
        {
            _MaSV = MASV;
            _IDMonHoc = IDMONHOC;
            _Diem = DIEM;
        }
        public DTO_GV(string MASV, string IDMONHOC)
        {
            _MaSV = MASV;
            _IDMonHoc = IDMONHOC;
        }
    }
}
