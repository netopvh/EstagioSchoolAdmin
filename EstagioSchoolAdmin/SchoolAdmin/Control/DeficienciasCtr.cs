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
    public class DeficienciasCtr
    {
        public Deficiencia GetInstancia()
        {
            return new Deficiencia();
        }

        public bool Gravar(Deficiencia instancia)
        {
            DeficienciaDAO defDAO = new DeficienciaDAO();
            if (instancia.Id == 0)
            {
                return defDAO.Inserir(instancia);
            }

            return defDAO.Alterar(instancia);
        }

        public DataTable Consultar(string descricao)
        {
            DataTable resultadoBusca = new DataTable();
            resultadoBusca.Columns.Add("Id", typeof(int));
            resultadoBusca.Columns.Add("Descrição", typeof(string));

            DeficienciaDAO defDAO = new DeficienciaDAO();

            foreach (Deficiencia obj in (defDAO.Consultar(descricao)))
            {
                DataRow linha = resultadoBusca.NewRow();

                linha["Id"] = obj.Id;
                linha["Descrição"] = obj.Descricao;

                resultadoBusca.Rows.Add(linha);
            }
            return resultadoBusca;
        }

        public bool Excluir(int deficiencia_id)
        {
            DeficienciaDAO defDAO = new DeficienciaDAO();
            return defDAO.Excluir(deficiencia_id);
        }
    }
}
