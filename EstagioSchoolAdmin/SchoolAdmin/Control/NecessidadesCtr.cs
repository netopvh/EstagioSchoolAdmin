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
    public class NecessidadesCtr
    {
         public NecessidadeEspecial GetInstancia()
        {
            return new NecessidadeEspecial();
        }

        public bool Gravar(NecessidadeEspecial instancia)
        {
            NecessidadeEspecialDAO necDAO = new NecessidadeEspecialDAO();
            if (instancia.Id == 0)
            {
                return necDAO.Inserir(instancia);
            }

            return necDAO.Alterar(instancia);
        }

        public DataTable Consultar(string descricao)
        {
            DataTable resultadoBusca = new DataTable();
            resultadoBusca.Columns.Add("Id", typeof(int));
            resultadoBusca.Columns.Add("Descrição", typeof(string));

            NecessidadeEspecialDAO necDAO = new NecessidadeEspecialDAO();

            foreach (NecessidadeEspecial obj in (necDAO.Consultar(descricao)))
            {
                DataRow linha = resultadoBusca.NewRow();

                linha["Id"] = obj.Id;
                linha["Descrição"] = obj.Descricao;

                resultadoBusca.Rows.Add(linha);
            }
            return resultadoBusca;
        }

        public bool Excluir(int necessidade_id)
        {
            NecessidadeEspecialDAO necDAO = new NecessidadeEspecialDAO();
            return necDAO.Excluir(necessidade_id);
        }
    }
}
