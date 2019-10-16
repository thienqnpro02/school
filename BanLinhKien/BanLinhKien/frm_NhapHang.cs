using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanLinhKien
{
    public partial class frm_NhapHang : Form
    {
        public frm_NhapHang()
        {
            InitializeComponent();
        }

        private void BtnGioNhapHang_Click(object sender, EventArgs e)
        {
            frm_ChiTietPhieuNhap form_ChiTietPhieuNhap = new frm_ChiTietPhieuNhap();
            form_ChiTietPhieuNhap.ShowDialog();
        }
    }
}
