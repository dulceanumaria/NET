using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Double res = 0;
        String op = "";
        bool isOp = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Clickeq(object sender, EventArgs e)
        {
            switch (op)
            {
                case "+":
                    textBox1.Text = (res + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (res - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (res * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (res / Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
            res = Double.Parse(textBox1.Text);
            label1.Text = "";
        }


        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (isOp)
            {
                textBox1.Clear();
            }
            Button button = (Button)sender;
            isOp = false;
            if (button.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text = textBox1.Text + button.Text;
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + button.Text;
            }
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (res!=0)
            {
                BtnEqual.PerformClick();
                op = button.Text;
                label1.Text = res + " " + op;
                isOp = true;
            }
            else
            {
                op = button.Text;
                res = Double.Parse(textBox1.Text);
                label1.Text = res + " " + op;
                isOp = true;
            }    
        }
        private void C_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
