using DAL_QL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QL;

namespace BUS_QL
{
    public class BUS_IT
    {
        DAL_IT TruyVanTaiKhoan = new DAL_IT();

        public DataTable LoadDsTkIT()
        {
            return TruyVanTaiKhoan.GetListAccountIT();
        }
        public DataTable LoadDsTkCBDT()
        {
            return TruyVanTaiKhoan.GetListAccountCBDT();
        }
        public DataTable LoadDsTkGV()
        {
            return TruyVanTaiKhoan.GetListAccountGV();
        }
        public DataTable LoadDsTkGLOBALBAN()
        {
            return TruyVanTaiKhoan.GetListAccountGLOBALBAN();
        }
        public DataTable LoadDsRole()
        {
            return TruyVanTaiKhoan.GetListRole();
        }
        public DataTable LoadDsITChuaCoTaiKhoan()
        {
            return TruyVanTaiKhoan.GetListITChuaCoTaiKhoan();
        }
        public DataTable LoadDsCBDTChuaCoTaiKhoan()
        {
            return TruyVanTaiKhoan.GetListCBDTChuaCoTaiKhoan();
        }
        public DataTable LoadDsCBQLChuaCoTaiKhoan()
        {
            return TruyVanTaiKhoan.GetListCBQLChuaCoTaiKhoan();
        }
        public DataTable LoadDsGiaoVienChuaCoTaiKhoan()
        {
            return TruyVanTaiKhoan.GetListGiaoVienChuaCoTaiKhoan();
        }
        public DataTable LoadDsSinhVienChuaCoTaiKhoan()
        {
            return TruyVanTaiKhoan.GetListSinhVienChuaCoTaiKhoan();
        }
        public DataTable LoadLichSu(string idAcc)
        {
            return TruyVanTaiKhoan.GetListHistory(idAcc);
        }
        public string LayRoleCuaTk(string mataikhoan)
        {
            return TruyVanTaiKhoan.GetRole(mataikhoan);
        }
        public bool AddNewAccount(DTO_IT taikhoan, out string message)
        {
            return TruyVanTaiKhoan.InsertAccount(taikhoan, out message);
        }
        public bool UpdateAccount(DTO_IT taikhoan, out string message)
        {
            return TruyVanTaiKhoan.UpdateAccount(taikhoan, out message);
        }
        public bool LockOrUnlockAccount(string idAcc)
        {
            return TruyVanTaiKhoan.LockOrUnlockAccount(idAcc);
        }
        public bool KtSoLuongTkIT(string idAcc)
        {
            return TruyVanTaiKhoan.KtSlRoleAdmin(idAcc);
        }
        public string CreateID(string prefix)
        {
            return TruyVanTaiKhoan.CreateNewId(prefix);
        }
        public bool KtTkDaCapGvChua(string idAcc)
        {
            return TruyVanTaiKhoan.KtTkDaCapGvChua(idAcc);
        }
        public bool KtTkDaTonTai(string maTk)
        {
            return TruyVanTaiKhoan.KtTkDaTonTai(maTk);
        }
    }
}
