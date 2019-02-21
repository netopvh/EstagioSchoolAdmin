﻿using SchoolAdmin.Model;
using SchoolAdmin.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Control
{
    public class CirurgiasCtr
    {
        public Cirurgia GetInstancia()
        {
            return new Cirurgia();
        }

        public bool Gravar(Cirurgia instancia)
        {
            CirurgiaDAO cirDAO = new CirurgiaDAO();
            if (instancia.Id == 0)
            {
                return cirDAO.Inserir(instancia);
            }

            return cirDAO.Alterar(instancia);
        }

        public DataTable Consultar(string descricao)
        {
            DataTable resultadoBusca = new DataTable();
            resultadoBusca.Columns.Add("Id", typeof(int));
            resultadoBusca.Columns.Add("Descrição", typeof(string));

            CirurgiaDAO cirDAO = new CirurgiaDAO();

            foreach (Cirurgia obj in (cirDAO.Consultar(descricao)))
            {
                DataRow linha = resultadoBusca.NewRow();

                linha["Id"] = obj.Id;
                linha["Descrição"] = obj.Descricao;

                resultadoBusca.Rows.Add(linha);
            }
            return resultadoBusca;
        }

        public bool Excluir(int cirurgia_id)
        {
            CirurgiaDAO cirDAO = new CirurgiaDAO();
            return cirDAO.Excluir(cirurgia_id);
        }
    }
}
