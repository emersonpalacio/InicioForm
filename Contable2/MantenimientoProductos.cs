using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contable2
{
    public partial class MantenimientoProductos : Form
    {
        ConexionDB con = new ConexionDB();
        public MantenimientoProductos()
        {
            InitializeComponent();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            try
            {
                string data = string.Format("Exec  ActulizaArticulos '{0}', '{1}' , '{2}' ", idProTextBox.Text.Trim(), NomProTextBox.Text.Trim(), PrecioTextBox.Text.Trim());
                con.conexion(data);
                MessageBox.Show("se guardo con satisfacion");

            }

            catch (Exception ex)
            {

                MessageBox.Show("Sin guardar", ex.Message);
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            try
            {
                string data = string.Format("exec eliminarArticulos '{0}' ", idProTextBox.Text.Trim());
                con.conexion(data);
                MessageBox.Show("se elimino satisfacion");

            }
            catch (Exception ex)
            {

                MessageBox.Show("no se puedo eliminar", ex.Message);
            }
        }
    }
}
