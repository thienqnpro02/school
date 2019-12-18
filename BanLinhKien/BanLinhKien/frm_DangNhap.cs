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
namespace BanLinhKien
{
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void Frm_DangNhap_Load(object sender, EventArgs e)
        {
                       
        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            NhanVien.client = BUS_NhanVien.Instance.Login(username, password);

            if(NhanVien.client != null)
            {
                
                
                clearTextBox();
                this.Hide();
                main frm_main = new main();
                frm_main.ActionOpenFormDangNhap = openFormDangNhap;
                frm_main.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }
            
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frm_DangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        void clearTextBox()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        void openFormDangNhap()
        {
            Application.OpenForms["main"].Close();
            Application.OpenForms["frm_DangNhap"].Show();          
        }
    }
}
