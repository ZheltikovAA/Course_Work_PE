using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork_Sharp
{
    public partial class wildVal : Form
    {
        static string link = "C:\\Users\\Alexander\\Desktop\\Курсач ПИ\\dataset\\val\\wild\\flickr_wild_";
        static int count = 2;
        static string number = "000057";

       
        public wildVal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  >>
            if (Convert.ToInt32(number) <= 4834)
            {
                string foo;
                pictureBox1.ImageLocation = link + number + ".jpg";
                count++;
                foo = Convert.ToString(count);
                number = number.Remove(number.Length - foo.Length);
                number += foo;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(number) >= 2)
            {
                string foo;
                pictureBox1.ImageLocation = link + number + ".jpg";
                count--;
                foo = Convert.ToString(count);
                number = number.Remove(number.Length - foo.Length);
                number += foo;
            }
        }


    }
}
