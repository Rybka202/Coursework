using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form28 : Form
    {
        public Form28()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1.task_10(listBox1, listBox2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class1.task_10(listBox1, listBox3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Class1.task_10(listBox1, listBox4);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Class1.task10(listBox2, listBox3, listBox4, 9);
            Form29 f = new Form29();
            this.Hide();
            f.ShowDialog();
            Close();
        }
    }
}
