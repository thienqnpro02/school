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

namespace BanLinhKien
{
    public partial class frm_ThongKe : Form
    {
        private enum TimeReport
        {
            Today = 0,
            Week = 1,
            Month = 2,
            Year = 3,
            Custom = 4
        }

        private Hashtable timeReport = new Hashtable()
        {
            {4 , "Tùy chọn" },
            {3, "Năm này" },
            {2, "Tháng này" },
            {1,"Tuần này" },
            {0, "Hôm nay" }
        };

        public frm_ThongKe()
        {
            InitializeComponent();
        }

        private void Frm_ThongKe_Load(object sender, EventArgs e)
        {
            
        }
    }
}
