﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHub01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int soucet = a + b;
            MessageBox.Show("Součet dvou čísel je: " + soucet);

            int soucin = a * b;
            MessageBox.Show("Součin dvou čísel je: " + soucin);

            int rozdil = a - b;
            MessageBox.Show("Rozdíl dvou čísel je: " + rozdil);

            double podil = (double)a / b;
            MessageBox.Show("Podíl dvou čísel je: " + podil);
        }
    }
}
