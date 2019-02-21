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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }


        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string mensagem = "Deseja encerrar a aplicação?";
            const string titulo = "Encerrar a aplicação";
            var result = MessageBox.Show(mensagem, titulo,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            new frmFuncionariosCadastrar(new FuncionarioCtr()).ShowDialog();
        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            new frmAlunosCadastrar(new AlunosCtr()).ShowDialog();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.WorkingArea.Width;
            int h = Screen.PrimaryScreen.WorkingArea.Height;

            pnlTop.BackColor = System.Drawing.ColorTranslator.FromHtml("#168BDB");

            btnFuncionarios.BackColor = System.Drawing.ColorTranslator.FromHtml("#168BDB");
            btnAlunos.BackColor = System.Drawing.ColorTranslator.FromHtml("#168BDB");
            btnFinanceiro.BackColor = System.Drawing.ColorTranslator.FromHtml("#168BDB");

            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            new frmMenuFinanceiro().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmGerenciarNecessidadesEspeciais(new NecessidadesCtr()).ShowDialog();
        }
    }
}
