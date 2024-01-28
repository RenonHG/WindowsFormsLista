namespace WindowsFormsLista
{
    partial class Ex4
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
            this.cbxLetras = new System.Windows.Forms.CheckBox();
            this.cbxNumeros = new System.Windows.Forms.CheckBox();
            this.cbxEspeciais = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbResultado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudTamanho = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGerarSenha = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudTamanho)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxLetras
            // 
            this.cbxLetras.AutoSize = true;
            this.cbxLetras.Location = new System.Drawing.Point(29, 190);
            this.cbxLetras.Name = "cbxLetras";
            this.cbxLetras.Size = new System.Drawing.Size(55, 17);
            this.cbxLetras.TabIndex = 0;
            this.cbxLetras.Text = "Letras";
            this.cbxLetras.UseVisualStyleBackColor = true;
            // 
            // cbxNumeros
            // 
            this.cbxNumeros.AutoSize = true;
            this.cbxNumeros.Location = new System.Drawing.Point(29, 213);
            this.cbxNumeros.Name = "cbxNumeros";
            this.cbxNumeros.Size = new System.Drawing.Size(68, 17);
            this.cbxNumeros.TabIndex = 1;
            this.cbxNumeros.Text = "Números";
            this.cbxNumeros.UseVisualStyleBackColor = true;
            // 
            // cbxEspeciais
            // 
            this.cbxEspeciais.AutoSize = true;
            this.cbxEspeciais.Location = new System.Drawing.Point(29, 236);
            this.cbxEspeciais.Name = "cbxEspeciais";
            this.cbxEspeciais.Size = new System.Drawing.Size(125, 17);
            this.cbxEspeciais.TabIndex = 2;
            this.cbxEspeciais.Text = "Caracteres Especiais";
            this.cbxEspeciais.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Deseja Incluir quais elementos na sua senha?";
            // 
            // txbResultado
            // 
            this.txbResultado.Location = new System.Drawing.Point(29, 348);
            this.txbResultado.Multiline = true;
            this.txbResultado.Name = "txbResultado";
            this.txbResultado.Size = new System.Drawing.Size(198, 57);
            this.txbResultado.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "RESULTADO";
            // 
            // nudTamanho
            // 
            this.nudTamanho.Location = new System.Drawing.Point(29, 127);
            this.nudTamanho.Name = "nudTamanho";
            this.nudTamanho.Size = new System.Drawing.Size(120, 20);
            this.nudTamanho.TabIndex = 6;
            this.nudTamanho.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Defina o tamanho da sua senha (número de caracteres)";
            // 
            // btnGerarSenha
            // 
            this.btnGerarSenha.Location = new System.Drawing.Point(29, 285);
            this.btnGerarSenha.Name = "btnGerarSenha";
            this.btnGerarSenha.Size = new System.Drawing.Size(120, 23);
            this.btnGerarSenha.TabIndex = 8;
            this.btnGerarSenha.Text = "GERAR SENHA";
            this.btnGerarSenha.UseVisualStyleBackColor = true;
            this.btnGerarSenha.Click += new System.EventHandler(this.btnGerarSenha_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "GERADOR DE SENHAS";
            // 
            // Ex4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGerarSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudTamanho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxEspeciais);
            this.Controls.Add(this.cbxNumeros);
            this.Controls.Add(this.cbxLetras);
            this.Name = "Ex4";
            this.Text = "Ex4";
            ((System.ComponentModel.ISupportInitialize)(this.nudTamanho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxLetras;
        private System.Windows.Forms.CheckBox cbxNumeros;
        private System.Windows.Forms.CheckBox cbxEspeciais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudTamanho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGerarSenha;
        private System.Windows.Forms.Label label4;
    }
}