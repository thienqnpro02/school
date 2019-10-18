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
    public class HangBUS
    {
        private static HangBUS instance;
        
        public static HangBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new HangBUS();
                return instance;
            }
        }

        public int totalRow = 0;
        public int currentPageHang = 1;
        public int pageSize = 10;

        private HangBUS() {  }

        public DataTable select()
        {
            return HangDAO.Instance.select();
        }

        public DataTable pagingHang()
        {
            this.rowCount();
            return HangDAO.Instance.pagingHang(this.currentPageHang,this.pageSize);
        }

        public void rowCount()
        {
            HangBUS.Instance.totalRow = (int)Math.Ceiling( (double)HangDAO.Instance.rowCount() / this.pageSize );
        }
    }
}
