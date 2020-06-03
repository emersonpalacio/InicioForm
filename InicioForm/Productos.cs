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
    public partial class Productos : Form
    {
        Conexion conexion = new Conexion();

        public Productos()
        {
            InitializeComponent();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            conexion.Con("  {0}{1}{2} ",IdProTextBox.Text, NomProTextBox.Text, PrecioTextBox.Text);
        }
    }
}
