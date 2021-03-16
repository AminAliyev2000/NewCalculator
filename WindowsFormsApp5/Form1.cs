using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {

        Double myResult = 0;
        String choosenOperation = "";
        //String choosenColor = "";
        bool operationEnded = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_clicks(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0")||(operationEnded))
            {
                textBox1.Clear();
            }
            operationEnded = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                textBox1.Text = textBox1.Text + button.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + button.Text;
            }
            
        }

        private void operations_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (myResult != 0)
            {
                button16.PerformClick();
                choosenOperation = button.Text;
                label1.Text = myResult + " " + choosenOperation;
                operationEnded = true;

            }
            else
            {
                choosenOperation = button.Text;
                myResult = Double.Parse(textBox1.Text);
                label1.Text = myResult + " " + choosenOperation;
                operationEnded = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            myResult = 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            switch (choosenOperation)
            {
                case "+":
                    textBox1.Text = (myResult + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (myResult - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (myResult * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    if (myResult == 0) {

                        label1.Text = "Can`t divide to 0!!!!";
                    }
                    else
                    textBox1.Text = (myResult / Double.Parse(textBox1.Text)).ToString();
                    break;
                case "%":
                    textBox1.Text = ((myResult * Double.Parse(textBox1.Text))/100).ToString();
                    break;
                default:
                    break;
            }
            myResult = Double.Parse(textBox1.Text);
            label1.Text = "";
        }

        //private void colorclick(object sender, EventArgs e)
        //{

        //}
    }
}
