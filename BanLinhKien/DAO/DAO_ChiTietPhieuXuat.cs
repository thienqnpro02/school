using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class DAO_ChiTietPhieuXuat
    {
        private static DAO_ChiTietPhieuXuat instance;
        public static DAO_ChiTietPhieuXuat Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAO_ChiTietPhieuXuat();
                }
                return instance;
            }
        }

        private DAO_ChiTietPhieuXuat() { }

        public int insert(ChiTietPhieuXuat item)
        {
            string sql = String.Format("insert into CHITIETPHIEUXUAT values({0},{1},{2},{3})", item.MaPhieuXuat, item.MaHang, item.SoLuong, item.GiaXuat);

            return DataProvider.Instance.ExecuteNonQuery(sql);
        }
    }
}
