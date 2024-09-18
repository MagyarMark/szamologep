using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            RoundButtonCorners(btn0, 20);
            RoundButtonCorners(btn1, 20);
            RoundButtonCorners(btn2, 20);
            RoundButtonCorners(btn3, 20);
            RoundButtonCorners(btn4, 20);
            RoundButtonCorners(btn5, 20);
            RoundButtonCorners(btn6, 20);
            RoundButtonCorners(btn7, 20);
            RoundButtonCorners(btn8, 20);
            RoundButtonCorners(btn9, 20);

        }
        private void RoundButtonCorners(Button button, int radius)
        {
            
            Rectangle rect = new Rectangle(0, 0, button.Width, button.Height); //terület 

            
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();//sarok lekerekítés
            button.Region = new Region(path);//gomb sarokká tétele
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
