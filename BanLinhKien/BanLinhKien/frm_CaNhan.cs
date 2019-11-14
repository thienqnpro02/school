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
    public partial class frm_CaNhan : Form
    {
        BUS_NhanVien bus_nhanvien = BUS_NhanVien.Instance;
        public frm_CaNhan()
        {
            InitializeComponent();
        }

        private void frm_CaNhan_Load(object sender, EventArgs e)
        {
             txtMatKhauCu.Text=null;
             txtMatKhauMoi.Text=null;
             txtReMatKhauMoi.Text=null;
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            String matkhaucu = txtMatKhauCu.Text;
            String matkhaumoi = txtMatKhauMoi.Text;
            String matkhaumoi2 = txtReMatKhauMoi.Text;

            int manv=bus_nhanvien.KiemTraMatKhauCu(matkhaucu);
            if (manv>0)
            {
                if (!matkhaumoi.Equals("") && !matkhaumoi2.Equals(""))
                {
                    if (matkhaumoi.Equals(matkhaumoi2))
                    {
                        String note=(bus_nhanvien.CapNhapLaiMatKhau(matkhaumoi, manv)>0)?
                            "Đổi mật khẩu thành công":"Đổi mật khẩu không thành công";
                        MessageBox.Show(note);
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu mới không khớp");
                    }
                }
                else
                {
                    MessageBox.Show("Mời nhập mật khẩu mới");
                }
            }
            else
            {
                MessageBox.Show("Sai mật khẩu");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
