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
    public class BUS_CBDT
    {
        DAL_CBDT QlThongTin = new DAL_CBDT();

        //Sinh Viên
        public DataTable LoadDsSinhVien()
        {
            return QlThongTin.GetListStudent();
        }
        public DataTable LoadDsLopChoSinhVien()
        {
            return QlThongTin.GetListClassFromStudent();
        }
        public int KtTrangThaiCuaLop(string MaLop)
        {
            return QlThongTin.checkStatusClass(MaLop);
        }
        public bool KtSvDaTonTai(string maHs)
        {
            return QlThongTin.KtSvDaTonTai(maHs);
        }
        public bool KiemTraSVDaCoDiemChua(string maSV)
        {
            return QlThongTin.KiemTraSVDaCoDiemChua(maSV);
        }
        public bool ThemSinhVien(DTO_CBDT_SV SinhVien)
        {
            return QlThongTin.InsertStudent(SinhVien);
        }
        public bool CapNhatSinhVien(DTO_CBDT_SV SinhVien)
        {
            return QlThongTin.UpdateStudent(SinhVien);
        }
        public bool XoaSinhVien(string maSV)
        {
            return QlThongTin.DeleteStudent(maSV);
        }
        public string CreateStudentID(string prefix)
        {
            return QlThongTin.CreateNewStudentId(prefix);
        }

        //Lớp
        public DataTable LoadDsLop()
        {
            return QlThongTin.GetListClass();
        }
        public DataTable LoadDsGvChoLop()
        {
            return QlThongTin.GetListTeacherFromClass();
        }
        public bool KtGVDaChiDinh(string maLop)
        {
            return QlThongTin.KtGVDaChiDinh(maLop);
        }
        public bool KtLopDaTonTai(string maLop)
        {
            return QlThongTin.KtLopDaTonTai(maLop);
        }
        public bool ThemLop(DTO_CBDT_CLASS lop)
        {
            return QlThongTin.InsertClass(lop);
        }
        public bool CapNhatLop(DTO_CBDT_CLASS lop)
        {
            return QlThongTin.UpdateClass(lop);
        }
        public bool XoaLop(string maLop)
        {
            return QlThongTin.DeleteClass(maLop);
        }
        public bool LockOrUnlockClass(string maLop)
        {
            return QlThongTin.LockOrUnlockClass(maLop);
        }
        public string CreateNewClassId(string prefix)
        {
            return QlThongTin.CreateNewClassId(prefix);
        }

        //Giáo viên
        public DataTable LoadDsGiaoVien()
        {
            return QlThongTin.GetListTeacher();
        }
        public bool KtGvDaTonTai(string maGV)
        {
            return QlThongTin.KtGvDaTonTai(maGV);
        }
        public bool KtTKDaChiDinh(string MaGV)
        {
            return QlThongTin.KtTKDaChiDinh(MaGV);
        }
        public bool ThemGiaoVien(DTO_CBDT_GV GiaoVien)
        {
            return QlThongTin.InsertTeacher(GiaoVien);
        }
        public bool CapNhatGiaoVien(DTO_CBDT_GV GiaoVien)
        {
            return QlThongTin.UpdateTeacher(GiaoVien);
        }
        public bool XoaGiaoVien(string magv)
        {
            return QlThongTin.DeleteTeacher(magv);
        }
        public string CreateNewTeacherId(string prefix)
        {
            return QlThongTin.CreateNewTeacherId(prefix);
        }
    }
}
