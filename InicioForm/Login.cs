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
          
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
