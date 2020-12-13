using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Вы не ответили на вопрос", "Заголовок", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if ((textBox1.Text=="Денежный оборот")||(textBox1.Text == "Денежныйоборот"))
            {
                MessageBox.Show("Вы ответили правильно", "Заголовок", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Enabled = false;
                Class1.massiv(0,1);
            }
            else
            {
                MessageBox.Show("Вы ответили неправильно", "Заголовок", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Enabled = false;
                Class1.massiv(0, 0);
            } 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!(textBox1.Text == ""))
            {
                Form20 f = new Form20();
                this.Hide();
                f.ShowDialog();
                Close();
            }
            else
                MessageBox.Show("Вы не ответили на вопрос", "Заголовок", MessageBoxButtons.OK, MessageBoxIcon.Information);          
        }
    }
}
