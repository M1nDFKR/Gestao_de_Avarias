using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pap
{
    internal class InserirEquipamento
    {
        private string n_s;
        private DateTime dtEntrada;
        private string tipoEquip;
        private int? nsaQueixa;
        private string refQueiEmpr;

        public string NS
        {
            get { return n_s; }
            set { n_s = value; }
        }

        public DateTime DtEntrada
        {
            get { return dtEntrada; }
            set { dtEntrada = value; }
        }

        public string TipoEquip
        {
            get { return tipoEquip; }
            set { tipoEquip = value; }
        }

        public int? NSAQueixa
        {
            get { return nsaQueixa; }
            set { nsaQueixa = value; }
        }

        public string RefQueiEmpr
        {
            get { return refQueiEmpr; }
            set { refQueiEmpr = value; }
        }

        public bool Inserir()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(ConexaoBD.basededados))
                {
                    conexao.Open();

                    string insert = "INSERT INTO EquipRecebido (`N-S`, DtEntrada, TipoEquip, NSA_Queixa, Ref_Quei_Empr) " +
                                    "VALUES (@NS, @DtEntrada, @TipoEquip, @NSAQueixa, @RefQueiEmpr)";

                    using (MySqlCommand comandoSql = new MySqlCommand(insert, conexao))
                    {
                        comandoSql.Parameters.AddWithValue("@NS", NS);
                        comandoSql.Parameters.AddWithValue("@DtEntrada", DtEntrada.Date);
                        comandoSql.Parameters.AddWithValue("@TipoEquip", string.IsNullOrEmpty(TipoEquip) ? (object)DBNull.Value : TipoEquip);
                        comandoSql.Parameters.AddWithValue("@NSAQueixa", NSAQueixa.HasValue ? (object)NSAQueixa.Value : DBNull.Value);
                        comandoSql.Parameters.AddWithValue("@RefQueiEmpr", string.IsNullOrEmpty(RefQueiEmpr) ? (object)DBNull.Value : RefQueiEmpr);

                        comandoSql.ExecuteNonQuery();
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir equipamento recebido: " + ex.Message);
                return false;
            }
        }
    }
}
