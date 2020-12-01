using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form2 : Form
    {
        double no1, no2;
        string op;
        public Form2()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + (sender as Button).Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            no2 = Convert.ToDouble(textBox1.Text);
            switch (op)
            {
                case "+":
                    no1 = no1 + no2;
                    break;

                case "-":
                    no1 = no1 - no2;
                    break;

                case "*":
                    no1 = no1 * no2;
                    break;

                case "/":
                    no1 = no1 / no2;
                    break;

                case "Power":
                    no1 = Math.Pow(no1, no2);
                    textBox1.Text = no1.ToString();
                    break;
                default:
                    break;
            }
            textBox1.Text = Convert.ToString(no1);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            no1 = Convert.ToDouble(textBox1.Text);
            no1 = 1 / no1;
            textBox1.Text = no1.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            no1 = Convert.ToDouble(textBox1.Text);
            for(int i= Convert.ToInt32(textBox1.Text);i>2;i--)
            {
                no1 = no1 * (i - 1);
            }
            textBox1.Text = no1.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            no1 = Convert.ToDouble(textBox1.Text);
            no1=Math.Sqrt(no1);
            textBox1.Text = no1.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            no1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            op = (sender as Button).Text;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            no1 = no2 = 0;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            no1 = Convert.ToDouble(textBox1.Text);
            no1 = Math.Sin(no1);
            textBox1.Text = no1.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            no1 = Convert.ToDouble(textBox1.Text);
            no1 = Math.Cos(no1);
            textBox1.Text = no1.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            no1 = Convert.ToDouble(textBox1.Text);
            no1 = Math.Tan(no1);
            textBox1.Text = no1.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            no1 = Convert.ToDouble(textBox1.Text);
            no1 = Math.Log(no1);
            textBox1.Text = no1.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            no1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            op = (sender as Button).Text;
        }
    }
}
