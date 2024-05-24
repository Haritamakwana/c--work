using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace practice1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
            label1.Text=Convert.ToString((Convert.ToInt16(textBox1.Text)*9/5)+32);
            }
            if (radioButton2.Checked == true)
            {
            label1.Text=Convert.ToString((Convert.ToInt16(textBox1.Text)-32)*5/9);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox2.SelectedItem);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i;
            for( i=0;i<=listBox1.Items.Count-1;i++)
            listBox2.Items.Add(listBox1.Items[i]);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i <= listBox2.Items.Count - 1; i++)
            listBox1.Items.Add(listBox2.Items[i]);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            Int16 i, n;
            n = Convert.ToInt16(numericUpDown1.Value);
            i = 1;
            while (i <= 10)
            {
                listBox3.Items.Add(n+"*"+i+"="+n*i);
                i+=1;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem=="add")
            {
            label5.Text=(Convert.ToInt16(textBox2.Text)+Convert.ToInt16(textBox3.Text)).ToString();
            }
            else if (comboBox1.SelectedItem == "sub")
            { 
            label5.Text=(Convert.ToInt16(textBox2.Text)-Convert.ToInt16(textBox3.Text)).ToString();
            }
            else if(comboBox1.SelectedItem=="mul")
            {
            label5.Text=(Convert.ToInt16(textBox2.Text)*Convert.ToInt16(textBox3.Text)).ToString();
            }
            else if(comboBox1.SelectedItem=="div")
            {
                label5.Text = (Convert.ToInt16(textBox2.Text) / Convert.ToInt16(textBox3.Text)).ToString();
            }       
        }
    }
}
