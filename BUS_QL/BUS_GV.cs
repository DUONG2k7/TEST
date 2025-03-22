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
    public class BUS_GV
    {
        DAL_GV QlGiaoVien = new DAL_GV();

        //Tất cả Form đều dùng
        public string GetMaLop(string taikhoan)
        {
            return QlGiaoVien.GetMaLop(taikhoan);
        }

        //Form Hiện Thị
        public DataTable GetData(string query, string Malop)
        {
            return QlGiaoVien.GetData(query, Malop);
        }

        //Form Quản Lý Điểm
        public DataTable LoadDsSinhVien(string Malop, string IdGv)
        {
            return QlGiaoVien.GetListStudent(Malop, IdGv);
        }
        public DataTable GetStudentsByPage(string Malop, string IdGv, int pageIndex, int pageSize)
        {
            return QlGiaoVien.GetStudentsByPage(Malop, IdGv, pageIndex, pageSize);
        }
        public string GetIdGvFromIdAcc(string Idacc)
        {
            return QlGiaoVien.GetIdGvFromIdAcc(Idacc);
        }
        public string GetIdMonhocFromIdGv(string IdGv)
        {
            return QlGiaoVien.GetIdMonhocFromIdGv(IdGv);
        }
        public int GetTotalStudent(string Malop)
        {
            return QlGiaoVien.GetTotalStudent(Malop);
        }
        public bool KtSvDaCoDiemChua(string maHs)
        {
            return QlGiaoVien.KtSvDaCoDiemChua(maHs);
        }
        public DataTable TimKiemSinhVien(string maLop, string maGV, string maSV)
        {
            return QlGiaoVien.SearchByID(maLop, maGV, maSV);
        }
        public bool ThemDiem(DTO_GV DiemSV, out string message)
        {
            return QlGiaoVien.InsertGrade(DiemSV, out message);
        }
        public bool CapNhattDiem(DTO_GV DiemSV, out string message)
        {
            return QlGiaoVien.UpdateGrade(DiemSV, out message);
        }
        public bool XoaDiem(DTO_GV DiemSV, out string message)
        {
            return QlGiaoVien.DeleteGrade(DiemSV, out message);
        }
    }
}
