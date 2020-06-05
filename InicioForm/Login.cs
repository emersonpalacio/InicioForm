using Contable;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace InicioForm
{
    public partial class LoginForm : Form
    {
        Conexion conexion = new Conexion();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            IdTextBox.Focus();
        }

        public static string codigo;

        private void LoginButton_Click(object sender, EventArgs e)
        {

            try
            {
                string strin = string.Format(" select * from Usuarios where Account ='{0}' and Password = '{1}' ", IdTextBox.Text.Trim(), PasswordTextBox.Text.Trim());
                DataSet DS = conexion.Con(strin);

                codigo = DS.Tables[0].Rows[0]["Id_Usuario"].ToString().Trim();

                string account = DS.Tables[0].Rows[0]["Account"].ToString().Trim();
                string contraseña = DS.Tables[0].Rows[0]["Password"].ToString().Trim();                

                if (account == IdTextBox.Text.Trim() && contraseña == PasswordTextBox.Text.Trim())
                {
                    if (Convert.ToBoolean(DS.Tables[0].Rows[0]["StatusAdmin"].ToString()) == true)
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
                MessageBox.Show(string.Empty);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
    }
}
