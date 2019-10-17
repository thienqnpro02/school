using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuXuat
    {
        private int maPhieuXuat;
        private int maKH;
        private DateTime ngayTao;
        private int maNV;


        public int MaPhieuXuat { get => maPhieuXuat; set => maPhieuXuat = value; }
        public int MaKH { get => maKH; set => maKH = value; }
        public DateTime NgayTao { get => ngayTao; set => ngayTao = value; }
        public int MaNV { get => maNV; set => maNV = value; }

        public PhieuXuat() { }

        public PhieuXuat(int maphieuxuat, int makh, DateTime ngaytao, int manv)
        {
            this.MaPhieuXuat = maphieuxuat;
            this.MaKH = makh;
            this.NgayTao = ngaytao;
            this.MaNV = manv;
        }
    }
}
