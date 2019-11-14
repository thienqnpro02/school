using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class BUS_ChiTietPhieuNhap
    {
        private static BUS_ChiTietPhieuNhap instance;
        private DAO_ChiTietPhieuNhap chitietphieunhap = DAO_ChiTietPhieuNhap.Instance;
        private DAO_PhieuNhap dao_phieunhap = DAO_PhieuNhap.Instance;
        private DAO_Hang dao_hang = DAO_Hang.Instance;

        public static BUS_ChiTietPhieuNhap Instance
        {
            get
            {
                if (instance == null)
                    instance = new BUS_ChiTietPhieuNhap();
                return instance;
            }
        }

        public int LuuBangChiTietPhieuNhap(ChiTietPhieuNhap ct_phieunhap)
        {
            int effect = chitietphieunhap.LuuBangChiTietPhieuNhap(ct_phieunhap);
            return effect;
        }

        public int MaPhieuNhap()
        {
            return dao_phieunhap.MaPhieuNhap();
        }

        public int CapNhapSoLuongHang(ChiTietPhieuNhap hangnhap)
        {
            return dao_hang.updateSoLuongHang(hangnhap.MaHang,hangnhap.SoLuong);
        }

    }
}
