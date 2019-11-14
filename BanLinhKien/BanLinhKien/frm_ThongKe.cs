using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
namespace BanLinhKien
{
    public partial class frm_ThongKe : Form
    {
        bool isCbPhieuNhapLoaded = false;
        bool isCbPhieuXuatLoaded = false;
        bool isCbKhachHangLoaded = false;
        

        private enum TimeReport
        {
            Today = 4,
            Week = 3,
            Month = 2,
            Year = 1,
            Custom = 0
        }

        private Hashtable timeReport = new Hashtable()
        {
            {4, "Hôm nay" },
            {3,"Tuần này" },
            {2, "Tháng này" },
            {1, "Năm này" },
            {0 , "Tùy chọn" }

        };

        public frm_ThongKe()
        {
            InitializeComponent();
        }

        private void Frm_ThongKe_Load(object sender, EventArgs e)
        {
           
            // set datasource for combobox
            cbThongKePhieuNhap.DataSource = new BindingSource(timeReport, null);
            cbThongKePhieuNhap.DisplayMember = "Value";
            cbThongKePhieuNhap.ValueMember = "Key";
            isCbPhieuNhapLoaded = true;

            cbThongKePhieuXuat.DataSource = new BindingSource(timeReport, null);
            cbThongKePhieuXuat.DisplayMember = "Value";
            cbThongKePhieuXuat.ValueMember = "Key";
            isCbPhieuXuatLoaded = true;

            cbThongKeKhachHang.DataSource = new BindingSource(timeReport, null);
            cbThongKeKhachHang.DisplayMember = "Value";
            cbThongKeKhachHang.ValueMember = "Key";
            isCbKhachHangLoaded = true;

            // load defailt report
            loadingReportPhieuNhap(DateTime.Now, DateTime.Now);
        }
        
        void pickTime(int value, ref DateTime from, ref DateTime to)
        {


            switch (value)
            {
                case (int)TimeReport.Today:
                    from = DateTime.Now;
                    to = DateTime.Now;
                    break;
                case (int)TimeReport.Week:
                    if ((int)DateTime.Today.DayOfWeek == 0)
                        from = DateTime.Today.AddDays(-6);
                    else
                        from = DateTime.Today.AddDays(-((int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday));

                    to = DateTime.Now;
                    break;
                case (int)TimeReport.Month:
                    from = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                    to = DateTime.Now;
                    break;
                case (int)TimeReport.Year:
                    from = new DateTime(DateTime.Now.Year, 1, 1);
                    to = DateTime.Now;
                    break;
                case (int)TimeReport.Custom:

                    switch (tabControlThongKe.SelectedTab.Name)
                    {
                        case "tabPhieuNhap":
                            from = dtpkFromPhieuNhap.Value;
                            to = dtpkToPhieuNhap.Value;
                            break;
                        case "tabPhieuXuat":
                            from = dtpkFromPhieuXuat.Value;
                            to = dtpkToPhieuXuat.Value;
                            break;
                        case "tabKhachHang":
                            from = dtpkFromKhachHang.Value;
                            to = dtpkToKhachHang.Value;
                            break;
                        case "tabLoiNhuan":
                            break;
                    }
                    break;
            }
        }

        void loadingReportPhieuXuat(DateTime from, DateTime to)
        {

            string distanceTime = "";
            if (from.Equals(to))
            {
                distanceTime = String.Format("Ngày {0}", from.ToString("dd-MM-yyyy"));
            }
            else
            {
                distanceTime = String.Format("Từ: {0}       Đến: {1}", from.ToString("dd-MM-yyyy"), to.ToString("dd-MM-yyyy"));
            }



            ReportParameter param = new ReportParameter("txtDistanceTime", distanceTime);
            this.rpvPhieuXuat.LocalReport.SetParameters(param);
            this.USP_ReportPhieuXuatTableAdapter.Fill(this.DataSet_ThongKe.USP_ReportPhieuXuat, from.ToString("yyyy-MM-dd"), to.ToString("yyyy-MM-dd"));
            this.rpvPhieuXuat.RefreshReport();

        }

        void loadingReportKhachHang(DateTime from, DateTime to)
        {
            string distanceTime = "";
            if (from.Equals(to))
            {
                distanceTime = String.Format("Ngày {0}", from.ToString("dd-MM-yyyy"));
            }
            else
            {
                distanceTime = String.Format("Từ: {0}       Đến: {1}", from.ToString("dd-MM-yyyy"), to.ToString("dd-MM-yyyy"));
            }
            ReportParameter param = new ReportParameter("txtDistanceTimeKH", distanceTime);
            this.rpvKhachHang.LocalReport.SetParameters(param);
            this.USP_ReportKhachHangTableAdapter.Fill(this.DataSet_ThongKe.USP_ReportKhachHang, from.ToString("yyyy-MM-dd"), to.ToString("yyyy-MM-dd"));
            this.rpvKhachHang.RefreshReport();
        }

        void loadingReportPhieuNhap(DateTime from, DateTime to)
        {
            string distanceTime = "";
            if (from.Equals(to))
            {
                distanceTime = String.Format("Ngày {0}", from.ToString("dd-MM-yyyy"));
            }
            else
            {
                distanceTime = String.Format("Từ: {0}       Đến: {1}", from.ToString("dd-MM-yyyy"), to.ToString("dd-MM-yyyy"));
            }
            ReportParameter param = new ReportParameter("txtDistanceTimePN", distanceTime);
            this.rpvPhieuNhap.LocalReport.SetParameters(param);
            this.USP_ReportPhieuNhapTableAdapter.Fill(this.DataSet_ThongKe.USP_ReportPhieuNhap,from.ToString("yyyy-MM-dd"), to.ToString("yyyy-MM-dd"));
            this.rpvPhieuNhap.RefreshReport();
        }

        private void CbThongKeKhachHang_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!isCbKhachHangLoaded) return;


