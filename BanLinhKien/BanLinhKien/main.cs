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
            GiamDan = 0,
            TangDan = 1
        }

        // variables for cbSapXep
        bool cbSapXepLoaded = false;

        // variables for cbDanhMuc
        bool cbDanhMucLoaded = false;

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
                { 0, "Giảm dần"},
                { 1, "Tăng dần" }
            };

            cbSapXep.DataSource = new BindingSource(sapXepTheo,null);
            cbSapXep.DisplayMember = "Value";
            cbSapXep.ValueMember = "Key";
            cbSapXepLoaded = true;

            cbDanhMuc.DataSource = BUS_DanhMuc.Instance.BangDanhMuc();
            cbDanhMuc.DisplayMember = "TenDanhMuc";
            cbDanhMuc.ValueMember = "MaDM";
            cbDanhMucLoaded = true;

           
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

        private void CaNhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
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
        }

        private void CbSapXep_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!cbSapXepLoaded) return;
            MessageBox.Show(cbSapXep.SelectedValue.ToString());
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (currentPageHang + 1 > BUS_Hang.Instance.totalPage)
                return;
            else
            {
                currentPageHang++;
                dt_hang = BUS_Hang.Instance.pagingHang(currentPageHang);
                dgvDanhSachHang.DataSource = dt_hang;
                txtTrang.Text = currentPageHang.ToString();
                lblTongTrang.Text = "/" + BUS_Hang.Instance.totalPage;
                
            }
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            if (currentPageHang -1 <= 0)
                return;
            else
            {
                currentPageHang--;
                dt_hang = BUS_Hang.Instance.pagingHang(currentPageHang);
                dgvDanhSachHang.DataSource = dt_hang;
                txtTrang.Text = currentPageHang.ToString();
                lblTongTrang.Text = "/" + BUS_Hang.Instance.totalPage;

            }
        }

        void searchHang()
        {
            DataView dv = new DataView(dt_hang);
            dv.RowFilter = String.Format("TenHang like '%{0}%'", txtTimKiem.Text);
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

            
            
        }
    }
}

