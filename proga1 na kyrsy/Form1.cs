using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proga1_na_kyrsy
{
    public partial class Form1 : Form
    {
        internal double h, w, l, h1, w1;
        internal int check;
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                w1 = Convert.ToDouble(textBox6.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("You have entered a character. Enter the number!");
            }

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            try
            {
                h1 = Convert.ToDouble(textBox4.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("You have entered a character. Enter the number!");
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (h1 > h && (w1 > w || w1 > l))
            {
                check = 1;
            }
            else if (h1 > h && (w1 < w || w1 < l))
            {
                check = 0;
            }
            else if (h1 < h)
            {
                check = 0;
            }
            else
            {
                check = 0;
            }

            if (check == 0)
            {
                textBox7.Clear();
                textBox7.AppendText("not fit");
            }
            if (check == 1)
            {
                textBox7.Clear();
                textBox7.AppendText("fit");
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                l = Convert.ToDouble(textBox2.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("You have entered a character. Enter the number!");
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                w = Convert.ToDouble(textBox1.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("You have entered a character. Enter the number!");
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                h = Convert.ToDouble(textBox3.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("You have entered a character. Enter the number!");
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
    }
}

