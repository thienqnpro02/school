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

        public int totalPage = 0;        
        public int pageSize = 10;
        public string pathImage = @"D:\Ex-on-school\school\BanLinhKien\BanLinhKien\images\";

        private HangBUS() {  }

        public DataTable select()
        {
            return HangDAO.Instance.select();
        }

        public DataTable pagingHang(int currentPageHang)
        {
            this.pageCount();
            return HangDAO.Instance.pagingHang(currentPageHang,this.pageSize);
        }

        public void pageCount()
        {
            HangBUS.Instance.totalPage = (int)Math.Ceiling( (double)HangDAO.Instance.rowCount() / this.pageSize );
        }

        public int Tongsohang()
        {
            return HangDAO.Instance.rowCount();
        }

        public int LuuBangHang(Hang hang)
        {
            return dao_hang.LuuBangHang(hang);
            
        }

        public int SuaBangHang(Hang hang)
        {
            return dao_hang.SuaBangHang(hang);
            
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

        public bool isExistsImage(string fileName)
        {
            return HangDAO.Instance.isExistsImage(fileName);
        }
    }
}
