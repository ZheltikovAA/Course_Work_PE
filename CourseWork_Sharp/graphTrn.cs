using System;
using System.IO;
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
    public partial class graphTrn : Form
    {
        public graphTrn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pass = "C:\\Users\\Alexander\\Desktop\\Курсач ПИ\\acc.png";

            pictureBox1.ImageLocation = pass;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
