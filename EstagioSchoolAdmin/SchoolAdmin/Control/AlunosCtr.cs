using SchoolAdmin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Control
{
    public class AlunosCtr
    {
        public List<Estado> GetListaEstados()
        {
            return new Estado().RecuperarLista();
        }
    }
}
