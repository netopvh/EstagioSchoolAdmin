using Npgsql;
using SchoolAdmin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Persistencia
{
    class TelefoneDAO
    {
        private NpgsqlConnection conexao;

        public NpgsqlConnection Conexao
        {
            get
            {
                return conexao;
            }
        }

        public TelefoneDAO()
        {
            conexao = Persistencia.Conexao.getInstance().conexaoBD();
        }

        public bool Inserir(Telefone telefone)
        {
            string stringSQL = "insert into telefones " +
                                     "(tel_numero, pes_pk)" +
                                     "values " +
                                     "(@numero, @pessoa)";

            NpgsqlCommand cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);
            this.Conexao.Open();

            cmdIncluir.Parameters.AddWithValue("@numero", telefone.Numero);
            cmdIncluir.Parameters.AddWithValue("@pessoa", telefone.Pessoa.Id);

            cmdIncluir.ExecuteNonQuery();
            this.Conexao.Close();

            return true;
        }

        public bool Alterar(Telefone telefone)
        {
            string stringSQL = "UPDATE telefones SET tel_numero=@numero WHERE tel_pk = @telefones";

            NpgsqlCommand cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);
            this.Conexao.Open();

            cmdIncluir.Parameters.AddWithValue("@numero", telefone.Numero);
            cmdIncluir.Parameters.AddWithValue("@telefones", telefone.Id);

            cmdIncluir.ExecuteNonQuery();
            this.Conexao.Close();

            return true;
        }

        public List<Telefone> Consultar(int pes_pk)
        {
            List<Telefone> lista = new List<Telefone>();

            string stringSQL = "select * from telefones " +
                                  "where pes_pk = @pessoa " +
                                  "order by tel_pk";

            NpgsqlCommand cmdConsultar = new NpgsqlCommand(stringSQL, this.Conexao);
            this.Conexao.Open();
            cmdConsultar.Parameters.AddWithValue("@pessoa", pes_pk);

            NpgsqlDataReader resultado = cmdConsultar.ExecuteReader();

            if (resultado.HasRows)
            {
                while (resultado.Read())
                {
                    Telefone tel = new Telefone();
                    tel.Id = resultado.GetInt32(0);
                    tel.Numero = resultado.GetString(1);

                    lista.Add(tel);
                }
            }
            resultado.Close();
            this.Conexao.Close();

            return lista;
        }

        public void Excluir(int pessoa_id)
        {
            string stringSQL = "delete from telefones where pes_pk = @codigo";

            NpgsqlCommand cmdExcluir = new NpgsqlCommand(stringSQL, this.Conexao);
            this.Conexao.Open();

            cmdExcluir.Parameters.AddWithValue("@codigo", pessoa_id);

            cmdExcluir.ExecuteNonQuery();
            this.Conexao.Close();
        }
    }
}
