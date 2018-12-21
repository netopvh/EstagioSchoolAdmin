using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Model
{
    public class CargoFuncionario
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value > 0 ? value : 0; }
        }

        private string cargo;

        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }

        public virtual ICollection<Funcionario> Funcionarios { get; set; }

        public CargoFuncionario()
        {
            Funcionarios = new HashSet<Funcionario>();
        }

    }
}
