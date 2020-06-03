namespace Contable
{
    partial class MantenimientoProductos
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.NomProTextBox = new System.Windows.Forms.TextBox();
            this.idProTextBox = new System.Windows.Forms.TextBox();
            this.SalirBbutton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.ConsultarButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nom_Pro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Id_Pro";
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Location = new System.Drawing.Point(95, 111);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(114, 20);
            this.PrecioTextBox.TabIndex = 23;
            // 
            // NomProTextBox
            // 
            this.NomProTextBox.Location = new System.Drawing.Point(95, 67);
            this.NomProTextBox.Name = "NomProTextBox";
            this.NomProTextBox.Size = new System.Drawing.Size(114, 20);
            this.NomProTextBox.TabIndex = 22;
            // 
            // idProTextBox
            // 
            this.idProTextBox.Location = new System.Drawing.Point(95, 21);
            this.idProTextBox.Name = "idProTextBox";
            this.idProTextBox.Size = new System.Drawing.Size(114, 20);
            this.idProTextBox.TabIndex = 21;
            // 
            // SalirBbutton
            // 
            this.SalirBbutton.Location = new System.Drawing.Point(301, 194);
            this.SalirBbutton.Name = "SalirBbutton";
            this.SalirBbutton.Size = new System.Drawing.Size(97, 23);
            this.SalirBbutton.TabIndex = 20;
            this.SalirBbutton.Text = "SalirButton";
            this.SalirBbutton.UseVisualStyleBackColor = true;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(301, 150);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(97, 23);
            this.NuevoButton.TabIndex = 19;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(301, 106);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(97, 23);
            this.EliminarButton.TabIndex = 18;
            this.EliminarButton.Text = "ELiminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(301, 62);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(97, 23);
            this.GuardarButton.TabIndex = 17;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // ConsultarButton
            // 
            this.ConsultarButton.Location = new System.Drawing.Point(301, 18);
            this.ConsultarButton.Name = "ConsultarButton";
            this.ConsultarButton.Size = new System.Drawing.Size(97, 23);
            this.ConsultarButton.TabIndex = 16;
            this.ConsultarButton.Text = "Colsultar";
            this.ConsultarButton.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MantenimientoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 268);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrecioTextBox);
            this.Controls.Add(this.NomProTextBox);
            this.Controls.Add(this.idProTextBox);
            this.Controls.Add(this.SalirBbutton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.ConsultarButton);
            this.Name = "MantenimientoProductos";
            this.Text = "MantenimientoProductos";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.TextBox NomProTextBox;
        private System.Windows.Forms.TextBox idProTextBox;
        private System.Windows.Forms.Button SalirBbutton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button ConsultarButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}