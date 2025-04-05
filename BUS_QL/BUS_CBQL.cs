using DAL_QL;
using DTO_QL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QL
{
    public class BUS_CBQL
    {
        DAL_CBQL QlThongTin = new DAL_CBQL();

        //IT
        public DataTable LoadDsIT()
        {
            return QlThongTin.GetListIT();
        }
        public bool ThemIT(DTO_CBQL_IT IT, out string message)
        {
            return QlThongTin.InsertIT(IT, out message);
        }
        public bool CapNhatIT(DTO_CBQL_IT IT, out string message)
        {
            return QlThongTin.UpdateIT(IT, out message);
        }
        public string CreateNewItId(string prefix)
        {
            return QlThongTin.CreateNewItId(prefix);
        }

        //CBDT
        public DataTable LoadDsCBDT()
        {
            return QlThongTin.GetListCBDT();
        }
        public bool ThemCBDT(DTO_CBQL_CBDT CBDT, out string message)
        {
            return QlThongTin.InsertCBDT(CBDT, out message);
        }
        public bool CapNhatCBDT(DTO_CBQL_CBDT CBDT, out string message)
        {
            return QlThongTin.UpdateCBDT(CBDT, out message);
        }
        public string CreateNewCBDTId(string prefix)
        {
            return QlThongTin.CreateNewCBDTId(prefix);
        }

        //CBQL
        public DataTable LoadDsCBQL()
        {
            return QlThongTin.GetListCBQL();
        }
        public bool ThemCBQL(DTO_CBQL_CBQL CBQL, out string message)
        {
            return QlThongTin.InsertCBQL(CBQL, out message);
        }
        public bool CapNhatCBQL(DTO_CBQL_CBQL CBQL, out string message)
        {
            return QlThongTin.UpdateCBQL(CBQL, out message);
        }
        public string CreateNewCBQLId(string prefix)
        {
            return QlThongTin.CreateNewCBQLId(prefix);
        }

        //Phòng ban
        public DataTable LoadDsPhong()
        {
            return QlThongTin.GetListPhong();
        }
        public bool ThemPhong(string TenPhong, out string message)
        {
            return QlThongTin.InsertPhong(TenPhong, out message);
        }
        public bool CapNhatPhong(int IDPhong, string TenPhong, out string message)
        {
            return QlThongTin.UpdatePhong(IDPhong, TenPhong, out message);
        }
    }
}
