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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            int max = (num1 > num2) ? num2 : num1;

            int[] arr = new int[max + 2];
            for (int i = 2; i <= max; i++)
            {
                if (num1 % i == 0 && num2 % i == 0)
                {
                    arr[i] = i;
                }
            }
            int g = arr[2];
            for (int i = 0; i <= max; i++)
            {
                if (arr[i] > g)
                    g = arr[i];
            }
            button1.Text = (Convert.ToString(g));

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
