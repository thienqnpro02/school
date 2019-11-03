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
    public partial class frm_ChiTietHang : Form
    {
        public int maHang;
        public frm_ChiTietHang()
        {
            InitializeComponent();
        }

        private void Frm_ChiTietHang_Load(object sender, EventArgs e)
        {
            DataTable data = BUS_Hang.Instance.selectByID(new List<int> { maHang });
            lblTenHang.Text = data.Rows[0]["TENHANG"].ToString();
            lblThongSo.Text = data.Rows[0]["THONGSO"].ToString();
            lblBaoHanh.Text = data.Rows[0]["BAOHANH"] + " tháng";
            lblGia.Text = data.Rows[0]["GIA"] + " VNĐ";
            picHang.ImageLocation = BUS_Hang.Instance.pathImage + data.Rows[0]["HINH"].ToString();
        }
    }
}
