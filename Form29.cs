using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form29 : Form
    {
        public Form29()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1.task_11(checkedListBox1, 10);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(!(checkedListBox1.CheckedItems.Count == 0))
            {
                Form30 f = new Form30();
                this.Hide();
                f.ShowDialog();
                Close();
            }
            else
                MessageBox.Show("Надо ответить на вопрос", "Заголовок", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
