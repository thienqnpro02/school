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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
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
            form_GioHang.ShowDialog();
        }
    }
}
