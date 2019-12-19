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
using BUS;
using DTO;

namespace BanLinhKien
{
    public partial class frm_ChiTietPhieuNhap : Form
    {
	    BUS_Hang bus_hang = BUS_Hang.Instance;
        BUS_NCC bus_ncc = BUS_NCC.Instance;
        BUS_PhieuNhap bus_phieunhap = BUS_PhieuNhap.Instance;
        BUS_ChiTietPhieuNhap bus_chitietphieunhap = BUS_ChiTietPhieuNhap.Instance;

        private DataTable ncc = new DataTable();
        private List<Label> listlabel = new List<Label>();
        public delegate void ReloadHang();
        public ReloadHang actionReloadHang;

        public frm_ChiTietPhieuNhap()
        {
            InitializeComponent();
        }
        private Hashtable listhang = frm_NhapHang.ListHang();

        private void frm_ChiTietPhieuNhap_Load(object sender, EventArgs e)
        {
            ncc = bus_ncc.BangNCC();
            LoadHang();
            BuocVaoComboBox_NCC();
            
        }

        int i = 0;
        private void LoadHang()
        {
            foreach (Hang hang in listhang.Values)
            {
                GroupBox_HangNhap(hang);
                i++;
            }
            totalPaymentAmount();
        }

        private void GroupBox_HangNhap(Hang hang)
        {
            GroupBox groupbox_hangnhap = new GroupBox();
            groupbox_hangnhap.Size = groupBox1.Size;
            groupbox_hangnhap.Name = "groupbox_hangnhap" + hang.MaHang.ToString();
            groupbox_hangnhap.TabIndex = i;

            Label label_tenhang = new Label();
            label_tenhang.Name = "lb_hang" + hang.MaHang;
            label_tenhang.Size = label11.Size;
            label_tenhang.Text = hang.TenHang;
            label_tenhang.Location = label11.Location;

            Label label_gianhap = new Label();
            label_gianhap.Size = label9.Size;
            label_gianhap.Text = "Giá nhập";
            label_gianhap.Name = "lb_gianhap" + hang.MaHang;
            label_gianhap.Location = label9.Location;

            Label label_soluong = new Label();
            label_soluong.Size = label10.Size;
            label_soluong.Text = "Số lượng";
            label_soluong.Name = "lb_soluong" + hang.MaHang;
            label_soluong.Location = label10.Location;

            PictureBox pic = new PictureBox();
            pic.Size = pictureBox1.Size;
            pic.Name = "pic" + hang.MaHang;
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.ImageLocation =bus_hang.pathImage + hang.Hinh.ToString();
            pic.Location = pictureBox1.Location;

            NumericUpDown num = new NumericUpDown();
            num.Minimum = 0;
            num.Maximum = Int32.MaxValue;
            num.Size = numericUpDown2.Size;
            num.Name = "num" + hang.MaHang;
            num.Value = hang.SoLuong;
            num.Location = numericUpDown2.Location;
            num.ValueChanged += Num_SoLuong_ValueChanged;
            num.Tag = hang.MaHang;
            num.TabIndex = i;

            TextBox textGia = new TextBox();
            textGia.Name = "tb_" + hang.SoLuong;
            textGia.Size = textBox1.Size;
            textGia.Location = textBox1.Location;
            textGia.TextChanged += Text_Gia_TextChanged;
            textGia.Tag = hang.MaHang;
            textGia.Text = "0";
            textGia.TabIndex = i;

            Label label_gia = new Label();
            label_gia.Size = label5.Size;
            label_gia.Name = "lb_gia" + hang.MaHang;
            label_gia.Location = label5.Location;
            label_gia.Text = (num.Value * Convert.ToInt32(textGia.Text)).ToString()+" VNĐ";
            label_gia.Tag = hang.MaHang;
            listlabel.Add(label_gia);

            Button btn_xemchitiet = new Button();
            btn_xemchitiet.Size = btnChiTietHang.Size;
            btn_xemchitiet.Name = "btn_xemchitiet" + hang.MaHang;
            btn_xemchitiet.Text = "Xem chi tiết";
            btn_xemchitiet.Location = btnChiTietHang.Location;
            btn_xemchitiet.Tag = hang.MaHang;
            btn_xemchitiet.Click += BtnXemChiTiet_Click;

            Button btnDel = new Button();
            btnDel.Size = button1.Size;
            btnDel.Name = "btn_clear" + hang.MaHang;
            btnDel.Location = button1.Location;
            btnDel.BackColor = System.Drawing.Color.Red;
            btnDel.Text = "X";
            btnDel.ForeColor = System.Drawing.Color.White;
            btnDel.Font=new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnDel.Tag = hang.MaHang;
            btnDel.Click += BtnDel_Click;

            groupbox_hangnhap.Controls.Add(label_tenhang);
            groupbox_hangnhap.Controls.Add(pic);
            groupbox_hangnhap.Controls.Add(num);
            groupbox_hangnhap.Controls.Add(textGia);
            groupbox_hangnhap.Controls.Add(btn_xemchitiet);
            groupbox_hangnhap.Controls.Add(btnDel);
            groupbox_hangnhap.Controls.Add(label_soluong);
            groupbox_hangnhap.Controls.Add(label_gia);
            groupbox_hangnhap.Controls.Add(label_gianhap);

            flpDanhSachSanPham.Controls.Add(groupbox_hangnhap);
        }

        private void BuocVaoComboBox_NCC()
        {
            cbNhaCungCap.DataSource =ncc;
            cbNhaCungCap.DisplayMember = "TenNCC";
            cbNhaCungCap.ValueMember = "MaNCC";
            cbNhaCungCap.SelectedValue = 1;
            BuocVaoCacDieuKhien_NCC();
        }

