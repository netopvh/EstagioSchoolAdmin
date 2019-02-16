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
    public partial class frmResponsaveisCadastrar : Form
    {
        public ResponsaveisCtr controller;
        public Responsavel instancia;
        public Aluno instanciaAluno;
        public Telefone telefoneObrigatorio;
        public Telefone telefoneOpcional;
        public Telefone telefoneTrabalho;

        public frmResponsaveisCadastrar(ResponsaveisCtr ctr, Aluno alunoSelecionado)
        {
            InitializeComponent();

            instanciaAluno = alunoSelecionado;

            controller = ctr;
            CarregarComboboxs();
            InicializarControles();
        }

        private void CarregarComboboxs()
        {
            Dictionary<string, char> dictSexo = new Dictionary<string, char>();
            dictSexo.Add("MASCULINO", 'M');
            dictSexo.Add("FEMININO", 'F');

            cbbSexo.DisplayMember = "Key";
            cbbSexo.ValueMember = "Value";
            cbbSexo.DataSource = dictSexo.ToList();


            Dictionary<string, char> dictParentesco = new Dictionary<string, char>();
            dictParentesco.Add("PAI", 'P');
            dictParentesco.Add("MÃE", 'M');
            dictParentesco.Add("AVÔ/AVÓ", 'A');

            cbbParentesco.DisplayMember = "Key";
            cbbParentesco.ValueMember = "Value";
            cbbParentesco.DataSource = dictParentesco.ToList();


            Dictionary<string, char> dictEstadoCivil = new Dictionary<string, char>();
            dictEstadoCivil.Add("SOLTEIRO", '1');
            dictEstadoCivil.Add("CASADO", '2');
            dictEstadoCivil.Add("SEPARADO", '3');
            dictEstadoCivil.Add("DIVORCIADO", '4');
            dictEstadoCivil.Add("VIÚVO", '5');

            cbbEstadoCivil.DisplayMember = "Key";
            cbbEstadoCivil.ValueMember = "Value";
            cbbEstadoCivil.DataSource = dictEstadoCivil.ToList();
        }

        private void InicializarControles()
        {
            txtNome.Clear();
            cbbSexo.SelectedIndex = -1;
            cbbParentesco.SelectedIndex = -1;
            ckbOutroParentesco.Checked = false;
            txtOutroParentesco.Clear();
            txtOutroParentesco.Enabled = false;
            cbbEstadoCivil.SelectedIndex = -1;
            txtNomeConjuge.Clear();
            txtCPF.Clear();
            txtRG.Clear();
            ckbEndereco.Checked = false;
            ckbEndereco.Enabled = false;
            btnCadastrarEndereco.Enabled = false;
            txtProfissao.Clear();
            btnEnderecoTrabalho.Enabled = false;
            txtTelefone1.Clear();
            txtTelefone2.Clear();
            txtTelefoneTrabalho.Clear();

            txtRG.Mask = "00.000.000 - 0";
            txtCPF.Mask = "000.000.000 - 00";

            txtTelefone1.Mask = "(99) 00000 - 0000";
            txtTelefone2.Mask = "(99) 00000 - 0000";
            txtTelefoneTrabalho.Mask = "(99) 00000 - 0000";

            instancia = controller.GetInstancia();
            telefoneObrigatorio = new Telefone();
            telefoneOpcional = new Telefone();
            telefoneTrabalho = new Telefone();
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

            if (!STRvalidator.Validar(txtNome.Text, 64))
            {
                erro = true;
                titErro = "Erro, nome do responsável não informado corretamente!";
                msgErro = "Informe o nome do responsável para prosseguir com o cadastro.";
                txtNome.Focus();
            }
            else if (cbbSexo.SelectedIndex == -1)
            {
                erro = true;
                titErro = "Erro, sexo não informado!";
                msgErro = "Selecione o sexo do responsável para prosseguir com o cadastro.";
                cbbSexo.Focus();
            }
            else if (!ckbOutroParentesco.Checked && cbbParentesco.SelectedIndex == -1)
            {
                erro = true;
                titErro = "Erro, parentesco não informado!";
                msgErro = "Selecione o parentesco do responsável para prosseguir com o cadastro.";
                cbbSexo.Focus();
            }
            else if (ckbOutroParentesco.Checked && !STRvalidator.Validar(txtOutroParentesco.Text, 64))
            {
                erro = true;
                titErro = "Erro, parentesco não informado!";
                msgErro = "Informe o parentesco do responsável para prosseguir com o cadastro.";
                txtOutroParentesco.Focus();
            }
            else if (cbbEstadoCivil.SelectedIndex == -1)
            {
                erro = true;
                titErro = "Erro, estado civil não informado!";
                msgErro = "Selecione o estado civil do responsável para prosseguir com o cadastro.";
                cbbEstadoCivil.Focus();
            }
            else if (txtNomeConjuge.Text.Trim().Length > 0 && !STRvalidator.Validar(txtNomeConjuge.Text, 64))
            {
                erro = true;
                titErro = "Erro, nome do cônjuge não informado corretamente!";
                msgErro = "Informe o nome do cônjuge corretamente para prosseguir com o cadastro.";
                txtNome.Focus();
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
            else if (txtProfissao.Text.Trim().Length > 0 && !STRvalidator.Validar(txtProfissao.Text, 64))
            {
                erro = true;
                titErro = "Erro, profissão não informada corretamente!";
                msgErro = "Informe o nome da profissão corretamente para prosseguir com o cadastro.";
                txtNome.Focus();
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
            else if (txtTelefoneTrabalho.Text.Replace("-", "").Replace(" ", "").
                        Replace("(", "").Replace(")", "").Trim().Length > 0
                        && !Telvalidator.Validar(txtTelefoneTrabalho.Text))
            {   // Telefone 2 opcional, validar caso seja informado.
                erro = true;
                titErro = "Erro, Telefone do trabalho inválido!";
                msgErro = "Informe um Telefone válido para prosseguir com o cadastro.";
                txtTelefone2.Focus();
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

        public string getTelefoneValue(string telefone)
        {
            return telefone.Replace("-", "").Replace(" ", "").Replace("(", "").Replace(")", "").Trim();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (ValidarDados())
            {
                instancia.Nome = txtNome.Text;
                instancia.Sexo = cbbSexo.SelectedValue.ToString();
                instancia.Rg = txtRG.Text;

                if(ckbOutroParentesco.Checked)
                {
                    instancia.Parentesco = "";
                    instancia.OutroParentesco = txtOutroParentesco.Text.Trim();
                }
                else
                {
                    instancia.Parentesco = cbbParentesco.SelectedValue.ToString();
                    instancia.OutroParentesco = "";
                }
                instancia.EstadoCivil = cbbEstadoCivil.SelectedValue.ToString();
                instancia.NomeConjuge = txtNomeConjuge.Text.Trim();
                instancia.CPF = txtCPF.Text.Trim();
                instancia.Rg = txtCPF.Text.Trim();
                instancia.MoraMesmoEnderecoAluno = ckbEndereco.Checked;
                instancia.Profissao = txtProfissao.Text.Trim();

                telefoneObrigatorio.Numero = getTelefoneValue(txtTelefone1.Text);
                telefoneOpcional.Numero = getTelefoneValue(txtTelefone2.Text);
                telefoneTrabalho.Numero = getTelefoneValue(txtTelefoneTrabalho.Text);


                if (controller.Gravar(instancia, instanciaAluno, telefoneObrigatorio, telefoneOpcional, telefoneTrabalho))
                {
                    MessageBox.Show(
                        "Gravação realizada com sucesso. Todos os dados foram salvos.",
                        "Gravação realizada",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    InicializarControles();
                }

            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ckbEndereco_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbEndereco.Checked)
            {
                btnCadastrarEndereco.Enabled = true;
            }
            else
            {
                btnCadastrarEndereco.Enabled = false;
            }
        }

        private void ckbOutroParentesco_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbOutroParentesco.Checked)
            {
                txtOutroParentesco.Enabled = true;
            }
            else
            {
                txtOutroParentesco.Enabled = false;
            }
        }
    }
}
