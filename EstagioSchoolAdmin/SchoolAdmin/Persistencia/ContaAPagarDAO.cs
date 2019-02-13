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

            cmdIncluir.Parameters.AddWithValue("@descricao",conta.Descricao);
            cmdIncluir.Parameters.AddWithValue("@data", conta.DataLancamento);
            cmdIncluir.Parameters.AddWithValue("@vencimento", conta.Vencimento);
            cmdIncluir.Parameters.AddWithValue("@valor", conta.Valor);
            cmdIncluir.Parameters.AddWithValue("@origem", conta.Origem.Id);

            cmdIncluir.ExecuteNonQuery();
            this.Conexao.Close();

            return true;
        }
    }
}
