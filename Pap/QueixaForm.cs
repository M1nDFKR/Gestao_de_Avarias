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

            cb_listaClientes.DropDownStyle = ComboBoxStyle.DropDownList;

            cb_listaClientes.SelectedIndex = 0;

            cb_listaClientes.Enabled = string.IsNullOrEmpty(nif) && string.IsNullOrEmpty(nome);

            cb_listaClientes.SelectedIndexChanged += new EventHandler(cb_listaClientes_SelectedIndexChanged);

            richTextDecisao.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextDecisao.WordWrap = true;

            richTextDescricao.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextDescricao.WordWrap = true;
        }


        private void QueixaForm_Load(object sender, EventArgs e)
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
        }

        private void cb_listaClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_listaClientes.SelectedIndex == 0)
            {
                MessageBox.Show("Este item não pode ser selecionado.");
                cb_listaClientes.SelectedIndex = -1;
                return;
            }

            if (cb_listaClientes.SelectedIndex != -1)
            {
                string selectedItem = cb_listaClientes.SelectedItem.ToString();
                string[] parts = selectedItem.Split('-');

                string nif = parts[0].Trim();
                string nome = parts[1].Trim();

                if (UtilizadorJaTemQueixa(nif))
                {
                    MessageBox.Show("Este utilizador já tem uma queixa registrada.");
                    cb_listaClientes.SelectedIndex = -1;
                    textNome.Clear();
                    textNIF.Clear();
                    return;
                }

                textNIF.Text = nif;
                textNome.Text = nome;
            }
        }

        private bool UtilizadorJaTemQueixa(string nif)
        {
            try
            {
                string connectionString = ConexaoBD.basededados;
                string query = "SELECT COUNT(*) FROM Queixa WHERE NIF_Utilizador = @NIF";

                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand(query, conexao);
                    comando.Parameters.AddWithValue("@NIF", nif);

                    int count = Convert.ToInt32(comando.ExecuteScalar());

                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar a existência de queixa: " + ex.Message);
                return true;
            }
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            textNome.Clear();
            textNIF.Clear();
            cb_listaClientes.Enabled = true;
            cb_listaClientes.SelectedIndex = -1;
            textTipoEquip.Clear();
            textN_S.Clear();
            richTextDescricao.Clear();
            richTextDecisao.Clear();
        }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(textNIF.Text) &&
                    !string.IsNullOrWhiteSpace(textTipoEquip.Text) &&
                    !string.IsNullOrWhiteSpace(textN_S.Text) &&
                    !string.IsNullOrWhiteSpace(richTextDescricao.Text))
                {

                    InserirQueixa inQueixa = new InserirQueixa();

                    inQueixa.NIFUtilizador = textNIF.Text;
                    inQueixa.TipoEquip = textTipoEquip.Text;
                    inQueixa.NS = textN_S.Text;
                    inQueixa.DataQueixa = dateQueixa.Value;
                    inQueixa.Descricao = richTextDescricao.Text;
                    inQueixa.Decisao = richTextDecisao.Text;


                    if (inQueixa.inserirQueixa())
                    {
                        MessageBox.Show($" O(A) Cliente com o NIF: {inQueixa.NIFUtilizador} tem a sua queixa registrada com sucesso.");
                        textNome.Clear();
                        textNIF.Clear();
                        cb_listaClientes.Enabled = true;
                        cb_listaClientes.SelectedIndex = -1;
                        textTipoEquip.Clear();
                        textN_S.Clear();
                        richTextDescricao.Clear();
                        richTextDecisao.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel regista a queixa da avaria.");
                    }
                }
                else
                {
                    MessageBox.Show(" Preencher todos os campos antes de inserir.");
                    textNome.Clear();
                    textNIF.Clear();
                    cb_listaClientes.Enabled = true;
                    cb_listaClientes.SelectedIndex = -1;
                    textTipoEquip.Clear();
                    textN_S.Clear();
                    richTextDescricao.Clear();
                    richTextDecisao.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro ao resgista Queixa da avaria: " + ex.Message);
            }
        }
        private void btnPageHome_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textNIF.Text) &&
                string.IsNullOrWhiteSpace(textTipoEquip.Text) &&
                string.IsNullOrWhiteSpace(textN_S.Text) &&
                string.IsNullOrWhiteSpace(richTextDescricao.Text) &&
                string.IsNullOrWhiteSpace(richTextDecisao.Text))
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
            if (string.IsNullOrWhiteSpace(textNIF.Text) &&
                string.IsNullOrWhiteSpace(textTipoEquip.Text) &&
                string.IsNullOrWhiteSpace(textN_S.Text) &&
                string.IsNullOrWhiteSpace(richTextDescricao.Text) &&
                string.IsNullOrWhiteSpace(richTextDecisao.Text))
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
            if (string.IsNullOrWhiteSpace(textNIF.Text) &&
                string.IsNullOrWhiteSpace(textTipoEquip.Text) &&
                string.IsNullOrWhiteSpace(textN_S.Text) &&
                string.IsNullOrWhiteSpace(richTextDescricao.Text) &&
                string.IsNullOrWhiteSpace(richTextDecisao.Text))
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
    }
}
