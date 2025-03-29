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
            string query = @"SELECT C.IDLop FROM CLASSES C INNER JOIN TEACHERS T ON C.IDGV = T.IDGV INNER JOIN ACCOUNTS A ON T.IdAcc = A.IdAcc WHERE A.Username = @Username";
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
        public string GetIdMonhocFromIdGv(string IdGv)
        {
            string query = "SELECT IDMonHoc FROM MonHoc_GiangVien WHERE IDGV = @IDGV";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IDGV", IdGv);
                    return cmd.ExecuteScalar()?.ToString();
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
                            "LEFT JOIN Diem GD ON SV.IDSV = GD.IDSV AND GD.IDMonHoc = (SELECT IDMonHoc FROM MonHoc_GiangVien WHERE IDGV = @IDGV) " +
                            "LEFT JOIN MonHoc MH ON MH.IDMonHoc = (SELECT IDMonHoc FROM MonHoc_GiangVien WHERE IDGV = @IDGV) " +
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
            string query = "INSERT INTO Diem (IDSV, IDMonHoc, Diem) VALUES (@IDSV, @IDMonHoc, @Diem)";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
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
            string query = "UPDATE Diem SET Diem = @Diem WHERE IDSV = @IDSV AND IDMonHoc = @IDMonHoc";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
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
            string Deletequery = "DELETE FROM Diem WHERE IDSV = @IDSV AND IDMonHoc = @IDMonHoc";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(Deletequery, conn))
                    {
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
    }
}
