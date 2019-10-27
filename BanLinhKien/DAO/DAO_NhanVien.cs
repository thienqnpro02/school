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
    public class DAO_NhanVien
    {
        DataProvider dataProvider = DataProvider.Instance;
        public DataTable BangNhanVien()
        {
            String sql = "select *from nhanvien";
            DataTable nhanvien = dataProvider.ExecuteQuery(sql);
            return nhanvien;
        }

        public DataTable DLTrenMotTrang_NhanVien(int currentPage,int pageSize)
        {
            String sql = String.Format("exec PHANTRANG_NHANVIEN @currentPage = {0}, @pageSize = {1}", currentPage, pageSize);
            DataTable trang_nhanvien = dataProvider.ExecuteQuery(sql);
            return trang_nhanvien;
        }

        public int RowCount()
        {
            String sql = "select count(*) from nhanvien";
            int row =Convert.ToInt32(dataProvider.ExecuteScalar(sql));
            return row;
        }

        public int LuuBangNhanVien(NhanVien nhanvien)
        {
            String sql = String.Format("insert into nhanvien(username,password,hoten,sdt,diachi,namsinh,loainhanvien,gioitinh,ngaytao)" +
                " values('{0}','{1}','{2}','{3}','{4}','{5}',{6},{7},'{8}')",
                nhanvien.Username, nhanvien.Password, nhanvien.HoTen, nhanvien.Sdt, nhanvien.DiaChi, nhanvien.NamSinh,
                nhanvien.LoaiNhanVien, nhanvien.GioiTinh, nhanvien.NgayTao);
            int effect = dataProvider.ExecuteNonQuery(sql);
            return effect;
        }

        public int XoaDlBangNhanVien(int manv)
        {
            String sql = String.Format("delete from nhanvien where manv = {0}", manv);
            int effect = dataProvider.ExecuteNonQuery(sql);
            return effect;
        }

        public int CapNhapBangNhanVien(NhanVien nhanvien)
        {
            String sql = String.Format("update nhanvien set hoten='{0}',username='{1}',password='{2}',sdt='{3}'," +
                "diachi='{4}',namsinh='{5}',loainhanvien={6},gioitinh={7},ngaytao='{8}' where manv ={9}",
                nhanvien.HoTen, nhanvien.Username, nhanvien.Password, nhanvien.Sdt, nhanvien.DiaChi, nhanvien.NamSinh,
               nhanvien.LoaiNhanVien, nhanvien.GioiTinh, nhanvien.NgayTao, nhanvien.MaNV);
            int effect = dataProvider.ExecuteNonQuery(sql);
            return effect;
        }


        
    }
}