            DateTime from = new DateTime();
            DateTime to = new DateTime();

            if ((int)cbThongKeKhachHang.SelectedValue == (int)TimeReport.Custom)
            {
                lblFromKhachHang.Visible = true;
                lblToKhachHang.Visible = true;
                dtpkFromKhachHang.Visible = true;
                dtpkToKhachHang.Visible = true;
            }
            else
            {
                lblFromKhachHang.Visible = false;
                lblToKhachHang.Visible = false;
                dtpkFromKhachHang.Visible = false;
                dtpkToKhachHang.Visible = false;
            }
            pickTime((int)cbThongKeKhachHang.SelectedValue, ref from, ref to);

            loadingReportKhachHang(from, to);
        }

        private void CbThongKePhieuXuat_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!isCbPhieuXuatLoaded) return;


            DateTime from = new DateTime();
            DateTime to = new DateTime();

            if ((int)cbThongKePhieuXuat.SelectedValue == (int)TimeReport.Custom)
            {
                lblFromPhieuXuat.Visible = true;
                lblToPhieuXuat.Visible = true;
                dtpkFromPhieuXuat.Visible = true;
                dtpkToPhieuXuat.Visible = true;
            }
            else
            {
                lblFromPhieuXuat.Visible = false;
                lblToPhieuXuat.Visible = false;
                dtpkFromPhieuXuat.Visible = false;
                dtpkToPhieuXuat.Visible = false;
            }
            pickTime((int)cbThongKePhieuXuat.SelectedValue, ref from, ref to);

            loadingReportPhieuXuat(from, to);
        }

        private void CbThongKePhieuNhap_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!isCbPhieuNhapLoaded) return;


            DateTime from = new DateTime();
            DateTime to = new DateTime();

            if ((int)cbThongKePhieuNhap.SelectedValue == (int)TimeReport.Custom)
            {
                lblFromPhieuNhap.Visible = true;
                lblToPhieuNhap.Visible = true;
                dtpkFromPhieuNhap.Visible = true;
                dtpkToPhieuNhap.Visible = true;
            }
            else
            {
                lblFromPhieuNhap.Visible = false;
                lblToPhieuNhap.Visible = false;
                dtpkFromPhieuNhap.Visible = false;
                dtpkToPhieuNhap.Visible = false;
            }
            pickTime((int)cbThongKePhieuNhap.SelectedValue, ref from, ref to);

            loadingReportPhieuNhap(from, to);
        }

        private void TabControlThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControlThongKe.SelectedTab.Name)
            {
                case "tabPhieuNhap":
                    loadingReportPhieuNhap(DateTime.Now, DateTime.Now);
                    break;
                case "tabPhieuXuat":
                    loadingReportPhieuXuat(DateTime.Now, DateTime.Now);
                    break;
                case "tabKhachHang":
                    loadingReportKhachHang(DateTime.Now, DateTime.Now);
                    break;
                case "tabLoiNhuan":
                    this.USP_ReportLoiNhuanTableAdapter.Fill(this.DataSet_ThongKe.USP_ReportLoiNhuan);
                    this.rpvLoiNhuan.RefreshReport();
                    break;
            }
        }

       
    }
}
