using Npgsql;
using SchoolAdmin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Persistencia
{
    class OrigemContaAPagarDAO
    {
        private NpgsqlConnection conexao;

        public NpgsqlConnection Conexao
        {
            get
            {
                return conexao;
            }
        }

        public OrigemContaAPagarDAO()
        {
            conexao = Persistencia.Conexao.getInstance().conexaoBD();
        }

        public bool Inserir(OrigemContaAPagar origem)
        {
            string stringSQL = "insert into origens_conta (org_descricao) values (@descricao)";

            NpgsqlCommand cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);
            this.Conexao.Open();

            cmdIncluir.Parameters.AddWithValue("@descricao", origem.Descricao);

            cmdIncluir.ExecuteNonQuery();
            this.Conexao.Close();

            return true;
        }

        public bool Alterar(OrigemContaAPagar origem)
        {
            string stringSQL = "update origens_conta set org_descricao=@descricao where org_pk=@codigo";

            NpgsqlCommand cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);
            this.Conexao.Open();

            cmdIncluir.Parameters.AddWithValue("@descricao", origem.Descricao);
            cmdIncluir.Parameters.AddWithValue("@codigo", origem.Id);

            cmdIncluir.ExecuteNonQuery();
            this.Conexao.Close();

            return true;
        }

        public List<OrigemContaAPagar> GetLista()
        {
            List<OrigemContaAPagar> lista = new List<OrigemContaAPagar>();
            string stringSQL = "select org_pk, org_descricao from origens_conta";

            NpgsqlCommand cmdConsultar = new NpgsqlCommand(stringSQL, this.Conexao);
            this.Conexao.Open();

            NpgsqlDataReader resultado = cmdConsultar.ExecuteReader();

            if (resultado.HasRows)
            {
                lista = new List<OrigemContaAPagar>();
                while (resultado.Read())
                {
                    OrigemContaAPagar org = new OrigemContaAPagar();
                    org.Id = resultado.GetInt32(0);
                    org.Descricao = resultado.GetString(1);

                    lista.Add(org);
                }
            }
            resultado.Close();
            this.Conexao.Close();

            return lista;
        }

        public List<OrigemContaAPagar> Consultar(string descricao)
        {
            List<OrigemContaAPagar> lista = new List<OrigemContaAPagar>();
            string stringSQL = "select " +
                "org_pk, org_descricao " +
              "from origens_conta where org_descricao ilike @nome";

            NpgsqlCommand cmdConsultar = new NpgsqlCommand(stringSQL, this.Conexao);
            this.Conexao.Open();
            cmdConsultar.Parameters.AddWithValue("@nome", "%" + descricao + "%");

            NpgsqlDataReader resultado = cmdConsultar.ExecuteReader();

            if (resultado.HasRows)
            {
                lista = new List<OrigemContaAPagar>();
                while (resultado.Read())
                {
                    OrigemContaAPagar org = new OrigemContaAPagar();
                    org.Id = resultado.GetInt32(0);
                    org.Descricao = resultado.GetString(1);

                    lista.Add(org);
                }
            }
            resultado.Close();
            this.Conexao.Close();

            return lista;
        }

        public bool Excluir(int origem_id)
        {
            string stringSQL = "delete from origens_conta where org_pk=@codigo";

            NpgsqlCommand cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);
            this.Conexao.Open();

            cmdIncluir.Parameters.AddWithValue("@codigo", origem_id);

            cmdIncluir.ExecuteNonQuery();
            this.Conexao.Close();

            return true;
        }
    }
}
