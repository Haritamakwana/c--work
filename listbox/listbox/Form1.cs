using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox2.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i <= listBox1.Items.Count - 1; i++)
            {
                listBox2.Items.Add(listBox1.Items[i].ToString());

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i <= listBox2.Items.Count - 1; i++)
            {
                listBox1.Items.Add(listBox2.Items[i].ToString());

            }
        }
    }
}
