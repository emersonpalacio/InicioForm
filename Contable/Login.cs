using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Contable;
using InicioForm;


namespace InicioForm
{
    public partial class LoginForm : Form
    {

        Connecion connecion = new Connecion();
        public LoginForm()
        {
            InitializeComponent();
        }

        public static string codigo;

        private void LoginButton_Click(object sender, EventArgs e)
        {       

            try
            {
                string cmd = string.Format("select * from Usuarios where Account = '{0}' and  Password ='{1}' ", IdTextBox.Text.Trim(), PasswordTextBox.Text.Trim());
                DataSet Ds = connecion.Data(cmd);

                codigo = Ds.Tables[0].Rows[0]["Id_Usuario"].ToString().Trim();

                string cuenta = Ds.Tables[0].Rows[0]["Account"].ToString().Trim();
                string contra = Ds.Tables[0].Rows[0]["Password"].ToString().Trim();

                if (cuenta == IdTextBox.Text.Trim() && contra == PasswordTextBox.Text.Trim())
                {
                    if (Convert.ToBoolean( Ds.Tables[0].Rows[0]["StatusAdmin"]) == true)
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
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
