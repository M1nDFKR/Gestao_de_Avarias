using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pap
{
    public partial class QueixaForm : Form
    {

        private string nif;
        private string nome;

        public QueixaForm(string nif = "", string nome = "")
        {
            InitializeComponent();
            this.nif = nif;
            this.nome = nome;

            textNIF.Text = this.nif;
            textNome.Text = this.nome;
        }

        private void QueixaForm_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConexaoBD.basededados;
                string query = "SELECT NIF, Nome FROM Utilizador ORDER BY DataInsercao DESC LIMIT 8";

                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand(query, conexao);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nif = reader["NIF"].ToString();
                            string nome = reader["Nome"].ToString();

                            cb_listaClientes.Items.Add($"{nif} - {nome}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar clientes: " + ex.Message);
            }
        }
    }
}
