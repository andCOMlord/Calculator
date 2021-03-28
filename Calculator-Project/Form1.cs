using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Project
{
    public partial class Form1 : Form
    {
        double num1 = 0;
        double num2 = 0;
        double result = 0;
        bool decimalPressed = false;
        bool typeagain = false;
        char funtion;
        
        public Form1()
        {
            InitializeComponent();
            
        }

        

        private void decimalButton_Click(object sender, EventArgs e)
        {
            if (decimalPressed == false)
            {
                display1.Text += ".";
                decimalPressed = true;
                
            }       
        }
        private void num0Button_Click(object sender, EventArgs e)
        {
            if (display1.Text == "0" || typeagain == true)
                display1.Clear();
            display1.Text += "0";
            num1 = Convert.ToDouble(display1.Text);
            typeagain = false;
        }
        private void num1Button_Click(object sender, EventArgs e)
        {
            if (display1.Text == "0" || typeagain==true)
                display1.Clear();
            display1.Text += "1";
            num1 = Convert.ToDouble(display1.Text);
            typeagain = false;
        }
        private void num2Button_Click(object sender, EventArgs e)
        {
            if (display1.Text == "0" || typeagain == true)
                display1.Clear();
            display1.Text += "2";
            num1 = Convert.ToDouble(display1.Text);
            typeagain = false;
        }
        private void num3Button_Click(object sender, EventArgs e)
        {
            if (display1.Text == "0" || typeagain == true)
                display1.Clear();
            display1.Text += "3";
            num1 = Convert.ToDouble(display1.Text);
            typeagain = false;
        }

        private void num4Button_Click(object sender, EventArgs e)
        {
            if (display1.Text == "0" || typeagain == true)
                display1.Clear();
            display1.Text += "4";
            num1 = Convert.ToDouble(display1.Text);
            typeagain = false;
        }

        private void num5Button_Click(object sender, EventArgs e)
        {
            if (display1.Text == "0" || typeagain == true)
                display1.Clear();
            display1.Text += "5";
            num1 = Convert.ToDouble(display1.Text);
            typeagain = false;
        }

        private void num6Button_Click(object sender, EventArgs e)
        {
            if (display1.Text == "0" || typeagain == true)
                display1.Clear();
            display1.Text += "6";
            num1 = Convert.ToDouble(display1.Text);
            typeagain = false;
        }

        private void num7Button_Click(object sender, EventArgs e)
        {
            if (display1.Text == "0" || typeagain == true)
                display1.Clear();
            display1.Text += "7";
            num1 = Convert.ToDouble(display1.Text);
            typeagain = false;
        }

        private void num8Button_Click(object sender, EventArgs e)
        {
            if (display1.Text == "0" || typeagain == true)
                display1.Clear();
            display1.Text += "8";
            num1 = Convert.ToDouble(display1.Text);
            typeagain = false;
        }

        private void num9Button_Click(object sender, EventArgs e)
        {
            if (display1.Text == "0" || typeagain == true)
                display1.Clear();
            display1.Text += "9";
            num1 = Convert.ToDouble(display1.Text);
            typeagain = false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            funtion = '+';
            typeagain = true;
            if(display3.Text == "")
            {
                num1 = Convert.ToDouble(display1.Text);
                display3.Text = display1.Text;
                result = num1 + num2;
                display1.Text = Convert.ToString(result);
            }
            else
            {
                num1 = Convert.ToDouble(display3.Text);
                display3.Text = Convert.ToString(result);
                num2 = Convert.ToDouble(display1.Text);
                result = num1 + num2;
                display3.Text = Convert.ToString(result);
                display1.Text = "0";
            }
            
        }

        private void abstractButton_Click(object sender, EventArgs e)
        {
            funtion = '-';
            typeagain = true;
            if (display3.Text == "")
            {
                num1 = Convert.ToDouble(display1.Text);
                display3.Text = display1.Text;
                result = num1 - num2;
                display1.Text = Convert.ToString(result);
            }
            else
            {
                num1 = Convert.ToDouble(display3.Text);
                display3.Text = Convert.ToString(result);
                num2 = Convert.ToDouble(display1.Text);
                result = num1 - num2;
                display3.Text = Convert.ToString(result);
                display1.Text = "0";
            }
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            funtion = '*';
            typeagain = true;
            if (display3.Text == "")
            {
                num1 = Convert.ToDouble(display1.Text);
                display3.Text = display1.Text;
                result = num1 + num2;
                display1.Text = Convert.ToString(result);
            }
            else
            {
                num1 = Convert.ToDouble(display3.Text);
                display3.Text = Convert.ToString(result);
                num2 = Convert.ToDouble(display1.Text);
                result = num1 * num2;
                display3.Text = Convert.ToString(result);
                display1.Text = "0";
            }
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            funtion = '/';
            typeagain = true;
            if (display3.Text == "")
            {
                num1 = Convert.ToDouble(display1.Text);
                display3.Text = display1.Text;
                result = num1 + num2;
                display1.Text = Convert.ToString(result);
            }
            else
            {
                num1 = Convert.ToDouble(display3.Text);
                display3.Text = Convert.ToString(result);
                num2 = Convert.ToDouble(display1.Text);
                result = num1 / num2;
                display3.Text = Convert.ToString(result);
                display1.Text = "0";
            }
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(display1.Text);
            if (funtion == '+')
                result = num1 + num2;
            else if (funtion == '-')
                result = num1 - num2;
            else if (funtion == '*')
                result = num1 * num2;
            else
                result = num1 / num2;
            display1.Text = Convert.ToString(result);
            display3.Text = "";
            typeagain = true;
            funtion = 's' ;
        }
    }
}
