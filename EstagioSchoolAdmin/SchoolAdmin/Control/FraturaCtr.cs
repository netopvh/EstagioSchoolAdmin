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
    public class FraturaCtr
    {
        public Fratura GetInstancia()
        {
            return new Fratura();
        }

        public bool Gravar(Fratura instancia)
        {
            FraturaDAO fratDAO = new FraturaDAO();
            if (instancia.Id == 0)
            {
                return fratDAO.Inserir(instancia);
            }

            return fratDAO.Alterar(instancia);
        }

        public DataTable Consultar(string descricao)
        {
            DataTable resultadoBusca = new DataTable();
            resultadoBusca.Columns.Add("Id", typeof(int));
            resultadoBusca.Columns.Add("Descrição", typeof(string));

            FraturaDAO fratDAO = new FraturaDAO();

            foreach (Fratura obj in (fratDAO.Consultar(descricao)))
            {
                DataRow linha = resultadoBusca.NewRow();

                linha["Id"] = obj.Id;
                linha["Descrição"] = obj.Descricao;

                resultadoBusca.Rows.Add(linha);
            }
            return resultadoBusca;
        }

        public bool Excluir(int fratura_id)
        {
            FraturaDAO fratDAO = new FraturaDAO();
            return fratDAO.Excluir(fratura_id);
        }
    }
}
