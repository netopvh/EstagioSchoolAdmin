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
    public class ContaPagarCtr
    {
        public ContaAPagar GetInstancia()
        {
            return new ContaAPagar();
        }

        public List<OrigemContaAPagar> GetListaOrigemConta()
        {
            OrigemContaAPagarDAO orgDAO = new OrigemContaAPagarDAO();
            return orgDAO.GetLista();
        }

        public List<FormaPagamento> GetListaFormasPagamento()
        {
            FormaPagamentoDAO formDAO = new FormaPagamentoDAO();
            return formDAO.GetLista();
        }

        public DataTable PesquisarContas(OrigemContaAPagar origem)
        {
            ContaAPagarDAO conDAO = new ContaAPagarDAO();

            DataTable resultadoBusca = new DataTable();
            resultadoBusca.Columns.Add("CÓDIGO", typeof(int));
            resultadoBusca.Columns.Add("DESCRIÇÃO", typeof(string));
            resultadoBusca.Columns.Add("VENCIMENTO", typeof(DateTime));
            resultadoBusca.Columns.Add("VALOR", typeof(Decimal));
            resultadoBusca.Columns.Add("V. PAGO", typeof(Decimal));

            foreach (ContaAPagar obj in (conDAO.GetListaByOrigem(origem.Id)))
            {
                DataRow linha = resultadoBusca.NewRow();

                linha["CÓDIGO"] = obj.Id;
                linha["DESCRIÇÃO"] = obj.Descricao;
                linha["VENCIMENTO"] = obj.Vencimento;
                linha["VALOR"] = obj.Valor;
                linha["V. PAGO"] = 0;

                resultadoBusca.Rows.Add(linha);
            }

            return resultadoBusca;
        }

        public bool GravarLancamento(ContaAPagar conta)
        {
            ContaAPagarDAO conDAO = new ContaAPagarDAO();
            return conDAO.Inserir(conta);
        }
    }
}
