namespace BanLinhKien
{
    partial class frm_GioHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSDTKhachHang = new System.Windows.Forms.TextBox();
            this.dtpkNamSinhKhachHang = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnChonKhachCu = new System.Windows.Forms.Button();
            this.cbInBienLai = new System.Windows.Forms.CheckBox();
            this.flpDanhSachSanPham = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClearGio = new System.Windows.Forms.Button();
            this.btnKhachMoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(490, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Năm Sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(541, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thông Tin Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(490, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Enabled = false;
            this.txtTenKhachHang.Location = new System.Drawing.Point(565, 86);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(128, 20);
            this.txtTenKhachHang.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(490, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "SDT";
            // 
            // txtSDTKhachHang
            // 
            this.txtSDTKhachHang.Enabled = false;
            this.txtSDTKhachHang.Location = new System.Drawing.Point(565, 128);
            this.txtSDTKhachHang.Name = "txtSDTKhachHang";
            this.txtSDTKhachHang.Size = new System.Drawing.Size(128, 20);
            this.txtSDTKhachHang.TabIndex = 2;
            // 
            // dtpkNamSinhKhachHang
            // 
            this.dtpkNamSinhKhachHang.Enabled = false;
            this.dtpkNamSinhKhachHang.Location = new System.Drawing.Point(565, 174);
            this.dtpkNamSinhKhachHang.Name = "dtpkNamSinhKhachHang";
            this.dtpkNamSinhKhachHang.Size = new System.Drawing.Size(128, 20);
            this.dtpkNamSinhKhachHang.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(490, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tổng Tiền:";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(562, 307);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(75, 13);
            this.lblTongTien.TabIndex = 1;
            this.lblTongTien.Text = "9999999 VNĐ";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(493, 344);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(200, 36);
            this.btnThanhToan.TabIndex = 4;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.BtnThanhToan_Click);
            // 
            // btnChonKhachCu
            // 
            this.btnChonKhachCu.Location = new System.Drawing.Point(493, 46);
            this.btnChonKhachCu.Name = "btnChonKhachCu";
            this.btnChonKhachCu.Size = new System.Drawing.Size(100, 23);
            this.btnChonKhachCu.TabIndex = 4;
            this.btnChonKhachCu.Text = "Chọn khách cũ";
            this.btnChonKhachCu.UseVisualStyleBackColor = true;
            this.btnChonKhachCu.Click += new System.EventHandler(this.BtnChonKhachCu_Click);
            // 
            // cbInBienLai
            // 
            this.cbInBienLai.AutoSize = true;
            this.cbInBienLai.Location = new System.Drawing.Point(621, 214);
            this.cbInBienLai.Name = "cbInBienLai";
            this.cbInBienLai.Size = new System.Drawing.Size(72, 17);
            this.cbInBienLai.TabIndex = 5;
            this.cbInBienLai.Text = "In Biên lai";
            this.cbInBienLai.UseVisualStyleBackColor = true;
            // 
            // flpDanhSachSanPham
            // 
            this.flpDanhSachSanPham.AutoScroll = true;
            this.flpDanhSachSanPham.Location = new System.Drawing.Point(12, 12);
            this.flpDanhSachSanPham.Name = "flpDanhSachSanPham";
            this.flpDanhSachSanPham.Padding = new System.Windows.Forms.Padding(5);
            this.flpDanhSachSanPham.Size = new System.Drawing.Size(472, 328);
            this.flpDanhSachSanPham.TabIndex = 6;
            // 
            // btnClearGio
            // 
            this.btnClearGio.Location = new System.Drawing.Point(12, 346);
            this.btnClearGio.Name = "btnClearGio";
            this.btnClearGio.Size = new System.Drawing.Size(116, 36);
            this.btnClearGio.TabIndex = 4;
            this.btnClearGio.Text = "Làm sạch giỏ";
            this.btnClearGio.UseVisualStyleBackColor = true;
            this.btnClearGio.Click += new System.EventHandler(this.BtnClearGio_Click);
            // 
            // btnKhachMoi
            // 
            this.btnKhachMoi.Location = new System.Drawing.Point(600, 46);
            this.btnKhachMoi.Name = "btnKhachMoi";
            this.btnKhachMoi.Size = new System.Drawing.Size(100, 23);
            this.btnKhachMoi.TabIndex = 4;
            this.btnKhachMoi.Text = "Khách mới";
            this.btnKhachMoi.UseVisualStyleBackColor = true;
            this.btnKhachMoi.Click += new System.EventHandler(this.BtnKhachMoi_Click);
            // 
            // frm_GioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(705, 388);
            this.Controls.Add(this.flpDanhSachSanPham);
            this.Controls.Add(this.cbInBienLai);
            this.Controls.Add(this.btnKhachMoi);
            this.Controls.Add(this.btnChonKhachCu);
            this.Controls.Add(this.btnClearGio);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.dtpkNamSinhKhachHang);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.txtSDTKhachHang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_GioHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Giỏ hàng";
            this.Load += new System.EventHandler(this.Frm_GioHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSDTKhachHang;
        private System.Windows.Forms.DateTimePicker dtpkNamSinhKhachHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnChonKhachCu;
        private System.Windows.Forms.CheckBox cbInBienLai;
        private System.Windows.Forms.FlowLayoutPanel flpDanhSachSanPham;
        private System.Windows.Forms.Button btnClearGio;
        private System.Windows.Forms.Button btnKhachMoi;
    }
}