using System;
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
    public partial class MenuExercicios : Form
    {
        public MenuExercicios()
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
            
        }

        private void btnEx1_Click(object sender, EventArgs e)
        {
            loadForm(new Ex1());

        }

        private void btnEx2_Click(object sender, EventArgs e)
        {
            loadForm(new Ex2());
        }

        private void btnEx3_Click(object sender, EventArgs e)
        {
            loadForm(new Ex3());
        }

        private void btnEx4_Click(object sender, EventArgs e)
        {
            loadForm(new Ex4());
        }

    }
}
