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

        public List<Responsavel> Consultar(string resp_nome, Aluno aluno)
        {
            List<Responsavel> lista = new List<Responsavel>();
            string stringSQL = "select ra.alu_pk, ra.resp_pk, p.pes_nome, r.resp_parentesco, r.resp_outroparentesco " +
                "from responsaveis_aluno ra " +
                "inner join pessoas p on p.pes_pk=ra.resp_pk " +
                "inner join responsaveis r on r.pes_pk=ra.resp_pk " +
                "where ra.alu_pk=20 and p.pes_nome ilike @nome";

            NpgsqlCommand cmdConsultar = new NpgsqlCommand(stringSQL, this.Conexao);
            this.Conexao.Open();
            cmdConsultar.Parameters.AddWithValue("@nome", "%" + resp_nome + "%");

            NpgsqlDataReader resultado = cmdConsultar.ExecuteReader();

            if (resultado.HasRows)
            {
                while (resultado.Read())
                {
                    Responsavel resp = new Responsavel();
                    resp.Id = resultado.GetInt32(1);
                    resp.Nome = resultado.GetString(2);
                    resp.Parentesco = resultado.GetChar(3).ToString();
                    resp.OutroParentesco = resultado.GetString(4);

                    lista.Add(resp);
                }
            }
            resultado.Close();
            this.Conexao.Close();

            return lista;
        }

        public Responsavel GetResponsavelById(int responsavel_id)
        {
            Responsavel resp = null;
            string stringSQL = "select p.pes_pk, p.pes_nome, p.pes_sexo, p.pes_rg, r.resp_cpf, " +
                "r.resp_estadocivil, r.resp_nomeconjuge, r.resp_profissao, r.resp_parentesco, " +
                "r.resp_outroparentesco, r.resp_enderecoaluno " +
             "from pessoas p " +
                "inner join responsaveis r on p.pes_pk = r.pes_pk " +
             "where p.pes_pk=@pessoa";

            NpgsqlCommand cmdConsultar = new NpgsqlCommand(stringSQL, this.Conexao);
            this.Conexao.Open();
            cmdConsultar.Parameters.AddWithValue("@pessoa", responsavel_id);

            NpgsqlDataReader resultado = cmdConsultar.ExecuteReader();

            if (resultado.HasRows)
            {
                resultado.Read();
                resp = new Responsavel();

                resp.Id = resultado.GetInt32(0);
                resp.Nome = resultado.GetString(1);
                resp.Sexo = resultado.GetChar(2).ToString();
                resp.Rg = resultado.GetString(3);

                resp.CPF = resultado.GetString(4);
                resp.EstadoCivil = resultado.GetChar(5).ToString();
                resp.NomeConjuge = resultado.GetString(6);
                resp.Profissao = resultado.GetString(7);
                resp.Parentesco = resultado.GetChar(8).ToString();
                resp.OutroParentesco = resultado.GetString(9);
                resp.MoraMesmoEnderecoAluno = resultado.GetBoolean(10);

            }
            resultado.Close();
            this.Conexao.Close();

            return resp;
        }
    }
}
