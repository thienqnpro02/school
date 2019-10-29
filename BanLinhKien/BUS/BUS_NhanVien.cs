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
    public class BUS_NhanVien
    {
        DAO_NhanVien dao_nhanvien = DAO_NhanVien.Instance;
        private static BUS_NhanVien instance;
        public static BUS_NhanVien Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_NhanVien();
                }
                return instance;
            }
        }
        private BUS_NhanVien() { }

        public DataTable BangNhanVien()
        {
            DataTable nhanvien = dao_nhanvien.BangNhanVien();
            return nhanvien;
        }

        public int totalPage = 0;
        public int pageSize = 10;
        

        private void PageNumber()
        {
            totalPage = (int)Math.Ceiling((double)dao_nhanvien.RowCount() / this.pageSize);
        }

        public int RowCount()
        {
            return dao_nhanvien.RowCount();
        }

        public DataTable DlTrenMotTrang_NhanVien(int currentPageNhanVien)
        {
            PageNumber();
            DataTable dltrenmottrang_nhanvien = dao_nhanvien.DLTrenMotTrang_NhanVien(currentPageNhanVien, pageSize);
            return dltrenmottrang_nhanvien;
        }

        public String LuuBangNhanVien(NhanVien nhanvien)
        {
            int effect = dao_nhanvien.LuuBangNhanVien(nhanvien);
            if(effect > 0)
            {
                return "Luu du lieu thanh cong";
            }else
            {
                return "Luu du lieu khong thanh cong";
            }
        }

        public String XoaDLBangNhanVien(int manv)
        {
            int effect = dao_nhanvien.XoaDlBangNhanVien(manv);
            if(effect > 0)
            {
                return "Xoa du lieu thanh cong";
            }else
            {
                return "Xoa du lieu khong thanh cong";
            }
        }

        public String CapNhapDLBangNhanVien(NhanVien nhanvien)
        {
            int effect = dao_nhanvien.CapNhapBangNhanVien(nhanvien);
            if(effect > 0)
            {
                return "Cap nhap du lieu thanh cong";
            }else
            {
                return "Cap nhap du lieu khong thanh cong";
            }

        }

       
    }
}
