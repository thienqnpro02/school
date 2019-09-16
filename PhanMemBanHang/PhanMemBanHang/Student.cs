using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemBanHang
{
    public class Student
    {
        public string name { get; set; }
        public string path { get; set; }
        public Image picture
        {
            get
            {
                if(!String.IsNullOrEmpty(this.path))
                {
                    if (File.Exists(this.path))
                    {
                        return resizeImg(Image.FromFile(this.path), new Size(80, 80));
                    }
                    
                }
                return null;
            }
        }

        private Image resizeImg(Image img, Size size)
        {
            return (Image)(new Bitmap(img, size));
        }

        public Student()
        {

        }
    }
}
