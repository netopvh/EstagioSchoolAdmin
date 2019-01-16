using SchoolAdmin.Model;
using System;
using System.Collections.Generic;
using System.Data;
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

        public bool Gravar(Funcionario fun)
        {
            return fun.Salvar();
        }

        public DataTable Pesquisar(string fun_nome)
        {
            DataTable resultadoBusca = new DataTable();
            resultadoBusca.Columns.Add("Id", typeof(int));
            resultadoBusca.Columns.Add("Nome", typeof(string));
            resultadoBusca.Columns.Add("Cargo", typeof(string));

            foreach (Funcionario obj in (new Funcionario().RecuperarLista(fun_nome)))
            {
                DataRow linha = resultadoBusca.NewRow();

                linha["Id"] = obj.Id;
                linha["Nome"] = obj.Nome;
                linha["Cargo"] = obj.Cargo.Cargo;

                resultadoBusca.Rows.Add(linha);
            }
            return resultadoBusca;
        }

        public Funcionario GetFuncionarioById(int id)
        {
            return new Funcionario().ConsultarPeloId(id);
        }

        public bool Excluir(Funcionario fun)
        {
            return fun.Excluir(fun.Id);
        }

        public List<CargoFuncionario> GetListaCargos()
        {
            return new CargoFuncionario().RecuperarLista();
        }

    }
}
