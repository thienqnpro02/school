namespace QuanLi
{
    partial class frmDanhSachKH
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
            this.lbKhachHang = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbKhachHang
            // 
            this.lbKhachHang.FormattingEnabled = true;
            this.lbKhachHang.Location = new System.Drawing.Point(12, 12);
            this.lbKhachHang.Name = "lbKhachHang";
            this.lbKhachHang.Size = new System.Drawing.Size(299, 212);
            this.lbKhachHang.TabIndex = 0;
            this.lbKhachHang.SelectedIndexChanged += new System.EventHandler(this.lbKhachHang_SelectedIndexChanged);
            // 
            // frmDanhSachKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 260);
            this.Controls.Add(this.lbKhachHang);
            this.Name = "frmDanhSachKH";
            this.Text = "frmDanhSachKH";
            this.Load += new System.EventHandler(this.frmDanhSachKH_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbKhachHang;
    }
}