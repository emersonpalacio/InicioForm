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
    public partial class ConsultarProductos : Form
    {

        Connecion connecion = new Connecion();
        public ConsultarProductos()
        {
            InitializeComponent();
        }

        public DataSet llenarGrillas(string tabla)
        {
            DataSet DS;
            string str = string.Format("select * from " + tabla);
            DS = connecion.Data(str);
            return DS;
        }

        private void ConsultarClientes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = llenarGrillas("Articulo").Tables[0];
        }

        private void SeleccionarButton_Click(object sender, EventArgs e)
        {

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NombreTextBox.Text) == false)
            {
                try
                {
                    string data = string.Format("select * from Articulo where Nom_Pro like ('%" + NombreTextBox.Text + "%')");
                    DataSet DS = connecion.Data(data);
                    dataGridView1.DataSource = DS.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error", ex.Message);
                }

            }
        }
    }
}
