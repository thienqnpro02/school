using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAO;
using DTO;

namespace BUS
{
    public class BUS_NCC
    {
        DAO_NCC dao_ncc = DAO_NCC.Instance;

        private static BUS_NCC instance;
        public static BUS_NCC Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_NCC();
                }
                return instance;
            }
        }

        private BUS_NCC() { }

        public int totalPage = 0;
        public int pageSize = 10;


        public DataTable BangNCC()
        {
            DataTable ncc = dao_ncc.BangNCC();
            return ncc;
        }

        public DataTable DLTrenTungTrang_NCC(int currentPageNCC)
        {
            PageNumber();
            DataTable ncc = dao_ncc.DLTrenTungTrang_NCC(currentPageNCC, this.pageSize);
            return ncc;
        }

        public void PageNumber()
        {
            totalPage = (int)Math.Ceiling((double)dao_ncc.RowCount() / this.pageSize);
        }

        public int RowCount()
        {
            return dao_ncc.RowCount();
        }

        public String LuuBangNhaCungCap(NhaCungCap ncc)
        {
            int effect = dao_ncc.LuuBangNhaCungCap(ncc);
            if (effect > 0)
            {
                return "Lưu dữ liệu thành công";
            } else
            {
                return "Lưu dữ liệu không thành công";
            }
        }

        public String SuuBangNhaCungCap(NhaCungCap ncc)
        {
            int effect = dao_ncc.SuuBangNhaCungCap(ncc);
            if (effect > 0)
            {
                return "Sửa dữ liệu thành công";
            } else
            {
                return "Sửa dữ liệu không thành công";
            }
        }

        public String XoaDLBangNhaCungCap(int mancc)
        {
            int effect = dao_ncc.XoaDLBangNhaCungCap(mancc);
            if (effect > 0)
            {
                return "Xóa dữ liệu thành công";
            } else
            {
                return "Xóa dữ liệu không thành công";
            }
        }

        public int MaNCC()
        {
            return dao_ncc.MaNCC();
        }
    }
}
