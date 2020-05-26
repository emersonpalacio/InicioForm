using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InicioForm
{
    public partial class ImagenesForm : Form
    {
        public ImagenesForm()
        {
            InitializeComponent();
        }

        private void MostrarButton_Click(object sender, EventArgs e)
        {
            PictureBoxListBox.ImageLocation = ("C:/Users/emers/Desktop/New folder/" + ImgenListBox.Text + ".png");
            PictureBoxCombobox.ImageLocation = ("C:/Users/emers/Desktop/New folder/" + ImagenComboBox.Text + ".png");           
        }
    }
}
