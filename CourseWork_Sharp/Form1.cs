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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void котыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            catTrn traincat = new catTrn();
            traincat.Show();
        }

        private void собакиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dogTrn traindog = new dogTrn();
            traindog.Show();
        }

        private void дикиеЖивотныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wildTrn trainWild = new wildTrn();
            trainWild.Show();
        }

        private void котыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            catVal traincat = new catVal();
            traincat.Show();
        }

        private void собакиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dogVal traindog = new dogVal();
            traindog.Show();
        }

        private void дикиеЖивотныеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            wildVal trainwild = new wildVal();
            trainwild.Show();
        }

        private void тренировочныеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            graphTrn graph = new graphTrn();
            graph.Show();
        }

        private void валидационныеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            graphVal graph = new graphVal();    
            graph.Show();
        }
    }
}
