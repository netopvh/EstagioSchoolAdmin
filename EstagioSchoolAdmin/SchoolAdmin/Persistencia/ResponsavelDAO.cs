using Npgsql;
using SchoolAdmin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Persistencia
{
    public class ResponsavelDAO
    {
        private NpgsqlConnection conexao;

        public NpgsqlConnection Conexao
        {
            get
            {
                return conexao;
            }
        }

        public ResponsavelDAO()
        {
            conexao = Persistencia.Conexao.getInstance().conexaoBD();
        }

        public bool Inserir(Responsavel responsavel, Aluno aluno)
        {
            string stringSQL = "insert into pessoas " +
                                     "(pes_nome, pes_sexo, pes_datanascimento, pes_rg)" +
                                     "values " +
                                     "(@nome, @sexo, @datanascimento, @rg) returning pes_pk";

            NpgsqlCommand cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);
            this.Conexao.Open();

            cmdIncluir.Parameters.AddWithValue("@nome", responsavel.Nome);
            cmdIncluir.Parameters.AddWithValue("@sexo", responsavel.Sexo);
            cmdIncluir.Parameters.AddWithValue("@datanascimento", DateTime.Today);
            cmdIncluir.Parameters.AddWithValue("@rg", responsavel.Rg);

            int pessoa_pk = (int)cmdIncluir.ExecuteScalar();
            responsavel.Id = pessoa_pk;



            stringSQL = "insert into responsaveis " +
                "(pes_pk, resp_cpf, resp_estadocivil, resp_nomeconjuge, resp_profissao, " +
                "resp_parentesco, resp_outroparentesco, resp_enderecoaluno) " +
            "values " +
                "(@pessoa, @cpf, @estadocivil, @conjuge, @profissao, @parentesco, " +
                "@outroparentesco, @enderecoaluno)";

            cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);

            cmdIncluir.Parameters.AddWithValue("@pessoa", pessoa_pk);
            cmdIncluir.Parameters.AddWithValue("@cpf", responsavel.CPF);
            cmdIncluir.Parameters.AddWithValue("@estadocivil", responsavel.EstadoCivil);
            cmdIncluir.Parameters.AddWithValue("@conjuge", responsavel.NomeConjuge);
            cmdIncluir.Parameters.AddWithValue("@profissao", responsavel.Profissao);
            cmdIncluir.Parameters.AddWithValue("@parentesco", responsavel.Parentesco);
            cmdIncluir.Parameters.AddWithValue("@outroparentesco", responsavel.OutroParentesco);
            cmdIncluir.Parameters.AddWithValue("@enderecoaluno", responsavel.MoraMesmoEnderecoAluno);

            cmdIncluir.ExecuteNonQuery();



            stringSQL = "insert into responsaveis_aluno " +
                "(alu_pk, resp_pk) " +
                "VALUES (@aluno, @responsavel)";

            cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);

            cmdIncluir.Parameters.AddWithValue("@aluno", aluno.Id);
            cmdIncluir.Parameters.AddWithValue("@responsavel", pessoa_pk);

            cmdIncluir.ExecuteNonQuery();


            this.Conexao.Close();


            return true;
        }

        public bool Alterar(Responsavel responsavel)
        {
            string stringSQL = "update " +
                "pessoas set pes_nome=@nome, pes_sexo=@sexo, pes_rg=@rg " +
              "WHERE pes_pk = @pessoa_id";

            NpgsqlCommand cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);
            this.Conexao.Open();

            cmdIncluir.Parameters.AddWithValue("@nome", responsavel.Nome);
            cmdIncluir.Parameters.AddWithValue("@nome", responsavel.Sexo);
            cmdIncluir.Parameters.AddWithValue("@nome", responsavel.Rg);

            cmdIncluir.Parameters.AddWithValue("@pessoa_id", responsavel.Id);
            cmdIncluir.ExecuteNonQuery();

            stringSQL = "update responsaveis set " +
                "resp_cpf=@cpf, resp_estadocivil=@estadocivil, " +
                "resp_nomeconjuge=@conjuge, resp_profissao=@profissao, resp_parentesco=@parentesco, " +
                "resp_outroparentesco=@outroparentesco, resp_enderecoaluno=@enderecoaluno " +
             "WHERE pes_pk = @pessoa_id";

            cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);
            cmdIncluir.Parameters.AddWithValue("@cpf", responsavel.CPF);
            cmdIncluir.Parameters.AddWithValue("@estadocivil", responsavel.EstadoCivil);
            cmdIncluir.Parameters.AddWithValue("@conjuge", responsavel.NomeConjuge);
            cmdIncluir.Parameters.AddWithValue("@profissao", responsavel.Profissao);
            cmdIncluir.Parameters.AddWithValue("@parentesco", responsavel.Parentesco);
            cmdIncluir.Parameters.AddWithValue("@outroparentesco", responsavel.OutroParentesco);
            cmdIncluir.Parameters.AddWithValue("@enderecoaluno", responsavel.MoraMesmoEnderecoAluno);

            cmdIncluir.ExecuteNonQuery();

            return true;
        }
    }
}
