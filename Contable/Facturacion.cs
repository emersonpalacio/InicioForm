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
    
    public partial class Facturacion : Form
    {
        Connecion connecion = new Connecion();

        public Facturacion()
        {
            InitializeComponent();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            string cmd = string.Format("select * from Usuarios where Id_Usuario =" + LoginForm.codigo);
            DataSet ds = connecion.Data(cmd);
            LeAtiendeLabel.Text = ds.Tables[0].Rows[0]["Nom_usu"].ToString().Trim();
            
        }

 

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CodigoTextBox.Text.Trim()) == false)
            {
                try
                {
                    string cmd = string.Format("select Nom_Cli from clientes where Id_cli = '{0}' ", CodigoTextBox.Text.Trim());
                    DataSet DS = connecion.Data(cmd);
                    ClienteTextBox.Text = DS.Tables[0].Rows[0]["Nom_Cli"].ToString().Trim();
                    CodigoTextBox.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No existe",ex.Message);
                }
            }
        }
        public static int contadorFila = 0;


        private void ColocarButton_Click(object sender, EventArgs e)
        {

            bool existe = false;
            int NumFila = 0;

            if (contadorFila == 0)
            {
                dataGridView1.Rows.Add(CodigoTextBox2.Text,DescripcionTextBox.Text,PrecioTextBox.Text,CantidadTextBox.Text);
                double importe = Convert.ToDouble(dataGridView1.Rows[contadorFila].Cells[2].Value) * 
                                 Convert.ToDouble(dataGridView1.Rows[contadorFila].Cells[3].Value);
                dataGridView1.Rows[contadorFila].Cells[4].Value = importe;

                contadorFila++;
            }else
            {
                foreach (DataGridViewRow Fila in dataGridView1.Rows)
                {
                    if (Fila.Cells[0].Value.ToString()==CodigoTextBox2.Text)
                    {
                        existe = true;
                        NumFila = Fila.Index;
                    }
                }

                if (existe == true)
                {
                    dataGridView1.Rows[NumFila].Cells[3].Value = (Convert.ToDouble(CantidadTextBox.Text) + 
                                                                Convert.ToDouble(dataGridView1.Rows[NumFila].Cells[3].Value)).ToString() ;
                    double importe = Convert.ToDouble(dataGridView1.Rows[NumFila].Cells[2].Value) *
                                 Convert.ToDouble(dataGridView1.Rows[NumFila].Cells[3].Value);

                    dataGridView1.Rows[NumFila].Cells[4].Value=importe;

                }else
                {
                    dataGridView1.Rows.Add(CodigoTextBox2.Text, DescripcionTextBox.Text, PrecioTextBox.Text, CantidadTextBox.Text);
                    double importe = Convert.ToDouble(dataGridView1.Rows[contadorFila].Cells[2].Value) *
                                     Convert.ToDouble(dataGridView1.Rows[contadorFila].Cells[3].Value);
                    dataGridView1.Rows[contadorFila].Cells[4].Value = importe;

                    contadorFila++;
                }
            }
        }
    }
}
