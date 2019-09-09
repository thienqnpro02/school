using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DonHang
    {
        public string SoDonHang { get; set; }
        public string MaKH { get; set; }
        public string MaNV { get; set; }
        public DateTime NgayLap { get; set; }
        public string NoiGiaoHang { get; set; }
        public DateTime ThoiGianGiao { get; set; }
        public string GhiChu { get; set; }
        public string NamLapDH { get; set; }
        public int SoTien { get; set; }
        public string SoHopHong { get; set; }

        public DonHang() { }

        public DonHang(string sodonhang, string makh, string manv,
            DateTime ngaylap, string noigiaohang, DateTime thoigiangiao, string ghichu, string namlapdh, int sotien, string sohopdong) 
        {
            this.SoDonHang = sodonhang;
            this.MaKH = makh;
            this.MaNV = manv;
            this.NgayLap = ngaylap;
            this.NoiGiaoHang = noigiaohang;
            this.ThoiGianGiao = thoigiangiao;
            this.GhiChu = ghichu;
            this.NamLapDH = namlapdh;
            this.SoTien = sotien;
            this.SoHopHong = sohopdong;
        }

    }
}
