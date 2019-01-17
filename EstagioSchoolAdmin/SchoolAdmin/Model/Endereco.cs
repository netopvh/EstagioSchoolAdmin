using SchoolAdmin.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Model
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }

        public int EstadoId { get; set; }
        public virtual Estado Estado { get; set; }

        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }


        public Endereco()
        {
            Id = 0;
        }

        public Endereco ConsultarPeloId(int pessoa_id)
        {
            Endereco ret = null;
            using (var db = new ContextoDB())
            { 
                ret = db.EnderecoMap.Where(e => e.PessoaId == pessoa_id).FirstOrDefault();
            }

            if (ret != null)
            {
                ret.Pessoa = new Funcionario().ConsultarPeloId(ret.PessoaId);
                ret.Estado = new Estado().ConsultarPeloId(ret.EstadoId);
            }

            return ret;
        }

        public bool Salvar()
        {
            var ret = 0;
            var model = ConsultarPeloId(this.PessoaId);

            using (var db = new ContextoDB())
            {
                if (this.Estado != null)
                {
                    this.EstadoId = this.Estado.Id;
                    this.Estado = null;
                }

                if (this.Pessoa != null)
                {
                    this.PessoaId = this.Pessoa.Id;
                    this.Pessoa = null;
                }

                if (model == null)
                {
                    db.EnderecoMap.Add(this);
                }
                else
                {
                    db.EnderecoMap.Attach(this);
                    db.Entry(this).State = EntityState.Modified;
                }

                db.SaveChanges();
                ret = this.Id;
            }
            return !(ret == 0);
        }
    }
}
