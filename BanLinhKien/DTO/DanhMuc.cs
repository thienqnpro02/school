using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DanhMuc
    {
        public String Madm { get; set; }
        public String Tendm { get; set; }

        public DanhMuc() { }

        public DanhMuc(String Madm,String Tendm)
        {
            this.Madm = Madm;
            this.Tendm = Tendm;
        }
    }
}