        private void BuocVaoCacDieuKhien_NCC()
        {
            try
            {
                int mancc = Convert.ToInt32(cbNhaCungCap.SelectedValue);
                DataView dataView = new DataView(ncc);
                dataView.RowFilter = String.Format("mancc = {0}", mancc);

                txtDiaChi.DataBindings.Clear();
                txtFax.DataBindings.Clear();
                txtEmail.DataBindings.Clear();

                txtDiaChi.DataBindings.Add("Text", dataView, "diachi");
                txtFax.DataBindings.Add("Text", dataView, "fax");
                txtEmail.DataBindings.Add("Text", dataView, "email");
            }
            catch (InvalidCastException ex) { }
        }

        private void cbNhaCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuocVaoCacDieuKhien_NCC();
        }

        private void Num_SoLuong_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num_soluong = sender as NumericUpDown;
            Hang hang = (Hang)listhang[num_soluong.Tag];
            hang.SoLuong = (int)num_soluong.Value;

            Label label_gia=listlabel[num_soluong.TabIndex];
            label_gia.Text = formatCultureToString((hang.Gia * hang.SoLuong)) + " VNĐ";
            totalPaymentAmount();
        }

        private void Text_Gia_TextChanged(object sender, EventArgs e)
        {
            TextBox txt_gia = sender as TextBox;
            Hang hang = (Hang)listhang[txt_gia.Tag];
            try
            {

                if (txt_gia.TextLength < 12)
                {
                    hang.Gia = Convert.ToInt32(sanitizeString(txt_gia.Text));

                }
                else { txt_gia.Text = hang.Gia.ToString(); }
                
                if (!txt_gia.Text.Equals("0"))
                {
                    Label label_gia = listlabel[txt_gia.TabIndex];
                    label_gia.Text = formatCultureToString((hang.Gia * hang.SoLuong)) + " VNĐ";
                    txt_gia.Text = formatCultureToString(hang.Gia);
                    txt_gia.Select(txt_gia.TextLength, 0);
                    totalPaymentAmount();
                }
            }
            catch(FormatException ex) { }
        }

        private void btnClearPhieu_Click(object sender, EventArgs e)
        {
            flpDanhSachSanPham.Controls.Clear();
            listhang.Clear();
            listlabel.Clear();
            totalPaymentAmount();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            Button btnDel = sender as Button;
            GroupBox gp = btnDel.Parent as GroupBox;

            foreach(Label lbl in listlabel)
            {
                if (btnDel.Tag.ToString() == lbl.Tag.ToString())
                {
                    listlabel.Remove(lbl);
                    break;
                }                   
                
            }

            flpDanhSachSanPham.Controls.Remove(gp);
            listhang.Remove(btnDel.Tag);
            totalPaymentAmount();
        }

        private void BtnXemChiTiet_Click(object sender, EventArgs e)
        {
            Button btnXem = sender as Button;
            Hang hang=(Hang)listhang[btnXem.Tag];

            frm_ChiTietHang formChiTietHang = new frm_ChiTietHang();
            formChiTietHang.hang = hang;
            formChiTietHang.ShowDialog();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            if(listhang.Count > 0)
            {
                if (LuuBangPhieuNhap() > 0 && LuuBangChiTietPhieuNhap() > 0)
                {
                    actionReloadHang();
                    MessageBox.Show("Nhập hàng thành công");

                    listhang.Clear();
                    listlabel.Clear();
                    totalPaymentAmount();
                    flpDanhSachSanPham.Controls.Clear(); 
                }
            }
            else
            {
                MessageBox.Show("Chọn hàng trước khi nhập");
            }
              
        }

        private int LuuBangPhieuNhap()
        {
            String ngaytao = DateTime.Now.ToString("yyyy-MM-dd");
            int mancc = Convert.ToInt32(cbNhaCungCap.SelectedValue);

            PhieuNhap phieunhap = new PhieuNhap();
            phieunhap.NgayTao = ngaytao;
            phieunhap.MaNCC = mancc;
            phieunhap.MaNV = NhanVien.client.MaNV;

            int effect = bus_phieunhap.LuuBangPhieuNhap(phieunhap);
            return effect;
        }

        private int LuuBangChiTietPhieuNhap()
        {
            int maphieunhap = bus_chitietphieunhap.MaPhieuNhap();
            int effect = 0;
            int update = 0;
            foreach (Hang hang in listhang.Values)
            {
                ChiTietPhieuNhap chitietphieunhap = new ChiTietPhieuNhap();
                chitietphieunhap.MaPhieuNhap = maphieunhap;
                chitietphieunhap.MaHang = hang.MaHang;
                chitietphieunhap.SoLuong = hang.SoLuong;
                chitietphieunhap.GiaNhap = hang.Gia;

                effect += bus_chitietphieunhap.LuuBangChiTietPhieuNhap(chitietphieunhap);
                update +=bus_chitietphieunhap.CapNhapSoLuongHang(chitietphieunhap);
            }
            return (effect==listhang.Count && update==listhang.Count)?1:0;
        }

        private void totalPaymentAmount()
        {
            int total = 0;
            foreach (Label lbl in listlabel)
            {
                total += Convert.ToInt32(sanitizeString(lbl.Text));
            }

            lblTongTien.Text = formatCultureToString(total) + " VNĐ";
        }

        string formatCultureToString(int num)
        {
            return String.Format("{0:n0}", num);
        }

        string sanitizeString(string str)
        {
            int idx = str.IndexOf(' ');
            if(idx != -1)
            {
                str = str.Substring(0, idx);
            }
            
            return String.Join("", str.Split(',', '.'));
        }
    }
}
