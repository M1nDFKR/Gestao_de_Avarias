using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pap
{
    internal class BuscarEnvio
    {
        public string txt_buscar;
        public ListView lst_dados;

        public bool Buscar_EnvioNaBD()
        {
            try
            {
                using (MySqlConnection ConexaoBasedeDados = new MySqlConnection(ConexaoBD.basededados))
                {
                    ConexaoBasedeDados.Open();

                    string select = @"
                SELECT 
                    Referencia,
                    NSA_Queixa,
                    DtEnvio,
                    NSA_Transp
                FROM
                    Envio
                WHERE
                    CAST(Referencia AS CHAR) LIKE @valor
                    OR CAST(NSA_Queixa AS CHAR) LIKE @valor
                    OR CAST(NSA_Transp AS CHAR) LIKE @valor
                    OR DtEnvio LIKE @valor;";

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
                            reader.IsDBNull(reader.GetOrdinal("Referencia")) ? "" : reader.GetInt32(reader.GetOrdinal("Referencia")).ToString(),
                            reader.IsDBNull(reader.GetOrdinal("NSA_Queixa")) ? "" : reader.GetInt32(reader.GetOrdinal("NSA_Queixa")).ToString(),
                            reader.IsDBNull(reader.GetOrdinal("DtEnvio")) ? "" : reader.GetDateTime(reader.GetOrdinal("DtEnvio")).ToString("yyyy-MM-dd"),
                            reader.IsDBNull(reader.GetOrdinal("NSA_Transp")) ? "" : reader.GetInt32(reader.GetOrdinal("NSA_Transp")).ToString()
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
