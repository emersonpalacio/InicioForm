using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InicioForm
{
    public partial class LoginForm : Form
    {
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
            ConInicio conn = new ConInicio();
            try
            {
                string cmd = string.Format("select * from Usuarios where Account = '{0}' and  Password ='{1}' ", IdTextBox.Text.Trim(), PasswordTextBox.Text.Trim());
                DataSet Ds = conn.Conections(cmd);

                string cuenta = Ds.Tables[0].Rows[0]["Account"].ToString().Trim();
                string contra = Ds.Tables[0].Rows[0]["Password"].ToString().Trim();


                if (cuenta == IdTextBox.Text.Trim() && contra == PasswordTextBox.Text.Trim())
                {
                    MessageBox.Show("usairo correcto");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error"+ex.Message);
            }

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
