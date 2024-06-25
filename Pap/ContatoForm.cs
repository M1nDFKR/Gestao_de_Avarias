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
                MessageBox.Show("Erro ao inserir o formulário de contato: " + ex.Message);
            }
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

        private void btnPageHome_Click(object sender, EventArgs e)
        {
            home Home = new home();
            Home.Show();
            this.Hide();
        }
    }
}
