using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAO;
namespace BUS
{
    public class DonHanBUS
    {
        private static DonHanBUS instance;

        public static DonHanBUS Instance 
        {
            get 
            {
                if (instance == null) 
                {
                    instance = new DonHanBUS();
                }

                return instance;
            }
        }

        private DonHanBUS() { }

        public int TongDonHangHomNay() 
        {
            return DonHangDAO.Instance.TongDonHangHomNay();
        }

        public string TaoMaDH() 
        {
            string maDH = "DHL_{0}_{1}";
            int tongDH = DonHangDAO.Instance.TongDonHangHomNay() +1;
            return string.Format(maDH, DateTime.Now.ToShortDateString(), tongDH);
        }
    }
}
