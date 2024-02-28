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
        System.Timers.Timer cronometro;
        int h, m, s, ms;

        private string startTime;
        
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            cronometro.Start();
            //startTime = txbTempo.t;
            //timer1.Start();

        }

        private void btnResetar_Click(object sender, EventArgs e)
        {
            cronometro.Stop();
            s = 0;
            m = 0;
            h = 0;
            //timer1.Stop();
            lbContagem.Text = "00:00.00";

        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        //int contador = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            //TimeSpan span = DateTime.Now - startTime;
            //lbContagem.Text = span.ToString(@"mm\:ss\.ff");

        }


        private void Ex7_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1;
            cronometro = new System.Timers.Timer();
            cronometro.Interval = 1;
            cronometro.Elapsed += OnTimeEvent;
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {

                s -= 1;
                if (s == 0)
                {
                    s = 59;
                    m -= 1;
                }

                if (m == 0)
                {
                    m = 59;
                    h -= 1;
                }


                lbContagem.Text = string.Format("{0}:{1}:{2}", h.ToString().ToString().PadLeft(2, '0'), m.ToString().ToString().PadLeft(2, '0'), s.ToString().ToString().PadLeft(2, '0'));

            }));
        }
    }
}
