using DAL_QL;
using DTO_QL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        public bool ThemSinhVien(DTO_CBDT_SV SinhVien, out string message)
        {
            return QlThongTin.InsertStudent(SinhVien, out message);
        }
        public bool CapNhatSinhVien(DTO_CBDT_SV SinhVien, out string message)
        {
            return QlThongTin.UpdateStudent(SinhVien, out message);
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
        public bool ThemLop(DTO_CBDT_CLASS lop, out string message)
        {
            return QlThongTin.InsertClass(lop, out message);
        }
        public bool CapNhatLop(DTO_CBDT_CLASS lop, out string message)
        {
            return QlThongTin.UpdateClass(lop, out message);
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
        public bool ThemGiaoVien(DTO_CBDT_GV GiaoVien, out string message)
        {
            return QlThongTin.InsertTeacher(GiaoVien, out message);
        }
        public bool CapNhatGiaoVien(DTO_CBDT_GV GiaoVien, out string message)
        {
            return QlThongTin.UpdateTeacher(GiaoVien, out message);
        }
        public bool XoaGiaoVien(string magv)
        {
            return QlThongTin.DeleteTeacher(magv);
        }
        public string CreateNewTeacherId(string prefix)
        {
            return QlThongTin.CreateNewTeacherId(prefix);
        }

        //Lịch học
        public DataTable LoadDsLich()
        {
            return QlThongTin.GetListLich();
        }
        public int GetIdKyHocDangHoc()
        {
            return QlThongTin.GetIdKyHocDangHoc();
        }
        public DataTable LoadDsLopFormLich()
        {
            return QlThongTin.GetListClassFormLich();
        }
        public string LoadBuoiHoc(string IDLop)
        {
            return QlThongTin.GetBuoiHocFromLich(IDLop);
        }
        public DataTable LoadDsMonHoc()
        {
            return QlThongTin.GetListSubjectFormLich();
        }
        public DataTable LoadDsGvBoMon(string IdMonHoc)
        {
            return QlThongTin.GetListTeacherOfSubjectFormLich(IdMonHoc);
        }
        public bool ThemLichHoc(DTO_CBDT_LICHHOC LICH, out string message)
        {
            return QlThongTin.InsertLichHoc(LICH, out message);
        }
        public bool SuaLichHoc(DTO_CBDT_LICHHOC LICH, out string message)
        {
            return QlThongTin.UpdateLichHoc(LICH, out message);
        }

        //Kỳ học
        public DataTable LoadDsKyHoc()
        {
            return QlThongTin.GetListKyHoc();
        }
        public DataTable LoadDsKyHocMonHoc()
        {
            return QlThongTin.GetListKyHocMonHoc();
        }
        public DataTable LoadDsKyHocFormChiDinhMonHoc()
        {
            return QlThongTin.GetListKyHocFormChiDinhMonHoc();
        }
        public DataTable LoadDsMHFormChiDinhMonHoc(int IDKyHoc)
        {
            return QlThongTin.GetListMHFormChiDinhMonhoc(IDKyHoc);
        }
        public bool ThemKyHoc(DTO_CBDT_KYHOC KyHoc, out string message)
        {
            return QlThongTin.InsertKyHoc(KyHoc, out message);
        }
        public bool ThemChiDinhMHtoKyHoc(int IDKyHoc, int IDMonHoc, bool trangthai, out string message)
        {
            return QlThongTin.InsertChiDinhMHtoKyHoc(IDKyHoc, IDMonHoc, trangthai, out message);
        }
        public bool SuaKyHoc(DTO_CBDT_KYHOC KyHoc, out string message)
        {
            return QlThongTin.UpdateKyHoc(KyHoc, out message);
        }
        public bool SuaChiDinhMHtoKyHoc(int IDKyHoc, out string message)
        {
            return QlThongTin.UpdateChiDinhMHtoKyHoc(IDKyHoc, out message);
        }
        public bool SudungKyHoc(DTO_CBDT_KYHOC KyHoc, out string message)
        {
            return QlThongTin.UseKyHoc(KyHoc, out message);
        }
        public bool KhoaOrMoKhoaMonHoc(int IDKyHoc, int IDMonHoc, out string message)
        {
            return QlThongTin.LockOrUnlockMonHoc(IDKyHoc, IDMonHoc, out message);
        }

        //Môn học
        public DataTable LoadDsMonHocFormMonHoc()
        {
            return QlThongTin.GetListmonHoc();
        }
        public bool ThemMonHoc(DTO_CBDT_MONHOC MonHOC, out string message)
        {
            return QlThongTin.InsertMonHoc(MonHOC, out message);
        }
        public bool SuaMonHoc(DTO_CBDT_MONHOC MonHOC, out string message)
        {
            return QlThongTin.UpdateMonHoc(MonHOC, out message);
        }

        //Form phân việc
        public DataTable LoadDsMonHocGV()
        {
            return QlThongTin.GetListMonHocGV();
        }
        public DataTable LoadDsMonHocFormChiDinhGV()
        {
            return QlThongTin.GetListMonHocFormChiDinhGV();
        }
        public DataTable LoadDsGVFormChiDinhGV(int IDMonHoc)
        {
            return QlThongTin.GetListGVFormChiDinhGV(IDMonHoc);
        }
        public DateTime? LayNamBatDauKyHoc()
        {
            return QlThongTin.GetNamBatDauKyHoc();
        }
        public bool ThemChiDinhGVtoMonHoc(int IDKyhoc, int IDMonHoc, string IDGV, DateTime Ngaychot, out string message)
        {
            return QlThongTin.InsertChiDinhGVtoMonHoc(IDKyhoc, IDMonHoc, IDGV, Ngaychot, out message);
        }
        public bool SuaChiDinhGVtoMonHoc(int IDMonHoc, out string message)
        {
            return QlThongTin.UpdateChiDinhGVtoMonHoc(IDMonHoc, out message);
        }
    }
}
