using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contable2
{
    public partial class Contenedor : Form
    {
        private int childFormNumber = 0;

        public Contenedor()
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

        private void consultaClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaClientes consulta = new ConsultaClientes();
            consulta.MdiParent= this;
            consulta.Show();
            
        }

        private void consultaProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaProductos consulta = new ConsultaProductos();
            consulta.MdiParent = this;
            consulta.Show();
        }

        private void mantenimientoProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoProductos mantenimiento = new MantenimientoProductos();
            mantenimiento.MdiParent = this;
            mantenimiento.Show();
        }

        private void mantenimientoClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimentoClientes mantenimento = new MantenimentoClientes();
            mantenimento.MdiParent = this;
            mantenimento.Show();
        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura();
            factura.MdiParent = this;
            factura.Show();
        }
    }
}
