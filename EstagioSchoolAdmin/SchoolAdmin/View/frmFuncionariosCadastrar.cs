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
using System.ComponentModel.DataAnnotations;

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

            cbbCargo.ValueMember = "Id";
            cbbCargo.DisplayMember = "Cargo";
            cbbCargo.DataSource = controller.GetListaCargos();
            cbbCargo.DropDownStyle = ComboBoxStyle.DropDownList;
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
            chkDemissao.Enabled = false;
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

        private bool ValidarDados()
        {
            bool erro = false;
            string msgErro = "";
            string titErro = "";

            StringValidator STRvalidator = new StringValidator();
            RGValidator RGvalidator = new RGValidator();
            CPFValidator CPFvalidator = new CPFValidator();
            TelefoneValidator Telvalidator = new TelefoneValidator();
            DinheiroValidator Dinvalidator = new DinheiroValidator();

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
                txtCPF.Focus();
            }
            else if (!Telvalidator.Validar(txtTelefone1.Text))
            {
                erro = true;
                titErro = "Erro, Telefone (1) inválido!";
                msgErro = "Informe um Telefone válido para prosseguir com o cadastro.";
                txtTelefone1.Focus();
            }
            else if (txtTelefone2.Text.Replace("-", "").Replace(" ", "").
                        Replace("(", "").Replace(")", "").Trim().Length > 0 
                        && !Telvalidator.Validar(txtTelefone2.Text))
            {   // Telefone 2 opcional, validar caso seja informado.
                erro = true;
                titErro = "Erro, Telefone (2) inválido!";
                msgErro = "Informe um Telefone válido para prosseguir com o cadastro.";
                txtTelefone2.Focus();
            }
            else if(txtEmail.Text.Length > 0 && !(new EmailAddressAttribute().IsValid(txtEmail.Text.Trim())))
            {
                erro = true;
                titErro = "Erro, E-mail informado é inválido!";
                msgErro = "Informe um E-mail válido para prosseguir com o cadastro.";
                txtEmail.Focus();
            }
            else if (cbbCargo.SelectedIndex == -1)
            {
                erro = true;
                titErro = "Erro, cargo não informado!";
                msgErro = "Selecione o cargo do funcionário para prosseguir com o cadastro.";
                cbbCargo.Focus();
            }
            else if(!Dinvalidator.Validar(txtSalario.Text))
            {
                erro = true;
                titErro = "Erro, salário inválido!";
                msgErro = "Informe um valor de salário válido para prosseguir com o cadastro.";
                txtSalario.Focus();
            }
            else if (dtpAdmissao.Value.Date > DateTime.Today)
            {
                erro = true;
                titErro = "Erro, data de admissão inválida!";
                msgErro = "Informe uma data de admissão válida para prosseguir com o cadastro.";
                dtpAdmissao.Focus();
            }
            
            // Validação de dados para funcionários já cadastrados.
            if (instancia.Id != 0)
            {
                if(chkDemissao.Checked && dtpDemissao.Value.Date > DateTime.Today)
                {
                    erro = true;
                    titErro = "Erro, data de demissão inválida!";
                    msgErro = "Informe uma data de demissão válida para prosseguir com o cadastro.";
                    dtpDemissao.Focus();
                }
            }
            

            if (erro)
            {
                MessageBox.Show(msgErro,
                                titErro,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            return !erro;
        }

        private void CarregarDados()
        {
            txtNome.Text = instancia.Nome;
            dtpDataNascimento.Value = instancia.DataNascimento;
            cbbSexo.SelectedIndex = instancia.Sexo.Equals("m") ? 0 : 1;
            txtRG.Text = instancia.Rg;
            txtCPF.Text = instancia.Cpf;
            txtEmail.Text = instancia.Email;
            cbbCargo.SelectedItem = instancia.Cargo;
            txtSalario.Text = instancia.Salario.ToString();
            dtpAdmissao.Value = instancia.Admissao;
            txtObservacoes.Text = instancia.Observacoes;
            chkDemissao.Enabled = true;

            // Funcionário com demissão registrada.
            if(!instancia.Desligamento.Equals(new DateTime()))
            {
                chkDemissao.Checked = true;
                dtpDemissao.Value = instancia.Desligamento;
                dtpDemissao.Enabled = true;
            }
            else
            {
                chkDemissao.Checked = false;
                dtpDemissao.ResetText();
                dtpDemissao.Enabled = false;
            }

            txtSalario.Focus();
            txtNome.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            InicializarControles();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (ValidarDados())
            {
                instancia.Nome = txtNome.Text;
                instancia.Sexo = cbbSexo.SelectedValue.ToString();
                instancia.DataNascimento = dtpDataNascimento.Value;
                instancia.Rg = txtRG.Text;

                instancia.Cpf = txtCPF.Text;
                instancia.Email = txtEmail.Text;
                instancia.Salario = GetTxtSalarioValue();
                instancia.Admissao = dtpAdmissao.Value;
                instancia.Observacoes = txtObservacoes.Text.Trim();

                instancia.Cargo = (CargoFuncionario)cbbCargo.SelectedItem;

                if (instancia.Id != 0 && chkDemissao.Checked)
                {
                    instancia.Desligamento = dtpDemissao.Value;
                }

                controller.Gravar(instancia);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            using(var formPesquisar = new frmFuncionariosPesquisar(controller))
            {
                formPesquisar.ShowDialog();
                if(formPesquisar.confirmacao == DialogResult.OK)
                {
                    instancia = controller.GetFuncionarioById(formPesquisar.id_selecionado);
                    CarregarDados();
                }
                else
                {
                    MessageBox.Show(
                        "Atenção, nenhum funcionário foi selecionado para alteração de dados.",
                        "Nenhum Funcionário Selecionado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Máscara de dinheiro para txtSalario
        private Decimal GetTxtSalarioValue()
        {
            string strSalario = txtSalario.Text.Replace("R$", "").Trim();
            return Decimal.Parse(strSalario);
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
        #endregion

        private void chkDemissao_CheckedChanged(object sender, EventArgs e)
        {
            if(chkDemissao.Checked)
            {
                dtpDemissao.Enabled = true;
            }
            else
            {
                dtpDemissao.Enabled = false;
            }
        }
    }
}
