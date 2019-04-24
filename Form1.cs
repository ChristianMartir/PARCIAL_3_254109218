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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if((txtUsuario.Text == "Christian Martir") && (txtContraseña.Text == "2541092018"))
           {
               MDIParent1 Hijo = new MDIParent1();
               Hijo.Show();

           }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        }
    }
}
