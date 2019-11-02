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

    }
}
