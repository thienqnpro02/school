using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAO;
using DTO;

namespace DAO
{
    public class DAO_KhachHang
    {
        DataProvider dataProvider = DataProvider.Instance;
        private static DAO_KhachHang instance;
        public static DAO_KhachHang Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAO_KhachHang();
                }
                return instance;
            }
        }

        private DAO_KhachHang() { }

        public DataTable BangKhachHang()
        {
            String sql = "Select *from khachhang";
            DataTable bangkhachhang = dataProvider.ExecuteQuery(sql);
            return bangkhachhang;
        }

        public int RowCount()
        {
            String sql = "Select count(*) from khachhang;";
            int row = Convert.ToInt32(dataProvider.ExecuteScalar(sql));
            return row;
        }

        public DataTable DLTrenMotTrang_KhachHang(int currentPage, int pageSize)
        {
            String sql = String.Format("exec PHANTRANG_KHACHHANG @currentPage={0} , @pageSize={1}",
                currentPage,pageSize);
            DataTable dltrenmottrang_khachhang = dataProvider.ExecuteQuery(sql);
            return dltrenmottrang_khachhang;
        }

        public int LuuBangKhachHang(KhachHang khachhang)
        {
            String sql =String.Format("Insert into khachhang(hoten,sdt,namsinh,ngaytao) values(N'{0}','{1}','{2}','{3}')",
                khachhang.HoTen,khachhang.Sdt,khachhang.NamSinh,khachhang.NgayTao);
            int effect = dataProvider.ExecuteNonQuery(sql);
            return effect;
        }

        public int SuaBangKhachHang(KhachHang khachhang)
        {
            String sql = String.Format("update khachhang set hoten=N'{0}',sdt='{1}',namsinh='{2}' where makh={3}",
                khachhang.HoTen, khachhang.Sdt, khachhang.NamSinh, khachhang.MaKH);
            int effect = dataProvider.ExecuteNonQuery(sql);
            return effect;
        }

        public int XoaBangKhachHang(int makh)
        {
            String sql = String.Format("delete from khachhang where makh = {0}", makh);
            int effect = dataProvider.ExecuteNonQuery(sql);
            return effect;
        }

        public int currentID()
        {
            string sql = "SELECT IDENT_CURRENT('KHACHHANG')";
            return Convert.ToInt32(DataProvider.Instance.ExecuteScalar(sql));
        }

        public DataTable selectByID(List<int> list_id)
        {

            string sql = "select * from KHACHHANG where MAKH in (";
            foreach (int id in list_id)
            {
                sql += id + ",";
            }
            sql = sql.Remove(sql.Length - 1);
            sql += ")";



            return DataProvider.Instance.ExecuteQuery(sql);
        }

    }
}
