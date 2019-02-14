﻿using SchoolAdmin.Model;
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
            resultadoBusca.Columns.Add("LANÇAMENTO", typeof(DateTime));
            resultadoBusca.Columns.Add("VENCIMENTO", typeof(DateTime));
            resultadoBusca.Columns.Add("VALOR", typeof(string));
            resultadoBusca.Columns.Add("V. PAGO", typeof(string));

            foreach (ContaAPagar obj in (conDAO.GetListaByOrigem(origem.Id)))
            {
                DataRow linha = resultadoBusca.NewRow();

                linha["CÓDIGO"] = obj.Id;
                linha["DESCRIÇÃO"] = obj.Descricao;
                linha["LANÇAMENTO"] = obj.DataLancamento;
                linha["VENCIMENTO"] = obj.Vencimento;
                linha["VALOR"] = String.Format("R$ {0:0.00}", obj.Valor);
                linha["V. PAGO"] = "R$ 0,00";

                resultadoBusca.Rows.Add(linha);
            }

            return resultadoBusca;
        }

        public DataTable FiltrarContasPorDataVencimento(OrigemContaAPagar origem, DateTime inicio, DateTime fim)
        {
            DataTable resultadoBusca = new DataTable();
            ContaAPagarDAO conDAO = new ContaAPagarDAO();

            List<ContaAPagar> lista = conDAO.GetListaByOrigem(origem.Id);

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
                linha["V. PAGO"] = "R$ 0,00";

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
