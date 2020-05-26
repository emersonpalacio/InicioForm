using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InicioForm
{
    public partial class VentaForm : Form
    {
        public VentaForm()
        {
            InitializeComponent();
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            string c = string.Empty ;
            string mensaje = string.Empty;

            if (PhpRadioButton.Checked == true)
            {           
                c = "PHP";
                mensaje = "programa php";
             }
            if (CcharpButton.Checked == true)
            {
                c = "C# ";
                mensaje = "programa Cschap";
            }

            if (PaypalheckBox.Checked==true)
            {
                MessageBox.Show("Compras con paypal" + $" c " + "tipo de programacion" + mensaje);
            }
            if (TarjetaCheckBox.Checked == true)
            {
                MessageBox.Show("Compras con tarjeta"+$"c"+"tipo de programacion"+mensaje);
            }





        }

    }
}
