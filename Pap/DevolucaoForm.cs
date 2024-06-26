﻿using MySql.Data.MySqlClient;
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

            cb_Lista_NSA_NIF_NIFEE.SelectedIndexChanged += new EventHandler(cb_Lista_NSA_NIF_NIFEE_SelectedIndexChanged);
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
        }
    }
}
