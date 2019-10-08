namespace BaiTapQuanLyBH
{
    partial class main
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
            this.menuStripFormMain = new System.Windows.Forms.MenuStrip();
            this.heThongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangNhapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangXuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhapHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiTietPhieuNhapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuatHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiTiếtPhiếuXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thuTienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ghiPhiếuThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripFormMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripFormMain
            // 
            this.menuStripFormMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heThongToolStripMenuItem,
            this.nhapHangToolStripMenuItem,
            this.xuatHangToolStripMenuItem,
            this.thuTienToolStripMenuItem});
            this.menuStripFormMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripFormMain.Name = "menuStripFormMain";
            this.menuStripFormMain.Size = new System.Drawing.Size(705, 24);
            this.menuStripFormMain.TabIndex = 1;
            this.menuStripFormMain.Text = "menuStrip1";
            // 
            // heThongToolStripMenuItem
            // 
            this.heThongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dangNhapToolStripMenuItem,
            this.dangXuatToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.heThongToolStripMenuItem.Name = "heThongToolStripMenuItem";
            this.heThongToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.heThongToolStripMenuItem.Text = "Hệ thống";
            // 
            // dangNhapToolStripMenuItem
            // 
            this.dangNhapToolStripMenuItem.Name = "dangNhapToolStripMenuItem";
            this.dangNhapToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dangNhapToolStripMenuItem.Text = "Đăng nhập";
            this.dangNhapToolStripMenuItem.Click += new System.EventHandler(this.đăngNhậpToolStripMenuItem_Click);
            // 
            // dangXuatToolStripMenuItem
            // 
            this.dangXuatToolStripMenuItem.Name = "dangXuatToolStripMenuItem";
            this.dangXuatToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dangXuatToolStripMenuItem.Text = "Đăng xuất";
            this.dangXuatToolStripMenuItem.Visible = false;
            this.dangXuatToolStripMenuItem.Click += new System.EventHandler(this.dangXuatToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // nhapHangToolStripMenuItem
            // 
            this.nhapHangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chiTietPhieuNhapToolStripMenuItem});
            this.nhapHangToolStripMenuItem.Enabled = false;
            this.nhapHangToolStripMenuItem.Name = "nhapHangToolStripMenuItem";
            this.nhapHangToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.nhapHangToolStripMenuItem.Text = "Nhập hàng";
            // 
            // chiTietPhieuNhapToolStripMenuItem
            // 
            this.chiTietPhieuNhapToolStripMenuItem.Name = "chiTietPhieuNhapToolStripMenuItem";
            this.chiTietPhieuNhapToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.chiTietPhieuNhapToolStripMenuItem.Text = "Chi tiết phiếu nhập";
            this.chiTietPhieuNhapToolStripMenuItem.Click += new System.EventHandler(this.chiTiếtPhiếuNhậpToolStripMenuItem_Click);
            // 
            // xuatHangToolStripMenuItem
            // 
            this.xuatHangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chiTiếtPhiếuXuấtToolStripMenuItem});
            this.xuatHangToolStripMenuItem.Enabled = false;
            this.xuatHangToolStripMenuItem.Name = "xuatHangToolStripMenuItem";
            this.xuatHangToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.xuatHangToolStripMenuItem.Text = "Xuất hàng";
            // 
            // chiTiếtPhiếuXuấtToolStripMenuItem
            // 
            this.chiTiếtPhiếuXuấtToolStripMenuItem.Name = "chiTiếtPhiếuXuấtToolStripMenuItem";
            this.chiTiếtPhiếuXuấtToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.chiTiếtPhiếuXuấtToolStripMenuItem.Text = "Chi tiết phiếu xuất";
            this.chiTiếtPhiếuXuấtToolStripMenuItem.Click += new System.EventHandler(this.chiTiếtPhiếuXuấtToolStripMenuItem_Click);
            // 
            // thuTienToolStripMenuItem
            // 
            this.thuTienToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ghiPhiếuThuToolStripMenuItem,
            this.hóaĐơnToolStripMenuItem});
            this.thuTienToolStripMenuItem.Enabled = false;
            this.thuTienToolStripMenuItem.Name = "thuTienToolStripMenuItem";
            this.thuTienToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.thuTienToolStripMenuItem.Text = "Thu tiền";
            // 
            // ghiPhiếuThuToolStripMenuItem
            // 
            this.ghiPhiếuThuToolStripMenuItem.Name = "ghiPhiếuThuToolStripMenuItem";
            this.ghiPhiếuThuToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.ghiPhiếuThuToolStripMenuItem.Text = "Ghi phiếu thu";
            this.ghiPhiếuThuToolStripMenuItem.Click += new System.EventHandler(this.ghiPhiếuThuToolStripMenuItem_Click);
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa đơn";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 492);
            this.Controls.Add(this.menuStripFormMain);
            this.IsMdiContainer = true;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.main_Load);
            this.menuStripFormMain.ResumeLayout(false);
            this.menuStripFormMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripFormMain;
        private System.Windows.Forms.ToolStripMenuItem heThongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangNhapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangXuatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhapHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chiTietPhieuNhapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuatHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chiTiếtPhiếuXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thuTienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ghiPhiếuThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;


    }
}

