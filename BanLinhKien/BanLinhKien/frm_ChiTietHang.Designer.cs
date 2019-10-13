namespace BanLinhKien
{
    partial class frm_ChiTietHang
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
            this.picHang = new System.Windows.Forms.PictureBox();
            this.lblTenHang = new System.Windows.Forms.Label();
            this.lblThongSo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBaoHanh = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picHang)).BeginInit();
            this.SuspendLayout();
            // 
            // picHang
            // 
            this.picHang.Location = new System.Drawing.Point(12, 12);
            this.picHang.Name = "picHang";
            this.picHang.Size = new System.Drawing.Size(176, 181);
            this.picHang.TabIndex = 0;
            this.picHang.TabStop = false;
            // 
            // lblTenHang
            // 
            this.lblTenHang.Location = new System.Drawing.Point(194, 12);
            this.lblTenHang.Name = "lblTenHang";
            this.lblTenHang.Size = new System.Drawing.Size(296, 23);
            this.lblTenHang.TabIndex = 1;
            this.lblTenHang.Text = "Tên Hàng";
            this.lblTenHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThongSo
            // 
            this.lblThongSo.Location = new System.Drawing.Point(194, 65);
            this.lblThongSo.Name = "lblThongSo";
            this.lblThongSo.Size = new System.Drawing.Size(296, 115);
            this.lblThongSo.TabIndex = 2;
            this.lblThongSo.Text = "Thông số .... Thông số ....Thông số ....Thông số ....Thông số ....Thông số ....Th" +
    "ông số ....Thông số ....Thông số ....Thông số ....Thông số ....Thông số ....";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bảo hành: ";
            // 
            // lblBaoHanh
            // 
            this.lblBaoHanh.AutoSize = true;
            this.lblBaoHanh.Location = new System.Drawing.Point(259, 180);
            this.lblBaoHanh.Name = "lblBaoHanh";
            this.lblBaoHanh.Size = new System.Drawing.Size(49, 13);
            this.lblBaoHanh.TabIndex = 2;
            this.lblBaoHanh.Text = "36 tháng";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(415, 228);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(75, 13);
            this.lblGia.TabIndex = 2;
            this.lblGia.Text = "9999999 VND";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(342, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Giá";
            // 
            // frm_ChiTietHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 266);
            this.Controls.Add(this.lblBaoHanh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblThongSo);
            this.Controls.Add(this.lblTenHang);
            this.Controls.Add(this.picHang);
            this.Name = "frm_ChiTietHang";
            this.Text = "Chi tiết hàng";
            ((System.ComponentModel.ISupportInitialize)(this.picHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picHang;
        private System.Windows.Forms.Label lblTenHang;
        private System.Windows.Forms.Label lblThongSo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBaoHanh;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label label6;
    }
}