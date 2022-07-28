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
    public partial class graphVal : Form
    {
        public graphVal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pass = "C:\\Users\\Alexander\\Desktop\\Курсач ПИ\\loss.png";

            pictureBox1.ImageLocation = pass;
        }
    }
}
