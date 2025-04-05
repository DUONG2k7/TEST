using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QL
{
    public class DTO_IT_IT
    {
        private string IdAcc;
        private string Username;
        private string Password;
        private string IdRole;
        private bool TrangThai;

        public string _IdAcc
        {
            get
            {
                return IdAcc;
            }
            set
            {
                IdAcc = value;
            }
        }
        public string _Username
        {
            get
            {
                return Username;
            }
            set
            {
                Username = value;
            }
        }
        public string _Password
        {
            get
            {
                return Password;
            }
            set
            {
                Password = value;
            }
        }
        public string _IdRole
        {
            get
            {
                return IdRole;
            }
            set
            {
                IdRole = value;
            }
        }
        public bool _TrangThai
        {
            get
            {
                return TrangThai;
            }
            set
            {
                TrangThai = value;
            }
        }
        public string _IDIT { get; set; }
        public string _CBDT { get; set; }
        public string _CBQL { get; set; }
        public string _MaGV { get; set; }
        public string _IDSV { get; set; }

        public DTO_IT_IT(string idAcc, string username, string password, string idRole, bool trangThai, string roleId)
        {
            _IdAcc = idAcc;
            _Username = username;
            _Password = password;
            _IdRole = idRole;
            _TrangThai = trangThai;

            switch (idRole)
            {
                case "R01": _IDIT = roleId; break;
                case "R02": _CBDT = roleId; break;
                case "R03": _CBQL = roleId; break;
                case "R04": _MaGV = roleId; break;
                case "R05": _IDSV = roleId; break;
            }
        }

        public DTO_IT_IT(string idAcc, string password, string idRole)
        {
            _IdAcc = idAcc;
            _Password = password;
            _IdRole = idRole;
        }
    }
}
