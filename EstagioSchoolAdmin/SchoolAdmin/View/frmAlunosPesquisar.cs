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
    public partial class frmAlunosPesquisar : Form
    {
        private AlunosCtr controller;
        public int id_selecionado;
        public DialogResult confirmacao;

        public frmAlunosPesquisar(AlunosCtr ctr)
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
                MessageBox.Show("Não foi encontrado nenhum aluno como resultado",
                    "School - Nenhum Resultado Encontrado.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void atualizarGridView(DataTable dt)
        {
            dgvAlunos.DataSource = dt;
            dgvAlunos.Refresh();
        }

        private void dgvAlunos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string alunoSelecionado = dgvAlunos.Rows[e.RowIndex].Cells[1].Value.ToString();

            String mensagem = String
                               .Format("O aluno '{0}' foi selecionado.Deseja confirmar a seleção? ",
                               alunoSelecionado);
            string titulo = "Confirmar seleção";

            confirmacao = MessageBox.Show(
                mensagem,
                titulo,
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1
             );

            if (confirmacao == DialogResult.OK)
            {
                id_selecionado = int.Parse(dgvAlunos.Rows[e.RowIndex].Cells[0].Value.ToString());
                this.Close();
            }
        }
    }
}
