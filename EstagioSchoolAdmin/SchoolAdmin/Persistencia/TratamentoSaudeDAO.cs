using Npgsql;
using SchoolAdmin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Persistencia
{
    class TratamentoSaudeDAO
    {
        private NpgsqlConnection conexao;

        public NpgsqlConnection Conexao
        {
            get
            {
                return conexao;
            }
        }

        public TratamentoSaudeDAO()
        {
            conexao = Persistencia.Conexao.getInstance().conexaoBD();
        }

        public bool Inserir(TratamentoSaude tratamento)
        {
            string stringSQL = "insert into tratamentos_saude (trat_descricao) values (@descricao)";

            NpgsqlCommand cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);
            this.Conexao.Open();

            cmdIncluir.Parameters.AddWithValue("@descricao", tratamento.Descricao);

            cmdIncluir.ExecuteNonQuery();
            this.Conexao.Close();

            return true;
        }

        public bool Alterar(TratamentoSaude tratamento)
        {
            string stringSQL = "update tratamentos_saude set trat_descricao=@descricao where trat_pk=@codigo";

            NpgsqlCommand cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);
            this.Conexao.Open();

            cmdIncluir.Parameters.AddWithValue("@descricao", tratamento.Descricao);
            cmdIncluir.Parameters.AddWithValue("@codigo", tratamento.Id);

            cmdIncluir.ExecuteNonQuery();
            this.Conexao.Close();

            return true;
        }

        public List<TratamentoSaude> GetLista()
        {
            List<TratamentoSaude> lista = null;
            string stringSQL = "select trat_pk, trat_descricao from tratamentos_saude";

            NpgsqlCommand cmdConsultar = new NpgsqlCommand(stringSQL, this.Conexao);
            this.Conexao.Open();

            NpgsqlDataReader resultado = cmdConsultar.ExecuteReader();

            if (resultado.HasRows)
            {
                lista = new List<TratamentoSaude>();
                while (resultado.Read())
                {
                    TratamentoSaude trat = new TratamentoSaude();
                    trat.Id = resultado.GetInt32(0);
                    trat.Descricao = resultado.GetString(1);

                    lista.Add(trat);
                }
            }
            resultado.Close();
            this.Conexao.Close();

            return lista;
        }

        public List<TratamentoSaude> Consultar(string descricao)
        {
            List<TratamentoSaude> lista = new List<TratamentoSaude>();
            string stringSQL = "select " +
                "trat_pk, trat_descricao " +
              "from tratamentos_saude where trat_descricao ilike @descricao";

            NpgsqlCommand cmdConsultar = new NpgsqlCommand(stringSQL, this.Conexao);
            this.Conexao.Open();
            cmdConsultar.Parameters.AddWithValue("@descricao", "%" + descricao + "%");

            NpgsqlDataReader resultado = cmdConsultar.ExecuteReader();

            if (resultado.HasRows)
            {
                lista = new List<TratamentoSaude>();
                while (resultado.Read())
                {
                    TratamentoSaude trat = new TratamentoSaude();
                    trat.Id = resultado.GetInt32(0);
                    trat.Descricao = resultado.GetString(1);

                    lista.Add(trat);
                }
            }
            resultado.Close();
            this.Conexao.Close();

            return lista;
        }

        public bool Excluir(int tratamento_id)
        {
            string stringSQL = "delete from tratamentos_saude where trat_pk=@codigo";

            NpgsqlCommand cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);
            this.Conexao.Open();

            cmdIncluir.Parameters.AddWithValue("@codigo", tratamento_id);

            cmdIncluir.ExecuteNonQuery();
            this.Conexao.Close();

            return true;
        }
    }
}
