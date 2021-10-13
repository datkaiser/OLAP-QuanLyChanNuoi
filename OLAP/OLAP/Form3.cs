using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OLAP
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void ádToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ádasdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 form3 = new Form6();
            form3.ShowDialog();
            this.Close();
        }

        private void ádadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            RibbonForm1 form3 = new RibbonForm1();
            form3.ShowDialog();
            this.Close();
        }

        private void sQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void eXCELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form1 = new Form5();
            form1.ShowDialog();
            this.Close();
        }
    }
}
