using SchoolAdmin.Model;
using SchoolAdmin.Persistencia;
using System;
using System.Collections.Generic;
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
            return aluDAO.Inserir(aluno);
        }
    }
}
