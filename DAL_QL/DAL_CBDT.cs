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
            string query = "SELECT COUNT(*) FROM STUDENTS WHERE MASV = @MASV";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MASV", maHs);
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
        public bool InsertStudent(DTO_CBDT_SV SinhVien)
        {
            string insertQuery = "INSERT INTO STUDENTS (MASV, TenSV, IDLop, Email, SoDT, Gioitinh, Diachi, Hinh) VALUES (@MASV, @TenSV, @IDLop, @Email, @SoDT, @Gioitinh, @Diachi, @Hinh)";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@MASV", SinhVien._MaSV);
                        cmd.Parameters.AddWithValue("@TenSV", SinhVien._TenSV);
                        cmd.Parameters.AddWithValue("@IDLop", SinhVien._MaLop);
                        cmd.Parameters.AddWithValue("@Email", SinhVien._Email);
                        cmd.Parameters.AddWithValue("@SoDT", SinhVien._SoDT);
                        cmd.Parameters.AddWithValue("@Gioitinh", SinhVien._Gioitinh ? 1 : 0);
                        cmd.Parameters.AddWithValue("@Diachi", SinhVien._Diachi);
                        cmd.Parameters.AddWithValue("@Hinh", SinhVien._Hinh);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public bool UpdateStudent(DTO_CBDT_SV SinhVien)
        {
            string updateQuery = "UPDATE STUDENTS SET TenSV = @TenSV, IDLop = @Malop, Email = @Email, SoDT = @SoDT, Gioitinh = @Gioitinh, Diachi = @Diachi, Hinh = @Hinh WHERE MASV = @MASV";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@MASV", SinhVien._MaSV);
                        cmd.Parameters.AddWithValue("@TenSV", SinhVien._TenSV);
                        cmd.Parameters.AddWithValue("@IDLop", SinhVien._MaLop);
                        cmd.Parameters.AddWithValue("@Email", SinhVien._Email);
                        cmd.Parameters.AddWithValue("@SoDT", SinhVien._SoDT);
                        cmd.Parameters.AddWithValue("@Gioitinh", SinhVien._Gioitinh ? 1 : 0);
                        cmd.Parameters.AddWithValue("@Diachi", SinhVien._Diachi);
                        cmd.Parameters.AddWithValue("@Hinh", SinhVien._Hinh);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool DeleteStudent(string maSV)
        {
            string deleteQuery = "DELETE FROM STUDENTS WHERE MASV = @MASV";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@MASV", maSV);
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
            string query = "SELECT c.IDLop, c.ClassName, COUNT(s.IDSV) AS SiSo, ISNULL(t.TenGV, N'Không có GVCN') AS TenGiaoVien, CASE WHEN c.Trangthai = 1 THEN N'Khóa' ELSE N'Đang sử dụng' END AS TrangThai FROM CLASSES c LEFT JOIN STUDENTS s ON c.IDLop = s.IDLop LEFT JOIN TEACHERS t ON c.MaGV = t.MaGV GROUP BY c.IDLop, c.ClassName, t.TenGV, c.Trangthai;";
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
            string query = "SELECT T.MaGV, T.TenGV FROM TEACHERS T LEFT JOIN CLASSES C ON T.MaGV = C.MaGV WHERE C.MaGV IS NULL AND T.IdAcc IS NOT NULL";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);

                DataRow emptyRow = dataTable.NewRow();
                emptyRow["MaGV"] = DBNull.Value;
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
            string query = "SELECT MaGV FROM CLASSES WHERE IDLop = @IDLop";
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

        public bool InsertClass(DTO_CBDT_CLASS lop)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string insertQuery = "INSERT INTO CLASSES (IDLop, ClassName, MaGV) VALUES (@IDLop, @ClassName, @MaGV)";
                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@IDLop", lop._MaLop);
                    cmd.Parameters.AddWithValue("@ClassName", lop._ClassName);
                    cmd.Parameters.AddWithValue("@MaGV", string.IsNullOrEmpty(lop._MaGV) ? (object)DBNull.Value : lop._MaGV);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool UpdateClass(DTO_CBDT_CLASS lop)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string updateQuery = "UPDATE CLASSES SET ClassName = @ClassName, MaGV = @MaGV WHERE IDLop = @IDLop";
                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@IDLop", lop._MaLop);
                    cmd.Parameters.AddWithValue("@ClassName", lop._ClassName);
                    cmd.Parameters.AddWithValue("@MaGV", string.IsNullOrEmpty(lop._MaGV) ? (object)DBNull.Value : lop._MaGV);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
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
            string query = "SELECT T.MaGV, T.TenGV, T.IdAcc, T.Email, T.SoDT, CASE WHEN T.Gioitinh = 1 THEN 'Nam' ELSE N'Nữ' END AS Gioitinh, T.Diachi, T.Hinh, ISNULL(C.IDLop, N'Chưa có lớp') AS Lop FROM TEACHERS T LEFT JOIN CLASSES C ON T.MaGV = C.MaGV";
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
            string query = "SELECT COUNT(*) FROM TEACHERS WHERE MaGV = @MaGV";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaGV", maGV);
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
        public bool KtTKDaChiDinh(string MaGV)
        {
            string query = "SELECT IdAcc FROM TEACHERS WHERE MaGV = @MaGV";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaGV", MaGV);
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
        public bool InsertTeacher(DTO_CBDT_GV GiaoVien)
        {
            try
            {
                string insertQuery = "INSERT INTO TEACHERS (MaGV, TenGV, Email, SoDT, Gioitinh, Diachi, Hinh) VALUES (@MaGV, @TenGV, @Email, @SoDT, @Gioitinh, @Diachi, @Hinh)";
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaGV", GiaoVien._MaGV);
                        cmd.Parameters.AddWithValue("@TenGV", GiaoVien._TenGV);
                        cmd.Parameters.AddWithValue("@Email", GiaoVien._Email);
                        cmd.Parameters.AddWithValue("@SoDT", GiaoVien._SoDT);
                        cmd.Parameters.AddWithValue("@Gioitinh", GiaoVien._Gioitinh ? 1 : 0);
                        cmd.Parameters.AddWithValue("@Diachi", GiaoVien._Diachi);
                        cmd.Parameters.AddWithValue("@Hinh", GiaoVien._Hinh);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdateTeacher(DTO_CBDT_GV GiaoVien)
        {
            try
            {
                string updateQuery = "UPDATE TEACHERS SET TenGV = @TenGV, Email = @Email, SoDT = @SoDT, Gioitinh = @Gioitinh, Diachi = @Diachi, Hinh = @Hinh WHERE MaGV = @MaGV";
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaGV", GiaoVien._MaGV);
                        cmd.Parameters.AddWithValue("@TenGV", GiaoVien._TenGV);
                        cmd.Parameters.AddWithValue("@Email", GiaoVien._Email);
                        cmd.Parameters.AddWithValue("@SoDT", GiaoVien._SoDT);
                        cmd.Parameters.AddWithValue("@Gioitinh", GiaoVien._Gioitinh ? 1 : 0);
                        cmd.Parameters.AddWithValue("@Diachi", GiaoVien._Diachi);
                        cmd.Parameters.AddWithValue("@Hinh", GiaoVien._Hinh);

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
        public bool DeleteTeacher(string magv)
        {
            try
            {
                string deleteQuery = "DELETE FROM TEACHERS WHERE MaGV = @MaGV";
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaGV", magv);

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

            string query = "SELECT MaGV FROM TEACHERS WHERE MaGV LIKE @prefix + '%'";
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
                            string id = reader["MaGV"].ToString();
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
