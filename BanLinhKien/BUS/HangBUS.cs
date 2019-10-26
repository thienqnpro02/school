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
    public class HangBUS
    {
        HangDAO dao_hang = HangDAO.Instance;
        private static HangBUS instance;
        
        public static HangBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new HangBUS();
                return instance;
            }
        }

        public int totalRow = 0;
        public int currentPageHang = 1;
        public int pageSize = 10;

        private HangBUS() {  }

        public DataTable select()
        {
            return HangDAO.Instance.select();
        }

        public DataTable pagingHang()
        {
            this.rowCount();
            return HangDAO.Instance.pagingHang(this.currentPageHang,this.pageSize);
        }

        public void rowCount()
        {
            HangBUS.Instance.totalRow = (int)Math.Ceiling( (double)HangDAO.Instance.rowCount() / this.pageSize );
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
