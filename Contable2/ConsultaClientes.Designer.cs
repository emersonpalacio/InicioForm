﻿namespace Contable2
{
    partial class ConsultaClientes
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
            this.label2 = new System.Windows.Forms.Label();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SeleccionarButton = new System.Windows.Forms.Button();
            this.SalirButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ImprimirButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Consulta clientes";
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(299, 66);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(75, 23);
            this.BuscarButton.TabIndex = 15;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(155, 67);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.NombreTextBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre";
            // 
            // SeleccionarButton
            // 
            this.SeleccionarButton.Location = new System.Drawing.Point(117, 286);
            this.SeleccionarButton.Name = "SeleccionarButton";
            this.SeleccionarButton.Size = new System.Drawing.Size(75, 23);
            this.SeleccionarButton.TabIndex = 12;
            this.SeleccionarButton.Text = "Seleccionar";
            this.SeleccionarButton.UseVisualStyleBackColor = true;
            // 
            // SalirButton
            // 
            this.SalirButton.Location = new System.Drawing.Point(359, 286);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(75, 23);
            this.SalirButton.TabIndex = 11;
            this.SalirButton.Text = "Salir";
            this.SalirButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(470, 149);
            this.dataGridView1.TabIndex = 10;
            // 
            // ImprimirButton
            // 
            this.ImprimirButton.Location = new System.Drawing.Point(238, 286);
            this.ImprimirButton.Name = "ImprimirButton";
            this.ImprimirButton.Size = new System.Drawing.Size(75, 23);
            this.ImprimirButton.TabIndex = 9;
            this.ImprimirButton.Text = "Imprimir";
            this.ImprimirButton.UseVisualStyleBackColor = true;
            // 
            // ConusltaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 341);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SeleccionarButton);
            this.Controls.Add(this.SalirButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ImprimirButton);
            this.Name = "ConusltaClientes";
            this.Text = "ConusltaClientes";
            this.Load += new System.EventHandler(this.ConusltaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SeleccionarButton;
        private System.Windows.Forms.Button SalirButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ImprimirButton;
    }
}