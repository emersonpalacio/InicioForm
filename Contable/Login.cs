using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InicioForm;


namespace InicioForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Connecion connecion = new Connecion();
       


            try
            {
                string cmd = string.Format("select * from Usuarios where Account = '{0}' and  Password ='{1}' ", IdTextBox.Text.Trim(), PasswordTextBox.Text.Trim());
                DataSet Ds = connecion.Data(cmd);

                string cuenta = Ds.Tables[0].Rows[0]["Account"].ToString().Trim();
                string contra = Ds.Tables[0].Rows[0]["Password"].ToString().Trim();


                if (cuenta == IdTextBox.Text.Trim() && contra == PasswordTextBox.Text.Trim())
                {
                    MessageBox.Show("usuario correcto");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex.Message);
            }
        }
    }
}
