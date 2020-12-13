using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form27 : Form
    {
        public Form27()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1.task_9(textBox1, 8);
            Form28 f = new Form28();
            this.Hide();
            f.ShowDialog();
            Close();
        }
    }
}
