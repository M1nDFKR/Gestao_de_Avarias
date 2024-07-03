using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pap
{
    internal class Buscar_Clientes
    {
        public string txt_buscar;
        public ListView lst_dados;

        public bool BuscarClientesNaBD()
        {
            try
            {
                using (MySqlConnection ConexaoBasedeDados = new MySqlConnection(ConexaoBD.basededados))
                {
                    ConexaoBasedeDados.Open();

                    string select = @"
                SELECT 
                    NIF,
                    Nome,
                    Processo,
                    NIFEE,
                    NomeEE,
                    EmailEE,
                    Parentesco,
                    Tipo,
                    DataInsercao
                FROM
                    Utilizador
                WHERE
                    NIF LIKE @valor
                    OR Nome LIKE @valor
                    OR Processo LIKE @valor
                    OR NIFEE LIKE @valor
                    OR NomeEE LIKE @valor
                    OR EmailEE LIKE @valor
                    OR Parentesco LIKE @valor
                    OR Tipo LIKE @valor;";

                    using (MySqlCommand comandoSql = new MySqlCommand(select, ConexaoBasedeDados))
                    {
                        comandoSql.Parameters.AddWithValue("@valor", "%" + txt_buscar + "%");

                        using (MySqlDataReader reader = comandoSql.ExecuteReader())
                        {
                            lst_dados.Items.Clear();

                            while (reader.Read())
                            {
                                string[] row =
                                {
                            reader.IsDBNull(reader.GetOrdinal("NIF")) ? "" : reader.GetString(reader.GetOrdinal("NIF")),
                            reader.IsDBNull(reader.GetOrdinal("Nome")) ? "" : reader.GetString(reader.GetOrdinal("Nome")),
                            reader.IsDBNull(reader.GetOrdinal("Processo")) ? "" : reader.GetInt32(reader.GetOrdinal("Processo")).ToString(),
                            reader.IsDBNull(reader.GetOrdinal("NIFEE")) ? "" : reader.GetString(reader.GetOrdinal("NIFEE")),
                            reader.IsDBNull(reader.GetOrdinal("NomeEE")) ? "" : reader.GetString(reader.GetOrdinal("NomeEE")),
                            reader.IsDBNull(reader.GetOrdinal("EmailEE")) ? "" : reader.GetString(reader.GetOrdinal("EmailEE")),
                            reader.IsDBNull(reader.GetOrdinal("Parentesco")) ? "" : reader.GetString(reader.GetOrdinal("Parentesco")),
                            reader.IsDBNull(reader.GetOrdinal("Tipo")) ? "" : reader.GetString(reader.GetOrdinal("Tipo")),
                            reader.IsDBNull(reader.GetOrdinal("DataInsercao")) ? "" : reader.GetDateTime(reader.GetOrdinal("DataInsercao")).ToString("yyyy-MM-dd")
                        };

                                var listViewItem = new ListViewItem(row);
                                lst_dados.Items.Add(listViewItem);
                            }
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
                return false;
            }
            finally
            {
                using MySqlConnection ConexaoBasedeDados = null;
                if (ConexaoBasedeDados != null)
                {
                    if (ConexaoBasedeDados.State != ConnectionState.Closed)
                    {
                        ConexaoBasedeDados.Close();
                    }
                    ConexaoBasedeDados.Dispose();
                }
            }
        }

    }
}
