using Npgsql;
using SchoolAdmin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Persistencia
{
    class CirurgiaDAO
    {
        private NpgsqlConnection conexao;

        public NpgsqlConnection Conexao
        {
            get
            {
                return conexao;
            }
        }

        public CirurgiaDAO()
        {
            conexao = Persistencia.Conexao.getInstance().conexaoBD();
        }

        public bool Inserir(Cirurgia cirurgia)
        {
            string stringSQL = "insert into cirurgias (cir_descricao) values (@descricao)";

            NpgsqlCommand cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);
            this.Conexao.Open();

            cmdIncluir.Parameters.AddWithValue("@descricao", cirurgia.Descricao);

            cmdIncluir.ExecuteNonQuery();
            this.Conexao.Close();

            return true;
        }

        public bool Alterar(Cirurgia cirurgia)
        {
            string stringSQL = "update cirurgias set cir_descricao=@descricao where cir_pk=@codigo";

            NpgsqlCommand cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);
            this.Conexao.Open();

            cmdIncluir.Parameters.AddWithValue("@descricao", cirurgia.Descricao);
            cmdIncluir.Parameters.AddWithValue("@codigo", cirurgia.Id);

            cmdIncluir.ExecuteNonQuery();
            this.Conexao.Close();

            return true;
        }

        public List<Cirurgia> GetLista()
        {
            List<Cirurgia> lista = null;
            string stringSQL = "select cir_pk, cir_descricao from cirurgias";

            NpgsqlCommand cmdConsultar = new NpgsqlCommand(stringSQL, this.Conexao);
            this.Conexao.Open();

            NpgsqlDataReader resultado = cmdConsultar.ExecuteReader();

            if (resultado.HasRows)
            {
                lista = new List<Cirurgia>();
                while (resultado.Read())
                {
                    Cirurgia cir = new Cirurgia();
                    cir.Id = resultado.GetInt32(0);
                    cir.Descricao = resultado.GetString(1);

                    lista.Add(cir);
                }
            }
            resultado.Close();
            this.Conexao.Close();

            return lista;
        }

        public List<Cirurgia> Consultar(string descricao)
        {
            List<Cirurgia> lista = new List<Cirurgia>();
            string stringSQL = "select " +
                "cir_pk, cir_descricao " +
              "from cirurgias where cir_descricao ilike @descricao";

            NpgsqlCommand cmdConsultar = new NpgsqlCommand(stringSQL, this.Conexao);
            this.Conexao.Open();
            cmdConsultar.Parameters.AddWithValue("@descricao", "%" + descricao + "%");

            NpgsqlDataReader resultado = cmdConsultar.ExecuteReader();

            if (resultado.HasRows)
            {
                lista = new List<Cirurgia>();
                while (resultado.Read())
                {
                    Cirurgia cir = new Cirurgia();
                    cir.Id = resultado.GetInt32(0);
                    cir.Descricao = resultado.GetString(1);

                    lista.Add(cir);
                }
            }
            resultado.Close();
            this.Conexao.Close();

            return lista;
        }

        public bool Excluir(int cirurgia_id)
        {
            string stringSQL = "delete from cirurgias where cir_pk=@codigo";

            NpgsqlCommand cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);
            this.Conexao.Open();

            cmdIncluir.Parameters.AddWithValue("@codigo", cirurgia_id);

            cmdIncluir.ExecuteNonQuery();
            this.Conexao.Close();

            return true;
        }
    }
}
