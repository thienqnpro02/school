﻿namespace BanLinhKien
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
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbLocHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTongTrang
            // 
            this.lblTongTrang.AutoSize = true;
            this.lblTongTrang.Location = new System.Drawing.Point(357, 449);
            this.lblTongTrang.Name = "lblTongTrang";
            this.lblTongTrang.Size = new System.Drawing.Size(18, 13);
            this.lblTongTrang.TabIndex = 23;
            this.lblTongTrang.Text = "/0";
            // 
            // txtTrang
            // 
            this.txtTrang.Enabled = false;
            this.txtTrang.Location = new System.Drawing.Point(312, 446);
            this.txtTrang.Name = "txtTrang";
            this.txtTrang.Size = new System.Drawing.Size(39, 20);
            this.txtTrang.TabIndex = 22;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(583, 444);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 23);
            this.btnNext.TabIndex = 20;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(12, 444);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(100, 23);
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
            this.gbLocHang.Location = new System.Drawing.Point(19, 23);
            this.gbLocHang.Name = "gbLocHang";
            this.gbLocHang.Size = new System.Drawing.Size(368, 102);
            this.gbLocHang.TabIndex = 19;
            this.gbLocHang.TabStop = false;
            this.gbLocHang.Text = "Lọc Hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Danh Mục:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sắp Xếp Theo:";
            // 
            // cbLocDanhMuc
            // 
            this.cbLocDanhMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocDanhMuc.FormattingEnabled = true;
            this.cbLocDanhMuc.Location = new System.Drawing.Point(99, 20);
            this.cbLocDanhMuc.Name = "cbLocDanhMuc";
            this.cbLocDanhMuc.Size = new System.Drawing.Size(263, 21);
            this.cbLocDanhMuc.TabIndex = 1;
            this.cbLocDanhMuc.SelectedValueChanged += new System.EventHandler(this.cbLocDanhMuc_SelectedValueChanged);
            // 
            // cbSapXep
            // 
            this.cbSapXep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSapXep.FormattingEnabled = true;
            this.cbSapXep.Items.AddRange(new object[] {
            "Mặc định",
            "Giá giảm dần",
            "Giá tăng dần"});
            this.cbSapXep.Location = new System.Drawing.Point(99, 54);
            this.cbSapXep.Name = "cbSapXep";
            this.cbSapXep.Size = new System.Drawing.Size(263, 21);
            this.cbSapXep.TabIndex = 1;
            this.cbSapXep.SelectedIndexChanged += new System.EventHandler(this.cbSapXep_SelectedIndexChanged);
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(489, 141);
            this.numSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(81, 20);
            this.numSoLuong.TabIndex = 18;
            this.numSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnThemVaoGioNhapHang
            // 
            this.btnThemVaoGioNhapHang.Location = new System.Drawing.Point(585, 141);
            this.btnThemVaoGioNhapHang.Name = "btnThemVaoGioNhapHang";
            this.btnThemVaoGioNhapHang.Size = new System.Drawing.Size(98, 23);
            this.btnThemVaoGioNhapHang.TabIndex = 17;
            this.btnThemVaoGioNhapHang.Text = "Thêm vào phiếu";
            this.btnThemVaoGioNhapHang.UseVisualStyleBackColor = true;
            this.btnThemVaoGioNhapHang.Click += new System.EventHandler(this.btnThemVaoGioNhapHang_Click);
            // 
            // btnGioNhapHang
            // 
            this.btnGioNhapHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGioNhapHang.Location = new System.Drawing.Point(489, 32);
            this.btnGioNhapHang.Name = "btnGioNhapHang";
            this.btnGioNhapHang.Size = new System.Drawing.Size(194, 66);
            this.btnGioNhapHang.TabIndex = 16;
            this.btnGioNhapHang.Text = "Phiếu nhập (0)";
            this.btnGioNhapHang.UseVisualStyleBackColor = true;
            this.btnGioNhapHang.Click += new System.EventHandler(this.BtnGioNhapHang_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(312, 141);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 15;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(19, 144);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(270, 20);
            this.txtTimKiem.TabIndex = 14;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // dgvDanhSachHang
            // 
            this.dgvDanhSachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahang,
            this.tenhang,
            this.SOLUONG,
            this.gia});
            this.dgvDanhSachHang.Location = new System.Drawing.Point(12, 186);
            this.dgvDanhSachHang.Name = "dgvDanhSachHang";
            this.dgvDanhSachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachHang.Size = new System.Drawing.Size(671, 238);
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
            this.tenhang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenhang.DataPropertyName = "tenhang";
            this.tenhang.HeaderText = "Tên Hàng";
            this.tenhang.Name = "tenhang";
            // 
            // SOLUONG
            // 
            this.SOLUONG.DataPropertyName = "SOLUONG";
            this.SOLUONG.HeaderText = "Số Lượng";
            this.SOLUONG.Name = "SOLUONG";
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 487);
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
            this.Name = "frm_NhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nhập hàng";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
    }
}