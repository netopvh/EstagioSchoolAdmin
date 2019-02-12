using Npgsql;
using SchoolAdmin.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Persistencia
{
    class FuncionarioDAO
    {
        private NpgsqlConnection conexao;

        public NpgsqlConnection Conexao
        {
            get
            {
                return conexao;
            }
        }

        public FuncionarioDAO()
        {
            conexao = Persistencia.Conexao.getInstance().conexaoBD();
        }

        public bool Inserir(Funcionario funcionario)
        {
            string stringSQL = "insert into pessoas " +
                                     "(pes_nome, pes_sexo, pes_datanascimento, pes_rg)" +
                                     "values " +
                                     "(@nome, @sexo, @datanascimento, @rg) returning pes_pk";

            NpgsqlCommand cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);
            this.Conexao.Open();

            cmdIncluir.Parameters.AddWithValue("@nome", funcionario.Nome);
            cmdIncluir.Parameters.AddWithValue("@sexo", funcionario.Sexo);
            cmdIncluir.Parameters.AddWithValue("@datanascimento", funcionario.DataNascimento);
            cmdIncluir.Parameters.AddWithValue("@rg", funcionario.Rg);

            int pessoa_pk = (int)cmdIncluir.ExecuteScalar();
            funcionario.Id = pessoa_pk;

            stringSQL = "INSERT INTO funcionarios " +
                            " (pes_pk, fun_cpf, fun_email, fun_admissao, fun_observacoes, fun_salario, car_pk) " +
                            "VALUES" +
                            "(@pessoa, @cpf, @email, @admissao, @observacoes, @salario, @cargo)";

            cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);

            cmdIncluir.Parameters.AddWithValue("@pessoa", pessoa_pk);
            cmdIncluir.Parameters.AddWithValue("@cpf", funcionario.Cpf);
            cmdIncluir.Parameters.AddWithValue("@email", funcionario.Email);
            cmdIncluir.Parameters.AddWithValue("@admissao", funcionario.Admissao);
            cmdIncluir.Parameters.AddWithValue("@observacoes", funcionario.Observacoes);
            cmdIncluir.Parameters.AddWithValue("@salario", funcionario.Salario);
            cmdIncluir.Parameters.AddWithValue("@cargo", funcionario.Cargo.Id);

            cmdIncluir.ExecuteNonQuery();
            this.Conexao.Close();

            return true;
        }

        public bool Alterar(Funcionario funcionario)
        {
            string stringSQL = "UPDATE " +
                "pessoas SET pes_nome=@nome, pes_sexo=@sexo, pes_datanascimento=@nascimento, " +
                "pes_rg=@rg, pes_ativo=@ativo " +
              "WHERE pes_pk = @pessoa_id";

            NpgsqlCommand cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);
            this.Conexao.Open();

            cmdIncluir.Parameters.AddWithValue("@nome", funcionario.Nome);
            cmdIncluir.Parameters.AddWithValue("@sexo", funcionario.Sexo);
            cmdIncluir.Parameters.AddWithValue("@nascimento", funcionario.DataNascimento);
            cmdIncluir.Parameters.AddWithValue("@rg", funcionario.Rg);
            cmdIncluir.Parameters.AddWithValue("@ativo", funcionario.Ativo);

            cmdIncluir.Parameters.AddWithValue("@pessoa_id", funcionario.Id);

            cmdIncluir.ExecuteNonQuery();


            stringSQL = "UPDATE " +
                "funcionarios SET fun_cpf=@cpf, fun_email=@email, fun_desligamento=@desligamento, " +
                "fun_observacoes=@observacoes, fun_salario=@salario, car_pk=@cargo_id, " +
                "fun_admissao=@admissao " +
              "WHERE pes_pk = @pessoa_id";

            cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);

            cmdIncluir.Parameters.AddWithValue("@cpf", funcionario.Cpf);
            cmdIncluir.Parameters.AddWithValue("@email", funcionario.Email);
            cmdIncluir.Parameters.AddWithValue("@desligamento", funcionario.Desligamento);
            cmdIncluir.Parameters.AddWithValue("@observacoes", funcionario.Observacoes);
            cmdIncluir.Parameters.AddWithValue("@salario", funcionario.Salario);
            cmdIncluir.Parameters.AddWithValue("@cargo_id", funcionario.Cargo.Id);
            cmdIncluir.Parameters.AddWithValue("@admissao", funcionario.Admissao);
            cmdIncluir.Parameters.AddWithValue("@pessoa_id", funcionario.Id);

            cmdIncluir.ExecuteNonQuery();
            this.Conexao.Close();

            return true;
        }

        public List<Funcionario> Consultar(string nome)
        {
            List<Funcionario> lista = new List<Funcionario>();

            string stringSQL = "select f.pes_pk, p.pes_nome, c.car_cargo, f.car_pk from funcionarios f " +
                "inner join pessoas p on f.pes_pk = p.pes_pk inner join cargos_funcionarios c " +
                "on f.car_pk = c.car_pk where p.pes_nome ilike @nome order by f.pes_pk";

            NpgsqlCommand cmdConsultar = new NpgsqlCommand(stringSQL, this.Conexao);
            this.Conexao.Open();
            cmdConsultar.Parameters.AddWithValue("@nome", "%" + nome + "%");

            NpgsqlDataReader resultado = cmdConsultar.ExecuteReader();

            if (resultado.HasRows)
            {
                while (resultado.Read())
                {
                    Funcionario F = new Funcionario();
                    F.Id = resultado.GetInt32(0);
                    F.Nome = resultado.GetString(1);

                    F.Cargo = new CargoFuncionario();
                    F.Cargo.Cargo = resultado.GetString(2);

                    lista.Add(F);
                }
            }
            resultado.Close();
            this.Conexao.Close();

            return lista;
        }

        public Funcionario GetFuncionarioById(int id)
        {
            Funcionario fun = null;
            string stringSQL = "select " +
                "p.pes_pk, p.pes_nome, p.pes_sexo, p.pes_datanascimento, p.pes_rg, p.pes_ativo, " +
                "f.fun_cpf, f.fun_email, f.fun_desligamento, f.fun_observacoes, f.fun_salario, " +
                "f.car_pk, f.fun_admissao, c.car_cargo " +
              "from pessoas p inner join funcionarios f on p.pes_pk = f.pes_pk " +
              "inner join cargos_funcionarios c on f.car_pk = c.car_pk " +
                 "where f.pes_pk = @codigo";

            NpgsqlCommand cmdConsultar = new NpgsqlCommand(stringSQL, this.Conexao);
            this.Conexao.Open();
            cmdConsultar.Parameters.AddWithValue("@codigo", id);

            NpgsqlDataReader resultado = cmdConsultar.ExecuteReader();

            if (resultado.HasRows)
            {
                resultado.Read();
                fun = new Funcionario();

                fun.Id = resultado.GetInt32(0);
                fun.Nome = resultado.GetString(1);
                fun.Sexo = resultado.GetChar(2).ToString();
                fun.DataNascimento = resultado.GetDateTime(3);
                fun.Rg = resultado.GetString(4);
                fun.Ativo = resultado.GetBoolean(5);

                fun.Cpf = resultado.GetString(6);
                fun.Email = resultado.GetString(7);
                if(!resultado.IsDBNull(8))
                {
                    fun.Desligamento = resultado.GetDateTime(8);
                }
                fun.Observacoes = resultado.GetString(9);
                fun.Salario = resultado.GetDecimal(10);
                fun.Admissao = resultado.GetDateTime(12);

                CargoFuncionario c = new CargoFuncionario();
                c.Id = resultado.GetInt32(11);
                c.Cargo = resultado.GetString(13);

                fun.Cargo = c;

            }
            resultado.Close();
            this.Conexao.Close();

            return fun;
        }

        public void Excluir(int pessoa_id)
        {
            string stringSQL = "delete from funcionarios where pes_pk = @codigo";

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
