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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.USP_ReportKhachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet_ThongKe = new BanLinhKien.DataSet_ThongKe();
            this.USP_ReportPhieuXuatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.USP_ReportPhieuNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.USP_ReportLoiNhuanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabKhachHang = new System.Windows.Forms.TabPage();
            this.rpvKhachHang = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtpkToKhachHang = new System.Windows.Forms.DateTimePicker();
            this.lblToKhachHang = new System.Windows.Forms.Label();
            this.dtpkFromKhachHang = new System.Windows.Forms.DateTimePicker();
            this.lblFromKhachHang = new System.Windows.Forms.Label();
            this.cbThongKeKhachHang = new System.Windows.Forms.ComboBox();
            this.tabPhieuXuat = new System.Windows.Forms.TabPage();
            this.rpvPhieuXuat = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtpkToPhieuXuat = new System.Windows.Forms.DateTimePicker();
            this.lblToPhieuXuat = new System.Windows.Forms.Label();
            this.dtpkFromPhieuXuat = new System.Windows.Forms.DateTimePicker();
            this.lblFromPhieuXuat = new System.Windows.Forms.Label();
            this.cbThongKePhieuXuat = new System.Windows.Forms.ComboBox();
            this.tabPhieuNhap = new System.Windows.Forms.TabPage();
            this.dtpkToPhieuNhap = new System.Windows.Forms.DateTimePicker();
            this.lblToPhieuNhap = new System.Windows.Forms.Label();
            this.rpvPhieuNhap = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtpkFromPhieuNhap = new System.Windows.Forms.DateTimePicker();
            this.lblFromPhieuNhap = new System.Windows.Forms.Label();
            this.cbThongKePhieuNhap = new System.Windows.Forms.ComboBox();
            this.tabControlThongKe = new System.Windows.Forms.TabControl();
            this.tabLoiNhuan = new System.Windows.Forms.TabPage();
            this.rpvLoiNhuan = new Microsoft.Reporting.WinForms.ReportViewer();
            this.USP_ReportPhieuXuatTableAdapter = new BanLinhKien.DataSet_ThongKeTableAdapters.USP_ReportPhieuXuatTableAdapter();
            this.USP_ReportKhachHangTableAdapter = new BanLinhKien.DataSet_ThongKeTableAdapters.USP_ReportKhachHangTableAdapter();
            this.USP_ReportLoiNhuanTableAdapter = new BanLinhKien.DataSet_ThongKeTableAdapters.USP_ReportLoiNhuanTableAdapter();
            this.USP_ReportPhieuNhapTableAdapter = new BanLinhKien.DataSet_ThongKeTableAdapters.USP_ReportPhieuNhapTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.USP_ReportKhachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_ThongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_ReportPhieuXuatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_ReportPhieuNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_ReportLoiNhuanBindingSource)).BeginInit();
            this.tabKhachHang.SuspendLayout();
            this.tabPhieuXuat.SuspendLayout();
            this.tabPhieuNhap.SuspendLayout();
            this.tabControlThongKe.SuspendLayout();
            this.tabLoiNhuan.SuspendLayout();
            this.SuspendLayout();
            // 
            // USP_ReportKhachHangBindingSource
            // 
            this.USP_ReportKhachHangBindingSource.DataMember = "USP_ReportKhachHang";
            this.USP_ReportKhachHangBindingSource.DataSource = this.DataSet_ThongKe;
            // 
            // DataSet_ThongKe
            // 
            this.DataSet_ThongKe.DataSetName = "DataSet_ThongKe";
            this.DataSet_ThongKe.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // USP_ReportPhieuXuatBindingSource
            // 
            this.USP_ReportPhieuXuatBindingSource.DataMember = "USP_ReportPhieuXuat";
            this.USP_ReportPhieuXuatBindingSource.DataSource = this.DataSet_ThongKe;
            // 
            // USP_ReportPhieuNhapBindingSource
            // 
            this.USP_ReportPhieuNhapBindingSource.DataMember = "USP_ReportPhieuNhap";
            this.USP_ReportPhieuNhapBindingSource.DataSource = this.DataSet_ThongKe;
            // 
            // USP_ReportLoiNhuanBindingSource
            // 
            this.USP_ReportLoiNhuanBindingSource.DataMember = "USP_ReportLoiNhuan";
            this.USP_ReportLoiNhuanBindingSource.DataSource = this.DataSet_ThongKe;
            // 
            // tabKhachHang
            // 
            this.tabKhachHang.Controls.Add(this.rpvKhachHang);
            this.tabKhachHang.Controls.Add(this.dtpkToKhachHang);
            this.tabKhachHang.Controls.Add(this.lblToKhachHang);
            this.tabKhachHang.Controls.Add(this.dtpkFromKhachHang);
            this.tabKhachHang.Controls.Add(this.lblFromKhachHang);
            this.tabKhachHang.Controls.Add(this.cbThongKeKhachHang);
            this.tabKhachHang.Location = new System.Drawing.Point(4, 22);
            this.tabKhachHang.Name = "tabKhachHang";
            this.tabKhachHang.Padding = new System.Windows.Forms.Padding(3);
            this.tabKhachHang.Size = new System.Drawing.Size(819, 473);
            this.tabKhachHang.TabIndex = 2;
            this.tabKhachHang.Text = "Khách hàng";
            this.tabKhachHang.UseVisualStyleBackColor = true;
            // 
            // rpvKhachHang
            // 
            reportDataSource1.Name = "DataSet_TableKhachHang";
            reportDataSource1.Value = this.USP_ReportKhachHangBindingSource;
            this.rpvKhachHang.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvKhachHang.LocalReport.ReportEmbeddedResource = "BanLinhKien.rp_KhachHang.rdlc";
            this.rpvKhachHang.Location = new System.Drawing.Point(9, 66);
            this.rpvKhachHang.Name = "rpvKhachHang";
            this.rpvKhachHang.ServerReport.BearerToken = null;
            this.rpvKhachHang.Size = new System.Drawing.Size(804, 401);
            this.rpvKhachHang.TabIndex = 45;
            // 
            // dtpkToKhachHang
            // 
            this.dtpkToKhachHang.Location = new System.Drawing.Point(613, 40);
            this.dtpkToKhachHang.Name = "dtpkToKhachHang";
            this.dtpkToKhachHang.Size = new System.Drawing.Size(200, 20);
            this.dtpkToKhachHang.TabIndex = 43;
            this.dtpkToKhachHang.Visible = false;
            // 
            // lblToKhachHang
            // 
            this.lblToKhachHang.AutoSize = true;
            this.lblToKhachHang.Location = new System.Drawing.Point(539, 40);
            this.lblToKhachHang.Name = "lblToKhachHang";
            this.lblToKhachHang.Size = new System.Drawing.Size(27, 13);
            this.lblToKhachHang.TabIndex = 41;
            this.lblToKhachHang.Text = "Đến";
            this.lblToKhachHang.Visible = false;
            // 
            // dtpkFromKhachHang
            // 
            this.dtpkFromKhachHang.Location = new System.Drawing.Point(80, 40);
            this.dtpkFromKhachHang.Name = "dtpkFromKhachHang";
            this.dtpkFromKhachHang.Size = new System.Drawing.Size(200, 20);
            this.dtpkFromKhachHang.TabIndex = 44;
            this.dtpkFromKhachHang.Visible = false;
            // 
            // lblFromKhachHang
            // 
            this.lblFromKhachHang.AutoSize = true;
            this.lblFromKhachHang.Location = new System.Drawing.Point(6, 40);
            this.lblFromKhachHang.Name = "lblFromKhachHang";
            this.lblFromKhachHang.Size = new System.Drawing.Size(20, 13);
            this.lblFromKhachHang.TabIndex = 42;
            this.lblFromKhachHang.Text = "Từ";
            this.lblFromKhachHang.Visible = false;
            // 
            // cbThongKeKhachHang
            // 
            this.cbThongKeKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThongKeKhachHang.FormattingEnabled = true;
            this.cbThongKeKhachHang.Location = new System.Drawing.Point(305, 6);
            this.cbThongKeKhachHang.Name = "cbThongKeKhachHang";
            this.cbThongKeKhachHang.Size = new System.Drawing.Size(230, 21);
            this.cbThongKeKhachHang.TabIndex = 40;
            this.cbThongKeKhachHang.SelectedValueChanged += new System.EventHandler(this.CbThongKeKhachHang_SelectedValueChanged);
            // 
            // tabPhieuXuat
            // 
            this.tabPhieuXuat.Controls.Add(this.rpvPhieuXuat);
            this.tabPhieuXuat.Controls.Add(this.dtpkToPhieuXuat);
            this.tabPhieuXuat.Controls.Add(this.lblToPhieuXuat);
            this.tabPhieuXuat.Controls.Add(this.dtpkFromPhieuXuat);
            this.tabPhieuXuat.Controls.Add(this.lblFromPhieuXuat);
            this.tabPhieuXuat.Controls.Add(this.cbThongKePhieuXuat);
            this.tabPhieuXuat.Location = new System.Drawing.Point(4, 22);
            this.tabPhieuXuat.Name = "tabPhieuXuat";
            this.tabPhieuXuat.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhieuXuat.Size = new System.Drawing.Size(819, 473);
            this.tabPhieuXuat.TabIndex = 1;
            this.tabPhieuXuat.Text = "Phiếu xuất";
            this.tabPhieuXuat.UseVisualStyleBackColor = true;
            // 
            // rpvPhieuXuat
            // 
            reportDataSource2.Name = "DataSet_TablePhieuXuat";
            reportDataSource2.Value = this.USP_ReportPhieuXuatBindingSource;
            this.rpvPhieuXuat.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvPhieuXuat.LocalReport.ReportEmbeddedResource = "BanLinhKien.rp_PhieuXuat.rdlc";
            this.rpvPhieuXuat.Location = new System.Drawing.Point(9, 66);
            this.rpvPhieuXuat.Name = "rpvPhieuXuat";
            this.rpvPhieuXuat.ServerReport.BearerToken = null;
            this.rpvPhieuXuat.Size = new System.Drawing.Size(804, 401);
            this.rpvPhieuXuat.TabIndex = 45;
            // 
            // dtpkToPhieuXuat
            // 
            this.dtpkToPhieuXuat.Location = new System.Drawing.Point(613, 40);
            this.dtpkToPhieuXuat.Name = "dtpkToPhieuXuat";
            this.dtpkToPhieuXuat.Size = new System.Drawing.Size(200, 20);
            this.dtpkToPhieuXuat.TabIndex = 43;
            this.dtpkToPhieuXuat.Visible = false;
            // 
            // lblToPhieuXuat
            // 
            this.lblToPhieuXuat.AutoSize = true;
            this.lblToPhieuXuat.Location = new System.Drawing.Point(539, 40);
            this.lblToPhieuXuat.Name = "lblToPhieuXuat";
            this.lblToPhieuXuat.Size = new System.Drawing.Size(27, 13);
            this.lblToPhieuXuat.TabIndex = 41;
            this.lblToPhieuXuat.Text = "Đến";
            this.lblToPhieuXuat.Visible = false;
            // 
            // dtpkFromPhieuXuat
            // 
            this.dtpkFromPhieuXuat.Location = new System.Drawing.Point(80, 40);
            this.dtpkFromPhieuXuat.Name = "dtpkFromPhieuXuat";
            this.dtpkFromPhieuXuat.Size = new System.Drawing.Size(200, 20);
            this.dtpkFromPhieuXuat.TabIndex = 44;
            this.dtpkFromPhieuXuat.Visible = false;
            // 
            // lblFromPhieuXuat
            // 
            this.lblFromPhieuXuat.AutoSize = true;
            this.lblFromPhieuXuat.Location = new System.Drawing.Point(6, 40);
            this.lblFromPhieuXuat.Name = "lblFromPhieuXuat";
            this.lblFromPhieuXuat.Size = new System.Drawing.Size(20, 13);
            this.lblFromPhieuXuat.TabIndex = 42;
            this.lblFromPhieuXuat.Text = "Từ";
            this.lblFromPhieuXuat.Visible = false;
            // 
            // cbThongKePhieuXuat
            // 
            this.cbThongKePhieuXuat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThongKePhieuXuat.FormattingEnabled = true;
            this.cbThongKePhieuXuat.Location = new System.Drawing.Point(305, 6);
            this.cbThongKePhieuXuat.Name = "cbThongKePhieuXuat";
            this.cbThongKePhieuXuat.Size = new System.Drawing.Size(230, 21);
            this.cbThongKePhieuXuat.TabIndex = 40;
            this.cbThongKePhieuXuat.SelectedValueChanged += new System.EventHandler(this.CbThongKePhieuXuat_SelectedValueChanged);
            // 
            // tabPhieuNhap
            // 
            this.tabPhieuNhap.Controls.Add(this.dtpkToPhieuNhap);
            this.tabPhieuNhap.Controls.Add(this.lblToPhieuNhap);
            this.tabPhieuNhap.Controls.Add(this.rpvPhieuNhap);
            this.tabPhieuNhap.Controls.Add(this.dtpkFromPhieuNhap);
            this.tabPhieuNhap.Controls.Add(this.lblFromPhieuNhap);
            this.tabPhieuNhap.Controls.Add(this.cbThongKePhieuNhap);
            this.tabPhieuNhap.Location = new System.Drawing.Point(4, 22);
            this.tabPhieuNhap.Name = "tabPhieuNhap";
            this.tabPhieuNhap.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhieuNhap.Size = new System.Drawing.Size(819, 473);
            this.tabPhieuNhap.TabIndex = 0;
            this.tabPhieuNhap.Text = "Phiếu nhập";
            this.tabPhieuNhap.UseVisualStyleBackColor = true;
            // 
            // dtpkToPhieuNhap
            // 
            this.dtpkToPhieuNhap.CustomFormat = "dd/MM/yyyy";
            this.dtpkToPhieuNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkToPhieuNhap.Location = new System.Drawing.Point(613, 40);
            this.dtpkToPhieuNhap.Name = "dtpkToPhieuNhap";
            this.dtpkToPhieuNhap.Size = new System.Drawing.Size(200, 20);
            this.dtpkToPhieuNhap.TabIndex = 45;
            this.dtpkToPhieuNhap.Visible = false;
            // 
            // lblToPhieuNhap
            // 
            this.lblToPhieuNhap.AutoSize = true;
            this.lblToPhieuNhap.Location = new System.Drawing.Point(539, 40);
            this.lblToPhieuNhap.Name = "lblToPhieuNhap";
            this.lblToPhieuNhap.Size = new System.Drawing.Size(27, 13);
            this.lblToPhieuNhap.TabIndex = 44;
            this.lblToPhieuNhap.Text = "Đến";
            this.lblToPhieuNhap.Visible = false;
            // 
            // rpvPhieuNhap
            // 
            reportDataSource3.Name = "DataSet_TablePhieuNhap";
            reportDataSource3.Value = this.USP_ReportPhieuNhapBindingSource;
            this.rpvPhieuNhap.LocalReport.DataSources.Add(reportDataSource3);
            this.rpvPhieuNhap.LocalReport.ReportEmbeddedResource = "BanLinhKien.rp_PhieuNhap.rdlc";
            this.rpvPhieuNhap.Location = new System.Drawing.Point(9, 66);
            this.rpvPhieuNhap.Name = "rpvPhieuNhap";
            this.rpvPhieuNhap.ServerReport.BearerToken = null;
            this.rpvPhieuNhap.Size = new System.Drawing.Size(804, 401);
            this.rpvPhieuNhap.TabIndex = 3;
            // 
            // dtpkFromPhieuNhap
            // 
            this.dtpkFromPhieuNhap.CustomFormat = "dd/MM/yyyy";
            this.dtpkFromPhieuNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkFromPhieuNhap.Location = new System.Drawing.Point(80, 40);
            this.dtpkFromPhieuNhap.Name = "dtpkFromPhieuNhap";
            this.dtpkFromPhieuNhap.Size = new System.Drawing.Size(200, 20);
            this.dtpkFromPhieuNhap.TabIndex = 2;
            this.dtpkFromPhieuNhap.Visible = false;
            // 
            // lblFromPhieuNhap
            // 
            this.lblFromPhieuNhap.AutoSize = true;
            this.lblFromPhieuNhap.Location = new System.Drawing.Point(6, 40);
            this.lblFromPhieuNhap.Name = "lblFromPhieuNhap";
            this.lblFromPhieuNhap.Size = new System.Drawing.Size(20, 13);
            this.lblFromPhieuNhap.TabIndex = 1;
            this.lblFromPhieuNhap.Text = "Từ";
            this.lblFromPhieuNhap.Visible = false;
            // 
            // cbThongKePhieuNhap
            // 
            this.cbThongKePhieuNhap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThongKePhieuNhap.FormattingEnabled = true;
            this.cbThongKePhieuNhap.Location = new System.Drawing.Point(305, 6);
            this.cbThongKePhieuNhap.Name = "cbThongKePhieuNhap";
            this.cbThongKePhieuNhap.Size = new System.Drawing.Size(230, 21);
            this.cbThongKePhieuNhap.TabIndex = 0;
            this.cbThongKePhieuNhap.SelectedValueChanged += new System.EventHandler(this.CbThongKePhieuNhap_SelectedValueChanged);
            // 
            // tabControlThongKe
            // 
            this.tabControlThongKe.Controls.Add(this.tabPhieuNhap);
            this.tabControlThongKe.Controls.Add(this.tabPhieuXuat);
            this.tabControlThongKe.Controls.Add(this.tabKhachHang);
            this.tabControlThongKe.Controls.Add(this.tabLoiNhuan);
            this.tabControlThongKe.Location = new System.Drawing.Point(12, 12);
            this.tabControlThongKe.Name = "tabControlThongKe";
            this.tabControlThongKe.SelectedIndex = 0;
            this.tabControlThongKe.Size = new System.Drawing.Size(827, 499);
            this.tabControlThongKe.TabIndex = 0;
            this.tabControlThongKe.SelectedIndexChanged += new System.EventHandler(this.TabControlThongKe_SelectedIndexChanged);
            // 
            // tabLoiNhuan
            // 
            this.tabLoiNhuan.Controls.Add(this.rpvLoiNhuan);
            this.tabLoiNhuan.Location = new System.Drawing.Point(4, 22);
            this.tabLoiNhuan.Name = "tabLoiNhuan";
            this.tabLoiNhuan.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoiNhuan.Size = new System.Drawing.Size(819, 473);
            this.tabLoiNhuan.TabIndex = 3;
            this.tabLoiNhuan.Text = "Lợi nhuận";
            this.tabLoiNhuan.UseVisualStyleBackColor = true;
            // 
            // rpvLoiNhuan
            // 
            reportDataSource4.Name = "DataSet_TableLoiNhuan";
            reportDataSource4.Value = this.USP_ReportLoiNhuanBindingSource;
            this.rpvLoiNhuan.LocalReport.DataSources.Add(reportDataSource4);
            this.rpvLoiNhuan.LocalReport.ReportEmbeddedResource = "BanLinhKien.rp_LoiNhuan.rdlc";
            this.rpvLoiNhuan.Location = new System.Drawing.Point(9, 66);
            this.rpvLoiNhuan.Name = "rpvLoiNhuan";
            this.rpvLoiNhuan.ServerReport.BearerToken = null;
            this.rpvLoiNhuan.Size = new System.Drawing.Size(804, 401);
            this.rpvLoiNhuan.TabIndex = 51;
            // 
            // USP_ReportPhieuXuatTableAdapter
            // 
            this.USP_ReportPhieuXuatTableAdapter.ClearBeforeFill = true;
            // 
            // USP_ReportKhachHangTableAdapter
            // 
            this.USP_ReportKhachHangTableAdapter.ClearBeforeFill = true;
            // 
            // USP_ReportLoiNhuanTableAdapter
            // 
            this.USP_ReportLoiNhuanTableAdapter.ClearBeforeFill = true;
            // 
            // USP_ReportPhieuNhapTableAdapter
            // 
            this.USP_ReportPhieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // frm_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 523);
            this.Controls.Add(this.tabControlThongKe);
            this.Name = "frm_ThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.Frm_ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.USP_ReportKhachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_ThongKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_ReportPhieuXuatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_ReportPhieuNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_ReportLoiNhuanBindingSource)).EndInit();
            this.tabKhachHang.ResumeLayout(false);
            this.tabKhachHang.PerformLayout();
            this.tabPhieuXuat.ResumeLayout(false);
            this.tabPhieuXuat.PerformLayout();
            this.tabPhieuNhap.ResumeLayout(false);
            this.tabPhieuNhap.PerformLayout();
            this.tabControlThongKe.ResumeLayout(false);
            this.tabLoiNhuan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabKhachHang;
        private Microsoft.Reporting.WinForms.ReportViewer rpvKhachHang;
        private System.Windows.Forms.DateTimePicker dtpkToKhachHang;
        private System.Windows.Forms.Label lblToKhachHang;
        private System.Windows.Forms.DateTimePicker dtpkFromKhachHang;
        private System.Windows.Forms.Label lblFromKhachHang;
        private System.Windows.Forms.ComboBox cbThongKeKhachHang;
        private System.Windows.Forms.TabPage tabPhieuXuat;
        private Microsoft.Reporting.WinForms.ReportViewer rpvPhieuXuat;
        private System.Windows.Forms.DateTimePicker dtpkToPhieuXuat;
        private System.Windows.Forms.Label lblToPhieuXuat;
        private System.Windows.Forms.DateTimePicker dtpkFromPhieuXuat;
        private System.Windows.Forms.Label lblFromPhieuXuat;
        private System.Windows.Forms.ComboBox cbThongKePhieuXuat;
        private System.Windows.Forms.TabPage tabPhieuNhap;
        private Microsoft.Reporting.WinForms.ReportViewer rpvPhieuNhap;
        private System.Windows.Forms.DateTimePicker dtpkFromPhieuNhap;
        private System.Windows.Forms.Label lblFromPhieuNhap;
        private System.Windows.Forms.ComboBox cbThongKePhieuNhap;
        private System.Windows.Forms.TabControl tabControlThongKe;
        private System.Windows.Forms.TabPage tabLoiNhuan;
        private Microsoft.Reporting.WinForms.ReportViewer rpvLoiNhuan;
        private System.Windows.Forms.DateTimePicker dtpkToPhieuNhap;
        private System.Windows.Forms.Label lblToPhieuNhap;
        private System.Windows.Forms.BindingSource USP_ReportPhieuXuatBindingSource;
        private DataSet_ThongKe DataSet_ThongKe;
        private DataSet_ThongKeTableAdapters.USP_ReportPhieuXuatTableAdapter USP_ReportPhieuXuatTableAdapter;
        private System.Windows.Forms.BindingSource USP_ReportKhachHangBindingSource;
        private DataSet_ThongKeTableAdapters.USP_ReportKhachHangTableAdapter USP_ReportKhachHangTableAdapter;
        private System.Windows.Forms.BindingSource USP_ReportLoiNhuanBindingSource;
        private DataSet_ThongKeTableAdapters.USP_ReportLoiNhuanTableAdapter USP_ReportLoiNhuanTableAdapter;
        private System.Windows.Forms.BindingSource USP_ReportPhieuNhapBindingSource;
        private DataSet_ThongKeTableAdapters.USP_ReportPhieuNhapTableAdapter USP_ReportPhieuNhapTableAdapter;
    }
}