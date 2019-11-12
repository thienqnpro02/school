using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAO;

namespace BUS
{
    public class BUS_NhapHang
    {
        private DAO_DanhMuc dao_danhmuc = DAO_DanhMuc.Instance;
        private DAO_Hang dao_hang = DAO_Hang.Instance;

        private static BUS_NhapHang bus_nhaphang;

        public static BUS_NhapHang Instance
        {
            get
            {
                if (bus_nhaphang == null)
                {
                    bus_nhaphang = new BUS_NhapHang();
                }
                return bus_nhaphang;
            }
        }

        private int pageSize = 10;
        public int pageNumber = 1;
        public int currentPage = 1;

        public DataTable DanhMuc()
        {
            DataTable danhmuc = dao_danhmuc.BangDanhMuc();
            return danhmuc;
        }

        public DataTable Hang()
        {
            DataTable hang = dao_hang.select();
            return hang;
        }

        public DataTable DLTrenTungTrang_NhapHang()
        {
            PageNumber();
            DataTable dltrentungtrang_nhaphang = dao_hang.pagingHang(currentPage, pageSize);
            return dltrentungtrang_nhaphang;
        }

        public DataTable DLTrenTungTrang_NhapHang_TheoMadanhmuc(int madanhmuc)
        {
            PageNumber_TheoMaDanhMuc(madanhmuc);
            DataTable dltrentungtrang_nhaphang_theomadnhmuc = dao_hang.pagingHangByMaDM(currentPage, pageSize, madanhmuc);
            return dltrentungtrang_nhaphang_theomadnhmuc;
        }

        private void PageNumber_TheoMaDanhMuc(int madanhmuc)
        {
            pageNumber = (int)Math.Ceiling((double)dao_hang.rowCountByMaDM(madanhmuc) / this.pageSize);
        }

        private void PageNumber()
        {
            pageNumber = (int)Math.Ceiling((double)dao_hang.rowCount() / this.pageSize);
        }

    }
}
