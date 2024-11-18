using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaPOOFormsExer7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1, n2;
            n1 = double.Parse(primeiro.Text);
            n2 = double.Parse(segundo.Text);
                if (n1 > n2)
                {
                    resultado.Text = "O maior valor é o " + n1.ToString();
                }
                else if (n1 < n2)
                {
                    resultado.Text = "O maior valor é o " + n2.ToString();
                }
                else if (n1 == n2)
                {
                resultado.Text = "Os valores são iguais, escreva novamente";
                }

            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
