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
            string sql = "select * from Hang";
            DataTable res = DataProvider.Instance.ExecuteQuery(sql);

            return res;
        }

        public DataTable pagingHang(int currentPage, int pageSize)
        {
            string sql = "exec USP_PagingHang @currentPage , @pageSize";
            DataTable res = DataProvider.Instance.ExecuteQuery(sql, new object[] { currentPage , pageSize });

            return res;
        }

        public int rowCount()
        {
            string sql = "select count(*) from Hang";
            int row = Convert.ToInt32( DataProvider.Instance.ExecuteScalar(sql) );
            return row;
        }
    }
}
