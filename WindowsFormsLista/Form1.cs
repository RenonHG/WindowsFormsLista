﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void loadForm(object form)
        {

            if (this.painelConteudo.Controls.Count > 0)
                this.painelConteudo.Controls.RemoveAt(0);

            Form formSelecionado = form as Form;
            formSelecionado.TopLevel = false;
            formSelecionado.Dock = DockStyle.Fill;
            this.painelConteudo.Controls.Add(formSelecionado);
            this.painelConteudo.Tag = formSelecionado;
            formSelecionado.Show();



        }


        private void Form1_Load(object sender, EventArgs e)
        {
            loadForm(new Ex4());
        }
    }
}
