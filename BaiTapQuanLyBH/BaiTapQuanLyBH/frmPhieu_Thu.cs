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
        bool isSubmit = false;
        bool checkLoaded = false;

        private void frmPhieu_Thu_Load(object sender, EventArgs e)
        {
            loadPhieuXuat();
            loadSoCT();
        }

        void loadPhieuXuat(string previousItem = null) 
        {
           
            string cmdText = "select * from PHIEU_XUAT where SoTienConLai <> 0";
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
            checkLoaded = true;

            if (previousItem != null) 
            {
                int previousItemIdx = cbPhieuXuat.FindString(previousItem);
                cbPhieuXuat.SelectedIndex = (previousItemIdx != -1) ? previousItemIdx : 0;
            }

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
            if (isSubmit == true) 
            {
                MessageBox.Show("Bấm tạo mới trước khi lưu");
                return;
            }

            if (txtSoTienTra.Text == "" || txtSoTienTra.Text == "0") 
            {
                MessageBox.Show("Số tiền trả không hợp lệ");
                return;
            }
            

            if (ThemPhieuThu() > 0 && SuaPhieuXuat() > 0)
            {
                
                string selectedText = cbPhieuXuat.Text;
                loadPhieuXuat(selectedText);
                isSubmit = true;
                MessageBox.Show("Lưu thành công");
            }
            else 
            {
                MessageBox.Show("Thao tác thất bại");
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
            
            int soTienTra;
            DataRowView r = cbPhieuXuat.SelectedItem as DataRowView;
            if (txtSoTienTra.Text == "" || txtSoTienTra.Text == "")
            {
                soTienTra = 0;
                if (r != null) 
                {
                    txtDaTra.Text = r.Row["SoTienDaTra"].ToString();
                    txtConNo.Text = r.Row["SoTienConLai"].ToString();
                }
                
                    
                 
            }
            else 
            {
                 soTienTra = Convert.ToInt32(txtSoTienTra.Text);
                 
                 int daTra = Convert.ToInt32(r.Row["SoTienDaTra"]);
                 int conNo = Convert.ToInt32(r.Row["SoTienConLai"]);



                 if (soTienTra > conNo)
                 {
                     txtSoTienTra.Text = r.Row["SoTienConLai"].ToString();
                     txtSoTienTra.Select(txtSoTienTra.TextLength, 0);
                     soTienTra = Convert.ToInt32(txtSoTienTra.Text);
                }

                 int updateDaTra = daTra + soTienTra;
                 int updateConNo = conNo - soTienTra;

                 txtDaTra.Text = updateDaTra.ToString();
                 txtConNo.Text = updateConNo.ToString();
            }
            
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            loadSoCT();            
            txtSoTienTra.Text = "";
            txtDienGiai.Text = "";
            isSubmit = false;
        }

        private void cbPhieuXuat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkLoaded == false)
                return;
            txtSoTienTra.Text = "";            
             
        }
    }
}
