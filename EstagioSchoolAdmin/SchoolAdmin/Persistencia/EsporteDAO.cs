using Npgsql;
using SchoolAdmin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Persistencia
{
    class EsporteDAO
    {
        private NpgsqlConnection conexao;

        public NpgsqlConnection Conexao
        {
            get
            {
                return conexao;
            }
        }

        public EsporteDAO()
        {
            conexao = Persistencia.Conexao.getInstance().conexaoBD();
        }

        public bool Inserir(Esporte esporte)
        {
            string stringSQL = "insert into esportes (esp_descricao) values (@descricao)";

            NpgsqlCommand cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);
            this.Conexao.Open();

            cmdIncluir.Parameters.AddWithValue("@descricao", esporte.Descricao);

            cmdIncluir.ExecuteNonQuery();
            this.Conexao.Close();

            return true;
        }

        public bool Alterar(Esporte esporte)
        {
            string stringSQL = "update esportes set esp_descricao=@descricao where esp_pk=@codigo";

            NpgsqlCommand cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);
            this.Conexao.Open();

            cmdIncluir.Parameters.AddWithValue("@descricao", esporte.Descricao);
            cmdIncluir.Parameters.AddWithValue("@codigo", esporte.Id);

            cmdIncluir.ExecuteNonQuery();
            this.Conexao.Close();

            return true;
        }

        public List<Esporte> GetLista()
        {
            List<Esporte> lista = null;
            string stringSQL = "select esp_pk, esp_descricao from esportes";

            NpgsqlCommand cmdConsultar = new NpgsqlCommand(stringSQL, this.Conexao);
            this.Conexao.Open();

            NpgsqlDataReader resultado = cmdConsultar.ExecuteReader();

            if (resultado.HasRows)
            {
                lista = new List<Esporte>();
                while (resultado.Read())
                {
                    Esporte esp = new Esporte();
                    esp.Id = resultado.GetInt32(0);
                    esp.Descricao = resultado.GetString(1);

                    lista.Add(esp);
                }
            }
            resultado.Close();
            this.Conexao.Close();

            return lista;
        }

        public List<Esporte> Consultar(string descricao)
        {
            List<Esporte> lista = new List<Esporte>();
            string stringSQL = "select " +
                "esp_pk, esp_descricao " +
              "from esportes where esp_descricao ilike @descricao";

            NpgsqlCommand cmdConsultar = new NpgsqlCommand(stringSQL, this.Conexao);
            this.Conexao.Open();
            cmdConsultar.Parameters.AddWithValue("@descricao", "%" + descricao + "%");

            NpgsqlDataReader resultado = cmdConsultar.ExecuteReader();

            if (resultado.HasRows)
            {
                lista = new List<Esporte>();
                while (resultado.Read())
                {
                    Esporte esp = new Esporte();
                    esp.Id = resultado.GetInt32(0);
                    esp.Descricao = resultado.GetString(1);

                    lista.Add(esp);
                }
            }
            resultado.Close();
            this.Conexao.Close();

            return lista;
        }

        public bool Excluir(int esporte_id)
        {
            string stringSQL = "delete from esportes where esp_pk=@codigo";

            NpgsqlCommand cmdIncluir = new NpgsqlCommand(stringSQL, this.conexao);
            this.Conexao.Open();

            cmdIncluir.Parameters.AddWithValue("@codigo", esporte_id);

            cmdIncluir.ExecuteNonQuery();
            this.Conexao.Close();

            return true;
        }
    }
}
