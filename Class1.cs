using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Class1
    {
        public static void massiv(int i,int n,params string [] a1)
        {
            string[] a = new string[14];
            if (n == 1)
                a[i] = "Верно";
            else if (n == 0)
                a[i] = "Неверно";
            a1[i] = a[i];
        }
        public static void task_9(TextBox t, int i)
        {
            if (t.Text == "")
                MessageBox.Show("Вы не ответили на вопрос", "Заголовок", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if ((t.Text == "Лимит остатка") || (t.Text == "Лимитостатка"))
            {
                MessageBox.Show("Вы ответили правильно", "Заголовок", MessageBoxButtons.OK, MessageBoxIcon.Information);
                t.Enabled = false;
                Class1.massiv(i, 1);
            }
            else
            {
                MessageBox.Show("Вы ответили неправильно", "Заголовок", MessageBoxButtons.OK, MessageBoxIcon.Information);
                t.Enabled = false;
                Class1.massiv(i, 0);
            }
        }
        public static void task_10(ListBox t, ListBox tx)
        {
            if (t.SelectedIndex == 0)
            {
                tx.Items.Add(t.Text);
                tx.Text = Convert.ToString(t.SelectedIndex);
                t.Items.RemoveAt(0);
            }
            if (t.SelectedIndex == 1)
            {
                tx.Items.Add(t.Text);
                tx.Text = Convert.ToString(t.SelectedIndex);
                t.Items.RemoveAt(1);
            }
            if (t.SelectedIndex == 2)
            {
                tx.Items.Add(t.Text);
                tx.Text = Convert.ToString(t.SelectedIndex);
                t.Items.RemoveAt(2);
            }
        }
        public static void task10(ListBox t2, ListBox t3, ListBox t4, int i)
        {
            if (t2.Text == "" && t3.Text == "" && t4.Text == "")
                MessageBox.Show("Надо ответить на вопрос", "Заголовок", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if ((t2.Items[0] == "Денежные чековые книжки") && (t3.Items[0] == "Монеты из драгоценных металлов") && (t4.Items[0] == "Банковские карты и ПИН-конверты к ним")||((t2.Items[0] == "Банковские карты и ПИН-конверты к ним") && (t3.Items[0] == "Монеты из драгоценных металлов") && (t4.Items[0] == "Денежные чековые книжки")))
            {
                MessageBox.Show("Вы ответили правильно", "Заголовок", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Class1.massiv(i, 1);
            }
            else
            {
                MessageBox.Show("Вы ответили неправильно", "Заголовок", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Class1.massiv(i, 0);
            }
        }
        public static void task_11(CheckedListBox t, int i)
        {
            if (t.CheckedItems.Count == 0)
                MessageBox.Show("Надо ответить на вопрос", "Заголовок", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (t.CheckedIndices.Count == 2 && t.CheckedIndices.Contains(0) && t.CheckedIndices.Contains(1))
            {
                MessageBox.Show("Вы ответили правильно", "Заголовок", MessageBoxButtons.OK, MessageBoxIcon.Information);
                t.Enabled = false;
                Class1.massiv(i, 1);
            }
            else
            {
                MessageBox.Show("Вы ответили неправильно", "Заголовок", MessageBoxButtons.OK, MessageBoxIcon.Information);
                t.Enabled = false;
                Class1.massiv(i, 0);
            }
        }
        public static void task_12(CheckBox t1, CheckBox t2, CheckBox t3, CheckBox t4, CheckBox t5, int i)
        {
            if ((!t1.Checked) && (!t2.Checked) && (!t3.Checked) && (!t4.Checked) && (!t5.Checked))
                MessageBox.Show("Надо ответить на вопрос", "Заголовок", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if ((t1.Checked) && (!t2.Checked) && (t3.Checked) && (!t4.Checked) && (t5.Checked))
            {
                MessageBox.Show("Вы ответили правильно", "Заголовок", MessageBoxButtons.OK, MessageBoxIcon.Information);
                t1.Enabled = false;
                t2.Enabled = false;
                t3.Enabled = false;
                t4.Enabled = false;
                t5.Enabled = false;
                Class1.massiv(i, 1);
            }
            else
            {
                MessageBox.Show("Вы ответили неправильно", "Заголовок", MessageBoxButtons.OK, MessageBoxIcon.Information);
                t1.Enabled = false;
                t2.Enabled = false;
                t3.Enabled = false;
                t4.Enabled = false;
                t5.Enabled = false;
                Class1.massiv(i, 0);
            }
        }
        public static void task_13(ComboBox t, int i)
        {
            if (t.SelectedIndex == -1)
                MessageBox.Show("Надо ответить на вопрос", "Заголовок", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (t.SelectedIndex == 0)
            {
                MessageBox.Show("Вы ответили правильно", "Заголовок", MessageBoxButtons.OK, MessageBoxIcon.Information);
                t.Enabled = false;
                Class1.massiv(i, 1);
            }
            else
            {
                MessageBox.Show("Вы ответили неправильно", "Заголовок", MessageBoxButtons.OK, MessageBoxIcon.Information);
                t.Enabled = false;
                Class1.massiv(i, 0);
            }
        }
        public static void task_14(TrackBar t, int i)
        {
            if (t.Value == 3)
                MessageBox.Show("Надо ответить на вопрос", "Заголовок", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (t.Value == 2)
            {
                MessageBox.Show("Вы ответили правильно", "Заголовок", MessageBoxButtons.OK, MessageBoxIcon.Information);
                t.Enabled = false;
                Class1.massiv(i, 1);
            }
            else
            {
                MessageBox.Show("Вы ответили неправильно", "Заголовок", MessageBoxButtons.OK, MessageBoxIcon.Information);
                t.Enabled = false;
                Class1.massiv(i, 0);
            }
        }
        public static void output_mas(int len, DataGridView DGV, params int[] a)
        {
            DGV.ColumnCount = 2;
            DGV.RowCount = len;
            for (int i = 0; i < len; i++)
            {
                DGV.Columns[0].Cells[i].Value= "[" + (i + 1) + "]";
                DGV.Rows[1].Cells[i].Value = a[i];
            }
            int height = 0;
            for (int s = 0; s < DGV.RowCount; s++)
                height += DGV.Rows[s].Height;
            if (height > 1200)
                DGV.Height = 1200;
            else
                DGV.Height = height;
        }
    }
}

