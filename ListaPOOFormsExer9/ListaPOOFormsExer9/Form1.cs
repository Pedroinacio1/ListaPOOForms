using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaPOOFormsExer9
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
            double bas, alt, resul;
            bas= double.Parse(Base1.Text);
            alt= double.Parse(Altura.Text);
            resul= alt * bas;
            if (resul > 100)
            {
                resultado.Text = "Terreno grande";
            }
            else if (resul < 100)
            {
                resultado.Text = "Terreno pequeno";
            }
                
        }
    }
}
