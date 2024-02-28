namespace WindowsFormsLista
{
    partial class Ex7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ex7));
            this.lbContagem = new System.Windows.Forms.Label();
            this.txbTempo = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnResetar = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbContagem
            // 
            this.lbContagem.AutoSize = true;
            this.lbContagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContagem.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbContagem.Location = new System.Drawing.Point(64, 163);
            this.lbContagem.Name = "lbContagem";
            this.lbContagem.Size = new System.Drawing.Size(229, 46);
            this.lbContagem.TabIndex = 0;
            this.lbContagem.Text = "00:00:00:00";
            // 
            // txbTempo
            // 
            this.txbTempo.Location = new System.Drawing.Point(71, 120);
            this.txbTempo.Name = "txbTempo";
            this.txbTempo.Size = new System.Drawing.Size(100, 20);
            this.txbTempo.TabIndex = 1;
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnIniciar.Location = new System.Drawing.Point(71, 221);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(81, 35);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "INICIAR";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnResetar
            // 
            this.btnResetar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnResetar.Location = new System.Drawing.Point(167, 221);
            this.btnResetar.Name = "btnResetar";
            this.btnResetar.Size = new System.Drawing.Size(81, 35);
            this.btnResetar.TabIndex = 3;
            this.btnResetar.Text = "RESETAR";
            this.btnResetar.UseVisualStyleBackColor = false;
            this.btnResetar.Click += new System.EventHandler(this.btnResetar_Click);
            // 
            // btnParar
            // 
            this.btnParar.BackColor = System.Drawing.Color.IndianRed;
            this.btnParar.Location = new System.Drawing.Point(265, 221);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(81, 35);
            this.btnParar.TabIndex = 4;
            this.btnParar.Text = "PARAR";
            this.btnParar.UseVisualStyleBackColor = false;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label1.Location = new System.Drawing.Point(127, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "CONTAGEM REGRESSIVA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(71, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Ex7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 375);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnResetar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.txbTempo);
            this.Controls.Add(this.lbContagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ex7";
            this.Text = "Ex7";
            this.Load += new System.EventHandler(this.Ex7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbContagem;
        private System.Windows.Forms.TextBox txbTempo;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnResetar;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}