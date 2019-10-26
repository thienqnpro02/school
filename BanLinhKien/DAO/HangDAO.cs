using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
namespace DAO
{
    public class HangDAO
    {
        DataProvider dataProvider = DataProvider.Instance;
        private static HangDAO instance;

        public static HangDAO Instance
        {
            get
            {
                if (instance == null)
                     instance = new HangDAO();
                return instance;
            }
        }

        private HangDAO() { }

        public DataTable select()
        {
            string sql = "select * from Hang_test";
            DataTable res = DataProvider.Instance.ExecuteQuery(sql);

            return res;
        }

        public DataTable pagingHang(int currentPage, int pageSize)
        {
            string sql = "exec dbo.USP_PagingHang @currentPage , @pageSize";
            DataTable res = DataProvider.Instance.ExecuteQuery(sql, new object[] { currentPage , pageSize });
            return res;
        }

        public int rowCount()
        {
            string sql = "select count(*) from Hang_test";
            int row = Convert.ToInt32( DataProvider.Instance.ExecuteScalar(sql) );
            return row;
        }

        public int LuuBangHang(Hang hang)
        {
            String sql = String.Format("insert into hang_test(tenhang,thongso,baohanh,soluong,gia,nhasanxuat,ngaytao,madanhmuc) " +
                "values ('{0}','{1}',{2},{3},{4},'{5}','{6}',{7})",
            hang.TenHang,hang.ThongSo,hang.BaoHanh,hang.SoLuong,hang.Gia,hang.NhaSanXuat,hang.NgayTao,hang.MaDanhMuc);
            int effect = dataProvider.ExecuteNonQuery(sql);
            return effect;
        }

        public int SuaBangHang(Hang hang)
        {
            String sql = String.Format("update hang_test set tenhang='{0}', thongso='{1}', baohanh={2}, soluong={3}," +
                " gia={4},nhasanxuat='{5}',madanhmuc={6} where mahang={7}",hang.TenHang,hang.ThongSo,hang.BaoHanh,hang.SoLuong,
                hang.Gia,hang.NhaSanXuat,hang.MaDanhMuc,hang.MaHang);
            int effect = dataProvider.ExecuteNonQuery(sql);
            return effect;
        }

        public int XoaDLBangHang(int mahang)
        {
            String sql = String.Format("delete from hang_test where mahang = {0}", mahang);
            int effect = dataProvider.ExecuteNonQuery(sql);
            return effect;
        }
    }
}
