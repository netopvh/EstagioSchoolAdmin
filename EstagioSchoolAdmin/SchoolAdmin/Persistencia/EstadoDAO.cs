using Npgsql;
using SchoolAdmin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Persistencia
{
    class EstadoDAO
    {
        private NpgsqlConnection conexao;

        public NpgsqlConnection Conexao
        {
            get
            {
                return conexao;
            }
        }

        public EstadoDAO()
        {
            conexao = Persistencia.Conexao.getInstance().conexaoBD();
        }

        public bool Inserir(Estado estado)
        {
            string stringSQL = "insert into estados(est_nome, est_sigla) values (@nome, @sigla)";

            NpgsqlCommand cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);
            this.Conexao.Open();

            cmdIncluir.Parameters.AddWithValue("@nome", estado.Nome);
            cmdIncluir.Parameters.AddWithValue("@sigla", estado.Sigla);

            cmdIncluir.ExecuteNonQuery();
            this.Conexao.Close();

            return true;
        }

        public bool Alterar(Estado estado)
        {
            string stringSQL = "update estados set est_nome=@nome, est_sigla=@sigla where est_pk=@codigo";

            NpgsqlCommand cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);
            this.Conexao.Open();

            cmdIncluir.Parameters.AddWithValue("@nome", estado.Nome);
            cmdIncluir.Parameters.AddWithValue("@sigla", estado.Sigla);
            cmdIncluir.Parameters.AddWithValue("@codigo", estado.Id);

            cmdIncluir.ExecuteNonQuery();
            this.Conexao.Close();

            return true;
        }

        public List<Estado> GetLista()
        {
            List<Estado> lista = new List<Estado>();
            string stringSQL = "select est_pk, est_nome, est_sigla from estados";

            NpgsqlCommand cmdConsultar = new NpgsqlCommand(stringSQL, this.Conexao);
            this.Conexao.Open();

            NpgsqlDataReader resultado = cmdConsultar.ExecuteReader();

            if (resultado.HasRows)
            {
                lista = new List<Estado>();
                while (resultado.Read())
                {
                    Estado est = new Estado();
                    est.Id = resultado.GetInt32(0);
                    est.Nome = resultado.GetString(1);
                    est.Sigla = resultado.GetString(2);

                    lista.Add(est);
                }
            }
            resultado.Close();
            this.Conexao.Close();

            return lista;
        }

        public List<Estado> Consultar(string nome)
        {
            List<Estado> lista = new List<Estado>();
            string stringSQL = "select " +
                "est_pk, est_nome, est_sigla " +
              "from estados where est_nome ilike @nome";

            NpgsqlCommand cmdConsultar = new NpgsqlCommand(stringSQL, this.Conexao);
            this.Conexao.Open();
            cmdConsultar.Parameters.AddWithValue("@nome", "%" + nome + "%");

            NpgsqlDataReader resultado = cmdConsultar.ExecuteReader();

            if (resultado.HasRows)
            {
                lista = new List<Estado>();
                while (resultado.Read())
                {

                    Estado est = new Estado();
                    est.Id = resultado.GetInt32(0);
                    est.Nome = resultado.GetString(1);
                    est.Sigla = resultado.GetString(2);

                    lista.Add(est);
                }
            }
            resultado.Close();
            this.Conexao.Close();

            return lista;
        }

        public bool Excluir(int estado_id)
        {
            string stringSQL = "delete from estados where org_pk=@codigo";

            NpgsqlCommand cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);
            this.Conexao.Open();

            cmdIncluir.Parameters.AddWithValue("@codigo", estado_id);

            cmdIncluir.ExecuteNonQuery();
            this.Conexao.Close();

            return true;
        }
    }
}
