using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang
    {
        private int maKH;
        private string hoTen;
        private string sdt;
        private DateTime namSinh;
        private DateTime ngayTao;


        public int MaKH { get => maKH; set => maKH = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public DateTime NamSinh { get => namSinh; set => namSinh = value; }
        public DateTime NgayTao { get => ngayTao; set => ngayTao = value; }

        public KhachHang() { }

        public KhachHang(int makh, string hoten, string sdt, DateTime namsinh, DateTime ngaytao)
        {
            this.MaKH = makh;
            this.HoTen = hoten;
            this.NamSinh = namsinh;
            this.NgayTao = ngaytao;
        }
    }
}
