using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_PhieuNhap
    {
        private DataProvider dataProvider = DataProvider.Instance;
        private static DAO_PhieuNhap instance;

        public static DAO_PhieuNhap Instance
        {
            get
            {
                if (instance == null) instance = new DAO_PhieuNhap();
                return instance;
            }
        }

        public int LuuBangPhieuNhap(PhieuNhap phieunhap)
        {
            String sql = String.Format("insert into phieunhap(ngaytao,mancc,manv) values('{0}',{1},{2})",
                phieunhap.NgayTao, phieunhap.MaNCC,phieunhap.MaNV);
            int effect = dataProvider.ExecuteNonQuery(sql);
            return effect;
        }

        public int MaPhieuNhap()
        {
            String sql = "select ident_current('phieunhap')";
            return Convert.ToInt32(dataProvider.ExecuteScalar(sql));
        }
    }
}
