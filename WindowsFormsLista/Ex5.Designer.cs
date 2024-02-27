namespace WindowsFormsLista
{
    partial class Ex5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ex5));
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBoxCompras = new System.Windows.Forms.ListBox();
            this.txbItem = new System.Windows.Forms.TextBox();
            this.btnMarcar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(223, 338);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "ADICIONAR";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(223, 367);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 2;
            this.btnRemover.Text = "REMOVER";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(91, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "LISTA DE COMPRAS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(35, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // listBoxCompras
            // 
            this.listBoxCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCompras.FormattingEnabled = true;
            this.listBoxCompras.ItemHeight = 16;
            this.listBoxCompras.Location = new System.Drawing.Point(35, 105);
            this.listBoxCompras.Name = "listBoxCompras";
            this.listBoxCompras.Size = new System.Drawing.Size(263, 212);
            this.listBoxCompras.TabIndex = 5;
            // 
            // txbItem
            // 
            this.txbItem.Location = new System.Drawing.Point(35, 340);
            this.txbItem.Name = "txbItem";
            this.txbItem.Size = new System.Drawing.Size(124, 20);
            this.txbItem.TabIndex = 6;
            // 
            // btnMarcar
            // 
            this.btnMarcar.Location = new System.Drawing.Point(35, 367);
            this.btnMarcar.Name = "btnMarcar";
            this.btnMarcar.Size = new System.Drawing.Size(75, 23);
            this.btnMarcar.TabIndex = 7;
            this.btnMarcar.Text = "MARCAR";
            this.btnMarcar.UseVisualStyleBackColor = true;
            this.btnMarcar.Click += new System.EventHandler(this.btnMarcar_Click);
            // 
            // Ex5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 450);
            this.Controls.Add(this.btnMarcar);
            this.Controls.Add(this.txbItem);
            this.Controls.Add(this.listBoxCompras);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ex5";
            this.Text = "Ex5";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBoxCompras;
        private System.Windows.Forms.TextBox txbItem;
        private System.Windows.Forms.Button btnMarcar;
    }
}