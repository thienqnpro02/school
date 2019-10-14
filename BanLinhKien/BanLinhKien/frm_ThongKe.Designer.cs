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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPhieuNhap = new System.Windows.Forms.TabPage();
            this.btnXuatBaoCaoPN = new System.Windows.Forms.Button();
            this.lblTongTrangPN = new System.Windows.Forms.Label();
            this.txtTrangPN = new System.Windows.Forms.TextBox();
            this.btnNextPN = new System.Windows.Forms.Button();
            this.btnPrevPN = new System.Windows.Forms.Button();
            this.dgvDanhSachPhieuNhap = new System.Windows.Forms.DataGridView();
            this.dtpkToPhieuNhap = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpkFromPhieuNhap = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbThongKePhieuNhap = new System.Windows.Forms.ComboBox();
            this.tabPhieuXuat = new System.Windows.Forms.TabPage();
            this.btnXuatBaoCaoPX = new System.Windows.Forms.Button();
            this.lblTongTrangPX = new System.Windows.Forms.Label();
            this.txtTrangPX = new System.Windows.Forms.TextBox();
            this.btnNextPX = new System.Windows.Forms.Button();
            this.btnPrevPX = new System.Windows.Forms.Button();
            this.dgvDanhSachPhieuXuat = new System.Windows.Forms.DataGridView();
            this.dtpkToPhieuXuat = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpkFromPhieuXuat = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbThongKePhieuXuat = new System.Windows.Forms.ComboBox();
            this.tabKhachHang = new System.Windows.Forms.TabPage();
            this.btnXuatBaoCaoKH = new System.Windows.Forms.Button();
            this.lblTongTrangKH = new System.Windows.Forms.Label();
            this.txtTrangKH = new System.Windows.Forms.TextBox();
            this.btnNextKH = new System.Windows.Forms.Button();
            this.btnPrevKH = new System.Windows.Forms.Button();
            this.dgvDanhSachKhachHang = new System.Windows.Forms.DataGridView();
            this.dtpkToKhachHang = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpkFromKhachHang = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cbThongKeKhachHang = new System.Windows.Forms.ComboBox();
            this.tabLoiNhuan = new System.Windows.Forms.TabPage();
            this.btnXuatBaoCaoLN = new System.Windows.Forms.Button();
            this.lblTongTrangLN = new System.Windows.Forms.Label();
            this.txtTrangLN = new System.Windows.Forms.TextBox();
            this.btnNextLN = new System.Windows.Forms.Button();
            this.btnPrevLN = new System.Windows.Forms.Button();
            this.dtpkDanhSachLoiNhuan = new System.Windows.Forms.DataGridView();
            this.dtpkToLoiNhuan = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpkFromLoiNhuan = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.cbThongKeLoiNhuan = new System.Windows.Forms.ComboBox();
            this.tabControl.SuspendLayout();
            this.tabPhieuNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuNhap)).BeginInit();
            this.tabPhieuXuat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuXuat)).BeginInit();
            this.tabKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKhachHang)).BeginInit();
            this.tabLoiNhuan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpkDanhSachLoiNhuan)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPhieuNhap);
            this.tabControl.Controls.Add(this.tabPhieuXuat);
            this.tabControl.Controls.Add(this.tabKhachHang);
            this.tabControl.Controls.Add(this.tabLoiNhuan);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(681, 499);
            this.tabControl.TabIndex = 0;
            // 
            // tabPhieuNhap
            // 
            this.tabPhieuNhap.Controls.Add(this.btnXuatBaoCaoPN);
            this.tabPhieuNhap.Controls.Add(this.lblTongTrangPN);
            this.tabPhieuNhap.Controls.Add(this.txtTrangPN);
            this.tabPhieuNhap.Controls.Add(this.btnNextPN);
            this.tabPhieuNhap.Controls.Add(this.btnPrevPN);
            this.tabPhieuNhap.Controls.Add(this.dgvDanhSachPhieuNhap);
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
            // btnXuatBaoCaoPN
            // 
            this.btnXuatBaoCaoPN.Location = new System.Drawing.Point(551, 427);
            this.btnXuatBaoCaoPN.Name = "btnXuatBaoCaoPN";
            this.btnXuatBaoCaoPN.Size = new System.Drawing.Size(116, 40);
            this.btnXuatBaoCaoPN.TabIndex = 39;
            this.btnXuatBaoCaoPN.Text = "Xuất Báo Cáo";
            this.btnXuatBaoCaoPN.UseVisualStyleBackColor = true;
            // 
            // lblTongTrangPN
            // 
            this.lblTongTrangPN.AutoSize = true;
            this.lblTongTrangPN.Location = new System.Drawing.Point(347, 390);
            this.lblTongTrangPN.Name = "lblTongTrangPN";
            this.lblTongTrangPN.Size = new System.Drawing.Size(18, 13);
            this.lblTongTrangPN.TabIndex = 38;
            this.lblTongTrangPN.Text = "/0";
            // 
            // txtTrangPN
            // 
            this.txtTrangPN.Location = new System.Drawing.Point(304, 387);
            this.txtTrangPN.Name = "txtTrangPN";
            this.txtTrangPN.Size = new System.Drawing.Size(37, 20);
            this.txtTrangPN.TabIndex = 36;
            // 
            // btnNextPN
            // 
            this.btnNextPN.Location = new System.Drawing.Point(551, 384);
            this.btnNextPN.Name = "btnNextPN";
            this.btnNextPN.Size = new System.Drawing.Size(116, 23);
            this.btnNextPN.TabIndex = 37;
            this.btnNextPN.Text = ">";
            this.btnNextPN.UseVisualStyleBackColor = true;
            // 
            // btnPrevPN
            // 
            this.btnPrevPN.Location = new System.Drawing.Point(9, 384);
            this.btnPrevPN.Name = "btnPrevPN";
            this.btnPrevPN.Size = new System.Drawing.Size(116, 23);
            this.btnPrevPN.TabIndex = 35;
            this.btnPrevPN.Text = "<";
            this.btnPrevPN.UseVisualStyleBackColor = true;
            // 
            // dgvDanhSachPhieuNhap
            // 
            this.dgvDanhSachPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachPhieuNhap.Location = new System.Drawing.Point(9, 66);
            this.dgvDanhSachPhieuNhap.Name = "dgvDanhSachPhieuNhap";
            this.dgvDanhSachPhieuNhap.Size = new System.Drawing.Size(658, 301);
            this.dgvDanhSachPhieuNhap.TabIndex = 3;
            // 
            // dtpkToPhieuNhap
            // 
            this.dtpkToPhieuNhap.Location = new System.Drawing.Point(467, 40);
            this.dtpkToPhieuNhap.Name = "dtpkToPhieuNhap";
            this.dtpkToPhieuNhap.Size = new System.Drawing.Size(200, 20);
            this.dtpkToPhieuNhap.TabIndex = 2;
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
            // dtpkFromPhieuNhap
            // 
            this.dtpkFromPhieuNhap.Location = new System.Drawing.Point(80, 40);
            this.dtpkFromPhieuNhap.Name = "dtpkFromPhieuNhap";
            this.dtpkFromPhieuNhap.Size = new System.Drawing.Size(200, 20);
            this.dtpkFromPhieuNhap.TabIndex = 2;
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
            // cbThongKePhieuNhap
            // 
            this.cbThongKePhieuNhap.FormattingEnabled = true;
            this.cbThongKePhieuNhap.Location = new System.Drawing.Point(221, 6);
            this.cbThongKePhieuNhap.Name = "cbThongKePhieuNhap";
            this.cbThongKePhieuNhap.Size = new System.Drawing.Size(230, 21);
            this.cbThongKePhieuNhap.TabIndex = 0;
            // 
            // tabPhieuXuat
            // 
            this.tabPhieuXuat.Controls.Add(this.btnXuatBaoCaoPX);
            this.tabPhieuXuat.Controls.Add(this.lblTongTrangPX);
            this.tabPhieuXuat.Controls.Add(this.txtTrangPX);
            this.tabPhieuXuat.Controls.Add(this.btnNextPX);
            this.tabPhieuXuat.Controls.Add(this.btnPrevPX);
            this.tabPhieuXuat.Controls.Add(this.dgvDanhSachPhieuXuat);
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
            // btnXuatBaoCaoPX
            // 
            this.btnXuatBaoCaoPX.Location = new System.Drawing.Point(551, 427);
            this.btnXuatBaoCaoPX.Name = "btnXuatBaoCaoPX";
            this.btnXuatBaoCaoPX.Size = new System.Drawing.Size(116, 40);
            this.btnXuatBaoCaoPX.TabIndex = 50;
            this.btnXuatBaoCaoPX.Text = "Xuất Báo Cáo";
            this.btnXuatBaoCaoPX.UseVisualStyleBackColor = true;
            // 
            // lblTongTrangPX
            // 
            this.lblTongTrangPX.AutoSize = true;
            this.lblTongTrangPX.Location = new System.Drawing.Point(347, 390);
            this.lblTongTrangPX.Name = "lblTongTrangPX";
            this.lblTongTrangPX.Size = new System.Drawing.Size(18, 13);
            this.lblTongTrangPX.TabIndex = 49;
            this.lblTongTrangPX.Text = "/0";
            // 
            // txtTrangPX
            // 
            this.txtTrangPX.Location = new System.Drawing.Point(304, 387);
            this.txtTrangPX.Name = "txtTrangPX";
            this.txtTrangPX.Size = new System.Drawing.Size(37, 20);
            this.txtTrangPX.TabIndex = 47;
            // 
            // btnNextPX
            // 
            this.btnNextPX.Location = new System.Drawing.Point(551, 384);
            this.btnNextPX.Name = "btnNextPX";
            this.btnNextPX.Size = new System.Drawing.Size(116, 23);
            this.btnNextPX.TabIndex = 48;
            this.btnNextPX.Text = ">";
            this.btnNextPX.UseVisualStyleBackColor = true;
            // 
            // btnPrevPX
            // 
            this.btnPrevPX.Location = new System.Drawing.Point(9, 384);
            this.btnPrevPX.Name = "btnPrevPX";
            this.btnPrevPX.Size = new System.Drawing.Size(116, 23);
            this.btnPrevPX.TabIndex = 46;
            this.btnPrevPX.Text = "<";
            this.btnPrevPX.UseVisualStyleBackColor = true;
            // 
            // dgvDanhSachPhieuXuat
            // 
            this.dgvDanhSachPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachPhieuXuat.Location = new System.Drawing.Point(9, 66);
            this.dgvDanhSachPhieuXuat.Name = "dgvDanhSachPhieuXuat";
            this.dgvDanhSachPhieuXuat.Size = new System.Drawing.Size(658, 301);
            this.dgvDanhSachPhieuXuat.TabIndex = 45;
            // 
            // dtpkToPhieuXuat
            // 
            this.dtpkToPhieuXuat.Location = new System.Drawing.Point(467, 40);
            this.dtpkToPhieuXuat.Name = "dtpkToPhieuXuat";
            this.dtpkToPhieuXuat.Size = new System.Drawing.Size(200, 20);
            this.dtpkToPhieuXuat.TabIndex = 43;
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
            // dtpkFromPhieuXuat
            // 
            this.dtpkFromPhieuXuat.Location = new System.Drawing.Point(80, 40);
            this.dtpkFromPhieuXuat.Name = "dtpkFromPhieuXuat";
            this.dtpkFromPhieuXuat.Size = new System.Drawing.Size(200, 20);
            this.dtpkFromPhieuXuat.TabIndex = 44;
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
            // cbThongKePhieuXuat
            // 
            this.cbThongKePhieuXuat.FormattingEnabled = true;
            this.cbThongKePhieuXuat.Location = new System.Drawing.Point(221, 6);
            this.cbThongKePhieuXuat.Name = "cbThongKePhieuXuat";
            this.cbThongKePhieuXuat.Size = new System.Drawing.Size(230, 21);
            this.cbThongKePhieuXuat.TabIndex = 40;
            // 
            // tabKhachHang
            // 
            this.tabKhachHang.Controls.Add(this.btnXuatBaoCaoKH);
            this.tabKhachHang.Controls.Add(this.lblTongTrangKH);
            this.tabKhachHang.Controls.Add(this.txtTrangKH);
            this.tabKhachHang.Controls.Add(this.btnNextKH);
            this.tabKhachHang.Controls.Add(this.btnPrevKH);
            this.tabKhachHang.Controls.Add(this.dgvDanhSachKhachHang);
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
            // btnXuatBaoCaoKH
            // 
            this.btnXuatBaoCaoKH.Location = new System.Drawing.Point(551, 427);
            this.btnXuatBaoCaoKH.Name = "btnXuatBaoCaoKH";
            this.btnXuatBaoCaoKH.Size = new System.Drawing.Size(116, 40);
            this.btnXuatBaoCaoKH.TabIndex = 50;
            this.btnXuatBaoCaoKH.Text = "Xuất Báo Cáo";
            this.btnXuatBaoCaoKH.UseVisualStyleBackColor = true;
            // 
            // lblTongTrangKH
            // 
            this.lblTongTrangKH.AutoSize = true;
            this.lblTongTrangKH.Location = new System.Drawing.Point(347, 390);
            this.lblTongTrangKH.Name = "lblTongTrangKH";
            this.lblTongTrangKH.Size = new System.Drawing.Size(18, 13);
            this.lblTongTrangKH.TabIndex = 49;
            this.lblTongTrangKH.Text = "/0";
            // 
            // txtTrangKH
            // 
            this.txtTrangKH.Location = new System.Drawing.Point(304, 387);
            this.txtTrangKH.Name = "txtTrangKH";
            this.txtTrangKH.Size = new System.Drawing.Size(37, 20);
            this.txtTrangKH.TabIndex = 47;
            // 
            // btnNextKH
            // 
            this.btnNextKH.Location = new System.Drawing.Point(551, 384);
            this.btnNextKH.Name = "btnNextKH";
            this.btnNextKH.Size = new System.Drawing.Size(116, 23);
            this.btnNextKH.TabIndex = 48;
            this.btnNextKH.Text = ">";
            this.btnNextKH.UseVisualStyleBackColor = true;
            // 
            // btnPrevKH
            // 
            this.btnPrevKH.Location = new System.Drawing.Point(9, 384);
            this.btnPrevKH.Name = "btnPrevKH";
            this.btnPrevKH.Size = new System.Drawing.Size(116, 23);
            this.btnPrevKH.TabIndex = 46;
            this.btnPrevKH.Text = "<";
            this.btnPrevKH.UseVisualStyleBackColor = true;
            // 
            // dgvDanhSachKhachHang
            // 
            this.dgvDanhSachKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachKhachHang.Location = new System.Drawing.Point(9, 66);
            this.dgvDanhSachKhachHang.Name = "dgvDanhSachKhachHang";
            this.dgvDanhSachKhachHang.Size = new System.Drawing.Size(658, 301);
            this.dgvDanhSachKhachHang.TabIndex = 45;
            // 
            // dtpkToKhachHang
            // 
            this.dtpkToKhachHang.Location = new System.Drawing.Point(467, 40);
            this.dtpkToKhachHang.Name = "dtpkToKhachHang";
            this.dtpkToKhachHang.Size = new System.Drawing.Size(200, 20);
            this.dtpkToKhachHang.TabIndex = 43;
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
            // dtpkFromKhachHang
            // 
            this.dtpkFromKhachHang.Location = new System.Drawing.Point(80, 40);
            this.dtpkFromKhachHang.Name = "dtpkFromKhachHang";
            this.dtpkFromKhachHang.Size = new System.Drawing.Size(200, 20);
            this.dtpkFromKhachHang.TabIndex = 44;
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
            // cbThongKeKhachHang
            // 
            this.cbThongKeKhachHang.FormattingEnabled = true;
            this.cbThongKeKhachHang.Location = new System.Drawing.Point(221, 6);
            this.cbThongKeKhachHang.Name = "cbThongKeKhachHang";
            this.cbThongKeKhachHang.Size = new System.Drawing.Size(230, 21);
            this.cbThongKeKhachHang.TabIndex = 40;
            // 
            // tabLoiNhuan
            // 
            this.tabLoiNhuan.Controls.Add(this.btnXuatBaoCaoLN);
            this.tabLoiNhuan.Controls.Add(this.lblTongTrangLN);
            this.tabLoiNhuan.Controls.Add(this.txtTrangLN);
            this.tabLoiNhuan.Controls.Add(this.btnNextLN);
            this.tabLoiNhuan.Controls.Add(this.btnPrevLN);
            this.tabLoiNhuan.Controls.Add(this.dtpkDanhSachLoiNhuan);
            this.tabLoiNhuan.Controls.Add(this.dtpkToLoiNhuan);
            this.tabLoiNhuan.Controls.Add(this.label10);
            this.tabLoiNhuan.Controls.Add(this.dtpkFromLoiNhuan);
            this.tabLoiNhuan.Controls.Add(this.label11);
            this.tabLoiNhuan.Controls.Add(this.cbThongKeLoiNhuan);
            this.tabLoiNhuan.Location = new System.Drawing.Point(4, 22);
            this.tabLoiNhuan.Name = "tabLoiNhuan";
            this.tabLoiNhuan.Size = new System.Drawing.Size(673, 473);
            this.tabLoiNhuan.TabIndex = 3;
            this.tabLoiNhuan.Text = "Lợi nhuận";
            this.tabLoiNhuan.UseVisualStyleBackColor = true;
            // 
            // btnXuatBaoCaoLN
            // 
            this.btnXuatBaoCaoLN.Location = new System.Drawing.Point(551, 427);
            this.btnXuatBaoCaoLN.Name = "btnXuatBaoCaoLN";
            this.btnXuatBaoCaoLN.Size = new System.Drawing.Size(116, 40);
            this.btnXuatBaoCaoLN.TabIndex = 50;
            this.btnXuatBaoCaoLN.Text = "Xuất Báo Cáo";
            this.btnXuatBaoCaoLN.UseVisualStyleBackColor = true;
            // 
            // lblTongTrangLN
            // 
            this.lblTongTrangLN.AutoSize = true;
            this.lblTongTrangLN.Location = new System.Drawing.Point(347, 390);
            this.lblTongTrangLN.Name = "lblTongTrangLN";
            this.lblTongTrangLN.Size = new System.Drawing.Size(18, 13);
            this.lblTongTrangLN.TabIndex = 49;
            this.lblTongTrangLN.Text = "/0";
            // 
            // txtTrangLN
            // 
            this.txtTrangLN.Location = new System.Drawing.Point(304, 387);
            this.txtTrangLN.Name = "txtTrangLN";
            this.txtTrangLN.Size = new System.Drawing.Size(37, 20);
            this.txtTrangLN.TabIndex = 47;
            // 
            // btnNextLN
            // 
            this.btnNextLN.Location = new System.Drawing.Point(551, 384);
            this.btnNextLN.Name = "btnNextLN";
            this.btnNextLN.Size = new System.Drawing.Size(116, 23);
            this.btnNextLN.TabIndex = 48;
            this.btnNextLN.Text = ">";
            this.btnNextLN.UseVisualStyleBackColor = true;
            // 
            // btnPrevLN
            // 
            this.btnPrevLN.Location = new System.Drawing.Point(9, 384);
            this.btnPrevLN.Name = "btnPrevLN";
            this.btnPrevLN.Size = new System.Drawing.Size(116, 23);
            this.btnPrevLN.TabIndex = 46;
            this.btnPrevLN.Text = "<";
            this.btnPrevLN.UseVisualStyleBackColor = true;
            // 
            // dtpkDanhSachLoiNhuan
            // 
            this.dtpkDanhSachLoiNhuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtpkDanhSachLoiNhuan.Location = new System.Drawing.Point(9, 66);
            this.dtpkDanhSachLoiNhuan.Name = "dtpkDanhSachLoiNhuan";
            this.dtpkDanhSachLoiNhuan.Size = new System.Drawing.Size(658, 301);
            this.dtpkDanhSachLoiNhuan.TabIndex = 45;
            // 
            // dtpkToLoiNhuan
            // 
            this.dtpkToLoiNhuan.Location = new System.Drawing.Point(467, 40);
            this.dtpkToLoiNhuan.Name = "dtpkToLoiNhuan";
            this.dtpkToLoiNhuan.Size = new System.Drawing.Size(200, 20);
            this.dtpkToLoiNhuan.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(393, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Đến";
            // 
            // dtpkFromLoiNhuan
            // 
            this.dtpkFromLoiNhuan.Location = new System.Drawing.Point(80, 40);
            this.dtpkFromLoiNhuan.Name = "dtpkFromLoiNhuan";
            this.dtpkFromLoiNhuan.Size = new System.Drawing.Size(200, 20);
            this.dtpkFromLoiNhuan.TabIndex = 44;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "Từ";
            // 
            // cbThongKeLoiNhuan
            // 
            this.cbThongKeLoiNhuan.FormattingEnabled = true;
            this.cbThongKeLoiNhuan.Location = new System.Drawing.Point(221, 6);
            this.cbThongKeLoiNhuan.Name = "cbThongKeLoiNhuan";
            this.cbThongKeLoiNhuan.Size = new System.Drawing.Size(230, 21);
            this.cbThongKeLoiNhuan.TabIndex = 40;
            // 
            // frm_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 523);
            this.Controls.Add(this.tabControl);
            this.Name = "frm_ThongKe";
            this.Text = "Thống kê";
            this.tabControl.ResumeLayout(false);
            this.tabPhieuNhap.ResumeLayout(false);
            this.tabPhieuNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuNhap)).EndInit();
            this.tabPhieuXuat.ResumeLayout(false);
            this.tabPhieuXuat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuXuat)).EndInit();
            this.tabKhachHang.ResumeLayout(false);
            this.tabKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKhachHang)).EndInit();
            this.tabLoiNhuan.ResumeLayout(false);
            this.tabLoiNhuan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpkDanhSachLoiNhuan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPhieuNhap;
        private System.Windows.Forms.DataGridView dgvDanhSachPhieuNhap;
        private System.Windows.Forms.DateTimePicker dtpkToPhieuNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpkFromPhieuNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbThongKePhieuNhap;
        private System.Windows.Forms.TabPage tabPhieuXuat;
        private System.Windows.Forms.TabPage tabKhachHang;
        private System.Windows.Forms.TabPage tabLoiNhuan;
        private System.Windows.Forms.Label lblTongTrangPN;
        private System.Windows.Forms.TextBox txtTrangPN;
        private System.Windows.Forms.Button btnNextPN;
        private System.Windows.Forms.Button btnPrevPN;
        private System.Windows.Forms.Button btnXuatBaoCaoPN;
        private System.Windows.Forms.Button btnXuatBaoCaoPX;
        private System.Windows.Forms.Label lblTongTrangPX;
        private System.Windows.Forms.TextBox txtTrangPX;
        private System.Windows.Forms.Button btnNextPX;
        private System.Windows.Forms.Button btnPrevPX;
        private System.Windows.Forms.DataGridView dgvDanhSachPhieuXuat;
        private System.Windows.Forms.DateTimePicker dtpkToPhieuXuat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpkFromPhieuXuat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbThongKePhieuXuat;
        private System.Windows.Forms.Button btnXuatBaoCaoKH;
        private System.Windows.Forms.Label lblTongTrangKH;
        private System.Windows.Forms.TextBox txtTrangKH;
        private System.Windows.Forms.Button btnNextKH;
        private System.Windows.Forms.Button btnPrevKH;
        private System.Windows.Forms.DataGridView dgvDanhSachKhachHang;
        private System.Windows.Forms.DateTimePicker dtpkToKhachHang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpkFromKhachHang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbThongKeKhachHang;
        private System.Windows.Forms.Button btnXuatBaoCaoLN;
        private System.Windows.Forms.Label lblTongTrangLN;
        private System.Windows.Forms.TextBox txtTrangLN;
        private System.Windows.Forms.Button btnNextLN;
        private System.Windows.Forms.Button btnPrevLN;
        private System.Windows.Forms.DataGridView dtpkDanhSachLoiNhuan;
        private System.Windows.Forms.DateTimePicker dtpkToLoiNhuan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpkFromLoiNhuan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbThongKeLoiNhuan;
    }
}