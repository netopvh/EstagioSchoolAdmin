using SchoolAdmin.Model;
using SchoolAdmin.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Control
{
    public class StatusPagamentoCtr
    {
        public StatusPagamento GetInstancia()
        {
            return new StatusPagamento();
        }

        public bool Gravar(StatusPagamento instancia)
        {
            StatusPagamentoDAO staDAO = new StatusPagamentoDAO();
            if (instancia.Id == 0)
            {
                return staDAO.Inserir(instancia);
            }

            return staDAO.Alterar(instancia);
        }

        public DataTable Consultar(string descricao)
        {
            DataTable resultadoBusca = new DataTable();
            resultadoBusca.Columns.Add("Id", typeof(int));
            resultadoBusca.Columns.Add("Descrição", typeof(string));

            StatusPagamentoDAO staDAO = new StatusPagamentoDAO();

            foreach (StatusPagamento obj in (staDAO.Consultar(descricao)))
            {
                DataRow linha = resultadoBusca.NewRow();

                linha["Id"] = obj.Id;
                linha["Descrição"] = obj.Descricao;

                resultadoBusca.Rows.Add(linha);
            }
            return resultadoBusca;
        }

        public bool Excluir(int status_id)
        {
            StatusPagamentoDAO formDAO = new StatusPagamentoDAO();
            return formDAO.Excluir(status_id);
        }
    }
}
