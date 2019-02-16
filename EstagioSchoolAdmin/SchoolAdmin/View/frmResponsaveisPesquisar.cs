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
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new frmResponsaveisCadastrar(controller, instanciaAluno).ShowDialog();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            new frmResponsaveisCadastrar(controller, instanciaAluno).ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
