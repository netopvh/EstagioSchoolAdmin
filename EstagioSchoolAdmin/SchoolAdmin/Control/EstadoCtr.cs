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
    public class EstadoCtr
    {
        public Estado GetInstancia()
        {
            return new Estado();
        }

        public bool Gravar(Estado instancia)
        {
            EstadoDAO estDAO = new EstadoDAO();
            if (instancia.Id == 0)
            {
                return estDAO.Inserir(instancia);
            }

            return estDAO.Alterar(instancia);
        }

        public DataTable Consultar(string nome)
        {
            DataTable resultadoBusca = new DataTable();
            resultadoBusca.Columns.Add("Id", typeof(int));
            resultadoBusca.Columns.Add("Nome", typeof(string));
            resultadoBusca.Columns.Add("Sigla", typeof(string));

            EstadoDAO estDAO = new EstadoDAO();

            foreach (Estado obj in (estDAO.Consultar(nome)))
            {
                DataRow linha = resultadoBusca.NewRow();

                linha["Id"] = obj.Id;
                linha["Nome"] = obj.Nome;
                linha["Sigla"] = obj.Sigla;

                resultadoBusca.Rows.Add(linha);
            }
            return resultadoBusca;
        }

        public bool Excluir(int estado_id)
        {
            EstadoDAO estDAO = new EstadoDAO();
            return estDAO.Excluir(estado_id);
        }
    }
}

