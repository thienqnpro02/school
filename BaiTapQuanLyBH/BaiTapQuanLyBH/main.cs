using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapQuanLyBH
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        public bool isLogin;

        private void chiTiếtPhiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCT_PhieuNhap frmCT_PhieuNhap = new frmCT_PhieuNhap();
            frmCT_PhieuNhap.MdiParent = this;
            frmCT_PhieuNhap.Show();
        }

        private void chiTiếtPhiếuXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCT_PhieuXuat frmCT_PhieuXuat = new frmCT_PhieuXuat();
            frmCT_PhieuXuat.MdiParent = this;
            frmCT_PhieuXuat.Show();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap frmDangNhap = new frmDangNhap();
            frmDangNhap.MdiParent = this;
            frmDangNhap.checkLog = this.checkLog;
            frmDangNhap.Show();            
           
        }

        void checkLog(bool res)
        {
            isLogin = res;
            if (res)
            {
                menuStripFormMain.Items["nhapHangToolStripMenuItem"].Enabled = true;
                menuStripFormMain.Items["xuatHangToolStripMenuItem"].Enabled = true;
                menuStripFormMain.Items["thuTienToolStripMenuItem"].Enabled = true;

                dangNhapToolStripMenuItem.Visible = false;
                dangXuatToolStripMenuItem.Visible = true;
            }
        }

        private void ghiPhiếuThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieu_Thu frmPhieu_Thu = new frmPhieu_Thu();
            frmPhieu_Thu.MdiParent = this;
            frmPhieu_Thu.Show();
        }

        private void main_Load(object sender, EventArgs e)
        {
            
        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStripFormMain.Items["nhapHangToolStripMenuItem"].Enabled = false;
            menuStripFormMain.Items["xuatHangToolStripMenuItem"].Enabled = false;
            menuStripFormMain.Items["thuTienToolStripMenuItem"].Enabled = false;

            dangNhapToolStripMenuItem.Visible = true;
            dangXuatToolStripMenuItem.Visible = false;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
