using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Model
{
    public class TipoMatricula
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public TipoMatricula()
        {
            Id = 0;
        }
    }
}
