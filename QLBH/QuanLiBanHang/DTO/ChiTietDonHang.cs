using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietDonHang
    {
        public string SoDonHang { get; set; }
        public string MaHang { get; set; }
        public int SoLuong { get; set; }
        public string GhiChu { get; set; }

        public ChiTietDonHang() { }

        public ChiTietDonHang(string sodonhang, string mahang, int soluong, string ghichu) 
        {
            this.SoDonHang = sodonhang;
            this.MaHang = mahang;
            this.SoLuong = soluong;
            this.GhiChu = ghichu;
        }
    }
}
