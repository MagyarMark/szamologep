using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorMini
{
    public partial class Form1 : Form
    {

        public bool commaFlag = false;

        public Form1()
        {
            InitializeComponent();
            labelDisplay.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (labelDisplay.Text == "0" && labelDisplay.Text.Length < 8)
            {
                labelDisplay.Text = "0";
            }
            else if (labelDisplay.Text.Length < 8)
            {
                labelDisplay.Text += "0";
            }
        }

        private void btnplusminus_Click(object sender, EventArgs e)
        {
            string a = labelDisplay.Text;
            double b = double.Parse(a);
            b *= -1;
            a = b.ToString();
            if (commaFlag) labelDisplay.Text = a + ",";
            else labelDisplay.Text = a;
            
            
        }

        private void btnvesszo_Click(object sender, EventArgs e)
        {
            if (!labelDisplay.Text.Contains(",") && labelDisplay.Text.Length < 8)
            {
                labelDisplay.Text += ",";
                commaFlag = true;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            labelDisplay.Text = "0";
            commaFlag = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (labelDisplay.Text == "0" && labelDisplay.Text.Length < 8)
            {
                labelDisplay.Text = "1";
            }
            else if (labelDisplay.Text.Length < 8)
            {
                labelDisplay.Text += "1";
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (labelDisplay.Text == "0" && labelDisplay.Text.Length < 8)
            {
                labelDisplay.Text = "2";
            }
            else if (labelDisplay.Text.Length < 8)
            {
                labelDisplay.Text += "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (labelDisplay.Text == "0" && labelDisplay.Text.Length < 8)
            {
                labelDisplay.Text = "3";
            }
            else if (labelDisplay.Text.Length < 8)
            {
                labelDisplay.Text += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (labelDisplay.Text == "0" && labelDisplay.Text.Length < 8)
            {
                labelDisplay.Text = "4";
            }
            else if (labelDisplay.Text.Length < 8)
            {
                labelDisplay.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (labelDisplay.Text == "0" && labelDisplay.Text.Length < 8)
            {
                labelDisplay.Text = "5";
            }
            else if (labelDisplay.Text.Length < 8)
            {
                labelDisplay.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (labelDisplay.Text == "0" && labelDisplay.Text.Length < 8)
            {
                labelDisplay.Text = "6";
            }
            else if (labelDisplay.Text.Length < 8)
            {
                labelDisplay.Text += "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (labelDisplay.Text == "0" && labelDisplay.Text.Length < 8)
            {
                labelDisplay.Text = "7";
            }
            else if (labelDisplay.Text.Length < 8)
            {
                labelDisplay.Text += "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (labelDisplay.Text == "0" && labelDisplay.Text.Length < 8)
            {
                labelDisplay.Text = "8";
            }
            else if (labelDisplay.Text.Length < 8)
            {
                labelDisplay.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (labelDisplay.Text == "0" && labelDisplay.Text.Length < 8)
            {
                labelDisplay.Text = "9";
            }
            else if (labelDisplay.Text.Length < 8)
            {
                labelDisplay.Text += "9";
            }
        }
    }
}
