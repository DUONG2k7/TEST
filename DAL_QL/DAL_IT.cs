using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using DTO_QL;

namespace DAL_QL
{
    public class DAL_IT : DbConnect
    {
        public static string GetSha256Hash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha256.ComputeHash(inputBytes);
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }
        public bool KtSlRoleAdmin(string idAcc)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string checkQuery = @"SELECT COUNT(*) FROM ACCOUNTS WHERE IDRole = 'R01' AND Trangthai = 0";

                using (SqlCommand cmd = new SqlCommand(checkQuery, conn))
                {
                    int countAdmin = (int)cmd.ExecuteScalar();

                    if (countAdmin == 1)
                    {
                        string checkCurrentQuery = "SELECT IDRole FROM ACCOUNTS WHERE IdAcc = @IdAcc";
                        using (SqlCommand cmdCheck = new SqlCommand(checkCurrentQuery, conn))
                        {
                            cmdCheck.Parameters.AddWithValue("@IdAcc", idAcc);
                            object result = cmdCheck.ExecuteScalar();
                            if (result != null && result.ToString() == "R01")
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }
        public bool KtTkDaTonTai(string maTk)
        {
            string query = "SELECT COUNT(*) FROM ACCOUNTS WHERE IdAcc = @IdAcc";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdAcc", maTk);
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
        public bool KtTkDaCapGvChua(string IdAcc)
        {
            string query = "SELECT COUNT(*) FROM TEACHERS WHERE IdAcc = @IdAcc";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdAcc", IdAcc);
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
        public DataTable GetListAccountIT()
        {
            string query = "SELECT R.IDRole, A.IdAcc, A.Username, R.Role, CASE WHEN A.Trangthai = 1 THEN N'Khóa' ELSE N'Đang sử dụng' END AS TrangThai FROM ACCOUNTS A JOIN ROLES R ON A.IDRole = R.IDRole WHERE R.IDRole = 'R01'";
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
        public DataTable GetListAccountCBDT()
        {
            string query = "SELECT R.IDRole, A.IdAcc, A.Username, R.Role, CASE WHEN A.Trangthai = 1 THEN N'Khóa' ELSE N'Đang sử dụng' END AS TrangThai FROM ACCOUNTS A JOIN ROLES R ON A.IDRole = R.IDRole WHERE R.IDRole = 'R02'";
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
        public DataTable GetListAccountCBQL()
        {
            string query = "SELECT R.IDRole, A.IdAcc, A.Username, R.Role, CASE WHEN A.Trangthai = 1 THEN N'Khóa' ELSE N'Đang sử dụng' END AS TrangThai FROM ACCOUNTS A JOIN ROLES R ON A.IDRole = R.IDRole WHERE R.IDRole = 'R03'";
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
        public DataTable GetListAccountGV()
        {
            string query = "SELECT R.IDRole, A.IdAcc, A.Username, R.Role, CASE WHEN A.Trangthai = 1 THEN N'Khóa' ELSE N'Đang sử dụng' END AS TrangThai FROM ACCOUNTS A JOIN ROLES R ON A.IDRole = R.IDRole WHERE R.IDRole = 'R04'";
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
        public DataTable GetListAccountSV()
        {
            string query = "SELECT R.IDRole, A.IdAcc, A.Username, R.Role, CASE WHEN A.Trangthai = 1 THEN N'Khóa' ELSE N'Đang sử dụng' END AS TrangThai FROM ACCOUNTS A JOIN ROLES R ON A.IDRole = R.IDRole WHERE R.IDRole = 'R05'";
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
        public DataTable GetListAccountGLOBALBAN()
        {
            string query = "SELECT R.IDRole, A.IdAcc, A.Username, R.Role, CASE WHEN A.Trangthai = 1 THEN N'Khóa' ELSE N'Đang sử dụng' END AS TrangThai FROM ACCOUNTS A JOIN ROLES R ON A.IDRole = R.IDRole WHERE R.IDRole = 'R06'";
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
        public DataTable GetListRole()
        {
            string query = "SELECT IDRole, Role FROM ROLES WHERE Role <> 'GLOBALBAN'";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);
                return dataTable;
            }
        }
        public DataTable GetListITChuaCoTaiKhoan()
        {
            string query = "SELECT IDIT, TenIT FROM IT I LEFT JOIN ACCOUNTS A ON I.IdAcc = A.IdAcc WHERE I.IdAcc IS NULL";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);
                return dataTable;
            }
        }
        public DataTable GetListCBDTChuaCoTaiKhoan()
        {
            string query = "SELECT IDCBDT, TenCBDT FROM CBDT C LEFT JOIN ACCOUNTS A ON C.IdAcc = A.IdAcc WHERE C.IdAcc IS NULL";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);
                return dataTable;
            }
        }
        public DataTable GetListCBQLChuaCoTaiKhoan()
        {
            string query = "SELECT IDCBQL, TenCBQL FROM CBQL C LEFT JOIN ACCOUNTS A ON C.IdAcc = A.IdAcc WHERE C.IdAcc IS NULL";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);
                return dataTable;
            }
        }
        public DataTable GetListGiaoVienChuaCoTaiKhoan()
        {
            string query = "SELECT IDGV, TenGV FROM TEACHERS T LEFT JOIN ACCOUNTS A ON T.IdAcc = A.IdAcc WHERE T.IdAcc IS NULL";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);
                return dataTable;
            }
        }
        public DataTable GetListSinhVienChuaCoTaiKhoan()
        {
            string query = "SELECT IDSV, TenSV FROM STUDENTS S LEFT JOIN ACCOUNTS A ON S.IdAcc = A.IdAcc WHERE S.IdAcc IS NULL";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);
                return dataTable;
            }
        }
        public DataTable GetListHistory(string idAcc)
        {
            string query = "SELECT A.IdAcc, A.Username, R.Role, L.LichSuLogin FROM LoginHistory L JOIN ACCOUNTS A ON L.IdAcc = A.IdAcc JOIN ROLES R ON A.IDRole = R.IDRole WHERE A.IdAcc = @IdAcc";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                DataTable dt = new DataTable();
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.SelectCommand.Parameters.Add("@IdAcc", SqlDbType.NVarChar).Value = idAcc;
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
        public bool InsertAccount(DTO_IT taikhoan, out string message)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    string hashedPassword = GetSha256Hash(taikhoan._Password);

                    string insertQuery = "INSERT INTO ACCOUNTS (IDAcc, Username, Password, IDRole, Trangthai) " +
                                         "VALUES (@IDAcc, @Username, CONVERT(varbinary(max), @Password, 2), @IDRole, @Trangthai)";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@IDAcc", taikhoan._IdAcc);
                        cmd.Parameters.AddWithValue("@Username", taikhoan._Username);
                        cmd.Parameters.AddWithValue("@Password", hashedPassword);
                        cmd.Parameters.AddWithValue("@IDRole", taikhoan._IdRole);
                        cmd.Parameters.AddWithValue("@Trangthai", taikhoan._TrangThai ? 1 : 0);
                        cmd.ExecuteNonQuery();
                    }

                    string UpdateQuery = "";
                    string idValue = "";

                    switch (taikhoan._IdRole)
                    {
                        case "R01":
                            UpdateQuery = "UPDATE IT SET IdAcc = @IdAcc WHERE IDIT = @ID";
                            idValue = taikhoan._IDIT;
                            break;
                        case "R02":
                            UpdateQuery = "UPDATE CBDT SET IdAcc = @IdAcc WHERE IDCBDT = @ID";
                            idValue = taikhoan._CBDT;
                            break;
                        case "R03":
                            UpdateQuery = "UPDATE CBQL SET IdAcc = @IdAcc WHERE IDCBQL = @ID";
                            idValue = taikhoan._CBQL;
                            break;
                        case "R04":
                            UpdateQuery = "UPDATE TEACHERS SET IdAcc = @IdAcc WHERE IDGV = @ID";
                            idValue = taikhoan._MaGV;
                            break;
                        case "R05":
                            UpdateQuery = "UPDATE STUDENTS SET IdAcc = @IdAcc WHERE IDSV = @ID";
                            idValue = taikhoan._IDSV;
                            break;
                    }

                    if (!string.IsNullOrEmpty(UpdateQuery) && !string.IsNullOrEmpty(idValue))
                    {
                        using (SqlCommand cmd = new SqlCommand(UpdateQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@IdAcc", taikhoan._IdAcc);
                            cmd.Parameters.AddWithValue("@ID", idValue);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    message = "Thông tin tài khoản đã được lưu thành công!";
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    message = "Lỗi: " + ex.Message;
                    return false;
                }
            }
        }
        public string GetRole(string Idacc)
        {
            string Role = "";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string getRoleQuery = "SELECT IDRole FROM ACCOUNTS WHERE IdAcc = @IdAcc";
                using (SqlCommand cmd = new SqlCommand(getRoleQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@IdAcc", Idacc);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        Role = result.ToString();
                    }
                }
            }
            return Role;
        }
        public bool UpdateAccount(DTO_IT taikhoan, out string message)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    string oldrole = GetRole(taikhoan._IdAcc);
                    if (oldrole != taikhoan._IdRole)
                    {
                        message = "Không được thay đổi role của tài khoản.";
                        return false;
                    }

                    string newHash;
                    if (string.IsNullOrWhiteSpace(taikhoan._Password))
                    {
                        byte[] MkCuDaMaHoa = null;
                        string GetPassQuery = "SELECT Password FROM ACCOUNTS WHERE IdAcc = @IdAcc";
                        using (SqlCommand cmd = new SqlCommand(GetPassQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@IdAcc", taikhoan._IdAcc);
                            var result = cmd.ExecuteScalar();
                            if (result != null && result != DBNull.Value)
                            {
                                MkCuDaMaHoa = (byte[])result;
                            }
                        }
                        newHash = MkCuDaMaHoa != null ? BitConverter.ToString(MkCuDaMaHoa).Replace("-", "").ToLower() : "";
                    }
                    else
                    {
                        newHash = GetSha256Hash(taikhoan._Password);
                    }

                    if (string.IsNullOrWhiteSpace(newHash))
                    {
                        message = "Lỗi: Hash mật khẩu không hợp lệ!";
                        return false;
                    }

                    string UpdateQuery = "UPDATE ACCOUNTS SET Password = CONVERT(VARBINARY(MAX), @Password, 2) WHERE IdAcc = @IdAcc";
                    using (SqlCommand cmd = new SqlCommand(UpdateQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@IdAcc", taikhoan._IdAcc);
                        cmd.Parameters.AddWithValue("@Password", newHash);

                        cmd.ExecuteNonQuery();
                    }
                    
                    transaction.Commit();
                    message = "Thông tin tài khoản đã được cập nhật thành công!";
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    message = "Lỗi: " + ex.Message;
                    return false;
                }
            }
        }
        public bool LockOrUnlockAccount(string idAcc)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string updateQuery = @"
                UPDATE ACCOUNTS SET Trangthai = CASE WHEN Trangthai = 1 THEN 0 ELSE 1 END,
                                    RoleBanDau = CASE WHEN Trangthai = 0 THEN IDRole ELSE RoleBanDau END,
                                    IDRole = CASE WHEN Trangthai = 0 THEN 'R06' ELSE RoleBanDau END WHERE IdAcc = @IdAcc;";

                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@IdAcc", idAcc);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        //prefix là tiền tố cho id
        //ví dụ: A001 --> A + 001 || A là tiền tố
        public string CreateNewId(string prefix)
        {
            List<int> numbers = new List<int>();

            string query = "SELECT IdAcc FROM ACCOUNTS WHERE IdAcc LIKE @prefix + '%'";
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
                            string id = reader["IdAcc"].ToString();
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
