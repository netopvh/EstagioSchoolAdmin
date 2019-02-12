using SchoolAdmin.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Model
{
    public class Estado
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public virtual ICollection<Endereco> Enderecos { get; set; }

        public Estado()
        {
            Id = 0;
            Enderecos = new HashSet<Endereco>();
        }

        public List<Estado> RecuperarLista()
        {
            var ret = new List<Estado>();

            using (var db = new ContextoDB())
            {
                ret = db.EstadoMap.OrderBy(x => x.Id).ToList();
            }

            return ret;
        }

        public Estado ConsultarPeloId(int id)
        {
            Estado ret = null;
            using (var db = new ContextoDB())
            {
                ret = db.EstadoMap.Find(id);
            }
            return ret;
        }

        public override bool Equals(object obj)
        {
            var item = obj as Estado;

            if (item == null)
            {
                return false;
            }

            return this.Id == item.Id && this.Nome.Equals(item.Nome) && this.Sigla.Equals(item.Sigla);
        }
    }
}
