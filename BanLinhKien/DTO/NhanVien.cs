using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        private int maNV;
        private string username;
        private string password;
        private string hoTen;
        private string sdt;
        private string diaChi;
        private DateTime namSinh;
        private int loaiNhanVien;
        private bool gioiTinh;
        private DateTime ngayTao;


        public int MaNV { get => maNV; set => maNV = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public DateTime NamSinh { get => namSinh; set => namSinh = value; }
        public int LoaiNhanVien { get => loaiNhanVien; set => loaiNhanVien = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgayTao { get => ngayTao; set => ngayTao = value; }

        public NhanVien() { }

        public NhanVien(int manv, string username, string password, string hoten, string sdt, string diachi, DateTime namsinh, int loainhanvien, bool gioitinh, DateTime ngaytao)
        {
            this.MaNV = manv;
            this.Username = username;
            this.Password = password;
            this.HoTen = hoten;
            this.Sdt = sdt;
            this.DiaChi = diachi;
            this.NamSinh = namsinh;
            this.LoaiNhanVien = loainhanvien;
            this.GioiTinh = gioitinh;
            this.NgayTao = ngaytao;
        }
    }
}
