using Npgsql;
using SchoolAdmin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Persistencia
{
    class StatusPagamentoDAO
    {
        private NpgsqlConnection conexao;

        public NpgsqlConnection Conexao
        {
            get
            {
                return conexao;
            }
        }

        public StatusPagamentoDAO()
        {
            conexao = Persistencia.Conexao.getInstance().conexaoBD();
        }

        public bool Inserir(StatusPagamento status)
        {
            string stringSQL = "insert into status_pagamento (sta_descricao) values (@descricao)";

            NpgsqlCommand cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);
            this.Conexao.Open();

            cmdIncluir.Parameters.AddWithValue("@descricao", status.Descricao);

            cmdIncluir.ExecuteNonQuery();
            this.Conexao.Close();

            return true;
        }

        public bool Alterar(StatusPagamento status)
        {
            string stringSQL = "update status_pagamento set sta_descricao=@descricao where sta_pk=@codigo";

            NpgsqlCommand cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);
            this.Conexao.Open();

            cmdIncluir.Parameters.AddWithValue("@descricao", status.Descricao);
            cmdIncluir.Parameters.AddWithValue("@codigo", status.Id);

            cmdIncluir.ExecuteNonQuery();
            this.Conexao.Close();

            return true;
        }

        public List<StatusPagamento> GetLista()
        {
            List<StatusPagamento> lista = null;
            string stringSQL = "select sta_pk, sta_descricao from status_pagamento";

            NpgsqlCommand cmdConsultar = new NpgsqlCommand(stringSQL, this.Conexao);
            this.Conexao.Open();

            NpgsqlDataReader resultado = cmdConsultar.ExecuteReader();

            if (resultado.HasRows)
            {
                lista = new List<StatusPagamento>();
                while (resultado.Read())
                {
                    StatusPagamento sta = new StatusPagamento();
                    sta.Id = resultado.GetInt32(0);
                    sta.Descricao = resultado.GetString(1);

                    lista.Add(sta);
                }
            }
            resultado.Close();
            this.Conexao.Close();

            return lista;
        }

        public List<StatusPagamento> Consultar(string descricao)
        {
            List<StatusPagamento> lista = new List<StatusPagamento>();
            string stringSQL = "select " +
                "sta_pk, sta_descricao " +
              "from status_pagamento where sta_descricao ilike @descricao";

            NpgsqlCommand cmdConsultar = new NpgsqlCommand(stringSQL, this.Conexao);
            this.Conexao.Open();
            cmdConsultar.Parameters.AddWithValue("@descricao", "%" + descricao + "%");

            NpgsqlDataReader resultado = cmdConsultar.ExecuteReader();

            if (resultado.HasRows)
            {
                lista = new List<StatusPagamento>();
                while (resultado.Read())
                {
                    StatusPagamento sta = new StatusPagamento();
                    sta.Id = resultado.GetInt32(0);
                    sta.Descricao = resultado.GetString(1);

                    lista.Add(sta);
                }
            }
            resultado.Close();
            this.Conexao.Close();

            return lista;
        }

        public bool Excluir(int status_id)
        {
            string stringSQL = "delete from status_pagamento where sta_pk=@codigo";

            NpgsqlCommand cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);
            this.Conexao.Open();

            cmdIncluir.Parameters.AddWithValue("@codigo", status_id);

            cmdIncluir.ExecuteNonQuery();
            this.Conexao.Close();

            return true;
        }
    }
}
