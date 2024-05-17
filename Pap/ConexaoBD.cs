using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pap
{
    static class ConexaoBD
    {
        private const string servidor = "localhost";
        private const string basedados = "gestao_de_avaria";
        private const string Utilizador = "root";
        private const string senha = "292822";

        static public string basededados = $"server = {servidor}; user id = {Utilizador}; database = {basedados}; password = {senha}";
    }
}
