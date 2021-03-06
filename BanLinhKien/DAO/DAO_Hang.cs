﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using System.Collections;

namespace DAO
{
    public class DAO_Hang
    {
        DataProvider dataProvider = DataProvider.Instance;
        private static DAO_Hang instance;

        public static DAO_Hang Instance
        {
            get
            {
                if (instance == null)
                     instance = new DAO_Hang();
                return instance;
            }
        }

        private DAO_Hang() { }

        public DataTable select()
        {
            string sql = "select * from Hang";
            DataTable res = DataProvider.Instance.ExecuteQuery(sql);

            return res;
        }

        public DataTable pagingHang(int currentPage, int pageSize)
        {
            string sql = "exec dbo.USP_PagingHang @currentPage , @pageSize";
            DataTable res = DataProvider.Instance.ExecuteQuery(sql, new object[] { currentPage , pageSize });
            return res;
        }

        public DataTable pagingHangByMaDM(int currentPage, int pageSize, int maDM)
        {            
            string sql = "exec USP_PagingHangByMaDM @currentPage , @pageSize , @maDM";
            DataTable res = DataProvider.Instance.ExecuteQuery(sql, new object[] { currentPage, pageSize, maDM });
            return res;
        }        

        public int rowCount()
        {
            string sql = "select count(*) from Hang";
            int row = Convert.ToInt32( DataProvider.Instance.ExecuteScalar(sql) );
            return row;
        }
        public int rowCountByMaDM(int maDM)
        {
            string sql = "select count(*) from Hang where MADANHMUC = @madm";
            int totalRow = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(sql,new object[] { maDM }));
            return totalRow;
        }

        public int LuuBangHang(Hang hang)
        {
            String sql = "";
            if (hang.Hinh != "")
            {
                sql = String.Format("insert into hang(tenhang,thongso,baohanh,soluong,gia,nhasanxuat,ngaytao,madanhmuc,hinh) " +
                "values (N'{0}',N'{1}',{2},{3},{4},N'{5}','{6}',{7},'{8}')",
            hang.TenHang, hang.ThongSo, hang.BaoHanh, hang.SoLuong, hang.Gia, hang.NhaSanXuat, hang.NgayTao, hang.MaDanhMuc, hang.Hinh);
            }
            else
            {
                sql = String.Format("insert into hang(tenhang,thongso,baohanh,soluong,gia,nhasanxuat,ngaytao,madanhmuc) " +
                "values (N'{0}',N'{1}',{2},{3},{4},N'{5}','{6}',{7})",
            hang.TenHang, hang.ThongSo, hang.BaoHanh, hang.SoLuong, hang.Gia, hang.NhaSanXuat, hang.NgayTao, hang.MaDanhMuc);
            }
            int effect = dataProvider.ExecuteNonQuery(sql);
            return effect;
        }

        public int SuaBangHang(Hang hang)
        {
            String sql = "";
            if (hang.Hinh != "")
            {
                sql = String.Format("update hang set tenhang=N'{0}', thongso=N'{1}', baohanh={2}, soluong={3}," +
                " gia={4},nhasanxuat=N'{5}',madanhmuc={6}, hinh='{8}' where mahang={7}", hang.TenHang, hang.ThongSo, hang.BaoHanh, hang.SoLuong,
                hang.Gia, hang.NhaSanXuat, hang.MaDanhMuc, hang.MaHang, hang.Hinh);
            }
            else
            {
                sql = String.Format("update hang set tenhang=N'{0}', thongso=N'{1}', baohanh={2}, soluong={3}," +
               " gia={4},nhasanxuat=N'{5}',madanhmuc={6} where mahang={7}", hang.TenHang, hang.ThongSo, hang.BaoHanh, hang.SoLuong,
               hang.Gia, hang.NhaSanXuat, hang.MaDanhMuc, hang.MaHang);
            }
            
            int effect = (int)dataProvider.ExecuteNonQuery(sql);
            return effect;
        }

        public int XoaDLBangHang(int mahang)
        {
            String sql = String.Format("delete from hang where mahang = {0}", mahang);
            int effect = dataProvider.ExecuteNonQuery(sql);
            return effect;
        }

        public bool isExistsImage(string fileName)
        {
            string sql = string.Format("select count(*) from hang where hinh like '{0}'",fileName);
            int res = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(sql));
            if (res > 0)
                return true;
            return false;
        }

        public DataTable selectByID(List<int> list_id)
        {
            
            string sql = "select * from hang where MAHANG in (";
            foreach(int id in list_id)
            {
                sql += id + ",";
            }
            sql = sql.Remove(sql.Length - 1);
            sql += ")";
            
            return DataProvider.Instance.ExecuteQuery(sql);
        }

        public DataTable selectByMaDM(List<int> list_id)
        {
            string sql = "select * from hang where MADANHMUC in (";
            foreach (int id in list_id)
            {
                sql += id + ",";
            }
            sql = sql.Remove(sql.Length - 1);
            sql += ")";

            return DataProvider.Instance.ExecuteQuery(sql);
        }

        public int updateSoLuongHang(int maHang, int soLuong)
        {
            string sql = "update Hang set SOLUONG -= @soluong where MAHANG = @mahang";
            return Convert.ToInt32(DataProvider.Instance.ExecuteNonQuery(sql, new object[] { soLuong, maHang }));
        }

        public int MaHang()
        {
            String sql = "select ident_current('hang')";
            return Convert.ToInt32(dataProvider.ExecuteScalar(sql));
        }
    }
}
