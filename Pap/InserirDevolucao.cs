using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Pap
{
    internal class InserirDevolucao
    {
        private int nsaQueixa;
        private DateTime dtDevolucao;
        private DateTime dtEntrega;
        private string nifUtilizador;
        private string nifEE;

        public int NSA_Queixa
        {
            get { return nsaQueixa; }
            set { nsaQueixa = value; }
        }

        public DateTime DtDevolucao
        {
            get { return dtDevolucao; }
            set { dtDevolucao = value; }
        }

        public DateTime DtEntrega
        {
            get { return dtEntrega; }
            set { dtEntrega = value; }
        }

        public string NIF_Utilizador
        {
            get { return nifUtilizador; }
            set { nifUtilizador = value; }
        }

        public string NIFEE
        {
            get { return nifEE; }
            set { nifEE = value; }
        }

        public bool inserirDevolucao()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(ConexaoBD.basededados))
                {
                    conexao.Open();

                    string insert = "INSERT INTO Devolucao (NSA_Queixa, DtDevolucao, DtEntrega, NIF_Utilizador, NIFEE) " +
                                    "VALUES (@NSA_Queixa, @DtDevolucao, @DtEntrega, @NIF_Utilizador, @NIFEE)";

                    using (MySqlCommand comandoSql = new MySqlCommand(insert, conexao))
                    {
                        comandoSql.Parameters.AddWithValue("@NSA_Queixa", NSA_Queixa);
                        comandoSql.Parameters.AddWithValue("@DtDevolucao", DtDevolucao.Date);
                        comandoSql.Parameters.AddWithValue("@DtEntrega", DtEntrega.Date);
                        comandoSql.Parameters.AddWithValue("@NIF_Utilizador", NIF_Utilizador);
                        comandoSql.Parameters.AddWithValue("@NIFEE", NIFEE);

                        comandoSql.ExecuteNonQuery();
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir devolução: " + ex.Message);
                return false;
            }
        }
    }
}
