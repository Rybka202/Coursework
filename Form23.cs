using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();
        }

        private void Form23_Load(object sender, EventArgs e)
        {
            string[] a = new string[3];
            a[0] = "Драгоценные металлы";
            a[1] = "Денежная наличность";
            a[2] = "Ценности";
            for (int i = 0; i <= 2; i++)
                listBox1.Items.Add(a[i]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                listBox2.Items.Add(listBox1.Text);
                listBox2.Text = Convert.ToString(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(0);
            }
            if (listBox1.SelectedIndex == 1)
            {
                listBox2.Items.Add(listBox1.Text);
                listBox2.Text = Convert.ToString(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(1);
            }
            if (listBox1.SelectedIndex == 2)
            {
                listBox2.Items.Add(listBox1.Text);
                listBox2.Text = Convert.ToString(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(2);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                listBox3.Items.Add(listBox1.Text);
                listBox3.Text = Convert.ToString(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(0);
            }
            if (listBox1.SelectedIndex == 1)
            {
                listBox3.Items.Add(listBox1.Text);
                listBox3.Text = Convert.ToString(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(1);
            }
            if (listBox1.SelectedIndex == 2)
            {
                listBox3.Items.Add(listBox1.Text);
                listBox3.Text = Convert.ToString(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(2);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                listBox4.Items.Add(listBox1.Text);
                listBox4.Text = Convert.ToString(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(0);
            }
            if (listBox1.SelectedIndex == 1)
            {
                listBox4.Items.Add(listBox1.Text);
                listBox4.Text = Convert.ToString(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(1);
            }
            if (listBox1.SelectedIndex == 2)
            {
                listBox4.Items.Add(listBox1.Text);
                listBox4.Text = Convert.ToString(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox2.Text == "" && listBox3.Text == "" && listBox4.Text == "")
                MessageBox.Show("Надо ответить на вопрос", "Заголовок", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if ((listBox2.Items[0]=="Денежная наличность") && (listBox3.Items[0] == "Ценности") && (listBox4.Items[0] == "Драгоценные металлы"))
            {
                MessageBox.Show("Вы ответили правильно", "Заголовок", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listBox1.Enabled = false;
                Class1.massiv(4, 1);
                Form24 f = new Form24();
                this.Hide();
                f.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Вы ответили неправильно", "Заголовок", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listBox1.Enabled = false;
                Class1.massiv(4, 0);
                Form24 f = new Form24();
                this.Hide();
                f.ShowDialog();
                Close();
            }       
        }
    }
}
