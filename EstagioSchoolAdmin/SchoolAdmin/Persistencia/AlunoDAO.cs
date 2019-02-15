using Npgsql;
using SchoolAdmin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Persistencia
{
    class AlunoDAO
    {
        private NpgsqlConnection conexao;

        public NpgsqlConnection Conexao
        {
            get
            {
                return conexao;
            }
        }

        public AlunoDAO()
        {
            conexao = Persistencia.Conexao.getInstance().conexaoBD();
        }

        public bool Inserir(Aluno aluno)
        {
            string stringSQL = "insert into pessoas " +
                                    "(pes_nome, pes_sexo, pes_datanascimento)" +
                                    "values " +
                                    "(@nome, @sexo, @datanascimento) returning pes_pk";

            NpgsqlCommand cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);
            this.Conexao.Open();

            cmdIncluir.Parameters.AddWithValue("@nome", aluno.Nome);
            cmdIncluir.Parameters.AddWithValue("@sexo", aluno.Sexo);
            cmdIncluir.Parameters.AddWithValue("@datanascimento", aluno.DataNascimento);

            int pessoa_pk = (int)cmdIncluir.ExecuteScalar();

            stringSQL = "insert into alunos " +
                    "(pes_pk, alu_localnascimento, est_pk) " +
                "values (@pessoa, @local, @estado)";

            cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);

            cmdIncluir.Parameters.AddWithValue("@pessoa", pessoa_pk);
            cmdIncluir.Parameters.AddWithValue("@local", aluno.Municipio);
            cmdIncluir.Parameters.AddWithValue("@estado", aluno.Estado.Id);

            cmdIncluir.ExecuteNonQuery();
            this.Conexao.Close();

            return true;
        }

        public bool Alterar(Aluno aluno)
        {
            string stringSQL = "UPDATE " +
                "pessoas SET pes_nome=@nome, pes_sexo=@sexo, pes_datanascimento=@nascimento " +
              "WHERE pes_pk = @pessoa_id";

            NpgsqlCommand cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);
            this.Conexao.Open();

            cmdIncluir.Parameters.AddWithValue("@nome", aluno.Nome);
            cmdIncluir.Parameters.AddWithValue("@sexo", aluno.Sexo);
            cmdIncluir.Parameters.AddWithValue("@nascimento", aluno.DataNascimento);

            cmdIncluir.Parameters.AddWithValue("@pessoa_id", aluno.Id);
            cmdIncluir.ExecuteNonQuery();

            stringSQL = "UPDATE alunos " +
                "SET alu_localnascimento=@local, est_pk=@estado " +
             "WHERE pes_pk=@pessoa";

            cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);

            cmdIncluir.Parameters.AddWithValue("@local", aluno.Municipio);
            cmdIncluir.Parameters.AddWithValue("@estado", aluno.Estado.Id);
            cmdIncluir.Parameters.AddWithValue("@pessoa", aluno.Id);

            cmdIncluir.ExecuteNonQuery();
            this.Conexao.Close();

            return true;
        }

        public List<Aluno> Consultar(string nome)
        {
            List<Aluno> lista = new List<Aluno>();
            string stringSQL = "select a.pes_pk, " +
                "p.pes_nome, p.pes_datanascimento " +
                "from alunos a inner join pessoas p on a.pes_pk = p.pes_pk " +
                "where pes_nome ilike @nome order by pes_pk";

            NpgsqlCommand cmdConsultar = new NpgsqlCommand(stringSQL, this.Conexao);
            this.Conexao.Open();
            cmdConsultar.Parameters.AddWithValue("@nome", "%" + nome + "%");

            NpgsqlDataReader resultado = cmdConsultar.ExecuteReader();

            if (resultado.HasRows)
            {
                while (resultado.Read())
                {
                    Aluno alu = new Aluno();
                    alu.Id = resultado.GetInt32(0);
                    alu.Nome = resultado.GetString(1);
                    alu.DataNascimento = resultado.GetDateTime(2);

                    lista.Add(alu);
                }
            }

            resultado.Close();
            this.conexao.Close();

            return lista;
        }

        public Aluno GetAlunoById(int id)
        {
            Aluno alu = null;
            string stringSQL = "select " +
                "p.pes_pk, p.pes_nome, p.pes_datanascimento, p.pes_sexo, a.alu_localnascimento, " +
                "a.est_pk, e.est_nome, e.est_sigla " +
             "from alunos a " +
                "inner join pessoas p on p.pes_pk = a.pes_pk " +
                "inner join estados e on a.est_pk = e.est_pk " +
             "where p.pes_pk = @codigo";

            NpgsqlCommand cmdConsultar = new NpgsqlCommand(stringSQL, this.Conexao);
            this.Conexao.Open();
            cmdConsultar.Parameters.AddWithValue("@codigo", id);

            NpgsqlDataReader resultado = cmdConsultar.ExecuteReader();

            if (resultado.HasRows)
            {
                resultado.Read();
                alu = new Aluno();

                alu.Id = resultado.GetInt32(0);
                alu.Nome = resultado.GetString(1);
                alu.DataNascimento = resultado.GetDateTime(2);
                alu.Sexo = resultado.GetChar(3).ToString();
                alu.Municipio = resultado.GetString(4);
                alu.Estado = new Estado()
                {
                    Id = resultado.GetInt32(5),
                    Nome = resultado.GetString(6),
                    Sigla = resultado.GetString(7)
                };
            }

            resultado.Close();
            this.Conexao.Close();
            return alu;
        }

        public void Excluir(int pessoa_id)
        {
            string stringSQL = "delete from alunos where pes_pk = @codigo";

            NpgsqlCommand cmdExcluir = new NpgsqlCommand(stringSQL, this.Conexao);
            this.Conexao.Open();
            cmdExcluir.Parameters.AddWithValue("@codigo", pessoa_id);
            cmdExcluir.ExecuteNonQuery();


            stringSQL = "delete from pessoas where pes_pk = @codigo";

            cmdExcluir = new NpgsqlCommand(stringSQL, this.Conexao);
            cmdExcluir.Parameters.AddWithValue("@codigo", pessoa_id);
            cmdExcluir.ExecuteNonQuery();

            this.Conexao.Close();
        }
    }
}
