namespace BanLinhKien
{
    partial class frm_ChonKhach
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
            this.flpDanhSachKhachHang = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpDanhSachKhachHang
            // 
            this.flpDanhSachKhachHang.AutoScroll = true;
            this.flpDanhSachKhachHang.Location = new System.Drawing.Point(12, 12);
            this.flpDanhSachKhachHang.Name = "flpDanhSachKhachHang";
            this.flpDanhSachKhachHang.Padding = new System.Windows.Forms.Padding(5);
            this.flpDanhSachKhachHang.Size = new System.Drawing.Size(361, 328);
            this.flpDanhSachKhachHang.TabIndex = 7;
            // 
            // frm_ChonKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 348);
            this.Controls.Add(this.flpDanhSachKhachHang);
            this.Name = "frm_ChonKhach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chọn khách hàng";
            this.Load += new System.EventHandler(this.Frm_ChonKhach_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpDanhSachKhachHang;
    }
}