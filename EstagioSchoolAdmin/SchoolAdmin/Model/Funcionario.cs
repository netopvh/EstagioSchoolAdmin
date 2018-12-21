using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Model
{
    public class Funcionario : Pessoa
    {
        private string cpf;

        public string CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }

        private string telefone;

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        private string  telefone2;

        public string  Telefone2
        {
            get { return telefone2; }
            set { telefone2 = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private Decimal salario;

        public Decimal Salario
        {
            get { return salario; }
            set { salario = value > 0 ? value : 0; }
        }

        private DateTime admissao;

        public DateTime Admissao
        {
            get { return admissao; }
            set { admissao = value; }
        }

        private DateTime demissao;

        public DateTime Demissao
        {
            get { return demissao; }
            set { demissao = value; }
        }

        private int cargo_id;
        public virtual CargoFuncionario Cargo { get; set; }

        public int CargoId
        {
            get { return cargo_id; }
            set { cargo_id = value > 0 ? value : 0; }
        }

        private string observacoes;

        public string Observacoes
        {
            get { return observacoes; }
            set { observacoes = value; }
        }

        public Funcionario(string cPF, string telefone, string telefone2, string email, decimal salario, DateTime admissao, DateTime demissao, CargoFuncionario cargo, int cargoId, string observacoes)
        {
            CPF = cPF;
            Telefone = telefone;
            Telefone2 = telefone2;
            Email = email;
            Salario = salario;
            Admissao = admissao;
            Demissao = demissao;
            Cargo = cargo;
            CargoId = cargoId;
            Observacoes = observacoes;
        }

        public Funcionario()
        {
        }
    }
}
