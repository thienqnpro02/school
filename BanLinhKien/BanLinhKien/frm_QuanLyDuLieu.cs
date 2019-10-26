using System;
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
    public partial class frm_QuanLyDuLieu : Form
    {
        BUS_DanhMuc busDanhmuc = new BUS_DanhMuc();
        DataTable datatable_Danhmuc = new DataTable();
        int danhmucdaxoa = 0;
        
        // variables for dgvHang
        private bool dgvHangLoaded = false;
        private int dgvHangPreviousRow = -1;
        public frm_QuanLyDuLieu()
        {
            InitializeComponent();
        }

        private void frm_QuanLyDuLieu_Load(object sender, EventArgs e)
        {
            if (tabControlQL_DuLieu.SelectedIndex == 0)
            {
                CapNhapLaiDLTrenForm();
            }
        }
        private void CapNhapLaiDLTrenForm()
        {
            datatable_Danhmuc = busDanhmuc.pagingHang();
            Load_BangDanhMuc();
        }

        private void Load_BangDanhMuc()
        {
            dgvDanhMuc.DataSource = datatable_Danhmuc;
            BuocDlVaoCacDieuKhien();

            txtTrangDM.Text = busDanhmuc.currentPage.ToString();
            lblTongTrangDM.Text = "/" + busDanhmuc.pageNumber.ToString();
        }

        private void btnTimDM_Click(object sender, EventArgs e)
        {
            Search_Danhmuc(txtTimKiemDM.Text);
        }

        private void Search_Danhmuc(String timkiem)
        {
            DataView dataView = new DataView(datatable_Danhmuc);
            try
            {
                int madm = Int32.Parse(timkiem);
                dataView.RowFilter = String.Format("Madm = {0}", madm);
                dgvDanhMuc.DataSource = dataView;
                BuocDlVaoCacDieuKhien();
            }catch(FormatException ex)
            {
                dataView.RowFilter = String.Format("Tendanhmuc like '%{0}%'", timkiem);
                dgvDanhMuc.DataSource = dataView;
                BuocDlVaoCacDieuKhien();
            }
        }

        private void BuocDlVaoCacDieuKhien()
        {
            txtIDDanhMuc.DataBindings.Clear();
            txtTenDanhMuc.DataBindings.Clear();

            txtIDDanhMuc.DataBindings.Add("Text", dgvDanhMuc.DataSource, "madm");
            txtTenDanhMuc.DataBindings.Add("Text", dgvDanhMuc.DataSource, "tendanhmuc");

        }

        private void btnThemDM_Click(object sender, EventArgs e)
        {
            if (btnThemDM.Text.Contains("Th"))
            {
                btnThemDM.Text = "Luu";
                txtIDDanhMuc.Text = (busDanhmuc.rowCount() + danhmucdaxoa).ToString();
                txtTenDanhMuc.Text = "";
            }

            if (txtTenDanhMuc.Text != "")
            {
                MessageBox.Show("khac null");
                int madm = Int32.Parse(txtIDDanhMuc.Text);
                String tendanhmuc = txtTenDanhMuc.Text;
                DataView View = new DataView(datatable_Danhmuc);
                View.RowFilter = String.Format("madm = {0} or tendanhmuc like '%{1}%'", madm, tendanhmuc);

                if (View.Count > 0)
                {
                    MessageBox.Show("Danh muc da ton tai");
                }
                else
                {
                    String ngaytao = DateTime.Now.ToString("yyyy-MM-dd");
                    MessageBox.Show(busDanhmuc.LuuBangDanhMuc(tendanhmuc, ngaytao));
                    CapNhapLaiDLTrenForm();
                    btnThemDM.Text = "Thêm";
                }
            }
        }

        private void btnNextDM_Click(object sender, EventArgs e)
        {
            if(busDanhmuc.currentPage+1> busDanhmuc.pageNumber)
            {
                return;
            }else
            {
                busDanhmuc.currentPage++;
                dgvDanhMuc.DataSource = busDanhmuc.pagingHang();
                CapNhapLaiDLTrenForm();

            }
        }

        private void btnPrevDM_Click(object sender, EventArgs e)
        {
            if (busDanhmuc.currentPage -1 <=0)
            {
                return;
            }
            else
            {
                busDanhmuc.currentPage--;
                dgvDanhMuc.DataSource = busDanhmuc.pagingHang();
                CapNhapLaiDLTrenForm();
            }
        }

        private void btnSuaDM_Click(object sender, EventArgs e)
        {
            int madm = Int32.Parse(txtIDDanhMuc.Text);
            String tendanhmuc = txtTenDanhMuc.Text;
            MessageBox.Show(busDanhmuc.SuaBangDanhMuc(madm, tendanhmuc));
            CapNhapLaiDLTrenForm();
        }

        private void btnXoaDM_Click(object sender, EventArgs e)
        {
            int madm = Int32.Parse(txtIDDanhMuc.Text);
            MessageBox.Show(busDanhmuc.XoaDLBangDanhMuc(madm));
            CapNhapLaiDLTrenForm();
            danhmucdaxoa += 1;
        }
       
        private void dgvDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BuocDlVaoCacDieuKhien();
        }

        
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
                    DLTrenTungTrang_BangNhanVien();
                    break;
                case "tabKhachHang":
                    DLTrenTungTrang_KhachHang();
                    break;
                case "tabNhaCungCap":
                    DLTrenTungTrang_BangNCC();
                    break;
            }
        }
        //hang
        HangBUS bus_hang = HangBUS.Instance;
        int hangdaxoa = 0;
        DataTable datatable_hang = new DataTable();

        private void BuocVaoComboBoxDanhMuc()
        {
            cbDanhMuc.DataSource = busDanhmuc.BangDanhMuc();
            cbDanhMuc.DisplayMember = "Tendanhmuc";
            cbDanhMuc.ValueMember = "madm";
        }

        private void configDGVHang()
        {
         
            dgvHangLoaded = false;

            datatable_hang = HangBUS.Instance.pagingHang();
            dgvHang.DataSource = datatable_hang;

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
            cbDanhMuc.DataBindings.Clear();

            // binding
            txtIDHang.DataBindings.Add("Text", dgvHang.DataSource, "MAHANG");
            txtTenHang.DataBindings.Add("Text", dgvHang.DataSource, "TENHANG");
            txtThongSo.DataBindings.Add("Text", dgvHang.DataSource, "THONGSO");
            txtNhaSanXuat.DataBindings.Add("Text", dgvHang.DataSource, "NHASANXUAT");
            txtBaoHanh.DataBindings.Add("Text", dgvHang.DataSource, "BAOHANH");
            txtGia.DataBindings.Add("Text", dgvHang.DataSource, "GIA");
            //cbdanhmuc
            cbDanhMuc.DataBindings.Add("Text", dgvHang.DataSource, "MADANHMUC");
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

        private void BtnNextHang_Click(object sender, EventArgs e)
        {
            if (HangBUS.Instance.currentPageHang + 1 > HangBUS.Instance.totalRow)
                return;
            else
            {
                HangBUS.Instance.currentPageHang++;                
                dgvHang.DataSource = HangBUS.Instance.pagingHang();
                txtTrangHang.Text = HangBUS.Instance.currentPageHang.ToString();
                txtTongTrangHang.Text ="/" +bus_hang.totalRow;
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
                txtTongTrangHang.Text = "/" + bus_hang.totalRow;
                bindingHang();
            }
        }

        private void btnTimKiemHang_Click(object sender, EventArgs e)
        {
            String timkiem=txtTimKiemHang.Text;
            Search_Hang(timkiem);
        }

        private void Search_Hang(String timkiem)
        {
            DataView dataView = new DataView(datatable_hang);
            try
            {
                int mahang = Int32.Parse(timkiem);
                dataView.RowFilter = String.Format("Mahang = {0}", mahang);
                dgvHang.DataSource = dataView;
                bindingHang();
            }
            catch (FormatException ex)
            {
                dataView.RowFilter = String.Format("Tenhang like '%{0}%'", timkiem);
                dgvHang.DataSource = dataView;
                bindingHang();
            }
        }

        private void btnThemHang_Click(object sender, EventArgs e)
        {
            DataTable datatable_hang=bus_hang.select();
            if (btnThemHang.Text.Contains("Th"))
            {
                btnThemDM.Text = "Luu";
                txtIDHang.Text = (bus_hang.Tongsohang() +hangdaxoa).ToString();
                txtTenHang.Text = " ";
                txtBaoHanh.Text = "";
                txtGia.Text = "";
                txtIDDanhMuc.Text = "";
                txtNhaSanXuat.Text = "";
                txtThongSo.Text = "";
                txtSoLuong.Text = "";
                cbDanhMuc.DataBindings.Clear();
                cbDanhMuc.Text = "";
                
            }

            if (txtTenHang.Text != " ")
            {
                int mahang = Int32.Parse(txtIDHang.Text);
                String tenhang = txtTenHang.Text;
                DataView View = new DataView(datatable_hang);
                MessageBox.Show(tenhang + mahang);
                View.RowFilter = String.Format("mahang = {0} or tenhang like '%{1}%'", mahang, tenhang);

                if (View.Count > 0)
                {
                    MessageBox.Show("Hang da ton tai");
                }
                else
                {
                    String tenhang_ = txtTenHang.Text;
                    String thongso = txtThongSo.Text;
                    int baohanh = Int32.Parse(txtBaoHanh.Text);
                    int soluong = Int32.Parse(txtSoLuong.Text);
                    int gia = Int32.Parse(txtGia.Text);
                    String ngaytao = DateTime.Now.ToString("yyyy-MM-dd");
                    String nhasanxuat = txtNhaSanXuat.Text;
                    int madm = (Int32)cbDanhMuc.SelectedValue;

                    Hang hang = new Hang(mahang,tenhang, thongso, baohanh, soluong, gia, nhasanxuat, ngaytao, madm);
                    MessageBox.Show(bus_hang.LuuBangHang(hang));
                    btnThemDM.Text = "Thêm";
                }
            }
        }

        private void btnSuaHang_Click(object sender, EventArgs e)
        {
            int mahang = Int32.Parse(txtIDHang.Text);
            String tenhang_ = txtTenHang.Text;
            String thongso = txtThongSo.Text;
            int baohanh = Int32.Parse(txtBaoHanh.Text);
            int soluong = Int32.Parse(txtSoLuong.Text);
            int gia = Int32.Parse(txtGia.Text);
            String ngaytao = DateTime.Now.ToString("yyyy-MM-dd");
            String nhasanxuat = txtNhaSanXuat.Text;
            int madm = (Int32)cbDanhMuc.SelectedValue;
            MessageBox.Show(madm.ToString());

            Hang hang = new Hang(mahang,tenhang_, thongso, baohanh, soluong, gia, nhasanxuat, ngaytao, madm);
            MessageBox.Show(bus_hang.SuaBangHang(hang));
        }

        private void btnXoaHang_Click(object sender, EventArgs e)
        {
            int mahang = Int32.Parse(txtIDHang.Text);
            MessageBox.Show(bus_hang.XoaDLBangHang(mahang));
        }

        private void cbDanhMuc_Click(object sender, EventArgs e)
        {
            BuocVaoComboBoxDanhMuc();
            cbDanhMuc.DataBindings.Clear();
        }

        //nhanvien
        int nhanviendaxoa = 0;
        BUS_NhanVien bus_nhanvien = new BUS_NhanVien();

        private void DLTrenTungTrang_BangNhanVien()
        {
            dgvNhanVien.DataSource = bus_nhanvien.DlTrenMotTrang_NhanVien();
            BuocDLVaoCacDieuKhien_NhanVien();

            txtTrangNV.Text =bus_nhanvien.currentPage.ToString();
            lblTongTrangNV.Text ="/"+ bus_nhanvien.pageNumber.ToString();
        }

        private void BuocDLVaoCacDieuKhien_NhanVien()
        {
            txtIDNhanVien.DataBindings.Clear();
            txtUsername.DataBindings.Clear();
            txtPassword.DataBindings.Clear();
            txtHoTenNhanVien.DataBindings.Clear();
            txtSDTNhanVien.DataBindings.Clear();
            txtDiaChiNhanVien.DataBindings.Clear();
            dtpkNamSinhNhanVien.DataBindings.Clear();
            cbLoaiNhanVIen.DataBindings.Clear();

            txtIDNhanVien.DataBindings.Add("Text", dgvNhanVien.DataSource, "manv");
            txtUsername.DataBindings.Add("Text", dgvNhanVien.DataSource, "username");
            txtPassword.DataBindings.Add("Text", dgvNhanVien.DataSource, "password");
            txtHoTenNhanVien.DataBindings.Add("Text", dgvNhanVien.DataSource, "hoten");
            txtSDTNhanVien.DataBindings.Add("Text", dgvNhanVien.DataSource, "sdt");
            txtDiaChiNhanVien.DataBindings.Add("Text", dgvNhanVien.DataSource, "diachi");
            dtpkNamSinhNhanVien.DataBindings.Add("Text", dgvNhanVien.DataSource, "namsinh");
            cbLoaiNhanVIen.DataBindings.Add("Text", dgvNhanVien.DataSource, "loainhanvien");

            rdNu.Checked = (bool)dgvNhanVien.CurrentRow.Cells[8].Value;
            rdNam.Checked = !(bool)dgvNhanVien.CurrentRow.Cells[8].Value;
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rdNu.Checked = (bool)dgvNhanVien.CurrentRow.Cells[8].Value;
            rdNam.Checked = !(bool)dgvNhanVien.CurrentRow.Cells[8].Value;
        }

        private void Search_NhanVien(String timkiem)
        {
            DataTable nhanvien = bus_nhanvien.BangNhanVien();
            DataView dataView_nhanvien = new DataView(nhanvien);

            try
            {
                int manv = Int32.Parse(timkiem);
                dataView_nhanvien.RowFilter = String.Format("Manv = {0}", manv);
                dgvNhanVien.DataSource = dataView_nhanvien;
                BuocDLVaoCacDieuKhien_NhanVien();
            }
            catch (FormatException ex)
            {
                dataView_nhanvien.RowFilter = String.Format("hoten like '%{0}%'", timkiem);
                dgvNhanVien.DataSource = dataView_nhanvien;
                BuocDLVaoCacDieuKhien_NhanVien();
            }
        }

        private void btnNextNV_Click(object sender, EventArgs e)
        {
            if (bus_nhanvien.currentPage + 1 > bus_nhanvien.pageNumber)
            {
                return;
            }else
            {
                bus_nhanvien.currentPage++;
                DLTrenTungTrang_BangNhanVien();
            }
        }

        private void btnPrevNV_Click(object sender, EventArgs e)
        {
            if (bus_nhanvien.currentPage - 1 <=0)
            {
                return;
            }
            else
            {
                bus_nhanvien.currentPage--;
                DLTrenTungTrang_BangNhanVien();
            }
        }

        private void btnTimKiemNV_Click(object sender, EventArgs e)
        {
            String timkiem=txtTimKiemNV.Text;
            Search_NhanVien(timkiem);
        }

        private void BuocVaoComboBox_LoaiNhanVien()
        {
            for(int i = 0; i < dgvNhanVien.RowCount-1; i++)
            {
                String loainhanvien = dgvNhanVien.Rows[i].Cells[7].Value.ToString();
                if (!cbLoaiNhanVIen.Items.Contains(loainhanvien))
                {
                    cbLoaiNhanVIen.Items.Add(loainhanvien);
                }
            }
        }

        private void cbLoaiNhanVIen_Click(object sender, EventArgs e)
        {
            BuocVaoComboBox_LoaiNhanVien();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            DataTable datatable_nhanvien = bus_nhanvien.BangNhanVien();
            if (btnThemNV.Text.Contains("Th"))
            {
                txtIDNhanVien.Text =(bus_nhanvien.RowCount()+nhanviendaxoa).ToString();
                txtHoTenNhanVien.Text = "";
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtSDTNhanVien.Text = "";
                txtDiaChiNhanVien.Text = "";
                dtpkNamSinhNhanVien.DataBindings.Clear();
                dtpkNamSinhNhanVien.Text = "";
                cbLoaiNhanVIen.Text = "";
                rdNam.Checked = true;
                btnThemNV.Text = "Luu";
            }

            if (txtHoTenNhanVien.Text != "")
            {
                int manv = Int32.Parse(txtIDNhanVien.Text);
                String tennv = txtHoTenNhanVien.Text;
                DataView View = new DataView(datatable_nhanvien);
                View.RowFilter = String.Format("manv = {0} or hoten like '%{1}%'", manv, tennv);

                if (View.Count > 0)
                {
                    MessageBox.Show("Nhan vien da ton tai");
                }
                else
                {
                    String username = txtUsername.Text;
                    String password = txtPassword.Text;
                    String sdt = txtSDTNhanVien.Text;
                    String diachi = txtDiaChiNhanVien.Text;
                    String namsinh = dtpkNamSinhNhanVien.Value.ToString("yyyy-MM-dd");
                    int loainhanvien = Convert.ToInt32(cbLoaiNhanVIen.Text);
                    int gioitinh = (rdNam.Checked) ? 0 : 1;
                    String ngaytao = DateTime.Now.ToString("yyy-MM-dd");

                    NhanVien nhanvien_ = new NhanVien(manv,username,password,tennv,sdt,diachi,namsinh,loainhanvien,gioitinh,ngaytao);
                    MessageBox.Show(bus_nhanvien.LuuBangNhanVien(nhanvien_));
                    DLTrenTungTrang_BangNhanVien();
                    btnThemNV.Text = "Thêm";
                }
            }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            int manv = Int32.Parse(txtIDNhanVien.Text);
            MessageBox.Show(bus_nhanvien.XoaDLBangNhanVien(manv));
            DLTrenTungTrang_BangNhanVien();
            nhanviendaxoa += 1;
            
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            int manv = Int32.Parse(txtIDNhanVien.Text);
            String tennv = txtHoTenNhanVien.Text;
            String username = txtUsername.Text;
            String password = txtPassword.Text;
            String sdt = txtSDTNhanVien.Text;
            String diachi = txtDiaChiNhanVien.Text;
            String namsinh = dtpkNamSinhNhanVien.Value.ToString("yyyy-MM-dd");
            int loainhanvien = Convert.ToInt32(cbLoaiNhanVIen.Text);
            int gioitinh = (rdNam.Checked) ? 0 : 1;
            String ngaytao = DateTime.Now.ToString("yyy-MM-dd");

            NhanVien nhanvien_ = new NhanVien(manv, username, password, tennv, sdt,
                diachi, namsinh, loainhanvien, gioitinh, ngaytao);

            MessageBox.Show(bus_nhanvien.CapNhapDLBangNhanVien(nhanvien_));
            DLTrenTungTrang_BangNhanVien();
        }

        // khach hang
        int khachhangdaxoa = 0;
        BUS_KhachHang bus_khachhang = new BUS_KhachHang();
        public void DLTrenTungTrang_KhachHang()
        {
            dgvKhachHang.DataSource = bus_khachhang.PhanTrang_KhachHang();
            BuocDlVaoCacDieuKhien_KhachHang();

            txtTrangKH.Text = bus_khachhang.currentPage.ToString();
            lblTongTrangKH.Text = "/" + bus_khachhang.pageNumber;
        }

        public void BuocDlVaoCacDieuKhien_KhachHang()
        {
            txtIDKhachHang.DataBindings.Clear();
            txtHoTenKhachHang.DataBindings.Clear();
            txtSDTKhachHang.DataBindings.Clear();
            dtpkNamSinhKhachHang.DataBindings.Clear();

            txtIDKhachHang.DataBindings.Add("Text",dgvKhachHang.DataSource,"makh");
            txtHoTenKhachHang.DataBindings.Add("Text",dgvKhachHang.DataSource,"hoten");
            txtSDTKhachHang.DataBindings.Add("Text",dgvKhachHang.DataSource,"sdt");
            dtpkNamSinhKhachHang.DataBindings.Add("Text",dgvKhachHang.DataSource,"namsinh");
        }

        private void btnTimKiemKH_Click(object sender, EventArgs e)
        {
            String timkiem = txtTimKiemKH.Text;
            Search_KhachHang(timkiem);
        }

        private void Search_KhachHang(String timkiem)
        {
            DataTable khachhang = bus_khachhang.BangKhachHang();
            DataView dataView_khachhang = new DataView(khachhang);

            try
            {
                int makh = Int32.Parse(timkiem);
                dataView_khachhang.RowFilter = String.Format("Makh = {0}", makh);
                dgvKhachHang.DataSource = dataView_khachhang;
                BuocDlVaoCacDieuKhien_KhachHang();
            }
            catch (FormatException ex)
            {
                dataView_khachhang.RowFilter = String.Format("hoten like '%{0}%'", timkiem);
                dgvKhachHang.DataSource = dataView_khachhang;
                BuocDlVaoCacDieuKhien_KhachHang();
            }
        }

        private void btnNextKH_Click(object sender, EventArgs e)
        {
            if (bus_khachhang.currentPage +1 >bus_khachhang.pageNumber)
            {
                return;
            }else
            {
                bus_khachhang.currentPage++;
                DLTrenTungTrang_KhachHang();
            }
        }

        private void btnPrevKH_Click(object sender, EventArgs e)
        {
            if (bus_khachhang.currentPage -1 <=0)
            {
                return;
            }
            else
            {
                bus_khachhang.currentPage--;
                DLTrenTungTrang_KhachHang();
            }
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            DataTable datatable_khachhang = bus_khachhang.BangKhachHang();
            if (btnThemKH.Text.Contains("Th"))
            {
                txtIDKhachHang.Text = (bus_khachhang.RowCount() + khachhangdaxoa).ToString();
                txtHoTenKhachHang.Text = "";
                txtSDTKhachHang.Text = "";
                dtpkNamSinhKhachHang.DataBindings.Clear();
                dtpkNamSinhKhachHang.Text = "";
                btnThemKH.Text = "Luu";
            }

            if (txtHoTenKhachHang.Text != "")
            {
                int makh = Int32.Parse(txtIDKhachHang.Text);
                String tenkh = txtHoTenKhachHang.Text;
                DataView View = new DataView(datatable_khachhang);
                View.RowFilter = String.Format("makh = {0} or hoten like '%{1}%'", makh, tenkh);

                if (View.Count > 0)
                {
                    MessageBox.Show("Nhan vien da ton tai");
                }
                else
                {
                    String sdtkh = txtSDTKhachHang.Text;
                    String namsinh = dtpkNamSinhKhachHang.Value.ToString("yyyy-MM-dd");
                    String ngaytao = DateTime.Now.ToString("yyyy-MM-dd");
                    
                    KhachHang khachhang = new KhachHang(makh,tenkh,sdtkh,namsinh,ngaytao);
                    MessageBox.Show(bus_khachhang.LuuBangKhachHang(khachhang));
                    DLTrenTungTrang_KhachHang();
                    btnThemKH.Text = "Thêm";
                }
            }
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            int makh = Int32.Parse(txtIDKhachHang.Text);
            String tenkh = txtHoTenKhachHang.Text;
            String sdtkh = txtSDTKhachHang.Text;
            String namsinh = dtpkNamSinhKhachHang.Value.ToString("yyyy-MM-dd");
            String ngaytao = DateTime.Now.ToString("yyyy-MM-dd");

            KhachHang khachhang = new KhachHang(makh, tenkh, sdtkh, namsinh, ngaytao);
            MessageBox.Show(bus_khachhang.SuaBangKhachHang(khachhang));
            DLTrenTungTrang_KhachHang();
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            int makh = Int32.Parse(txtIDKhachHang.Text);
            MessageBox.Show(bus_khachhang.XoaDlBangKhachHang(makh));
            DLTrenTungTrang_KhachHang();
            khachhangdaxoa += 1;
        }

        // nha cung cap

        BUS_NCC bus_ncc = new BUS_NCC();
        int nccdaxoa = 0;
        public void DLTrenTungTrang_BangNCC()
        {
            dgvNhaCungCap.DataSource = bus_ncc.DLTrenTungTrang_NCC();
            BuocDLVaoCacDieuKhien_NCC();
            txtTrangNCC.Text = bus_ncc.currentPage.ToString();
            lblTongTrangNCC.Text = "/"+bus_ncc.pageNumber.ToString();
        }

        private void BuocDLVaoCacDieuKhien_NCC()
        {
            txtIDNCC.DataBindings.Clear();
            txtTenNCC.DataBindings.Clear();
            txtDiaChiNCC.DataBindings.Clear();
            txtFaxNCC.DataBindings.Clear();
            txtEmailNCC.DataBindings.Clear();

            txtIDNCC.DataBindings.Add("Text",dgvNhaCungCap.DataSource,"MANCC");
            txtTenNCC.DataBindings.Add("Text", dgvNhaCungCap.DataSource, "TENNCC");
            txtDiaChiNCC.DataBindings.Add("Text", dgvNhaCungCap.DataSource, "DIACHI"); ;
            txtFaxNCC.DataBindings.Add("Text", dgvNhaCungCap.DataSource, "FAX"); ;
            txtEmailNCC.DataBindings.Add("Text", dgvNhaCungCap.DataSource, "EMAIL"); ;
        }

        private void btnTimKiemNCC_Click(object sender, EventArgs e)
        {
            String timkiem=txtTimKiemNCC.Text;
            Search(timkiem);
        }

        private void Search(String timkiem)
        {
            DataTable ncc = bus_ncc.BangNCC();
            DataView dataView_ncc = new DataView(ncc);

            try
            {
                int mancc = Int32.Parse(timkiem);
                dataView_ncc.RowFilter = String.Format("Mancc = {0}", mancc);
                dgvNhaCungCap.DataSource = dataView_ncc;
                BuocDLVaoCacDieuKhien_NCC();
            }
            catch (FormatException ex)
            {
                dataView_ncc.RowFilter = String.Format("tenncc like '%{0}%'", timkiem);
                dgvNhaCungCap.DataSource = dataView_ncc;
                BuocDLVaoCacDieuKhien_NCC();
            }
        }

        private void btnPrevNCC_Click(object sender, EventArgs e)
        {
            if(bus_ncc.currentPage -1 <=0)
            {
                return;
            }else
            {
                bus_ncc.currentPage--;
                DLTrenTungTrang_BangNCC();
            }
        }

        private void btnNextNCC_Click(object sender, EventArgs e)
        {
            if (bus_ncc.currentPage +1 >bus_ncc.pageNumber)
            {
                return;
            }
            else
            {
                bus_ncc.currentPage++;
                DLTrenTungTrang_BangNCC();
            }
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            DataTable datatable_ncc = bus_ncc.BangNCC();
            if (btnThemNCC.Text.Contains("Th"))
            {
                txtIDNCC.Text = (bus_ncc.RowCount() +1+ nccdaxoa).ToString();
                txtTenNCC.Text = "";
                txtDiaChiNCC.Text = "";
                txtFaxNCC.Text = "";
                txtEmailNCC.Text = "";
                btnThemNCC.Text = "Luu";
            }

            if (txtTenNCC.Text != "")
            {
                int mancc = Int32.Parse(txtIDNCC.Text);
                String tenncc = txtTenNCC.Text;
                DataView View = new DataView(datatable_ncc);
                View.RowFilter = String.Format("mancc = {0} or tenncc like '%{1}%'", mancc, tenncc);

                if (View.Count > 0)
                {
                    MessageBox.Show("Nha cung cap da ton tai");
                }
                else
                {
                    String diachi = txtDiaChiNCC.Text;
                    String fax = txtFaxNCC.Text;
                    String email = txtEmailNCC.Text;
                    String ngaytao = DateTime.Now.ToString("yyyy-MM-dd");

                    NhaCungCap nhacungcap = new NhaCungCap(mancc,tenncc,diachi,fax,email,ngaytao);
                    MessageBox.Show(bus_ncc.LuuBangNhaCungCap(nhacungcap));
                    DLTrenTungTrang_BangNCC();
                    btnThemNCC.Text = "Thêm";
                }
            }
        }

        private void btnSuaNCC_Click(object sender, EventArgs e)
        {
            int mancc = Int32.Parse(txtIDNCC.Text);
            String tenncc = txtTenNCC.Text;
            String diachi = txtDiaChiNCC.Text;
            String fax = txtFaxNCC.Text;
            String email = txtEmailNCC.Text;
            String ngaytao = DateTime.Now.ToString("yyyy-MM-dd");

            NhaCungCap nhacungcap = new NhaCungCap(mancc, tenncc, diachi, fax, email, ngaytao);
            MessageBox.Show(bus_ncc.SuuBangNhaCungCap(nhacungcap));
            DLTrenTungTrang_BangNCC();

        }

        private void btnXoaNCC_Click(object sender, EventArgs e)
        {
            int mancc = Int32.Parse(txtIDNCC.Text);
            MessageBox.Show(bus_ncc.XoaDLBangNhaCungCap(mancc));
            DLTrenTungTrang_BangNCC();
            nccdaxoa += 1;
        }
    }

}
