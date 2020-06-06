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
    public partial class MantenimentoClientes : Form
    {
        ConexionDB con = new ConexionDB();
        public MantenimentoClientes()
        {
            InitializeComponent();
        }

        private void MantenimentoClientes_Load(object sender, EventArgs e)
        {

        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {

        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            try
            {
                string data = string.Format("Exec  ActulizaClientes '{0}', '{1}' , '{2}' ", idCliTextBox.Text.Trim(), NomCliTextBox.Text.Trim(), ApeCliTextBox.Text.Trim());
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
                string data = string.Format("exec eliminarClientes '{0}' ", idCliTextBox.Text.Trim());
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
