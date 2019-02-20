using Npgsql;
using SchoolAdmin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Persistencia
{
    class FraturaDAO
    {
        private NpgsqlConnection conexao;

        public NpgsqlConnection Conexao
        {
            get
            {
                return conexao;
            }
        }

        public FraturaDAO()
        {
            conexao = Persistencia.Conexao.getInstance().conexaoBD();
        }

        public bool Inserir(Fratura fratura)
        {
            string stringSQL = "insert into fraturas (frat_descricao) values (@descricao)";

            NpgsqlCommand cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);
            this.Conexao.Open();

            cmdIncluir.Parameters.AddWithValue("@descricao", fratura.Descricao);

            cmdIncluir.ExecuteNonQuery();
            this.Conexao.Close();

            return true;
        }

        public bool Alterar(Fratura fratura)
        {
            string stringSQL = "update fraturas set frat_descricao=@descricao where frat_pk=@codigo";

            NpgsqlCommand cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);
            this.Conexao.Open();

            cmdIncluir.Parameters.AddWithValue("@descricao", fratura.Descricao);
            cmdIncluir.Parameters.AddWithValue("@codigo", fratura.Id);

            cmdIncluir.ExecuteNonQuery();
            this.Conexao.Close();

            return true;
        }

        public List<Fratura> GetLista()
        {
            List<Fratura> lista = null;
            string stringSQL = "select frat_pk, frat_descricao from fraturas";

            NpgsqlCommand cmdConsultar = new NpgsqlCommand(stringSQL, this.Conexao);
            this.Conexao.Open();

            NpgsqlDataReader resultado = cmdConsultar.ExecuteReader();

            if (resultado.HasRows)
            {
                lista = new List<Fratura>();
                while (resultado.Read())
                {
                    Fratura frat = new Fratura();
                    frat.Id = resultado.GetInt32(0);
                    frat.Descricao = resultado.GetString(1);

                    lista.Add(frat);
                }
            }
            resultado.Close();
            this.Conexao.Close();

            return lista;
        }

        public List<Fratura> Consultar(string descricao)
        {
            List<Fratura> lista = new List<Fratura>();
            string stringSQL = "select " +
                "frat_pk, frat_descricao " +
              "from fraturas where frat_descricao ilike @descricao";

            NpgsqlCommand cmdConsultar = new NpgsqlCommand(stringSQL, this.Conexao);
            this.Conexao.Open();
            cmdConsultar.Parameters.AddWithValue("@descricao", "%" + descricao + "%");

            NpgsqlDataReader resultado = cmdConsultar.ExecuteReader();

            if (resultado.HasRows)
            {
                lista = new List<Fratura>();
                while (resultado.Read())
                {
                    Fratura frat = new Fratura();
                    frat.Id = resultado.GetInt32(0);
                    frat.Descricao = resultado.GetString(1);

                    lista.Add(frat);
                }
            }
            resultado.Close();
            this.Conexao.Close();

            return lista;
        }

        public bool Excluir(int fratura_id)
        {
            string stringSQL = "delete from fraturas where frat_pk=@codigo";

            NpgsqlCommand cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);
            this.Conexao.Open();

            cmdIncluir.Parameters.AddWithValue("@codigo", fratura_id);

            cmdIncluir.ExecuteNonQuery();
            this.Conexao.Close();

            return true;
        }
    }
}
