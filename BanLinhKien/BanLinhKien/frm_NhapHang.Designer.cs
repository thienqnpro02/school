namespace BanLinhKien
{
    partial class frm_NhapHang
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
            this.lblTongTrang = new System.Windows.Forms.Label();
            this.txtTrang = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.gbLocHang = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLocDanhMuc = new System.Windows.Forms.ComboBox();
            this.cbSapXep = new System.Windows.Forms.ComboBox();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnThemVaoGioNhapHang = new System.Windows.Forms.Button();
            this.btnGioNhapHang = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgvDanhSachHang = new System.Windows.Forms.DataGridView();
            this.mahang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbLocHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTongTrang
            // 
            this.lblTongTrang.AutoSize = true;
            this.lblTongTrang.Location = new System.Drawing.Point(536, 691);
            this.lblTongTrang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongTrang.Name = "lblTongTrang";
            this.lblTongTrang.Size = new System.Drawing.Size(22, 20);
            this.lblTongTrang.TabIndex = 23;
            this.lblTongTrang.Text = "/0";
            // 
            // txtTrang
            // 
            this.txtTrang.Location = new System.Drawing.Point(468, 686);
            this.txtTrang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTrang.Name = "txtTrang";
            this.txtTrang.Size = new System.Drawing.Size(56, 26);
            this.txtTrang.TabIndex = 22;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(874, 683);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(150, 35);
            this.btnNext.TabIndex = 20;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(18, 683);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(150, 35);
            this.btnPrev.TabIndex = 21;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // gbLocHang
            // 
            this.gbLocHang.Controls.Add(this.label2);
            this.gbLocHang.Controls.Add(this.label1);
            this.gbLocHang.Controls.Add(this.cbLocDanhMuc);
            this.gbLocHang.Controls.Add(this.cbSapXep);
            this.gbLocHang.Location = new System.Drawing.Point(28, 35);
            this.gbLocHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbLocHang.Name = "gbLocHang";
            this.gbLocHang.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbLocHang.Size = new System.Drawing.Size(552, 157);
            this.gbLocHang.TabIndex = 19;
            this.gbLocHang.TabStop = false;
            this.gbLocHang.Text = "Lọc Hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Danh Mục:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sắp Xếp Theo:";
            // 
            // cbLocDanhMuc
            // 
            this.cbLocDanhMuc.FormattingEnabled = true;
            this.cbLocDanhMuc.Location = new System.Drawing.Point(148, 31);
            this.cbLocDanhMuc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbLocDanhMuc.Name = "cbLocDanhMuc";
            this.cbLocDanhMuc.Size = new System.Drawing.Size(392, 28);
            this.cbLocDanhMuc.TabIndex = 1;
            this.cbLocDanhMuc.SelectedValueChanged += new System.EventHandler(this.cbLocDanhMuc_SelectedValueChanged);
            // 
            // cbSapXep
            // 
            this.cbSapXep.FormattingEnabled = true;
            this.cbSapXep.Items.AddRange(new object[] {
            "Toàn bộ giá",
            "Giá giảm dần",
            "Giá tăng dần"});
            this.cbSapXep.Location = new System.Drawing.Point(148, 83);
            this.cbSapXep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSapXep.Name = "cbSapXep";
            this.cbSapXep.Size = new System.Drawing.Size(392, 28);
            this.cbSapXep.TabIndex = 1;
            this.cbSapXep.SelectedIndexChanged += new System.EventHandler(this.cbSapXep_SelectedIndexChanged);
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(734, 217);
            this.numSoLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(122, 26);
            this.numSoLuong.TabIndex = 18;
            this.numSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnThemVaoGioNhapHang
            // 
            this.btnThemVaoGioNhapHang.Location = new System.Drawing.Point(878, 217);
            this.btnThemVaoGioNhapHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemVaoGioNhapHang.Name = "btnThemVaoGioNhapHang";
            this.btnThemVaoGioNhapHang.Size = new System.Drawing.Size(147, 35);
            this.btnThemVaoGioNhapHang.TabIndex = 17;
            this.btnThemVaoGioNhapHang.Text = "Thêm vào phiếu";
            this.btnThemVaoGioNhapHang.UseVisualStyleBackColor = true;
            this.btnThemVaoGioNhapHang.Click += new System.EventHandler(this.btnThemVaoGioNhapHang_Click);
            // 
            // btnGioNhapHang
            // 
            this.btnGioNhapHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGioNhapHang.Location = new System.Drawing.Point(734, 49);
            this.btnGioNhapHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGioNhapHang.Name = "btnGioNhapHang";
            this.btnGioNhapHang.Size = new System.Drawing.Size(291, 102);
            this.btnGioNhapHang.TabIndex = 16;
            this.btnGioNhapHang.Text = "Phiếu nhập (0)";
            this.btnGioNhapHang.UseVisualStyleBackColor = true;
            this.btnGioNhapHang.Click += new System.EventHandler(this.BtnGioNhapHang_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(468, 217);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(112, 35);
            this.btnTimKiem.TabIndex = 15;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(28, 222);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(403, 26);
            this.txtTimKiem.TabIndex = 14;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // dgvDanhSachHang
            // 
            this.dgvDanhSachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahang,
            this.tenhang,
            this.gia});
            this.dgvDanhSachHang.Location = new System.Drawing.Point(18, 286);
            this.dgvDanhSachHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDanhSachHang.Name = "dgvDanhSachHang";
            this.dgvDanhSachHang.Size = new System.Drawing.Size(1006, 366);
            this.dgvDanhSachHang.TabIndex = 13;
            // 
            // mahang
            // 
            this.mahang.DataPropertyName = "mahang";
            this.mahang.HeaderText = "Ma Hang";
            this.mahang.Name = "mahang";
            // 
            // tenhang
            // 
            this.tenhang.DataPropertyName = "tenhang";
            this.tenhang.HeaderText = "Tên Hàng";
            this.tenhang.Name = "tenhang";
            this.tenhang.Width = 400;
            // 
            // gia
            // 
            this.gia.DataPropertyName = "gia";
            this.gia.HeaderText = "Giá ";
            this.gia.Name = "gia";
            this.gia.Width = 150;
            // 
            // frm_NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 754);
            this.Controls.Add(this.lblTongTrang);
            this.Controls.Add(this.txtTrang);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.gbLocHang);
            this.Controls.Add(this.numSoLuong);
            this.Controls.Add(this.btnThemVaoGioNhapHang);
            this.Controls.Add(this.btnGioNhapHang);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.dgvDanhSachHang);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_NhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_NhapHang";
            this.Load += new System.EventHandler(this.frm_NhapHang_Load);
            this.gbLocHang.ResumeLayout(false);
            this.gbLocHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTongTrang;
        private System.Windows.Forms.TextBox txtTrang;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.GroupBox gbLocHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLocDanhMuc;
        private System.Windows.Forms.ComboBox cbSapXep;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Button btnThemVaoGioNhapHang;
        private System.Windows.Forms.Button btnGioNhapHang;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvDanhSachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
    }
}