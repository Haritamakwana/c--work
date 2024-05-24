using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        double oldvalue=0;
        char opr;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += Convert.ToString(button1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += Convert.ToString(button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += Convert.ToString(button3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += Convert.ToString(button4.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += Convert.ToString(button5.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += Convert.ToString(button6.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += Convert.ToString(button7.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += Convert.ToString(button8.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += Convert.ToString(button9.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += Convert.ToString(button10.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += Convert.ToString(button11.Text);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Log(Convert.ToDouble(textBox1.Text)).ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Pow(Convert.ToDouble(textBox1.Text),2).ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Sqrt(Convert.ToDouble(textBox1.Text)).ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            oldvalue=Convert.ToDouble(textBox1.Text);
            opr='+';
            textBox1.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            oldvalue=Convert.ToDouble(textBox1.Text);
            opr='-';
            textBox1.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            oldvalue=Convert.ToDouble(textBox1.Text);
            opr='*';
            textBox1.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            oldvalue=Convert.ToDouble(textBox1.Text);
            opr='/';
            textBox1.Clear();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if(opr=='+')
            {
                oldvalue=oldvalue+Convert.ToDouble(textBox1.Text);
                textBox1.Text= Convert.ToString(oldvalue);
            }
            if(opr=='-')
            {
                oldvalue=oldvalue-Convert.ToDouble(textBox1.Text);
                textBox1.Text= Convert.ToString(oldvalue);
            }
            if(opr=='*')
            {
                oldvalue=oldvalue*Convert.ToDouble(textBox1.Text);
                textBox1.Text= Convert.ToString(oldvalue);
            }
            if(opr=='/')
            {
                oldvalue=oldvalue/Convert.ToDouble(textBox1.Text);
                textBox1.Text= Convert.ToString(oldvalue);
            }
        }
    }
}
