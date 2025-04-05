using DTO_QL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QL
{
    public class DAL_CBQL : DbConnect
    {
        //IT
        public DataTable GetListIT()
        {
            string query = "SELECT P.IDPhong, I.IDIT, I.TenIT, I.IdAcc, I.Email, I.SoDT, " +
                            "CASE WHEN I.Gioitinh = 1 THEN N'Nam' ELSE N'Nữ' END AS Gioitinh, " +
                            "I.Diachi, I.Hinh, P.TenPhong " +
                            "FROM IT I JOIN PhongBan P ON I.IDPhong = P.IDPhong";
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
        public bool InsertIT(DTO_CBQL_IT IT, out string message)
        {
            try
            {
                string insertQuery = "INSERT INTO IT (IDIT, IDPhong, TenIT, Email, SoDT, Gioitinh, Diachi, Hinh) VALUES (@IDIT, @IDPhong, @TenIT, @Email, @SoDT, @Gioitinh, @Diachi, @Hinh)";
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@IDIT", IT.IDIT);
                        cmd.Parameters.AddWithValue("@IDPhong", IT.IDPhong);
                        cmd.Parameters.AddWithValue("@TenIT", IT.TenIT);
                        cmd.Parameters.AddWithValue("@Email", IT.Email);
                        cmd.Parameters.AddWithValue("@SoDT", IT.SoDT);
                        cmd.Parameters.AddWithValue("@Gioitinh", IT.Gioitinh ? 1 : 0);
                        cmd.Parameters.AddWithValue("@Diachi", IT.Diachi);
                        cmd.Parameters.AddWithValue("@Hinh", IT.Hinh);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            message = "Thông tin IT đã được lưu thành công!";
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
                message = "Lỗi khi thêm IT: " + ex.Message;
                return false;
            }
        }
        public bool UpdateIT(DTO_CBQL_IT IT, out string message)
        {
            try
            {
                string updateQuery = "UPDATE IT SET IDPhong = @IDPhong, TenIT = @TenIT, Email = @Email, SoDT = @SoDT, Gioitinh = @Gioitinh, Diachi = @Diachi, Hinh = @Hinh WHERE IDIT = @IDIT";
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@IDIT", IT.IDIT);
                        cmd.Parameters.AddWithValue("@IDPhong", IT.IDPhong);
                        cmd.Parameters.AddWithValue("@TenIT", IT.TenIT);
                        cmd.Parameters.AddWithValue("@Email", IT.Email);
                        cmd.Parameters.AddWithValue("@SoDT", IT.SoDT);
                        cmd.Parameters.AddWithValue("@Gioitinh", IT.Gioitinh ? 1 : 0);
                        cmd.Parameters.AddWithValue("@Diachi", IT.Diachi);
                        cmd.Parameters.AddWithValue("@Hinh", IT.Hinh);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            message = "Thông tin IT đã được cập nhật thành công!";
                            return true;
                        }
                        else
                        {
                            message = "Không có IT nào được cập nhật.";
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                message = "Lỗi khi cập nhật IT: " + ex.Message;
                return false;
            }
        }
        public string CreateNewItId(string prefix)
        {
            List<int> numbers = new List<int>();

            string query = "SELECT IDIT FROM IT WHERE IDIT LIKE @prefix + '%'";
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
                            string id = reader["IDIT"].ToString();
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

        //CBDT
        public DataTable GetListCBDT()
        {
            string query = "SELECT P.IDPhong, CB.IDCBDT, CB.TenCBDT, CB.IdAcc, CB.Email, CB.SoDT, " +
                            "CASE WHEN CB.Gioitinh = 1 THEN N'Nam' ELSE N'Nữ' END AS Gioitinh, " +
                            "CB.Diachi, CB.Hinh, P.TenPhong " +
                            "FROM CBDT CB JOIN PhongBan P ON CB.IDPhong = P.IDPhong";
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
        public bool InsertCBDT(DTO_CBQL_CBDT CBDT, out string message)
        {
            try
            {
                string insertQuery = "INSERT INTO CBDT (IDCBDT, IDPhong, TenCBDT, Email, SoDT, Gioitinh, Diachi, Hinh) VALUES (@IDCBDT, @IDPhong, @TenCBDT, @Email, @SoDT, @Gioitinh, @Diachi, @Hinh)";
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@IDCBDT", CBDT.IDCBDT);
                        cmd.Parameters.AddWithValue("@IDPhong", CBDT.IDPhong);
                        cmd.Parameters.AddWithValue("@TenCBDT", CBDT.TenCBDT);
                        cmd.Parameters.AddWithValue("@Email", CBDT.Email);
                        cmd.Parameters.AddWithValue("@SoDT", CBDT.SoDT);
                        cmd.Parameters.AddWithValue("@Gioitinh", CBDT.Gioitinh ? 1 : 0);
                        cmd.Parameters.AddWithValue("@Diachi", CBDT.Diachi);
                        cmd.Parameters.AddWithValue("@Hinh", CBDT.Hinh);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            message = "Thông tin CBDT đã được lưu thành công!";
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
                message = "Lỗi khi thêm CBDT: " + ex.Message;
                return false;
            }
        }
        public bool UpdateCBDT(DTO_CBQL_CBDT CBDT, out string message)
        {
            try
            {
                string updateQuery = "UPDATE CBDT SET IDPhong = @IDPhong, TenCBDT = @TenCBDT, Email = @Email, SoDT = @SoDT, Gioitinh = @Gioitinh, Diachi = @Diachi, Hinh = @Hinh WHERE IDCBDT = @IDCBDT";
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@IDCBDT", CBDT.IDCBDT);
                        cmd.Parameters.AddWithValue("@IDPhong", CBDT.IDPhong);
                        cmd.Parameters.AddWithValue("@TenCBDT", CBDT.TenCBDT);
                        cmd.Parameters.AddWithValue("@Email", CBDT.Email);
                        cmd.Parameters.AddWithValue("@SoDT", CBDT.SoDT);
                        cmd.Parameters.AddWithValue("@Gioitinh", CBDT.Gioitinh ? 1 : 0);
                        cmd.Parameters.AddWithValue("@Diachi", CBDT.Diachi);
                        cmd.Parameters.AddWithValue("@Hinh", CBDT.Hinh);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            message = "Thông tin CBDT đã được cập nhật thành công!";
                            return true;
                        }
                        else
                        {
                            message = "Không có CBDT nào được cập nhật.";
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                message = "Lỗi khi cập nhật CBDT: " + ex.Message;
                return false;
            }
        }
        public string CreateNewCBDTId(string prefix)
        {
            List<int> numbers = new List<int>();

            string query = "SELECT IDCBDT FROM CBDT WHERE IDCBDT LIKE @prefix + '%'";
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
                            string id = reader["IDCBDT"].ToString();
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

        //CBQL
        public DataTable GetListCBQL()
        {
            string query = "SELECT P.IDPhong, QL.IDCBQL, QL.TenCBQL, QL.IdAcc, QL.Email, QL.SoDT, " +
                            "CASE WHEN QL.Gioitinh = 1 THEN N'Nam' ELSE N'Nữ' END AS Gioitinh, " +
                            "QL.Diachi, QL.Hinh, P.TenPhong " +
                            "FROM CBQL QL JOIN PhongBan P ON QL.IDPhong = P.IDPhong";
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
        public bool InsertCBQL(DTO_CBQL_CBQL CBQL, out string message)
        {
            try
            {
                string insertQuery = "INSERT INTO CBQL (IDCBQL, IDPhong, TenCBQL, Email, SoDT, Gioitinh, Diachi, Hinh) VALUES (@IDCBQL, @IDPhong, @TenCBQL, @Email, @SoDT, @Gioitinh, @Diachi, @Hinh)";
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@IDCBQL", CBQL.IDCBQL);
                        cmd.Parameters.AddWithValue("@IDPhong", CBQL.IDPhong);
                        cmd.Parameters.AddWithValue("@TenCBQL", CBQL.TenCBQL);
                        cmd.Parameters.AddWithValue("@Email", CBQL.Email);
                        cmd.Parameters.AddWithValue("@SoDT", CBQL.SoDT);
                        cmd.Parameters.AddWithValue("@Gioitinh", CBQL.Gioitinh ? 1 : 0);
                        cmd.Parameters.AddWithValue("@Diachi", CBQL.Diachi);
                        cmd.Parameters.AddWithValue("@Hinh", CBQL.Hinh);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            message = "Thông tin CBQL đã được lưu thành công!";
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
                message = "Lỗi khi thêm CBQL: " + ex.Message;
                return false;
            }
        }
        public bool UpdateCBQL(DTO_CBQL_CBQL CBQL, out string message)
        {
            try
            {
                string updateQuery = "UPDATE CBQL SET IDPhong = @IDPhong, TenCBQL = @TenCBQL, Email = @Email, SoDT = @SoDT, Gioitinh = @Gioitinh, Diachi = @Diachi, Hinh = @Hinh WHERE IDCBQL = @IDCBQL";
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@IDCBQL", CBQL.IDCBQL);
                        cmd.Parameters.AddWithValue("@IDPhong", CBQL.IDPhong);
                        cmd.Parameters.AddWithValue("@TenCBQL", CBQL.TenCBQL);
                        cmd.Parameters.AddWithValue("@Email", CBQL.Email);
                        cmd.Parameters.AddWithValue("@SoDT", CBQL.SoDT);
                        cmd.Parameters.AddWithValue("@Gioitinh", CBQL.Gioitinh ? 1 : 0);
                        cmd.Parameters.AddWithValue("@Diachi", CBQL.Diachi);
                        cmd.Parameters.AddWithValue("@Hinh", CBQL.Hinh);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            message = "Thông tin CBQL đã được cập nhật thành công!";
                            return true;
                        }
                        else
                        {
                            message = "Không có CBQL nào được cập nhật.";
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                message = "Lỗi khi cập nhật CBQL: " + ex.Message;
                return false;
            }
        }
        public string CreateNewCBQLId(string prefix)
        {
            List<int> numbers = new List<int>();

            string query = "SELECT IDCBQL FROM CBQL WHERE IDCBQL LIKE @prefix + '%'";
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
                            string id = reader["IDCBQL"].ToString();
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

        //Phòng ban
        public DataTable GetListPhong()
        {
            string query = "SELECT IDPhong, TenPhong FROM PhongBan";
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
        public bool InsertPhong(string TenPhong, out string message)
        {
            try
            {
                string insertQuery = "INSERT INTO PhongBan (TenPhong) VALUES (@TenPhong)";
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@TenPhong", TenPhong);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            message = "Thông tin phòng ban đã được lưu thành công!";
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
                message = "Lỗi khi thêm phòng ban: " + ex.Message;
                return false;
            }
        }
        public bool UpdatePhong(int IDPhong, string TenPhong, out string message)
        {
            try
            {
                string updateQuery = "UPDATE PhongBan SET TenPhong = @TenPhong WHERE IDPhong = @IDPhong";
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@IDPhong", IDPhong);
                        cmd.Parameters.AddWithValue("@TenPhong", TenPhong);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            message = "Thông tin phòng ban đã được cập nhật thành công!";
                            return true;
                        }
                        else
                        {
                            message = "Không có phòng ban nào được cập nhật.";
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                message = "Lỗi khi cập nhật phòng ban: " + ex.Message;
                return false;
            }
        }
    }
}
