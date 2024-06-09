using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Pap
{
    internal class Inserir
    {
        private string nif;
        private string nome;
        private int processo;
        private string nifEE;
        private string nomeEE;
        private string emailEE;
        private string parentesco;
        private string tipo;

        public string NIF
        {
            get { return nif; }
            set { nif = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Processo
        {
            get { return processo; }
            set { processo = value; }
        }

        public string NIFEE
        {
            get { return nifEE; }
            set { nifEE = value; }
        }

        public string NomeEE
        {
            get { return nomeEE; }
            set { nomeEE = value; }
        }

        public string EmailEE
        {
            get { return emailEE; }
            set { emailEE = value; }
        }

        public string Parentesco
        {
            get { return parentesco; }
            set { parentesco = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        // método para inserir responsavel

        public bool inserirResponsavel()
        { 

            try
            {
                MySqlConnection ConexaoBasedeDados = new MySqlConnection(ConexaoBD.basededados);
                ConexaoBasedeDados.Open();

                string insert = $" insert into utilizador (nif,nome,processo,nifEE,nomeEE,emailEE,parentesco,tipo) values " +
                    $"('{NIF}','{Nome}','{Processo}','{NIFEE}','{NomeEE}','{EmailEE}','{Parentesco}','{Tipo}')";

                MySqlCommand comandoSql = ConexaoBasedeDados.CreateCommand();
                comandoSql.CommandText = insert;

                comandoSql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir responsável pela avaria - método inserirResponsavel: " + ex.Message);
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