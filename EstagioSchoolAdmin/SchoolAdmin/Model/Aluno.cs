using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Model
{
    public class Aluno : Pessoa
    {
        public string Municipio { get; set; }
        public Estado Estado { get; set; }
    }
}
