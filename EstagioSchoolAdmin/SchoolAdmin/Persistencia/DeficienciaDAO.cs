using Npgsql;
using SchoolAdmin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Persistencia
{
    public class DeficienciaDAO
    {
        private NpgsqlConnection conexao;

        public NpgsqlConnection Conexao
        {
            get
            {
                return conexao;
            }
        }

        public DeficienciaDAO()
        {
            conexao = Persistencia.Conexao.getInstance().conexaoBD();
        }

        public bool Inserir(Deficiencia deficiencia)
        {
            string stringSQL = "insert into deficiencias (def_descricao) values (@descricao)";

            NpgsqlCommand cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);
            this.Conexao.Open();

            cmdIncluir.Parameters.AddWithValue("@descricao", deficiencia.Descricao);

            cmdIncluir.ExecuteNonQuery();
            this.Conexao.Close();

            return true;
        }

        public bool Alterar(Deficiencia deficiencia)
        {
            string stringSQL = "update deficiencias set def_descricao=@descricao where def_pk=@codigo";

            NpgsqlCommand cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);
            this.Conexao.Open();

            cmdIncluir.Parameters.AddWithValue("@descricao", deficiencia.Descricao);
            cmdIncluir.Parameters.AddWithValue("@codigo", deficiencia.Id);

            cmdIncluir.ExecuteNonQuery();
            this.Conexao.Close();

            return true;
        }

        public List<Deficiencia> GetLista()
        {
            List<Deficiencia> lista = null;
            string stringSQL = "select def_pk, def_descricao from deficiencias";

            NpgsqlCommand cmdConsultar = new NpgsqlCommand(stringSQL, this.Conexao);
            this.Conexao.Open();

            NpgsqlDataReader resultado = cmdConsultar.ExecuteReader();

            if (resultado.HasRows)
            {
                lista = new List<Deficiencia>();
                while (resultado.Read())
                {
                    Deficiencia def = new Deficiencia();
                    def.Id = resultado.GetInt32(0);
                    def.Descricao = resultado.GetString(1);

                    lista.Add(def);
                }
            }
            resultado.Close();
            this.Conexao.Close();

            return lista;
        }

        public List<Deficiencia> Consultar(string descricao)
        {
            List<Deficiencia> lista = new List<Deficiencia>();
            string stringSQL = "select " +
                "def_pk, def_descricao " +
              "from deficiencias where def_descricao ilike @descricao";

            NpgsqlCommand cmdConsultar = new NpgsqlCommand(stringSQL, this.Conexao);
            this.Conexao.Open();
            cmdConsultar.Parameters.AddWithValue("@descricao", "%" + descricao + "%");

            NpgsqlDataReader resultado = cmdConsultar.ExecuteReader();

            if (resultado.HasRows)
            {
                lista = new List<Deficiencia>();
                while (resultado.Read())
                {
                    Deficiencia def = new Deficiencia();
                    def.Id = resultado.GetInt32(0);
                    def.Descricao = resultado.GetString(1);

                    lista.Add(def);
                }
            }
            resultado.Close();
            this.Conexao.Close();

            return lista;
        }

        public bool Excluir(int deficiencia_id)
        {
            string stringSQL = "delete from deficiencias where def_pk=@codigo";

            NpgsqlCommand cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);
            this.Conexao.Open();

            cmdIncluir.Parameters.AddWithValue("@codigo", deficiencia_id);

            cmdIncluir.ExecuteNonQuery();
            this.Conexao.Close();

            return true;
        }
    }
}
