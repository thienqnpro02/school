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
    public class BUS_KhachHang
    {
        private DAO_KhachHang dao_khachhang = DAO_KhachHang.Instance;
        private static BUS_KhachHang instance;

        public static BUS_KhachHang Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_KhachHang();
                }
                return instance;
            }
        }

        private BUS_KhachHang() { }

        public int pageSize = 10;
        public int totalPage = 0;
        

        public DataTable BangKhachHang()
        {
            DataTable datatable_khachhang = dao_khachhang.BangKhachHang();
            return datatable_khachhang;
        }

        public DataTable PhanTrang_KhachHang(int currentPageKhachHang)
        {
            pageTotal();
            DataTable dlmottrang_khachhang = dao_khachhang.DLTrenMotTrang_KhachHang(currentPageKhachHang, pageSize);
            return dlmottrang_khachhang;
        }

        private void pageTotal()
        {
            totalPage = (int)Math.Ceiling((double)dao_khachhang.RowCount() / this.pageSize);
        }

        public int RowCount()
        {
            return dao_khachhang.RowCount();
        }

        public String LuuBangKhachHang(KhachHang khachhang)
        {
            int effect = dao_khachhang.LuuBangKhachHang(khachhang);
            if(effect > 0)
            {
                return "Luu du lieu thanh cong";
            }else
            {
                return "Luu du lieu khong thanh cong";
            }
        }

        public String SuaBangKhachHang(KhachHang khachhang)
        {
            int effect = dao_khachhang.SuaBangKhachHang(khachhang);
            if(effect > 0)
            {
                return "Sua du lieu thanh cong";
            }else
            {
                return "Sua du lieu khong thanh cong";
            }
        }

        public String XoaDlBangKhachHang(int makh)
        {
            int effect = dao_khachhang.XoaBangKhachHang(makh);
            if(effect > 0)
            {
                return "Xoa du lieu thanh cong";
            }else
            {
                return "Xoa du lieu khong thanh cong";
            }
        }


        public int currentID()
        {
            return DAO_KhachHang.Instance.currentID();
        }

        public DataTable selectByID(List<int> list_id)
        {
            return DAO_KhachHang.Instance.selectByID(list_id);
        }
    }
}
