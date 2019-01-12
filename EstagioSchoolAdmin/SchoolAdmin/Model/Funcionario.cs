using SchoolAdmin.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Model
{
    public class Funcionario : Pessoa
    {
        private string cpf;

        public string Cpf
        {
            get { return cpf; }
            set
            {
                cpf = value.Replace(".", "").Replace("-", "").Replace(",", "").Replace(" ", "").Trim(); ;
            }
        }

        public string Email { get; set; }

        public Decimal Salario { get; set; }

        public DateTime Admissao { get; set; }
        public DateTime Desligamento { get; set; }
        public string Observacoes { get; set; }

        public int CargoId { get; set; }
        public virtual CargoFuncionario Cargo { get; set; }

        public Funcionario() { }

        public List<Funcionario> RecuperarLista(string nome)
        {
            var ret = new List<Funcionario>();

            using (var db = new ContextoDB())
            {
                ret = db.FuncionariosMap
                            .Where(o => o.Nome.ToLower().Contains(nome.ToLower())).Include(o => o.Cargo).OrderBy(o => o.Id).ToList();
            }

            return ret;
        }

        public Funcionario ConsultarPeloId(int id)
        {
            Funcionario ret = null;
            using (var db = new ContextoDB())
            {
                ret = db.PessoaMap.Find(id) as Funcionario;
            }
            return ret;
        }

        public bool Salvar()
        {
            var ret = 0;
            var model = ConsultarPeloId(this.Id);

            using (var db = new ContextoDB())
            {
                if (this.Cargo != null)
                {
                    this.CargoId = this.Cargo.Id;
                    this.Cargo = null;
                }

                if (model == null)
                {
                    db.PessoaMap.Add(this);
                }
                else
                {
                    db.PessoaMap.Attach(this);
                    db.Entry(this).State = EntityState.Modified;
                }
                db.SaveChanges();
                ret = this.Id;
            }
            return !(ret == 0);
        }

        public bool Excluir(int id)
        {
            var ret = false;
            Funcionario obj = ConsultarPeloId(id);

            if (obj != null)
            {
                using (var db = new ContextoDB())
                {
                    db.PessoaMap.Attach(obj);
                    db.Entry(obj).State = EntityState.Deleted;
                    db.SaveChanges();
                    ret = true;
                }
            }
            return ret;
        }
    }
}
