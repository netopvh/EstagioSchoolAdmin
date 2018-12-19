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
    public partial class frmFuncionariosCadastrar : Form
    {
        string salario;

        public frmFuncionariosCadastrar()
        {
            InitializeComponent();

            CarregarComboboxs();
            InicializarControles();
        }

        private void CarregarComboboxs()
        {
            Dictionary<string, char> dict = new Dictionary<string, char>();
            dict.Add("MASCULINO", 'M');
            dict.Add("FEMININO", 'F');
            cbbSexo.DisplayMember = "Key";
            cbbSexo.ValueMember = "Value";

            cbbSexo.DataSource = dict.ToList();

            Dictionary<string, char> dict2 = new Dictionary<string, char>();
            dict2.Add("PROFESSOR", 'P');
            dict2.Add("AUXILIAR", 'A');
            cbbCargo.DisplayMember = "Key";
            cbbCargo.ValueMember = "Value";

            cbbCargo.DataSource = dict2.ToList();
        }

        private void InicializarControles()
        {
            txtNome.Clear();
            dtpDataNascimento.Value = DateTime.Now;
            cbbSexo.SelectedIndex = -1;
            txtRG.Clear();
            txtCPF.Clear();
            btnEndereco.Enabled = false;
            txtTelefone1.Clear();
            txtTelefone2.Clear();
            txtEmail.Clear();
            cbbCargo.SelectedIndex = -1;
            txtSalario.Clear();
            dtpAdmissao.Value = DateTime.Now;
            dtpDemissao.Value = DateTime.Now;
            dtpDemissao.Enabled = false;
            txtObservacoes.Clear();

            txtRG.Mask = "00.000.000 - 0";
            txtCPF.Mask = "000.000.000 - 00";
            txtTelefone1.Mask = "(99) 00000 - 0000";
            txtTelefone2.Mask = "(99) 00000 - 0000";

            btnNovo.Focus();
            btnExcluir.Enabled = false;
            
        }

        private void ValidarDados()
        {
            string nome, rg, cpf, telefone, telefone2, email, salario, observacoes;
            DateTime dataNascimento, dataAdmissao, dataDemissao;
            char sexo, cargo;

            nome = txtNome.Text;
            dataNascimento = dtpDataNascimento.Value;
            sexo = (char)cbbSexo.SelectedValue;
            rg = txtRG.Text;
            cpf = txtCPF.Text;
            telefone = txtTelefone1.Text;
            telefone2 = txtTelefone2.Text;
            email = txtEmail.Text;
            cargo = (char)cbbCargo.SelectedValue;
            salario = txtSalario.Text;
            dataAdmissao = dtpAdmissao.Value;
            dataDemissao = dtpDemissao.Value;
            observacoes = txtObservacoes.Text;

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            InicializarControles();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            ValidarDados();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            new frmFuncionariosPesquisar().ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txtSalario.Text.Contains(","));
                }
                else
                    e.Handled = true;
            }
        }

        private void txtSalario_Leave(object sender, EventArgs e)
        {
            salario = txtSalario.Text.Replace("R$", "");
            
            try
            {
                txtSalario.Text = string.Format("{0:C}", Convert.ToDouble(salario));
            }
            catch
            {
                txtSalario.Clear();
            }
        }

        private void txtSalario_KeyUp(object sender, KeyEventArgs e)
        {
            salario = txtSalario.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");

            if(salario.Length == 0)
            {
                txtSalario.Text = "0,00" + salario;
            }
            if(salario.Length == 1)
            {
                txtSalario.Text = "0,0" + salario;
            }
            if (salario.Length == 2)
            {
                txtSalario.Text = "0," + salario;
            }
            else if(salario.Length >= 3)
            {
                if(txtSalario.Text.StartsWith("0,"))
                {
                    txtSalario.Text = salario.Insert(salario.Length - 2, ",").Replace("0,", "");
                }
                else if(txtSalario.Text.Contains("00,"))
                {
                    txtSalario.Text = salario.Insert(salario.Length - 2, ",").Replace("00,", "");
                }
                else
                {
                    txtSalario.Text = salario.Insert(salario.Length - 2, ",");
                }
            }

            salario = txtSalario.Text;
            txtSalario.Text = string.Format("{0:C}", Convert.ToDouble(salario));
            txtSalario.Select(txtSalario.Text.Length, 0);
        }
    }
}
