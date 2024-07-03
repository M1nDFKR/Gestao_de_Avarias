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
    public partial class ContatoForm : Form
    {
        public ContatoForm()
        {
            InitializeComponent();

            cb_Lista_Queixa_NIF.DropDownStyle = ComboBoxStyle.DropDownList;

            cb_Lista_Queixa_NIF.SelectedIndex = 0;

            cb_Lista_Queixa_NIF.SelectedIndexChanged += new EventHandler(cb_Lista_Queixa_NIF_SelectedIndexChanged);

            richTextResumo.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextResumo.WordWrap = true;

            richTextInfoContato.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextInfoContato.WordWrap = true;

            lstDados.View = View.Details;
            lstDados.LabelEdit = true;
            lstDados.AllowColumnReorder = true;
            lstDados.FullRowSelect = true;
            lstDados.GridLines = true;

            lstDados.Columns.Add("NSA", 50, HorizontalAlignment.Left);
            lstDados.Columns.Add("NSA-Empresa", 100, HorizontalAlignment.Left);
            lstDados.Columns.Add("DtContact", 100, HorizontalAlignment.Left);
            lstDados.Columns.Add("HrContacto", 100, HorizontalAlignment.Left);
            lstDados.Columns.Add("Resumo", 150, HorizontalAlignment.Left);
            lstDados.Columns.Add("Forma", 100, HorizontalAlignment.Left);
            lstDados.Columns.Add("InfoContacto", 200, HorizontalAlignment.Left);
            lstDados.Columns.Add("NSA_Queixa", 50, HorizontalAlignment.Left);
            lstDados.Columns.Add("NIF_Utilizador", 100, HorizontalAlignment.Left);

            CarregarDadosContacto();
        }

        private void ContatoForm_Load(object sender, EventArgs e)
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

                            cb_Lista_Queixa_NIF.Items.Add($"{nsa} - {nifUtilizador}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar queixas: " + ex.Message);
            }
        }

        private void cb_Lista_Queixa_NIF_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Lista_Queixa_NIF.SelectedIndex == 0)
            {
                MessageBox.Show("Este item não pode ser selecionado.");
                cb_Lista_Queixa_NIF.SelectedIndex = -1;
                return;
            }
            if (cb_Lista_Queixa_NIF.SelectedIndex != -1)
            {
                string selectedItem = cb_Lista_Queixa_NIF.SelectedItem.ToString();
                string[] parts = selectedItem.Split('-');

                if (parts.Length == 2)
                {
                    string nsa = parts[0].Trim();
                    string nif = parts[1].Trim();

                    NSA_Queixa.Text = nsa;
                    txt_NIF_Utilizador.Text = nif;
                }
            }
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            NSA_Queixa.Text = string.Empty;
            txt_NIF_Utilizador.Clear();
            cb_Lista_Queixa_NIF.Enabled = true;
            cb_Lista_Queixa_NIF.SelectedIndex = -1;
            txt_NSA_Empresa.Clear();
            maskedTextHora.Clear();
            richTextResumo.Clear();
            txt_Forma.Clear();
            richTextInfoContato.Clear();
        }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(NSA_Queixa.Text) &&
                    !string.IsNullOrWhiteSpace(txt_NIF_Utilizador.Text) &&
                    !string.IsNullOrWhiteSpace(txt_NSA_Empresa.Text) &&
                    !string.IsNullOrWhiteSpace(maskedTextHora.Text) &&
                    !string.IsNullOrWhiteSpace(richTextResumo.Text) &&
                    !string.IsNullOrWhiteSpace(txt_Forma.Text) &&
                    !string.IsNullOrWhiteSpace(richTextInfoContato.Text))
                {
                    InserirContacto inContacto = new InserirContacto();

                    inContacto.NIF_Utilizador = txt_NIF_Utilizador.Text;

                    if (int.TryParse(NSA_Queixa.Text, out int nsaQueixa))
                    {
                        inContacto.NSA_Queixa = nsaQueixa;
                    }
                    else
                    {
                        MessageBox.Show("Por favor, insira um número de queixa válido.");
                        return;
                    }

                    int nsaEmpresa;
                    if (!int.TryParse(txt_NSA_Empresa.Text, out nsaEmpresa))
                    {
                        MessageBox.Show("NSA Empresa deve ser um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    TimeSpan hrContacto;
                    if (!TimeSpan.TryParse(maskedTextHora.Text, out hrContacto))
                    {
                        MessageBox.Show("Hora de contato deve estar em um formato válido (HH:mm).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    inContacto.NSA_Empresa = nsaEmpresa;
                    inContacto.DtContacto = dataDeContato.Value;
                    inContacto.HrContacto = hrContacto;
                    inContacto.Resumo = richTextResumo.Text;
                    inContacto.Forma = txt_Forma.Text;
                    inContacto.InfoContacto = richTextInfoContato.Text;

                    if (inContacto.inserirContacto())
                    {
                        MessageBox.Show($" O(A) Cliente com o NIF: {inContacto.NIF_Utilizador} tem o seu contato registrado com sucesso.");
                        NSA_Queixa.Text = string.Empty;
                        txt_NIF_Utilizador.Clear();
                        cb_Lista_Queixa_NIF.Enabled = true;
                        cb_Lista_Queixa_NIF.SelectedIndex = -1;
                        txt_NSA_Empresa.Clear();
                        maskedTextHora.Clear();
                        richTextResumo.Clear();
                        txt_Forma.Clear();
                        richTextInfoContato.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel regista a queixa da avaria.");
                    }
                }
                else
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos antes de inserir.");
                    NSA_Queixa.Text = string.Empty;
                    txt_NIF_Utilizador.Clear();
                    cb_Lista_Queixa_NIF.Enabled = true;
                    cb_Lista_Queixa_NIF.SelectedIndex = -1;
                    txt_NSA_Empresa.Clear();
                    maskedTextHora.Clear();
                    richTextResumo.Clear();
                    txt_Forma.Clear();
                    richTextInfoContato.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir o Formulário de Contacto: " + ex.Message);
            }
        }

        private void btnPageBusca_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NSA_Queixa.Text) &&
                string.IsNullOrWhiteSpace(txt_NIF_Utilizador.Text) &&
                string.IsNullOrWhiteSpace(txt_NSA_Empresa.Text) &&
                string.IsNullOrWhiteSpace(richTextResumo.Text) &&
                string.IsNullOrWhiteSpace(txt_Forma.Text) &&
                string.IsNullOrWhiteSpace(richTextInfoContato.Text))
            {
                BuscarForm buscarForm = new BuscarForm();
                buscarForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Por favor, limpe todos os campos antes de mudar de página.");
            }
        }

        private void btnPageInsercao_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NSA_Queixa.Text) &&
                string.IsNullOrWhiteSpace(txt_NIF_Utilizador.Text) &&
                string.IsNullOrWhiteSpace(txt_NSA_Empresa.Text) &&
                string.IsNullOrWhiteSpace(richTextResumo.Text) &&
                string.IsNullOrWhiteSpace(txt_Forma.Text) &&
                string.IsNullOrWhiteSpace(richTextInfoContato.Text))
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Por favor, limpe todos os campos antes de mudar de página.");
            }
        }

        private void btnPageQueixa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NSA_Queixa.Text) &&
                string.IsNullOrWhiteSpace(txt_NIF_Utilizador.Text) &&
                string.IsNullOrWhiteSpace(txt_NSA_Empresa.Text) &&
                string.IsNullOrWhiteSpace(richTextResumo.Text) &&
                string.IsNullOrWhiteSpace(txt_Forma.Text) &&
                string.IsNullOrWhiteSpace(richTextInfoContato.Text))
            {
                QueixaForm queixaForm = new QueixaForm();
                queixaForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Por favor, limpe todos os campos antes de mudar de página.");
            }
        }

        private void btnPageEquipamentos_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NSA_Queixa.Text) &&
                string.IsNullOrWhiteSpace(txt_NIF_Utilizador.Text) &&
                string.IsNullOrWhiteSpace(txt_NSA_Empresa.Text) &&
                string.IsNullOrWhiteSpace(richTextResumo.Text) &&
                string.IsNullOrWhiteSpace(txt_Forma.Text) &&
                string.IsNullOrWhiteSpace(richTextInfoContato.Text))
            {
                EquipRecebido equipamentorecebido = new EquipRecebido();
                equipamentorecebido.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Por favor, limpe todos os campos antes de mudar de página.");
            }
        }

        private void btnPageHome_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NSA_Queixa.Text) &&
                string.IsNullOrWhiteSpace(txt_NIF_Utilizador.Text) &&
                string.IsNullOrWhiteSpace(txt_NSA_Empresa.Text) &&
                string.IsNullOrWhiteSpace(richTextResumo.Text) &&
                string.IsNullOrWhiteSpace(txt_Forma.Text) &&
                string.IsNullOrWhiteSpace(richTextInfoContato.Text))
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

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                BuscarContato buscar = new BuscarContato();
                buscar.txt_buscar = txt_Buscar.Text;

                buscar.lst_dados = lstDados;

                if (!buscar.BuscarNaBD_Contacto())
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
            CarregarDadosContacto();
        }

        private void CarregarDadosContacto()
        {
            try
            {
                using (MySqlConnection ConexaoBasedeDados = new MySqlConnection(ConexaoBD.basededados))
                {
                    ConexaoBasedeDados.Open();

                    string select = @"
                SELECT 
                    NSA,
                    `NSA-Empresa`,
                    DtContact,
                    HrContacto,
                    Resumo,
                    Forma,
                    InfoContacto,
                    NSA_Queixa,
                    NIF_Utilizador
                FROM
                    Contacto;";

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
                            reader.IsDBNull(reader.GetOrdinal("NSA-Empresa")) ? "" : reader.GetInt32(reader.GetOrdinal("NSA-Empresa")).ToString(),
                            reader.IsDBNull(reader.GetOrdinal("DtContact")) ? "" : reader.GetDateTime(reader.GetOrdinal("DtContact")).ToString("yyyy-MM-dd"),
                            reader.IsDBNull(reader.GetOrdinal("HrContacto")) ? "" : reader.GetTimeSpan(reader.GetOrdinal("HrContacto")).ToString(),
                            reader.IsDBNull(reader.GetOrdinal("Resumo")) ? "" : reader.GetString(reader.GetOrdinal("Resumo")),
                            reader.IsDBNull(reader.GetOrdinal("Forma")) ? "" : reader.GetString(reader.GetOrdinal("Forma")),
                            reader.IsDBNull(reader.GetOrdinal("InfoContacto")) ? "" : reader.GetString(reader.GetOrdinal("InfoContacto")),
                            reader.IsDBNull(reader.GetOrdinal("NSA_Queixa")) ? "" : reader.GetInt32(reader.GetOrdinal("NSA_Queixa")).ToString(),
                            reader.IsDBNull(reader.GetOrdinal("NIF_Utilizador")) ? "" : reader.GetString(reader.GetOrdinal("NIF_Utilizador"))
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

    }
}
