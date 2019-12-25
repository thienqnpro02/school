using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_ChiTietPhieuNhap
    {
        private DataProvider dataProvider = DataProvider.Instance;
        private static DAO_ChiTietPhieuNhap instance;

        public static DAO_ChiTietPhieuNhap Instance
        {
            get
            {
                if (instance == null) instance = new DAO_ChiTietPhieuNhap();
                return instance;
            }
        }

        public int LuuBangChiTietPhieuNhap(ChiTietPhieuNhap ct_phieunhap)
        {
            String sql = String.Format("insert into chitietphieunhap(maphieunhap,mahang,soluong,gianhap) " +
                "values({0},{1},{2},{3})",
                ct_phieunhap.MaPhieuNhap, ct_phieunhap.MaHang, ct_phieunhap.SoLuong, ct_phieunhap.GiaNhap);
            int effect = dataProvider.ExecuteNonQuery(sql);
            return effect;
        }
    }
}
