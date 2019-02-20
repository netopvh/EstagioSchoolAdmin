using SchoolAdmin.Control;
using SchoolAdmin.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolAdmin.View
{
    public partial class frmGerenciarEstados : Form
    {
        private EstadoCtr controller;
        private Estado instancia;

        public frmGerenciarEstados(EstadoCtr ctr)
        {
            InitializeComponent();

            controller = ctr;
            InicializarControles();
        }

        public void InicializarControles()
        {
            txtPesquisar.Clear();
            txtNome.Clear();
            txtSigla.Clear();
            btnExcluir.Enabled = false;
            instancia = controller.GetInstancia();
            InicializarGridView();
        }

        private void InicializarGridView()
        {
            DataTable resultado = new DataTable();
            resultado.Columns.Add("Id", typeof(int));
            resultado.Columns.Add("Nome", typeof(string));
            resultado.Columns.Add("Sigla", typeof(string));

            AtualizarGrid(resultado);
        }

        private void AtualizarGrid(DataTable resultado)
        {
            dgvEstados.DataSource = resultado;
            dgvEstados.Refresh();
        }

        private void CarregarDados()
        {
            txtNome.Text = instancia.Nome;
            txtSigla.Text = instancia.Sigla;
            btnExcluir.Enabled = true;
        }

        private void dgvEstados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string estadoSelecionado = dgvEstados.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (!string.IsNullOrEmpty(estadoSelecionado))
                {
                    instancia.Id = Convert.ToInt32(estadoSelecionado);
                    instancia.Nome = dgvEstados.Rows[e.RowIndex].Cells[1].Value.ToString();
                    instancia.Sigla = dgvEstados.Rows[e.RowIndex].Cells[2].Value.ToString();

                    MessageBox.Show("O registro foi selecionado com sucesso e pode ser alterado.",
                                "Registro selecionado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                    CarregarDados();
                }
            }
            catch
            {
                MessageBox.Show("Atenção, não existem dados para ser selecionados na tabela. " +
                    "Você pode realizar uma pesquisa ou cadastradar um novo registro.",
                                "Atenção!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string sigla = txtSigla.Text.Trim();

            if (!string.IsNullOrWhiteSpace(nome) && !string.IsNullOrWhiteSpace(sigla))
            {
                instancia.Nome = nome;
                instancia.Sigla = sigla;

                if (controller.Gravar(instancia))
                {
                    MessageBox.Show("Todos os dados foram salvos com sucesso.",
                               "Gravação realizada",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                    InicializarControles();
                }
            }
            else
            {
                MessageBox.Show("Atenção, os campos não foram preenchidos corretamente. " +
                    "Informe uma descrição e uma sigla para prosseguir com o cadastro.",
                                "Erro, campo não descrição não informado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtPesquisar.Text.Trim();
            AtualizarGrid(new EstadoCtr().Consultar(nome));
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            InicializarControles();
            InicializarGridView();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (controller.Excluir(instancia.Id))
            {
                MessageBox.Show("Todos os dados foram excluidos.",
                               "Exclusão realizada",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);

                InicializarControles();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
