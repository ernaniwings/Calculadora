using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double num1;
        private double num2;
        private string cal;
        private bool inputstatus = true;

        private void button0_Click(object sender, EventArgs e)
        {
            if (inputstatus)
            {
                if (textBox1.Text.Length >= 1)
                {
                    textBox1.Text += button0.Text;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (inputstatus)
            {
                textBox1.Text += button1.Text;
            }
            else
            {
                textBox1.Text = button1.Text;
                inputstatus = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (inputstatus)
            {
                textBox1.Text += button2.Text;
            }
            else
            {
                textBox1.Text = button2.Text;
                inputstatus = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (inputstatus)
            {
                textBox1.Text += button3.Text;
            }
            else
            {
                textBox1.Text = button3.Text;
                inputstatus = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (inputstatus)
            {
                textBox1.Text += button4.Text;
            }
            else
            {
                textBox1.Text = button4.Text;
                inputstatus = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (inputstatus)
            {
                textBox1.Text += button5.Text;
            }
            else
            {
                textBox1.Text = button5.Text;
                inputstatus = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (inputstatus)
            {
                textBox1.Text += button6.Text;
            }
            else
            {
                textBox1.Text = button6.Text;
                inputstatus = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (inputstatus)
            {
                textBox1.Text += button7.Text;
            }
            else
            {
                textBox1.Text = button7.Text;
                inputstatus = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (inputstatus)
            {
                textBox1.Text += button8.Text;
            }
            else
            {
                textBox1.Text = button8.Text;
                inputstatus = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (inputstatus)
            {
                textBox1.Text += button9.Text;
            }
            else
            {
                textBox1.Text = button9.Text;
                inputstatus = true;
            }
        }

        private void buttonMAIS_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                num1 = System.Double.Parse(textBox1.Text);
                result();
                cal = "+";
            }
        }

        private void buttonSUB_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                num1 = System.Double.Parse(textBox1.Text);
                result();
                cal = "-";
            }
        }

        private void buttonMULT_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                num1 = System.Double.Parse(textBox1.Text);
                result();
                cal = "*";
            }
        }

        private void buttonDIV_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                num1 = System.Double.Parse(textBox1.Text);
                result();
                cal = "/";
            }
        }

        private void buttonEQU_Click(object sender, EventArgs e)
        {
            result();
            cal = string.Empty;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            num1 = 0;
            num2 = 0;
            cal = string.Empty;

        }

        private void result()
        {
            num2 = System.Double.Parse(textBox1.Text);
            switch (cal)
            {
                case "+":
                    num1 = num1 + num2;
                    break;
                case "-":
                    num1 = num1 - num2;
                    break;
                case "*":
                    num1 = num1 * num2;
                    break;
                case "/":
                    num1 = num1 / num2;
                    break;
            }
            textBox1.Text = num1.ToString();
            inputstatus = false;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void pasteCtrlVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void cutCtrlXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

    }
}
