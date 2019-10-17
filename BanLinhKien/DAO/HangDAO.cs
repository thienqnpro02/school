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
    }
}
