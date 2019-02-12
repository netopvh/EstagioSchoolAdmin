using Npgsql;
using SchoolAdmin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Persistencia
{
    class EnderecoDAO
    {
        private NpgsqlConnection conexao;

        public NpgsqlConnection Conexao
        {
            get
            {
                return conexao;
            }
        }

        public EnderecoDAO()
        {
            conexao = Persistencia.Conexao.getInstance().conexaoBD();
        }

        public bool Inserir(Endereco end)
        {
            string stringSQL = "insert into enderecos " +
                "(end_rua, end_numero, end_complemento, end_cidade, end_cep, pes_pk, est_pk, end_bairro)" +
             " VALUES (@rua, @numero, @complemento, @cidade, @cep, @pessoa, @estado, @bairro)";

            NpgsqlCommand cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);
            this.Conexao.Open();

            cmdIncluir.Parameters.AddWithValue("@rua", end.Rua);
            cmdIncluir.Parameters.AddWithValue("@numero", end.Numero);
            cmdIncluir.Parameters.AddWithValue("@complemento", end.Complemento);
            cmdIncluir.Parameters.AddWithValue("@cidade", end.Cidade);
            cmdIncluir.Parameters.AddWithValue("@cep", end.CEP);
            cmdIncluir.Parameters.AddWithValue("@pessoa", end.Pessoa.Id);
            cmdIncluir.Parameters.AddWithValue("@estado", end.Estado.Id);
            cmdIncluir.Parameters.AddWithValue("@bairro", end.Bairro);

            cmdIncluir.ExecuteNonQuery();
            this.Conexao.Close();

            return true;
        }

        public bool Alterar(Endereco end)
        {
            string stringSQL = "update enderecos " +
                "set end_rua=@rua, end_numero=@numero, end_complemento=@complemento, " +
                "end_cidade=@cidade, end_cep=@cep, est_pk=@estado, end_bairro=@bairro " +
                "WHERE pes_pk = @pessoa";

            NpgsqlCommand cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);
            this.Conexao.Open();

            cmdIncluir.Parameters.AddWithValue("@rua", end.Rua);
            cmdIncluir.Parameters.AddWithValue("@numero", end.Numero);
            cmdIncluir.Parameters.AddWithValue("@complemento", end.Complemento);
            cmdIncluir.Parameters.AddWithValue("@cidade", end.Cidade);
            cmdIncluir.Parameters.AddWithValue("@cep", end.CEP);
            cmdIncluir.Parameters.AddWithValue("@estado", end.Estado.Id);
            cmdIncluir.Parameters.AddWithValue("@bairro", end.Bairro);

            cmdIncluir.Parameters.AddWithValue("@pessoa", end.Pessoa.Id);

            cmdIncluir.ExecuteNonQuery();
            this.Conexao.Close();

            return true;
        }

        public Endereco GetEnderecoById(int pessoa_id)
        {
            Endereco end = null;
            string stringSQL = "select " +
                "e.end_pk, e.end_rua, e.end_numero, e.end_complemento, e.end_cidade, " +
                "e.end_cep, e.pes_pk, e.est_pk, e.end_bairro, est.est_nome, est.est_sigla " +
             "from enderecos e inner join estados est on est.est_pk = e.est_pk " +
                "where pes_pk = @pessoa";

            NpgsqlCommand cmdConsultar = new NpgsqlCommand(stringSQL, this.Conexao);
            this.Conexao.Open();
            cmdConsultar.Parameters.AddWithValue("@pessoa", pessoa_id);

            NpgsqlDataReader resultado = cmdConsultar.ExecuteReader();

            if (resultado.HasRows)
            {
                resultado.Read();

                end = new Endereco();
                end.Id = resultado.GetInt32(0);
                end.Rua = resultado.GetString(1);
                end.Numero = resultado.GetInt32(2);
                end.Complemento = resultado.GetString(3);
                end.Cidade = resultado.GetString(4);
                end.CEP = resultado.GetString(5);
                end.Bairro = resultado.GetString(8);

                Estado est = new Estado();
                est.Id = resultado.GetInt32(7);
                est.Nome = resultado.GetString(9);
                est.Sigla = resultado.GetString(10);

                end.Estado = est;
            }

            resultado.Close();
            this.Conexao.Close();

            return end;
        }

        public void Excluir(int pessoa_id)
        {
            string stringSQL = "delete from enderecos where pes_pk = @codigo";

            NpgsqlCommand cmdExcluir = new NpgsqlCommand(stringSQL, this.Conexao);
            this.Conexao.Open();

            cmdExcluir.Parameters.AddWithValue("@codigo", pessoa_id);

            cmdExcluir.ExecuteNonQuery();
            this.Conexao.Close();
        }
    }
}
