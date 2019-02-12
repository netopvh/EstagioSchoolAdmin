using SchoolAdmin.Model;
using SchoolAdmin.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Control
{
    public class EnderecosCtr
    {
        public List<Estado> GetListaEstados()
        {
            return new Estado().RecuperarLista();
        }

        public Endereco GetInstance()
        {
            return new Endereco();
        }

        public bool Gravar(Endereco instancia)
        {
            EnderecoDAO endDAO = new EnderecoDAO();
            if(instancia.Id == 0)
            {
                return endDAO.Inserir(instancia);
            }

            return endDAO.Alterar(instancia);
        }

        public Endereco GetEnderecoById(int pessoa_id)
        {
            EnderecoDAO endDAO = new EnderecoDAO();
            return endDAO.GetEnderecoById(pessoa_id);
        }
    }
}
