namespace Contable2
{
    partial class Factura
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
            this.LeAtiendeLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CantidadTextBox = new System.Windows.Forms.TextBox();
            this.ClienteTextBox = new System.Windows.Forms.TextBox();
            this.CodigoTextBox = new System.Windows.Forms.TextBox();
            this.CodigoTextBox2 = new System.Windows.Forms.TextBox();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SalirButton = new System.Windows.Forms.Button();
            this.FacturaButton = new System.Windows.Forms.Button();
            this.ProductosButton = new System.Windows.Forms.Button();
            this.ClientesButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.ColocarButton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LeAtiendeLabel
            // 
            this.LeAtiendeLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.LeAtiendeLabel.Location = new System.Drawing.Point(146, 25);
            this.LeAtiendeLabel.Name = "LeAtiendeLabel";
            this.LeAtiendeLabel.Size = new System.Drawing.Size(117, 23);
            this.LeAtiendeLabel.TabIndex = 49;
            // 
            // TotalLabel
            // 
            this.TotalLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TotalLabel.Location = new System.Drawing.Point(433, 381);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(100, 23);
            this.TotalLabel.TabIndex = 48;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(417, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 130);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // CantidadTextBox
            // 
            this.CantidadTextBox.Location = new System.Drawing.Point(328, 177);
            this.CantidadTextBox.Name = "CantidadTextBox";
            this.CantidadTextBox.Size = new System.Drawing.Size(75, 20);
            this.CantidadTextBox.TabIndex = 46;
            // 
            // ClienteTextBox
            // 
            this.ClienteTextBox.Location = new System.Drawing.Point(146, 100);
            this.ClienteTextBox.Name = "ClienteTextBox";
            this.ClienteTextBox.Size = new System.Drawing.Size(204, 20);
            this.ClienteTextBox.TabIndex = 45;
            // 
            // CodigoTextBox
            // 
            this.CodigoTextBox.Location = new System.Drawing.Point(146, 65);
            this.CodigoTextBox.Name = "CodigoTextBox";
            this.CodigoTextBox.Size = new System.Drawing.Size(117, 20);
            this.CodigoTextBox.TabIndex = 44;
            // 
            // CodigoTextBox2
            // 
            this.CodigoTextBox2.Location = new System.Drawing.Point(70, 177);
            this.CodigoTextBox2.Name = "CodigoTextBox2";
            this.CodigoTextBox2.Size = new System.Drawing.Size(56, 20);
            this.CodigoTextBox2.TabIndex = 43;
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(132, 177);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(92, 20);
            this.DescripcionTextBox.TabIndex = 42;
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Location = new System.Drawing.Point(230, 177);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(92, 20);
            this.PrecioTextBox.TabIndex = 41;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCodigo,
            this.ColDescripcion,
            this.ColPrecio,
            this.ColCantidad,
            this.ColImporte});
            this.dataGridView1.Location = new System.Drawing.Point(27, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(516, 174);
            this.dataGridView1.TabIndex = 40;
            // 
            // ColCodigo
            // 
            this.ColCodigo.HeaderText = "Codigo";
            this.ColCodigo.Name = "ColCodigo";
            this.ColCodigo.Width = 60;
            // 
            // ColDescripcion
            // 
            this.ColDescripcion.HeaderText = "Descripción";
            this.ColDescripcion.Name = "ColDescripcion";
            // 
            // ColPrecio
            // 
            this.ColPrecio.HeaderText = "Precio";
            this.ColPrecio.Name = "ColPrecio";
            // 
            // ColCantidad
            // 
            this.ColCantidad.HeaderText = "Cantidad";
            this.ColCantidad.Name = "ColCantidad";
            // 
            // ColImporte
            // 
            this.ColImporte.HeaderText = "Importe";
            this.ColImporte.Name = "ColImporte";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(372, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Total";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(43, 107);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(39, 13);
            this.Label3.TabIndex = 38;
            this.Label3.Text = "Cliente";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(43, 68);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(40, 13);
            this.Label2.TabIndex = 37;
            this.Label2.Text = "Codigo";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(43, 26);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(58, 13);
            this.Label1.TabIndex = 36;
            this.Label1.Text = "Le Atiende";
            // 
            // SalirButton
            // 
            this.SalirButton.Location = new System.Drawing.Point(549, 358);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(119, 23);
            this.SalirButton.TabIndex = 35;
            this.SalirButton.Text = "Salir";
            this.SalirButton.UseVisualStyleBackColor = true;
            // 
            // FacturaButton
            // 
            this.FacturaButton.Location = new System.Drawing.Point(549, 327);
            this.FacturaButton.Name = "FacturaButton";
            this.FacturaButton.Size = new System.Drawing.Size(119, 23);
            this.FacturaButton.TabIndex = 34;
            this.FacturaButton.Text = "Factura";
            this.FacturaButton.UseVisualStyleBackColor = true;
            // 
            // ProductosButton
            // 
            this.ProductosButton.Location = new System.Drawing.Point(549, 296);
            this.ProductosButton.Name = "ProductosButton";
            this.ProductosButton.Size = new System.Drawing.Size(119, 23);
            this.ProductosButton.TabIndex = 33;
            this.ProductosButton.Text = "Productos";
            this.ProductosButton.UseVisualStyleBackColor = true;
            // 
            // ClientesButton
            // 
            this.ClientesButton.Location = new System.Drawing.Point(549, 265);
            this.ClientesButton.Name = "ClientesButton";
            this.ClientesButton.Size = new System.Drawing.Size(119, 23);
            this.ClientesButton.TabIndex = 32;
            this.ClientesButton.Text = "Clientes";
            this.ClientesButton.UseVisualStyleBackColor = true;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(549, 234);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(119, 23);
            this.EliminarButton.TabIndex = 31;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            // 
            // ColocarButton
            // 
            this.ColocarButton.Location = new System.Drawing.Point(549, 203);
            this.ColocarButton.Name = "ColocarButton";
            this.ColocarButton.Size = new System.Drawing.Size(119, 23);
            this.ColocarButton.TabIndex = 30;
            this.ColocarButton.Text = "Colocar";
            this.ColocarButton.UseVisualStyleBackColor = true;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(278, 63);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(119, 23);
            this.Buscarbutton.TabIndex = 29;
            this.Buscarbutton.Text = "BuscarButton";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 417);
            this.Controls.Add(this.LeAtiendeLabel);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CantidadTextBox);
            this.Controls.Add(this.ClienteTextBox);
            this.Controls.Add(this.CodigoTextBox);
            this.Controls.Add(this.CodigoTextBox2);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.PrecioTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.SalirButton);
            this.Controls.Add(this.FacturaButton);
            this.Controls.Add(this.ProductosButton);
            this.Controls.Add(this.ClientesButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.ColocarButton);
            this.Controls.Add(this.Buscarbutton);
            this.Name = "Factura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LeAtiendeLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox CantidadTextBox;
        private System.Windows.Forms.TextBox ClienteTextBox;
        private System.Windows.Forms.TextBox CodigoTextBox;
        private System.Windows.Forms.TextBox CodigoTextBox2;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColImporte;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button SalirButton;
        private System.Windows.Forms.Button FacturaButton;
        private System.Windows.Forms.Button ProductosButton;
        private System.Windows.Forms.Button ClientesButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button ColocarButton;
        private System.Windows.Forms.Button Buscarbutton;
    }
}