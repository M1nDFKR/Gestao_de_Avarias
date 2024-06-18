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

        private void cb_listaClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_listaClientes.SelectedIndex == 0)
            {
                MessageBox.Show("Este item não pode ser selecionado.");

                cb_listaClientes.SelectedIndex = 0;
                return;
            }

            if (cb_listaClientes.SelectedIndex != -1)
            {
                string selectedItem = cb_listaClientes.SelectedItem.ToString();
                string[] parts = selectedItem.Split('-');

                textNIF.Text = parts[0].Trim();
                textNome.Text = parts[1].Trim();
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
                //Arrumar isso amanhã
                if (!string.IsNullOrWhiteSpace(textNIF.Text) &&
                    !string.IsNullOrWhiteSpace(textTipoEquip.Text) &&
                    !string.IsNullOrWhiteSpace(textN_S.Text) &&
                    !string.IsNullOrWhiteSpace(richTextDescricao.Text) &&
                    !string.IsNullOrWhiteSpace(richTextDecisao.Text))
                {

                    InserirQueixa inserirQueixa = new InserirQueixa();

                    inserirQueixa.NIFUtilizador = textNIF.Text;
                    inserirQueixa.TipoEquip = textTipoEquip.Text;
                    inserirQueixa.NS = textN_S.Text;
                    inserirQueixa.DataQueixa = dateQueixa.Value;
                    inserirQueixa.Descricao = richTextDescricao.Text;
                    inserirQueixa.Decisao = richTextDecisao.Text;

                }
                else
                {
                    MessageBox.Show(" Preencher todos os campos antes de inserir.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro ao resgista Queixa da avaria: " + ex.Message);
            }
        }
    }
}
