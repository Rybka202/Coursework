using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((!radioButton1.Checked) && (!radioButton2.Checked) && (!radioButton3.Checked) && (!radioButton4.Checked))
                MessageBox.Show("Надо ответить на вопрос", "Заголовок", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (radioButton3.Checked)
            {
                MessageBox.Show("Вы ответили правильно", "Заголовок", MessageBoxButtons.OK, MessageBoxIcon.Information);
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                Class1.massiv(2, 1);
            }
            else
            {
                MessageBox.Show("Вы ответили правильно", "Заголовок", MessageBoxButtons.OK, MessageBoxIcon.Information);
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                Class1.massiv(2, 0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
            {
                Form22 f = new Form22();
                this.Hide();
                f.ShowDialog();
                Close();
            }
            else
                MessageBox.Show("Надо ответить на вопрос", "Заголовок", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
