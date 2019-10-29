using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using System.Collections;
using DTO;
namespace BanLinhKien
{
    public partial class frm_QuanLyDuLieu : Form
    {
        // variables for tab Danh Muc
        BUS_DanhMuc busDanhmuc = BUS_DanhMuc.Instance;
        DataTable datatable_Danhmuc = new DataTable();
        private int currentPageDanhMuc = 1;

        // variables for tab Hang
        private bool dgvHangLoaded = false;
        private bool isUpdateImage = false;
        private int currentPageHang = 1;

        // variables for tab Nhan Vien      
        BUS_NhanVien bus_nhanvien = BUS_NhanVien.Instance;
        private bool cbLoaiNhanVienLoaded = false;
        private int currentPageNhanVien = 1;

        // variables for tab Khach Hang      
        BUS_KhachHang bus_khachhang = BUS_KhachHang.Instance;
        private int currentPageKhachHang = 1;

        // variables for tab Nha Cung Cap
        BUS_NCC bus_ncc = BUS_NCC.Instance;
        private int currentPageNCC = 1;


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
            datatable_Danhmuc = busDanhmuc.pagingDanhMuc(currentPageDanhMuc);
            Load_BangDanhMuc();
        }

        private void Load_BangDanhMuc()
        {
            dgvDanhMuc.DataSource = datatable_Danhmuc;
            BuocDlVaoCacDieuKhien();

            txtTrangDM.Text = currentPageDanhMuc.ToString();
            lblTongTrangDM.Text = "/" + busDanhmuc.totalPage.ToString();
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
                btnThemDM.Text = "Lưu";
                txtIDDanhMuc.Text = "";
                txtTenDanhMuc.Text = "";
            }

