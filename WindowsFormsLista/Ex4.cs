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
    public partial class Ex4 : Form
    {
        public Ex4()
        {
            InitializeComponent();
        }

        string letras = "ABCDEFGHIJKLMNOPQRSTUVWXYZ" + "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower();
        string numeros = "0123456789";
        string especiais = "!@#$%&*-+_Ç!@#$%&*-+_Ç";
        string senha = "";
        


        private void btnGerarSenha_Click(object sender, EventArgs e)
        {
            if (cbxLetras.Checked == true || cbxNumeros.Checked == true || cbxEspeciais.Checked == true)
            {

                string caracteres = "";
                if (cbxLetras.Checked == true)
                {
                    caracteres += letras;

                }

                if (cbxNumeros.Checked == true)
                {
                    caracteres += numeros;
                }

                if (cbxEspeciais.Checked == true)
                {
                    caracteres += especiais;
                }


                int tamanho = caracteres.Length;

                Random gerada = new Random();

                for (int i = 0; i < nudTamanho.Value; i++)
                {

                    senha += caracteres[gerada.Next(tamanho)];

                }

                txbResultado.Text = senha;

            }
            else
            {
                MessageBox.Show("Selecione ao menos uma opção de caracteres!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            senha = "";


        }



    }
}
