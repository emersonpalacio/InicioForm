﻿namespace InicioForm
{
    partial class Productos
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.NomProTextBox = new System.Windows.Forms.TextBox();
            this.IdProTextBox = new System.Windows.Forms.TextBox();
            this.SalirBbutton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.ConsultarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Nom_Pro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Id_Pro";
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Location = new System.Drawing.Point(111, 120);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(114, 20);
            this.PrecioTextBox.TabIndex = 34;
            // 
            // NomProTextBox
            // 
            this.NomProTextBox.Location = new System.Drawing.Point(111, 76);
            this.NomProTextBox.Name = "NomProTextBox";
            this.NomProTextBox.Size = new System.Drawing.Size(114, 20);
            this.NomProTextBox.TabIndex = 33;
            // 
            // IdProTextBox
            // 
            this.IdProTextBox.Location = new System.Drawing.Point(111, 30);
            this.IdProTextBox.Name = "IdProTextBox";
            this.IdProTextBox.Size = new System.Drawing.Size(114, 20);
            this.IdProTextBox.TabIndex = 32;
            // 
            // SalirBbutton
            // 
            this.SalirBbutton.Location = new System.Drawing.Point(317, 203);
            this.SalirBbutton.Name = "SalirBbutton";
            this.SalirBbutton.Size = new System.Drawing.Size(97, 23);
            this.SalirBbutton.TabIndex = 31;
            this.SalirBbutton.Text = "SalirButton";
            this.SalirBbutton.UseVisualStyleBackColor = true;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(317, 159);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(97, 23);
            this.NuevoButton.TabIndex = 30;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(317, 115);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(97, 23);
            this.EliminarButton.TabIndex = 29;
            this.EliminarButton.Text = "ELiminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(317, 71);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(97, 23);
            this.GuardarButton.TabIndex = 28;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // ConsultarButton
            // 
            this.ConsultarButton.Location = new System.Drawing.Point(317, 27);
            this.ConsultarButton.Name = "ConsultarButton";
            this.ConsultarButton.Size = new System.Drawing.Size(97, 23);
            this.ConsultarButton.TabIndex = 27;
            this.ConsultarButton.Text = "Colsultar";
            this.ConsultarButton.UseVisualStyleBackColor = true;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 265);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrecioTextBox);
            this.Controls.Add(this.NomProTextBox);
            this.Controls.Add(this.IdProTextBox);
            this.Controls.Add(this.SalirBbutton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.ConsultarButton);
            this.Name = "Productos";
            this.Text = "Productos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.TextBox NomProTextBox;
        private System.Windows.Forms.TextBox IdProTextBox;
        private System.Windows.Forms.Button SalirBbutton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button ConsultarButton;
    }
}