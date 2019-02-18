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
    public partial class frmMenuFinanceiro : Form
    {
        public frmMenuFinanceiro()
        {
            InitializeComponent();
        }

        private void btnLancarContasPagar_Click(object sender, EventArgs e)
        {
            new frmLancarContasAPagar(new ContaPagarCtr()).ShowDialog();
        }

        private void btnQuitarContasPagar_Click(object sender, EventArgs e)
        {
            new frmQuitarContasAPagar(new ContaPagarCtr()).ShowDialog();
        }
    }
}
