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

        private HangBUS() { }

        public DataTable select()
        {
            return HangDAO.Instance.select();
        }
    }
}
