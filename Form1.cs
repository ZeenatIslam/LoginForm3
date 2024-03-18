namespace LoginForm3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            string s = textBox1.Text;
            string d = textBox2.Text;
            if (s == "zeenat" && d=="zeenat")
            {
                Form2 f = new Form2();
                f.Show();

            }
            else
            {
                MessageBox.Show("wrong input");

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
