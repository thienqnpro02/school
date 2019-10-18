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
        DataProvider dataProvider = DataProvider.Instance;
        public DataTable BangDanhMuc()
        {
            String sql = "select *from danhmuc_test";
            DataTable datatable=dataProvider.ExecuteQuery(sql);
            return datatable;           
        }

        public String LuuBangDanhMuc(String tendanhmuc)
        {
            String sql = String.Format("insert into danhmuc_test(tendanhmuc) values ('{0}')",tendanhmuc);
            int effect=dataProvider.ExecuteNonQuery(sql);
            if (effect > 0)
            {
                return "Luu du lieu thanh cong";
            }
            return "Luu du lieu khong thanh cong";
        }

        public String SuaBangDanhMuc(int madm,String tendanhmuc)
        {
            String sql = String.Format("update danhmuc_test set tendanhmuc = '{0}' where madm = {1}", tendanhmuc, madm);
            int effect = dataProvider.ExecuteNonQuery(sql);
            if (effect > 0)
            {
                return "Suu du lieu thanh cong";
            }
            return "Suu du lieu khong thanh cong";
        }

        public String XoaDLBangDanhMuc(int madm)
        {
            String sql = String.Format("delete from danhmuc_test where madm = {0}", madm);
            int effect = dataProvider.ExecuteNonQuery(sql);
            if (effect > 0)
            {
                return "Xoa du lieu thanh cong";
            }
            return "Xoa du lieu khong thanh cong";
        }
    }
}
