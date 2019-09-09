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
    public class KhachHangBUS
    {
        private static KhachHangBUS instance;

        public static KhachHangBUS Instance 
        {
            get 
            {
                if (instance == null) 
                {
                    instance = new KhachHangBUS();
                }

                return instance;
            }
        }

        private KhachHangBUS() { }

        public List<KhachHang> DanhSach_KhachHang()
        {
            List<KhachHang> ds_KhachHang = new List<KhachHang>();
            DataTable data = KhachHangDAO.Instance.DanhSach_KhachHang();

            foreach (DataRow row in data.Rows) 
            {
                KhachHang item = new KhachHang();

                item.MaKH = row[0].ToString();
                item.TenKH = row[1].ToString();
                item.DiaChi = row[2].ToString();
                item.Email = row[3].ToString();

                ds_KhachHang.Add(item);
            }

            return ds_KhachHang;
        }
    }
}
