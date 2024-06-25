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
    public partial class EnvioForm : Form
    {
        public EnvioForm()
        {
            InitializeComponent();

            cb_Lista_Queixa.DropDownStyle = ComboBoxStyle.DropDownList;

            cb_Lista_Queixa.SelectedIndex = 0;

            cb_Lista_Queixa.SelectedIndexChanged += new EventHandler(cb_Lista_Queixa_SelectedIndexChanged);
        }

        private void EnvioForm_Load(object sender, EventArgs e)
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
                            string nif = reader["NIF_Utilizador"].ToString();

                            cb_Lista_Queixa.Items.Add($"{nsa} - {nif}");
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

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_NIF_Utilizador.Clear();
            txt_NSA_Queixa.Clear();
            cb_Lista_Queixa.Enabled = true;
            cb_Lista_Queixa.SelectedIndex = -1;
            txt_Referencia_Envio.Clear();
            txt_NSA_Transporter.Clear();
        }
    }
}
