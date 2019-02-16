using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Model
{
    public class Responsavel : Pessoa
    {
        public string Parentesco { get; set; }
        public string OutroParentesco { get; set; }
        public string  EstadoCivil { get; set; }
        public string NomeConjuge { get; set; }
        public string CPF { get; set; }
        public bool MoraMesmoEnderecoAluno { get; set; }
        public string Profissao { get; set; }
    }
}
