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

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string strin = string.Format(" select * from  Usuarios  where Account= '{0}' and Password ='{1}' ", IdTextBox.Text.Trim(), PasswordTextBox.Text.Trim());
                DataSet DS = conexion.Con(strin);

                string account = DS.Tables[0].Rows[0]["Account"].ToString().Trim();
                string contraseña = DS.Tables[0].Rows[0]["Password"].ToString().Trim();

                if (account == IdTextBox.Text.Trim() && contraseña == PasswordTextBox.Text.Trim())
                {
                    MessageBox.Show("Is fine");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Usuario o contraseña incorrect",ex.Message);
            }            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
