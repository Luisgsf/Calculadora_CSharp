using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora___Senai
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            FormCalculadora Calc = new FormCalculadora();

            Calc.Show();
        }

        private void btnCalcIMC_Click(object sender, EventArgs e)
        {
            FormIMC CalcIMC = new FormIMC();

            CalcIMC.Show();
        }

       
    }
}
