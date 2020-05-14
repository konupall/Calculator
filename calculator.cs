using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorVer0._1
{
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
            InitializeCalculator();
        }

        Double number1 = 0;
        Double number2 = 0;
        string op = null;
        private void InitializeCalculator()
        {
            this.BackColor = Color.DarkMagenta;

            string buttonName = null;
            Button button = null;
            for (int i = 0; i < 9; i++)
            {
                buttonName = "button" + i;
                button = (Button)this.Controls[buttonName];
                button.Text = i.ToString(); // + " (lol)";
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if(CalcDisplay.Text == "0")
            {
                CalcDisplay.Text = button.Text;
            }
            else
            {
                CalcDisplay.Text += button.Text;
            }
        }

        private void ButtonDecimal_Click(object sender, EventArgs e)
        {
            // CAN ALSO USE THIS
            // bool YesDot = CalcDisplay.Text.Contains(".");
            // if (!YesDot)
            //{
            //  CalcDisplay.Text += ".";
            //}

            if (CalcDisplay.Text.Contains(".")) // Wanted to use this
            {
                MessageBox.Show("Error: Decimal point already exists", "ERROR #1", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (CalcDisplay.Text == String.Empty)
                {
                    CalcDisplay.Text += "0.";
                }
                else
                {
                    CalcDisplay.Text += ".";
                }
            }
        }

        private void UpdateDisplay()
        {
            if (CalcDisplay.Text == "-")
            {
                CalcDisplay.Text = String.Empty;
            }
            else
            {

            }
        }
        private void buttonBacksp_Click(object sender, EventArgs e)
        {
            string s = CalcDisplay.Text;
            if (s.Length > 1)
            {
                s = s.Substring(0, s.Length - 1);
            }
            else
            {
                s = string.Empty;
                // s = "0";     <-- can also use this
            }
            CalcDisplay.Text = s;
            UpdateDisplay();
        }

        private void buttonSign_Click(object sender, EventArgs e) // Finished in v0.4 update
        {
            try // Try this
            {
                double number = Convert.ToDouble(CalcDisplay.Text);
                number *= -1;
                CalcDisplay.Text = Convert.ToString(number);
            }
            catch // If fail (crash), do nothing (changed to my code)
            {
                CalcDisplay.Text = "0";
                MessageBox.Show("Error: No numbers on display", "ERROR #2", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            double result = 0;
            number2 = Convert.ToDouble(CalcDisplay.Text);

            if (op == "+")
            {
                result = number1 + number2;
            }
            else if (op == "-")
            {
                result = number1 - number2;
            }
            else if (op == "/")
            {
                result = number1 / number2;
            }
            else if (op == "*")
            {
                result = number1 * number2;
            }

            number1 = 0;
            CalcDisplay.Text = result.ToString();

            if (CalcDisplay.Text == "NaN")
            {
                MessageBox.Show("Error: What did you expect?", "ERROR #3", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                CalcDisplay.Text = "";
            }
            else;
            {

            }
        }

        private void Operation_click(object sender, EventArgs e) // All buttons (add, sub, multip, div) do this
        {
            Button button = (Button)sender;
            number1 = Convert.ToDouble(CalcDisplay.Text);
            CalcDisplay.Text = string.Empty;
            op = button.Text;
        }

        private async void buttonOn_Click(object sender, EventArgs e) // Added this fun thing when you press the "ON" key
        {
            CalcDisplay.Text = "Booting Up.";
            await Task.Delay(1000);
            CalcDisplay.Text = "Please Wait.";
            await Task.Delay(1000);
            CalcDisplay.Text = "Loading...0%";
            await Task.Delay(1000);
            CalcDisplay.Text = "Loading...1%";
            await Task.Delay(1000);
            CalcDisplay.Text = "Loading...4%";
            await Task.Delay(200);
            CalcDisplay.Text = "Loading...5%";
            await Task.Delay(100);
            CalcDisplay.Text = "Loading...10%";
            await Task.Delay(980);
            CalcDisplay.Text = "Loading...22%";
            await Task.Delay(210);
            CalcDisplay.Text = "Loading...56%";
            await Task.Delay(670);
            CalcDisplay.Text = "Loading...87%";
            await Task.Delay(300);
            CalcDisplay.Text = "Loading...98%";
            await Task.Delay(750);
            CalcDisplay.Text = "Loading...99%";
            await Task.Delay(3000);
            CalcDisplay.Text = "Loading...100%";
            await Task.Delay(200);
            CalcDisplay.Text = "L";
            await Task.Delay(200);
            CalcDisplay.Text = "Lo";
            await Task.Delay(200);
            CalcDisplay.Text = "Loa";
            await Task.Delay(200);
            CalcDisplay.Text = "Load";
            await Task.Delay(200);
            CalcDisplay.Text = "Loade";
            await Task.Delay(200);
            CalcDisplay.Text = "Loaded";
            await Task.Delay(200);
            CalcDisplay.Text = "Loaded!";
            await Task.Delay(1000);
            CalcDisplay.Text = "0";
        }
    }
}
