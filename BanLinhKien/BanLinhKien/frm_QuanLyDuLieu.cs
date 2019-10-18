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
                    configDGVHang();
                    
                    break;
                case "tabNhanVien":
                    break;
                case "tabKhachHang":
                    break;
                case "tabNhaCungCap":
                    break;
            }
        }

        private void configDGVHang()
        {
            
            dgvHangLoaded = false;

            dgvHang.DataSource = HangBUS.Instance.pagingHang();

            // Ẩn cột            
            dgvHang.Columns["THONGSO"].Visible = false;
            dgvHang.Columns["BAOHANH"].Visible = false;
            dgvHang.Columns["SOLUONG"].Visible = false;
            dgvHang.Columns["GIA"].Visible = false;
            dgvHang.Columns["HINH"].Visible = false;
            dgvHang.Columns["NHASANXUAT"].Visible = false;
            dgvHang.Columns["NGAYTAO"].Visible = false;
            dgvHang.Columns["MADANHMUC"].Visible = false;

            // chỉnh kích thước cột
            dgvHang.Columns["MAHANG"].Width = 75;
            dgvHang.Columns["TENHANG"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // chỉnh header text
            dgvHang.Columns["MAHANG"].HeaderText = "Mã Hàng";
            dgvHang.Columns["TENHANG"].HeaderText = "Tên Hàng";

            if (dgvHang.Rows.Count > 0) dgvHangPreviousRow = 0;
            dgvHangLoaded = true;           

            // paging

            txtTongTrangHang.Text = "/" + HangBUS.Instance.totalRow;
            txtTrangHang.Text = HangBUS.Instance.currentPageHang.ToString();
            bindingHang();
        }

        private void bindingHang()
        {
            // clear binding
            txtIDHang.DataBindings.Clear();
            txtTenHang.DataBindings.Clear();
            txtThongSo.DataBindings.Clear();
            txtNhaSanXuat.DataBindings.Clear();
            txtBaoHanh.DataBindings.Clear();
            txtGia.DataBindings.Clear();
            txtSoLuong.DataBindings.Clear();

            // binding
            txtIDHang.DataBindings.Add("Text", dgvHang.DataSource, "MAHANG");
            txtTenHang.DataBindings.Add("Text", dgvHang.DataSource, "TENHANG");
            txtThongSo.DataBindings.Add("Text", dgvHang.DataSource, "THONGSO");
            txtNhaSanXuat.DataBindings.Add("Text", dgvHang.DataSource, "NHASANXUAT");
            txtBaoHanh.DataBindings.Add("Text", dgvHang.DataSource, "BAOHANH");
            txtGia.DataBindings.Add("Text", dgvHang.DataSource, "GIA");
            //cbdanhmuc
            txtSoLuong.DataBindings.Add("Text", dgvHang.DataSource, "SOLUONG");
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

        private void BtnPrevDM_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnNextDM_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnNextHang_Click(object sender, EventArgs e)
        {
            if (HangBUS.Instance.currentPageHang + 1 > HangBUS.Instance.totalRow)
                return;
            else
            {
                HangBUS.Instance.currentPageHang++;                
                dgvHang.DataSource = HangBUS.Instance.pagingHang();
                txtTrangHang.Text = HangBUS.Instance.currentPageHang.ToString();
                bindingHang();
            }
        }

        private void BtnPrevHang_Click(object sender, EventArgs e)
        {
            if (HangBUS.Instance.currentPageHang - 1 <= 0)
                return;
            else
            {
                HangBUS.Instance.currentPageHang--;               
                dgvHang.DataSource = HangBUS.Instance.pagingHang();
                txtTrangHang.Text = HangBUS.Instance.currentPageHang.ToString();
                bindingHang();
            }
        }
    }
}
