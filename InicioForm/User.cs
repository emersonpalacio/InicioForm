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
    public partial class User : Form
    {
        Conexion conexion = new Conexion();

        public User()
        {
            InitializeComponent();
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void User_Load(object sender, EventArgs e)
        {
            string login = "select * from Usuarios where Id_Usuario =" + LoginForm.codigo;
            DataSet dt = conexion.Con(login);

            AdminLabel.Text = dt.Tables[0].Rows[0]["Nom_usu"].ToString().Trim();
            UserLabel.Text = dt.Tables[0].Rows[0]["Account"].ToString().Trim();
            CodigoLabel.Text = dt.Tables[0].Rows[0]["Id_Usuario"].ToString().Trim();
        }
    }
}
