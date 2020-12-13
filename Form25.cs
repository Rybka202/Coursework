using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form25 : Form
    {
        public Form25()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkedListBox1.CheckedItems.Count==0)
                MessageBox.Show("Надо ответить на вопрос", "Заголовок", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if(checkedListBox1.CheckedIndices.Count==3 && checkedListBox1.CheckedIndices.Contains(0) && checkedListBox1.CheckedIndices.Contains(1) && checkedListBox1.CheckedIndices.Contains(4))
            {
                MessageBox.Show("Вы ответили правильно", "Заголовок", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkedListBox1.Enabled = false;
                Class1.massiv(6, 1);
            }
            else
            {
                MessageBox.Show("Вы ответили неправильно", "Заголовок", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkedListBox1.Enabled = false;
                Class1.massiv(6, 0);
            }
            Form26 f = new Form26();
            this.Hide();
            f.ShowDialog();
            Close();
        }
    }
}
