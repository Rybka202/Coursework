using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form30 : Form
    {
        public Form30()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1.task_12(checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, 11);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((checkBox1.Checked) || (checkBox2.Checked) || (checkBox3.Checked) || (checkBox4.Checked) || (checkBox5.Checked))
            {
                Form31 f = new Form31();
                this.Hide();
                f.ShowDialog();
                Close();
            }
            else
                MessageBox.Show("Надо ответить на вопрос", "Заголовок", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
