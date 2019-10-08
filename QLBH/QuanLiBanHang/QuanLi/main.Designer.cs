namespace QuanLi
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.heThongToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.dangNhapToolStripHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.dangXuatToolStripHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heThongToolStrip,
            this.thốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(507, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // heThongToolStrip
            // 
            this.heThongToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dangNhapToolStripHeThong,
            this.dangXuatToolStripHeThong});
            this.heThongToolStrip.Name = "heThongToolStrip";
            this.heThongToolStrip.Size = new System.Drawing.Size(69, 20);
            this.heThongToolStrip.Text = "Hệ thống";
            // 
            // dangNhapToolStripHeThong
            // 
            this.dangNhapToolStripHeThong.Name = "dangNhapToolStripHeThong";
            this.dangNhapToolStripHeThong.Size = new System.Drawing.Size(152, 22);
            this.dangNhapToolStripHeThong.Text = "Đăng nhập";
            this.dangNhapToolStripHeThong.Click += new System.EventHandler(this.dangNhapToolStripHeThong_Click);
            // 
            // dangXuatToolStripHeThong
            // 
            this.dangXuatToolStripHeThong.Name = "dangXuatToolStripHeThong";
            this.dangXuatToolStripHeThong.Size = new System.Drawing.Size(152, 22);
            this.dangXuatToolStripHeThong.Text = "Đăng xuất";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 379);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem heThongToolStrip;
        private System.Windows.Forms.ToolStripMenuItem dangNhapToolStripHeThong;
        private System.Windows.Forms.ToolStripMenuItem dangXuatToolStripHeThong;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
    }
}