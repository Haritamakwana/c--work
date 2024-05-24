using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace loan_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double amt, rate, im;

            amt = Convert.ToDouble(textBox1.Text);
            rate = Convert.ToDouble(textBox3.Text)/1200;
            im = Convert.ToDouble(textBox2.Text)*12;
            textBox4.Text = Convert.ToString(amt * rate / 1 - Math.Pow(1 + rate, im * -1));
        }
    }
}
