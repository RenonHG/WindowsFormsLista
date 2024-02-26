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
    public partial class Ex3 : Form
    {
        public Ex3()
        {
            InitializeComponent();
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            try
            {
                float emprestimo = float.Parse(txbEmprestimo.Text);
                int anos = int.Parse(txbPrazo.Text);
                float taxa = float.Parse(txbTaxaJuros.Text);

                float valorTotal = 0;
                float valorParcela = 0;

                valorTotal = emprestimo + (emprestimo * (taxa / 100));

                valorParcela = (valorTotal / (anos * 12));

                lbValorTotal.Text = valorTotal.ToString();
                lbValorMensal.Text = valorParcela.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor, preencha todos os campos necessários.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
