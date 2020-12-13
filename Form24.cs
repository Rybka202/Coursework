using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form24 : Form
    {
        public Form24()
        {
            InitializeComponent();
        }

        private void Form24_Load(object sender, EventArgs e)
        {
            trackBar1.Minimum = 3;
            trackBar1.Maximum = 15;
            trackBar1.LargeChange = 1;
            trackBar1.Value = 6;
            label3.Text= "Ваш ответ: "+ Convert.ToString(trackBar1.Value);

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label3.Text = "Ваш ответ: " + Convert.ToString(trackBar1.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(trackBar1.Value==6)
                MessageBox.Show("Надо ответить на вопрос", "Заголовок", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (trackBar1.Value == 10)
            {
                MessageBox.Show("Вы ответили правильно", "Заголовок", MessageBoxButtons.OK, MessageBoxIcon.Information);
                trackBar1.Enabled = false;
                Class1.massiv(5, 1);
            }
            else
            {
                MessageBox.Show("Вы ответили неправильно", "Заголовок", MessageBoxButtons.OK, MessageBoxIcon.Information);
                trackBar1.Enabled = false;
                Class1.massiv(5, 0);
            }
            Form25 f = new Form25();
            this.Hide();
            f.ShowDialog();
            Close();
        }
    }
}
