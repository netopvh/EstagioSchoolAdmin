using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace SchoolAdmin.Persistencia
{
    sealed class Conexao
    {
        private static Conexao instancia;

        private static string serverName = "127.0.0.1";
        private static string port = "5432";
        private static string userName = "postgres";
        private static string password = "postgres123";
        private static string databaseName = "estagio";
        private static NpgsqlConnection conn = null;

        private string connString = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};", serverName, port, userName, password, databaseName);

        private Conexao()
        {
            conn = new NpgsqlConnection(connString);
        }

        public static Conexao getInstance()
        {
            if (instancia == null)
            {
                instancia = new Conexao();
                return instancia;
            }
            else
            {
                return instancia;
            }
        }

        public NpgsqlConnection conexaoBD()
        {
            return conn;
        }
    }
}
