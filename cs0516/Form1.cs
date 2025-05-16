using System.Windows.Forms;

namespace cs0516
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ç±ÇÒÇ…ÇøÇÕ");
            MessageBox.Show(100.ToString());
            MessageBox.Show($"{100}");
            MessageBox.Show($"label1.Top={label1.Top}");
            MessageBox.Show(3.14f.ToString());
            MessageBox.Show($"{3.14f}");

            MessageBox.Show(1 + 1.ToString());//èoóÕÇÕÅu11Åv
            MessageBox.Show((1 + 1).ToString());
            MessageBox.Show($"{1 + 1}");
            MessageBox.Show((1.23f * 2.34).ToString());
            MessageBox.Show($"{1.23f * 2.34}");
            MessageBox.Show("1" + "1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = 1;
            a += 5;
            MessageBox.Show($"{a}");
            a -= 5;
            MessageBox.Show($"{a}");
            a *= 5;
            MessageBox.Show($"{a}");
            a /= 5;
            MessageBox.Show($"{a}");
            a %= 5;
            MessageBox.Show($"{a}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello");
            label1.Text = "hello";
            MessageBox.Show($"Ç±ÇÒÇ…ÇøÇÕ{textBox1.Text}Ç≥ÇÒ");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += 1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a;
            float fw;
            string str;
            bool bl;

            int b = 10;
            float fw2 = -10.5f;
            string str2 = "Ç±ÇÒÇ…ÇøÇÕ";
            bool bl2 = true;
        }
    }
}
