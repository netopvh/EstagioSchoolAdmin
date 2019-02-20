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
    public class TratamentoSaudeCtr
    {
        public TratamentoSaude GetInstancia()
        {
            return new TratamentoSaude();
        }

        public bool Gravar(TratamentoSaude instancia)
        {
            TratamentoSaudeDAO tratDAO = new TratamentoSaudeDAO();
            if (instancia.Id == 0)
            {
                return tratDAO.Inserir(instancia);
            }

            return tratDAO.Alterar(instancia);
        }

        public DataTable Consultar(string descricao)
        {
            DataTable resultadoBusca = new DataTable();
            resultadoBusca.Columns.Add("Id", typeof(int));
            resultadoBusca.Columns.Add("Descrição", typeof(string));

            TratamentoSaudeDAO tratDAO = new TratamentoSaudeDAO();

            foreach (TratamentoSaude obj in (tratDAO.Consultar(descricao)))
            {
                DataRow linha = resultadoBusca.NewRow();

                linha["Id"] = obj.Id;
                linha["Descrição"] = obj.Descricao;

                resultadoBusca.Rows.Add(linha);
            }
            return resultadoBusca;
        }

        public bool Excluir(int tratamento_id)
        {
            TratamentoSaudeDAO tratDAO = new TratamentoSaudeDAO();
            return tratDAO.Excluir(tratamento_id);
        }
    }
}
