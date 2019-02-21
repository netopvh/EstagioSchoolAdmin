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
    public class EsporteCtr
    {
        public Esporte GetInstancia()
        {
            return new Esporte();
        }

        public bool Gravar(Esporte instancia)
        {
            EsporteDAO espDAO = new EsporteDAO();
            if (instancia.Id == 0)
            {
                return espDAO.Inserir(instancia);
            }

            return espDAO.Alterar(instancia);
        }

        public DataTable Consultar(string descricao)
        {
            DataTable resultadoBusca = new DataTable();
            resultadoBusca.Columns.Add("Id", typeof(int));
            resultadoBusca.Columns.Add("Descrição", typeof(string));

            EsporteDAO espDAO = new EsporteDAO();

            foreach (Esporte obj in (espDAO.Consultar(descricao)))
            {
                DataRow linha = resultadoBusca.NewRow();

                linha["Id"] = obj.Id;
                linha["Descrição"] = obj.Descricao;

                resultadoBusca.Rows.Add(linha);
            }
            return resultadoBusca;
        }

        public bool Excluir(int esporte_id)
        {
            EsporteDAO espDAO = new EsporteDAO();
            return espDAO.Excluir(esporte_id);
        }
    }
}
