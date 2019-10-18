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

namespace BanLinhKien
{
    public partial class frm_QuanLyDuLieu : Form
    {
        CurrencyManager pointer;
        BUS_DanhMuc busDanhmuc = new BUS_DanhMuc();
        DataTable datatable_Danhmuc = new DataTable();
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
            datatable_Danhmuc = busDanhmuc.BangDanhMuc();
            Load_BangDanhMuc();
            BuocDlVaoCacDieuKhien(datatable_Danhmuc);
        }

        private void Load_BangDanhMuc()
        {
            dgvDanhMuc.DataSource = datatable_Danhmuc;
        }

        private void btnTimDM_Click(object sender, EventArgs e)
        {
            Search(txtTimKiemDM.Text);
        }

        private void Search(String timkiem)
        {
            DataView dataView = new DataView(datatable_Danhmuc);
            try
            {
                int madm = Int32.Parse(timkiem);
                dataView.RowFilter = String.Format("Madm = {0}", madm);
                dgvDanhMuc.DataSource = dataView;
                BuocDlVaoCacDieuKhien(dataView);
            }catch(FormatException ex)
            {
                dataView.RowFilter = String.Format("Tendanhmuc like '%{0}%'", timkiem);
                dgvDanhMuc.DataSource = dataView;
                BuocDlVaoCacDieuKhien(dataView);
            }
        }

        private void BuocDlVaoCacDieuKhien(Object data)
        {
            txtIDDanhMuc.DataBindings.Clear();
            txtTenDanhMuc.DataBindings.Clear();

            txtIDDanhMuc.DataBindings.Add("Text", data, "madm");
            txtTenDanhMuc.DataBindings.Add("Text", data, "tendanhmuc");

            pointer = (CurrencyManager)BindingContext[data];
            lblTongTrangDM.Text = pointer.Count.ToString();
            txtTrangDM.Text = (pointer.Position+1).ToString();
        }

        private void btnPrevDM_Click(object sender, EventArgs e)
        {
            pointer.Position -= 1;
            txtTrangDM.Text = (pointer.Position+1).ToString();
        }

        private void btnNextDM_Click(object sender, EventArgs e)
        {
            pointer.Position += 1;
            txtTrangDM.Text = (pointer.Position + 1).ToString();
        }

        private void btnThemDM_Click(object sender, EventArgs e)
        {
            if (btnThemDM.Text.Contains("Th"))
            {
                btnThemDM.Text = "Luu";
                txtIDDanhMuc.Text = (pointer.Count + 1).ToString();
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
                    MessageBox.Show(busDanhmuc.LuuBangDanhMuc(tendanhmuc));
                    CapNhapLaiDLTrenForm();
                    btnThemDM.Text = "Thêm";
                }
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
            txtTrangDM.Text = (pointer.Position + 1).ToString();
        }
    }
    
}
