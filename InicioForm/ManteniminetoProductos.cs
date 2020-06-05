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
    public partial class ManteniminetoProductos : Form
    {
        Conexion conexion = new Conexion();

        public ManteniminetoProductos()
        {
            InitializeComponent();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            conexion.Con(string.Format( "{0}{1}{2} ",IdProTextBox.Text, NomProTextBox.Text, PrecioTextBox.Text));
        }
    }
}
