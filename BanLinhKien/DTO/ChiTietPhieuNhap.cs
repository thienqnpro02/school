using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhieuNhap
    {
        private int maPhieuNhap;
        private int maHang;
        private int soLuong;
        private int giaNhap;


        public int MaPhieuNhap { get => maPhieuNhap; set => maPhieuNhap = value; }
        public int MaHang { get => maHang; set => maHang = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int GiaNhap { get => giaNhap; set => giaNhap = value; }

        public ChiTietPhieuNhap() { }

        public ChiTietPhieuNhap(int maphieunhap, int mahang, int soluong, int gianhap)
        {
            this.MaPhieuNhap = maphieunhap;
            this.MaHang = mahang;
            this.SoLuong = soluong;
            this.GiaNhap = gianhap;
        }
    }
}
