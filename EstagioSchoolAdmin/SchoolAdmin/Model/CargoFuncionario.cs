using SchoolAdmin.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Model
{
    public class CargoFuncionario
    {
        public CargoFuncionario()
        {
            Funcionarios = new HashSet<Funcionario>();
        }

        public int Id { get; set; }
        public string Cargo { get; set; }

        public virtual ICollection<Funcionario> Funcionarios { get; set; }

        public List<CargoFuncionario> RecuperarLista()
        {
            var ret = new List<CargoFuncionario>();

            using (var db = new ContextoDB())
            {
                ret = db.CargosMap.OrderBy(x => x.Id).ToList();
            }

            return ret;
        }

        public CargoFuncionario ConsultarPeloId(int id)
        {
            CargoFuncionario ret = null;
            using (var db = new ContextoDB())
            {
                ret = db.CargosMap.Find(id);
            }
            return ret;
        }

        public override bool Equals(object obj)
        {
            var item = obj as CargoFuncionario;

            if (item == null)
            {
                return false;
            }

            return this.Id == item.Id && this.Cargo.Equals(item.Cargo);
        }

    }
}
