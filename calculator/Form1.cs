using System;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace calculatorMini
{
    public partial class Form1 : Form
    {
        public int commaFlag = 0;  
        public int negFlag = 0;    
        public double result = 0;  
        public string oper = "";   
        public bool flag = false;  

        public Form1()
        {
            InitializeComponent();
            txbDisplay.Text = "0";
            txbDisplay.Enabled = false;  // nem lehet kézzel szerkeszteni
            RoundButtonCorners(btn0, 55);//gomb neve és lekekített érték megadása
            RoundButtonCorners(btn1, 55);
            RoundButtonCorners(btn2, 55);
            RoundButtonCorners(btn3, 55);
            RoundButtonCorners(btn4, 55);
            RoundButtonCorners(btn5, 55);
            RoundButtonCorners(btn6, 55);
            RoundButtonCorners(btn7, 55);
            RoundButtonCorners(btn8, 55);
            RoundButtonCorners(btn9, 55);
            RoundButtonCorners(btnSign, 55);
            RoundButtonCorners(btnC, 55);
            RoundButtonCorners(btnCA, 55);
            RoundButtonCorners(btnDivide, 55);
            RoundButtonCorners(btnEqual, 55);
            RoundButtonCorners(btnMinus, 55);
            RoundButtonCorners(btnPlus, 55);
            RoundButtonCorners(btnComma, 55);
            RoundButtonCorners(btnGyok, 55);
            RoundButtonCorners(btnTimes, 55);

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


        // kilépés
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // negatív szám
        private void btnSign_Click(object sender, EventArgs e)
        {
            string a = txbDisplay.Text;
            double b = double.Parse(a);
            b *= -1;
            if (b < 0) negFlag = 1;
            else negFlag = 0;

            a = b.ToString();
            txbDisplay.Text = a;
        }

        // 8 karakter hossz
        private double resultFormat(double a)
        {
            return double.Parse((a.ToString() + "         ").Substring(0, 8 + negFlag + commaFlag));
        }

        // vessző
        private void btnComma_Click(object sender, EventArgs e)
        {
            if (!txbDisplay.Text.Contains(","))
            {
                txbDisplay.Text += ",";
                commaFlag = 1;
            }
        }

        // kijelző törlése (C)
        private void btnC_Click(object sender, EventArgs e)
        {
            txbDisplay.Text = "0";
            commaFlag = 0;
            negFlag = 0;
            flag = false;
        }

        // gyök
        private void btnGyok_Click(object sender, EventArgs e)
        {
            result = Math.Sqrt(double.Parse(txbDisplay.Text));
            double r = double.Parse((result.ToString() + "         ").Substring(0, 10));
            txbDisplay.Text = r.ToString();
            flag = false;
        }

        // számok kezelése
        private void numbers(string number)
        {
            if (flag)  
            {
                txbDisplay.Text = "0";
                flag = false;
            }

            // ha a szám 0 felülírjuk; egyébként hozzáadjuk
            if (txbDisplay.Text == "0") txbDisplay.Text = number;
            else if (txbDisplay.Text.Length < 8 + negFlag + commaFlag) txbDisplay.Text += number;
        }

        // összeadás kivonás szorzás osztás
        private void operat()
        {
            if (oper == "+")
            {
                result += double.Parse(txbDisplay.Text);
            }
            else if (oper == "-")
            {
                result -= double.Parse(txbDisplay.Text);
            }
            else if (oper == "*")
            {
                result *= double.Parse(txbDisplay.Text);
            }
            else if (oper == "/")
            {
                if (txbDisplay.Text == "0")
                {
                    txbDisplay.Text = "hiba";
                    result = 0;
                    flag = true;
                    commaFlag = 0;
                    negFlag = 0;
                    oper = "";
                    return;
                }
                result /= double.Parse(txbDisplay.Text);
            }

            // eredmeny 
            txbDisplay.Text = result.ToString();
            flag = true;  
        }

        // számok
        private void btn1_Click(object sender, EventArgs e)
        {
            numbers("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            numbers("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            numbers("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            numbers("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            numbers("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            numbers("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            numbers("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            numbers("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            numbers("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            numbers("0");
        }

        // összeadás 
        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (oper == "")
            {
                result = double.Parse(txbDisplay.Text);
            }
            else
            {
                operat();
            }

            oper = "+";
            flag = true; 
            txbDisplay.Text += "+";  // kijelzőre kiírás 
        }

        // osztas
        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (oper == "")
            {
                result = double.Parse(txbDisplay.Text);
            }
            else
            {
                operat();
            }

            oper = "/";
            flag = true;
            txbDisplay.Text += "/";  // kijelzőre kiírás  
        }

        // CA
        private void btnCA_Click(object sender, EventArgs e)
        {
            result = 0;
            flag = false;
            commaFlag = 0;
            negFlag = 0;
            oper = "";
            txbDisplay.Text = "0";
        }

        // szorzás
        private void btnTimes_Click(object sender, EventArgs e)
        {
            if (oper == "")
            {
                result = double.Parse(txbDisplay.Text);
            }
            else
            {
                operat();
            }

            oper = "*";
            flag = true;
            txbDisplay.Text += "*";  // kijelzőre kiírás  
        }

        // kivonás
        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (oper == "")
            {
                result = double.Parse(txbDisplay.Text);
            }
            else
            {
                operat();
            }

            oper = "-";
            flag = true;
            txbDisplay.Text += "-";  // kijelzőre kiírás 
        }

        // egyenlőség
        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (oper == "")
            {
                return;
            }
            else
            {
                operat();
                oper = "";
            }
        }
    }
}
