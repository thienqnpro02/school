namespace BanLinhKien
{
    partial class frm_ThongKe
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
            this.tabKhachHang = new System.Windows.Forms.TabPage();
            this.cbThongKeKhachHang = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpkFromKhachHang = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpkToKhachHang = new System.Windows.Forms.DateTimePicker();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPhieuXuat = new System.Windows.Forms.TabPage();
            this.cbThongKePhieuXuat = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpkFromPhieuXuat = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpkToPhieuXuat = new System.Windows.Forms.DateTimePicker();
            this.rpPhieuXuat = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPhieuNhap = new System.Windows.Forms.TabPage();
            this.cbThongKePhieuNhap = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpkFromPhieuNhap = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpkToPhieuNhap = new System.Windows.Forms.DateTimePicker();
            this.rpPhieuNhap = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rpKhachHang = new System.Windows.Forms.TabControl();
            this.tabKhachHang.SuspendLayout();
            this.tabPhieuXuat.SuspendLayout();
            this.tabPhieuNhap.SuspendLayout();
            this.rpKhachHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabKhachHang
            // 
            this.tabKhachHang.Controls.Add(this.reportViewer3);
            this.tabKhachHang.Controls.Add(this.dtpkToKhachHang);
            this.tabKhachHang.Controls.Add(this.label7);
            this.tabKhachHang.Controls.Add(this.dtpkFromKhachHang);
            this.tabKhachHang.Controls.Add(this.label8);
            this.tabKhachHang.Controls.Add(this.cbThongKeKhachHang);
            this.tabKhachHang.Location = new System.Drawing.Point(4, 22);
            this.tabKhachHang.Name = "tabKhachHang";
            this.tabKhachHang.Padding = new System.Windows.Forms.Padding(3);
            this.tabKhachHang.Size = new System.Drawing.Size(673, 473);
            this.tabKhachHang.TabIndex = 2;
            this.tabKhachHang.Text = "Khách hàng";
            this.tabKhachHang.UseVisualStyleBackColor = true;
            // 
            // cbThongKeKhachHang
            // 
            this.cbThongKeKhachHang.FormattingEnabled = true;
            this.cbThongKeKhachHang.Location = new System.Drawing.Point(221, 6);
            this.cbThongKeKhachHang.Name = "cbThongKeKhachHang";
            this.cbThongKeKhachHang.Size = new System.Drawing.Size(230, 21);
            this.cbThongKeKhachHang.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Từ";
            // 
            // dtpkFromKhachHang
            // 
            this.dtpkFromKhachHang.Location = new System.Drawing.Point(80, 40);
            this.dtpkFromKhachHang.Name = "dtpkFromKhachHang";
            this.dtpkFromKhachHang.Size = new System.Drawing.Size(200, 20);
            this.dtpkFromKhachHang.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(393, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Đến";
            // 
            // dtpkToKhachHang
            // 
            this.dtpkToKhachHang.Location = new System.Drawing.Point(467, 40);
            this.dtpkToKhachHang.Name = "dtpkToKhachHang";
            this.dtpkToKhachHang.Size = new System.Drawing.Size(200, 20);
            this.dtpkToKhachHang.TabIndex = 43;
            // 
            // reportViewer3
            // 
            this.reportViewer3.Location = new System.Drawing.Point(9, 66);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(658, 401);
            this.reportViewer3.TabIndex = 45;
            // 
            // tabPhieuXuat
            // 
            this.tabPhieuXuat.Controls.Add(this.rpPhieuXuat);
            this.tabPhieuXuat.Controls.Add(this.dtpkToPhieuXuat);
            this.tabPhieuXuat.Controls.Add(this.label4);
            this.tabPhieuXuat.Controls.Add(this.dtpkFromPhieuXuat);
            this.tabPhieuXuat.Controls.Add(this.label5);
            this.tabPhieuXuat.Controls.Add(this.cbThongKePhieuXuat);
            this.tabPhieuXuat.Location = new System.Drawing.Point(4, 22);
            this.tabPhieuXuat.Name = "tabPhieuXuat";
            this.tabPhieuXuat.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhieuXuat.Size = new System.Drawing.Size(673, 473);
            this.tabPhieuXuat.TabIndex = 1;
            this.tabPhieuXuat.Text = "Phiếu xuất";
            this.tabPhieuXuat.UseVisualStyleBackColor = true;
            // 
            // cbThongKePhieuXuat
            // 
            this.cbThongKePhieuXuat.FormattingEnabled = true;
            this.cbThongKePhieuXuat.Location = new System.Drawing.Point(221, 6);
            this.cbThongKePhieuXuat.Name = "cbThongKePhieuXuat";
            this.cbThongKePhieuXuat.Size = new System.Drawing.Size(230, 21);
            this.cbThongKePhieuXuat.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Từ";
            // 
            // dtpkFromPhieuXuat
            // 
            this.dtpkFromPhieuXuat.Location = new System.Drawing.Point(80, 40);
            this.dtpkFromPhieuXuat.Name = "dtpkFromPhieuXuat";
            this.dtpkFromPhieuXuat.Size = new System.Drawing.Size(200, 20);
            this.dtpkFromPhieuXuat.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Đến";
            // 
            // dtpkToPhieuXuat
            // 
            this.dtpkToPhieuXuat.Location = new System.Drawing.Point(467, 40);
            this.dtpkToPhieuXuat.Name = "dtpkToPhieuXuat";
            this.dtpkToPhieuXuat.Size = new System.Drawing.Size(200, 20);
            this.dtpkToPhieuXuat.TabIndex = 43;
            // 
            // rpPhieuXuat
            // 
            this.rpPhieuXuat.Location = new System.Drawing.Point(9, 66);
            this.rpPhieuXuat.Name = "rpPhieuXuat";
            this.rpPhieuXuat.ServerReport.BearerToken = null;
            this.rpPhieuXuat.Size = new System.Drawing.Size(658, 401);
            this.rpPhieuXuat.TabIndex = 45;
            // 
            // tabPhieuNhap
            // 
            this.tabPhieuNhap.Controls.Add(this.rpPhieuNhap);
            this.tabPhieuNhap.Controls.Add(this.dtpkToPhieuNhap);
            this.tabPhieuNhap.Controls.Add(this.label2);
            this.tabPhieuNhap.Controls.Add(this.dtpkFromPhieuNhap);
            this.tabPhieuNhap.Controls.Add(this.label1);
            this.tabPhieuNhap.Controls.Add(this.cbThongKePhieuNhap);
            this.tabPhieuNhap.Location = new System.Drawing.Point(4, 22);
            this.tabPhieuNhap.Name = "tabPhieuNhap";
            this.tabPhieuNhap.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhieuNhap.Size = new System.Drawing.Size(673, 473);
            this.tabPhieuNhap.TabIndex = 0;
            this.tabPhieuNhap.Text = "Phiếu nhập";
            this.tabPhieuNhap.UseVisualStyleBackColor = true;
            // 
            // cbThongKePhieuNhap
            // 
            this.cbThongKePhieuNhap.FormattingEnabled = true;
            this.cbThongKePhieuNhap.Location = new System.Drawing.Point(221, 6);
            this.cbThongKePhieuNhap.Name = "cbThongKePhieuNhap";
            this.cbThongKePhieuNhap.Size = new System.Drawing.Size(230, 21);
            this.cbThongKePhieuNhap.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ";
            // 
            // dtpkFromPhieuNhap
            // 
            this.dtpkFromPhieuNhap.Location = new System.Drawing.Point(80, 40);
            this.dtpkFromPhieuNhap.Name = "dtpkFromPhieuNhap";
            this.dtpkFromPhieuNhap.Size = new System.Drawing.Size(200, 20);
            this.dtpkFromPhieuNhap.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đến";
            // 
            // dtpkToPhieuNhap
            // 
            this.dtpkToPhieuNhap.Location = new System.Drawing.Point(467, 40);
            this.dtpkToPhieuNhap.Name = "dtpkToPhieuNhap";
            this.dtpkToPhieuNhap.Size = new System.Drawing.Size(200, 20);
            this.dtpkToPhieuNhap.TabIndex = 2;
            // 
            // rpPhieuNhap
            // 
            this.rpPhieuNhap.Location = new System.Drawing.Point(9, 66);
            this.rpPhieuNhap.Name = "rpPhieuNhap";
            this.rpPhieuNhap.ServerReport.BearerToken = null;
            this.rpPhieuNhap.Size = new System.Drawing.Size(658, 401);
            this.rpPhieuNhap.TabIndex = 3;
            // 
            // rpKhachHang
            // 
            this.rpKhachHang.Controls.Add(this.tabPhieuNhap);
            this.rpKhachHang.Controls.Add(this.tabPhieuXuat);
            this.rpKhachHang.Controls.Add(this.tabKhachHang);
            this.rpKhachHang.Location = new System.Drawing.Point(12, 12);
            this.rpKhachHang.Name = "rpKhachHang";
            this.rpKhachHang.SelectedIndex = 0;
            this.rpKhachHang.Size = new System.Drawing.Size(681, 499);
            this.rpKhachHang.TabIndex = 0;
            // 
            // frm_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 523);
            this.Controls.Add(this.rpKhachHang);
            this.Name = "frm_ThongKe";
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.Frm_ThongKe_Load);
            this.tabKhachHang.ResumeLayout(false);
            this.tabKhachHang.PerformLayout();
            this.tabPhieuXuat.ResumeLayout(false);
            this.tabPhieuXuat.PerformLayout();
            this.tabPhieuNhap.ResumeLayout(false);
            this.tabPhieuNhap.PerformLayout();
            this.rpKhachHang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabKhachHang;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.DateTimePicker dtpkToKhachHang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpkFromKhachHang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbThongKeKhachHang;
        private System.Windows.Forms.TabPage tabPhieuXuat;
        private Microsoft.Reporting.WinForms.ReportViewer rpPhieuXuat;
        private System.Windows.Forms.DateTimePicker dtpkToPhieuXuat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpkFromPhieuXuat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbThongKePhieuXuat;
        private System.Windows.Forms.TabPage tabPhieuNhap;
        private Microsoft.Reporting.WinForms.ReportViewer rpPhieuNhap;
        private System.Windows.Forms.DateTimePicker dtpkToPhieuNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpkFromPhieuNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbThongKePhieuNhap;
        private System.Windows.Forms.TabControl rpKhachHang;
    }
}