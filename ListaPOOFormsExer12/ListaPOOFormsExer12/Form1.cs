using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaPOOFormsExer12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            double vlr1, vlr2, vlr3;
            vlr1 = double.Parse(valor1.Text);
            vlr2 = double.Parse(valor2.Text);
            vlr3 = double.Parse(valor3.Text);

            if (vlr1 > vlr2 && vlr1 > vlr3 && vlr1 * vlr1 == vlr2 * vlr2 + vlr3 * vlr3)
            {
                resultado.Text = "É um triangulo retangulo";
            }
            else if (vlr2 > vlr1 && vlr2 > vlr3 && vlr2 * vlr2 == vlr1 * vlr1 + vlr3 * vlr3)
            {
                resultado.Text = "É um triangulo retangulo";
            }
            else if (vlr3 > vlr1 && vlr3 > vlr2 && vlr3 * vlr3 == vlr1 * vlr1 + vlr2 * vlr2)
            {
                resultado.Text = "É um triangulo retangulo";
            }
            else
            {
                resultado.Text = "Não é um triangulo retangulo";
            }
        }
    }
}
