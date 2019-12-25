using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuNhap
    {
        private int maPhieuNhap;
        private String ngayTao;
        private int maNCC;
        private int maNV;


        public int MaPhieuNhap { get => maPhieuNhap; set => maPhieuNhap = value; }
        public String NgayTao { get => ngayTao; set => ngayTao = value; }
        public int MaNCC { get => maNCC; set => maNCC = value; }
        public int MaNV { get => maNV; set => maNV = value; }

        public PhieuNhap() { }

        public PhieuNhap(int maphieunhap, String ngaytao, int mancc, int manv)
        {
            this.MaPhieuNhap = maphieunhap;
            this.NgayTao = ngaytao;
            this.MaNCC = mancc;
            this.MaNV = manv;
        }
    }
}
