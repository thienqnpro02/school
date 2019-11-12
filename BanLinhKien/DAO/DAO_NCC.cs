using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class DAO_NCC
    {
        DataProvider dataProvider = DataProvider.Instance;

        private static DAO_NCC instance;
        public static DAO_NCC Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAO_NCC();
                }
                return instance;
            }
        }

        private DAO_NCC() { }

        public DataTable BangNCC()
        {
            String sql = "Select *from nhacungcap";
            DataTable ncc = dataProvider.ExecuteQuery(sql);
            return ncc;
        }

        public DataTable DLTrenTungTrang_NCC(int currentPage, int pageSize)
        {
            String sql =String.Format("exec PHANTRANG_NCC @currentPage={0},@pageSize={1}",currentPage,pageSize);
            DataTable dlncctrentungtrang_ncc = dataProvider.ExecuteQuery(sql);
            return dlncctrentungtrang_ncc;
        }

        public int RowCount()
        {
            String sql = "Select count(*) from nhacungcap";
            int effect = Convert.ToInt32(dataProvider.ExecuteScalar(sql));
            return effect;
        }

        public int LuuBangNhaCungCap(NhaCungCap ncc)
        {
            String sql = String.Format("insert into nhacungcap(tenncc,diachi,fax,email,ngaytao) values(N'{0}',N'{1}',N'{2}',N'{3}','{4}')",
                ncc.TenNCC, ncc.DiaChi, ncc.Fax, ncc.Email, ncc.NgayTao);
            int effect = dataProvider.ExecuteNonQuery(sql);
            return effect;
        }

        public int SuuBangNhaCungCap(NhaCungCap ncc)
        {
            String sql =String.Format("update nhacungcap set tenncc=N'{0}',diachi=N'{1}',fax='{2}',email='{3}' where mancc = {4}",
                ncc.TenNCC,ncc.DiaChi,ncc.Fax,ncc.Email,ncc.MaNCC);
            int effect = dataProvider.ExecuteNonQuery(sql);
            return effect;
        }

        public int XoaDLBangNhaCungCap(int mancc)
        {
            String sql = String.Format("delete from nhacungcap where mancc={0}", mancc);
            int effect = dataProvider.ExecuteNonQuery(sql);
            return effect;
        }

        public int MaNCC()
        {
            String sql = "select ident_current('nhacungcap')";
            return Convert.ToInt32(dataProvider.ExecuteScalar(sql));
        }
    }
}
