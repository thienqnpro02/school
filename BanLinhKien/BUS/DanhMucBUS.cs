using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DanhMucBUS
    {
        private static DanhMucBUS instance;

        public static DanhMucBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new DanhMucBUS();
                return instance;
            }
        }

        private DanhMucBUS() { }
    }
}
