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
    public class FormasPagamentoCtr
    {
        public FormaPagamento GetInstancia()
        {
            return new FormaPagamento();
        }

        public bool Gravar(FormaPagamento instancia)
        {
            FormaPagamentoDAO formDAO = new FormaPagamentoDAO();
            if (instancia.Id == 0)
            {
                return formDAO.Inserir(instancia);
            }

            return formDAO.Alterar(instancia);
        }

        public DataTable Consultar(string descricao)
        {
            DataTable resultadoBusca = new DataTable();
            resultadoBusca.Columns.Add("Id", typeof(int));
            resultadoBusca.Columns.Add("Descrição", typeof(string));

            FormaPagamentoDAO formDAO = new FormaPagamentoDAO();

            foreach (FormaPagamento obj in (formDAO.Consultar(descricao)))
            {
                DataRow linha = resultadoBusca.NewRow();

                linha["Id"] = obj.Id;
                linha["Descrição"] = obj.Descricao;

                resultadoBusca.Rows.Add(linha);
            }
            return resultadoBusca;
        }

        public bool Excluir(int forma_id)
        {
            FormaPagamentoDAO formDAO = new FormaPagamentoDAO();
            return formDAO.Excluir(forma_id);
        }
    }
}
