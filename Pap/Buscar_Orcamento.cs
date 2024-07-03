using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pap
{
    internal class Buscar_Orcamento
    {
        public string txt_buscar;
        public ListView lst_dados;

        public bool Buscar_OrcamentoNaBD()
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
                    DtOrcamento,
                    Comunicado,
                    FormaCom,
                    Resumo,
                    Resposta,
                    DtResposta,
                    Pago,
                    DtPagamento
                FROM
                    Orcamento
                WHERE
                    NSA LIKE @valor
                    OR NSA_Queixa LIKE @valor
                    OR DtOrcamento LIKE @valor
                    OR Comunicado LIKE @valor
                    OR FormaCom LIKE @valor
                    OR Resumo LIKE @valor
                    OR Resposta LIKE @valor
                    OR DtResposta LIKE @valor
                    OR Pago LIKE @valor
                    OR DtPagamento LIKE @valor;";

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
                            reader.IsDBNull(reader.GetOrdinal("DtOrcamento")) ? "" : reader.GetDateTime(reader.GetOrdinal("DtOrcamento")).ToString("yyyy-MM-dd"),
                            reader.IsDBNull(reader.GetOrdinal("Comunicado")) ? "" : reader.GetString(reader.GetOrdinal("Comunicado")),
                            reader.IsDBNull(reader.GetOrdinal("FormaCom")) ? "" : reader.GetString(reader.GetOrdinal("FormaCom")),
                            reader.IsDBNull(reader.GetOrdinal("Resumo")) ? "" : reader.GetString(reader.GetOrdinal("Resumo")),
                            reader.IsDBNull(reader.GetOrdinal("Resposta")) ? "" : reader.GetString(reader.GetOrdinal("Resposta")),
                            reader.IsDBNull(reader.GetOrdinal("DtResposta")) ? "" : reader.GetDateTime(reader.GetOrdinal("DtResposta")).ToString("yyyy-MM-dd"),
                            reader.IsDBNull(reader.GetOrdinal("Pago")) ? "" : reader.GetString(reader.GetOrdinal("Pago")),
                            reader.IsDBNull(reader.GetOrdinal("DtPagamento")) ? "" : reader.GetDateTime(reader.GetOrdinal("DtPagamento")).ToString("yyyy-MM-dd")
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
