﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanLinhKien
{
    public partial class frm_GioHang : Form
    {
        public frm_GioHang()
        {
            InitializeComponent();
        }

        private void BtnChonKhachCu_Click(object sender, EventArgs e)
        {
            frm_ChonKhach form_ChonKhach = new frm_ChonKhach();
            form_ChonKhach.ShowDialog();
        }
    }
}
