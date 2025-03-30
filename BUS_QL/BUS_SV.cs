using DAL_QL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QL
{
    public class BUS_SV
    {
        DAL_SV QlSV = new DAL_SV();

        public DataTable LoadDsLichHocSv(string IdAcc)
        {
            return QlSV.GetListLichHocSv(IdAcc);
        }
        public DataTable LoadDsLichThiSv(string IdAcc)
        {
            return QlSV.GetListLichThiSv(IdAcc);
        }
        public DataTable LoadDsKyhoc()
        {
            return QlSV.GetListKyHoc();
        }
        public DataTable LayDiem(string IDACC, int IDKYHOC)
        {
            return QlSV.GetListDiem(IDACC, IDKYHOC);
        }
    }
}
