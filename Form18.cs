﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form17 f = new Form17();
            this.Hide();
            f.ShowDialog();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form19 f = new Form19();
            this.Hide();
            f.ShowDialog();
            Close();
        }
    }
}
