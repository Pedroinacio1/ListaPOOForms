using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIstaPOOFormsExer10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double pes, altu, imc;
            pes = double.Parse(peso.Text);
            altu = double.Parse(altura.Text);
            imc = pes/Math.Pow(altu, 2);
            
            if (imc < 20)
            {
                resultado.Text = "Abaixo do peso";
            }
            else if (20 <= imc && imc < 25)
            {
                resultado.Text = "Peso ideal";
            }
            else if (imc >= 25)
            {
                resultado.Text = "Acima do peso";
            }

        }
    }
}
