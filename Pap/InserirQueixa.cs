using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pap
{
    internal class InserirQueixa
    {
        private string nifUtilizador;
        private string tipoEquip;
        private string n_s;
        private DateTime dataQueixa;
        private string descricao;
        private string decisao;

        public string NIFUtilizador
        {
            get { return nifUtilizador; }
            set { nifUtilizador = value; }
        }

        public string TipoEquip
        {
            get { return tipoEquip; }
            set { tipoEquip = value; }
        }

        public string NS
        {
            get { return n_s; }
            set { n_s = value; }
        }

        public DateTime DataQueixa
        {
            get { return dataQueixa; }
            set { dataQueixa = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public string Decisao
        {
            get { return decisao; }
            set { decisao = value; }
        }

        public bool inserirQueixa()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(ConexaoBD.basededados))
                {
                    conexao.Open();

                    string insert = "INSERT INTO Queixa (NIF_Utilizador, TipoEquip, `N-S`, DtQueixa, Descricao, Decisao) " +
                                    "VALUES (@NIFUtilizador, @TipoEquip, @NS, @DataQueixa, @Descricao, @Decisao)";

                    using (MySqlCommand comandoSql = new MySqlCommand(insert, conexao))
                    {
                        comandoSql.Parameters.AddWithValue("@NIFUtilizador", NIFUtilizador);
                        comandoSql.Parameters.AddWithValue("@TipoEquip", string.IsNullOrEmpty(TipoEquip) ? (object)DBNull.Value : TipoEquip);
                        comandoSql.Parameters.AddWithValue("@NS", NS);
                        comandoSql.Parameters.AddWithValue("@DataQueixa", DataQueixa.Date);
                        comandoSql.Parameters.AddWithValue("@Descricao", Descricao);
                        comandoSql.Parameters.AddWithValue("@Decisao", string.IsNullOrEmpty(Decisao) ? (object)DBNull.Value : Decisao);

                        comandoSql.ExecuteNonQuery();
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir queixa: " + ex.Message);
                return false;
            }
        }
    }
}
