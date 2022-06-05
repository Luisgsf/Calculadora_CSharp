using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora___Senai
{
    public partial class FormCalculadora : Form
    {
        float num1 = 0, num2 = 0;
        string op;
        public FormCalculadora()
        {
            InitializeComponent();
            lbNumDigi.Text = "";
            lbOp.Text = "";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txbVisor.Text += "1";
            lbNumDigi.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txbVisor.Text += "2";
            lbNumDigi.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txbVisor.Text += "3";
            lbNumDigi.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txbVisor.Text += "4";
            lbNumDigi.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txbVisor.Text += "5";
            lbNumDigi.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txbVisor.Text += "6";
            lbNumDigi.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txbVisor.Text += "7";
            lbNumDigi.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txbVisor.Text += "8";
            lbNumDigi.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txbVisor.Text += "9";
            lbNumDigi.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txbVisor.Text += "0";
            lbNumDigi.Text += "0";
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            txbVisor.Text += "00";
            lbNumDigi.Text += "00";
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (txbVisor.Text.Contains(",") == false)
            {
                txbVisor.Text += ",";
                lbNumDigi.Text += ",";
            }
        }

        private void btnDivi_Click(object sender, EventArgs e)
        {
            lbNumDigi.Text += " / ";
            num1 = float.Parse(txbVisor.Text, CultureInfo.InvariantCulture);
            txbVisor.Clear();
            op = "DIVISAO";
            lbOp.Text = "Divisão";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            lbNumDigi.Text += " * ";
            num1 = float.Parse(txbVisor.Text, CultureInfo.InvariantCulture);
            txbVisor.Clear();
            op = "MULTIPLICACAO";
            lbOp.Text = "Multiplicação";
        }

        private void btnSubt_Click(object sender, EventArgs e)
        {
            lbNumDigi.Text += " - ";
            num1 = float.Parse(txbVisor.Text, CultureInfo.InvariantCulture);
            txbVisor.Clear();
            op = "SUBTRACAO";
            lbOp.Text = "Subtração";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            lbNumDigi.Text += " + ";
            num1 = float.Parse(txbVisor.Text, CultureInfo.InvariantCulture);
            txbVisor.Clear();
            op = "SOMA";
            lbOp.Text = "Soma";
        }

        private void btnFat_Click(object sender, EventArgs e)
        {
            lbNumDigi.Text += "!";
            num1 = float.Parse(txbVisor.Text, CultureInfo.InvariantCulture);
            txbVisor.Clear();
            op = "FATORIAL";
            lbOp.Text = "Fatoração";
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            lbNumDigi.Text += " % ";
            num1 = float.Parse(txbVisor.Text, CultureInfo.InvariantCulture);
            txbVisor.Clear();
            op = "PORCENTAGEM";
            lbOp.Text = "Porcentagem";
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            lbNumDigi.Text = "√" + lbNumDigi.Text;
            txbVisor.Clear();
            op = "RAIZ";
            lbOp.Text = "Radiciação";
        }

        private void btnPot_Click(object sender, EventArgs e)
        {
            lbNumDigi.Text = lbNumDigi.Text + "^" + txbVisor.Text;
            num1 = float.Parse(txbVisor.Text, CultureInfo.InvariantCulture);
            txbVisor.Clear();
            op = "POTENCIA";
            lbOp.Text = "Potência";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txbVisor.Text = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            txbVisor.Text = "";
            lbNumDigi.Text = "";
            lbOp.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {

            lbOp.Text = "Resultado:";

            switch (op)
            {
                case "SOMA":
                    num2 = float.Parse(txbVisor.Text, CultureInfo.InvariantCulture);
                    txbVisor.Text = Convert.ToString(num1 + num2);
                    break;

                case "SUBTRACAO":
                    num2 = float.Parse(txbVisor.Text, CultureInfo.InvariantCulture);
                    txbVisor.Text = Convert.ToString(num1 - num2);
                    break;

                case "MULTIPLICACAO":
                    num2 = float.Parse(txbVisor.Text, CultureInfo.InvariantCulture);
                    txbVisor.Text = Convert.ToString(num1 * num2);
                    break;

                case "DIVISAO":
                    num2 = float.Parse(txbVisor.Text, CultureInfo.InvariantCulture);
                    txbVisor.Text = Convert.ToString(num1 / num2);
                    break;

                case "FATORIAL":
                    for (int i = Convert.ToInt32(num1 - 1); i >= 1; i--)
                    {
                        num1 *= i;
                    }
                    txbVisor.Text = Convert.ToString(num1);
                    break;

                case "PORCENTAGEM":
                    num2 = float.Parse(txbVisor.Text, CultureInfo.InvariantCulture);
                    txbVisor.Text = Convert.ToString(num1 * (num2 / 100));
                    break;

                case "RAIZ":
                    num1 = float.Parse(txbVisor.Text, CultureInfo.InvariantCulture);
                    txbVisor.Text = Convert.ToString(Math.Sqrt(num1));
                    break;

                case "POTENCIA":
                    num2 = float.Parse(txbVisor.Text, CultureInfo.InvariantCulture);
                    txbVisor.Text = Convert.ToString(Math.Pow(num1, num2));
                    break;

                default:
                    break;
            }
        }
    }
}