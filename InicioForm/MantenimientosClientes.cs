﻿using System;
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
    

    public partial class MantenimientosClientes : Form
    {
        Conexion conexion = new Conexion();

        public MantenimientosClientes()
        {
            InitializeComponent();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            try
            {
                string data = string.Format("exec ActulizaClientes '{0}','{1}','{2}' ", idCliTextBox.Text.Trim(), NomCliTextBox.Text.Trim(), ApeCliTextBox.Text.Trim());
                conexion.Con(data);
                MessageBox.Show("se guardo con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Conexion sin exito", ex.Message);

            }

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            try
            {
                string data = string.Format("exec eliminarClientes '{0}' ", idCliTextBox.Text.Trim());
                conexion.Con(data);
                MessageBox.Show("se elimino con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se elimino", ex.Message);

            }

        }
    }
}
