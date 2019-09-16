using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemBanHang
{
    public partial class main : Form
    {
        List<Student> ds_hs = new List<Student>();
        public main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            string rootPath = @"D:\Ex-on-school\school\PhanMemBanHang\PhanMemBanHang\uploads\{0}";
            ds_hs.Add(new Student { name = "hoc sinh 1", path = string.Format(rootPath, "01_1.jpg") });
            ds_hs.Add(new Student { name = "hoc sinh 1", path = string.Format(rootPath, "01_5.jpg") });
            ds_hs.Add(new Student { name = "hoc sinh 1", path = string.Format(rootPath, "01_6.jpg") });
            ds_hs.Add(new Student { name = "hoc sinh 1", path = string.Format(rootPath, "01_6.jpg") });
            ds_hs.Add(new Student { name = "hoc sinh 1", path = string.Format(rootPath, "01_6.jpg") });
            ds_hs.Add(new Student { name = "hoc sinh 1", path = string.Format(rootPath, "01_6.jpg") });
            dataGridView1.DataSource = ds_hs;
            dataGridView1.Columns[0].HeaderText = "Ten HS";
            dataGridView1.Columns[2].Width = 80;


            ToolStripMenuItem admin = menuStrip1.Items["admin"] as ToolStripMenuItem;
            admin.Visible = false;

            //foreach (ToolStripMenuItem item in menuStrip1.Items)
            //{
            //    if(item.Name == "admin")
            //    {
            //        item.Visible = false;
            //    }
            //}
        }
    }
}
