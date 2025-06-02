using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Calc : Form
    {



        public Calc()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";

        }

        private void button11_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length > 0)
            {
                char lastChar = textBox1.Text[textBox1.Text.Length - 1];
                if (lastChar != '+' && lastChar != '-' && lastChar != '*' && lastChar != '/')
                {
                    textBox1.Text += "*";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";

        }

        private void button8_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + "8";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";

        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";

        }

        private void button13_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length > 0)
            {
                char lastChar = textBox1.Text[textBox1.Text.Length - 1];
                if (lastChar != '+' && lastChar != '-' && lastChar != '*' && lastChar != '/')
                {
                    textBox1.Text += "-";
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {


            if (textBox1.Text.Length > 0)
            {
                char lastChar = textBox1.Text[textBox1.Text.Length - 1];
                if (lastChar != '+' && lastChar != '-' && lastChar != '*' && lastChar != '/')
                {
                    textBox1.Text += "/";
                }
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length > 0)
            {
                char lastChar = textBox1.Text[textBox1.Text.Length - 1];
                if (lastChar != '+' && lastChar != '-' && lastChar != '*' && lastChar != '/')
                { 
                    textBox1.Text += "+";
                }
            }

        }
        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                var result = new System.Data.DataTable().Compute(textBox1.Text, null);
                textBox1.Text = result.ToString();
            }
            catch
            {
                textBox1.Text = "Error";
            }
        }
    }
} 
