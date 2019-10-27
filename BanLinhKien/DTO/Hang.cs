using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Hang
    {
        private int maHang;
        private string tenHang;
        private string thongSo;
        private int baoHanh;
        private int soLuong;
        private int gia;
        private string hinh;
        private string nhaSanXuat;
        private string ngayTao;
        private int maDanhMuc;

        public int MaHang { get => maHang; set => maHang = value; }
        public string TenHang { get => tenHang; set => tenHang = value; }
        public string ThongSo { get => thongSo; set => thongSo = value; }
        public int BaoHanh { get => baoHanh; set => baoHanh = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int Gia { get => gia; set => gia = value; }
        public string Hinh { get => hinh; set => hinh = value; }
        public string NhaSanXuat { get => nhaSanXuat; set => nhaSanXuat = value; }
        public string NgayTao { get => ngayTao; set => ngayTao = value; }
        public int MaDanhMuc { get => maDanhMuc; set => maDanhMuc = value; }

        public Hang() { }

        public Hang(int mahang, string tenhang, string thongso, int baohanh, int soluong, int gia, string nhasanxuat, String ngaytao, int madanhmuc)
        {
            this.MaHang = mahang;
            this.TenHang = tenhang;
            this.ThongSo = thongso;
            this.BaoHanh = baohanh;
            this.SoLuong = soluong;
            this.Gia = gia;            
            this.NhaSanXuat = nhasanxuat;
            this.NgayTao = ngaytao;
            this.MaDanhMuc = madanhmuc;
        }
    }
}
