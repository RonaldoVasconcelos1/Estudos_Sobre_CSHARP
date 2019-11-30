namespace Loja.WindowsForms
{
    partial class VeiculoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VeiculoForm));
            this.VeiculoerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.Gravarbutton = new System.Windows.Forms.Button();
            this.Limparbutton = new System.Windows.Forms.Button();
            this.CorcomboBox = new System.Windows.Forms.ComboBox();
            this.ModelocomboBox = new System.Windows.Forms.ComboBox();
            this.AnoTextBox = new System.Windows.Forms.MaskedTextBox();
            this.PlacaTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ObservacaotextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CombustivelcomboBox = new System.Windows.Forms.ComboBox();
            this.CambiocomboBox = new System.Windows.Forms.ComboBox();
            this.MarcacomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VeiculoerrorProvider)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // VeiculoerrorProvider
            // 
            this.VeiculoerrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.VeiculoerrorProvider.ContainerControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.Gravarbutton);
            this.bunifuGradientPanel1.Controls.Add(this.Limparbutton);
            this.bunifuGradientPanel1.Controls.Add(this.CorcomboBox);
            this.bunifuGradientPanel1.Controls.Add(this.ModelocomboBox);
            this.bunifuGradientPanel1.Controls.Add(this.AnoTextBox);
            this.bunifuGradientPanel1.Controls.Add(this.PlacaTextBox);
            this.bunifuGradientPanel1.Controls.Add(this.label8);
            this.bunifuGradientPanel1.Controls.Add(this.ObservacaotextBox);
            this.bunifuGradientPanel1.Controls.Add(this.label7);
            this.bunifuGradientPanel1.Controls.Add(this.label6);
            this.bunifuGradientPanel1.Controls.Add(this.label5);
            this.bunifuGradientPanel1.Controls.Add(this.CombustivelcomboBox);
            this.bunifuGradientPanel1.Controls.Add(this.CambiocomboBox);
            this.bunifuGradientPanel1.Controls.Add(this.MarcacomboBox);
            this.bunifuGradientPanel1.Controls.Add(this.label4);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Coral;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(-2, -3);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(720, 339);
            this.bunifuGradientPanel1.TabIndex = 1;
            // 
            // Gravarbutton
            // 
            this.Gravarbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Gravarbutton.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.Gravarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Gravarbutton.Location = new System.Drawing.Point(489, 19);
            this.Gravarbutton.Name = "Gravarbutton";
            this.Gravarbutton.Size = new System.Drawing.Size(217, 63);
            this.Gravarbutton.TabIndex = 18;
            this.Gravarbutton.Tag = "*";
            this.Gravarbutton.Text = "Gravar";
            this.Gravarbutton.UseVisualStyleBackColor = false;
            this.Gravarbutton.Click += new System.EventHandler(this.Gravarbutton_Click);
            // 
            // Limparbutton
            // 
            this.Limparbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Limparbutton.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.Limparbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Limparbutton.Location = new System.Drawing.Point(489, 103);
            this.Limparbutton.Name = "Limparbutton";
            this.Limparbutton.Size = new System.Drawing.Size(217, 63);
            this.Limparbutton.TabIndex = 17;
            this.Limparbutton.Text = "Limpar";
            this.Limparbutton.UseVisualStyleBackColor = false;
            this.Limparbutton.Click += new System.EventHandler(this.Limparbutton_Click);
            // 
            // CorcomboBox
            // 
            this.CorcomboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CorcomboBox.FormattingEnabled = true;
            this.CorcomboBox.Location = new System.Drawing.Point(85, 68);
            this.CorcomboBox.Name = "CorcomboBox";
            this.CorcomboBox.Size = new System.Drawing.Size(100, 21);
            this.CorcomboBox.TabIndex = 3;
            this.CorcomboBox.Tag = "*";
            // 
            // ModelocomboBox
            // 
            this.ModelocomboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ModelocomboBox.FormattingEnabled = true;
            this.ModelocomboBox.Location = new System.Drawing.Point(322, 57);
            this.ModelocomboBox.Name = "ModelocomboBox";
            this.ModelocomboBox.Size = new System.Drawing.Size(121, 21);
            this.ModelocomboBox.TabIndex = 9;
            this.ModelocomboBox.Tag = "*";
            // 
            // AnoTextBox
            // 
            this.AnoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AnoTextBox.Location = new System.Drawing.Point(85, 120);
            this.AnoTextBox.Mask = "0000";
            this.AnoTextBox.Name = "AnoTextBox";
            this.AnoTextBox.Size = new System.Drawing.Size(100, 20);
            this.AnoTextBox.TabIndex = 5;
            this.AnoTextBox.Tag = "*ANO";
            // 
            // PlacaTextBox
            // 
            this.PlacaTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PlacaTextBox.Location = new System.Drawing.Point(85, 19);
            this.PlacaTextBox.Mask = ">LLL<-0000";
            this.PlacaTextBox.Name = "PlacaTextBox";
            this.PlacaTextBox.Size = new System.Drawing.Size(100, 20);
            this.PlacaTextBox.TabIndex = 1;
            this.PlacaTextBox.Tag = "*PLACA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Observação";
            // 
            // ObservacaotextBox
            // 
            this.ObservacaotextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ObservacaotextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObservacaotextBox.Location = new System.Drawing.Point(15, 238);
            this.ObservacaotextBox.Multiline = true;
            this.ObservacaotextBox.Name = "ObservacaotextBox";
            this.ObservacaotextBox.Size = new System.Drawing.Size(692, 87);
            this.ObservacaotextBox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(223, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Combustivel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(239, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Câmbio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(244, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Marca";
            // 
            // CombustivelcomboBox
            // 
            this.CombustivelcomboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CombustivelcomboBox.FormattingEnabled = true;
            this.CombustivelcomboBox.Location = new System.Drawing.Point(322, 103);
            this.CombustivelcomboBox.Name = "CombustivelcomboBox";
            this.CombustivelcomboBox.Size = new System.Drawing.Size(121, 21);
            this.CombustivelcomboBox.TabIndex = 11;
            this.CombustivelcomboBox.Tag = "*";
            // 
            // CambiocomboBox
            // 
            this.CambiocomboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CambiocomboBox.FormattingEnabled = true;
            this.CambiocomboBox.Location = new System.Drawing.Point(322, 145);
            this.CambiocomboBox.Name = "CambiocomboBox";
            this.CambiocomboBox.Size = new System.Drawing.Size(121, 21);
            this.CambiocomboBox.TabIndex = 13;
            this.CambiocomboBox.Tag = "*";
            // 
            // MarcacomboBox
            // 
            this.MarcacomboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MarcacomboBox.FormattingEnabled = true;
            this.MarcacomboBox.Location = new System.Drawing.Point(322, 10);
            this.MarcacomboBox.Name = "MarcacomboBox";
            this.MarcacomboBox.Size = new System.Drawing.Size(121, 21);
            this.MarcacomboBox.TabIndex = 7;
            this.MarcacomboBox.Tag = "*";
            this.MarcacomboBox.SelectedIndexChanged += new System.EventHandler(this.marcaComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ano";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(239, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Modelo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa";
            // 
            // VeiculoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 333);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "VeiculoForm";
            this.Text = "Veiculos";
            ((System.ComponentModel.ISupportInitialize)(this.VeiculoerrorProvider)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider VeiculoerrorProvider;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Button Gravarbutton;
        private System.Windows.Forms.Button Limparbutton;
        private System.Windows.Forms.ComboBox CorcomboBox;
        private System.Windows.Forms.ComboBox ModelocomboBox;
        private System.Windows.Forms.MaskedTextBox AnoTextBox;
        private System.Windows.Forms.MaskedTextBox PlacaTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ObservacaotextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CombustivelcomboBox;
        private System.Windows.Forms.ComboBox CambiocomboBox;
        private System.Windows.Forms.ComboBox MarcacomboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

