using SchoolAdmin.Control;
using SchoolAdmin.Model;
using SchoolAdmin.Util.Validators;
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
        FuncionarioCtr controller;
        Funcionario instancia; 
        string salario;

        public frmFuncionariosCadastrar(FuncionarioCtr ctr)
        {
            InitializeComponent();

            controller = ctr;
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

            instancia = controller.getInstance();
        }


        private void ValidarDados()
        {
            bool erro = false;
            string msgErro = "";
            string titErro = "";

            StringValidator STRvalidator = new StringValidator();
            RGValidator RGvalidator = new RGValidator();
            CPFValidator CPFvalidator = new CPFValidator();

            if (!STRvalidator.Validar(txtNome.Text, 64))
            {
                erro = true;
                titErro = "Erro, nome do funcionário não informado corretamente!";
                msgErro = "Informe o nome do funcionário para prosseguir com o cadastro.";
                txtNome.Focus();
            }
            else if (dtpDataNascimento.Value.Date >= DateTime.Today)
            {
                erro = true;
                titErro = "Erro, data de nascimento inválida!";
                msgErro = "Informe uma data de nascimento válida para prosseguir com o cadastro.";
                dtpDataNascimento.Focus();
            }
            else if (cbbSexo.SelectedIndex == -1)
            {
                erro = true;
                titErro = "Erro, sexo não informado!";
                msgErro = "Selecione o sexo do funcionário para prosseguir com o cadastro.";
                cbbSexo.Focus();
            }
            else if (!RGValidator.Validar(txtRG.Text.Trim()))
            {
                erro = true;
                titErro = "Erro, RG inválido!";
                msgErro = "Informe um RG válido para prosseguir com o cadastro.";
                txtRG.Focus();
            }
            else if (!CPFvalidator.Validar(txtCPF.Text))
            {
                erro = true;
                titErro = "Erro, CPF inválido!";
                msgErro = "Informe um CPF válido para prosseguir com o cadastro.";
                txtRG.Focus();
            }


            if (erro)
            {
                MessageBox.Show(msgErro,
                                titErro,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            //string nome, rg, cpf, telefone, telefone2, email, salario, observacoes;
            //DateTime dataNascimento, dataAdmissao, dataDemissao;
            //char sexo, cargo;

            //nome = txtNome.Text;

            //dataNascimento = dtpDataNascimento.Value;
            //rg = txtRG.Text;
            //cpf = txtCPF.Text;
            //telefone = txtTelefone1.Text;
            //telefone2 = txtTelefone2.Text;
            //email = txtEmail.Text;
            //salario = txtSalario.Text;
            //dataAdmissao = dtpAdmissao.Value;
            //dataDemissao = dtpDemissao.Value;
            //observacoes = txtObservacoes.Text;

            //if (cbbSexo.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Selecione o sexo do funcionário para prosseguir com o cadastro.",
            //                    "Erro, sexo não informado!",
            //                    MessageBoxButtons.OK,
            //                    MessageBoxIcon.Error);
            //    cbbSexo.Focus();
            //}
            //else
            //{
            //    sexo = (char)cbbSexo.SelectedValue;
            //}

            //if (cbbCargo.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Selecione o cargo exercido pelo funcionário para prosseguir com o cadastro.",
            //                    "Erro, cargo não informado!",
            //                    MessageBoxButtons.OK,
            //                    MessageBoxIcon.Error);
            //    cbbCargo.Focus();
            //}
            //else
            //{
            //    cargo = (char)cbbCargo.SelectedValue;
            //}

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

        #region Máscara de dinheiro para txtSalario
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
        #endregion
    }
}
