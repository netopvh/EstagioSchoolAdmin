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
    }
}
