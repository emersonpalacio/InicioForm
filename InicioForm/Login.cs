using System;
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
          

            if (IdTextBox.Text == "emerson" && PasswordTextBox.Text =="123")
            {
                this.Hide();
                VentaForm form = new VentaForm();
                form.Show();
            }
            else
            {
                MessageBox.Show("estas fuera ");
            }

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
