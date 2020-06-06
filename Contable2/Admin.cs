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
    public partial class Admin : Form
    {
        ConexionDB con = new ConexionDB();
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            string cmd = "select * from Usuarios where Id_Usuario =" + Login.usuario;
            DataSet ds = con.conexion(cmd);

            AdminLabel.Text = ds.Tables[0].Rows[0]["Nom_usu"].ToString().Trim();
            UserLabel.Text = ds.Tables[0].Rows[0]["Account"].ToString().Trim();
            CodigoLabel.Text = ds.Tables[0].Rows[0]["Id_Usuario"].ToString().Trim();

            string url = ds.Tables[0].Rows[0]["Foto"].ToString().Trim();
            pictureBox1.Image = Image.FromFile(url);
        }

        private void COntenedorPrincpalButton_Click(object sender, EventArgs e)
        {
            Contenedor contenedor = new Contenedor();
            this.Hide();
            contenedor.Show();
        }
    }
}
