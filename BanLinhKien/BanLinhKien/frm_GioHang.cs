using System;
using System.Collections;
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
    public partial class frm_GioHang : Form
    {
        public Hashtable items_picked;

        public frm_GioHang()
        {
            InitializeComponent();
            
        }

        private void loadCart()
        {
            DataTable data = BUS_Hang.Instance.selectByID(items_picked);
            foreach(DataRow row in data.Rows)
            {
                // groupbox
                GroupBox gpHang = new GroupBox();                
                gpHang.Name = "gpHang" + row["MAHANG"].ToString();
                gpHang.Width = 437;
                gpHang.Height = 142;

                // picturebox
                PictureBox pic = new PictureBox();
                pic.ImageLocation = BUS_Hang.Instance.pathImage + row["HINH"].ToString();
                pic.Width = 116;
                pic.Height = 125;
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Location = new Point(6, 10);

                // button
                Button btn = new Button();                
                btn.Name = "btnHang" + row["MAHANG"].ToString();
                btn.Text = "Xem chi tiết";                
                btn.Location = new Point(356, 112);
                btn.Click += Btn_Click;

                Button btnDel = new Button();
                btnDel.Name = "btnDelHang" + row["MAHANG"].ToString();
                btnDel.Text = "X";
                btnDel.Size = new Size(42, 23);
                btnDel.Location = new Point(389, 10);
                btnDel.BackColor = System.Drawing.Color.Red;
                btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnDel.ForeColor = System.Drawing.Color.White;
                btnDel.Tag = row["MAHANG"].ToString();
                btnDel.Click += BtnDel_Click;

                // label
                Label lbl = new Label();
                lbl.Name = "lblHang" + row["MAHANG"].ToString();
                lbl.Text = row["TENHANG"].ToString();
                lbl.AutoSize = false;
                lbl.Size = new Size(231, 46);
                lbl.Location = new Point(128, 15);

                Label lblGiaHang = new Label();
                lblGiaHang.Name = "lblGiaHang" + row["MAHANG"].ToString();
                lblGiaHang.Text = row["GIA"].ToString() + " VNĐ";
                lblGiaHang.AutoSize = true;
                lblGiaHang.Location = new Point(356, 86);

                Label lblSoLuong = new Label();
                lblSoLuong.Name = "lblSoLuong" + row["MAHANG"].ToString();
                lblSoLuong.Text = "Số Lượng";
                lblSoLuong.Size = new Size(53, 13);
                lblSoLuong.Location = new Point(128, 85);

                // numericUpDown
                NumericUpDown num = new NumericUpDown();
                num.Name = "numHang" + row["MAHANG"].ToString();
                num.Location = new Point(201, 78);
                num.Size = new Size(43, 20);
                num.Minimum = 1;
                num.Value = Convert.ToInt32(items_picked[row["MAHANG"].ToString()]);

                gpHang.Controls.Add(pic);
                gpHang.Controls.Add(btn);
                gpHang.Controls.Add(btnDel);
                gpHang.Controls.Add(lbl);
                gpHang.Controls.Add(lblGiaHang);
                gpHang.Controls.Add(lblSoLuong);
                gpHang.Controls.Add(num);


                flpDanhSachSanPham.Controls.Add(gpHang);

            }

            
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            frm_ChiTietHang form_ChiTietHang = new frm_ChiTietHang();
            form_ChiTietHang.Show();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            Button btnDel = sender as Button;
            GroupBox gpParent = btnDel.Parent as GroupBox;
            flpDanhSachSanPham.Controls.Remove(gpParent);
            items_picked.Remove(btnDel.Tag.ToString());

        }

        private void BtnChonKhachCu_Click(object sender, EventArgs e)
        {
            frm_ChonKhach form_ChonKhach = new frm_ChonKhach();
            form_ChonKhach.ShowDialog();
        }

        private void Frm_GioHang_Load(object sender, EventArgs e)
        {
            loadCart();
        }
    }
}
