using Npgsql;
using SchoolAdmin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Persistencia
{
    class ContaAPagarDAO
    {
        private NpgsqlConnection conexao;

        public NpgsqlConnection Conexao
        {
            get
            {
                return conexao;
            }
        }

        public ContaAPagarDAO()
        {
            conexao = Persistencia.Conexao.getInstance().conexaoBD();
        }

        public bool Inserir(ContaAPagar conta)
        {
            string stringSQL = "insert into contas_pagar " +
                "(conpg_descricao, conpg_data, conpg_vencimento, conpg_valor, org_pk) " +
                "values (@descricao, @data, @vencimento, @valor, @origem)";

            NpgsqlCommand cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);
            this.Conexao.Open();

            cmdIncluir.Parameters.AddWithValue("@descricao", conta.Descricao);
            cmdIncluir.Parameters.AddWithValue("@data", conta.DataLancamento);
            cmdIncluir.Parameters.AddWithValue("@vencimento", conta.Vencimento);
            cmdIncluir.Parameters.AddWithValue("@valor", conta.Valor);
            cmdIncluir.Parameters.AddWithValue("@origem", conta.Origem.Id);

            cmdIncluir.ExecuteNonQuery();
            this.Conexao.Close();

            return true;
        }

        public ContaAPagar GetContaById(int conta_id)
        {
            ContaAPagar conta = null;
            string stringSQL = "select conpg_pk, conpg_valor " +
              "from contas_pagar " +
                "where conpg_pk = @conta";

            NpgsqlCommand cmdConsultar = new NpgsqlCommand(stringSQL, this.Conexao);
            
            cmdConsultar.Parameters.AddWithValue("@conta", conta_id);

            NpgsqlDataReader resultado = cmdConsultar.ExecuteReader();

            if (resultado.HasRows)
            {
                while (resultado.Read())
                {
                    conta = new ContaAPagar();
                    conta.Id = resultado.GetInt32(0);
                    conta.Valor = resultado.GetDecimal(1);
                }
               
            }
            resultado.Close();
            

            return conta;
        }

        public List<ContaAPagar> GetListaByOrigem(int origem_id)
        {
            List<ContaAPagar> lista = new List<ContaAPagar>();
            string stringSQL = "select c.conpg_pk, c.conpg_descricao, c.conpg_data, c.conpg_vencimento, " +
                "c.conpg_valor, c.org_pk, o.org_descricao " +
              "from contas_pagar c inner join origens_conta o on c.org_pk = o.org_pk " +
                "where c.org_pk = @origem " +
                "and " +
                "c.conpg_pk not in (select conpg_pk from pagamentos)";

            NpgsqlCommand cmdConsultar = new NpgsqlCommand(stringSQL, this.Conexao);
            this.Conexao.Open();
            cmdConsultar.Parameters.AddWithValue("@origem", origem_id);

            NpgsqlDataReader resultado = cmdConsultar.ExecuteReader();

            if (resultado.HasRows)
            {
                while (resultado.Read())
                {
                    ContaAPagar con = new ContaAPagar();
                    con.Id = resultado.GetInt32(0);
                    con.Descricao = resultado.GetString(1);
                    con.DataLancamento = resultado.GetDateTime(2);
                    con.Vencimento = resultado.GetDateTime(3);
                    con.Valor = resultado.GetDecimal(4);

                    con.Origem = new OrigemContaAPagar()
                    {
                        Id = resultado.GetInt32(5),
                        Descricao = resultado.GetString(6)
                    };


                    lista.Add(con);
                }
            }
            resultado.Close();
            this.Conexao.Close();

            return lista;
        }

        public List<ContaAPagar> GetListaTodasContasByOrigem(int origem_id)
        {
            List<ContaAPagar> lista = new List<ContaAPagar>();
            string stringSQL = "select " +
                "c.conpg_pk, c.conpg_descricao, c.conpg_data, c.conpg_vencimento, " +
                "c.conpg_valor, c.org_pk, o.org_descricao, p.pag_valorpago " +
                "from contas_pagar c inner join origens_conta o on c.org_pk = o.org_pk " +
                "left join pagamentos p on c.conpg_pk = p.conpg_pk " +
                "where c.org_pk = @origem";

            NpgsqlCommand cmdConsultar = new NpgsqlCommand(stringSQL, this.Conexao);
            this.Conexao.Open();
            cmdConsultar.Parameters.AddWithValue("@origem", origem_id);

            NpgsqlDataReader resultado = cmdConsultar.ExecuteReader();

            if (resultado.HasRows)
            {
                while (resultado.Read())
                {
                    ContaAPagar con = new ContaAPagar();
                    con.Id = resultado.GetInt32(0);
                    con.Descricao = resultado.GetString(1);
                    con.DataLancamento = resultado.GetDateTime(2);
                    con.Vencimento = resultado.GetDateTime(3);
                    con.Valor = resultado.GetDecimal(4);

                    if(!resultado.IsDBNull(7))
                    {
                        con.ValorPago = resultado.GetDecimal(7);
                    }

                    con.Origem = new OrigemContaAPagar()
                    {
                        Id = resultado.GetInt32(5),
                        Descricao = resultado.GetString(6)
                    };


                    lista.Add(con);
                }
            }
            resultado.Close();
            this.Conexao.Close();

            return lista;
        }

    }
}
