using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Model
{
    class CargoFuncionario
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

    }
}
