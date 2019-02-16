using SchoolAdmin.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Model
{
    public class Telefone
    {
        public int Id { get; set; }
        public string Numero { get; set; }

        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }

        public Telefone() { }

        public Telefone ConsultarPeloId(int id)
        {
            Telefone ret = null;
            using (var db = new ContextoDB())
            {
                ret = db.TelefonesMap.Find(id);
            }

            if (ret != null)
            {
                ret.Pessoa = new Funcionario().ConsultarPeloId(ret.PessoaId);
            }

            return ret;
        }

        public bool Salvar()
        {
            var ret = 0;
            var model = ConsultarPeloId(this.Id);

            using (var db = new ContextoDB())
            {
                if (this.Pessoa != null)
                {
                    this.PessoaId = this.Pessoa.Id;
                    this.Pessoa = null;
                }

                if (model == null)
                {
                    db.TelefonesMap.Add(this);
                }
                else
                {
                    db.TelefonesMap.Attach(this);
                    db.Entry(this).State = EntityState.Modified;
                }
                db.SaveChanges();
                ret = this.Id;
            }
            return !(ret == 0);
        }

        public List<Telefone> RecuperarTelefones(Funcionario fun)
        {
            var ret = new List<Telefone>();

            using (var db = new ContextoDB())
            {
                ret = db.TelefonesMap.Where(t => t.PessoaId == fun.Id).ToList();
            }

            return ret;
        }

        public bool Excluir(int id)
        {
            var ret = false;

            if (id != 0)
            {
                using (var db = new ContextoDB())
                {
                    db.TelefonesMap.RemoveRange(db.TelefonesMap.Where(t => t.PessoaId == id));
                    db.SaveChanges();
                    ret = true;
                }
            }
            return ret;
        }
    }
}
