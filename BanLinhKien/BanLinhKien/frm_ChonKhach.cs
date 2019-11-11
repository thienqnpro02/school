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
    public partial class frm_ChonKhach : Form
    {
        public int idCustomer;
        private DataTable dt_khachhang;
        public frm_ChonKhach()
        {
            InitializeComponent();
        }

        private void Frm_ChonKhach_Load(object sender, EventArgs e)
        {
            dt_khachhang = BUS_KhachHang.Instance.BangKhachHang();
            foreach(DataRow row in dt_khachhang.Rows)
            {
                // groupbox
                GroupBox gpKhachHang = new GroupBox();
                gpKhachHang.Location = new System.Drawing.Point(8, 8);
                gpKhachHang.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
                gpKhachHang.Name = "gpKhachHang" + row["MAKH"];
                gpKhachHang.Size = new System.Drawing.Size(327, 142);

                // label
                Label lblTen = new Label();
                lblTen.AutoSize = true;
                lblTen.Location = new System.Drawing.Point(6, 27);
                lblTen.Name = "lblTen" + row["MAKH"];
                lblTen.Size = new System.Drawing.Size(29, 13);
                lblTen.Text = "Tên:";

                Label lblHoldTen = new Label();
                lblHoldTen.AutoSize = true;
                lblHoldTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
                lblHoldTen.Location = new System.Drawing.Point(91, 27);
                lblHoldTen.Name = "lblHoldTen" + row["MAKH"];
                lblHoldTen.Size = new System.Drawing.Size(117, 20);                
                lblHoldTen.Text = row["HOTEN"].ToString();

                Label lblSDT = new Label();
                lblSDT.AutoSize = true;
                lblSDT.Location = new System.Drawing.Point(6, 61);
                lblSDT.Name = "lblSDT" + row["MAKH"];
                lblSDT.Size = new System.Drawing.Size(32, 13);
                lblSDT.TabIndex = 0;
                lblSDT.Text = "SĐT:";

                Label lblHoldSDT = new Label();
                lblHoldSDT.AutoSize = true;
                lblHoldSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
                lblHoldSDT.Location = new System.Drawing.Point(91, 61);
                lblHoldSDT.Name = "lblHoldSDT" + row["MAKH"];
                lblHoldSDT.Size = new System.Drawing.Size(109, 20);
                lblHoldSDT.TabIndex = 1;
                lblHoldSDT.Text = row["SDT"].ToString();

                Label lblNamSinh = new Label();
                lblNamSinh.AutoSize = true;
                lblNamSinh.Location = new System.Drawing.Point(6, 96);
                lblNamSinh.Name = "lblNamSinh" + row["MAKH"];
                lblNamSinh.Size = new System.Drawing.Size(54, 13);
                lblNamSinh.TabIndex = 0;
                lblNamSinh.Text = "Năm sinh:";

                Label lblHoldNamSinh = new Label();
                lblHoldNamSinh.AutoSize = true;
                lblHoldNamSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
                lblHoldNamSinh.Location = new System.Drawing.Point(91, 96);
                lblHoldNamSinh.Name = "lblHoldNamSinh" + row["MAKH"];
                lblHoldNamSinh.Size = new System.Drawing.Size(99, 20);
                lblHoldNamSinh.TabIndex = 1;
                DateTime date = DateTime.Parse(row["namsinh"].ToString());
                lblHoldNamSinh.Text = date.ToString("dd/M/yyyy");

                // button
                Button btnChon = new Button();
                btnChon.Location = new System.Drawing.Point(246, 113);
                btnChon.Name = "btnChon" + row["MAKH"];
                btnChon.Size = new System.Drawing.Size(75, 23);
                btnChon.TabIndex = 2;
                btnChon.Text = "Chọn";
                btnChon.Tag = row["MAKH"];
                btnChon.UseVisualStyleBackColor = true;
                btnChon.Click += BtnChon_Click;

                gpKhachHang.Controls.Add(lblTen);
                gpKhachHang.Controls.Add(lblHoldTen);
                gpKhachHang.Controls.Add(lblSDT);
                gpKhachHang.Controls.Add(lblHoldSDT);
                gpKhachHang.Controls.Add(lblNamSinh);
                gpKhachHang.Controls.Add(lblHoldSDT);
                gpKhachHang.Controls.Add(lblHoldTen);
                gpKhachHang.Controls.Add(lblNamSinh);
                gpKhachHang.Controls.Add(lblHoldNamSinh);
                gpKhachHang.Controls.Add(btnChon);


                flpDanhSachKhachHang.Controls.Add(gpKhachHang);
            }
        }

        private void BtnChon_Click(object sender, EventArgs e)
        {
            idCustomer = Convert.ToInt32((sender as Button).Tag);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
