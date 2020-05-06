using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string expr;
        private Regex rgx;

        public Form1()
        {
            InitializeComponent();
        }        

        private void btnEqls_Click(object sender, EventArgs e)
        {
            expr = Expression.Text;
            
            rgx = new Regex("(\\d+(,?\\d+)?)\\*(\\d+(,?\\d+)?)");
            expr = multiply(expr);
            rgx = new Regex("(\\d+(,?\\d+)?)/(\\d+(,?\\d+)?)");
            expr = divide(expr);
            rgx = new Regex("(\\d+(,?\\d+)?)\\+(\\d+(,?\\d+)?)");
            expr = add(expr);
            rgx = new Regex("(\\d+(,?\\d+)?)-(\\d+(,?\\d+)?)");
            expr = sub(expr);
            Expression.Text = expr;

            Clipboard.SetText(expr);
        }

        private string multiply(string s)
        {
            if(s.Contains("*"))
            {
                return multiply(rgx.Replace(s, (float.Parse(rgx.Match(s).Groups[1].Value) * 
                                                 float.Parse(rgx.Match(s).Groups[3].Value)).ToString(),1));

            }

            return s;
        }

        private string divide(string s)
        {
            if (s.Contains("/"))
            {
                return divide(rgx.Replace(s, (float.Parse(rgx.Match(s).Groups[1].Value) /
                                                 float.Parse(rgx.Match(s).Groups[3].Value)).ToString(), 1));

            }
            return s;
        }

        private string add(string s)
        {
            if (s.Contains("+"))
            {
                return add(rgx.Replace(s, (float.Parse(rgx.Match(s).Groups[1].Value) +
                                                 float.Parse(rgx.Match(s).Groups[3].Value)).ToString(), 1));

            }
            return s;
        }

        private string sub(string s)
        {
            if (s.Contains("-"))
            {
                return sub(rgx.Replace(s, (float.Parse(rgx.Match(s).Groups[1].Value) -
                                                 float.Parse(rgx.Match(s).Groups[3].Value)).ToString(), 1));

            }
            return s;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            Expression.Text = "0";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Expression.Text = (Expression.Text == "0") || (Expression.Text == "∞") || 
                                Expression.Text.Equals(Clipboard.GetText()) ? "7" : Expression.Text + 7; 
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Expression.Text = (Expression.Text == "0") || (Expression.Text == "∞") || 
                                Expression.Text.Equals(Clipboard.GetText()) ? "8" : Expression.Text + 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Expression.Text = (Expression.Text == "0") || (Expression.Text == "∞") || 
                                Expression.Text.Equals(Clipboard.GetText()) ? "9" : Expression.Text + 9;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Expression.Text = (Expression.Text == "0") || (Expression.Text == "∞") || 
                                Expression.Text.Equals(Clipboard.GetText()) ? "4" : Expression.Text + 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Expression.Text = (Expression.Text == "0") || (Expression.Text == "∞") || 
                                Expression.Text.Equals(Clipboard.GetText()) ? "5" : Expression.Text + 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Expression.Text = (Expression.Text == "0") || (Expression.Text == "∞") || 
                                Expression.Text.Equals(Clipboard.GetText()) ? "6" : Expression.Text + 6;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Expression.Text = (Expression.Text == "0") || (Expression.Text == "∞") || 
                                Expression.Text.Equals(Clipboard.GetText()) ? "1" : Expression.Text + 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Expression.Text = (Expression.Text == "0") || (Expression.Text == "∞") || 
                                Expression.Text.Equals(Clipboard.GetText()) ? "2" : Expression.Text + 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Expression.Text = (Expression.Text == "0") || (Expression.Text == "∞") || 
                                Expression.Text.Equals(Clipboard.GetText()) ? "3" : Expression.Text + 3;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (Expression.Text.Equals(Clipboard.GetText())) Expression.Text = "0";
            else if (Expression.Text != "0" && Expression.Text != "∞") Expression.Text += 0;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (Expression.Text != "0")
            {
                switch (Expression.Text[Expression.Text.Length - 1])
                {
                    case '+': break;
                    case '-': break;
                    case '*': break;
                    case '/': break;
                    case ',': break;
                    case '∞': break;
                    default: Expression.Text += ","; break;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Expression.Text != "0")
            {
                switch (Expression.Text[Expression.Text.Length - 1])
                {
                    case '+': break;
                    case '-': break;
                    case '*': break;
                    case '/': break;
                    case ',': break;
                    case '∞': break;
                    default: Expression.Text += "+"; break;
                }
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (Expression.Text != "0")
            {
                switch (Expression.Text[Expression.Text.Length - 1])
                {
                    case '+': break;
                    case '-': break;
                    case '*': break;
                    case '/': break;
                    case ',': break;
                    case '∞': break;
                    default: Expression.Text += "-"; break;
                }
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (Expression.Text != "0")
            {
                switch (Expression.Text[Expression.Text.Length - 1])
                {
                    case '+': break;
                    case '-': break;
                    case '*': break;
                    case '/': break;
                    case ',': break;
                    case '∞': break;
                    default: Expression.Text += "*"; break;
                }
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (Expression.Text != "0")
            {
                switch (Expression.Text[Expression.Text.Length - 1])
                {
                    case '+': break;
                    case '-': break;
                    case '*': break;
                    case '/': break;
                    case ',': break;
                    case '∞': break;
                    default: Expression.Text += "/"; break;
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad0: btn0_Click(sender, e); break;
                case Keys.NumPad1: btn1_Click(sender, e); break;
                case Keys.NumPad2: btn2_Click(sender, e); break;
                case Keys.NumPad3: btn3_Click(sender, e); break;
                case Keys.NumPad4: btn4_Click(sender, e); break;
                case Keys.NumPad5: btn5_Click(sender, e); break;
                case Keys.NumPad6: btn6_Click(sender, e); break;
                case Keys.NumPad7: btn7_Click(sender, e); break;
                case Keys.NumPad8: btn8_Click(sender, e); break;
                case Keys.NumPad9: btn9_Click(sender, e); break;
                case Keys.Decimal: btnDot_Click(sender, e); break;

                case Keys.Add: btnAdd_Click(sender, e); break;
                case Keys.Subtract: btnSub_Click(sender, e); break;
                case Keys.Multiply: btnMult_Click(sender, e); break;
                case Keys.Divide: btnDiv_Click(sender, e); break;

                case Keys.Back: btnCE_Click(sender, e); break;
            }
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (msg.WParam.ToInt32() == 13)
            {
                btnEqls_Click(new Object(), new KeyEventArgs(keyData));
                return true;
            }
            else return false;
        }
    }
}
