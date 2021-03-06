﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DAO
{
    public class DAO_DanhMuc
    {
        DataProvider dataProvider = DataProvider.Instance;

        private static DAO_DanhMuc instance;       
        public static DAO_DanhMuc Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAO_DanhMuc();
                }
                return instance;
            }
        }

        private DAO_DanhMuc() { }

        public DataTable BangDanhMuc()
        {
            String sql = "select *from danhmuc";
            DataTable datatable=dataProvider.ExecuteQuery(sql);
            return datatable;
        }

        public int LuuBangDanhMuc(String tendanhmuc,String ngaytao)
        {
            String sql = String.Format("insert into danhmuc(tendanhmuc,ngaytao) values (N'{0}','{1}')", tendanhmuc,ngaytao);
            int effect = dataProvider.ExecuteNonQuery(sql);
            return effect;
        }

        public int SuaBangDanhMuc(int madm, String tendanhmuc)
        {
            String sql = String.Format("update danhmuc set tendanhmuc = N'{0}' where madm = {1}", tendanhmuc, madm);
            int effect = dataProvider.ExecuteNonQuery(sql);
            return effect;
        }

        public int XoaDLBangDanhMuc(int madm)
        {
            String sql = String.Format("delete from danhmuc where madm = {0}", madm);
            int effect = dataProvider.ExecuteNonQuery(sql);
            return effect; 
        }

        public DataTable pagingDangMuc(int currentPage,int pageSize)
        {
            String sql = String.Format("exec PHANTRANG_DANHMUC @currentPage={0},@pageSize={1}",
                currentPage,pageSize);
            DataTable dataTable=dataProvider.ExecuteQuery(sql);
            return dataTable;
        }

        public int rowCount()
        {
            String sql = "Select count(*) from danhmuc";
            int numberRow = Convert.ToInt32(dataProvider.ExecuteScalar(sql));
            return numberRow;
        }

        public int MaDanhMuc()
        {
            String sql = "select ident_current('danhmuc')";
            return Convert.ToInt32(dataProvider.ExecuteScalar(sql));
        }

        public bool isHasManyHang(int maDanhMuc)
        {
            string sql = "select count(*) from HANG where MADANHMUC = @maDanhMuc";

            int res = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(sql, new object[] { maDanhMuc }));

            if (res > 0)
                return true;

            return false;
        }
    }
}
