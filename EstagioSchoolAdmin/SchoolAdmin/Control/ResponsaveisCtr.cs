using SchoolAdmin.Model;
using SchoolAdmin.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Control
{
    public class ResponsaveisCtr
    {

        public Responsavel GetInstancia()
        {
            return new Responsavel();
        }

        public bool Gravar(Responsavel resp, Aluno alu, Telefone telObrigatorio, Telefone telOpcional, Telefone telTrabalho)
        {
            ResponsavelDAO respDAO = new ResponsavelDAO();
            TelefoneDAO telDAO = new TelefoneDAO();

            if(resp.Id == 0)
            {
                respDAO.Inserir(resp, alu);

                telObrigatorio.Pessoa = resp;
                telDAO.Inserir(telObrigatorio);

                telOpcional.Pessoa = resp;
                telDAO.Inserir(telOpcional);

                telTrabalho.Pessoa = resp;
                telDAO.Inserir(telTrabalho);
            }


            return true;
        }
    }
}
