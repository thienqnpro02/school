using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using DTO;
namespace DAO
{
    public class KhachHangDAO
    {
        private static KhachHangDAO instance;

        public static KhachHangDAO Instance 
        {
            get 
            {
                if (instance == null) 
                {
                    instance = new KhachHangDAO();
                }

                return instance;
            }
        }

        private KhachHangDAO() { }

        public DataTable DanhSach_KhachHang() 
        {
            DataTable data = new DataTable();

            string sql = "select * from KhachHang2";

            data = DataProvider.Instance.ExecuteQuery(sql);

            return data;
        }
    }
}
