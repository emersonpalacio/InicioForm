using InicioForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contable
{
    public partial class MantenimientoCliente : Form
    {
        Connecion connecion = new Connecion();
        public MantenimientoCliente()
        {
            InitializeComponent();
        }

        private void MantenimientoCliente_Load(object sender, EventArgs e)
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
                connecion.Data(data);
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
                connecion.Data(data);
                MessageBox.Show("se elimino satisfacion");

            }
            catch (Exception ex)
            {

                MessageBox.Show("no se puedo eliminar",ex.Message);
            }
        }

    }
}
