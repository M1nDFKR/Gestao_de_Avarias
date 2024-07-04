using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pap
{
    public partial class EnvioForm : Form
    {
        public EnvioForm()
        {
            InitializeComponent();

            txt_Buscar.Focus();

            cb_Lista_Queixa.DropDownStyle = ComboBoxStyle.DropDownList;

            cb_Lista_Queixa.SelectedIndex = 0;

            cb_Lista_Queixa.SelectedIndexChanged += new EventHandler(cb_Lista_Queixa_SelectedIndexChanged);

            lstDados.View = View.Details;
            lstDados.LabelEdit = true;
            lstDados.AllowColumnReorder = true;
            lstDados.FullRowSelect = true;
            lstDados.GridLines = true;

            lstDados.Columns.Add("Referencia", 100, HorizontalAlignment.Left);
            lstDados.Columns.Add("NSA_Queixa", 100, HorizontalAlignment.Left);
            lstDados.Columns.Add("DtEnvio", 100, HorizontalAlignment.Left);
            lstDados.Columns.Add("NSA_Transp", 100, HorizontalAlignment.Left);

            CarregarDadosEnvio();
        }

        private void EnvioForm_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConexaoBD.basededados;
                string query = "SELECT NSA, NIF_Utilizador FROM Queixa ORDER BY DtQueixa DESC LIMIT 5";

                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand(query, conexao);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nsa = reader["NSA"].ToString();
                            string nif = reader["NIF_Utilizador"].ToString();

                            cb_Lista_Queixa.Items.Add($"{nsa} - {nif}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar queixas: " + ex.Message);
            }
        }

        private void cb_Lista_Queixa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Lista_Queixa.SelectedIndex == 0)
            {
                MessageBox.Show("Este item não pode ser selecionado.");
                cb_Lista_Queixa.SelectedIndex = -1;
                txt_NIF_Utilizador.Clear();
                txt_NSA_Queixa.Clear();
                return;
            }

            if (cb_Lista_Queixa.SelectedIndex != -1)
            {
                string selectedItem = cb_Lista_Queixa.SelectedItem.ToString();
                string[] parts = selectedItem.Split('-');

                if (parts.Length == 2)
                {
                    string nsa = parts[0].Trim();
                    string nif = parts[1].Trim();

                    if (QueixaJaTemEnvio(nsa))
                    {
                        MessageBox.Show("Esta queixa já possui um envio registrado.");
                        cb_Lista_Queixa.SelectedIndex = -1;
                        txt_NIF_Utilizador.Clear();
                        txt_NSA_Queixa.Clear();
                        return;
                    }

                    txt_NSA_Queixa.Text = nsa;
                    txt_NIF_Utilizador.Text = nif;
                }
            }
        }

        private bool QueixaJaTemEnvio(string nsa)
        {
            try
            {
                string connectionString = ConexaoBD.basededados;
                string query = "SELECT COUNT(*) FROM Envio WHERE NSA_Queixa = @NSA";

                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand(query, conexao);
                    comando.Parameters.AddWithValue("@NSA", nsa);

                    int count = Convert.ToInt32(comando.ExecuteScalar());

                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar a existência de envio: " + ex.Message);
                return true;
            }
        }


        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_NIF_Utilizador.Clear();
            txt_NSA_Queixa.Clear();
            cb_Lista_Queixa.Enabled = true;
            cb_Lista_Queixa.SelectedIndex = -1;
            txt_Referencia_Envio.Clear();
            txt_NSA_Transporte.Clear();
            txt_Referencia_Envio.Focus();
        }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txt_NSA_Queixa.Text) &&
                    !string.IsNullOrWhiteSpace(txt_NSA_Transporte.Text) &&
                    !string.IsNullOrWhiteSpace(txt_Referencia_Envio.Text))
                {
                    InserirEnvio inEnvio = new InserirEnvio();

                    inEnvio.DtEnvio = Data_de_Envio.Value;

                    int nsaQueixa;
                    int referencia;
                    int nsaTransp;

                    if (int.TryParse(txt_NSA_Queixa.Text, out nsaQueixa) &&
                        int.TryParse(txt_Referencia_Envio.Text, out referencia) &&
                        int.TryParse(txt_NSA_Transporte.Text, out nsaTransp))
                    {
                        inEnvio.NSAQueixa = nsaQueixa;
                        inEnvio.Referencia = referencia;
                        inEnvio.NSATransp = nsaTransp;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao converter valores. Certifique-se de que os campos contêm valores numéricos válidos.");
                    }

                    if (inEnvio.inserirEnvio())
                    {
                        MessageBox.Show($" O(A) Cliente com a Queixa nº: {inEnvio.NSAQueixa} tem o seu Envio registrado com sucesso.");
                        txt_NIF_Utilizador.Clear();
                        txt_NSA_Queixa.Clear();
                        cb_Lista_Queixa.Enabled = true;
                        cb_Lista_Queixa.SelectedIndex = -1;
                        txt_Referencia_Envio.Clear();
                        txt_NSA_Transporte.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel regista a queixa da avaria.");
                    }
                }
                else
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos antes de inserir.");
                    txt_NIF_Utilizador.Clear();
                    txt_NSA_Queixa.Clear();
                    cb_Lista_Queixa.Enabled = true;
                    cb_Lista_Queixa.SelectedIndex = -1;
                    txt_Referencia_Envio.Clear();
                    txt_NSA_Transporte.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir o dados do formulário Envio: " + ex.Message);
            }
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                BuscarEnvio buscar = new BuscarEnvio();
                buscar.txt_buscar = txt_Buscar.Text;

                buscar.lst_dados = lstDados;

                if (!buscar.Buscar_EnvioNaBD())
                {
                    MessageBox.Show("Nenhum dado foi encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao executar a busca:" + ex.Message);
            }
        }

        private void btn_Limpar_Pesquisa_Click(object sender, EventArgs e)
        {
            txt_Buscar.Clear();
            txt_Buscar.Focus();
            CarregarDadosEnvio();
        }

        private void CarregarDadosEnvio()
        {
            try
            {
                using (MySqlConnection ConexaoBasedeDados = new MySqlConnection(ConexaoBD.basededados))
                {
                    ConexaoBasedeDados.Open();

                    string select = @"
                SELECT 
                    Referencia,
                    NSA_Queixa,
                    DtEnvio,
                    NSA_Transp
                FROM
                    Envio;";

                    using (MySqlCommand comandoSql = new MySqlCommand(select, ConexaoBasedeDados))
                    {
                        using (MySqlDataReader reader = comandoSql.ExecuteReader())
                        {
                            lstDados.Items.Clear();

                            while (reader.Read())
                            {
                                string[] row =
                                {
                            reader.IsDBNull(reader.GetOrdinal("Referencia")) ? "" : reader.GetInt32(reader.GetOrdinal("Referencia")).ToString(),
                            reader.IsDBNull(reader.GetOrdinal("NSA_Queixa")) ? "" : reader.GetInt32(reader.GetOrdinal("NSA_Queixa")).ToString(),
                            reader.IsDBNull(reader.GetOrdinal("DtEnvio")) ? "" : reader.GetDateTime(reader.GetOrdinal("DtEnvio")).ToString("yyyy-MM-dd"),
                            reader.IsDBNull(reader.GetOrdinal("NSA_Transp")) ? "" : reader.GetInt32(reader.GetOrdinal("NSA_Transp")).ToString()
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

        private void btn_home_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_NSA_Queixa.Text) &&
                   string.IsNullOrWhiteSpace(txt_NSA_Transporte.Text) &&
                   string.IsNullOrWhiteSpace(txt_Referencia_Envio.Text))
            {
                home Home = new home();
                Home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Por favor, limpe todos os campos antes de mudar de página.");
            }
        }

        private void btnPageBusca_Click(object sender, EventArgs e)
        {
            BuscarForm buscarForm = new BuscarForm();
            buscarForm.Show();
            this.Hide();
        }

        private void btnPageQueixa_Click(object sender, EventArgs e)
        {
            QueixaForm queixaForm = new QueixaForm();
            queixaForm.Show();
            this.Hide();
        }

        private void btnPageEquipamentos_Click(object sender, EventArgs e)
        {
            EquipRecebido equipamentorecebido = new EquipRecebido();
            equipamentorecebido.Show();
            this.Hide();
        }

        private void btn_Contato_Click(object sender, EventArgs e)
        {
            ContatoForm contatoForm = new ContatoForm();
            contatoForm.Show();
            this.Hide();
        }

        private void btnPageInsercao_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btn_Orcamento_Click(object sender, EventArgs e)
        {
            OrcamentoForm orcamentoForm = new OrcamentoForm();
            orcamentoForm.Show();
            this.Hide();
        }

        private void btn_Devolucao_Click(object sender, EventArgs e)
        {
            DevolucaoForm devolucaoForm = new DevolucaoForm();
            devolucaoForm.Show();
            this.Hide();
        }
    }
}
