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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);

            int n2 = n + 1;
            int found = 0;
            for (int i = 0; i < n2; i++)
            {
                if (i * i == n2)
                {
                    found = 1;

                }
            }
            if (found == 1)
            {
                button1.Text = Convert.ToString("Yes");
            }
            else
            {
                button1.Text = Convert.ToString("NO");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

