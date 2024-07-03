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
    public partial class EquipRecebido : Form
    {
        public EquipRecebido()
        {
            InitializeComponent();

            cb_ListaDeQueixas.SelectedIndex = 0;

            cb_ListaDeQueixas.SelectedIndexChanged += new EventHandler(cb_ListaDeQueixas_SelectedIndexChanged);

            cb_ListaDeQueixas.DropDownStyle = ComboBoxStyle.DropDownList;

            lstDados.View = View.Details;
            lstDados.LabelEdit = true;
            lstDados.AllowColumnReorder = true;
            lstDados.FullRowSelect = true;
            lstDados.GridLines = true;

            lstDados.Columns.Add("NSA", 50, HorizontalAlignment.Left);
            lstDados.Columns.Add("N-S", 100, HorizontalAlignment.Left);
            lstDados.Columns.Add("DtEntrada", 100, HorizontalAlignment.Left);
            lstDados.Columns.Add("TipoEquip", 100, HorizontalAlignment.Left);
            lstDados.Columns.Add("NSA_Queixa", 50, HorizontalAlignment.Left);
            lstDados.Columns.Add("Ref_Quei_Empr", 200, HorizontalAlignment.Left);

            CarregarDadosEquipRecebido();
        }

        private void EquipRecebido_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConexaoBD.basededados;
                string query = "SELECT `N-S`, TipoEquip, NSA FROM Queixa";

                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand(query, conexao);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string ns = reader["N-S"].ToString();
                            string tipoEquip = reader["TipoEquip"].ToString();
                            string nsaQueixa = reader["NSA"].ToString();

                            cb_ListaDeQueixas.Items.Add($"{nsaQueixa} - {ns} - {tipoEquip}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar queixas: " + ex.Message);
            }
        }

        private void cb_ListaDeQueixas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_ListaDeQueixas.SelectedIndex == 0)
            {
                MessageBox.Show("Este item não pode ser selecionado.");
                cb_ListaDeQueixas.SelectedIndex = -1;
                NSA_Queixas.Text = string.Empty;
                txt_NS.Clear();
                txt_TipoDeEquipamento.Clear();
                return;
            }

            if (cb_ListaDeQueixas.SelectedIndex != -1)
            {
                string selectedItem = cb_ListaDeQueixas.SelectedItem.ToString();
                string[] parts = selectedItem.Split('-');

                if (parts.Length == 3)
                {
                    string nsaQueixa = parts[0].Trim();
                    string ns = parts[1].Trim();
                    string tipoEquip = parts[2].Trim();

                    if (EquipamentoJaExiste(ns, tipoEquip))
                    {
                        MessageBox.Show("Este equipamento já está registrado.");
                        cb_ListaDeQueixas.SelectedIndex = -1;
                        NSA_Queixas.Text = string.Empty;
                        txt_NS.Clear();
                        txt_TipoDeEquipamento.Clear();
                        return;
                    }

                    NSA_Queixas.Text = nsaQueixa;
                    txt_NS.Text = ns;
                    txt_TipoDeEquipamento.Text = tipoEquip;
                }
            }
        }


        private bool EquipamentoJaExiste(string ns, string tipoEquip)
        {
            try
            {
                string connectionString = ConexaoBD.basededados;
                string query = "SELECT COUNT(*) FROM EquipRecebido WHERE `N-S` = @NS AND TipoEquip = @TipoEquip";

                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand(query, conexao);
                    comando.Parameters.AddWithValue("@NS", ns);
                    comando.Parameters.AddWithValue("@TipoEquip", tipoEquip);

                    int count = Convert.ToInt32(comando.ExecuteScalar());

                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar a existência do equipamento: " + ex.Message);
                return true;
            }
        }


        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            NSA_Queixas.Text = string.Empty;
            txt_NS.Clear();
            txt_TipoDeEquipamento.Clear();
            cb_ListaDeQueixas.Enabled = true;
            cb_ListaDeQueixas.SelectedIndex = -1;
            txt_referencia.Clear();
        }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txt_NS.Text) &&
                    !string.IsNullOrWhiteSpace(txt_TipoDeEquipamento.Text) &&
                    !string.IsNullOrWhiteSpace(txt_referencia.Text))
                {
                    InserirEquipamento inEquipamento = new InserirEquipamento();

                    if (int.TryParse(NSA_Queixas.Text, out int nsaQueixa))
                    {
                        inEquipamento.NSAQueixa = nsaQueixa;
                    }
                    else
                    {
                        MessageBox.Show("Por favor, insira um número de queixa válido.");
                        return;
                    }

                    inEquipamento.NS = txt_NS.Text;
                    inEquipamento.TipoEquip = txt_TipoDeEquipamento.Text;
                    inEquipamento.DtEntrada = dataDeEntrada.Value;
                    inEquipamento.RefQueiEmpr = txt_referencia.Text;

                    if (inEquipamento.Inserir())
                    {
                        MessageBox.Show($" O Equipamento com o NS: {inEquipamento.NS} foi resgitado com sucesso.");
                        NSA_Queixas.Text = string.Empty;
                        txt_NS.Clear();
                        txt_TipoDeEquipamento.Clear();
                        cb_ListaDeQueixas.Enabled = true;
                        cb_ListaDeQueixas.SelectedIndex = -1;
                        txt_referencia.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel regista o equipamento.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro ao resgista Equipamento: " + ex.Message);
            }
        }

        private void btnPageHome_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_NS.Text) &&
                string.IsNullOrWhiteSpace(txt_TipoDeEquipamento.Text) &&
                string.IsNullOrWhiteSpace(txt_referencia.Text))
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

        private void btnPageQueixa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_NS.Text) &&
                string.IsNullOrWhiteSpace(txt_TipoDeEquipamento.Text) &&
                string.IsNullOrWhiteSpace(txt_referencia.Text))
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

        private void btnPageBusca_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_NS.Text) &&
                string.IsNullOrWhiteSpace(txt_TipoDeEquipamento.Text) &&
                string.IsNullOrWhiteSpace(txt_referencia.Text))
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

        private void btnPage_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_NS.Text) &&
                string.IsNullOrWhiteSpace(txt_TipoDeEquipamento.Text) &&
                string.IsNullOrWhiteSpace(txt_referencia.Text))
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

        private void btn_Contato_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_NS.Text) &&
                string.IsNullOrWhiteSpace(txt_TipoDeEquipamento.Text) &&
                string.IsNullOrWhiteSpace(txt_referencia.Text))
            {
                ContatoForm contatoForm = new ContatoForm();
                contatoForm.Show();
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
                Buscar_EquipRecebido buscar = new Buscar_EquipRecebido();
                buscar.txt_buscar = txt_Buscar.Text;

                buscar.lst_dados = lstDados;

                if (!buscar.BuscarNaBD_EquipRecebido())
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
            CarregarDadosEquipRecebido();
        }

        private void CarregarDadosEquipRecebido()
        {
            try
            {
                using (MySqlConnection ConexaoBasedeDados = new MySqlConnection(ConexaoBD.basededados))
                {
                    ConexaoBasedeDados.Open();

                    string select = @"
                SELECT 
                    NSA,
                    `N-S`,
                    DtEntrada,
                    TipoEquip,
                    NSA_Queixa,
                    Ref_Quei_Empr
                FROM
                    EquipRecebido;";

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
                            reader.IsDBNull(reader.GetOrdinal("N-S")) ? "" : reader.GetString(reader.GetOrdinal("N-S")),
                            reader.IsDBNull(reader.GetOrdinal("DtEntrada")) ? "" : reader.GetDateTime(reader.GetOrdinal("DtEntrada")).ToString("yyyy-MM-dd"),
                            reader.IsDBNull(reader.GetOrdinal("TipoEquip")) ? "" : reader.GetString(reader.GetOrdinal("TipoEquip")),
                            reader.IsDBNull(reader.GetOrdinal("NSA_Queixa")) ? "" : reader.GetInt32(reader.GetOrdinal("NSA_Queixa")).ToString(),
                            reader.IsDBNull(reader.GetOrdinal("Ref_Quei_Empr")) ? "" : reader.GetString(reader.GetOrdinal("Ref_Quei_Empr"))
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
