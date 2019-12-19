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
    public partial class frm_NhapHang : Form
    {
	    private BUS_NhapHang bus_nhaphang = BUS_NhapHang.Instance;
        private DataTable hang;
        public frm_NhapHang()
        {
            InitializeComponent();
        }

        private void BtnGioNhapHang_Click(object sender, EventArgs e)
        {
            frm_ChiTietPhieuNhap form_ChiTietPhieuNhap = new frm_ChiTietPhieuNhap();
            form_ChiTietPhieuNhap.actionReloadHang = this.actionReload;
            form_ChiTietPhieuNhap.ShowDialog();
            btnGioNhapHang.Text = String.Format("Phiếu nhập ({0})", listhang.Count);
        }

        private void frm_NhapHang_Load(object sender, EventArgs e)
        {
            cbSapXep.SelectedIndex = 0;

            BuocDLVaoCombobox_Danhmuc();
            DLTrenTungTrang_NhapHang((int)cbLocDanhMuc.SelectedValue);
            hang = bus_nhaphang.Hang();
        }

        private void BuocDLVaoCombobox_Danhmuc()
        {
            DataTable danhmuc = bus_nhaphang.DanhMuc();

            DataRow danhmuc_newrow = danhmuc.NewRow();
            danhmuc_newrow["madm"] = 0;
            danhmuc_newrow["tendanhmuc"] = "Tất cả danh mục";
            danhmuc.Rows.InsertAt(danhmuc_newrow, 0);

            cbLocDanhMuc.SelectedValue = 0;
            cbLocDanhMuc.DataSource = danhmuc;
            cbLocDanhMuc.ValueMember = "madm";
            cbLocDanhMuc.DisplayMember = "tendanhmuc";
        }

        private void DLTrenTungTrang_NhapHang(int madanhmuc)
        {
            if (madanhmuc > 0)
            {
                dgvDanhSachHang.DataSource = bus_nhaphang.DLTrenTungTrang_NhapHang_TheoMadanhmuc(madanhmuc);
                txtTrang.Text = bus_nhaphang.currentPage.ToString();
                lblTongTrang.Text = "/" + bus_nhaphang.pageNumber.ToString();
            }
            else
            {
                dgvDanhSachHang.DataSource = bus_nhaphang.DLTrenTungTrang_NhapHang();
                txtTrang.Text = bus_nhaphang.currentPage.ToString();
                lblTongTrang.Text = "/" + bus_nhaphang.pageNumber.ToString();
            }

            dgvDanhSachHang.Columns["ThongSo"].Visible = false;
            dgvDanhSachHang.Columns["BaoHanh"].Visible = false;
            //dgvDanhSachHang.Columns["SoLuong"].Visible = false;
            dgvDanhSachHang.Columns["Hinh"].Visible = false;
            dgvDanhSachHang.Columns["NhaSanXuat"].Visible = false;
            dgvDanhSachHang.Columns["NgayTao"].Visible = false;
            dgvDanhSachHang.Columns["Madanhmuc"].Visible = false;
            dgvDanhSachHang.Columns["Tendanhmuc"].Visible = false;
        }

        private void cbLocDanhMuc_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int madanhmuc = Convert.ToInt32(cbLocDanhMuc.SelectedValue);
                DLTrenTungTrang_NhapHang(madanhmuc);
            }
            catch(InvalidCastException ex) { }
        }


        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (bus_nhaphang.currentPage - 1 <= 0)
            {
                return;
            }else
            {
                bus_nhaphang.currentPage--;
                DLTrenTungTrang_NhapHang((int)cbLocDanhMuc.SelectedValue);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (bus_nhaphang.currentPage +1 >bus_nhaphang.pageNumber)
            {
                return;
            }
            else
            {
                bus_nhaphang.currentPage++;
                DLTrenTungTrang_NhapHang((int)cbLocDanhMuc.SelectedValue);
            }
        }

        private void cbSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbSapXep.SelectedIndex;
            switch (index)
            {
                case 0: dgvDanhSachHang.Sort(dgvDanhSachHang.Columns["mahang"], ListSortDirection.Ascending); break;
                case 1: dgvDanhSachHang.Sort(dgvDanhSachHang.Columns["gia"], ListSortDirection.Descending);break;
                case 2: dgvDanhSachHang.Sort(dgvDanhSachHang.Columns["gia"], ListSortDirection.Ascending);break;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            String timkiem = txtTimKiem.Text;
            DataView dataView = new DataView(hang);
            try
            {
                int mahang = Int32.Parse(timkiem);
                dataView.RowFilter = String.Format("Mahang = {0}", mahang);
                dgvDanhSachHang.DataSource = dataView;
            }
            catch (FormatException ex)
            {
                dataView.RowFilter = String.Format("Tenhang like '%{0}%'", timkiem);
                dgvDanhSachHang.DataSource = dataView;
            }
        }

        private static Hashtable listhang = new Hashtable();

        private void btnThemVaoGioNhapHang_Click(object sender, EventArgs e)
        {
            int mahang =Convert.ToInt32(dgvDanhSachHang.CurrentRow.Cells[0].Value);
            String tenhang = dgvDanhSachHang.CurrentRow.Cells[1].Value.ToString();
            int soluong = (int)numSoLuong.Value;
            String thongso = dgvDanhSachHang.CurrentRow.Cells["thongso"].Value.ToString();
            int gia = Convert.ToInt32(dgvDanhSachHang.CurrentRow.Cells["gia"].Value);
            String hinh = dgvDanhSachHang.CurrentRow.Cells["hinh"].Value.ToString();
            int baohanh= Convert.ToInt32(dgvDanhSachHang.CurrentRow.Cells["baohanh"].Value);
            int madanhmuc = Convert.ToInt32(dgvDanhSachHang.CurrentRow.Cells["madanhmuc"].Value);
            String ngaytao = DateTime.Now.ToString("yyyy-MM-dd");
            String nhasanxuat = dgvDanhSachHang.CurrentRow.Cells["nhasanxuat"].Value.ToString();

            Hang hang = new Hang(mahang,tenhang,thongso,baohanh,soluong,gia,hinh,nhasanxuat,ngaytao,madanhmuc);
           

            if (listhang.ContainsKey(mahang))
            {
                Hang h=(Hang)listhang[mahang];
                h.SoLuong += soluong;
            }
            else
            {
                listhang.Add(mahang, hang);
            }
            
            btnGioNhapHang.Text =String.Format("Phiếu nhập ({0})", listhang.Count);
        }

        public static Hashtable ListHang()
        {
            return listhang;
        }

        void actionReload()
        {
            DLTrenTungTrang_NhapHang((int)cbLocDanhMuc.SelectedValue);
        }
    }
}
