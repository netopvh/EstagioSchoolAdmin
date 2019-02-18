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

            pnl2.BackColor = System.Drawing.ColorTranslator.FromHtml("#BBBDC0");

            btnFuncionarios.BackColor = System.Drawing.ColorTranslator.FromHtml("#56DEA7");
            btnAlunos.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF7659");
            btnFinanceiro.BackColor = System.Drawing.ColorTranslator.FromHtml("#F8CD36");

            Left = Top = 0;
            Width = w;
            Height = h;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#393d4b");
            this.btnClose.Location = new Point(w-80, 3);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            new frmMenuFinanceiro().ShowDialog();
        }
    }
}
