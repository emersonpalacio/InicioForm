using System;
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
            try
            {
                SqlConnection con = new SqlConnection(" Data Source=.;Initial Catalog=Administracion;Integrated Security=True");
         
                con.Open();

                MessageBox.Show("Conection Satisfactria");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error",ex.Message);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
