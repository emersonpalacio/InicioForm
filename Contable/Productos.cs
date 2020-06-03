using InicioForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contable
{
    public partial class Productos : Form
    {
        Connecion connecion = new Connecion(); 

        public Productos()
        {
            InitializeComponent();
        }

        private void SalirBbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {

        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {

        }
    }
}
