using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pap
{
    internal class InserirEnvio
    {
        private int referencia;
        private int nsaQueixa;
        private DateTime dtEnvio;
        private int nsaTransp;

        public int Referencia
        {
            get { return referencia; }
            set { referencia = value; }
        }

        public int NSAQueixa
        {
            get { return nsaQueixa; }
            set { nsaQueixa = value; }
        }

        public DateTime DtEnvio
        {
            get { return dtEnvio; }
            set { dtEnvio = value; }
        }

        public int NSATransp
        {
            get { return nsaTransp; }
            set { nsaTransp = value; }
        }

        public bool inserirEnvio()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(ConexaoBD.basededados))
                {
                    conexao.Open();

                    string insert = "INSERT INTO Envio (Referencia, NSA_Queixa, DtEnvio, NSA_Transp) " +
                                    "VALUES (@Referencia, @NSAQueixa, @DtEnvio, @NSATransp)";

                    using (MySqlCommand comandoSql = new MySqlCommand(insert, conexao))
                    {
                        comandoSql.Parameters.AddWithValue("@Referencia", Referencia);
                        comandoSql.Parameters.AddWithValue("@NSAQueixa", NSAQueixa);
                        comandoSql.Parameters.AddWithValue("@DtEnvio", DtEnvio.Date);
                        comandoSql.Parameters.AddWithValue("@NSATransp", NSATransp);

                        comandoSql.ExecuteNonQuery();
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir envio: " + ex.Message);
                return false;
            }
        }
    }
}
