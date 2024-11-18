using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaPOOFormsExer11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double lado1, lado2, lado3;
            lado1 = double.Parse(lad1.Text);
            lado2 = double.Parse(lad2.Text);
            lado3 = double.Parse(lad3.Text);
            if (lado1 + lado2 > lado3)
            {

                if (lado1 + lado3 > lado2)
                {

                    if (lado2 + lado3 > lado1)
                    {

                        if (lado1 == lado2)
                        {

                            if (lado1 == lado3)
                            {

                                resultado.Text = "Equilátero";
                            }
                            else
                                resultado.Text = "Isósceles";
                        }
                        else
                            if (lado2 == lado3)
                        {

                            resultado.Text = "Isósceles";
                        }
                        else
                                  if (lado1 == lado3)
                        {

                            resultado.Text = "Isósceles";
                        }
                        else
                            resultado.Text = "Escaleno";
                    }
                    else
                        resultado.Text = "Não forma triângulo";
                }
                else
                    resultado.Text = "Não forma triângulo";
            }
            else
                resultado.Text = "Não forma triângulo";

            resultado.Visible = true;
        }
    }
}
