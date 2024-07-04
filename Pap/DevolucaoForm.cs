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
    public partial class DevolucaoForm : Form
    {
        public DevolucaoForm()
        {
            InitializeComponent();

            txt_Buscar.Focus();

            cb_Lista_NSA_NIF_NIFEE.SelectedIndexChanged += new EventHandler(cb_Lista_NSA_NIF_NIFEE_SelectedIndexChanged);

            lstDados.View = View.Details;
            lstDados.LabelEdit = true;
            lstDados.AllowColumnReorder = true;
            lstDados.FullRowSelect = true;
            lstDados.GridLines = true;

            lstDados.Columns.Add("NSA", 50, HorizontalAlignment.Left);
            lstDados.Columns.Add("NSA_Queixa", 50, HorizontalAlignment.Left);
            lstDados.Columns.Add("DtDevolucao", 100, HorizontalAlignment.Left);
            lstDados.Columns.Add("DtEntrega", 100, HorizontalAlignment.Left);
            lstDados.Columns.Add("NIF_Utilizador", 100, HorizontalAlignment.Left);
            lstDados.Columns.Add("NIFEE", 100, HorizontalAlignment.Left);

            CarregarDadosDevolucao();
        }

        private void DevolucaoForm_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConexaoBD.basededados;
                string query = @"
            SELECT 
                q.NSA AS NSA_Queixa, 
                u1.NIF AS NIF_Utilizador, 
                u1.NIFEE AS NIFEE
            FROM 
                Utilizador u1
            INNER JOIN 
                Queixa q ON u1.NIF = q.NIF_Utilizador
            ORDER BY 
                q.NSA";

                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand(query, conexao);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nsa = reader["NSA_Queixa"].ToString();
                            string nifUtilizador = reader["NIF_Utilizador"].ToString();
                            string nifEE = reader["NIFEE"].ToString();

                            cb_Lista_NSA_NIF_NIFEE.Items.Add($"{nsa} - {nifUtilizador} - {nifEE}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar devoluções: " + ex.Message);
            }
        }


        private void cb_Lista_NSA_NIF_NIFEE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Lista_NSA_NIF_NIFEE.SelectedIndex == 0)
            {
                MessageBox.Show("Este item não pode ser selecionado.");
                cb_Lista_NSA_NIF_NIFEE.SelectedIndex = -1;
                txt_NSA_Queixa.Clear();
                txt_NIF.Clear();
                txt_NIFEE.Clear();
                return;
            }

            if (cb_Lista_NSA_NIF_NIFEE.SelectedIndex != -1)
            {
                string selectedItem = cb_Lista_NSA_NIF_NIFEE.SelectedItem.ToString();
                string[] parts = selectedItem.Split('-');

                if (parts.Length == 3)
                {
                    string nsa = parts[0].Trim();
                    string nifUtilizador = parts[1].Trim();
                    string nifEE = parts[2].Trim();

                    if (UtilizadorJaTemDevolucao(nsa))
                    {
                        MessageBox.Show("Este utilizador já possui uma devolução registrada.");
                        cb_Lista_NSA_NIF_NIFEE.SelectedIndex = -1;
                        txt_NSA_Queixa.Clear();
                        txt_NIF.Clear();
                        txt_NIFEE.Clear();
                        return;
                    }

                    txt_NSA_Queixa.Text = nsa;
                    txt_NIF.Text = nifUtilizador;
                    txt_NIFEE.Text = nifEE;
                }
            }
        }

        private bool UtilizadorJaTemDevolucao(string nsa)
        {
            try
            {
                string connectionString = ConexaoBD.basededados;
                string query = "SELECT COUNT(*) FROM Devolucao WHERE NSA_Queixa = @NSA";

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
                MessageBox.Show("Erro ao verificar a existência de devolução: " + ex.Message);
                return true;
            }
        }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txt_NIF.Text) &&
                    !string.IsNullOrWhiteSpace(txt_NSA_Queixa.Text) &&
                    !string.IsNullOrWhiteSpace(txt_NIFEE.Text))
                {
                    InserirDevolucao inDevolucao = new InserirDevolucao();

                    if (int.TryParse(txt_NSA_Queixa.Text, out int nsaQueixa))
                    {
                        inDevolucao.NSA_Queixa = nsaQueixa;
                    }
                    else
                    {
                        MessageBox.Show("Por favor, insira um número de queixa válido.");
                        return;
                    }

                    inDevolucao.NIF_Utilizador = txt_NIF.Text;
                    inDevolucao.NIFEE = txt_NIFEE.Text;
                    inDevolucao.DtDevolucao = DataDeDevolucao.Value;
                    inDevolucao.DtEntrega = DataDeEntrega.Value;

                    if (inDevolucao.inserirDevolucao())
                    {
                        MessageBox.Show($" O(A) Cliente com o NIF: {inDevolucao.NIF_Utilizador} tem a sua devolução registrada com sucesso.");
                        txt_NSA_Queixa.Clear();
                        txt_NIF.Clear();
                        txt_NIFEE.Clear();
                        cb_Lista_NSA_NIF_NIFEE.Enabled = true;
                        cb_Lista_NSA_NIF_NIFEE.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel regista a queixa da avaria.");
                    }
                }
                else
                {
                    MessageBox.Show(" Preencher todos os campos antes de inserir.");
                    txt_NSA_Queixa.Clear();
                    txt_NIF.Clear();
                    txt_NIFEE.Clear();
                    cb_Lista_NSA_NIF_NIFEE.Enabled = true;
                    cb_Lista_NSA_NIF_NIFEE.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registra devolução: " + ex.Message);
            }

        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_NSA_Queixa.Clear();
            txt_NIF.Clear();
            txt_NIFEE.Clear();
            cb_Lista_NSA_NIF_NIFEE.Enabled = true;
            cb_Lista_NSA_NIF_NIFEE.SelectedIndex = -1;
            txt_Buscar.Focus();
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                Buscar_Devolucao buscar = new Buscar_Devolucao();
                buscar.txt_buscar = txt_Buscar.Text;

                buscar.lst_dados = lstDados;

                if (!buscar.BuscarDevolucaoNaBD())
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
            CarregarDadosDevolucao();
        }

        private void CarregarDadosDevolucao()
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
                    DtDevolucao,
                    DtEntrega,
                    NIF_Utilizador,
                    NIFEE
                FROM
                    Devolucao;";

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
                            reader.IsDBNull(reader.GetOrdinal("DtDevolucao")) ? "" : reader.GetDateTime(reader.GetOrdinal("DtDevolucao")).ToString("yyyy-MM-dd"),
                            reader.IsDBNull(reader.GetOrdinal("DtEntrega")) ? "" : reader.GetDateTime(reader.GetOrdinal("DtEntrega")).ToString("yyyy-MM-dd"),
                            reader.IsDBNull(reader.GetOrdinal("NIF_Utilizador")) ? "" : reader.GetString(reader.GetOrdinal("NIF_Utilizador")),
                            reader.IsDBNull(reader.GetOrdinal("NIFEE")) ? "" : reader.GetString(reader.GetOrdinal("NIFEE"))
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
            home Home = new home();
            Home.Show();
            this.Hide();
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

        private void btn_Orcamento_Click(object sender, EventArgs e)
        {
            OrcamentoForm orcamentoForm = new OrcamentoForm();
            orcamentoForm.Show();
            this.Hide();
        }
    }
}
