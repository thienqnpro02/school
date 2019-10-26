using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCap
    {
        private int maNCC;
        private string tenNCC;
        private string diaChi;
        private string fax;
        private string email;
        private String ngayTao;


        public int MaNCC { get => maNCC; set => maNCC = value; }
        public string TenNCC { get => tenNCC; set => tenNCC = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Fax { get => fax; set => fax = value; }
        public string Email { get => email; set => email = value; }
        public String NgayTao { get => ngayTao; set => ngayTao = value; }

        public NhaCungCap() { }

        public NhaCungCap(int mancc, string tenncc, string diachi, string fax, string email,String ngaytao)
        {
            this.MaNCC = mancc;
            this.TenNCC = tenncc;
            this.DiaChi = diachi;
            this.Fax = fax;
            this.Email = email;
            this.NgayTao = ngaytao;
        }
    }
}
