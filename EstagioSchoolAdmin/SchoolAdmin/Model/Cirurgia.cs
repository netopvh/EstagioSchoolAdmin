using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Model
{
    public class Cirurgia
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public Cirurgia()
        {
            Id = 0;
        }
    }
}
