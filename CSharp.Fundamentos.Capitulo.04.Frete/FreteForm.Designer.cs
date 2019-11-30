namespace CSharp.Fundamentos.Capitulo._04.Frete
{
    partial class FreteForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Calcularbutton = new System.Windows.Forms.Button();
            this.ClientetextBox = new System.Windows.Forms.TextBox();
            this.ValortextBox = new System.Windows.Forms.TextBox();
            this.UFcomboBox = new System.Windows.Forms.ComboBox();
            this.FretetextBox = new System.Windows.Forms.TextBox();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.LimparButtom = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "UF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "% Frete";
            // 
            // Calcularbutton
            // 
            this.Calcularbutton.BackColor = System.Drawing.Color.YellowGreen;
            this.Calcularbutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Calcularbutton.FlatAppearance.BorderSize = 0;
            this.Calcularbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Calcularbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Calcularbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Calcularbutton.Location = new System.Drawing.Point(12, 172);
            this.Calcularbutton.Name = "Calcularbutton";
            this.Calcularbutton.Size = new System.Drawing.Size(126, 35);
            this.Calcularbutton.TabIndex = 8;
            this.Calcularbutton.Text = "Calcular";
            this.Calcularbutton.UseVisualStyleBackColor = false;
            this.Calcularbutton.Click += new System.EventHandler(this.Calcularbutton_Click);
            // 
            // ClientetextBox
            // 
            this.ClientetextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClientetextBox.Location = new System.Drawing.Point(60, 17);
            this.ClientetextBox.Name = "ClientetextBox";
            this.ClientetextBox.Size = new System.Drawing.Size(216, 13);
            this.ClientetextBox.TabIndex = 1;
            // 
            // ValortextBox
            // 
            this.ValortextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ValortextBox.Location = new System.Drawing.Point(60, 50);
            this.ValortextBox.Name = "ValortextBox";
            this.ValortextBox.Size = new System.Drawing.Size(100, 13);
            this.ValortextBox.TabIndex = 3;
            // 
            // UFcomboBox
            // 
            this.UFcomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UFcomboBox.FormattingEnabled = true;
            this.UFcomboBox.Items.AddRange(new object[] {
            "SP",
            "RJ",
            "AM",
            "MG",
            "Outros"});
            this.UFcomboBox.Location = new System.Drawing.Point(60, 83);
            this.UFcomboBox.Name = "UFcomboBox";
            this.UFcomboBox.Size = new System.Drawing.Size(121, 21);
            this.UFcomboBox.TabIndex = 5;
            // 
            // FretetextBox
            // 
            this.FretetextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FretetextBox.Location = new System.Drawing.Point(60, 122);
            this.FretetextBox.Name = "FretetextBox";
            this.FretetextBox.ReadOnly = true;
            this.FretetextBox.Size = new System.Drawing.Size(100, 13);
            this.FretetextBox.TabIndex = 7;
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.TotaltextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TotaltextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotaltextBox.ForeColor = System.Drawing.Color.Black;
            this.TotaltextBox.Location = new System.Drawing.Point(71, 269);
            this.TotaltextBox.Multiline = true;
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.ReadOnly = true;
            this.TotaltextBox.Size = new System.Drawing.Size(178, 39);
            this.TotaltextBox.TabIndex = 10;
            this.TotaltextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LimparButtom
            // 
            this.LimparButtom.BackColor = System.Drawing.Color.SkyBlue;
            this.LimparButtom.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.LimparButtom.FlatAppearance.BorderSize = 0;
            this.LimparButtom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LimparButtom.Location = new System.Drawing.Point(150, 172);
            this.LimparButtom.Name = "LimparButtom";
            this.LimparButtom.Size = new System.Drawing.Size(126, 35);
            this.LimparButtom.TabIndex = 9;
            this.LimparButtom.Text = "Limpar";
            this.LimparButtom.UseVisualStyleBackColor = false;
            this.LimparButtom.Click += new System.EventHandler(this.LimparButtom_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(129, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "TOTAL";
            // 
            // Form1
            // 
            this.AcceptButton = this.Calcularbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.CancelButton = this.LimparButtom;
            this.ClientSize = new System.Drawing.Size(288, 338);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LimparButtom);
            this.Controls.Add(this.TotaltextBox);
            this.Controls.Add(this.FretetextBox);
            this.Controls.Add(this.UFcomboBox);
            this.Controls.Add(this.ValortextBox);
            this.Controls.Add(this.ClientetextBox);
            this.Controls.Add(this.Calcularbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Frete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Calcularbutton;
        private System.Windows.Forms.TextBox ClientetextBox;
        private System.Windows.Forms.TextBox ValortextBox;
        private System.Windows.Forms.ComboBox UFcomboBox;
        private System.Windows.Forms.TextBox FretetextBox;
        private System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.Button LimparButtom;
        private System.Windows.Forms.Label label5;
    }
}

