using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pap
{
    internal class InserirOrcamento
    {
        private int nsaQueixa;
        private DateTime dtOrcamento;
        private string comunicado;
        private string formaCom;
        private string resumo;
        private string resposta;
        private DateTime? dtResposta; // Nullable DateTime
        private string pago;
        private DateTime? dtPagamento; // Nullable DateTime

        public int NSA_Queixa
        {
            get { return nsaQueixa; }
            set { nsaQueixa = value; }
        }

        public DateTime DtOrcamento
        {
            get { return dtOrcamento; }
            set { dtOrcamento = value; }
        }

        public string Comunicado
        {
            get { return comunicado; }
            set { comunicado = value; }
        }

        public string FormaCom
        {
            get { return formaCom; }
            set { formaCom = value; }
        }

        public string Resumo
        {
            get { return resumo; }
            set { resumo = value; }
        }

        public string Resposta
        {
            get { return resposta; }
            set { resposta = value; }
        }

        public DateTime? DtResposta
        {
            get { return dtResposta; }
            set { dtResposta = value; }
        }

        public string Pago
        {
            get { return pago; }
            set { pago = value; }
        }

        public DateTime? DtPagamento
        {
            get { return dtPagamento; }
            set { dtPagamento = value; }
        }

        public bool inserirOrcamento()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(ConexaoBD.basededados))
                {
                    conexao.Open();

                    string insert = "INSERT INTO Orcamento (NSA_Queixa, DtOrcamento, Comunicado, FormaCom, Resumo, Resposta, DtResposta, Pago, DtPagamento) " +
                                    "VALUES (@NSA_Queixa, @DtOrcamento, @Comunicado, @FormaCom, @Resumo, @Resposta, @DtResposta, @Pago, @DtPagamento)";

                    using (MySqlCommand comandoSql = new MySqlCommand(insert, conexao))
                    {
                        comandoSql.Parameters.AddWithValue("@NSA_Queixa", NSA_Queixa == 0 ? (object)DBNull.Value : NSA_Queixa);
                        comandoSql.Parameters.AddWithValue("@DtOrcamento", DtOrcamento.Date);
                        comandoSql.Parameters.AddWithValue("@Comunicado", string.IsNullOrEmpty(Comunicado) ? (object)DBNull.Value : Comunicado);
                        comandoSql.Parameters.AddWithValue("@FormaCom", FormaCom);
                        comandoSql.Parameters.AddWithValue("@Resumo", string.IsNullOrEmpty(Resumo) ? (object)DBNull.Value : Resumo);
                        comandoSql.Parameters.AddWithValue("@Resposta", string.IsNullOrEmpty(Resposta) ? (object)DBNull.Value : Resposta);
                        comandoSql.Parameters.AddWithValue("@DtResposta", DtResposta.HasValue ? (object)DtResposta.Value.Date : (object)DBNull.Value);
                        comandoSql.Parameters.AddWithValue("@Pago", Pago);
                        comandoSql.Parameters.AddWithValue("@DtPagamento", DtPagamento.HasValue ? (object)DtPagamento.Value.Date : (object)DBNull.Value);

                        comandoSql.ExecuteNonQuery();
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir orcamento: " + ex.Message);
                return false;
            }
        }

    }
}
