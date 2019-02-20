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
    public class MedicamentosCtr
    {
        public Medicamento GetInstancia()
        {
            return new Medicamento();
        }

        public bool Gravar(Medicamento instancia)
        {
            MedicamentoDAO medDAO = new MedicamentoDAO();
            if (instancia.Id == 0)
            {
                return medDAO.Inserir(instancia);
            }

            return medDAO.Alterar(instancia);
        }

        public DataTable Consultar(string descricao)
        {
            DataTable resultadoBusca = new DataTable();
            resultadoBusca.Columns.Add("Id", typeof(int));
            resultadoBusca.Columns.Add("Descrição", typeof(string));

            MedicamentoDAO medDao = new MedicamentoDAO();

            foreach (Medicamento obj in (medDao.Consultar(descricao)))
            {
                DataRow linha = resultadoBusca.NewRow();

                linha["Id"] = obj.Id;
                linha["Descrição"] = obj.Descricao;

                resultadoBusca.Rows.Add(linha);
            }
            return resultadoBusca;
        }

        public bool Excluir(int medicamento_id)
        {
            MedicamentoDAO medDAO = new MedicamentoDAO();
            return medDAO.Excluir(medicamento_id);
        }
    }
}
