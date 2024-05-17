﻿using System;
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

        // método para inserir responsavel

        public bool inserirResponsavel()
        {
            MySqlConnection MysqlConexaoBasedeDados = null;

            try
            {
                MySqlConnection ConexaoBasedeDados = new MySqlConnection(ConexaoBD.basededados);
                ConexaoBasedeDados.Open();

                string insert = $" insert into utilizador (nif,nome,processo,nifEE,nomeEE,emailEE) values " +
                    $"('{NIF}','{Nome}','{Processo}','{NIFEE}','{NomeEE}','{EmailEE}')";

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
                if (MysqlConexaoBasedeDados != null && MysqlConexaoBasedeDados.State != ConnectionState.Closed)
                {
                    MysqlConexaoBasedeDados.Close();
                }
            }
        }
    }
}