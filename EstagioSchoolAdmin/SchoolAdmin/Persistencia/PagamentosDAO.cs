using Npgsql;
using SchoolAdmin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Persistencia
{
    class PagamentosDAO
    {
        private NpgsqlConnection conexao;

        public NpgsqlConnection Conexao
        {
            get
            {
                return conexao;
            }
        }

        public PagamentosDAO()
        {
            conexao = Persistencia.Conexao.getInstance().conexaoBD();
        }

        public bool RegistrarBaixa(List<int> listaContas, FormaPagamento formaPagamento)
        {
            string stringSQL = "insert into pagamentos " +
                "(pag_data, pag_valorpago, formp_pk, sta_pk, conpg_pk) " +
                "VALUES (@data, @valor, @formapg, @status, @conta)";

            ContaAPagarDAO conDAO = new ContaAPagarDAO();

            NpgsqlCommand cmdIncluir = new NpgsqlCommand(stringSQL, this.Conexao);
            this.Conexao.Open();

            foreach (int conta_id in listaContas)
            {
                ContaAPagar con = conDAO.GetContaById(conta_id);

                cmdIncluir.Parameters.AddWithValue("@data", DateTime.Today.Date);
                cmdIncluir.Parameters.AddWithValue("@valor", con.Valor);
                cmdIncluir.Parameters.AddWithValue("@formapg", formaPagamento.Id);
                cmdIncluir.Parameters.AddWithValue("@status", 1);
                cmdIncluir.Parameters.AddWithValue("@conta", con.Id);

                cmdIncluir.ExecuteNonQuery();

                cmdIncluir.Parameters.Clear();
            }

            this.Conexao.Close();

            return true;
        }
    }
}
