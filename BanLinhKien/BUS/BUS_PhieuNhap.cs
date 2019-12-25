using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class BUS_PhieuNhap
    {
        private static BUS_PhieuNhap instance;
        private DAO_PhieuNhap dao_phieunhap = DAO_PhieuNhap.Instance;

        public static BUS_PhieuNhap Instance
        {
            get
            {
                if (instance == null) instance = new BUS_PhieuNhap();
                return instance;
            }
        }

        public int LuuBangPhieuNhap(PhieuNhap phieunhap)
        {
            int effect = dao_phieunhap.LuuBangPhieuNhap(phieunhap);
            return effect;
        }
    }
}
