using SchoolAdmin.Control;
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
    public partial class frmFuncionariosPesquisar : Form
    {
        FuncionarioCtr controller;

        public frmFuncionariosPesquisar(FuncionarioCtr ctr)
        {
            InitializeComponent();
            controller = ctr;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            DataTable dt = controller.Pesquisar(txtNome.Text.Trim());
            if (dt.Rows.Count > 0)
            {
                atualizarGridView(dt);
            }
            else
            {
                MessageBox.Show("Não foi encontrado nenhum funcionário como resultado",
                    "School - Nenhum Resultado Encontrado.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void atualizarGridView(DataTable dt)
        {
            dgvFuncionarios.DataSource = dt;
            dgvFuncionarios.Refresh();
        }

        private void dgvFuncionarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string funcionarioSelecionado = dgvFuncionarios.Rows[e.RowIndex].Cells[1].Value.ToString();

            String mensagem = String
                                .Format("O funcionário {0} foi selecionado.Deseja confirmar a seleção? ", 
                                funcionarioSelecionado);
            string titulo = "Confirmar seleção";

            var confirmacao = MessageBox.Show(
                mensagem, 
                titulo,
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question, 
                MessageBoxDefaultButton.Button1
             );

            if (confirmacao == DialogResult.OK)
            {
                var idSelecionado = dgvFuncionarios.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.Close();
            }
        }
    }
}
