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
    public partial class frmPhieu_Thu : Form
    {
        public frmPhieu_Thu()
        {
            InitializeComponent();
        }

        string connStr = @"Data Source=.;Initial Catalog=QLBH;Integrated Security=True";

        DataSet ds;

        private void frmPhieu_Thu_Load(object sender, EventArgs e)
        {
            loadPhieuXuat();
            loadSoCT();
        }

        void loadPhieuXuat() 
        {
           
            string cmdText = "select * from PHIEU_XUAT";
            SqlConnection conn = new SqlConnection(connStr);

            SqlDataAdapter adapter = new SqlDataAdapter(cmdText, conn);
            ds = new DataSet();

            // clear data sourece
            ds.Clear();
            cbPhieuXuat.DataSource = null;
            txtPhaiTra.DataBindings.Clear();
            txtDaTra.DataBindings.Clear();
            txtConNo.DataBindings.Clear();

            adapter.Fill(ds, "PHIEU_XUAT");
            cbPhieuXuat.DataSource = ds.Tables["PHIEU_XUAT"];
            cbPhieuXuat.DisplayMember = "SoPX";

            txtPhaiTra.DataBindings.Add("Text", ds.Tables["PHIEU_XUAT"], "SoTienPhaiTra");
            txtDaTra.DataBindings.Add("Text", ds.Tables["PHIEU_XUAT"], "SoTienDaTra");
            txtConNo.DataBindings.Add("Text", ds.Tables["PHIEU_XUAT"], "SoTIenConLai");
        }

        void loadSoCT() 
        {
            string cmdText = "select count(*) from PHIEU_THU";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand comm = new SqlCommand(cmdText, conn);

            int soPhieu = Convert.ToInt32( comm.ExecuteScalar() ) + 1;
            txtSoChungTu.Text = "CT" + soPhieu;
            conn.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
           
            if (ThemPhieuThu() > 0 && SuaPhieuXuat() > 0)
            {
                MessageBox.Show("Them thanh cong");
            }
            else 
            {
                MessageBox.Show("Thao tac that bai");
            }
        }

        int ThemPhieuThu() 
        {
            string ngayCT = DateTime.Now.ToString();
            int soTien = Convert.ToInt32(txtSoTienTra.Text);
            string dienGiai = txtDienGiai.Text;
            string soPX = cbPhieuXuat.Text;

            string cmdText = string.Format("insert PHIEU_THU values('{0}','{1}',{2},'{3}','{4}')", txtSoChungTu.Text, ngayCT, soTien, dienGiai, soPX);
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            SqlCommand comm = new SqlCommand(cmdText, conn);
            int rowsEffect = comm.ExecuteNonQuery();

            conn.Close();
            return rowsEffect;
        }

        int SuaPhieuXuat() 
        {
            int soTien = Convert.ToInt32(txtSoTienTra.Text);
            string cmdText = string.Format("update PHIEU_XUAT set SoTienDaTra += {0}, SoTienConLai -= {1} Where SoPX = '{2}'",soTien,soTien,cbPhieuXuat.Text);
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            SqlCommand comm = new SqlCommand(cmdText, conn);
            int rowsEffect = comm.ExecuteNonQuery();

            conn.Close();
            return rowsEffect;
        }

        private void txtSoTienTra_TextChanged(object sender, EventArgs e)
        {
            if (txtSoTienTra.Text == "" || txtSoTienTra.Text == "")
                return;

            int soTienTra = Convert.ToInt32( txtSoTienTra.Text );
            int soTienConLai = Convert.ToInt32(txtConNo.Text);

            if (soTienTra > soTienConLai) 
            {
                txtSoTienTra.Text = txtConNo.Text;
                txtSoTienTra.SelectionStart = txtSoTienTra.TextLength;                
            }
            
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            loadSoCT();
            loadPhieuXuat();
            txtSoTienTra.Text = "";
            txtDienGiai.Text = "";
        }
    }
}
