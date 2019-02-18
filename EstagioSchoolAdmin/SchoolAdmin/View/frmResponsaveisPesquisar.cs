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
    public partial class frmResponsaveisPesquisar : Form
    {
        public ResponsaveisCtr controller;
        public Aluno instanciaAluno;
        public Responsavel instancia;
        public int id_selecionado;

        public frmResponsaveisPesquisar(Aluno alunoSelecionado)
        {
            InitializeComponent();

            instanciaAluno = alunoSelecionado;

            controller = new ResponsaveisCtr();
            IniciallizarControles();
        }

        private void IniciallizarControles()
        {
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            id_selecionado = 0;
        }

        private void atualizarGridView(DataTable dt)
        {
            dgvResponsaveis.DataSource = dt;
            dgvResponsaveis.Refresh();
        }

        private void EstadoSelecionando()
        {
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new frmResponsaveisCadastrar(controller, instanciaAluno, 0).ShowDialog();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if(id_selecionado > 0)
            {
                new frmResponsaveisCadastrar(controller, instanciaAluno, id_selecionado).ShowDialog();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            IniciallizarControles();

            DataTable dt = controller.Pesquisar(txtNome.Text.Trim(), instanciaAluno);
            if (dt.Rows.Count > 0)
            {
                atualizarGridView(dt);
            }
            else
            {
                MessageBox.Show("Não foi encontrado nenhum responsável como resultado",
                    "School - Nenhum Resultado Encontrado.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvResponsaveis_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string responsavelSelecionado = dgvResponsaveis.Rows[e.RowIndex].Cells[1].Value.ToString();

            String mensagem = String
                                .Format("O responsável '{0}' foi selecionado. Deseja confirmar a seleção? ",
                                responsavelSelecionado);
            string titulo = "Confirmar seleção";

            DialogResult confirmacao = MessageBox.Show(
                mensagem,
                titulo,
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1
             );

            if (confirmacao == DialogResult.OK)
            {
                id_selecionado = int.Parse(dgvResponsaveis.Rows[e.RowIndex].Cells[0].Value.ToString());
                EstadoSelecionando();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (id_selecionado > 0)
            {
               
            }
        }
    }
}
