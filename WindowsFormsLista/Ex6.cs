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
    public partial class Ex6 : Form
    {
        public Ex6()
        {
            InitializeComponent();
        }

        private void rbCelsius_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            if (rbCelsius.Checked)
            {
                float celsius, fahrenheit;
                celsius = float.Parse(txbTemperatura.Text);

                fahrenheit = ((celsius * 9 / 5) + 32);

                lbResultado.Text = fahrenheit.ToString() + " °F";
            }

            if (rbFahrenheit.Checked)
            {
                float fahrenheit; 
                float celsius;

                fahrenheit = float.Parse(txbTemperatura.Text);

                celsius = ((fahrenheit - 32) * 5/9);

                lbResultado.Text =celsius.ToString() + " °C";
            }
        }
    }
}
