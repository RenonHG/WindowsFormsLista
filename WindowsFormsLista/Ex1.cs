using MySql.Data.MySqlClient;
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
    public partial class Ex1 : Form
    {
        public Ex1()
        {
            InitializeComponent();
        }

        private void Ex1_Load(object sender, EventArgs e)
        {
            listViewTarefas.View = View.Details;
            listViewTarefas.Columns.Add("Tarefas", 255);

            CarregarTarefas();
        }

        private void CarregarTarefas()
        {
            //listViewTarefas.Clear();
            //listViewTarefas.View = View.Details;
            //listViewTarefas.Columns.Add("tarefas", 255);

            string conexaoString = "server=62.72.62.1;user=u687609827_renon;database=u687609827_renon;port=3306;password=BMsAR6SDo3^z";

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                string consulta = "SELECT * FROM renon_tb_tarefas";

                using (MySqlCommand comando = new MySqlCommand(consulta, conexao))
                {
                    conexao.Open();

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string tarefa = reader.GetString(1);

                            ListViewItem lista = new ListViewItem(id.ToString() + " - " + tarefa);
                            listViewTarefas.Items.Add(lista);

                        }
                    }
                    conexao.Close();
                }
            }
        }

        private void CadastrarTarefas(string tarefa)
        {
            string conexaoString = "server=62.72.62.1;user=u687609827_renon;database=u687609827_renon;port=3306;password=BMsAR6SDo3^z";

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(conexaoString))
                {
                    string inserir = "INSERT INTO renon_tb_tarefas (Tarefas) VALUES (@nome)";

                    using (MySqlCommand comando = new MySqlCommand(inserir, conexao))
                    {
                        conexao.Open();

                        comando.Parameters.AddWithValue("@nome", tarefa);

                        int linhasAfetadas = comando.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Tarefa Cadastrada com sucesso meu cria!");
                        }

                        conexao.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar Tarefa" + ex.Message);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string novaTarefa = txbTarefa.Text;
            if (novaTarefa.Trim() != "")
            {
                CadastrarTarefas(novaTarefa);
            }

            txbTarefa.Text = "";
            listViewTarefas.Items.Clear();
            CarregarTarefas();

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            string conexaoString = "server=62.72.62.1;user=u687609827_renon;database=u687609827_renon;port=3306;password=BMsAR6SDo3^z";
            string id = txbID.Text;

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                string remover = "DELETE FROM renon_tb_tarefas WHERE id = @id";

                using (MySqlCommand comando = new MySqlCommand(remover, conexao))
                {
                    conexao.Open();


                    comando.Parameters.AddWithValue("@id", id);

                    int linhasAfetadas = comando.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show("Tarefa Removidda!");
                    }

                    conexao.Close();
                    txbID.Text = "";
                    listViewTarefas.Items.Clear();
                    CarregarTarefas();

                }
            }


        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string conexaoString = "server=62.72.62.1;user=u687609827_renon;database=u687609827_renon;port=3306;password=BMsAR6SDo3^z";
            string id = txbID.Text;
            string tarefaNova = txbTarefa.Text;

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                string remover = "UPDATE renon_tb_tarefas set Tarefas = @tarefa WHERE id = @id";

                using (MySqlCommand comando = new MySqlCommand(remover, conexao))
                {
                    conexao.Open();

                    comando.Parameters.AddWithValue("@tarefa", tarefaNova);
                    comando.Parameters.AddWithValue("@id", id);

                    int linhasAfetadas = comando.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show("Alteração Realizada!");
                    }

                    conexao.Close();
                    txbTarefa.Text = "";
                    txbID.Text = "";
                    listViewTarefas.Items.Clear();
                    CarregarTarefas();
                }
            }
        }

        private void txbID_Click(object sender, EventArgs e)
        {
            txbID.Text = ""; 
        }

        private void txbTarefa_Click(object sender, EventArgs e)
        {
            txbTarefa.Text = "";
        }
    }
}
