using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaPOOFormsExer4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int alt, bas, resul;
            alt = int.Parse(altura.Text);
            bas = int.Parse(base1.Text);
            resul = alt * bas;
            resultado.Text = resul.ToString();


        }
    }
}
