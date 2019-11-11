using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class BUS_PhieuXuat
    {
        private static BUS_PhieuXuat instance;
        public static BUS_PhieuXuat Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_PhieuXuat();
                }
                return instance;
            }
        }

        private BUS_PhieuXuat() { }

        public int insert(PhieuXuat item)
        {
            return DAO_PhieuXuat.Instance.insert(item);
        }

        public int currentID()
        {
            return DAO_PhieuXuat.Instance.currentID();
        }
    }
}
