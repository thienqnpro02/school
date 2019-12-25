using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class BUS_ChiTietPhieuXuat
    {
        private static BUS_ChiTietPhieuXuat instance;
        public static BUS_ChiTietPhieuXuat Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_ChiTietPhieuXuat();
                }
                return instance;
            }
        }

        private BUS_ChiTietPhieuXuat() { }

        public int insert(ChiTietPhieuXuat item)
        {
            return DAO_ChiTietPhieuXuat.Instance.insert(item);
        }
    }
}
