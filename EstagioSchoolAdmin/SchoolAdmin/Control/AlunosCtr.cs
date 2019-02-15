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
    public class AlunosCtr
    {
        public Aluno GetInstancia()
        {
            return new Aluno();
        }

        public List<Estado> GetListaEstados()
        {
            return new Estado().RecuperarLista();
        }

        public bool Gravar(Aluno aluno)
        {
            AlunoDAO aluDAO = new AlunoDAO();

            if (aluno.Id > 0)
                return aluDAO.Alterar(aluno);

            return aluDAO.Inserir(aluno);
        }

        public DataTable Pesquisar(string fun_nome)
        {
            DataTable resultadoBusca = new DataTable();
            resultadoBusca.Columns.Add("Id", typeof(int));
            resultadoBusca.Columns.Add("Nome", typeof(string));
            resultadoBusca.Columns.Add("DataNascimento", typeof(DateTime));

            AlunoDAO aluDAO = new AlunoDAO();

            foreach (Aluno obj in (aluDAO.Consultar(fun_nome)))
            {
                DataRow linha = resultadoBusca.NewRow();

                linha["Id"] = obj.Id;
                linha["Nome"] = obj.Nome;
                linha["DataNascimento"] = obj.DataNascimento.Date;

                resultadoBusca.Rows.Add(linha);
            }

            return resultadoBusca;
        }

        public Aluno GetAlunoById(int id)
        {
            AlunoDAO aluDAO = new AlunoDAO();
            return aluDAO.GetAlunoById(id);
        }

        public bool Excluir(Aluno aluno)
        {
            AlunoDAO aluDAO = new AlunoDAO();
            aluDAO.Excluir(aluno.Id);

            return true;
        }
    }
}
