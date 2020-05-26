namespace InicioForm
{
    partial class VentaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentaForm));
            this.PaypalheckBox = new System.Windows.Forms.CheckBox();
            this.TarjetaCheckBox = new System.Windows.Forms.CheckBox();
            this.PhpRadioButton = new System.Windows.Forms.RadioButton();
            this.CcharpButton = new System.Windows.Forms.RadioButton();
            this.BuyButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PaypalheckBox
            // 
            this.PaypalheckBox.AutoSize = true;
            this.PaypalheckBox.Location = new System.Drawing.Point(399, 68);
            this.PaypalheckBox.Name = "PaypalheckBox";
            this.PaypalheckBox.Size = new System.Drawing.Size(58, 17);
            this.PaypalheckBox.TabIndex = 0;
            this.PaypalheckBox.Text = "Paypal";
            this.PaypalheckBox.UseVisualStyleBackColor = true;
            // 
            // TarjetaCheckBox
            // 
            this.TarjetaCheckBox.AutoSize = true;
            this.TarjetaCheckBox.Location = new System.Drawing.Point(399, 108);
            this.TarjetaCheckBox.Name = "TarjetaCheckBox";
            this.TarjetaCheckBox.Size = new System.Drawing.Size(59, 17);
            this.TarjetaCheckBox.TabIndex = 1;
            this.TarjetaCheckBox.Text = "Tarjeta";
            this.TarjetaCheckBox.UseVisualStyleBackColor = true;
            // 
            // PhpRadioButton
            // 
            this.PhpRadioButton.AutoSize = true;
            this.PhpRadioButton.Location = new System.Drawing.Point(124, 68);
            this.PhpRadioButton.Name = "PhpRadioButton";
            this.PhpRadioButton.Size = new System.Drawing.Size(47, 17);
            this.PhpRadioButton.TabIndex = 2;
            this.PhpRadioButton.TabStop = true;
            this.PhpRadioButton.Text = "PHP";
            this.PhpRadioButton.UseVisualStyleBackColor = true;
            // 
            // CcharpButton
            // 
            this.CcharpButton.AutoSize = true;
            this.CcharpButton.Location = new System.Drawing.Point(124, 108);
            this.CcharpButton.Name = "CcharpButton";
            this.CcharpButton.Size = new System.Drawing.Size(39, 17);
            this.CcharpButton.TabIndex = 3;
            this.CcharpButton.TabStop = true;
            this.CcharpButton.Text = "C#";
            this.CcharpButton.UseVisualStyleBackColor = true;
            // 
            // BuyButton
            // 
            this.BuyButton.Location = new System.Drawing.Point(124, 262);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(75, 23);
            this.BuyButton.TabIndex = 4;
            this.BuyButton.Text = "Buy";
            this.BuyButton.UseVisualStyleBackColor = true;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(356, 262);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(75, 23);
            this.ReturnButton.TabIndex = 5;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = true;
            // 
            // VentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InicioForm.Properties.Resources.bat_2_100;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.BuyButton);
            this.Controls.Add(this.CcharpButton);
            this.Controls.Add(this.PhpRadioButton);
            this.Controls.Add(this.TarjetaCheckBox);
            this.Controls.Add(this.PaypalheckBox);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "VentaForm";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox PaypalheckBox;
        private System.Windows.Forms.CheckBox TarjetaCheckBox;
        private System.Windows.Forms.RadioButton PhpRadioButton;
        private System.Windows.Forms.RadioButton CcharpButton;
        private System.Windows.Forms.Button BuyButton;
        private System.Windows.Forms.Button ReturnButton;
    }
}