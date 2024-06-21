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


            lstDados.View = View.Details;
            lstDados.LabelEdit = true;
            lstDados.AllowColumnReorder = true;
            lstDados.FullRowSelect = true;
            lstDados.GridLines = true;

            // Adiciona colunas ao ListView
            lstDados.Columns.Add("NSA", 50, HorizontalAlignment.Left);
            lstDados.Columns.Add("NIF_Utilizador", 100, HorizontalAlignment.Left);
            lstDados.Columns.Add("TipoEquip", 100, HorizontalAlignment.Left);
            lstDados.Columns.Add("N-S", 100, HorizontalAlignment.Left);
            lstDados.Columns.Add("DtQueixa", 100, HorizontalAlignment.Left);
            lstDados.Columns.Add("Descricao", 200, HorizontalAlignment.Left);
            lstDados.Columns.Add("Decisao", 200, HorizontalAlignment.Left);

            CarregarDadosQueixa();

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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                Busca_Home buscar = new Busca_Home();
                buscar.txt_buscar = txt_buscar.Text;

                buscar.lst_dados = lstDados;

                if (!buscar.BuscarNaBD())
                {
                    MessageBox.Show("Nenhum dado foi encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao executar a busca:" + ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txt_buscar.Clear();
            txt_buscar.Focus();
            CarregarDadosQueixa();
        }

        private void CarregarDadosQueixa()
        {
            try
            {
                using (MySqlConnection ConexaoBasedeDados = new MySqlConnection(ConexaoBD.basededados))
                {
                    ConexaoBasedeDados.Open();

                    string select = @"
            SELECT 
                NSA,
                NIF_Utilizador,
                TipoEquip,
                `N-S`,
                DtQueixa,
                Descricao,
                Decisao
            FROM
                Queixa;";

                    using (MySqlCommand comandoSql = new MySqlCommand(select, ConexaoBasedeDados))
                    {
                        using (MySqlDataReader reader = comandoSql.ExecuteReader())
                        {
                            lstDados.Items.Clear();

                            while (reader.Read())
                            {
                                string[] row =
                                {
                            reader.IsDBNull(reader.GetOrdinal("NSA")) ? "" : reader.GetInt32(reader.GetOrdinal("NSA")).ToString(),
                            reader.IsDBNull(reader.GetOrdinal("NIF_Utilizador")) ? "" : reader.GetString(reader.GetOrdinal("NIF_Utilizador")),
                            reader.IsDBNull(reader.GetOrdinal("TipoEquip")) ? "" : reader.GetString(reader.GetOrdinal("TipoEquip")),
                            reader.IsDBNull(reader.GetOrdinal("N-S")) ? "" : reader.GetString(reader.GetOrdinal("N-S")),
                            reader.IsDBNull(reader.GetOrdinal("DtQueixa")) ? "" : reader.GetDateTime(reader.GetOrdinal("DtQueixa")).ToString("yyyy-MM-dd"),
                            reader.IsDBNull(reader.GetOrdinal("Descricao")) ? "" : reader.GetString(reader.GetOrdinal("Descricao")),
                            reader.IsDBNull(reader.GetOrdinal("Decisao")) ? "" : reader.GetString(reader.GetOrdinal("Decisao"))
                        };

                                var listViewItem = new ListViewItem(row);
                                lstDados.Items.Add(listViewItem);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }

        private void btnPageEquipamentos_Click(object sender, EventArgs e)
        {
            EquipRecebido equipamentorecebido = new EquipRecebido();
            equipamentorecebido.Show();
            this.Hide();
        }
    }
}
