using Mysqlx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsLista
{
    public partial class Ex5 : Form
    {
        List<string> compras = new List<string>();

        public Ex5()
        {
            InitializeComponent();
        }
        string nome = "";

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            nome = txbItem.Text;
            compras.Add(nome);
            txbItem.Clear();
            listBoxCompras.DataSource = null;
            listBoxCompras.DataSource = compras;
            txbItem.Focus();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            compras.RemoveAt(listBoxCompras.SelectedIndex);
            listBoxCompras.DataSource = null;
            listBoxCompras.DataSource = compras;
        }

        private void btnMarcar_Click(object sender, EventArgs e)
        {
            string text = listBoxCompras.SelectedItem.ToString();
            compras.RemoveAt(listBoxCompras.SelectedIndex);
            compras.Add(text += "   ✔");
            listBoxCompras.DataSource = null;
            listBoxCompras.DataSource = compras;
        }
    }
}
