using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double A, B, Resultado = 0;
            A = double.Parse(txtCantida.Text);
            B = double.Parse(txtPocentaje.Text);
            Resultado = A * B / 100;
            txtResultado.Text = Resultado.ToString("c2");

            if(radioButton1.Checked == true)
            {
                txtTotal.Text = Resultado.ToString("c2");

            }
            

        }
    }
}
