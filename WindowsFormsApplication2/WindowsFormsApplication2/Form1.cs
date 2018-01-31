using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {

            WindowsFormsApplication1.Form1 f1 = new WindowsFormsApplication1.Form1();
            f1.ShowDialog();
            int y;
            y=int.Parse(textBox1.Text);
            
        }
    }
}
