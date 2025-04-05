using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QL
{
    public class DTO_GV_DIEM
    {
        private int IDKyHoc;
        private string MaSV;
        private int IDMonHoc;
        private string Diem;

        public int _IDKyHoc
        {
            get
            {
                return IDKyHoc;
            }
            set
            {
                IDKyHoc = value;
            }
        }
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
        public int _IDMonHoc
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
        public DTO_GV_DIEM(int IDKYHOC, string MASV, int IDMONHOC, string DIEM)
        {
            _IDKyHoc = IDKYHOC;
            _MaSV = MASV;
            _IDMonHoc = IDMONHOC;
            _Diem = DIEM;
        }
        public DTO_GV_DIEM(int IDKYHOC, string MASV, int IDMONHOC)
        {
            _IDKyHoc = IDKYHOC;
            _MaSV = MASV;
            _IDMonHoc = IDMONHOC;
        }
    }
}
