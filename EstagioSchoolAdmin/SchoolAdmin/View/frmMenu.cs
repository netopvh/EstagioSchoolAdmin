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

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
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

        private void btnContasPagar_Click(object sender, EventArgs e)
        {
            new frmLancarContasAPagar(new ContaPagarCtr()).ShowDialog();
        }
    }
}
