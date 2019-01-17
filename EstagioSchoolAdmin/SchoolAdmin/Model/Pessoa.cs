using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Model
{
    public class Pessoa
    {
        public int Id { get; set; }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value.Trim(); }
        }

        private string sexo;

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value.ToLower(); }
        }

        public DateTime DataNascimento { get; set; }

        private string rg;

        public string Rg
        {
            get { return rg; }
            set
            {
                rg = value.Replace(".", "").Replace("-", "").Replace(",", "").Replace(" ", "").Trim();
            }
        }

        public bool Ativo { get; set; }
        public virtual ICollection<Telefone> Telefones { get; set; }
        public virtual ICollection<Endereco> Enderecos { get; set; }

        public Pessoa()
        {
            this.Id = 0;
        }
    }
}
