using SchoolAdmin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Control
{
    public class FuncionarioCtr
    {
        public Funcionario getInstance()
        {
            return new Funcionario();
        }

        public void Gravar(Funcionario fun)
        {
            fun.Salvar();
        }

        public void Pesquisar(string fun_nome)
        {

        }

        public void Excluir(int fun_id)
        {

        }

        public List<CargoFuncionario> GetListaCargos()
        {
            return new CargoFuncionario().RecuperarLista();
        }

    }
}
