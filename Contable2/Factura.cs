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
    public partial class Factura : Form
    {
        ConexionDB con = new ConexionDB();
        public Factura()
        {
            InitializeComponent();
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            string user = string.Format("select * from Usuarios where Id_Usuario =" + Login.usuario);
            DataSet DS = con.conexion(user);
            LeAtiendeLabel.Text = DS.Tables[0].Rows[0]["Nom_usu"].ToString().Trim();


        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CodigoTextBox.Text.Trim()) == false)
            {
                try
                {
                    string cmd = string.Format("select Nom_Cli from clientes where Id_cli = '{0}' ", CodigoTextBox.Text.Trim());
                    DataSet DS = con.conexion(cmd);
                    ClienteTextBox.Text = DS.Tables[0].Rows[0]["Nom_Cli"].ToString().Trim();
                    CodigoTextBox.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No existe", ex.Message);
                }
            }
        }
    }
}
