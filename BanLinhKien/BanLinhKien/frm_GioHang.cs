﻿using System;
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

        private DataTable dt_hang;       
        private int idOldCustomer = -1;
        private bool isAnonymousCustomer = true;
        private Hashtable hash_Label = new Hashtable();

        public delegate void ReloadHang();
        public ReloadHang actionReloadHang;


        public frm_GioHang()
        {
            InitializeComponent();
            
        }

        private void loadCart()
        {
            List<int> list_id = new List<int>();
            
            foreach(DictionaryEntry item in items_picked)
            {
                list_id.Add(Convert.ToInt32(item.Key));
            }
            
            dt_hang = BUS_Hang.Instance.selectByID(list_id);
            foreach(DataRow row in dt_hang.Rows)
            {
                // groupbox
                GroupBox gpHang = new GroupBox();                
                gpHang.Name = "gpHang" + row["MAHANG"].ToString();                
                gpHang.Size = new Size(437, 142);

                // picturebox
                PictureBox pic = new PictureBox();
                pic.ImageLocation = BUS_Hang.Instance.pathImage + row["HINH"].ToString();
                pic.Size = new Size(116, 125);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Location = new Point(6, 10);

                // button
                Button btn = new Button();                
                btn.Name = "btnHang" + row["MAHANG"].ToString();
                btn.Text = "Xem chi tiết";                
                btn.Location = new Point(356, 112);
                btn.Tag = row["MAHANG"].ToString();
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
                lblGiaHang.Text = formatCultureToString(Convert.ToInt32(row["GIA"])) + " VNĐ";
                lblGiaHang.AutoSize = true;
                lblGiaHang.Location = new Point(356, 86);
                lblGiaHang.Tag = row["GIA"].ToString();
                hash_Label.Add(row["MAHANG"].ToString(), lblGiaHang);

                Label lblSoLuong = new Label();
                lblSoLuong.Name = "lblSoLuong" + row["MAHANG"].ToString();
                lblSoLuong.Text = "Số Lượng";
                lblSoLuong.Size = new Size(53, 13);
                lblSoLuong.Location = new Point(128, 85);

                // numericUpDown
                NumericUpDown num = new NumericUpDown();
                num.Minimum = 0;
                num.Maximum = Convert.ToInt32(row["SOLUONG"]);
                num.Name = "numHang" + row["MAHANG"].ToString();
                num.Location = new Point(201, 78);
                num.Size = new Size(43, 20);
                num.Minimum = 1;
                num.Tag = row["MAHANG"].ToString();
                num.Value = Convert.ToInt32(items_picked[row["MAHANG"].ToString()]);
                num.ValueChanged += Num_ValueChanged;

                gpHang.Controls.Add(pic);
                gpHang.Controls.Add(btn);
                gpHang.Controls.Add(btnDel);
                gpHang.Controls.Add(lbl);
                gpHang.Controls.Add(lblGiaHang);
                gpHang.Controls.Add(lblSoLuong);
                gpHang.Controls.Add(num);


                flpDanhSachSanPham.Controls.Add(gpHang);

            }
            totalPaymentAmount();


        }

        private void Num_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = sender as NumericUpDown;
            Label lbl = hash_Label[num.Tag.ToString()] as Label;
            int soLuong = Convert.ToInt32(num.Value);

            items_picked[num.Tag.ToString()] = soLuong;
            lbl.Text = (Convert.ToInt32(lbl.Tag) * soLuong).ToString();
            lbl.Text = formatCultureToString(Convert.ToInt32(lbl.Text)) + " VNĐ";

            totalPaymentAmount();
        }

        private void totalPaymentAmount()
        {
            int total = 0; 
            foreach(DictionaryEntry section in hash_Label)
            {
                Label lbl = section.Value as Label;
                string soTien = sanitizeString(lbl.Text);

                total += Convert.ToInt32(soTien);
            }
            
            lblTongTien.Text = formatCultureToString(total) + " VNĐ";
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            frm_ChiTietHang form_ChiTietHang = new frm_ChiTietHang();
            form_ChiTietHang.maHang = Convert.ToInt32((sender as Button).Tag);
            form_ChiTietHang.ShowDialog();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            Button btnDel = sender as Button;
            GroupBox gpParent = btnDel.Parent as GroupBox;


            
            flpDanhSachSanPham.Controls.Remove(gpParent);
            items_picked.Remove(btnDel.Tag.ToString());
            hash_Label.Remove(btnDel.Tag.ToString());

            totalPaymentAmount();

            DataTable dt_hang_CLone = dt_hang;
            int idx = 0;
            foreach (DataRow row_del in dt_hang_CLone.Rows)
            {

                if(row_del["MAHANG"].ToString() == btnDel.Tag.ToString())
                {
                    dt_hang.Rows.RemoveAt(idx);
                    break;
                }
                idx++;
            }
        }

        private void BtnChonKhachCu_Click(object sender, EventArgs e)
        {
            frm_ChonKhach form_ChonKhach = new frm_ChonKhach();            
            
            if(form_ChonKhach.ShowDialog() == DialogResult.OK)
            {
                this.isAnonymousCustomer = false;
                this.idOldCustomer = form_ChonKhach.idCustomer;
                txtTenKhachHang.Enabled = false;
                txtSDTKhachHang.Enabled = false;
                dtpkNamSinhKhachHang.Enabled = false;

                DataTable dt_khachahng = BUS_KhachHang.Instance.selectByID(new List<int> { this.idOldCustomer });
                txtTenKhachHang.Text = dt_khachahng.Rows[0]["HOTEN"].ToString();
                txtSDTKhachHang.Text = dt_khachahng.Rows[0]["SDT"].ToString();
                dtpkNamSinhKhachHang.Value = DateTime.Parse(dt_khachahng.Rows[0]["NAMSINH"].ToString());
            }
            
            
        }

        private void Frm_GioHang_Load(object sender, EventArgs e)
        {
            loadCart();
        }

        private void BtnClearGio_Click(object sender, EventArgs e)
        {
            this.items_picked.Clear();
            flpDanhSachSanPham.Controls.Clear();
            lblTongTien.Text = "0 VNĐ";
        }

        private void BtnThanhToan_Click(object sender, EventArgs e)
        {
            if(items_picked.Count == 0)
            {
                MessageBox.Show("Chọn hàng trước khi thanh toán");
                return;
            }

            PhieuXuat phieuxuat = new PhieuXuat();
            phieuxuat.MaNV = NhanVien.client.MaNV;            
            phieuxuat.NgayTao = DateTime.Now;

            if(isAnonymousCustomer == true)
            {
                phieuxuat.MaKH = null;
            }
            else if (idOldCustomer == -1)
            {
                insertKhachHang();
                phieuxuat.MaKH = BUS_KhachHang.Instance.currentID();
            }
            else
            {
                phieuxuat.MaKH = idOldCustomer;
            }

            if (BUS_PhieuXuat.Instance.insert(phieuxuat) > 0)
            {
                insertCT_PhieuXuat();
                actionReloadHang();
                MessageBox.Show("Thanh toán thành công");

                flpDanhSachSanPham.Controls.Clear();
                items_picked.Clear();
                dt_hang.Clear();

                totalPaymentAmount();
            }
        }

        void insertKhachHang()
        {
            KhachHang khachhang = new KhachHang();
            khachhang.HoTen = txtTenKhachHang.Text;
            khachhang.Sdt = txtSDTKhachHang.Text;
            khachhang.NamSinh = dtpkNamSinhKhachHang.Value.ToString();
            khachhang.NgayTao = DateTime.Now.ToString();

            BUS_KhachHang.Instance.LuuBangKhachHang(khachhang);
        }

        void insertCT_PhieuXuat()
        {
            int currentID = BUS_PhieuXuat.Instance.currentID();
            foreach (DataRow row in dt_hang.Rows)
            {
                int maHang = Convert.ToInt32(row["MAHANG"]);
                ChiTietPhieuXuat ct_phieuxuat = new ChiTietPhieuXuat();
                ct_phieuxuat.MaPhieuXuat = currentID;
                ct_phieuxuat.MaHang = maHang;
                ct_phieuxuat.SoLuong = Convert.ToInt32(items_picked[maHang.ToString()]);
                ct_phieuxuat.GiaXuat = Convert.ToInt32(row["GIA"]);

                if (BUS_ChiTietPhieuXuat.Instance.insert(ct_phieuxuat) > 0)
                {
                    BUS_Hang.Instance.updateSoLuongHang(maHang, Convert.ToInt32(items_picked[maHang.ToString()]));
                }
            }
        }
        
        void clearInputKhachHang()
        {
            txtTenKhachHang.Text = "";
            txtSDTKhachHang.Text = "";
            dtpkNamSinhKhachHang.Value = DateTime.Now;
        }

        private void BtnKhachMoi_Click(object sender, EventArgs e)
        {
            this.isAnonymousCustomer = false;
            txtTenKhachHang.Enabled = true;
            txtSDTKhachHang.Enabled = true;
            dtpkNamSinhKhachHang.Enabled = true;
            clearInputKhachHang();
            
        }

        string formatCultureToString(int num)
        {
            return String.Format("{0:n0}", num);

        }

        string sanitizeString(string str)
        {
            string strSanitize = String.Join("", str.Split(',', '.'));
            int idx = strSanitize.IndexOf(' ');
            
            strSanitize = strSanitize.Remove(idx);


            return strSanitize;
        }
    }
}
