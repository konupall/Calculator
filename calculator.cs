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
            }
            CalcDisplay.Text = s;
        }

        private void buttonSign_Click(object sender, EventArgs e) // Not finished yet
        {
            bool signchange = CalcDisplay.Text.Contains("-");
            if(!signchange)
            {
                CalcDisplay.Text += "-";
            }
            else
            {
                CalcDisplay.Text = string.Empty;
            }
        }
    }
}
