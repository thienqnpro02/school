using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace BanLinhKien
{
    

    public partial class main : Form
    {

        private enum SapXepTheo
        {
            TangDan = 0,
            GiamDan = 1,            
            MacDinh = 2
        }

        // variables for cbSapXep
        bool cbSapXepLoaded = false;

        // variables for cbDanhMuc
        bool cbDanhMucLoaded = false;
        DataTable dt_danhmuc;

        // variables for dgvDanHSachHang
        private int currentPageHang = 1;
        private DataTable dt_hang;
        public Hashtable items_picked = new Hashtable();

        public main()
        {
            InitializeComponent();
            initializeData();
        }

        void initializeData()
        {
            Hashtable sapXepTheo = new Hashtable() {                
                { 0, "Giá tăng dần" },                
                { 1, "Giá giảm dần"},
                { 2, "Mặc định" }
            };

            cbSapXep.DataSource = new BindingSource(sapXepTheo,null);
            cbSapXep.DisplayMember = "Value";
            cbSapXep.ValueMember = "Key";
            cbSapXepLoaded = true;

            dt_danhmuc = BUS_DanhMuc.Instance.BangDanhMuc();
            DataRow row_danhmuc = dt_danhmuc.NewRow();
            row_danhmuc["MADM"] = -1;
            row_danhmuc["TENDANHMUC"] = "Tất cả danh mục";
            dt_danhmuc.Rows.InsertAt(row_danhmuc, 0);
            cbDanhMuc.DataSource = dt_danhmuc;
            cbDanhMuc.DisplayMember = "TenDanhMuc";
            cbDanhMuc.ValueMember = "MaDM";            
            cbDanhMucLoaded = true;

            loadHang();



            updatePagingText();

        }

        void loadHang()
        {
            dt_hang = BUS_Hang.Instance.pagingHang(currentPageHang);
            dgvDanhSachHang.DataSource = dt_hang;

            // Ẩn cột            
            dgvDanhSachHang.Columns["THONGSO"].Visible = false;
            dgvDanhSachHang.Columns["BAOHANH"].Visible = false;
            dgvDanhSachHang.Columns["SOLUONG"].Visible = false;
            dgvDanhSachHang.Columns["HINH"].Visible = false;
            dgvDanhSachHang.Columns["NHASANXUAT"].Visible = false;
            dgvDanhSachHang.Columns["NGAYTAO"].Visible = false;
            dgvDanhSachHang.Columns["MADANHMUC"].Visible = false;
            dgvDanhSachHang.Columns["TENDANHMUC"].Visible = false;

            // chỉnh kích thước cột
            dgvDanhSachHang.Columns["MAHANG"].Width = 75;
            dgvDanhSachHang.Columns["GIA"].Width = 135;
            dgvDanhSachHang.Columns["TENHANG"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // chỉnh header text
            dgvDanhSachHang.Columns["MAHANG"].HeaderText = "Mã Hàng";
            dgvDanhSachHang.Columns["GIA"].HeaderText = "Giá";
            dgvDanhSachHang.Columns["TENHANG"].HeaderText = "Tên Hàng";
        }

        void updatePagingText()
        {
            lblTongTrang.Text = "/" + BUS_Hang.Instance.totalPage;
            txtTrang.Text = currentPageHang.ToString();
        }

        private void Ql_DuLieuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_QuanLyDuLieu form_QuanLyDuLieu = new frm_QuanLyDuLieu();
            form_QuanLyDuLieu.ShowDialog();
        }

        private void NhapHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_NhapHang form_NhapHang = new frm_NhapHang();
            form_NhapHang.ShowDialog();
        }

        private void ThongKeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ThongKe form_ThongKe = new frm_ThongKe();
            form_ThongKe.ShowDialog();
        }

        private void ĐổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CaNhan form_CaNhan = new frm_CaNhan();
            form_CaNhan.ShowDialog();
        }

        private void BtnGioHang_Click(object sender, EventArgs e)
        {
            frm_GioHang form_GioHang = new frm_GioHang();
            form_GioHang.items_picked = this.items_picked;
            form_GioHang.ShowDialog();
            btnGioHang.Text = String.Format("Giỏ hàng ({0})", items_picked.Count);
        }

        private void CbSapXep_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!cbSapXepLoaded) return;
            sortHang((int)cbSapXep.SelectedValue);
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            int maDM = Convert.ToInt32(cbDanhMuc.SelectedValue);
            if (currentPageHang + 1 > BUS_Hang.Instance.totalPage)
                return;
            else if(maDM == -1)
            {
                currentPageHang++;
                dt_hang = BUS_Hang.Instance.pagingHang(currentPageHang);
                dgvDanhSachHang.DataSource = dt_hang;               
                
            }
            else
            {
                currentPageHang++;
                dt_hang = BUS_Hang.Instance.pagingHangByMaDM(currentPageHang, maDM);
                dgvDanhSachHang.DataSource = dt_hang;
               
            }

            updatePagingText();
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            int maDM = Convert.ToInt32(cbDanhMuc.SelectedValue);
            if (currentPageHang -1 <= 0)
                return;
            else if(maDM == -1)
            {
                currentPageHang--;
                dt_hang = BUS_Hang.Instance.pagingHang(currentPageHang);
                dgvDanhSachHang.DataSource = dt_hang;                

            }
            else
            {
                currentPageHang--;
                dt_hang = BUS_Hang.Instance.pagingHangByMaDM(currentPageHang, maDM);
                dgvDanhSachHang.DataSource = dt_hang;
            }

            updatePagingText();
        }

        void searchHang()
        {
            DataView dv = new DataView(dt_hang);
            dv.RowFilter = String.Format("TenHang like '%{0}%'", txtTimKiem.Text);
            dgvDanhSachHang.DataSource = dv;
        }

        void sortHang(int sortType)
        {
            
            DataView dv = new DataView(dt_hang);
            
            switch (sortType)
            {
                case (int)SapXepTheo.GiamDan:
                    dv.Sort = "GIA DESC";                    
                    break;
                case (int)SapXepTheo.TangDan:
                    dv.Sort = "GIA ASC";
                    break;
                case (int)SapXepTheo.MacDinh:
                    dv.Sort = "MAHANG ASC";
                    break;
            }
            
            dgvDanhSachHang.DataSource = dv;
        }

        private void TxtTimKiem_TextChanged(object sender, EventArgs e)
        {
            searchHang();
        }       

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            searchHang();
        }

        private void BtnThemVaoGio_Click(object sender, EventArgs e)
        {
            string idHang = dgvDanhSachHang.CurrentRow.Cells["MAHANG"].Value.ToString();
            int soLuong = Convert.ToInt32(numSoLuong.Value);
            if (items_picked.ContainsKey(idHang))
            {
                
                items_picked[idHang] = Convert.ToInt32(items_picked[idHang]) + soLuong;
            }
            else
            {
                items_picked.Add(idHang, soLuong);
            }

            btnGioHang.Text = String.Format("Giỏ hàng ({0})", items_picked.Count);
            
            
        }

        private void CbDanhMuc_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!cbDanhMucLoaded) return;

            currentPageHang = 1;
            int maDM = Convert.ToInt32(cbDanhMuc.SelectedValue);

            if (maDM == -1)
            {
                dt_hang = BUS_Hang.Instance.pagingHang(currentPageHang);
                dgvDanhSachHang.DataSource = dt_hang;
            }
            else
            {
                dt_hang = BUS_Hang.Instance.pagingHangByMaDM(currentPageHang, maDM);
                dgvDanhSachHang.DataSource = dt_hang;
            }            

            updatePagingText();
        }

        private void ĐăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien.client = null;
            frm_DangNhap frm_login = new frm_DangNhap();
            frm_login.Show();
            this.Close();
            
        }

        void setClientPermission()
        {
            switch (NhanVien.client.LoaiNhanVien)
            {
                case (int)NhanVien.E_LoaiNhanVien.QUANLY:
                    break;
                case (int)NhanVien.E_LoaiNhanVien.NV_BanHang:
                    menuStrip.Items["ql_DuLieuToolStripMenuItem"].Visible = false;
                    menuStrip.Items["nhapHangToolStripMenuItem"].Visible = false;
                    break;
                case (int)NhanVien.E_LoaiNhanVien.NV_TinHoc:
                    break;
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            setClientPermission();
        }
    }
}

