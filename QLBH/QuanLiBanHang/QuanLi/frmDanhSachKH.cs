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
namespace QuanLi
{
    public partial class frmDanhSachKH : Form
    {
        public frmDanhSachKH()
        {
            InitializeComponent();
        }

        public bool checkLoaded = false;
        public List<KhachHang> ds_kh;
        public delegate void SendDetail(KhachHang kh);
        public SendDetail SendDetail_KH;
        

        private void frmDanhSachKH_Load(object sender, EventArgs e)
        {
            lbKhachHang.DataSource = ds_kh;
            lbKhachHang.DisplayMember = "TenKH";
            checkLoaded = true;
        }

        private void lbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkLoaded != true) { return; }

            KhachHang kh = lbKhachHang.SelectedItem as KhachHang;

            SendDetail_KH(kh);
            
        }

        private void LbKhachHang_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