            if (txtTenDanhMuc.Text != "")
            {
                
                
                String tendanhmuc = txtTenDanhMuc.Text;
                DataView View = new DataView(datatable_Danhmuc);
                View.RowFilter = String.Format("tendanhmuc like '%{0}%'", tendanhmuc);

                if (View.Count > 0)
                {
                    MessageBox.Show("Danh mục đã tồn tại");
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
            if(currentPageDanhMuc + 1> busDanhmuc.totalPage)
            {
                return;
            }else
            {
                currentPageDanhMuc++;
                dgvDanhMuc.DataSource = busDanhmuc.pagingDanhMuc(currentPageDanhMuc);
                CapNhapLaiDLTrenForm();

            }
        }

        private void btnPrevDM_Click(object sender, EventArgs e)
        {
            if (currentPageDanhMuc - 1 <=0)
            {
                return;
            }
            else
            {
                currentPageDanhMuc--;
                dgvDanhMuc.DataSource = busDanhmuc.pagingDanhMuc(currentPageDanhMuc);
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

            datatable_hang = HangBUS.Instance.pagingHang(currentPageHang);
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
            dgvHang.Columns["TENDANHMUC"].Visible = false;

            // chỉnh kích thước cột
            dgvHang.Columns["MAHANG"].Width = 75;
            dgvHang.Columns["TENHANG"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // chỉnh header text
            dgvHang.Columns["MAHANG"].HeaderText = "Mã Hàng";
            dgvHang.Columns["TENHANG"].HeaderText = "Tên Hàng";

            
            dgvHangLoaded = true;           

            // paging
            txtTongTrangHang.Text = "/" + HangBUS.Instance.totalPage;
            txtTrangHang.Text = currentPageHang.ToString();

            // binding
            BuocVaoComboBoxDanhMuc();
            bindingHang();
            
        }

        private void bindingCBDanhMuc()
        {            
            DataGridViewRow row = dgvHang.CurrentRow as DataGridViewRow;
            if (row == null) return;
            string selectValue = row.Cells["MADANHMUC"].Value.ToString();            
            cbDanhMuc.SelectedValue = selectValue;
            picHang.ImageLocation = HangBUS.Instance.pathImage + row.Cells["HINH"].Value.ToString();
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
            txtSoLuong.DataBindings.Add("Text", dgvHang.DataSource, "SOLUONG");
            bindingCBDanhMuc();
            
        }

        

        private void DgvHang_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHangLoaded == false) return;

            
            if(dgvHang.CurrentRow != null)
            {               
                
                bindingCBDanhMuc();    
            }
            
        }

        private void BtnNextHang_Click(object sender, EventArgs e)
        {
            if (currentPageHang + 1 > HangBUS.Instance.totalPage)
                return;
            else
            {
                currentPageHang++;                
                dgvHang.DataSource = HangBUS.Instance.pagingHang(currentPageHang);
                txtTrangHang.Text = currentPageHang.ToString();
                txtTongTrangHang.Text ="/" +bus_hang.totalPage;
                bindingHang();
            }
        }

        private void BtnPrevHang_Click(object sender, EventArgs e)
        {
            if (currentPageHang - 1 <= 0)
                return;
            else
            {
                currentPageHang--;               
                dgvHang.DataSource = HangBUS.Instance.pagingHang(currentPageHang);
                txtTrangHang.Text = currentPageHang.ToString();
                txtTongTrangHang.Text = "/" + bus_hang.totalPage;
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
                btnThemHang.Text = "Lưu";
                txtIDHang.Text = "";
                txtTenHang.Text = " ";
                txtBaoHanh.Text = "";
                txtGia.Text = "";
                txtIDDanhMuc.Text = "";
                txtNhaSanXuat.Text = "";
                txtThongSo.Text = "";
                txtSoLuong.Text = "";
                cbDanhMuc.DataBindings.Clear();
                cbDanhMuc.Text = "";
                picHang.ImageLocation = HangBUS.Instance.pathImage + "default.png";
                
            }

            if (txtTenHang.Text != " ")
            {
                
                String tenhang = txtTenHang.Text;
                DataView View = new DataView(datatable_hang);
                
                View.RowFilter = String.Format("tenhang like '%{0}%'", tenhang);

                if (View.Count > 0)
                {
                    MessageBox.Show("Hàng đã tồn tại");
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

                    string hinh = "";
                    if (isUpdateImage)
                    {
                        do
                        {
                            hinh = RandomString(10) + Path.GetExtension(picHang.ImageLocation);
                        } while (HangBUS.Instance.isExistsImage(hinh));
                    }

                    Hang hang = new Hang(-1,tenhang, thongso, baohanh, soluong, gia, hinh, nhasanxuat, ngaytao, madm);
                    
                    int res = bus_hang.LuuBangHang(hang);
                    if(res > 0)
                    {
                        if (isUpdateImage)
                        {
                            File.Copy(picHang.ImageLocation, HangBUS.Instance.pathImage + hang.Hinh);
                            isUpdateImage = false;
                        }

                        MessageBox.Show("Thêm thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }

                    btnThemHang.Text = "Thêm";
                    configDGVHang();
                }
            }
        }

        private string RandomString(int length)
        {
            Random random = new Random();
            const string pool = "abcdefghijklmnopqrstuvwxyz0123456789";
            string rdString = "";

            for (int i = 0; i < length; i++)
            {
               rdString += pool[random.Next(0, pool.Length)];
                
            }

            return rdString;
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

            string hinh = "";            

            if (isUpdateImage)
            {
                do
                {
                    hinh = RandomString(10) + Path.GetExtension(picHang.ImageLocation);
                } while (HangBUS.Instance.isExistsImage(hinh));
            }          
            
            Hang hang = new Hang(mahang,tenhang_, thongso, baohanh, soluong, gia,hinh, nhasanxuat, ngaytao, madm);
            
            int res = bus_hang.SuaBangHang(hang);
            if(res > 0)
            {
                string oldFileName = dgvHang.CurrentRow.Cells["HINH"].Value.ToString();
                if (oldFileName != hang.Hinh)
                {              
                    

                    if (isUpdateImage)
                    {
                        if (File.Exists(HangBUS.Instance.pathImage + oldFileName) && oldFileName != "default.png")
                        {
                            File.Delete(HangBUS.Instance.pathImage + oldFileName);
                        }
                        File.Copy(picHang.ImageLocation, HangBUS.Instance.pathImage + hang.Hinh);
                        isUpdateImage = false;
                    }
                    
                    configDGVHang();
                }

                
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                
                MessageBox.Show("Sửa thất bại");
            }
            
        }

        private void btnXoaHang_Click(object sender, EventArgs e)
        {
            int mahang = Int32.Parse(txtIDHang.Text);
            MessageBox.Show(bus_hang.XoaDLBangHang(mahang));
            configDGVHang();
            if (currentPageHang > HangBUS.Instance.totalPage)
            {
                currentPageHang = HangBUS.Instance.totalPage;
                txtTrangHang.Text = currentPageHang.ToString();
            }
                
        }

       

        

        private void DLTrenTungTrang_BangNhanVien()
        {
            dgvNhanVien.DataSource = bus_nhanvien.DlTrenMotTrang_NhanVien(currentPageNhanVien);
            BuocDLVaoCacDieuKhien_NhanVien();
            BuocVaoComboBox_LoaiNhanVien();
            txtTrangNV.Text = currentPageNhanVien.ToString();
            lblTongTrangNV.Text ="/"+ bus_nhanvien.totalPage.ToString();
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
            if (currentPageNhanVien + 1 > bus_nhanvien.totalPage)
            {
                return;
            }else
            {
                currentPageNhanVien++;
                DLTrenTungTrang_BangNhanVien();
            }
        }

        private void btnPrevNV_Click(object sender, EventArgs e)
        {
            if (currentPageNhanVien - 1 <=0)
            {
                return;
            }
            else
            {
                currentPageNhanVien--;
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
            
            cbLoaiNhanVIen.DataSource = new BindingSource( NhanVien.List_LoaiNhanVien,null);
            cbLoaiNhanVIen.DisplayMember = "Value";
            cbLoaiNhanVIen.ValueMember = "Key";
            cbLoaiNhanVienLoaded = true;
        }

        private void bindingCBLoaiNhanVien()
        {
            cbLoaiNhanVIen.SelectedValue = dgvNhanVien.CurrentRow.Cells["LoaiNhanVien"].Value.ToString();
        }

        private void cbLoaiNhanVIen_Click(object sender, EventArgs e)
        {
            //BuocVaoComboBox_LoaiNhanVien();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            DataTable datatable_nhanvien = bus_nhanvien.BangNhanVien();
            if (btnThemNV.Text.Contains("Th"))
            {
                txtIDNhanVien.Text = "";
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
                
                String tennv = txtHoTenNhanVien.Text;
                DataView View = new DataView(datatable_nhanvien);
                View.RowFilter = String.Format("hoten like '%{0}%'", tennv);

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
                    int loainhanvien = Convert.ToInt32(cbLoaiNhanVIen.SelectedValue);
                    int gioitinh = (rdNam.Checked) ? 0 : 1;
                    String ngaytao = DateTime.Now.ToString("yyy-MM-dd");

                    NhanVien nhanvien_ = new NhanVien(-1,username,password,tennv,sdt,diachi,namsinh,loainhanvien,gioitinh,ngaytao);
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
            int loainhanvien = Convert.ToInt32(cbLoaiNhanVIen.SelectedValue);
            int gioitinh = (rdNam.Checked) ? 0 : 1;
            String ngaytao = DateTime.Now.ToString("yyy-MM-dd");

            NhanVien nhanvien_ = new NhanVien(manv, username, password, tennv, sdt,
                diachi, namsinh, loainhanvien, gioitinh, ngaytao);

            MessageBox.Show(bus_nhanvien.CapNhapDLBangNhanVien(nhanvien_));
            DLTrenTungTrang_BangNhanVien();
        }

        
        public void DLTrenTungTrang_KhachHang()
        {
            dgvKhachHang.DataSource = bus_khachhang.PhanTrang_KhachHang(currentPageKhachHang);
            BuocDlVaoCacDieuKhien_KhachHang();

            txtTrangKH.Text = currentPageKhachHang.ToString();
            lblTongTrangKH.Text = "/" + bus_khachhang.totalPage;
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
            if (currentPageKhachHang + 1 >bus_khachhang.totalPage)
            {
                return;
            }else
            {
                currentPageKhachHang++;
                DLTrenTungTrang_KhachHang();
            }
        }

        private void btnPrevKH_Click(object sender, EventArgs e)
        {
            if (currentPageKhachHang - 1 <=0)
            {
                return;
            }
            else
            {
                currentPageKhachHang--;
                DLTrenTungTrang_KhachHang();
            }
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            DataTable datatable_khachhang = bus_khachhang.BangKhachHang();
            if (btnThemKH.Text.Contains("Th"))
            {
                txtIDKhachHang.Text = "";
                txtHoTenKhachHang.Text = "";
                txtSDTKhachHang.Text = "";
                dtpkNamSinhKhachHang.DataBindings.Clear();
                dtpkNamSinhKhachHang.Text = "";
                btnThemKH.Text = "Luu";
            }

            if (txtHoTenKhachHang.Text != "")
            {
                
                String tenkh = txtHoTenKhachHang.Text;
                DataView View = new DataView(datatable_khachhang);
                View.RowFilter = String.Format("hoten like '%{0}%'",tenkh);

                if (View.Count > 0)
                {
                    MessageBox.Show("Nhan vien da ton tai");
                }
                else
                {
                    String sdtkh = txtSDTKhachHang.Text;
                    String namsinh = dtpkNamSinhKhachHang.Value.ToString("yyyy-MM-dd");
                    String ngaytao = DateTime.Now.ToString("yyyy-MM-dd");
                    
                    KhachHang khachhang = new KhachHang(-1,tenkh,sdtkh,namsinh,ngaytao);
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
           
        }

        
        public void DLTrenTungTrang_BangNCC()
        {
            dgvNhaCungCap.DataSource = bus_ncc.DLTrenTungTrang_NCC(currentPageNCC);
            BuocDLVaoCacDieuKhien_NCC();
            txtTrangNCC.Text = currentPageNCC.ToString();
            lblTongTrangNCC.Text = "/"+bus_ncc.totalPage.ToString();
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
            if(currentPageNCC - 1 <=0)
            {
                return;
            }else
            {
                currentPageNCC--;
                DLTrenTungTrang_BangNCC();
            }
        }

        private void btnNextNCC_Click(object sender, EventArgs e)
        {
            if (currentPageNCC + 1 >bus_ncc.totalPage)
            {
                return;
            }
            else
            {
                currentPageNCC++;
                DLTrenTungTrang_BangNCC();
            }
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            DataTable datatable_ncc = bus_ncc.BangNCC();
            if (btnThemNCC.Text.Contains("Th"))
            {
                txtIDNCC.Text = "";
                txtTenNCC.Text = "";
                txtDiaChiNCC.Text = "";
                txtFaxNCC.Text = "";
                txtEmailNCC.Text = "";
                btnThemNCC.Text = "Luu";
            }

            if (txtTenNCC.Text != "")
            {
                
                String tenncc = txtTenNCC.Text;
                DataView View = new DataView(datatable_ncc);
                View.RowFilter = String.Format("tenncc like '%{0}%'", tenncc);

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

                    NhaCungCap nhacungcap = new NhaCungCap(-1,tenncc,diachi,fax,email,ngaytao);
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
           
        }

        private void BtnDoiHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG files(.jpg)|*.jpg|PNG file(.png)|*.png|ALl files(*.*)|*.*";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                
                picHang.ImageLocation = dialog.FileName;
                isUpdateImage = true;
            }
        }

        private void CbLoaiNhanVIen_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbLoaiNhanVienLoaded == false) return;
            //MessageBox.Show(cbLoaiNhanVIen.SelectedValue.ToString());
        }

        private void DgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvNhanVien.CurrentRow != null)
            {
                bindingCBLoaiNhanVien();
            }
        }
    }

}
