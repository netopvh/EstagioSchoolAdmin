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
    public class OrigemContaAPagarCtr
    {
        public OrigemContaAPagar GetInstancia()
        {
            return new OrigemContaAPagar();
        }

        public bool Gravar(OrigemContaAPagar instancia)
        {
            OrigemContaAPagarDAO orgDAO = new OrigemContaAPagarDAO();
            if (instancia.Id == 0)
            {
                return orgDAO.Inserir(instancia);
            }

            return orgDAO.Alterar(instancia);
        }

        public DataTable Consultar(string descricao)
        {
            DataTable resultadoBusca = new DataTable();
            resultadoBusca.Columns.Add("Id", typeof(int));
            resultadoBusca.Columns.Add("Descrição", typeof(string));

            OrigemContaAPagarDAO orgDAO = new OrigemContaAPagarDAO();

            foreach (OrigemContaAPagar obj in (orgDAO.Consultar(descricao)))
            {
                DataRow linha = resultadoBusca.NewRow();

                linha["Id"] = obj.Id;
                linha["Descrição"] = obj.Descricao;

                resultadoBusca.Rows.Add(linha);
            }
            return resultadoBusca;
        }

        public bool Excluir(int origem_id)
        {
            OrigemContaAPagarDAO orgDAO = new OrigemContaAPagarDAO();
            return orgDAO.Excluir(origem_id);
        }
    }
}
