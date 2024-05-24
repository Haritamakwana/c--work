using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace timer
{
    public partial class Form1 : Form
    {
        int i, n;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            n = Convert.ToInt16(this.Height);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = System.DateTime.Today.ToString();
            i = i + 1;
            if (i >= n)
            {
                i = 10;
            }
            label1.Location = new Point(100, i);
        }
    }
}
