using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proga2
{
    public partial class Form1 : Form 
    {
        internal double Rd, Vd, THd, Rozw1, Rozw2, Rozw3, Radk, Rozb1, Rozb2, Math1, Math2, Math3;
        internal int check;
        internal double[] box = new double[3];
        internal double[] door = new double[2];
        internal double[] bok = new double[2];
        internal double[] Mathem = new double[3];

        private void button5_Click(object sender, EventArgs e)
        {
           // KB = true;
            Tomassivebok();
            CheckKB();
            Fix();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            //PW = true;
            Tomassivebox();
            Tomassivedoor();
            CheckPW();
            Fix();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //PK = true;
            Tomassivedoor();
            CheckPK();
            Fix();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          //  PB = true;
            Tomassivebok();
            Tomassivedoor();
            CheckPB();
            Fix();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  KK = true;
            CheckKK();
            Fix();
        }

        private void button4_Click(object sender, EventArgs e)
        {
        //    KW = true;
            Tomassivemath();
            MathMethod();
            Checkitround();
            Fix();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Radk = Convert.ToDouble(textBox6.Text);
            }
            catch (System.FormatException)
            {
                MassageError();
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Rozb1 = Convert.ToDouble(textBox7.Text);
            }
            catch (System.FormatException)
            {
                MassageError();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Rozb2 = Convert.ToDouble(textBox5.Text);
            }
            catch (System.FormatException)
            {
                MassageError();
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Rozw3 = Convert.ToDouble(textBox8.Text);
            }
            catch (System.FormatException)
            {
                MassageError();
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
        internal void Fix()
        {
            if (check == 0)
            {
                textBox10.Clear();
                textBox10.AppendText("not fit");
            }
            else if (check == 1)
            {
                textBox10.Clear();
                textBox10.AppendText("fit");
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Rozw2 = Convert.ToDouble(textBox9.Text);
            }
            catch (System.FormatException)
            {
                MassageError();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Rozw1 = Convert.ToDouble(textBox4.Text);
            }
            catch (System.FormatException)
            {
                MassageError();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                THd = Convert.ToDouble(textBox3.Text);
            }
            catch (System.FormatException)
            {
                MassageError();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Vd = Convert.ToDouble(textBox2.Text);
            }
            catch (System.FormatException)
            {
                MassageError();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Rd = Convert.ToDouble(textBox1.Text);
            }
            catch (System.FormatException)
            {
                MassageError();
            }
        }
        
        public Form1()
        {
            InitializeComponent();
        }

        internal void MassageError()
        {
            MessageBox.Show("You have entered a character. Enter the number!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        internal void Tomassivebox()
        {
            box[0] = Rozw1;
            box[1] = Rozw2;
            box[2] = Rozw3;
        }
        internal void Tomassivedoor()
        {
            door[0] = Vd;
            door[1] = THd;
        }
        internal void Tomassivebok()
        {
            bok[0] = Rozb1;
            bok[1] = Rozb2;
        }
        internal void CheckPK()
        {
            Array.Sort(door);
            if (door[0] >= Radk)
            {
                check = 1;
            }
            else
            {
                check = 0;
            }
        }
        internal void CheckPB()
        {
            Array.Sort(door);
            Array.Sort(bok);
            if (bok[0] <= door[0] && bok[1] <= door[1])
            {
                check = 1;
            }
            else
                check = 0;
        }
        internal void CheckKB()
        {
            Array.Sort(bok);
            if (bok[0] <= Rd)
            {
                check = 1;
            }
            else
                check = 0;
        }
        internal void CheckPW()
        {
            Array.Sort(door);
            Array.Sort(box);
            if (box[0] <= door[0] && box[1] <= door[1])
            {
                check = 1;

            }
            else
                check = 0;
        }
        
        internal void CheckKK()
        {
            if (Radk <= Rd)
            {
                check = 1;
            }
            else
                check = 0;
        }
        
        internal void MathMethod()
        {
            Math1 = Math.Sqrt(Math.Pow(Rozw1, 2) + Math.Pow(Rozw2, 2));
            Math2 = Math.Sqrt(Math.Pow(Rozw2, 2) + Math.Pow(Rozw3, 2));
            Math3 = Math.Sqrt(Math.Pow(Rozw3, 2) + Math.Pow(Rozw1, 2));
        }
        internal void Tomassivemath()
        {
            Mathem[0] = Math1;
            Mathem[1] = Math2;
            Mathem[2] = Math3;


        }
        internal void Checkitround()
        
        {
            Array.Sort(Mathem);
            if (Mathem[0] <= Rd)
            {
                check = 1;

            }
            else
            {
                check = 0;
            }
        }


    }

}
