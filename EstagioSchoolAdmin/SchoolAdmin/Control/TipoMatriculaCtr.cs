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
    public class TipoMatriculaCtr
    {
        public TipoMatricula GetInstancia()
        {
            return new TipoMatricula();
        }

        public bool Gravar(TipoMatricula instancia)
        {
            TipoMatriculaDAO tipDAO = new TipoMatriculaDAO();
            if (instancia.Id == 0)
            {
                return tipDAO.Inserir(instancia);
            }

            return tipDAO.Alterar(instancia);
        }

        public DataTable Consultar(string descricao)
        {
            DataTable resultadoBusca = new DataTable();
            resultadoBusca.Columns.Add("Id", typeof(int));
            resultadoBusca.Columns.Add("Descrição", typeof(string));

            TipoMatriculaDAO tipDAO = new TipoMatriculaDAO();

            foreach (TipoMatricula obj in (tipDAO.Consultar(descricao)))
            {
                DataRow linha = resultadoBusca.NewRow();

                linha["Id"] = obj.Id;
                linha["Descrição"] = obj.Descricao;

                resultadoBusca.Rows.Add(linha);
            }
            return resultadoBusca;
        }

        public bool Excluir(int tipo_id)
        {
            TipoMatriculaDAO tipDAO = new TipoMatriculaDAO();
            return tipDAO.Excluir(tipo_id);
        }
    }
}
