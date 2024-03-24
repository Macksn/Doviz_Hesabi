using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CLASS_BORSA_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        borsa eleman = new borsa();
        private void button1_Click(object sender, EventArgs e)
        {
            eleman.para = Convert.ToInt16(textBox1.Text);
            if (radioButton1.Checked)
            {
                label2.Text = eleman.dolar()+"$";
            }
            if (radioButton2.Checked)
            {
                label2.Text = eleman.euro()+"EUR";
            }
            if (radioButton3.Checked)
            {
                label2.Text = eleman.altın()+"gram";
            }
                
        }
    }
}
