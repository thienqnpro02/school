using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using DAO;

namespace BUS
{
    public class BUS_DanhMuc
    {
        DAO_DanhMuc dao_danhmuc = DAO_DanhMuc.Instance;

        public int pageNumber = 0;
        public int pageSize = 11;
        public int currentPage = 1;

        public DataTable BangDanhMuc()
        {
            DataTable danhmuc=dao_danhmuc.BangDanhMuc();
            return danhmuc;
        }

        public String LuuBangDanhMuc(String tendanhmuc,String ngaytao)
        {
            int effect=dao_danhmuc.LuuBangDanhMuc(tendanhmuc,ngaytao);
            if (effect > 0)
            {
                return "Luu du lieu thanh cong";
            }
            return "Luu du lieu khong thanh cong";
        }

        public String SuaBangDanhMuc(int madm,String tendanhmuc)
        {
            int effect=dao_danhmuc.SuaBangDanhMuc(madm, tendanhmuc);
            if (effect > 0)
            {
                return "Suu du lieu thanh cong";
            }
            return "Suu du lieu khong thanh cong";
        }

        public String XoaDLBangDanhMuc(int madm)
        {
            int effect=dao_danhmuc.XoaDLBangDanhMuc(madm);
            if (effect > 0)
            {
                return "Xoa du lieu thanh cong";
            }
            return "Xoa du lieu khong thanh cong";
        }

        public DataTable pagingHang()
        {
            PageNumber();
            DataTable datatable = dao_danhmuc.pagingDangMuc(this.currentPage, this.pageSize);
            return datatable;
        }

        public void PageNumber()
        {
            pageNumber = (int)Math.Ceiling((double)(rowCount() / this.pageSize));
        }

        public int rowCount()
        {
            return dao_danhmuc.rowCount();
        }
    }
}
