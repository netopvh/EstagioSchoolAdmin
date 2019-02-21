using Npgsql;
using SchoolAdmin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Persistencia
{
    public class NecessidadeEspecialDAO
    {
        private NpgsqlConnection conexao;

        public NpgsqlConnection Conexao
        {
            get
            {
                return conexao;
            }
        }

        public NecessidadeEspecialDAO()
        {
            conexao = Persistencia.Conexao.getInstance().conexaoBD();
        }

        public bool Inserir(NecessidadeEspecial necessidade)
        {
            string stringSQL = "insert into necessidades_especiais (nec_descricao) values (@descricao)";

            NpgsqlCommand cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);
            this.Conexao.Open();

            cmdIncluir.Parameters.AddWithValue("@descricao", necessidade.Descricao);

            cmdIncluir.ExecuteNonQuery();
            this.Conexao.Close();

            return true;
        }

        public bool Alterar(NecessidadeEspecial necessidade)
        {
            string stringSQL = "update necessidades_especiais set nec_descricao=@descricao where nec_pk=@codigo";

            NpgsqlCommand cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);
            this.Conexao.Open();

            cmdIncluir.Parameters.AddWithValue("@descricao", necessidade.Descricao);
            cmdIncluir.Parameters.AddWithValue("@codigo", necessidade.Id);

            cmdIncluir.ExecuteNonQuery();
            this.Conexao.Close();

            return true;
        }

        public List<NecessidadeEspecial> GetLista()
        {
            List<NecessidadeEspecial> lista = null;
            string stringSQL = "select nec_pk, nec_descricao from necessidades_especiais";

            NpgsqlCommand cmdConsultar = new NpgsqlCommand(stringSQL, this.Conexao);
            this.Conexao.Open();

            NpgsqlDataReader resultado = cmdConsultar.ExecuteReader();

            if (resultado.HasRows)
            {
                lista = new List<NecessidadeEspecial>();
                while (resultado.Read())
                {
                    NecessidadeEspecial nec = new NecessidadeEspecial();
                    nec.Id = resultado.GetInt32(0);
                    nec.Descricao = resultado.GetString(1);

                    lista.Add(nec);
                }
            }
            resultado.Close();
            this.Conexao.Close();

            return lista;
        }

        public List<NecessidadeEspecial> Consultar(string descricao)
        {
            List<NecessidadeEspecial> lista = new List<NecessidadeEspecial>();
            string stringSQL = "select " +
                "nec_pk, nec_descricao " +
              "from necessidades_especiais where nec_descricao ilike @descricao";

            NpgsqlCommand cmdConsultar = new NpgsqlCommand(stringSQL, this.Conexao);
            this.Conexao.Open();
            cmdConsultar.Parameters.AddWithValue("@descricao", "%" + descricao + "%");

            NpgsqlDataReader resultado = cmdConsultar.ExecuteReader();

            if (resultado.HasRows)
            {
                lista = new List<NecessidadeEspecial>();
                while (resultado.Read())
                {
                    NecessidadeEspecial nec = new NecessidadeEspecial();
                    nec.Id = resultado.GetInt32(0);
                    nec.Descricao = resultado.GetString(1);

                    lista.Add(nec);
                }
            }
            resultado.Close();
            this.Conexao.Close();

            return lista;
        }

        public bool Excluir(int necessidade_id)
        {
            string stringSQL = "delete from necessidades_especiais where nec_pk=@codigo";

            NpgsqlCommand cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);
            this.Conexao.Open();

            cmdIncluir.Parameters.AddWithValue("@codigo", necessidade_id);

            cmdIncluir.ExecuteNonQuery();
            this.Conexao.Close();

            return true;
        }
    }
}
