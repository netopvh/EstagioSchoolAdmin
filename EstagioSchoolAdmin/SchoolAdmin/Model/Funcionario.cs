using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Model
{
    class Funcionario
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value > 0 ? value : 0; }
        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private DateTime nascimento;

        public DateTime Nascimento
        {
            get { return nascimento; }
            set { nascimento = value; }
        }

        private char sexo;

        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        private string rg;

        public string RG
        {
            get { return rg; }
            set { rg = value; }
        }

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

        public Funcionario(int id, string nome, DateTime nascimento, char sexo, string rG, string cPF, string telefone, string telefone2, string email, decimal salario, DateTime admissao, DateTime demissao)
        {
            Id = id;
            Nome = nome;
            Nascimento = nascimento;
            Sexo = sexo;
            RG = rG;
            CPF = cPF;
            Telefone = telefone;
            Telefone2 = telefone2;
            Email = email;
            Salario = salario;
            Admissao = admissao;
            Demissao = demissao;
        }

        public Funcionario()
        {
        }
    }
}
