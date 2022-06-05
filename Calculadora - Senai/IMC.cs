using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Calculadora___Senai
{
    public partial class FormIMC : Form
    {
        public FormIMC()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float altura, peso;
            float resultado;

            peso = float.Parse(txbPeso.Text, CultureInfo.InvariantCulture);
            altura = float.Parse(txbAltura.Text, CultureInfo.InvariantCulture);

            resultado = peso / (altura * altura);

            MessageBox.Show(Convert.ToString(resultado), "Resultado do IMC");
        }
    }
}