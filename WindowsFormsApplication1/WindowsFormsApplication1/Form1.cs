﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            string str, str1, str2;
            int f;
            str = textBox1.Text;
            str1 = textBox2.Text;
            str2 = textBox3.Text;
            f = int.Parse(textBox4.Text);
            MessageBox.Show("welcome to AVAAT application");
        }
    }
}
