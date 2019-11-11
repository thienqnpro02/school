using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string BoPhan { get; set; }

        public NhanVien() { }

        public NhanVien(string manv, string tennv, string bophan) 
        {
            this.MaNV = manv;
            this.TenNV = tennv;
            this.BoPhan = bophan;
        }
    }
}
