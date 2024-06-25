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
    public partial class EnvioForm : Form
    {
        public EnvioForm()
        {
            InitializeComponent();

            cb_Lista_Queixa.DropDownStyle = ComboBoxStyle.DropDownList;

            cb_Lista_Queixa.SelectedIndex = 0;
        }

        private void EnvioForm_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConexaoBD.basededados;
                string query = "SELECT NSA, NIF_Utilizador FROM Queixa ORDER BY NSA";

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
    }
}
