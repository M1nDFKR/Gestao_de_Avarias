using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pap
{
    internal class Buscar_Devolucao
    {
        public string txt_buscar;
        public ListView lst_dados;

        public bool BuscarDevolucaoNaBD()
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
                    Devolucao
                WHERE
                    NSA LIKE @valor
                    OR NSA_Queixa LIKE @valor
                    OR DtDevolucao LIKE @valor
                    OR DtEntrega LIKE @valor
                    OR NIF_Utilizador LIKE @valor
                    OR NIFEE LIKE @valor;";

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
                            reader.IsDBNull(reader.GetOrdinal("NSA")) ? "" : reader.GetInt32(reader.GetOrdinal("NSA")).ToString(),
                            reader.IsDBNull(reader.GetOrdinal("NSA_Queixa")) ? "" : reader.GetInt32(reader.GetOrdinal("NSA_Queixa")).ToString(),
                            reader.IsDBNull(reader.GetOrdinal("DtDevolucao")) ? "" : reader.GetDateTime(reader.GetOrdinal("DtDevolucao")).ToString("yyyy-MM-dd"),
                            reader.IsDBNull(reader.GetOrdinal("DtEntrega")) ? "" : reader.GetDateTime(reader.GetOrdinal("DtEntrega")).ToString("yyyy-MM-dd"),
                            reader.IsDBNull(reader.GetOrdinal("NIF_Utilizador")) ? "" : reader.GetString(reader.GetOrdinal("NIF_Utilizador")),
                            reader.IsDBNull(reader.GetOrdinal("NIFEE")) ? "" : reader.GetString(reader.GetOrdinal("NIFEE"))
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
