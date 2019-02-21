using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Model
{
    public class Deficiencia
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public Deficiencia()
        {
            Id = 0;
        }
    }
}
