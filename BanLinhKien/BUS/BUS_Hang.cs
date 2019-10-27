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
    public class BUS_Hang
    {
        private static BUS_Hang instance;
        
        public static BUS_Hang Instance
        {
            get
            {
                if (instance == null)
                    instance = new BUS_Hang();
                return instance;
            }
        }

        public int totalRow = 0;
        public int pageSize = 10;

        private BUS_Hang() {  }

        public DataTable select()
        {
            return DAO_Hang.Instance.select();
        }

        public DataTable pagingHang(int currentPage)
        {
            this.rowCount();
            return DAO_Hang.Instance.pagingHang(currentPage, this.pageSize);
        }

        public void rowCount()
        {
            BUS_Hang.Instance.totalRow = (int)Math.Ceiling( (double)DAO_Hang.Instance.rowCount() / this.pageSize );
        }

        public int Tongsohang()
        {
            return HangDAO.Instance.rowCount();
        }

        public String LuuBangHang(Hang hang)
        {
            int effect=dao_hang.LuuBangHang(hang);
            if (effect > 0)
            {
                return "Luu du lieu thanh cong";
            }else
            {
                return "Luu du lieu khong thanh cong";
            }
        }

        public String SuaBangHang(Hang hang)
        {
            int effect = dao_hang.SuaBangHang(hang);
            if (effect>0)
            {
                return "Sua du lieu thanh cong";
            }else
            {
                return "Sua du lieu khong thanh cong";
            }
        }

        public String XoaDLBangHang(int mahang)
        {
            int effect = dao_hang.XoaDLBangHang(mahang);
            if(effect >0)
            {
                return "Xoa du lieu thanh cong";
            }else
            {
                return "Xoa du lieu khong thanh cong";
            }
        }
    }
}
