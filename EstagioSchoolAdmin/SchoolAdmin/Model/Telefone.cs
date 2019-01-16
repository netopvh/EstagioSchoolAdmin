using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Model
{
    public class Telefone
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }

        public Telefone() { }
    }
}
