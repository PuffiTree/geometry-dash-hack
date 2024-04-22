using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            char buchstabe = (char)trackBar1.Value;
            label1.Text = buchstabe.ToString();
            label3.Text = trackBar1.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char buchstabe = (char)trackBar1.Value;
            textBox1.Text += buchstabe.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
            foreach (char c in textBox1.Text)
            {
                textBox2.Text += ((int)c).ToString();
                textBox2.Text += ", ";
            }
        }
    }
}
