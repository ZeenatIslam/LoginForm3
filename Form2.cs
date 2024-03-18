using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj = new Form1();
            obj.ShowDialog();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gCDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.ShowDialog();
        }

        private void sunnyNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 H = new Form5();
            H.ShowDialog();
        }

        private void buzzNumberToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
