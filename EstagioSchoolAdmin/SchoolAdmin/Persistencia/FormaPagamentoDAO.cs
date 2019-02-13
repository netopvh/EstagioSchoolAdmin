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
    }
}
