using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HangHoa
    {
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public int GiaBanLe { get; set; }
        public int GiaBanBuon { get; set; }

        public HangHoa() { }

        public HangHoa(string mahang, string tenhang, int giabanle, int giabanbuon) 
        {
            this.MaHang = mahang;
            this.TenHang = tenhang;
            this.GiaBanLe = giabanle;
            this.GiaBanBuon = giabanbuon;
            
        }
    }
}
