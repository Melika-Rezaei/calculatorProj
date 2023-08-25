using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorProj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int num1, num2;
        int Result;
        string str;

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text += b.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(textBox1.Text);
            textBox1.Text = "";
            str = "+";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(textBox1.Text);
            textBox1.Text = "";
            str = "-";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(textBox1.Text);
            textBox1.Text = "";
            str = "*";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(textBox1.Text);
            textBox1.Text = "";
            str = "/";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(textBox1.Text);

            switch (str)
            {
                case "+": 
                    Result = num1 + num2; 
                break;

                case "-":
                    Result = num1 - num2;
                break;

                case "*":
                    Result = num1 * num2;
                break;

                case "/":
                    Result = num1 / num2;
                    break;
            }
            textBox1.Text = Result.ToString(); 
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
