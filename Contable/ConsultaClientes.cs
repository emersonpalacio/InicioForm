﻿using InicioForm;
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
    public partial class ConsultaClientes : Form
    {
        Connecion connecion = new Connecion();
        public ConsultaClientes()
        {
            InitializeComponent();
        }

        public DataSet llenarDataGridView(string tabla)
        {
            DataSet DS;
            string cmd= string.Format("select * from "+tabla);
            DS = connecion.Data(cmd);
            return DS;
        }
        private void Consultas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = llenarDataGridView("Clientes").Tables[0];
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SeleccionarButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

       

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NombreTextBox.Text.Trim()) == false)
            {         
                try
                {
                    
                    string buscar = string.Format("select * from Clientes where Nom_Cli like ('%"+NombreTextBox.Text.Trim()+"%') ");
                    DataSet ds = connecion.Data(buscar);
                    dataGridView1.DataSource = ds.Tables[0];
                }
                catch (Exception ex)
                {

                    MessageBox.Show("error",ex.Message);
                }
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }
    }
}
