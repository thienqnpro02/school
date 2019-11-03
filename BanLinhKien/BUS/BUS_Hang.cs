using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using DTO;
using DAO;
using System.Collections;

namespace BUS
{
    public class BUS_Hang
    {
        DAO_Hang dao_hang = DAO_Hang.Instance;
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

        public int totalPage = 0;        
        public int pageSize = 10;
        public string pathImage = @"D:\Ex-on-school\school\BanLinhKien\BanLinhKien\images\";

        private BUS_Hang() {  }

        public DataTable select()
        {
            return DAO_Hang.Instance.select();
        }

        public DataTable pagingHang(int currentPageHang)
        {
            this.pageCount();
            return DAO_Hang.Instance.pagingHang(currentPageHang,this.pageSize);
        }
        public DataTable pagingHangByMaDM(int currentPage, int maDM)
        {
            this.pageCountByMaDM(maDM);
            return DAO_Hang.Instance.pagingHangByMaDM(currentPage, this.pageSize, maDM);
        }

        public void pageCount()
        {
            BUS_Hang.Instance.totalPage = (int)Math.Ceiling( (double)DAO_Hang.Instance.rowCount() / (double)this.pageSize );
        }

        public void pageCountByMaDM(int maDM)
        {
            BUS_Hang.Instance.totalPage = (int)Math.Ceiling((double)DAO_Hang.Instance.rowCountByMaDM(maDM) / (double)this.pageSize);
        }

        public int Tongsohang()
        {
            return DAO_Hang.Instance.rowCount();
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
            return DAO_Hang.Instance.isExistsImage(fileName);
        }

        public DataTable selectByID(List<int> list_id)
        {
            if (list_id.Count == 0) return new DataTable();
            return DAO_Hang.Instance.selectByID(list_id);
        }

        public DataTable selectByMaDM(List<int> list_id)
        {
            if (list_id.Count == 0) return new DataTable();
            return DAO_Hang.Instance.selectByMaDM(list_id);                
        }

        public int updateSoLuongHang(int maHang, int soLuong)
        {

            return DAO_Hang.Instance.updateSoLuongHang(maHang, soLuong);
        }

        
    }
}
