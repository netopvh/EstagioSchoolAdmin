using SchoolAdmin.Model;
using SchoolAdmin.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Control
{
    public class ContaPagarCtr
    {
        public ContaAPagar GetInstancia()
        {
            return new ContaAPagar();
        }

        public List<OrigemContaAPagar> GetListaCargos()
        {
            OrigemContaAPagarDAO orgDAO = new OrigemContaAPagarDAO();
            return orgDAO.GetLista();
        }

        public bool GravarLancamento(ContaAPagar conta)
        {
            ContaAPagarDAO conDAO = new ContaAPagarDAO();
            return conDAO.Inserir(conta);
        }
    }
}
