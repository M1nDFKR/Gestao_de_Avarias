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
                        MessageBox.Show("Este equipamento já está registrado na base de dados.");
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
    }
}
