namespace WindowsFormsLista
{
    partial class Ex3
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
            this.txbEmprestimo = new System.Windows.Forms.TextBox();
            this.txbTaxaJuros = new System.Windows.Forms.TextBox();
            this.txbPrazo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSimular = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbValorMensal = new System.Windows.Forms.Label();
            this.lbValorTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbEmprestimo
            // 
            this.txbEmprestimo.Location = new System.Drawing.Point(73, 88);
            this.txbEmprestimo.Name = "txbEmprestimo";
            this.txbEmprestimo.Size = new System.Drawing.Size(123, 20);
            this.txbEmprestimo.TabIndex = 0;
            // 
            // txbTaxaJuros
            // 
            this.txbTaxaJuros.Location = new System.Drawing.Point(73, 152);
            this.txbTaxaJuros.Name = "txbTaxaJuros";
            this.txbTaxaJuros.Size = new System.Drawing.Size(123, 20);
            this.txbTaxaJuros.TabIndex = 1;
            // 
            // txbPrazo
            // 
            this.txbPrazo.Location = new System.Drawing.Point(83, 215);
            this.txbPrazo.Name = "txbPrazo";
            this.txbPrazo.Size = new System.Drawing.Size(123, 20);
            this.txbPrazo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valor de Empréstimo (R$)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Taxa de Juros (%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prazo (em anos)";
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(86, 257);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(75, 23);
            this.btnSimular.TabIndex = 6;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Valor Mensal:";
            // 
            // lbValorMensal
            // 
            this.lbValorMensal.AutoSize = true;
            this.lbValorMensal.Location = new System.Drawing.Point(147, 305);
            this.lbValorMensal.Name = "lbValorMensal";
            this.lbValorMensal.Size = new System.Drawing.Size(19, 13);
            this.lbValorMensal.TabIndex = 9;
            this.lbValorMensal.Text = "----";
            // 
            // lbValorTotal
            // 
            this.lbValorTotal.AutoSize = true;
            this.lbValorTotal.Location = new System.Drawing.Point(147, 332);
            this.lbValorTotal.Name = "lbValorTotal";
            this.lbValorTotal.Size = new System.Drawing.Size(19, 13);
            this.lbValorTotal.TabIndex = 10;
            this.lbValorTotal.Text = "----";
            // 
            // Ex3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbValorTotal);
            this.Controls.Add(this.lbValorMensal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbPrazo);
            this.Controls.Add(this.txbTaxaJuros);
            this.Controls.Add(this.txbEmprestimo);
            this.Name = "Ex3";
            this.Text = "Ex3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbEmprestimo;
        private System.Windows.Forms.TextBox txbTaxaJuros;
        private System.Windows.Forms.TextBox txbPrazo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbValorMensal;
        private System.Windows.Forms.Label lbValorTotal;
    }
}