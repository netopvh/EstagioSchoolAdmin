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
        }

        private void atualizarGridView(DataTable dt)
        {
            dgvAlunos.DataSource = dt;
            dgvAlunos.Refresh();
        }

    }
}
