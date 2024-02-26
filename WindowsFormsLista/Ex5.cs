using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsLista
{
    public partial class Ex5 : Form
    {
        class produto
        {
            public string nome;
            public int quantidade;
        }

        List<produto> lista_Produtos;
        

        //===============================
        public Ex5()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            
        }


        }

    }
}
