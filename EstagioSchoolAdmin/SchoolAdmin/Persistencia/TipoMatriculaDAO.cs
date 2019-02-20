using Npgsql;
using SchoolAdmin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Persistencia
{
    class TipoMatriculaDAO
    {
        private NpgsqlConnection conexao;

        public NpgsqlConnection Conexao
        {
            get
            {
                return conexao;
            }
        }

        public TipoMatriculaDAO()
        {
            conexao = Persistencia.Conexao.getInstance().conexaoBD();
        }

        public bool Inserir(TipoMatricula tipo)
        {
            string stringSQL = "insert into tipos_matricula (tpm_descricao) values (@descricao)";

            NpgsqlCommand cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);
            this.Conexao.Open();

            cmdIncluir.Parameters.AddWithValue("@descricao", tipo.Descricao);

            cmdIncluir.ExecuteNonQuery();
            this.Conexao.Close();

            return true;
        }

        public bool Alterar(TipoMatricula tipo)
        {
            string stringSQL = "update tipos_matricula set tpm_descricao=@descricao where tpm_pk=@codigo";

            NpgsqlCommand cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);
            this.Conexao.Open();

            cmdIncluir.Parameters.AddWithValue("@descricao", tipo.Descricao);
            cmdIncluir.Parameters.AddWithValue("@codigo", tipo.Id);

            cmdIncluir.ExecuteNonQuery();
            this.Conexao.Close();

            return true;
        }

        public List<TipoMatricula> GetLista()
        {
            List<TipoMatricula> lista = new List<TipoMatricula>();
            string stringSQL = "select tpm_pk, tpm_descricao from tipos_matricula";

            NpgsqlCommand cmdConsultar = new NpgsqlCommand(stringSQL, this.Conexao);
            this.Conexao.Open();

            NpgsqlDataReader resultado = cmdConsultar.ExecuteReader();

            if (resultado.HasRows)
            {
                lista = new List<TipoMatricula>();
                while (resultado.Read())
                {
                    TipoMatricula tipo = new TipoMatricula();
                    tipo.Id = resultado.GetInt32(0);
                    tipo.Descricao = resultado.GetString(1);

                    lista.Add(tipo);
                }
            }
            resultado.Close();
            this.Conexao.Close();

            return lista;
        }

        public List<TipoMatricula> Consultar(string descricao)
        {
            List<TipoMatricula> lista = new List<TipoMatricula>();
            string stringSQL = "select " +
                "tpm_pk, tpm_descricao " +
              "from tipos_matricula where tpm_descricao ilike @descricao";

            NpgsqlCommand cmdConsultar = new NpgsqlCommand(stringSQL, this.Conexao);
            this.Conexao.Open();
            cmdConsultar.Parameters.AddWithValue("@descricao", "%" + descricao + "%");

            NpgsqlDataReader resultado = cmdConsultar.ExecuteReader();

            if (resultado.HasRows)
            {
                lista = new List<TipoMatricula>();
                while (resultado.Read())
                {
                    TipoMatricula tipo = new TipoMatricula();
                    tipo.Id = resultado.GetInt32(0);
                    tipo.Descricao = resultado.GetString(1);

                    lista.Add(tipo);
                }
            }
            resultado.Close();
            this.Conexao.Close();

            return lista;
        }

        public bool Excluir(int tipo_id)
        {
            string stringSQL = "delete from tipos_matricula where tpm_pk=@codigo";

            NpgsqlCommand cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);
            this.Conexao.Open();

            cmdIncluir.Parameters.AddWithValue("@codigo", tipo_id);

            cmdIncluir.ExecuteNonQuery();
            this.Conexao.Close();

            return true;
        }
    }
}
