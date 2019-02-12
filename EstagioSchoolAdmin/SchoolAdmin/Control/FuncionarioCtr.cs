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
    public class FuncionarioCtr
    {
        public Funcionario getInstance()
        {
            return new Funcionario();
        }

        public bool Gravar(Funcionario fun, Telefone telefone1, Telefone telefone2)
        {
            FuncionarioDAO funDAO = new FuncionarioDAO();
            TelefoneDAO telDAO = new TelefoneDAO();

            if (fun.Id == 0)
            {
                funDAO.Inserir(fun);
                telefone1.Pessoa = fun;
                telDAO.Inserir(telefone1);
                telefone2.Pessoa = fun;
                telDAO.Inserir(telefone2);

            }
            else
            {
                funDAO.Alterar(fun);
                telefone1.Pessoa = fun;
                telDAO.Alterar(telefone1);
                telefone2.Pessoa = fun;
                telDAO.Alterar(telefone2);
            }

            return true;
        }

        public DataTable Pesquisar(string fun_nome)
        {
            DataTable resultadoBusca = new DataTable();
            resultadoBusca.Columns.Add("Id", typeof(int));
            resultadoBusca.Columns.Add("Nome", typeof(string));
            resultadoBusca.Columns.Add("Cargo", typeof(string));

            FuncionarioDAO funDAO = new FuncionarioDAO();

            foreach (Funcionario obj in (funDAO.Consultar(fun_nome)))
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
            FuncionarioDAO funDAO = new FuncionarioDAO();
            return funDAO.GetFuncionarioById(id);
        }

        public bool Excluir(Funcionario fun)
        {
            EnderecoDAO endDAO = new EnderecoDAO();
            endDAO.Excluir(fun.Id);

            TelefoneDAO telDAO = new TelefoneDAO();
            telDAO.Excluir(fun.Id);

            FuncionarioDAO funDAO = new FuncionarioDAO();
            funDAO.Excluir(fun.Id);

            return true;
        }

        public List<CargoFuncionario> GetListaCargos()
        {
            return new CargoFuncionario().RecuperarLista();
        }

        public List<Telefone> GetTelefones(int fun_id)
        {
            return new TelefoneDAO().Consultar(fun_id);
        }
    }
}
