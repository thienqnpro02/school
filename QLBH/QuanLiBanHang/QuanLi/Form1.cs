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
            MessageBox.Show(ds_kh.Count.ToString());
        }

        void KhoiTao() 
        {
            txtSoDH.Text = DonHanBUS.Instance.TaoMaDH();
            ds_kh = KhachHangBUS.Instance.DanhSach_KhachHang();
            
        }
    }
}
