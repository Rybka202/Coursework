using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex==-1)
                MessageBox.Show("Надо ответить на вопрос", "Заголовок", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (comboBox1.SelectedIndex == 1)
            {
                MessageBox.Show("Вы ответили правильно", "Заголовок", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox1.Enabled = false;
                Class1.massiv(3, 1);
            }
            else
            {
                MessageBox.Show("Вы ответили неправильно", "Заголовок", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox1.Enabled = false;
                Class1.massiv(3, 0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!(comboBox1.SelectedIndex == -1))
            {
                Form23 f = new Form23();
                this.Hide();
                f.ShowDialog();
                Close();
            }
            else
                MessageBox.Show("Надо ответить на вопрос", "Заголовок", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
