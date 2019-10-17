using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DanhMuc
    {
        private int maDM;
        private string tenDanhMuc;
        private DateTime ngayTao;


        public int MaDM { get => maDM; set => maDM = value; }
        public string TenDanhMuc { get => tenDanhMuc; set => tenDanhMuc = value; }
        public DateTime NgayTao { get => ngayTao; set => ngayTao = value; }

        public DanhMuc() { }

        public DanhMuc(int madm, string tendanhmuc, DateTime ngaytao)
        {
            this.MaDM = madm;
            this.TenDanhMuc = tendanhmuc;
            this.NgayTao = ngaytao;
        }
    }
}
