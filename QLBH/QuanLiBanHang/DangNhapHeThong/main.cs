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

namespace DangNhapHeThong
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        

        public string connSTR = @"Data Source=.;Initial Catalog=QLBH;Integrated Security=True";
        public bool checkLogin = false;

        private void main_Load(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            frm.KiemTraDangNhap = this.KiemTraDangNhap;
            DialogResult res = frm.ShowDialog();

            if (res != DialogResult.OK)
            {
                this.Close();
            }
            
            
        }

        public bool KiemTraDangNhap(string user, string pass)
        {
            string query = string.Format("select * from TaiKhoan where Username = '{0}' AND Password = '{1}'",user,pass);
            SqlConnection conn = new SqlConnection(connSTR);            
            SqlCommand comm = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader rd = comm.ExecuteReader();


            if (rd.HasRows)
            {
                checkLogin = true;
            }
                
            
            conn.Close();            
            return checkLogin;

        }

        
       
    }
}
