namespace Contable2
{
    partial class Contenedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repostesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem1,
            this.repostesToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // mantenimientoToolStripMenuItem1
            // 
            this.mantenimientoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoProductosToolStripMenuItem,
            this.mantenimientoClientesToolStripMenuItem});
            this.mantenimientoToolStripMenuItem1.Name = "mantenimientoToolStripMenuItem1";
            this.mantenimientoToolStripMenuItem1.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem1.Text = "&Mantenimiento";
            // 
            // mantenimientoProductosToolStripMenuItem
            // 
            this.mantenimientoProductosToolStripMenuItem.Name = "mantenimientoProductosToolStripMenuItem";
            this.mantenimientoProductosToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.mantenimientoProductosToolStripMenuItem.Text = "Mantenimiento Productos";
            this.mantenimientoProductosToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoProductosToolStripMenuItem_Click);
            // 
            // mantenimientoClientesToolStripMenuItem
            // 
            this.mantenimientoClientesToolStripMenuItem.Name = "mantenimientoClientesToolStripMenuItem";
            this.mantenimientoClientesToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.mantenimientoClientesToolStripMenuItem.Text = "Mantenimiento Clientes";
            this.mantenimientoClientesToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoClientesToolStripMenuItem_Click);
            // 
            // repostesToolStripMenuItem
            // 
            this.repostesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaClientesToolStripMenuItem,
            this.consultaProductosToolStripMenuItem});
            this.repostesToolStripMenuItem.Name = "repostesToolStripMenuItem";
            this.repostesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.repostesToolStripMenuItem.Text = "Repostes";
            // 
            // consultaClientesToolStripMenuItem
            // 
            this.consultaClientesToolStripMenuItem.Name = "consultaClientesToolStripMenuItem";
            this.consultaClientesToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.consultaClientesToolStripMenuItem.Text = "Consulta Clientes";
            this.consultaClientesToolStripMenuItem.Click += new System.EventHandler(this.consultaClientesToolStripMenuItem_Click);
            // 
            // consultaProductosToolStripMenuItem
            // 
            this.consultaProductosToolStripMenuItem.Name = "consultaProductosToolStripMenuItem";
            this.consultaProductosToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.consultaProductosToolStripMenuItem.Text = "ConsultaProductos";
            this.consultaProductosToolStripMenuItem.Click += new System.EventHandler(this.consultaProductosToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturacionToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // facturacionToolStripMenuItem
            // 
            this.facturacionToolStripMenuItem.Name = "facturacionToolStripMenuItem";
            this.facturacionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.facturacionToolStripMenuItem.Text = "Facturacion";
            this.facturacionToolStripMenuItem.Click += new System.EventHandler(this.facturacionToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // Contenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Contenedor";
            this.Text = "Contenedor";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repostesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturacionToolStripMenuItem;
    }
}



