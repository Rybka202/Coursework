using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form31 : Form
    {
        public Form31()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1.task_13(comboBox1, 12);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!(comboBox1.SelectedIndex == -1))
            {
                Form32 f = new Form32();
                this.Hide();
                f.ShowDialog();
                Close();
            }
            else
                MessageBox.Show("Надо ответить на вопрос", "Заголовок", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
