namespace WindowsFormsLista
{
    partial class MenuExercicios
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.painelConteudo = new System.Windows.Forms.Panel();
            this.btnEx1 = new System.Windows.Forms.Button();
            this.btnEx4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // painelConteudo
            // 
            this.painelConteudo.Location = new System.Drawing.Point(129, 0);
            this.painelConteudo.Name = "painelConteudo";
            this.painelConteudo.Size = new System.Drawing.Size(671, 450);
            this.painelConteudo.TabIndex = 0;
            // 
            // btnEx1
            // 
            this.btnEx1.Location = new System.Drawing.Point(12, 60);
            this.btnEx1.Name = "btnEx1";
            this.btnEx1.Size = new System.Drawing.Size(75, 23);
            this.btnEx1.TabIndex = 0;
            this.btnEx1.Text = "Exercício 1";
            this.btnEx1.UseVisualStyleBackColor = true;
            this.btnEx1.Click += new System.EventHandler(this.btnEx1_Click);
            // 
            // btnEx4
            // 
            this.btnEx4.Location = new System.Drawing.Point(12, 145);
            this.btnEx4.Name = "btnEx4";
            this.btnEx4.Size = new System.Drawing.Size(75, 23);
            this.btnEx4.TabIndex = 1;
            this.btnEx4.Text = "Exercício 4";
            this.btnEx4.UseVisualStyleBackColor = true;
            this.btnEx4.Click += new System.EventHandler(this.btnEx4_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEx4);
            this.panel1.Controls.Add(this.btnEx1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 450);
            this.panel1.TabIndex = 1;
            // 
            // MenuExercicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.painelConteudo);
            this.Name = "MenuExercicios";
            this.Text = "MenuExercicios";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel painelConteudo;
        private System.Windows.Forms.Button btnEx4;
        private System.Windows.Forms.Button btnEx1;
        private System.Windows.Forms.Panel panel1;
    }
}

