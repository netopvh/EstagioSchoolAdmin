using SchoolAdmin.Model;
using SchoolAdmin.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
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

        public DataTable Pesquisar(string resp_nome, Aluno aluno)
        {
            DataTable resultadoBusca = new DataTable();
            resultadoBusca.Columns.Add("Id", typeof(int));
            resultadoBusca.Columns.Add("Nome", typeof(string));
            resultadoBusca.Columns.Add("Parentesco", typeof(string));

            ResponsavelDAO respDAO = new ResponsavelDAO();
            foreach (Responsavel obj in (respDAO.Consultar(resp_nome, aluno)))
            {
                DataRow linha = resultadoBusca.NewRow();

                linha["Id"] = obj.Id;
                linha["Nome"] = obj.Nome;
                if(obj.OutroParentesco.Length > 0)
                {
                    linha["Parentesco"] = obj.OutroParentesco;
                }
                else
                {
                    switch(obj.Parentesco)
                    {
                        case "P":
                            linha["Parentesco"] = "PAI";
                            break;

                        case "M":
                            linha["Parentesco"] = "MÃE";
                            break;
                        case "A":
                            linha["Parentesco"] = "AVÔ/AVÓ";
                            break;
                    }
                }


                resultadoBusca.Rows.Add(linha);
            }
            return resultadoBusca;
        }
    }
}
