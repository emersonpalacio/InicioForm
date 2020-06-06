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
    public partial class User : Form
    {
        ConexionDB con = new ConexionDB();

        public User()
        {
            InitializeComponent();
        }

        private void COntenedorPrincpalButton_Click(object sender, EventArgs e)
        {
            Contenedor contenedor = new Contenedor();
            this.Hide();
            contenedor.Show();
        }

        private void User_Load(object sender, EventArgs e)
        {
            string user = string.Format("select * from Usuarios where Id_Usuario = " + Login.usuario);
            DataSet DS = con.conexion(user);


            AdminLabel.Text = DS.Tables[0].Rows[0]["Nom_usu"].ToString().ToString();
            UserLabel.Text = DS.Tables[0].Rows[0]["Account"].ToString().Trim();
            CodigoLabel.Text = DS.Tables[0].Rows[0]["Id_Usuario"].ToString().Trim();

            string url = DS.Tables[0].Rows[0]["Foto"].ToString();
            pictureBox1.Image = Image.FromFile(url);


        }
    }
}
