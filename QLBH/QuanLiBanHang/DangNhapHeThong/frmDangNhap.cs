using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangNhapHeThong
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        public delegate bool DangNhap(string username, string password);
        public DangNhap KiemTraDangNhap;

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = this.txtUsername.Text;
            string password = this.txtPassword.Text;

           bool res =  KiemTraDangNhap(username, password);

           if (res)
           {
               this.DialogResult = DialogResult.OK;
               this.Close();
           }
           else 
           {
               MessageBox.Show("sai tài khoản");
           }


        }

        private void btnThoatt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
