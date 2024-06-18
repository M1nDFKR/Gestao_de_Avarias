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

namespace Pap
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();

            cb_listaClientes.DropDownStyle = ComboBoxStyle.DropDownList;

            cb_listaClientes.SelectedIndex = 0;

            cb_ListadeEquip_NS.DropDownStyle = ComboBoxStyle.DropDownList;

            cb_ListadeEquip_NS.SelectedIndex = 0;
        }

        private void home_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConexaoBD.basededados;
                string query = "SELECT NIF, Nome FROM Utilizador ORDER BY DataInsercao DESC LIMIT 5";

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

            try
            {
                string connectionString = ConexaoBD.basededados;
                string query = "SELECT `TipoEquip`, `N-S` FROM Queixa ORDER BY `DtQueixa` DESC LIMIT 5";

                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand(query, conexao);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string tipoEquip = reader["TipoEquip"].ToString();
                            string numeroSerie = reader["N-S"].ToString();

                            cb_ListadeEquip_NS.Items.Add($"{tipoEquip} - {numeroSerie}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar equipamentos: " + ex.Message);
            }

        }

        private void btnPageQueixa_Click(object sender, EventArgs e)
        {
            QueixaForm queixaForm = new QueixaForm();
            queixaForm.Show();
            this.Hide();
        }

        private void btnPageBusca_Click(object sender, EventArgs e)
        {
            BuscarForm buscarForm = new BuscarForm();
            buscarForm.Show();
            this.Hide();
        }

        private void btnPageInsercao_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
