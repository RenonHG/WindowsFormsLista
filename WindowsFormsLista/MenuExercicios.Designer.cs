﻿namespace WindowsFormsLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuExercicios));
            this.painelConteudo = new System.Windows.Forms.Panel();
            this.btnEx1 = new System.Windows.Forms.Button();
            this.btnEx4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnEx7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEx5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEx3 = new System.Windows.Forms.Button();
            this.btnEx2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // painelConteudo
            // 
            this.painelConteudo.Location = new System.Drawing.Point(184, 0);
            this.painelConteudo.Name = "painelConteudo";
            this.painelConteudo.Size = new System.Drawing.Size(616, 450);
            this.painelConteudo.TabIndex = 0;
            // 
            // btnEx1
            // 
            this.btnEx1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEx1.Location = new System.Drawing.Point(12, 91);
            this.btnEx1.Name = "btnEx1";
            this.btnEx1.Size = new System.Drawing.Size(163, 23);
            this.btnEx1.TabIndex = 0;
            this.btnEx1.Text = "1: Lista de Tarefas";
            this.btnEx1.UseVisualStyleBackColor = false;
            this.btnEx1.Click += new System.EventHandler(this.btnEx1_Click);
            // 
            // btnEx4
            // 
            this.btnEx4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEx4.Location = new System.Drawing.Point(12, 178);
            this.btnEx4.Name = "btnEx4";
            this.btnEx4.Size = new System.Drawing.Size(163, 23);
            this.btnEx4.TabIndex = 1;
            this.btnEx4.Text = "4: Gerador de Senha";
            this.btnEx4.UseVisualStyleBackColor = true;
            this.btnEx4.Click += new System.EventHandler(this.btnEx4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnEx7);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnEx5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnEx3);
            this.panel1.Controls.Add(this.btnEx2);
            this.panel1.Controls.Add(this.btnEx4);
            this.panel1.Controls.Add(this.btnEx1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 450);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "8: Conversor de Unidades";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnEx7
            // 
            this.btnEx7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEx7.Location = new System.Drawing.Point(12, 265);
            this.btnEx7.Name = "btnEx7";
            this.btnEx7.Size = new System.Drawing.Size(163, 23);
            this.btnEx7.TabIndex = 7;
            this.btnEx7.Text = "7: Contagem Regressiva";
            this.btnEx7.UseVisualStyleBackColor = true;
            this.btnEx7.Click += new System.EventHandler(this.btnEx7_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "6: Conversor de Temperatura";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEx5
            // 
            this.btnEx5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEx5.Location = new System.Drawing.Point(12, 207);
            this.btnEx5.Name = "btnEx5";
            this.btnEx5.Size = new System.Drawing.Size(163, 23);
            this.btnEx5.TabIndex = 5;
            this.btnEx5.Text = "5: Lista de Compras";
            this.btnEx5.UseVisualStyleBackColor = true;
            this.btnEx5.Click += new System.EventHandler(this.btnEx5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.MaximumSize = new System.Drawing.Size(200, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "LISTA DE EXERCÍCIOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEx3
            // 
            this.btnEx3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEx3.Location = new System.Drawing.Point(12, 149);
            this.btnEx3.Name = "btnEx3";
            this.btnEx3.Size = new System.Drawing.Size(163, 23);
            this.btnEx3.TabIndex = 3;
            this.btnEx3.Text = "3: Calculadora de Hipoteca";
            this.btnEx3.UseVisualStyleBackColor = true;
            this.btnEx3.Click += new System.EventHandler(this.btnEx3_Click);
            // 
            // btnEx2
            // 
            this.btnEx2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEx2.Location = new System.Drawing.Point(12, 120);
            this.btnEx2.Name = "btnEx2";
            this.btnEx2.Size = new System.Drawing.Size(163, 23);
            this.btnEx2.TabIndex = 2;
            this.btnEx2.Text = "2: Conversor de Moeda";
            this.btnEx2.UseVisualStyleBackColor = false;
            this.btnEx2.Click += new System.EventHandler(this.btnEx2_Click);
            // 
            // MenuExercicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.painelConteudo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuExercicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuExercicios";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel painelConteudo;
        private System.Windows.Forms.Button btnEx4;
        private System.Windows.Forms.Button btnEx1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEx2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEx3;
        private System.Windows.Forms.Button btnEx5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEx7;
        private System.Windows.Forms.Button button2;
    }
}

