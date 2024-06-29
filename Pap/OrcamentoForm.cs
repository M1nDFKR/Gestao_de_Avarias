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
    }
}
