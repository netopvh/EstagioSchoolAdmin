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

        public DataTable PesquisarContas(OrigemContaAPagar origem, bool mostraQuitadas)
        {
            ContaAPagarDAO conDAO = new ContaAPagarDAO();

            DataTable resultadoBusca = new DataTable();
            resultadoBusca.Columns.Add("CÓDIGO", typeof(int));
            resultadoBusca.Columns.Add("DESCRIÇÃO", typeof(string));
            resultadoBusca.Columns.Add("LANÇAMENTO", typeof(DateTime));
            resultadoBusca.Columns.Add("VENCIMENTO", typeof(DateTime));
            resultadoBusca.Columns.Add("VALOR", typeof(string));
            resultadoBusca.Columns.Add("V. PAGO", typeof(string));

            List<ContaAPagar> resultadoPesquisa = null;
            if (mostraQuitadas)
            {
                resultadoPesquisa = conDAO.GetListaTodasContasByOrigem(origem.Id);
            }
            else
            {
                resultadoPesquisa = conDAO.GetListaByOrigem(origem.Id);
            }
            

            foreach (ContaAPagar obj in resultadoPesquisa)
            {
                DataRow linha = resultadoBusca.NewRow();

                linha["CÓDIGO"] = obj.Id;
                linha["DESCRIÇÃO"] = obj.Descricao;
                linha["LANÇAMENTO"] = obj.DataLancamento;
                linha["VENCIMENTO"] = obj.Vencimento;
                linha["VALOR"] = String.Format("R$ {0:0.00}", obj.Valor);
                linha["V. PAGO"] = String.Format("R$ {0:0.00}", obj.ValorPago);

                resultadoBusca.Rows.Add(linha);
            }

            return resultadoBusca;
        }

        public DataTable FiltrarContasPorDataVencimento(OrigemContaAPagar origem, DateTime inicio, DateTime fim, bool mostrarQuitadas)
        {
            DataTable resultadoBusca = new DataTable();
            ContaAPagarDAO conDAO = new ContaAPagarDAO();

            List<ContaAPagar> lista = null;
            if(mostrarQuitadas)
            {
                lista = conDAO.GetListaTodasContasByOrigem(origem.Id);
            }
            else
            {
                lista = conDAO.GetListaByOrigem(origem.Id);
            }

            resultadoBusca.Columns.Add("CÓDIGO", typeof(int));
            resultadoBusca.Columns.Add("DESCRIÇÃO", typeof(string));
            resultadoBusca.Columns.Add("LANÇAMENTO", typeof(DateTime));
            resultadoBusca.Columns.Add("VENCIMENTO", typeof(DateTime));
            resultadoBusca.Columns.Add("VALOR", typeof(string));
            resultadoBusca.Columns.Add("V. PAGO", typeof(string));

            var listaFiltrada = lista.Where(c => c.Vencimento.Date >= inicio.Date);
            if (fim.Date != DateTime.Today)
            {
                listaFiltrada = listaFiltrada.Where(c => c.Vencimento.Date <= fim.Date);
            }

            foreach (ContaAPagar obj in listaFiltrada)
            {
                DataRow linha = resultadoBusca.NewRow();

                linha["CÓDIGO"] = obj.Id;
                linha["DESCRIÇÃO"] = obj.Descricao;
                linha["LANÇAMENTO"] = obj.DataLancamento;
                linha["VENCIMENTO"] = obj.Vencimento;
                linha["VALOR"] = String.Format("R$ {0:0.00}", obj.Valor);
                linha["V. PAGO"] = String.Format("R$ {0:0.00}", obj.ValorPago);

                resultadoBusca.Rows.Add(linha);
            }

            return resultadoBusca;
        }

        public bool GravarLancamento(ContaAPagar conta)
        {
            ContaAPagarDAO conDAO = new ContaAPagarDAO();
            return conDAO.Inserir(conta);
        }

        public bool RegistrarBaixa(List<int> listaContas, FormaPagamento formaPagamento)
        {
            PagamentosDAO pagDAO = new PagamentosDAO();
            return pagDAO.RegistrarBaixa(listaContas, formaPagamento);
        }

    }
}
