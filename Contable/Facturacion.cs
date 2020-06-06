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
    
    public partial class Facturacion : Form
    {
        Connecion connecion = new Connecion();

        public Facturacion()
        {
            InitializeComponent();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            string cmd = string.Format("select * from Usuarios where Id_Usuario =" + LoginForm.codigo);
            DataSet ds = connecion.Data(cmd);
            LeAtiendeLabel.Text = ds.Tables[0].Rows[0]["Nom_usu"].ToString().Trim();

        }
    }
}
