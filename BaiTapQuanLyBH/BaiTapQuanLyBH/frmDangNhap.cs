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

namespace BaiTapQuanLyBH
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        public delegate void checkLogEvent(bool res);
        public checkLogEvent checkLog;
        string connStr = @"Data Source=.;Initial Catalog=QLBH;Integrated Security=True";


        private void btnDangNhap_Click(object sender, EventArgs e)
        {
           

            string taikhoan = txtTaiKhoan.Text;
            string matkhau = txtMatKhau.Text;
            bool res = false;

            string cmdText = string.Format("select * from TAI_KHOAN where Username = '{0}' AND Password = '{1}'",taikhoan,matkhau);
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            SqlCommand comm = new SqlCommand(cmdText, conn);
            SqlDataReader rd = comm.ExecuteReader();

            if (rd.Read())
            {
                res = true;
                checkLog(res);
                conn.Close();

                this.Close();
            }
            else 
            {
                MessageBox.Show("Sai");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
