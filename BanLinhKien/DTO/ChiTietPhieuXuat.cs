using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhieuXuat
    {
        private int maPhieuXuat;
        private int maHang;
        private int soLuong;
        private int giaXuat;


        public int MaPhieuXuat { get => maPhieuXuat; set => maPhieuXuat = value; }
        public int MaHang { get => maHang; set => maHang = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int GiaXuat { get => giaXuat; set => giaXuat = value; }

        public ChiTietPhieuXuat() { }

        public ChiTietPhieuXuat(int maphieuxuat, int mahang, int soluong, int giaxuat)
        {
            this.MaPhieuXuat = maphieuxuat;
            this.MaHang = mahang;
            this.SoLuong = soluong;
            this.GiaXuat = giaxuat;
        }
    }
}
