using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pap
{

    internal class InserirContacto
    {
        private int nsaEmpresa;
        private DateTime dtContact;
        private TimeSpan hrContacto;
        private string resumo;
        private string forma;
        private string infoContacto;
        private int nsaQueixa;
        private string nifUtilizador;

        public int NSA_Empresa
        {
            get { return nsaEmpresa; }
            set { nsaEmpresa = value; }
        }

        public DateTime DtContact
        {
            get { return dtContact; }
            set { dtContact = value; }
        }

        public TimeSpan HrContacto
        {
            get { return hrContacto; }
            set { hrContacto = value; }
        }

        public string Resumo
        {
            get { return resumo; }
            set { resumo = value; }
        }

        public string Forma
        {
            get { return forma; }
            set { forma = value; }
        }

        public string InfoContacto
        {
            get { return infoContacto; }
            set { infoContacto = value; }
        }

        public int NSA_Queixa
        {
            get { return nsaQueixa; }
            set { nsaQueixa = value; }
        }

        public string NIF_Utilizador
        {
            get { return nifUtilizador; }
            set { nifUtilizador = value; }
        }

        public bool inserirContacto()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(ConexaoBD.basededados))
                {
                    conexao.Open();

                    string insert = "INSERT INTO Contacto (`NSA-Empresa`, DtContact, HrContacto, Resumo, Forma, InfoContacto, NSA_Queixa, NIF_Utilizador) " +
                                    "VALUES (@NSAEmpresa, @DtContact, @HrContacto, @Resumo, @Forma, @InfoContacto, @NSA_Queixa, @NIF_Utilizador)";

                    using (MySqlCommand comandoSql = new MySqlCommand(insert, conexao))
                    {
                        comandoSql.Parameters.AddWithValue("@NSAEmpresa", NSA_Empresa == 0 ? (object)DBNull.Value : NSA_Empresa);
                        comandoSql.Parameters.AddWithValue("@DtContact", DtContact.Date);
                        comandoSql.Parameters.AddWithValue("@HrContacto", HrContacto);
                        comandoSql.Parameters.AddWithValue("@Resumo", string.IsNullOrEmpty(Resumo) ? (object)DBNull.Value : Resumo);
                        comandoSql.Parameters.AddWithValue("@Forma", Forma);
                        comandoSql.Parameters.AddWithValue("@InfoContacto", string.IsNullOrEmpty(InfoContacto) ? (object)DBNull.Value : InfoContacto);
                        comandoSql.Parameters.AddWithValue("@NSA_Queixa", NSA_Queixa);
                        comandoSql.Parameters.AddWithValue("@NIF_Utilizador", NIF_Utilizador);

                        comandoSql.ExecuteNonQuery();
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir contacto: " + ex.Message);
                return false;
            }
        }
    }
}
