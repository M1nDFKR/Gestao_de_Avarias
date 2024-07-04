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
    public partial class OrcamentoForm : Form
    {
        public OrcamentoForm()
        {
            InitializeComponent();

            cb_Lista_Queixa.DropDownStyle = ComboBoxStyle.DropDownList;

            cb_Lista_Queixa.SelectedIndex = 0;

            cb_Lista_Queixa.SelectedIndexChanged += new EventHandler(cb_Lista_Queixa_SelectedIndexChanged);

            richTxt_Resposta.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTxt_Resposta.WordWrap = true;

            richTxt_Resumo.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTxt_Resumo.WordWrap = true;

            lstDados.View = View.Details;
            lstDados.LabelEdit = true;
            lstDados.AllowColumnReorder = true;
            lstDados.FullRowSelect = true;
            lstDados.GridLines = true;

            lstDados.Columns.Add("NSA", 100, HorizontalAlignment.Left);
            lstDados.Columns.Add("NSA_Queixa", 100, HorizontalAlignment.Left);
            lstDados.Columns.Add("DtOrcamento", 100, HorizontalAlignment.Left);
            lstDados.Columns.Add("Comunicado", 100, HorizontalAlignment.Left);
            lstDados.Columns.Add("FormaCom", 100, HorizontalAlignment.Left);
            lstDados.Columns.Add("Resumo", 100, HorizontalAlignment.Left);
            lstDados.Columns.Add("Resposta", 100, HorizontalAlignment.Left);
            lstDados.Columns.Add("DtResposta", 100, HorizontalAlignment.Left);
            lstDados.Columns.Add("Pago", 100, HorizontalAlignment.Left);
            lstDados.Columns.Add("DtPagamento", 100, HorizontalAlignment.Left);

            CarregarDadosOrcamento();
        }
        private void OrcamentoForm_Load(object sender, EventArgs e)
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
                            string nifUtilizador = reader["NIF_Utilizador"].ToString();

                            cb_Lista_Queixa.Items.Add($"{nsa} - {nifUtilizador}");
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

                    txt_NSA_Queixa.Text = nsa;
                    txt_NIF_Utilizador.Text = nif;
                }
            }
        }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txt_NSA_Queixa.Text) &&
                    !string.IsNullOrWhiteSpace(txt_NIF_Utilizador.Text) &&
                    !string.IsNullOrWhiteSpace(txt_Comunicado.Text) &&
                    !string.IsNullOrWhiteSpace(txt_Forma_Comunicacao.Text) &&
                    !string.IsNullOrWhiteSpace(richTxt_Resumo.Text) &&
                    !string.IsNullOrWhiteSpace(richTxt_Resposta.Text) &&
                    (rb_Nao.Checked || rb_Sim.Checked))
                {
                    InserirOrcamento inOrcamento = new InserirOrcamento();

                    if (int.TryParse(txt_NSA_Queixa.Text, out int nsaQueixa))
                    {
                        inOrcamento.NSA_Queixa = nsaQueixa;
                    }
                    else
                    {
                        MessageBox.Show("Por favor, insira um número de queixa válido.");
                        return;
                    }

                    inOrcamento.DtOrcamento = DataDoOrcamento.Value;
                    inOrcamento.Comunicado = txt_Comunicado.Text;
                    inOrcamento.FormaCom = txt_Forma_Comunicacao.Text;
                    inOrcamento.Resumo = richTxt_Resumo.Text;
                    inOrcamento.Resposta = richTxt_Resposta.Text;
                    inOrcamento.DtResposta = DataDaResposta.Value;
                    inOrcamento.Pago = rb_Sim.Checked ? "Sim" : "Não";

                    if (rb_Nao.Checked)
                    {
                        inOrcamento.DtPagamento = null;
                    }
                    else if (rb_Sim.Checked)
                    {
                        if (DataDePagamento.Value != null)
                        {
                            inOrcamento.DtPagamento = DataDePagamento.Value;
                        }
                        else
                        {
                            MessageBox.Show("Por favor, selecione uma data de pagamento.");
                            return;
                        }
                    }

                    if (inOrcamento.inserirOrcamento())
                    {
                        MessageBox.Show($"Orçamento da Queixa com nº: {inOrcamento.NSA_Queixa} foi inserido com sucesso!");
                        txt_NSA_Queixa.Clear();
                        txt_NIF_Utilizador.Clear();
                        cb_Lista_Queixa.Enabled = true;
                        cb_Lista_Queixa.SelectedIndex = -1;
                        txt_Comunicado.Clear();
                        txt_Forma_Comunicacao.Clear();
                        richTxt_Resumo.Clear();
                        richTxt_Resposta.Clear();
                        rb_Nao.Checked = false;
                        rb_Sim.Checked = false;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao inserir orçamento.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir o Formulário de Orçamento: " + ex.Message);
            }
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_NSA_Queixa.Clear();
            txt_NIF_Utilizador.Clear();
            cb_Lista_Queixa.Enabled = true;
            cb_Lista_Queixa.SelectedIndex = -1;
            txt_Comunicado.Clear();
            txt_Forma_Comunicacao.Clear();
            richTxt_Resumo.Clear();
            richTxt_Resposta.Clear();
            rb_Nao.Checked = false;
            rb_Sim.Checked = false;
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                Buscar_Orcamento buscar = new Buscar_Orcamento();
                buscar.txt_buscar = txt_Buscar.Text;

                buscar.lst_dados = lstDados;

                if (!buscar.Buscar_OrcamentoNaBD())
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
            CarregarDadosOrcamento();
        }

        private void CarregarDadosOrcamento()
        {
            try
            {
                using (MySqlConnection ConexaoBasedeDados = new MySqlConnection(ConexaoBD.basededados))
                {
                    ConexaoBasedeDados.Open();

                    string select = @"
                SELECT 
                    NSA,
                    NSA_Queixa,
                    DtOrcamento,
                    Comunicado,
                    FormaCom,
                    Resumo,
                    Resposta,
                    DtResposta,
                    Pago,
                    DtPagamento
                FROM
                    Orcamento;";

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
                    reader.IsDBNull(reader.GetOrdinal("NSA_Queixa")) ? "" : reader.GetInt32(reader.GetOrdinal("NSA_Queixa")).ToString(),
                    reader.IsDBNull(reader.GetOrdinal("DtOrcamento")) ? "" : reader.GetDateTime(reader.GetOrdinal("DtOrcamento")).ToString("yyyy-MM-dd"),
                    reader.IsDBNull(reader.GetOrdinal("Comunicado")) ? "" : reader.GetString(reader.GetOrdinal("Comunicado")),
                    reader.IsDBNull(reader.GetOrdinal("FormaCom")) ? "" : reader.GetString(reader.GetOrdinal("FormaCom")),
                    reader.IsDBNull(reader.GetOrdinal("Resumo")) ? "" : reader.GetString(reader.GetOrdinal("Resumo")),
                    reader.IsDBNull(reader.GetOrdinal("Resposta")) ? "" : reader.GetString(reader.GetOrdinal("Resposta")),
                    reader.IsDBNull(reader.GetOrdinal("DtResposta")) ? "" : reader.GetDateTime(reader.GetOrdinal("DtResposta")).ToString("yyyy-MM-dd"),
                    reader.IsDBNull(reader.GetOrdinal("Pago")) ? "" : reader.GetString(reader.GetOrdinal("Pago")),
                    reader.IsDBNull(reader.GetOrdinal("DtPagamento")) ? "" : reader.GetDateTime(reader.GetOrdinal("DtPagamento")).ToString("yyyy-MM-dd")
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

        private void btnPageInsercao_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
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

        private void btn_Envio_Click(object sender, EventArgs e)
        {
            EnvioForm envioForm = new EnvioForm();
            envioForm.Show();
            this.Hide();
        }

        private void btn_Devolucao_Click(object sender, EventArgs e)
        {
            DevolucaoForm devolucaoForm = new DevolucaoForm();
            devolucaoForm.Show();
            this.Hide();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_NSA_Queixa.Text) &&
                    string.IsNullOrWhiteSpace(txt_NIF_Utilizador.Text) &&
                    string.IsNullOrWhiteSpace(txt_Comunicado.Text) &&
                    string.IsNullOrWhiteSpace(txt_Forma_Comunicacao.Text) &&
                    string.IsNullOrWhiteSpace(richTxt_Resumo.Text) &&
                    string.IsNullOrWhiteSpace(richTxt_Resposta.Text))
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
    }
}
