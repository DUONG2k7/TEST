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
    public class DAL_CBDT : DbConnect
    {
        //Sinh Viên
        public DataTable GetListStudent()
        {
            string query = "SELECT CL.IDLop, SV.IDSV, SV.TenSV, CL.ClassName, SV.Email, SV.SoDT, CASE WHEN SV.Gioitinh = 1 THEN 'Nam' ELSE N'Nữ' END AS Gioitinh, SV.Diachi, SV.Hinh FROM STUDENTS SV JOIN CLASSES CL ON SV.IDLop = CL.IDLop";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                DataTable dt = new DataTable();
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
        public DataTable GetListClassFromStudent()
        {
            string query = "SELECT IDLop, ClassName FROM CLASSES";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);

                return dataTable;
            }
        }
        public int checkStatusClass(string IDLop)
        {
            string query = "SELECT Trangthai FROM CLASSES WHERE IDLop = @IDLop";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IDLop", IDLop);
                        object result = cmd.ExecuteScalar();
                        return result != null ? Convert.ToInt32(result) : -1;
                    }
                }
                catch (Exception)
                {
                    return -1;
                }
            }
        }
        public bool KtSvDaTonTai(string maHs)
        {
            string query = "SELECT COUNT(*) FROM STUDENTS WHERE IDSV = @IDSV";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IDSV", maHs);
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public bool KiemTraSVDaCoDiemChua(string maSV)
        {
            string query = "SELECT COUNT(*) FROM GRADE WHERE IDSV = @IDSV";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IDSV", maSV);
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public bool InsertStudent(DTO_CBDT_SV SinhVien, out string message)
        {
            string insertQuery = "INSERT INTO STUDENTS (IDSV, TenSV, IDLop, Email, SoDT, Gioitinh, Diachi, Hinh) VALUES (@IDSV, @TenSV, @IDLop, @Email, @SoDT, @Gioitinh, @Diachi, @Hinh)";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@IDSV", SinhVien._MaSV);
                        cmd.Parameters.AddWithValue("@TenSV", SinhVien._TenSV);
                        cmd.Parameters.AddWithValue("@IDLop", SinhVien._MaLop);
                        cmd.Parameters.AddWithValue("@Email", SinhVien._Email);
                        cmd.Parameters.AddWithValue("@SoDT", SinhVien._SoDT);
                        cmd.Parameters.AddWithValue("@Gioitinh", SinhVien._Gioitinh ? 1 : 0);
                        cmd.Parameters.AddWithValue("@Diachi", SinhVien._Diachi);
                        cmd.Parameters.AddWithValue("@Hinh", SinhVien._Hinh);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            message = "Thông tin sinh viên đã được lưu thành công!";
                            return true;
                        }
                        else
                        {
                            message = "Không có dữ liệu nào được thêm.";
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    message = "Lỗi khi thêm sinh viên: " + ex.Message;
                    return false;
                }
            }
        }
        public bool UpdateStudent(DTO_CBDT_SV SinhVien, out string message)
        {
            string updateQuery = "UPDATE STUDENTS SET TenSV = @TenSV, IDLop = @IDLop, Email = @Email, SoDT = @SoDT, Gioitinh = @Gioitinh, Diachi = @Diachi, Hinh = @Hinh WHERE IDSV = @IDSV";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@IDSV", SinhVien._MaSV);
                        cmd.Parameters.AddWithValue("@TenSV", SinhVien._TenSV);
                        cmd.Parameters.AddWithValue("@IDLop", SinhVien._MaLop);
                        cmd.Parameters.AddWithValue("@Email", SinhVien._Email);
                        cmd.Parameters.AddWithValue("@SoDT", SinhVien._SoDT);
                        cmd.Parameters.AddWithValue("@Gioitinh", SinhVien._Gioitinh ? 1 : 0);
                        cmd.Parameters.AddWithValue("@Diachi", SinhVien._Diachi);
                        cmd.Parameters.AddWithValue("@Hinh", SinhVien._Hinh);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            message = "Thông tin sinh viên đã được cập nhật thành công!";
                            return true;
                        }
                        else
                        {
                            message = "Không có sinh viên nào được cập nhật.";
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    message = "Lỗi khi cập nhật sinh viên: " + ex.Message;
                    return false;
                }
            }
        }

        public bool DeleteStudent(string maSV)
        {
            string deleteQuery = "DELETE FROM STUDENTS WHERE IDSV = @IDSV";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@IDSV", maSV);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public string CreateNewStudentId(string prefix)
        {
            List<int> numbers = new List<int>();

            string query = "SELECT IDSV FROM STUDENTS WHERE IDSV LIKE @prefix + '%'";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@prefix", prefix);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string id = reader["IDSV"].ToString();
                            if (id.Length > prefix.Length)
                            {
                                string numberPart = id.Substring(prefix.Length);
                                if (int.TryParse(numberPart, out int num))
                                {
                                    numbers.Add(num);
                                }
                            }
                        }
                    }
                }
            }

            numbers.Sort();
            int nextNumber = 1;
            foreach (int num in numbers)
            {
                if (num == nextNumber)
                {
                    nextNumber++;
                }
                else if (num > nextNumber)
                {
                    break;
                }
            }

            return prefix + nextNumber.ToString("D" + Math.Max(2, nextNumber.ToString().Length));
        }

        //Class
        public DataTable GetListClass()
        {
            string query = "SELECT c.IDLop, c.ClassName, COUNT(s.IDSV) AS SiSo, ISNULL(t.TenGV, N'Không có GVCN') AS TenGiaoVien, CASE WHEN c.Trangthai = 1 THEN N'Khóa' ELSE N'Đang sử dụng' END AS TrangThai FROM CLASSES c LEFT JOIN STUDENTS s ON c.IDLop = s.IDLop LEFT JOIN TEACHERS t ON c.IDGV = t.IDGV GROUP BY c.IDLop, c.ClassName, t.TenGV, c.Trangthai;";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                DataTable dt = new DataTable();
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
        public DataTable GetListTeacherFromClass()
        {
            string query = "SELECT T.IDGV, T.TenGV FROM TEACHERS T LEFT JOIN CLASSES C ON T.IDGV = C.IDGV WHERE C.IDGV IS NULL AND T.IdAcc IS NOT NULL";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);

                DataRow emptyRow = dataTable.NewRow();
                emptyRow["IDGV"] = DBNull.Value;
                emptyRow["TenGV"] = "Không chỉ định";
                dataTable.Rows.InsertAt(emptyRow, 0);

                return dataTable;
            }
        }
        public bool KtLopDaTonTai(string maLop)
        {
            string query = "SELECT COUNT(*) FROM CLASSES WHERE IDLop = @IDLop";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IDLop", maLop);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            return (int)result > 0;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public bool KtGVDaChiDinh(string maLop)
        {
            string query = "SELECT IDGV FROM CLASSES WHERE IDLop = @IDLop";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IDLop", maLop);
                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            string maGV = result.ToString().Trim();
                            return !string.IsNullOrEmpty(maGV);
                        }
                        return false;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool InsertClass(DTO_CBDT_CLASS lop, out string message)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    string insertQuery = "INSERT INTO CLASSES (IDLop, ClassName, IDGV) VALUES (@IDLop, @ClassName, @IDGV)";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@IDLop", lop._MaLop);
                        cmd.Parameters.AddWithValue("@ClassName", lop._ClassName);
                        cmd.Parameters.AddWithValue("@IDGV", string.IsNullOrEmpty(lop._MaGV) ? (object)DBNull.Value : lop._MaGV);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            message = "Thông tin lớp đã được lưu thành công!";
                            return true;
                        }
                        else
                        {
                            message = "Không có dữ liệu nào được thêm.";
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    message = "Lỗi khi thêm lớp học: " + ex.Message;
                    return false;
                }
            }
        }

        public bool UpdateClass(DTO_CBDT_CLASS lop, out string message)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    string updateQuery = "UPDATE CLASSES SET ClassName = @ClassName, IDGV = @IDGV WHERE IDLop = @IDLop";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@IDLop", lop._MaLop);
                        cmd.Parameters.AddWithValue("@ClassName", lop._ClassName);
                        cmd.Parameters.AddWithValue("@IDGV", string.IsNullOrEmpty(lop._MaGV) ? (object)DBNull.Value : lop._MaGV);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            message = "Thông tin lớp đã được cập nhật thành công!";
                            return true;
                        }
                        else
                        {
                            message = "Không có lớp học nào được cập nhật.";
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    message = "Lỗi khi cập nhật lớp học: " + ex.Message;
                    return false;
                }
            }
        }

        public bool DeleteClass(string maLop)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string updateStudentsQuery = "UPDATE STUDENTS SET IDLop = 'L00' WHERE IDLop = @IDLop";
                    using (SqlCommand cmd1 = new SqlCommand(updateStudentsQuery, conn, transaction))
                    {
                        cmd1.Parameters.AddWithValue("@IDLop", maLop);
                        cmd1.ExecuteNonQuery();
                    }

                    string deleteClassQuery = "DELETE FROM CLASSES WHERE IDLop = @IDLop";
                    using (SqlCommand cmd2 = new SqlCommand(deleteClassQuery, conn, transaction))
                    {
                        cmd2.Parameters.AddWithValue("@IDLop", maLop);
                        int rowsAffected = cmd2.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            transaction.Commit();
                            return true;
                        }
                        else
                        {
                            transaction.Rollback();
                            return false;
                        }
                    }
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }
        public bool LockOrUnlockClass(string maLop)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string updateQuery = "UPDATE CLASSES SET Trangthai = CASE WHEN Trangthai = 1 THEN 0 ELSE 1 END WHERE IDLop = @IDLop;";
                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@IDLop", maLop);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public string CreateNewClassId(string prefix)
        {
            List<int> numbers = new List<int>();

            string query = "SELECT IDLop FROM CLASSES WHERE IDLop LIKE @prefix + '%'";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@prefix", prefix);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string id = reader["IDLop"].ToString();
                            if (id.Length > prefix.Length)
                            {
                                string numberPart = id.Substring(prefix.Length);
                                if (int.TryParse(numberPart, out int num))
                                {
                                    numbers.Add(num);
                                }
                            }
                        }
                    }
                }
            }

            numbers.Sort();
            int nextNumber = 1;
            foreach (int num in numbers)
            {
                if (num == nextNumber)
                {
                    nextNumber++;
                }
                else if (num > nextNumber)
                {
                    break;
                }
            }

            return prefix + nextNumber.ToString("D" + Math.Max(2, nextNumber.ToString().Length));
        }

        //Giáo viên

        public DataTable GetListTeacher()
        {
            string query = "SELECT T.IDGV, T.TenGV, T.IdAcc, T.Email, T.SoDT, CASE WHEN T.Gioitinh = 1 THEN 'Nam' ELSE N'Nữ' END AS Gioitinh, T.Diachi, T.Hinh, ISNULL(C.IDLop, N'Chưa có lớp') AS Lop FROM TEACHERS T LEFT JOIN CLASSES C ON T.IDGV = C.IDGV";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                DataTable dt = new DataTable();
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
        public bool KtGvDaTonTai(string maGV)
        {
            string query = "SELECT COUNT(*) FROM TEACHERS WHERE IDGV = @IDGV";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IDGV", maGV);
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public bool KtTKDaChiDinh(string IDGV)
        {
            string query = "SELECT IdAcc FROM TEACHERS WHERE IDGV = @IDGV";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IDGV", IDGV);
                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            string IdAcc = result.ToString().Trim();
                            return !string.IsNullOrEmpty(IdAcc);
                        }
                        return false;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public bool InsertTeacher(DTO_CBDT_GV GiaoVien, out string message)
        {
            try
            {
                string insertQuery = "INSERT INTO TEACHERS (IDGV, TenGV, Email, SoDT, Gioitinh, Diachi, Hinh) VALUES (@IDGV, @TenGV, @Email, @SoDT, @Gioitinh, @Diachi, @Hinh)";
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@IDGV", GiaoVien._MaGV);
                        cmd.Parameters.AddWithValue("@TenGV", GiaoVien._TenGV);
                        cmd.Parameters.AddWithValue("@Email", GiaoVien._Email);
                        cmd.Parameters.AddWithValue("@SoDT", GiaoVien._SoDT);
                        cmd.Parameters.AddWithValue("@Gioitinh", GiaoVien._Gioitinh ? 1 : 0);
                        cmd.Parameters.AddWithValue("@Diachi", GiaoVien._Diachi);
                        cmd.Parameters.AddWithValue("@Hinh", GiaoVien._Hinh);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            message = "Thông tin giảng viên đã được lưu thành công!";
                            return true;
                        }
                        else
                        {
                            message = "Không có dữ liệu nào được thêm.";
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                message = "Lỗi khi thêm giảng viên: " + ex.Message;
                return false;
            }
        }
        public bool UpdateTeacher(DTO_CBDT_GV GiaoVien, out string message)
        {
            try
            {
                string updateQuery = "UPDATE TEACHERS SET TenGV = @TenGV, Email = @Email, SoDT = @SoDT, Gioitinh = @Gioitinh, Diachi = @Diachi, Hinh = @Hinh WHERE IDGV = @IDGV";
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@IDGV", GiaoVien._MaGV);
                        cmd.Parameters.AddWithValue("@TenGV", GiaoVien._TenGV);
                        cmd.Parameters.AddWithValue("@Email", GiaoVien._Email);
                        cmd.Parameters.AddWithValue("@SoDT", GiaoVien._SoDT);
                        cmd.Parameters.AddWithValue("@Gioitinh", GiaoVien._Gioitinh ? 1 : 0);
                        cmd.Parameters.AddWithValue("@Diachi", GiaoVien._Diachi);
                        cmd.Parameters.AddWithValue("@Hinh", GiaoVien._Hinh);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            message = "Thông tin giảng viên đã được cập nhật thành công!";
                            return true;
                        }
                        else
                        {
                            message = "Không có giảng viên nào được cập nhật.";
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                message = "Lỗi khi cập nhật giảng viên: " + ex.Message;
                return false;
            }
        }
        public bool DeleteTeacher(string magv)
        {
            try
            {
                string deleteQuery = "DELETE FROM TEACHERS WHERE IDGV = @IDGV";
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@IDGV", magv);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        //prefix là tiền tố cho id
        //ví dụ: A001 --> A + 001 || A là tiền tố
        public string CreateNewTeacherId(string prefix)
        {
            List<int> numbers = new List<int>();

            string query = "SELECT IDGV FROM TEACHERS WHERE IDGV LIKE @prefix + '%'";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@prefix", prefix);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string id = reader["IDGV"].ToString();
                            if (id.Length > prefix.Length)
                            {
                                string numberPart = id.Substring(prefix.Length);
                                if (int.TryParse(numberPart, out int num))
                                {
                                    numbers.Add(num);
                                }
                            }
                        }
                    }
                }
            }

            numbers.Sort();
            int nextNumber = 1;
            foreach (int num in numbers)
            {
                if (num == nextNumber)
                {
                    nextNumber++;
                }
                else if (num > nextNumber)
                {
                    break;
                }
            }

            return prefix + nextNumber.ToString("D" + Math.Max(2, nextNumber.ToString().Length));
        }
    }
}
