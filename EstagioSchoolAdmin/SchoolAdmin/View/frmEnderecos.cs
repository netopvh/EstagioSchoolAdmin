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
    public partial class frmEnderecos : Form
    {
        public frmEnderecos()
        {
            InitializeComponent();
            InicializarControles();
        }

        private void InicializarControles()
        {
            txtRua.Clear();
            txtNumero.Value = 0;
            txtComplemento.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            cbbEstados.SelectedIndex = -1;
            txtCep.Clear();

            txtCep.Mask = "00000 - 000";
        }
    }
}
