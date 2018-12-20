using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Model
{
    internal class Pessoa
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

        private bool ativo;

        public bool Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }
    }
}
