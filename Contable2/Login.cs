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
    public partial class Login : Form
    {
        ConexionDB conexion = new ConexionDB();

        public Login()
        {
            InitializeComponent();
        }

        public static string usuario; 

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string letra = string.Format("select * from  Usuarios where Account ='{0}' and Password = '{1}' ", AccountTextBox.Text, PasswordTextBox.Text);
                DataSet DS = conexion.conexion(letra);

                string account = DS.Tables[0].Rows[0]["Account"].ToString().Trim();
                string password = DS.Tables[0].Rows[0]["Password"].ToString().Trim();

                usuario = DS.Tables[0].Rows[0]["Id_Usuario"].ToString().Trim();

                if (account == AccountTextBox.Text.Trim() && password == PasswordTextBox.Text.Trim())
                {

                    if (Convert.ToBoolean(DS.Tables[0].Rows[0]["StatusAdmin"]) == true)
                    {
                        Admin admin = new Admin();
                        this.Hide();
                        admin.Show();
                    }
                    else
                    {
                        User user = new User();
                        this.Hide();
                        user.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error",ex.Message);
            }
        }
    }
}
