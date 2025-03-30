using DTO_QL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QL
{
    public class DAL_GV : DbConnect
    {
        //Tất cả Form đều dùng
        public string GetMaLop(string taikhoan)
        {
            string query = @"SELECT C.IDLop FROM CLASSES C 
                            JOIN Class_Teacher CT ON C.IDLop = CT.IDLop 
                            JOIN TEACHERS T ON CT.IDGV = T.IDGV 
                            JOIN ACCOUNTS A ON T.IdAcc = A.IdAcc 
                            WHERE A.Username = @Username";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", taikhoan);
                    return cmd.ExecuteScalar()?.ToString();
                }
            }
        }

        //Form danh sách hiển thị
        public DataTable GetData(string query, string Malop)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IDLop", Malop);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    return dt;
                }
            }
        }

        //Form Quản Lý Điểm
        public DataTable GetListStudent(string Malop, string IdGv)
        {
            string query = @"SELECT SV.IDSV, SV.TenSV, MH.TenMon, 
                            COALESCE(CAST(GD.Diem AS NVARCHAR), N'Chưa nhập') AS Diem 
                            FROM STUDENTS SV
                            INNER JOIN MonHoc_GiangVien MG ON MG.IDGV = @IDGV
                            INNER JOIN MonHoc MH ON MH.IDMonHoc = MG.IDMonHoc
                            LEFT JOIN Diem GD ON SV.IDSV = GD.IDSV AND GD.IDMonHoc = MG.IDMonHoc
                            WHERE SV.IDLop = @IDLop";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IDLop", Malop);
                    cmd.Parameters.AddWithValue("@IDGV", IdGv);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);

                    return dt;
                }
            }
        }
        public DataTable GetStudentsByPage(string Malop, string IdGv, int offset, int pageSize)
        {
            DataTable dt = new DataTable();
            string query = "SELECT SV.IDSV, SV.TenSV, MH.TenMon, " +
                           "COALESCE(CAST(GD.Diem AS NVARCHAR), N'Chưa nhập') AS Diem " +
                           "FROM STUDENTS SV " +
                           "LEFT JOIN Diem GD ON SV.IDSV = GD.IDSV AND GD.IDMonHoc = (SELECT IDMonHoc FROM MonHoc_GiangVien WHERE IDGV = @IDGV) " +
                           "LEFT JOIN MonHoc MH ON MH.IDMonHoc = (SELECT IDMonHoc FROM MonHoc_GiangVien WHERE IDGV = @IDGV) " +
                           "WHERE SV.IDLop = @IDLop " +
                           "ORDER BY SV.IDSV ASC " +
                           "OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IDLop", Malop);
                    cmd.Parameters.AddWithValue("@IDGV", IdGv);
                    cmd.Parameters.AddWithValue("@Offset", offset);
                    cmd.Parameters.AddWithValue("@PageSize", pageSize);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }
        public string GetIdGvFromIdAcc(string Idacc)
        {
            string query = "SELECT IDGV FROM TEACHERS WHERE IDAcc = @IDAcc";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IDAcc", Idacc);
                    return cmd.ExecuteScalar()?.ToString();
                }
            }
        }
        public int GetIdMonhocFromIdGv(string IdGv)
        {
            string query = "SELECT IDMonHoc FROM MonHoc_GiangVien WHERE IDGV = @IDGV";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IDGV", IdGv);
                    return (int)cmd.ExecuteScalar();
                }
            }
        }
        public int GetTotalStudent(string Malop)
        {
            string query = "SELECT COUNT(*) FROM STUDENTS WHERE IDLop = @IDLop";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IDLop", (object)Malop ?? DBNull.Value);
                    return (int)cmd.ExecuteScalar();
                }
            }
        }
        public bool KtSvDaCoDiemChua(string maHs)
        {
            string query = "SELECT COUNT(*) FROM Diem WHERE IDSV = @IDSV";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IDSV", maHs);
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
        }
        public DataTable SearchByID(string maLop, string maGV, string maSV)
        {
            DataTable dtSinhVien = new DataTable();
            string query = "SELECT SV.IDSV, SV.TenSV, MH.TenMon, " +
                            "COALESCE(CAST(GD.Diem AS NVARCHAR), N'Chưa nhập') AS Diem " +
                            "FROM STUDENTS SV " +
                            "LEFT JOIN Diem GD ON SV.IDSV = GD.IDSV AND GD.IDMonHoc IN (SELECT IDMonHoc FROM MonHoc_GiangVien WHERE IDGV = @IDGV) " +
                            "LEFT JOIN MonHoc MH ON MH.IDMonHoc IN (SELECT IDMonHoc FROM MonHoc_GiangVien WHERE IDGV = @IDGV) " +
                            "WHERE SV.IDLop = @IDLop AND SV.IDSV LIKE @IDSV";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IDLop", maLop);
                    cmd.Parameters.AddWithValue("@IDGV", maGV);
                    cmd.Parameters.AddWithValue("@IDSV", "%" + maSV + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtSinhVien);
                }
            }
            return dtSinhVien;
        }
        public bool InsertGrade(DTO_GV DiemSV, out string message)
        {
            string query = "INSERT INTO Diem (IDKyHoc, IDSV, IDMonHoc, Diem) VALUES (@IDKyHoc, @IDSV, @IDMonHoc, @Diem)";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IDKyHoc", DiemSV._IDKyHoc);
                        cmd.Parameters.AddWithValue("@IDSV", DiemSV._MaSV);
                        cmd.Parameters.AddWithValue("@IDMonHoc", DiemSV._IDMonHoc);
                        cmd.Parameters.AddWithValue("@Diem", DiemSV._Diem);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            message = "Thông tin học sinh đã được lưu thành công!";
                            return true;
                        }
                        else
                        {
                            message = "Không thể thêm điểm!";
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    message = "Lỗi: " + ex.Message;
                    return false;
                }
            }
        }
        public bool UpdateGrade(DTO_GV DiemSV, out string message)
        {
            string query = "UPDATE Diem SET Diem = @Diem WHERE IDKyHoc = @IDKyHoc AND IDSV = @IDSV AND IDMonHoc = @IDMonHoc";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IDKyHoc", DiemSV._IDKyHoc);
                        cmd.Parameters.AddWithValue("@IDSV", DiemSV._MaSV);
                        cmd.Parameters.AddWithValue("@IDMonHoc", DiemSV._IDMonHoc);
                        cmd.Parameters.AddWithValue("@Diem", DiemSV._Diem);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            message = "Điểm học sinh đã được cập nhật thành công!";
                            return true;
                        }
                        else
                        {
                            message = "Không thể cập nhật điểm!";
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    message = "Lỗi: " + ex.Message;
                    return false;
                }
            }
        }
        public bool DeleteGrade(DTO_GV DiemSV, out string message)
        {
            string Deletequery = "DELETE FROM Diem WHERE IDKyHoc = @IDKyHoc AND IDSV = @IDSV AND IDMonHoc = @IDMonHoc";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(Deletequery, conn))
                    {
                        cmd.Parameters.AddWithValue("@IDKyHoc", DiemSV._IDKyHoc);
                        cmd.Parameters.AddWithValue("@IDSV", DiemSV._MaSV);
                        cmd.Parameters.AddWithValue("@IDMonHoc", DiemSV._IDMonHoc);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            message = "Điểm học sinh đã được xóa thành công!";
                            return true;
                        }
                        else
                        {
                            message = "Không thể xóa điểm!";
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    message = "Lỗi: " + ex.Message;
                    return false;
                }
            }
        }

        //Form Điểm danh
        public DataTable GetListSinhVienDiemDanh(string IDLop, int lichhoc, DateTime ngaydiemdanh)
        {
            string query = @"SELECT SV.IDSV, SV.TenSV, DD.TrangThai, ISNULL(DD.GhiChu, '') AS GhiChu FROM STUDENTS SV
                            LEFT JOIN DIEMDANH DD ON SV.IDSV = DD.IDSV AND DD.IDLichHoc = @IDLichHoc AND DD.ThoiGianDiemDanh = @ThoiGianDiemDanh
                            WHERE SV.IDLop = @IDLop ORDER BY SV.IDSV";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IDLichHoc", lichhoc);
                    cmd.Parameters.AddWithValue("@IDLop", IDLop);
                    cmd.Parameters.AddWithValue("@ThoiGianDiemDanh", ngaydiemdanh);

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        conn.Open();
                        dataAdapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }
        public DataTable GetListClassOfTeacher(string IDGV)
        {
            string query = @"SELECT C.IDLop, C.ClassName 
                            FROM CLASSES C
                            JOIN Class_Teacher CT ON C.IDLop = CT.IDLop
                            JOIN KyHoc KH ON CT.IDKyHoc = KH.IDKyHoc
                            WHERE CT.IDGV = @IDGV AND KH.Trangthai = 1";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IDGV", IDGV);

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        conn.Open();
                        dataAdapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }
        public DataTable GetListSubjectOfTeacher(string IDGV, string IDLop)
        {
            string query = @"SELECT MH.IDMonHoc, MH.TenMon
                            FROM MonHoc MH
                            JOIN MonHoc_GiangVien MG ON MH.IDMonHoc = MG.IDMonHoc
                            JOIN Class_Teacher CT ON MG.IDGV = CT.IDGV AND MG.IDKyHoc = CT.IDKyHoc
                            JOIN KyHoc KH ON CT.IDKyHoc = KH.IDKyHoc
                            WHERE MG.IDGV = @IDGV AND CT.IDLop = @IDLop AND KH.Trangthai = 1";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IDGV", IDGV);
                    cmd.Parameters.AddWithValue("@IDLop", IDLop);

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        conn.Open();
                        dataAdapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }
        public int GetIDLichHoc(string IDLop, int IDmonhoc, string IDGV, int idkyhoc)
        {
            string query = @"SELECT IDLichHoc FROM LichHoc WHERE IDLop = @IDLop AND IDMonHoc = @IDMonHoc AND IDGV = @IDGV AND IDKyHoc = @IDKyHoc";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IDLop", IDLop);
                    cmd.Parameters.AddWithValue("@IDMonHoc", IDmonhoc);
                    cmd.Parameters.AddWithValue("@IDGV", IDGV);
                    cmd.Parameters.AddWithValue("@IDKyHoc", idkyhoc);

                    object result = cmd.ExecuteScalar();

                    return (result != null) ? Convert.ToInt32(result) : -1;
                }
            }
        }
        public DateTime? GetNgayDiemdanh(int IDLichHoc)
        {
            string query = @"SELECT TOP 1 Ngay
                            FROM LichHoc
                            WHERE IDLichHoc = @IDLichHoc";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@IDLichHoc", IDLichHoc);

                conn.Open();
                object result = cmd.ExecuteScalar();

                return (result != null && result != DBNull.Value) ? Convert.ToDateTime(result) : (DateTime?)null;
            }
        }
    }
}
