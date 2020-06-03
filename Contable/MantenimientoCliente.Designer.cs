namespace Contable
{
    partial class MantenimientoCliente
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
            this.SalirBbutton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.ConsultarButton = new System.Windows.Forms.Button();
            this.idCliTextBox = new System.Windows.Forms.TextBox();
            this.NomCliTextBox = new System.Windows.Forms.TextBox();
            this.ApeCliTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SalirBbutton
            // 
            this.SalirBbutton.Location = new System.Drawing.Point(290, 200);
            this.SalirBbutton.Name = "SalirBbutton";
            this.SalirBbutton.Size = new System.Drawing.Size(97, 23);
            this.SalirBbutton.TabIndex = 9;
            this.SalirBbutton.Text = "SalirButton";
            this.SalirBbutton.UseVisualStyleBackColor = true;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(290, 156);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(97, 23);
            this.NuevoButton.TabIndex = 8;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(290, 112);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(97, 23);
            this.EliminarButton.TabIndex = 7;
            this.EliminarButton.Text = "ELiminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(290, 69);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(97, 23);
            this.GuardarButton.TabIndex = 6;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // ConsultarButton
            // 
            this.ConsultarButton.Location = new System.Drawing.Point(290, 24);
            this.ConsultarButton.Name = "ConsultarButton";
            this.ConsultarButton.Size = new System.Drawing.Size(97, 23);
            this.ConsultarButton.TabIndex = 5;
            this.ConsultarButton.Text = "Colsultar";
            this.ConsultarButton.UseVisualStyleBackColor = true;
            this.ConsultarButton.Click += new System.EventHandler(this.ConsultarButton_Click);
            // 
            // idCliTextBox
            // 
            this.idCliTextBox.Location = new System.Drawing.Point(84, 27);
            this.idCliTextBox.Name = "idCliTextBox";
            this.idCliTextBox.Size = new System.Drawing.Size(114, 20);
            this.idCliTextBox.TabIndex = 10;
            // 
            // NomCliTextBox
            // 
            this.NomCliTextBox.Location = new System.Drawing.Point(84, 73);
            this.NomCliTextBox.Name = "NomCliTextBox";
            this.NomCliTextBox.Size = new System.Drawing.Size(114, 20);
            this.NomCliTextBox.TabIndex = 11;
            // 
            // ApeCliTextBox
            // 
            this.ApeCliTextBox.Location = new System.Drawing.Point(84, 117);
            this.ApeCliTextBox.Name = "ApeCliTextBox";
            this.ApeCliTextBox.Size = new System.Drawing.Size(114, 20);
            this.ApeCliTextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Id_cli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nom_Cli";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ape_Cli";
            // 
            // MantenimientoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 235);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ApeCliTextBox);
            this.Controls.Add(this.NomCliTextBox);
            this.Controls.Add(this.idCliTextBox);
            this.Controls.Add(this.SalirBbutton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.ConsultarButton);
            this.Name = "MantenimientoCliente";
            this.Text = "MantenimientoCliente";
            this.Load += new System.EventHandler(this.MantenimientoCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SalirBbutton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button ConsultarButton;
        private System.Windows.Forms.TextBox idCliTextBox;
        private System.Windows.Forms.TextBox NomCliTextBox;
        private System.Windows.Forms.TextBox ApeCliTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}