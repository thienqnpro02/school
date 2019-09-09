using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using DTO;
using BUS;
namespace QuanLi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<KhachHang> ds_kh;

        private void Form1_Load(object sender, EventArgs e)
        {
            KhoiTao();
            
        }

        void KhoiTao() 
        {
            //txtSoDH.Text = DonHanBUS.Instance.TaoMaDH();
            ds_kh = KhachHangBUS.Instance.DanhSach_KhachHang();
            
        }

        void ReceiveDetail_KH(KhachHang kh)
        {
            txtTenKH.Text = kh.TenKH;
            txtNoiGiaoHang.Text = kh.DiaChi;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmDanhSachKH frm = new frmDanhSachKH();
            frm.ds_kh = this.ds_kh;
            frm.SendDetail_KH = ReceiveDetail_KH;

            frm.Show();
        }

        
        
    }
}
