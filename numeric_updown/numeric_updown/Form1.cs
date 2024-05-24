using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace numeric_updown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Int16 i, n;
            n = Convert.ToInt16(numericUpDown1.Value);
            i = 1;
            while (i <= 10)
            {
                listBox1.Items.Add(n + "*" + i + "=" + n * i);
                i += 1;
            }
        }
    }
}
