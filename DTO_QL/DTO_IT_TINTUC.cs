using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QL
{
    public class DTO_IT_TINTUC
    {
        public int IDTin { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime NgayDang { get; set; }
        public byte[] Hinh { get; set; }
        public bool Trangthai { get; set; }

        public DTO_IT_TINTUC(int idTin, string title, string content, DateTime ngayDang, byte[] hinh)
        {
            IDTin = idTin;
            Title = title;
            Content = content;
            NgayDang = ngayDang;
            Hinh = hinh;
        }
        public DTO_IT_TINTUC(string title, string content, DateTime ngayDang, byte[] hinh, bool TRANGTHAI)
        {
            Title = title;
            Content = content;
            NgayDang = ngayDang;
            Hinh = hinh;
            Trangthai = TRANGTHAI;
        }
    }
}
