using Npgsql;
using SchoolAdmin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Persistencia
{
    class MedicamentoDAO
    {
        private NpgsqlConnection conexao;

        public NpgsqlConnection Conexao
        {
            get
            {
                return conexao;
            }
        }

        public MedicamentoDAO()
        {
            conexao = Persistencia.Conexao.getInstance().conexaoBD();
        }

        public bool Inserir(Medicamento medicamento)
        {
            string stringSQL = "insert into medicamentos (medi_descricao) values (@descricao)";

            NpgsqlCommand cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);
            this.Conexao.Open();

            cmdIncluir.Parameters.AddWithValue("@descricao", medicamento.Descricao);

            cmdIncluir.ExecuteNonQuery();
            this.Conexao.Close();

            return true;
        }

        public bool Alterar(Medicamento medicamento)
        {
            string stringSQL = "update medicamentos set medi_descricao=@descricao where medi_pk=@codigo";

            NpgsqlCommand cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);
            this.Conexao.Open();

            cmdIncluir.Parameters.AddWithValue("@descricao", medicamento.Descricao);
            cmdIncluir.Parameters.AddWithValue("@codigo", medicamento.Id);

            cmdIncluir.ExecuteNonQuery();
            this.Conexao.Close();

            return true;
        }

        public List<Medicamento> GetLista()
        {
            List<Medicamento> lista = null;
            string stringSQL = "select medi_pk, medi_descricao from medicamentos";

            NpgsqlCommand cmdConsultar = new NpgsqlCommand(stringSQL, this.Conexao);
            this.Conexao.Open();

            NpgsqlDataReader resultado = cmdConsultar.ExecuteReader();

            if (resultado.HasRows)
            {
                lista = new List<Medicamento>();
                while (resultado.Read())
                {
                    Medicamento med = new Medicamento();
                    med.Id = resultado.GetInt32(0);
                    med.Descricao = resultado.GetString(1);

                    lista.Add(med);
                }
            }
            resultado.Close();
            this.Conexao.Close();

            return lista;
        }

        public List<Medicamento> Consultar(string descricao)
        {
            List<Medicamento> lista = new List<Medicamento>();
            string stringSQL = "select " +
                "medi_pk, medi_descricao " +
              "from medicamentos where medi_descricao ilike @descricao";

            NpgsqlCommand cmdConsultar = new NpgsqlCommand(stringSQL, this.Conexao);
            this.Conexao.Open();
            cmdConsultar.Parameters.AddWithValue("@descricao", "%" + descricao + "%");

            NpgsqlDataReader resultado = cmdConsultar.ExecuteReader();

            if (resultado.HasRows)
            {
                lista = new List<Medicamento>();
                while (resultado.Read())
                {
                    Medicamento med = new Medicamento();
                    med.Id = resultado.GetInt32(0);
                    med.Descricao = resultado.GetString(1);

                    lista.Add(med);
                }
            }
            resultado.Close();
            this.Conexao.Close();

            return lista;
        }

        public bool Excluir(int medicamento_id)
        {
            string stringSQL = "delete from medicamentos where medi_pk=@codigo";

            NpgsqlCommand cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);
            this.Conexao.Open();

            cmdIncluir.Parameters.AddWithValue("@codigo", medicamento_id);

            cmdIncluir.ExecuteNonQuery();
            this.Conexao.Close();

            return true;
        }
    }
}
