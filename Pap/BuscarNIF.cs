using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Pap
{
    internal class BuscarNIF
    {
        public string txt_buscar;
        public ListView lst_dados;

        public bool BuscarNaBD()
        {

            try
            {
                using (MySqlConnection ConexaoBasedeDados = new MySqlConnection(ConexaoBD.basededados))
                {
                    ConexaoBasedeDados.Open();


                    string select = @"
                    SELECT 
                        Utilizador.NIF,
                        Utilizador.Nome AS Nome_Utilizador,
                        Utilizador.Processo,
                        Utilizador.NIFEE,
                        Utilizador.NomeEE,
                        Utilizador.EmailEE,
                        Utilizador.Parentesco,
                        Utilizador.Tipo,
                        Queixa.NSA,
                        Queixa.TipoEquip,
                        Queixa.`N-S`,
                        Queixa.DtQueixa,
                        Queixa.Descricao,
                        Queixa.Decisao,
                        EquipRecebido.DtEntrada AS DtEntrada_EquipRecebido,
                        EquipRecebido.TipoEquip AS TipoEquip_EquipRecebido,
                        EquipRecebido.Ref_Quei_Empr,
                        Contacto.DtContact,
                        Contacto.HrContacto,
                        Contacto.Resumo AS Resumo_Contacto,
                        Contacto.Forma,
                        Contacto.InfoContacto,
                        Envio.Referencia,
                        Envio.DtEnvio,
                        Envio.NSA_Transp,
                        Orcamento.DtOrcamento,
                        Orcamento.Comunicado,
                        Orcamento.FormaCom,
                        Orcamento.Resumo AS Resumo_Orcamento,
                        Orcamento.Resposta,
                        Orcamento.DtResposta,
                        Orcamento.Pago,
                        Orcamento.DtPagamento,
                        Devolucao.DtDevolucao,
                        Devolucao.DtEntrega
                    FROM
                        Utilizador
                    LEFT JOIN Queixa ON Utilizador.NIF = Queixa.NIF_Utilizador
                    LEFT JOIN EquipRecebido ON Queixa.`N-S` = EquipRecebido.`N-S`
                    LEFT JOIN Contacto ON Queixa.NSA = Contacto.NSA_Queixa
                    LEFT JOIN Envio ON Queixa.NSA = Envio.NSA_Queixa
                    LEFT JOIN Orcamento ON Queixa.NSA = Orcamento.NSA_Queixa
                    LEFT JOIN Devolucao ON Queixa.NSA = Devolucao.NSA_Queixa
                    WHERE
                        Utilizador.NIF LIKE @valor
                        OR Utilizador.NIFEE LIKE @valor
                        OR Utilizador.Processo LIKE @valor;";


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
                                    reader.IsDBNull(reader.GetOrdinal("Nome_Utilizador")) ? "" : reader.GetString(reader.GetOrdinal("Nome_Utilizador")),
                                    reader.IsDBNull(reader.GetOrdinal("Processo")) ? "" : reader.GetInt32(reader.GetOrdinal("Processo")).ToString(),
                                    reader.IsDBNull(reader.GetOrdinal("NIFEE")) ? "" : reader.GetString(reader.GetOrdinal("NIFEE")),
                                    reader.IsDBNull(reader.GetOrdinal("NomeEE")) ? "" : reader.GetString(reader.GetOrdinal("NomeEE")),
                                    reader.IsDBNull(reader.GetOrdinal("EmailEE")) ? "" : reader.GetString(reader.GetOrdinal("EmailEE")),
                                    reader.IsDBNull(reader.GetOrdinal("Parentesco")) ? "" : reader.GetString("Parentesco"),
                                    reader.IsDBNull(reader.GetOrdinal("Tipo")) ? "" : reader.GetString("Tipo"),
                                    reader.IsDBNull(reader.GetOrdinal("NSA")) ? "" : reader.GetInt32(reader.GetOrdinal("NSA")).ToString(),
                                    reader.IsDBNull(reader.GetOrdinal("TipoEquip")) ? "" : reader.GetString(reader.GetOrdinal("TipoEquip")),
                                    reader.IsDBNull(reader.GetOrdinal("N-S")) ? "" : reader.GetString(reader.GetOrdinal("N-S")),
                                    reader.IsDBNull(reader.GetOrdinal("DtQueixa")) ? "" : reader.GetDateTime(reader.GetOrdinal("DtQueixa")).ToString("yyyy-MM-dd"),
                                    reader.IsDBNull(reader.GetOrdinal("Descricao")) ? "" : reader.GetString(reader.GetOrdinal("Descricao")),
                                    reader.IsDBNull(reader.GetOrdinal("Decisao")) ? "" : reader.GetString(reader.GetOrdinal("Decisao")),
                                    reader.IsDBNull(reader.GetOrdinal("DtEntrada_EquipRecebido")) ? "" : reader.GetDateTime(reader.GetOrdinal("DtEntrada_EquipRecebido")).ToString("yyyy-MM-dd"),
                                    reader.IsDBNull(reader.GetOrdinal("TipoEquip_EquipRecebido")) ? "" : reader.GetString(reader.GetOrdinal("TipoEquip_EquipRecebido")),
                                    reader.IsDBNull(reader.GetOrdinal("Ref_Quei_Empr")) ? "" : reader.GetString(reader.GetOrdinal("Ref_Quei_Empr")),
                                    reader.IsDBNull(reader.GetOrdinal("DtContact")) ? "" : reader.GetDateTime(reader.GetOrdinal("DtContact")).ToString("yyyy-MM-dd"),
                                    reader.IsDBNull(reader.GetOrdinal("HrContacto")) ? "" : reader.GetString(reader.GetOrdinal("HrContacto")),
                                    reader.IsDBNull(reader.GetOrdinal("Resumo_Contacto")) ? "" : reader.GetString(reader.GetOrdinal("Resumo_Contacto")),
                                    reader.IsDBNull(reader.GetOrdinal("Forma")) ? "" : reader.GetString(reader.GetOrdinal("Forma")),
                                    reader.IsDBNull(reader.GetOrdinal("InfoContacto")) ? "" : reader.GetString(reader.GetOrdinal("InfoContacto")),
                                    reader.IsDBNull(reader.GetOrdinal("Referencia")) ? "" : reader.GetInt32(reader.GetOrdinal("Referencia")).ToString(),
                                    reader.IsDBNull(reader.GetOrdinal("DtEnvio")) ? "" : reader.GetDateTime(reader.GetOrdinal("DtEnvio")).ToString("yyyy-MM-dd"),
                                    reader.IsDBNull(reader.GetOrdinal("NSA_Transp")) ? "" : reader.GetInt32(reader.GetOrdinal("NSA_Transp")).ToString(),
                                    reader.IsDBNull(reader.GetOrdinal("DtOrcamento")) ? "" : reader.GetDateTime(reader.GetOrdinal("DtOrcamento")).ToString("yyyy-MM-dd"),
                                    reader.IsDBNull(reader.GetOrdinal("Comunicado")) ? "" : reader.GetString(reader.GetOrdinal("Comunicado")),
                                    reader.IsDBNull(reader.GetOrdinal("FormaCom")) ? "" : reader.GetString(reader.GetOrdinal("FormaCom")),
                                    reader.IsDBNull(reader.GetOrdinal("Resumo_Orcamento")) ? "" : reader.GetString(reader.GetOrdinal("Resumo_Orcamento")),
                                    reader.IsDBNull(reader.GetOrdinal("Resposta")) ? "" : reader.GetString(reader.GetOrdinal("Resposta")),
                                    reader.IsDBNull(reader.GetOrdinal("DtResposta")) ? "" : reader.GetDateTime(reader.GetOrdinal("DtResposta")).ToString("yyyy-MM-dd"),
                                    reader.IsDBNull(reader.GetOrdinal("Pago")) ? "" : reader.GetString(reader.GetOrdinal("Pago")),
                                    reader.IsDBNull(reader.GetOrdinal("DtPagamento")) ? "" : reader.GetDateTime(reader.GetOrdinal("DtPagamento")).ToString("yyyy-MM-dd"),
                                    reader.IsDBNull(reader.GetOrdinal("DtDevolucao")) ? "" : reader.GetDateTime(reader.GetOrdinal("DtDevolucao")).ToString("yyyy-MM-dd"),
                                    reader.IsDBNull(reader.GetOrdinal("DtEntrega")) ? "" : reader.GetDateTime(reader.GetOrdinal("DtEntrega")).ToString("yyyy-MM-dd")
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
                MessageBox.Show("Erro ao executar a busca pela avaria - método BuscarNaBD: " + ex.Message);
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
