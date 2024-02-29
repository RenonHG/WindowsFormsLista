using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace WindowsFormsLista
{
    public partial class Ex7 : Form
    {
        public Ex7()
        {
            InitializeComponent();
        }
        int horas, minutos, segundos;

        private void Config()
        {
            string[] dados = masktxbTempo.Text.Split(':');

            horas = int.Parse(dados[0]);
            minutos = int.Parse(dados[1]);
            segundos = int.Parse(dados[2]);

            lbContagem.Text = horas + ":" + minutos + ":" + segundos;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Config();

            timer1.Enabled = true;
            timer1.Interval = 1000;
        }
        private void Contador()
        {

            segundos--;
            if (segundos < 0)
            {
                segundos = 59;
                minutos--;
            }
            if (minutos < 0)
            {
                minutos = 59;
                horas--;
            }
            if (segundos == 0 && minutos == 0 && horas == 0)
            {
                MessageBox.Show("Seu tempo acabou, ADEUS!");
                timer1.Enabled = false;
            }

            lbContagem.Text = horas + ":" + minutos + ":" + segundos;
        }

        private void btnResetar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            lbContagem.Text = "00:00:00";
        }
        int contadorParar = 0;

        private void btnParar_Click(object sender, EventArgs e)
        {

            if (contadorParar == 0)
            {
                timer1.Enabled = false;
                btnParar.Text = "RETOMAR";
            }
            else
            {
                timer1.Enabled = true;
                btnParar.Text = "PARAR";
            }
            contadorParar++;
            if (contadorParar == 2)
            {
                contadorParar = 0;
            }
            lbContagem.Text = horas + ":" + minutos + ":" + segundos;

        }

        private void Ex7_Load(object sender, EventArgs e)
        {

        }

        private void masktxbTempo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Contador();



        }
    }
}
