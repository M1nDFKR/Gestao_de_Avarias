using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pap
{
    internal class Buscar_EquipRecebido
    {
        public string txt_buscar;
        public ListView lst_dados;

        public bool BuscarNaBD_EquipRecebido()
        {
            try
            {
                using (MySqlConnection ConexaoBasedeDados = new MySqlConnection(ConexaoBD.basededados))
                {
                    ConexaoBasedeDados.Open();

                    string select = @"
                SELECT 
                    NSA,
                    `N-S`,
                    DtEntrada,
                    TipoEquip,
                    NSA_Queixa,
                    Ref_Quei_Empr
                FROM
                    EquipRecebido
                WHERE
                    `N-S` LIKE @valor
                    OR TipoEquip LIKE @valor
                    OR DtEntrada LIKE @valor
                    OR Ref_Quei_Empr LIKE @valor;";

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
                            reader.IsDBNull(reader.GetOrdinal("N-S")) ? "" : reader.GetString(reader.GetOrdinal("N-S")),
                            reader.IsDBNull(reader.GetOrdinal("DtEntrada")) ? "" : reader.GetDateTime(reader.GetOrdinal("DtEntrada")).ToString("yyyy-MM-dd"),
                            reader.IsDBNull(reader.GetOrdinal("TipoEquip")) ? "" : reader.GetString(reader.GetOrdinal("TipoEquip")),
                            reader.IsDBNull(reader.GetOrdinal("NSA_Queixa")) ? "" : reader.GetInt32(reader.GetOrdinal("NSA_Queixa")).ToString(),
                            reader.IsDBNull(reader.GetOrdinal("Ref_Quei_Empr")) ? "" : reader.GetString(reader.GetOrdinal("Ref_Quei_Empr"))
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
