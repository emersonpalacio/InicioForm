namespace InicioForm
{
    partial class ImagenesForm
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
            this.ImagenComboBox = new System.Windows.Forms.ComboBox();
            this.PictureBoxListBox = new System.Windows.Forms.PictureBox();
            this.PictureBoxCombobox = new System.Windows.Forms.PictureBox();
            this.ImgenListBox = new System.Windows.Forms.ListBox();
            this.MostrarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxListBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCombobox)).BeginInit();
            this.SuspendLayout();
            // 
            // ImagenComboBox
            // 
            this.ImagenComboBox.FormattingEnabled = true;
            this.ImagenComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.ImagenComboBox.Location = new System.Drawing.Point(116, 74);
            this.ImagenComboBox.Name = "ImagenComboBox";
            this.ImagenComboBox.Size = new System.Drawing.Size(121, 21);
            this.ImagenComboBox.TabIndex = 0;
            // 
            // PictureBoxListBox
            // 
            this.PictureBoxListBox.Image = global::InicioForm.Properties.Resources._1;
            this.PictureBoxListBox.Location = new System.Drawing.Point(351, 236);
            this.PictureBoxListBox.Name = "PictureBoxListBox";
            this.PictureBoxListBox.Size = new System.Drawing.Size(213, 119);
            this.PictureBoxListBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxListBox.TabIndex = 1;
            this.PictureBoxListBox.TabStop = false;
            // 
            // PictureBoxCombobox
            // 
            this.PictureBoxCombobox.Image = global::InicioForm.Properties.Resources._1;
            this.PictureBoxCombobox.Location = new System.Drawing.Point(84, 236);
            this.PictureBoxCombobox.Name = "PictureBoxCombobox";
            this.PictureBoxCombobox.Size = new System.Drawing.Size(213, 119);
            this.PictureBoxCombobox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxCombobox.TabIndex = 2;
            this.PictureBoxCombobox.TabStop = false;
            // 
            // ImgenListBox
            // 
            this.ImgenListBox.FormattingEnabled = true;
            this.ImgenListBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.ImgenListBox.Location = new System.Drawing.Point(431, 49);
            this.ImgenListBox.Name = "ImgenListBox";
            this.ImgenListBox.Size = new System.Drawing.Size(120, 95);
            this.ImgenListBox.TabIndex = 3;
            // 
            // MostrarButton
            // 
            this.MostrarButton.Location = new System.Drawing.Point(286, 384);
            this.MostrarButton.Name = "MostrarButton";
            this.MostrarButton.Size = new System.Drawing.Size(75, 23);
            this.MostrarButton.TabIndex = 4;
            this.MostrarButton.Text = "Schow";
            this.MostrarButton.UseVisualStyleBackColor = true;
            this.MostrarButton.Click += new System.EventHandler(this.MostrarButton_Click);
            // 
            // ImagenesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 430);
            this.Controls.Add(this.MostrarButton);
            this.Controls.Add(this.ImgenListBox);
            this.Controls.Add(this.PictureBoxCombobox);
            this.Controls.Add(this.PictureBoxListBox);
            this.Controls.Add(this.ImagenComboBox);
            this.Name = "ImagenesForm";
            this.Text = "Imagenes";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxListBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCombobox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ImagenComboBox;
        private System.Windows.Forms.PictureBox PictureBoxListBox;
        private System.Windows.Forms.PictureBox PictureBoxCombobox;
        private System.Windows.Forms.ListBox ImgenListBox;
        private System.Windows.Forms.Button MostrarButton;
    }
}