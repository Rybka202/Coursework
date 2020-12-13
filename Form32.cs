using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form32 : Form
    {
        public Form32()
        {
            InitializeComponent();
        }

        private void Form32_Load(object sender, EventArgs e)
        {
            trackBar1.Minimum = 1;
            trackBar1.Maximum = 5;
            trackBar1.LargeChange = 1;
            trackBar1.Value = 3;
            label3.Text = "Ваш ответ: " + Convert.ToString(trackBar1.Value);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label3.Text = "Ваш ответ: " + Convert.ToString(trackBar1.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1.task_14(trackBar1, 13);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(!(trackBar1.Value == 3))
            {
                Form33 f = new Form33();
                this.Hide();
                f.ShowDialog();
                Close();
            }
            else
                MessageBox.Show("Надо ответить на вопрос", "Заголовок", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
