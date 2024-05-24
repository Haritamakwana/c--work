using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace vowels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str;
            char c;
            str = textBox1.Text;
            Int16 i, strlen, nv, nss, ns, nd;
            i = 0;
            nv = 0;
            ns = 0;
            nss = 0;
            nd = 0;
            strlen = Convert.ToInt16(str.Length);
            while (i <= strlen - 1)
            {
                c = Convert.ToChar(str.Substring(i, 1));
                if (char.IsWhiteSpace(c) == true)
                {
                    ns += 1;
                }
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    nv += 1;
                }
                if (char.IsSymbol(c) == true)
                {
                    nss += 1;
                }
                if (char.IsDigit(c) == true)
                {
                    nd += 1;
                }
                i += 1;
            }
            if (radioButton1.Checked == true)
            {
                label1.Text = "vowel:" + nv;
            }
            if (radioButton2.Checked == true)
            {
                label1.Text = "spaces:" + ns;
            }
            if (radioButton3.Checked == true)
            {
                label1.Text = "digit:" + nd;
            }
            if (radioButton4.Checked == true)
            {
                label1.Text = "sp symbol:" + nss;
            }

        }

    }
}
