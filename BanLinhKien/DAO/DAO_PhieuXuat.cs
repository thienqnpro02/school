using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class DAO_PhieuXuat
    {
        private static DAO_PhieuXuat instance;
        public static DAO_PhieuXuat Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAO_PhieuXuat();
                }
                return instance;
            }
        }

        private DAO_PhieuXuat() { }

        public int insert(PhieuXuat item)
        {
            string sql = String.Format("insert into PhieuXuat values({0},GETDATE(),{1})", item.MaKH, item.MaNV);
            int res = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { item.MaKH, item.MaNV });

            return res;
        }

        public int currentID()
        {
            string sql = "SELECT IDENT_CURRENT('PHIEUXUAT')";
            return Convert.ToInt32(DataProvider.Instance.ExecuteScalar(sql));
        }
    }
}
