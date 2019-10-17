using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DTO;
using BUS;
namespace BanLinhKien
{
    public partial class frm_QuanLyDuLieu : Form
    {
        public frm_QuanLyDuLieu()
        {
            InitializeComponent();
        }

        // variables for dgvHang
        private bool dgvHangLoaded = false;
        private int dgvHangPreviousRow = -1;

        private void TabControlQL_DuLieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControlQL_DuLieu.SelectedTab.Name)
            {
                case "tabDanhMuc":
                    break;
                case "tabHang":
                    dgvHang = configDGVHang(dgvHang);
                    
                    break;
                case "tabNhanVien":
                    break;
                case "tabKhachHang":
                    break;
                case "tabNhaCungCap":
                    break;
            }
        }

        private DataGridView configDGVHang(DataGridView data)
        {
            
            dgvHangLoaded = false;
            DataTable tblHang = HangBUS.Instance.select();
            data.DataSource = HangBUS.Instance.select(); 

            // Ẩn cột            
            data.Columns["THONGSO"].Visible = false;
            data.Columns["BAOHANH"].Visible = false;
            data.Columns["SOLUONG"].Visible = false;
            data.Columns["GIA"].Visible = false;
            data.Columns["HINH"].Visible = false;
            data.Columns["NHASANXUAT"].Visible = false;
            data.Columns["NGAYTAO"].Visible = false;
            data.Columns["MADANHMUC"].Visible = false;

            // chỉnh kích thước cột
            data.Columns["MAHANG"].Width = 75;
            data.Columns["TENHANG"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // chỉnh header text
            data.Columns["MAHANG"].HeaderText = "Mã Hàng";
            data.Columns["TENHANG"].HeaderText = "Tên Hàng";

            if (data.Rows.Count > 0) dgvHangPreviousRow = 0;
            dgvHangLoaded = true;

            // clear binding
            txtIDHang.DataBindings.Clear();

            // binding
            txtIDHang.DataBindings.Add("Text", data.DataSource, "MAHANG");
            txtTenHang.DataBindings.Add("Text", data.DataSource, "TENHANG");
            txtThongSo.DataBindings.Add("Text", data.DataSource, "THONGSO");
            txtNhaSanXuat.DataBindings.Add("Text", data.DataSource, "NHASANXUAT");
            txtBaoHanh.DataBindings.Add("Text", data.DataSource, "BAOHANH");
            txtGia.DataBindings.Add("Text", data.DataSource, "GIA");
            //cbdanhmuc
            txtSoLuong.DataBindings.Add("Text", data.DataSource, "SOLUONG");

            return data;
        }

        

        private void DgvHang_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHangLoaded == false) return;
            

            if(dgvHang.CurrentRow != null && dgvHangPreviousRow != dgvHang.CurrentCell.RowIndex)
            {
                //DataGridViewRow row = dgvHang.CurrentRow as DataGridViewRow;
                //string tabName = tabControlQL_DuLieu.SelectedTab.Name;
                //int idx = dgvHang.CurrentCell.RowIndex;
                //bindingData(idx);
            }
            
        }

       
    }
}
