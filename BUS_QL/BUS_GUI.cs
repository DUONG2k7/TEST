using DAL_QL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QL
{
    public class BUS_GUI
    {
        DAL_GUI QlGiaoDien = new DAL_GUI();

        //Form LOGIN
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
        public string GetIdAccFormUsernameAndPassWord(string username, string password)
        {
            string passwordHash = GetSha256Hash(password);
            return QlGiaoDien.GetIdAccFormUsernameAndPassWord(username, passwordHash);
        }
        public int GetIdKyHocDangHoc()
        {
            return QlGiaoDien.GetIdKyHocDangHoc();
        }
        public string GetIDRole(string idAcc)
        {
            return QlGiaoDien.GetIDRole(idAcc);
        }

        public void SaveLoginHistory(string idAcc)
        {
            QlGiaoDien.InsertLoginHistory(idAcc);
        }

        //Form ADMIN
        public string GetRole(string ID)
        {
            return QlGiaoDien.GetRole(ID);
        }
    }
}
