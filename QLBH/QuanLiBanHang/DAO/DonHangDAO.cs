using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using DTO;
namespace DAO
{
    public class DonHangDAO
    {
        private static DonHangDAO instance;

        public static DonHangDAO Instance 
        {
            get 
            {
                if (instance == null) 
                {
                    instance = new DonHangDAO();
                }

                return instance;
            }
        }

        private DonHangDAO() { }

        public int TongDonHangHomNay()
        {
            string sql = "select COUNT(*) from DonHang where NgayLap = GETDATE()";

            int kq = Convert.ToInt32( DataProvider.Instance.ExecuteScalar(sql) );

            return kq;
        }
    }
}
