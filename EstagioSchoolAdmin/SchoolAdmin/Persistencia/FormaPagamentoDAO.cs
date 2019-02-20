using Npgsql;
using SchoolAdmin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Persistencia
{
    class FormaPagamentoDAO
    {
        private NpgsqlConnection conexao;

        public NpgsqlConnection Conexao
        {
            get
            {
                return conexao;
            }
        }

        public FormaPagamentoDAO()
        {
            conexao = Persistencia.Conexao.getInstance().conexaoBD();
        }

        public bool Inserir(FormaPagamento forma)
        {
            string stringSQL = "insert into formas_pagamento (formp_descricao) values (@descricao)";

            NpgsqlCommand cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);
            this.Conexao.Open();

            cmdIncluir.Parameters.AddWithValue("@descricao", forma.Descricao);

            cmdIncluir.ExecuteNonQuery();
            this.Conexao.Close();

            return true;
        }

        public bool Alterar(FormaPagamento forma)
        {
            string stringSQL = "update formas_pagamento set formp_descricao=@descricao where formp_pk=@codigo";

            NpgsqlCommand cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);
            this.Conexao.Open();

            cmdIncluir.Parameters.AddWithValue("@descricao", forma.Descricao);
            cmdIncluir.Parameters.AddWithValue("@codigo", forma.Id);

            cmdIncluir.ExecuteNonQuery();
            this.Conexao.Close();

            return true;
        }

        public List<FormaPagamento> GetLista()
        {
            List<FormaPagamento> lista = null;
            string stringSQL = "select formp_pk, formp_descricao from formas_pagamento";

            NpgsqlCommand cmdConsultar = new NpgsqlCommand(stringSQL, this.Conexao);
            this.Conexao.Open();

            NpgsqlDataReader resultado = cmdConsultar.ExecuteReader();

            if (resultado.HasRows)
            {
                lista = new List<FormaPagamento>();
                while (resultado.Read())
                {
                    FormaPagamento form = new FormaPagamento();
                    form.Id = resultado.GetInt32(0);
                    form.Descricao = resultado.GetString(1);

                    lista.Add(form);
                }
            }
            resultado.Close();
            this.Conexao.Close();

            return lista;
        }

        public List<FormaPagamento> Consultar(string descricao)
        {
            List<FormaPagamento> lista = new List<FormaPagamento>();
            string stringSQL = "select " +
                "formp_pk, formp_descricao " +
              "from formas_pagamento where formp_descricao ilike @descricao";

            NpgsqlCommand cmdConsultar = new NpgsqlCommand(stringSQL, this.Conexao);
            this.Conexao.Open();
            cmdConsultar.Parameters.AddWithValue("@descricao", "%" + descricao + "%");

            NpgsqlDataReader resultado = cmdConsultar.ExecuteReader();

            if (resultado.HasRows)
            {
                lista = new List<FormaPagamento>();
                while (resultado.Read())
                {
                    FormaPagamento form = new FormaPagamento();
                    form.Id = resultado.GetInt32(0);
                    form.Descricao = resultado.GetString(1);

                    lista.Add(form);
                }
            }
            resultado.Close();
            this.Conexao.Close();

            return lista;
        }

        public bool Excluir(int forma_id)
        {
            string stringSQL = "delete from formas_pagamento where formp_pk=@codigo";

            NpgsqlCommand cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);
            this.Conexao.Open();

            cmdIncluir.Parameters.AddWithValue("@codigo", forma_id);

            cmdIncluir.ExecuteNonQuery();
            this.Conexao.Close();

            return true;
        }
    }
}
