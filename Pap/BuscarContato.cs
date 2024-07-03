using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pap
{
    internal class BuscarContato
    {
        public string txt_buscar;
        public ListView lst_dados;

        public bool BuscarNaBD_Contacto()
        {
            try
            {
                using (MySqlConnection ConexaoBasedeDados = new MySqlConnection(ConexaoBD.basededados))
                {
                    ConexaoBasedeDados.Open();

                    string select = @"
                SELECT 
                    NSA,
                    `NSA-Empresa`,
                    DtContact,
                    HrContacto,
                    Resumo,
                    Forma,
                    InfoContacto,
                    NSA_Queixa,
                    NIF_Utilizador
                FROM
                    Contacto
                WHERE
                    `NSA-Empresa` LIKE @valor
                    OR Resumo LIKE @valor
                    OR Forma LIKE @valor
                    OR InfoContacto LIKE @valor
                    OR NIF_Utilizador LIKE @valor;";

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
                            reader.IsDBNull(reader.GetOrdinal("NSA-Empresa")) ? "" : reader.GetInt32(reader.GetOrdinal("NSA-Empresa")).ToString(),
                            reader.IsDBNull(reader.GetOrdinal("DtContact")) ? "" : reader.GetDateTime(reader.GetOrdinal("DtContact")).ToString("yyyy-MM-dd"),
                            reader.IsDBNull(reader.GetOrdinal("HrContacto")) ? "" : reader.GetTimeSpan(reader.GetOrdinal("HrContacto")).ToString(),
                            reader.IsDBNull(reader.GetOrdinal("Resumo")) ? "" : reader.GetString(reader.GetOrdinal("Resumo")),
                            reader.IsDBNull(reader.GetOrdinal("Forma")) ? "" : reader.GetString(reader.GetOrdinal("Forma")),
                            reader.IsDBNull(reader.GetOrdinal("InfoContacto")) ? "" : reader.GetString(reader.GetOrdinal("InfoContacto")),
                            reader.IsDBNull(reader.GetOrdinal("NSA_Queixa")) ? "" : reader.GetInt32(reader.GetOrdinal("NSA_Queixa")).ToString(),
                            reader.IsDBNull(reader.GetOrdinal("NIF_Utilizador")) ? "" : reader.GetString(reader.GetOrdinal("NIF_Utilizador"))
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
