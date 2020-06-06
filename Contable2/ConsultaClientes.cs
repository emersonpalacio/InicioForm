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
    public partial class ConsultaClientes : Form
    {
        ConexionDB con = new ConexionDB();
        public ConsultaClientes()
        {
            InitializeComponent();
        }
        public DataSet llenarDataGridView(string tabla)
        {
            DataSet DS;
            string cmd = string.Format("select * from " + tabla);
            DS = con.conexion(cmd);
            return DS;
        }
        private void ConusltaClientes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = llenarDataGridView("Clientes").Tables[0];
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NombreTextBox.Text.Trim()) == false)
            {
                try
                {

                    string buscar = string.Format("select * from Clientes where Nom_Cli like ('%" + NombreTextBox.Text.Trim() + "%') ");
                    DataSet ds = con.conexion(buscar);
                    dataGridView1.DataSource = ds.Tables[0];
                }
                catch (Exception ex)
                {

                    MessageBox.Show("error", ex.Message);
                }
            }
        }
    }
}
