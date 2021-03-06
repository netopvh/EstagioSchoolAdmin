﻿using SchoolAdmin.Control;
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
    public partial class frmGerenciarMedicamentos : Form
    {
        private MedicamentosCtr controller;
        private Medicamento instancia;

        public frmGerenciarMedicamentos(MedicamentosCtr ctr)
        {
            InitializeComponent();

            controller = ctr;
            InicializarControles();
        }

        public void InicializarControles()
        {
            txtPesquisar.Clear();
            txtDescricao.Clear();
            btnExcluir.Enabled = false;
            instancia = controller.GetInstancia();
            InicializarGridView();
        }

        private void InicializarGridView()
        {
            DataTable resultado = new DataTable();
            resultado.Columns.Add("Id", typeof(int));
            resultado.Columns.Add("Descrição", typeof(string));

            AtualizarGrid(resultado);
        }

        private void AtualizarGrid(DataTable resultado)
        {
            dgvMedicamentos.DataSource = resultado;
            dgvMedicamentos.Refresh();
        }

        private void CarregarDados()
        {
            txtDescricao.Text = instancia.Descricao;
            btnExcluir.Enabled = true;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string descricao = txtPesquisar.Text.Trim();
            AtualizarGrid(controller.Consultar(descricao));
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string descricao = txtDescricao.Text.Trim();

            if (!string.IsNullOrWhiteSpace(descricao))
            {
                instancia.Descricao = descricao;

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

        private void dgvMedicamentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string tipoSelecionado = dgvMedicamentos.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (!string.IsNullOrEmpty(tipoSelecionado))
                {
                    instancia.Id = Convert.ToInt32(tipoSelecionado);
                    instancia.Descricao = dgvMedicamentos.Rows[e.RowIndex].Cells[1].Value.ToString();

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
    }
}
