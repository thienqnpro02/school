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
            this.dgtvDanhSachHang = new System.Windows.Forms.DataGridView();
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
            this.btnTimKhachCu = new System.Windows.Forms.Button();
            this.btnLamSachGio = new System.Windows.Forms.Button();
            this.cbInBienLai = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgtvDanhSachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgtvDanhSachHang
            // 
            this.dgtvDanhSachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtvDanhSachHang.Location = new System.Drawing.Point(12, 12);
            this.dgtvDanhSachHang.Name = "dgtvDanhSachHang";
            this.dgtvDanhSachHang.Size = new System.Drawing.Size(472, 364);
            this.dgtvDanhSachHang.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(490, 142);
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
            this.label3.Location = new System.Drawing.Point(490, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(565, 48);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(128, 20);
            this.txtTenKhachHang.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(490, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "SDT";
            // 
            // txtSDTKhachHang
            // 
            this.txtSDTKhachHang.Location = new System.Drawing.Point(565, 90);
            this.txtSDTKhachHang.Name = "txtSDTKhachHang";
            this.txtSDTKhachHang.Size = new System.Drawing.Size(128, 20);
            this.txtSDTKhachHang.TabIndex = 2;
            // 
            // dtpkNamSinhKhachHang
            // 
            this.dtpkNamSinhKhachHang.Location = new System.Drawing.Point(565, 136);
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
            // 
            // btnTimKhachCu
            // 
            this.btnTimKhachCu.Location = new System.Drawing.Point(493, 174);
            this.btnTimKhachCu.Name = "btnTimKhachCu";
            this.btnTimKhachCu.Size = new System.Drawing.Size(200, 23);
            this.btnTimKhachCu.TabIndex = 4;
            this.btnTimKhachCu.Text = "Tìm khách cũ";
            this.btnTimKhachCu.UseVisualStyleBackColor = true;
            // 
            // btnLamSachGio
            // 
            this.btnLamSachGio.Location = new System.Drawing.Point(493, 215);
            this.btnLamSachGio.Name = "btnLamSachGio";
            this.btnLamSachGio.Size = new System.Drawing.Size(200, 23);
            this.btnLamSachGio.TabIndex = 4;
            this.btnLamSachGio.Text = "Làm sạch giỏ";
            this.btnLamSachGio.UseVisualStyleBackColor = true;
            // 
            // cbInBienLai
            // 
            this.cbInBienLai.AutoSize = true;
            this.cbInBienLai.Location = new System.Drawing.Point(493, 255);
            this.cbInBienLai.Name = "cbInBienLai";
            this.cbInBienLai.Size = new System.Drawing.Size(72, 17);
            this.cbInBienLai.TabIndex = 5;
            this.cbInBienLai.Text = "In Biên lai";
            this.cbInBienLai.UseVisualStyleBackColor = true;
            // 
            // frm_GioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 388);
            this.Controls.Add(this.cbInBienLai);
            this.Controls.Add(this.btnLamSachGio);
            this.Controls.Add(this.btnTimKhachCu);
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
            this.Controls.Add(this.dgtvDanhSachHang);
            this.Name = "frm_GioHang";
            this.Text = "Giỏ hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgtvDanhSachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgtvDanhSachHang;
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
        private System.Windows.Forms.Button btnTimKhachCu;
        private System.Windows.Forms.Button btnLamSachGio;
        private System.Windows.Forms.CheckBox cbInBienLai;
    }
}