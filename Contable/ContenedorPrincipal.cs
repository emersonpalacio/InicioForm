﻿using System;
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
    public partial class ContenedorPrincipal : Form
    {
        private int childFormNumber = 0;

        public ContenedorPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }


        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoCliente mantenimiento = new MantenimientoCliente();
            mantenimiento.MdiParent = this;
            mantenimiento.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.MdiParent = this;
            productos.Show();


        }

        private void colsultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaClientes consultas = new ConsultaClientes();
            consultas.MdiParent = this;
            consultas.Show();
        }

        private void procesosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Procesos procesos = new Procesos();
            procesos.MdiParent = this;
            procesos.Show();
        }

        private void mantenimientoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoProductos productos = new MantenimientoProductos();
            productos.MdiParent = this;
            productos.Show();
        }

        private void colsultasPordcutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarProductos productos = new ConsultarProductos();
            productos.MdiParent = this;
            productos.Show();
        }

<<<<<<< HEAD
    

        private void procesosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Procesos procesos = new Procesos();
            procesos.MdiParent = this;
            procesos.Show();
=======
        private void ContenedorPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturacion facturacion = new Facturacion();
            facturacion.MdiParent = this;
            facturacion.Show();
>>>>>>> 54a5178ea06ff622ba9f8051096de8387decd8b8
        }
    }
}
