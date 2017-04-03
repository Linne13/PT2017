using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Form1 : Form

    {
        Calculator calculator = new Calculator();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            display.Text += btn.Text;
        }

        private void oper_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text == "+")
            {
                calculator.firstNumber = double.Parse(display.Text);
                display.Text = "";
                calculator.symbol = '+';
            }

            if (btn.Text == "-")
            {
                calculator.firstNumber = double.Parse(display.Text);
                display.Text = "";
                calculator.symbol = '-';
            }

            if (btn.Text == "*")
            {
                calculator.firstNumber = double.Parse(display.Text);
                display.Text = "";
                calculator.symbol = '*';
            }

            if (btn.Text == "/")
            {
                calculator.firstNumber = double.Parse(display.Text);
                display.Text = "";
                calculator.symbol = '/';
            }

            if (btn.Text == "=")
            {
                calculator.secondNumber = double.Parse(display.Text);
                if (calculator.symbol == '+')
                {
                    display.Text = calculator.Plus().ToString();
                }

                if (calculator.symbol == '-')
                {
                    display.Text = calculator.Minus().ToString();
                }

                if (calculator.symbol == '*')
                {
                    display.Text = calculator.Mult().ToString();
                }

                if (calculator.symbol == '/')
                {
                    display.Text = calculator.Divide().ToString();
                }
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            display.Text = "0";
            
        }

        private void BackspaceButton_Click(object sender, EventArgs e)
        {
            try
            {
                display.Text = display.Text.Substring(0, display.Text.Length - 1);
            }
            catch (Exception) { }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!display.Text.Contains(','))
                display.Text += ",";
        }
    }
}
