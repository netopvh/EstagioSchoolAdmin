using Npgsql;
using SchoolAdmin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Persistencia
{
    class OrigemContaAPagarDAO
    {
        private NpgsqlConnection conexao;

        public NpgsqlConnection Conexao
        {
            get
            {
                return conexao;
            }
        }

        public OrigemContaAPagarDAO()
        {
            conexao = Persistencia.Conexao.getInstance().conexaoBD();
        }

        public List<OrigemContaAPagar> GetLista()
        {
            List<OrigemContaAPagar> lista = null;
            string stringSQL = "select org_pk, org_descricao from origens_conta";

            NpgsqlCommand cmdConsultar = new NpgsqlCommand(stringSQL, this.Conexao);
            this.Conexao.Open();

            NpgsqlDataReader resultado = cmdConsultar.ExecuteReader();

            if (resultado.HasRows)
            {
                lista = new List<OrigemContaAPagar>();
                while (resultado.Read())
                {
                    OrigemContaAPagar org = new OrigemContaAPagar();
                    org.Id = resultado.GetInt32(0);
                    org.Descricao = resultado.GetString(1);

                    lista.Add(org);
                }
            }
            resultado.Close();
            this.Conexao.Close();

            return lista;
        }
    }
}
