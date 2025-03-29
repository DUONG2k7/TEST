using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QL
{
    public class DTO_CBDT_MONHOC
    {
        public int IDMonHoc { get; set; }
        public string TenMon { get; set; }
        public int SoTiet { get; set; }

        public DTO_CBDT_MONHOC(int idmonhoc)
        {
            IDMonHoc = idmonhoc;
        }
        public DTO_CBDT_MONHOC(string tenmon, int sotiet)
        {
            TenMon = tenmon;
            SoTiet = sotiet;
        }
        public DTO_CBDT_MONHOC(int idmonhoc, string tenmon, int sotiet)
        {
            IDMonHoc = idmonhoc;
            TenMon = tenmon;
            SoTiet = sotiet;
        }
    }
}
